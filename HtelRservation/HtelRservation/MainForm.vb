Imports System.Data.OleDb
Imports System.Data

Public Class frmHome
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Dim dbAdapter As OleDbDataAdapter
    Dim dbDataSet As DataSet
    Dim dbTable As DataTableCollection
    Dim cmdBuilder As New OleDbCommandBuilder
    Dim strCmd, cusGender As String
    Public empType As String
    Public empId As String
    Public Sub checkConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
    End Sub
    Public Sub getClient()
        Try
            conn = New OleDbConnection
            conn.ConnectionString = connString
            dbDataSet = New DataSet
            dbTable = dbDataSet.Tables
            checkConn()
            dbAdapter = New OleDbDataAdapter(strCmd, conn)
            cmdBuilder = New OleDbCommandBuilder(dbAdapter)
            cmdBuilder.QuotePrefix = "["
            cmdBuilder.QuoteSuffix = "]"
            dbAdapter.Fill(dbDataSet, "tblCustomer")
            Dim dvTable As New DataView(dbTable(0))
            dgvClient.DataSource = dvTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadList()
    End Sub
    Private Sub loadList()
        gbAdd.Enabled = False
        btnSave.Enabled = False
        strCmd = "Select * from tblCustomer"
        getClient()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        gbAdd.Enabled = True
        btnSave.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If rdMale.Checked = True Then
            cusGender = "Male"
        Else
            cusGender = "Female"
        End If
        insertCustomer()
        txtCustomerName.Clear()
        rdFemale.Refresh()
        rdMale.Refresh()
        txtAge.Clear()
        dtpBirthdate.Value = Now
        txtLocation.Clear()
        btnSave.Enabled = False
        loadList()
    End Sub
    Private Sub insertCustomer()
        Try
            Dim cmdInsTrans As New OleDbCommand
            Dim cmdStrTrans = "Insert into tblCustomer(`CustomerName`,`Gender`,`Age`,`Birthdate`,`Location`,`Updatedate`,`Status`) values(@cusName,@gender,@age,@bday,@location,@updatedate,@Status)"

            conn = New OleDbConnection
            conn.ConnectionString = connString
            cmdInsTrans.Connection = conn
            checkConn()
            cmdInsTrans.CommandText = cmdStrTrans
            cmdInsTrans.Parameters.AddWithValue("@cusName", txtCustomerName.Text.ToUpper)
            cmdInsTrans.Parameters.AddWithValue("@gender", cusGender.ToUpper)
            cmdInsTrans.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text))
            cmdInsTrans.Parameters.AddWithValue("@bday", Convert.ToDateTime(Format(dtpBirthdate.Value, "MM/dd/yyyy")))
            cmdInsTrans.Parameters.AddWithValue("@location", txtLocation.Text.ToUpper)
            cmdInsTrans.Parameters.AddWithValue("@updatedate", Convert.ToDateTime(Format(Now(), "MM/dd/yyyy h:mm:ss tt")))
            cmdInsTrans.Parameters.AddWithValue("@Status", 0)
            cmdInsTrans.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        loadList()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim indexRow As Integer
        Dim AnsVerif As String

        AnsVerif = MsgBox("You about delete Registered Client", vbOKCancel, "Delete Client")
        If AnsVerif = vbOK Then
            indexRow = dgvClient.CurrentRow.Cells(0).Value
            Dim cmdDel As New OleDb.OleDbCommand("Delete from tblCustomer where CustomerID=@custId", conn)
            cmdDel.Parameters.AddWithValue("@custId", indexRow)
            cmdDel.ExecuteNonQuery()
            insertUserLog("Delete", "Customer")
        End If
        loadList()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        strCmd = "Select * from tblCustomer where CustomerName like'%" & txtSearch.Text & "%'"
        getClient()

    End Sub

    Private Sub btnRoomList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomList.Click
        frmRoomList.empType = "admin"
        Me.Visible = False
        frmRoomList.Show()
    End Sub

    Private Sub btnEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        Me.Visible = False
        frmEmployee.Show()
    End Sub

    Private Sub btnLout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLout.Click
        If MsgBox("Are you sure you want to Log out?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Close application") = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(empId)
    End Sub

    Private Sub btnTransLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransLog.Click
        Me.Visible = False
        frmTransLog.Show()
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click, btnEmployee.Click, btnLout.Click, btnRoomList.Click, btnSave.Click, btnTransLog.Click, btnSearch.Click
        Dim btnName As Button = DirectCast(sender, Button)
        insertUserLog(btnName.Text.Replace("&", ""), "Customer")

    End Sub
    Public Sub insertUserLog(ByVal strName As String, ByVal affected As String)
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmd As New OleDbCommand("Insert into tblUserLog(UserId, ActionTaken,Affected, ActionDate) values(@id, @act,@affect, @actDate)", conn)
                cmd.Parameters.AddWithValue("@id", empId)
                cmd.Parameters.AddWithValue("@act", strName)
                cmd.Parameters.AddWithValue("@act", affected)
                cmd.Parameters.AddWithValue("@actDate", Convert.ToDateTime(Format(Now(), "MM/dd/yyyy h:mm:ss tt")))
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub btnUserLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLog.Click
        frmUserLog.Show()
        Me.Visible = False
    End Sub
End Class
