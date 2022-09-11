Imports System.Data.OleDb
Imports System.Data
Public Class frmLogin
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Dim dtEmpType As New DataTable
    Public empType As String

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Public Sub checkConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
    End Sub
    Public Sub getUser()
        Dim dsUser As New DataSet
        Dim dtcUser As DataTableCollection
        Dim daUser As New OleDbDataAdapter
        Dim cmdbUser As New OleDbCommandBuilder

        conn = New OleDbConnection
        conn.ConnectionString = connString
        dsUser = New DataSet
        dtcUser = dsUser.Tables

        checkConn()

        daUser = New OleDbDataAdapter("Select * from tblEmployee where Username='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'", conn)
        cmdbUser = New OleDbCommandBuilder(daUser)
        cmdbUser.QuotePrefix = "["
        cmdbUser.QuoteSuffix = "]"
        daUser.Fill(dsUser, "tblEmployee")
        Dim dvUser As New DataView(dtcUser(0))

    End Sub
    Public Sub checkUser()
        checkConn()
        Dim cmd As New OleDbCommand("Select count(*) from tblEmployee where Username=? and Password=?", conn)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
        Dim cnt = Convert.ToInt32(cmd.ExecuteScalar())
        If cnt > 0 Then
            getUser()
            getEmpType()
            Me.Visible = False
            frmHome.Show()
            frmHome.insertUserLog("Login", "Login")
        Else
            MsgBox("Invalid Credential", vbInformation, "Incorrect")
        End If

    End Sub
    Public Sub getEmpType()

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("Select EmployeeType, EmpID from tblEmployee where Username='" & txtUsername.Text & "'", conn)
                Using daEmpType As New OleDbDataAdapter(cmd)
                    conn.Open()
                    daEmpType.Fill(dtEmpType)
                    conn.Close()
                End Using
            End Using
        End Using
        If dtEmpType.Rows(0).Item(0) = "admin" Then
            frmHome.flpAdminControl.Visible = True
            frmRoomList.flpAdmin.Visible = True
            frmHome.flpEmpList.Visible = True
        End If
        frmHome.empId = dtEmpType.Rows(0).Item(1)
        frmRoomList.getEmpId = dtEmpType.Rows(0).Item(1)
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
                MsgBox("Please use your assign credential", vbInformation, "NO INPUT")
            Else
                checkUser()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        checkConn()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
End Class
