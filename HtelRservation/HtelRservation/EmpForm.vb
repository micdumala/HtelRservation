Imports System.Data.OleDb
Imports System.Data

Public Class frmEmployee
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub
    Private Sub reload()
        getEmpList()
        btnSave.Enabled = False
        rbUser.Focus()
    End Sub
    Private Sub clearTxt()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
        rbUser.Focus()
    End Sub

    Private Sub getEmpList()
        Dim dtEmp As New DataTable

        Using conn As New OleDbConnection(connString)
            Using cmdSelEmp As New OleDbCommand("Select * from tblEmployee", conn)
                Using daEmpl As New OleDbDataAdapter(cmdSelEmp)
                    conn.Open()
                    daEmpl.Fill(dtEmp)
                    conn.Close()
                End Using
            End Using
        End Using
        dgvEmp.DataSource = dtEmp

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtFirstName.Text = dgvEmp.CurrentRow.Cells(1).Value
        txtLastName.Text = dgvEmp.CurrentRow.Cells(2).Value
        txtUser.Text = dgvEmp.CurrentRow.Cells(3).Value
        txtPassword.Text = dgvEmp.CurrentRow.Cells(5).Value
        If dgvEmp.CurrentRow.Cells(6).Value = "admin" Then
            rbAdmin.Checked = True
        Else
            rbUser.Checked = True
        End If
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim empType As String
        If rbAdmin.Checked = True Then
            empType = "admin"
        Else
            empType = "user"
        End If

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdUpd As New OleDbCommand("Update tblEmployee set FirstName=@first, LastName=@last, Username=@user, UpdatedDate=@updDate,`Password`=@pssword ,EmployeeType=@empType where EmpID=@id", conn)
                cmdUpd.Parameters.AddWithValue("@first", txtFirstName.Text)
                cmdUpd.Parameters.AddWithValue("@last", txtLastName.Text)
                cmdUpd.Parameters.AddWithValue("@user", txtUser.Text)
                cmdUpd.Parameters.AddWithValue("@updDate", Convert.ToDateTime(Format(Now(), "MM/dd/yyyy h:mm:ss tt")))
                cmdUpd.Parameters.AddWithValue("@pssword", txtPassword.Text)
                cmdUpd.Parameters.AddWithValue("@empType", empType)
                cmdUpd.Parameters.AddWithValue("@id", dgvEmp.CurrentRow.Cells(0).Value)
                cmdUpd.ExecuteNonQuery()
                frmHome.insertUserLog("Edit", "Employee")
            End Using
            conn.Close()
        End Using
        getEmpList()
        clearTxt()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = Nothing Or txtFirstName.Text = Nothing Or txtUser.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Incomplete registered details", vbInformation, "Incomplete")
        Else
            Dim empType As String
            If rbAdmin.Checked = True Then
                empType = "admin"
            Else
                empType = "user"
            End If

            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmdUpd As New OleDbCommand("Insert into tblEmployee(FirstName,Lastname,Username,UpdatedDate,`Password`,EmployeeType) values(@first,@last,@user,@updDate,@pssword,@empType)", conn)
                    cmdUpd.Parameters.AddWithValue("@first", txtFirstName.Text)
                    cmdUpd.Parameters.AddWithValue("@last", txtLastName.Text)
                    cmdUpd.Parameters.AddWithValue("@user", txtUser.Text)
                    cmdUpd.Parameters.AddWithValue("@updDate", Convert.ToDateTime(Format(Now(), "MM/dd/yyyy h:mm:ss tt")))
                    cmdUpd.Parameters.AddWithValue("@pssword", txtPassword.Text)
                    cmdUpd.Parameters.AddWithValue("@empType", empType)
                    cmdUpd.ExecuteNonQuery()
                End Using
                conn.Close()
                frmHome.insertUserLog("Add", "Employee")
            End Using
            getEmpList()
            clearTxt()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdDel As New OleDbCommand("Delete from tblEmployee where EmpId=@id", conn)
                cmdDel.Parameters.AddWithValue("@id", dgvEmp.CurrentRow.Cells(0).Value)
                cmdDel.ExecuteNonQuery()
                frmHome.insertUserLog("Delete", "Employee")
                reload()
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class