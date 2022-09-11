Imports System.Data.OleDb
Imports System.Data

Public Class frmTransLog
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Dim cmdSel As String
    Dim txtbox As New TextBox
    Dim cbbox As New ComboBox
    Dim dPicker As New DateTimePicker

    Private Sub frmTransLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub
    Private Sub reload()
        getTransLog("Select * from qryTransaction")
    End Sub

    Private Sub getTransLog(ByVal strCmd As String)
        Dim dtTransLog As New DataTable
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdSel As New OleDbCommand(strCmd, conn)
                Using daCmdSel As New OleDbDataAdapter(cmdSel)
                    daCmdSel.Fill(dtTransLog)
                    dgvTransLog.DataSource = dtTransLog
                End Using
            End Using
            conn.Close()
        End Using

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmHome.Visible = True
    End Sub

    Private Sub getFilterOption()

    End Sub

    Private Sub cbOption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOption.SelectionChangeCommitted
        If cbOption.SelectedIndex = 0 Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(txtbox)

        ElseIf cbOption.SelectedIndex = 4 Then
            Panel1.Controls.Clear()
            Panel1.Controls.Add(dPicker)
        Else
            Panel1.Controls.Clear()
            Panel1.Controls.Add(cbbox)
            If cbOption.SelectedIndex = 1 Then
                cbboxOption("Select distinct(RoomType) from qryTransaction", "RoomType")
            ElseIf cbOption.SelectedIndex = 2 Then
                cbboxOption("Select distinct(RoomNum) from qryTransaction", "RoomNum")
            ElseIf cbOption.SelectedIndex = 3 Then
                cbboxOption("Select distinct(Action) from qryTransaction", "Action")
            End If
        End If

    End Sub
    Private Sub cbboxOption(ByVal strCmd As String, ByVal cbDisplay As String)
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdSel As New OleDbCommand(strCmd, conn)
                Using daCmd As New OleDbDataAdapter(cmdSel)
                    Dim dtcombo As New DataTable
                    daCmd.Fill(dtcombo)
                    cbbox.DataSource = dtcombo

                    If dtcombo.Rows.Count > 0 Then
                        cbbox.DataSource = dtcombo
                        cbbox.ValueMember = cbDisplay
                        cbbox.DisplayMember = cbDisplay
                    End If
                End Using
            End Using
        End Using



    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Try
            If cbOption.SelectedIndex = 0 Then
                getTransLog("Select * from qryTransaction where CustomerName like '%" & txtbox.Text & "%';")
            ElseIf cbOption.SelectedIndex = 4 Then
                Dim selDate As Date = Convert.ToDateTime(Format(dPicker.Value, "MM/dd/yyyy"))
                getTransLog("Select * from qryTransaction where DateValue(UpdatedDate)=#" & selDate & "#;")
            Else
                Dim strTable As String = cbOption.SelectedItem
                Dim strValue As String = cbbox.SelectedValue.ToString
                getTransLog("Select * from qryTransaction where " & strTable & "='" & strValue & "';")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class