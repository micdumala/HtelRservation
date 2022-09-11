Imports System.Data.OleDb
Imports System.Data

Public Class frmRoomList
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Dim dtClient As New DataTable
    Public empType As String
    Public getEmpId As Integer

    Private Sub getActiveClient() 'Get Non-Reserved Customer

        Using conn As New OleDbConnection(connString)
            Using cmdSelClient As New OleDbCommand("Select * from qryCustomer", conn)
                Using daClient As New OleDbDataAdapter(cmdSelClient)
                    conn.Open()
                    daClient.Fill(dtClient)
                    conn.Close()
                End Using
            End Using
        End Using
        If dtClient.Rows.Count > 0 Then
            cbClientName.DataSource = dtClient
            cbClientName.ValueMember = "CustomerID"
            cbClientName.DisplayMember = "CustomerName"
        End If

    End Sub
    Private Sub getRooms(ByVal strCmd As String)
        Dim dtRoom As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmdSelRoom As New OleDbCommand(strCmd, conn)
                Using daRoom As New OleDbDataAdapter(cmdSelRoom)
                    conn.Open()
                    daRoom.Fill(dtRoom)
                    conn.Close()
                End Using
            End Using
        End Using
        dgvRoomList.DataSource = dtRoom

    End Sub
    Private Sub frmRoomList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getActiveClient()
        getRooms("Select * from qryRoomList")
    End Sub
    Public Sub reload()
        dtClient.Clear()
        getActiveClient()
        getRooms("Select * from qryRoomList")
    End Sub
    Private Sub btnRoomList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomList.Click
        frmHome.empType = empType
        Me.Visible = False
        frmHome.Show()
    End Sub
    Private Sub btnCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIn.Click
        Dim name As String
        Dim timeOut As Date

        If cbClientName.SelectedIndex > -1 Then
            Dim roomNum As Integer = dgvRoomList.CurrentRow.Cells(0).Value
            name = dtClient.Rows(cbClientName.SelectedIndex).Item(1)
            Dim rnStatus As Boolean = dgvRoomList.CurrentRow.Cells(3).Value

            If rnStatus = False Then
                If rbHour.Checked = True Then
                    timeOut = Now.AddHours(numDuration.Value)
                Else
                    timeOut = Now.AddDays(numDuration.Value)
                End If
                getTransaction(name, "Check In", roomNum)
                MsgBox(timeOut, vbInformation, "Checkout")
                updCustomerStatus(cbClientName.SelectedValue)
                updRoomList(name, -1, timeOut, roomNum, "In")
                frmHome.insertUserLog("CheckIn", "Room List")
            Else
                MsgBox("Room Already Occupied", vbInformation, "Not Available")
            End If
        Else
            MsgBox("No Client List Selected", vbInformation, "No Client")
        End If
    End Sub
    Private Sub updRoomList(ByVal custName As String, ByVal rnStatus As Integer, ByVal checkOut As Date, ByVal rnNum As Integer, ByVal TransType As String)

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdUpdate As New OleDbCommand("Update tblRoomList set ClientName=@name, RoomStatus=@rnStatus, Checkout=@outDate where RoomNumber=@rnNum", conn)
                cmdUpdate.Parameters.AddWithValue("@name", custName)
                cmdUpdate.Parameters.AddWithValue("@rnStatus", rnStatus)
                cmdUpdate.Parameters.AddWithValue("@outDate", Convert.ToDateTime(Format(checkOut, "MM/dd/yyyy h:mm:ss tt")))
                cmdUpdate.Parameters.AddWithValue("@rnNum", rnNum)
                cmdUpdate.ExecuteNonQuery()
                Dim Result As Integer = cmdUpdate.ExecuteNonQuery
                If TransType = "In" Then
                    If Result > 0 Then
                        MsgBox("Successflly Check In", vbInformation, "Check In")
                    End If
                ElseIf TransType = "Out" Then
                    MsgBox("Successflly Check Out", vbInformation, "Check Out")
                End If
                reload()
            End Using

        End Using

    End Sub
    Private Sub updCustomerStatus(ByVal custID As Integer)

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdUpdate As New OleDbCommand("Update tblCustomer set status=-1 where CustomerID=@id", conn)
                cmdUpdate.Parameters.AddWithValue("@id", custID)
                cmdUpdate.ExecuteNonQuery()
            End Using
        End Using

    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtClient.Clear()
        getActiveClient()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCo.Click
        Try
            Dim rnStatus As Boolean = dgvRoomList.CurrentRow.Cells(3).Value
            Dim roomNum As Integer = dgvRoomList.CurrentRow.Cells(0).Value

            If rnStatus = True Then
                Dim DateValue As Date = InputBox("Date Adjustment", "Date Adjustment", dgvRoomList.CurrentRow.Cells(4).Value)
                If IsDate(DateValue) Then
                    Using conn As New OleDbConnection(connString)
                        conn.Open()
                        Using cmdUpdateDate As New OleDbCommand("Update tblRoomList set Checkout=@checkout where RoomNumber=@rnNum", conn)
                            cmdUpdateDate.Parameters.AddWithValue("@checkout", Convert.ToDateTime(Format(DateValue, "MM/dd/yyyy h:mm:ss tt")))
                            cmdUpdateDate.Parameters.AddWithValue("@rnNum", roomNum)
                            cmdUpdateDate.ExecuteNonQuery()
                            frmHome.insertUserLog("Edit Checkout", "Room List")
                        End Using
                    End Using
                End If

            Else
                MsgBox("Room is Available", vbInformation, "Room Available")
            End If
            reload()
        Catch ex As Exception
            reload()
        End Try


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmdStrFilter As String

        If cbRoomType.SelectedIndex = -1 And cbVacant.Checked = False Then
            reload()
        ElseIf cbRoomType.SelectedIndex >= 0 And cbVacant.Checked = True Then
            cmdStrFilter = "Select * from tblRoomList where RoomType='" & cbRoomType.SelectedItem & "' and RoomStatus=0"
            getRooms(cmdStrFilter)
        Else
            cmdStrFilter = "Select * from tblRoomList where RoomType='" & cbRoomType.SelectedItem & "'"
            getRooms(cmdStrFilter)
        End If

    End Sub
    Private Sub bthCheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckOut.Click
        Dim roomNum As Integer = dgvRoomList.CurrentRow.Cells(0).Value
        Dim rnStatus As Boolean = dgvRoomList.CurrentRow.Cells(3).Value

        If rnStatus = True Then
            Dim sagot As String = MsgBox("Are you sure your want to Checkout Client?", vbOKCancel, "Check Out")
            If sagot = vbOK Then
                frmHome.insertUserLog("CheckIn", "Room List")
                getTransaction(dgvRoomList.CurrentRow.Cells(2).Value, "Check Out", roomNum)
                updRoomList("", 0, Nothing, roomNum, "Out")
            End If
        Else
            MsgBox("Room is Available", vbInformation, "No Check out")
        End If

    End Sub
    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        If dgvRoomList.CurrentRow.Cells(3).Value = True Then
            frmRoomTrans.roomNum = dgvRoomList.CurrentRow.Cells(0).Value
            frmRoomTrans.custName = dgvRoomList.CurrentRow.Cells(2).Value
            frmRoomTrans.checkDate = dgvRoomList.CurrentRow.Cells(4).Value

            Me.Visible = False
            frmRoomTrans.Show()
        Else
            MsgBox("Room is not occupied", vbInformation, "Room Available")
            reload()
        End If

    End Sub
    Private Sub Label4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
    Private Sub btnAddRoom_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click
        frmAddRoom.Show()
        frmAddRoom.intFunc = 1
        Me.Enabled = False
    End Sub

    Private Sub btnEditRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoom.Click


        If dgvRoomList.CurrentRow.Cells(3).Value = 0 Then
            frmAddRoom.Show()
            frmAddRoom.intFunc = 2
            Me.Enabled = False
            frmAddRoom.txtRoomNum.Text = dgvRoomList.CurrentRow.Cells(0).Value
            frmAddRoom.txtRoomType.Text = dgvRoomList.CurrentRow.Cells(1).Value
            getRoomId(dgvRoomList.CurrentRow.Cells(0).Value)
        Else
            MsgBox("Room not available", vbInformation, "Cannot Edit")
            reload()
        End If
    End Sub
    Private Sub getRoomId(ByVal rnRoomNum As Integer)
        Dim rnNum As Integer

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdGetRoomId As New OleDbCommand("Select RoomId from tblRoomList where RoomNumber=@rnNum", conn)
                cmdGetRoomId.Parameters.AddWithValue("@rnNum", rnRoomNum)
                Dim rdGetRom As OleDbDataReader
                rdGetRom = cmdGetRoomId.ExecuteReader
                rdGetRom.Read()
                rnNum = rdGetRom.Item(0)
                frmAddRoom.intRoomId = rnNum

            End Using

        End Using
    End Sub

    Private Sub btnDelRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRoom.Click
        Dim rnID As Integer = dgvRoomList.CurrentRow.Cells(0).Value

        If dgvRoomList.CurrentRow.Cells(3).Value = 0 Then
            Dim delMsg As String = MsgBox("You are about to delete Room. Proceed Deleting?", vbOKCancel, "Room Delete")
            If delMsg = vbOK Then
                Using conn As New OleDbConnection(connString)
                    conn.Open()
                    Using delCmd As New OleDbCommand("Delete from tblRoomList where RoomNumber=@rnId", conn)
                        delCmd.Parameters.AddWithValue("@rnId", rnID)
                        Dim delResult As String = delCmd.ExecuteNonQuery
                        If delResult > 0 Then
                            MsgBox("Room Successfully deleted", vbInformation, "Room Delete")
                            frmHome.insertUserLog("Delete Room", "Room List")
                        End If
                    End Using
                    conn.Close()
                End Using
                reload()
            End If
        Else
            MsgBox("Room not available", vbInformation, "Cannot Edit")
            reload()
        End If

    End Sub
    Public Sub getTransaction(ByVal cName As String, ByVal u_Action As String, ByVal intRoom As Integer)
        Dim empId As Integer = getEmpId

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmdInsert As New OleDbCommand("Insert into tblTransaction(EmpId, CustomerName, RoomType, RoomNum, `Action`, UpdatedDate) values (@empId, @cname, @rnType, @rnRoomNum, @act, @Upd)", conn)
                    cmdInsert.Parameters.AddWithValue("@empId", empId)
                    cmdInsert.Parameters.AddWithValue("@cname", cName)
                    cmdInsert.Parameters.AddWithValue("@rnType", dgvRoomList.CurrentRow.Cells(1).Value)
                    cmdInsert.Parameters.AddWithValue("@rnRoomNum", intRoom)
                    cmdInsert.Parameters.AddWithValue("@act", u_Action)
                    cmdInsert.Parameters.AddWithValue("@Upd", Convert.ToDateTime(Format(Now(), "MM/dd/yyyy h:mm:ss tt")))
                    cmdInsert.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

End Class
