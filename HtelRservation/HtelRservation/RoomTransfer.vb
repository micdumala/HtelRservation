Imports System.Data.OleDb
Imports System.Data

Public Class frmRoomTrans
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Public roomNum, rnNum As Integer
    Public custName As String
    Public checkDate As Date

    Private Sub frmRoomTrans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        reload()

    End Sub
    Private Sub reload()
        getRooms("Select * from tblRoomList where RoomStatus=0")
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmRoomList.Show()
    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        rnNum = dgvRoomList.CurrentRow.Cells(0).Value
        frmHome.insertUserLog("Transfer", "Room List")
        frmRoomList.getTransaction(custName, "Transfer", Me.rnNum)
        updateCmd(custName, True, checkDate, rnNum)
        updateCmd("", False, Nothing, roomNum)
        Me.Visible = False
        frmRoomList.reload()
        frmRoomList.Show()
    End Sub

    Private Sub updateCmd(ByVal cName As String, ByVal tRoom As Boolean, ByVal dCheck As Date, ByVal rNum As Integer)

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdUpdate As New OleDbCommand("Update tblRoomList set ClientName=@custName, RoomStatus=@status, Checkout=@checkDate where RoomNumber=@roomId", conn)
                cmdUpdate.Parameters.AddWithValue("@custName", cName)
                cmdUpdate.Parameters.AddWithValue("@status", tRoom)
                cmdUpdate.Parameters.AddWithValue("@checkDate", Convert.ToDateTime(Format(dCheck, "MM/dd/yyyy h:mm:ss tt")))
                cmdUpdate.Parameters.AddWithValue("@roomId", rNum)
                cmdUpdate.ExecuteNonQuery()
            End Using
            conn.Close()
            reload()
        End Using
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class