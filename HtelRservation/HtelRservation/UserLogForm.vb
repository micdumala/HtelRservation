Imports System.Data.OleDb
Imports System.Data

Public Class frmUserLog
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmHome.Visible = True
    End Sub

    Private Sub frmUserLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload()
    End Sub
    Private Sub reload()
        selUserLog("Select * from qryUserLog")
    End Sub
    Private Sub selUserLog(ByVal strCmd As String)
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdSel As New OleDbCommand(strCmd, conn)
                Using daCmdSel As New OleDbDataAdapter(cmdSel)
                    Dim dtCmdSel As New DataTable
                    dtCmdSel.Clear()
                    daCmdSel.Fill(dtCmdSel)
                    dgvUserLog.DataSource = dtCmdSel
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Private Sub selDropList(ByVal cbbox As ComboBox, ByVal strCmd As String, ByVal cbDisplay As String)
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

    Private Sub cbSelCol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSelCol.SelectionChangeCommitted
        If cbSelCol.SelectedIndex > 0 Then
            Dim strCol As String = Me.cbSelCol.SelectedItem
            selDropList(cbSelValue, "Select distinct(" & strCol & ") from qryUserLog", strCol)
        Else
            cbSelValue.DataSource = Nothing
            cbSelValue.Items.Clear()
        End If

    End Sub
    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Dim selDate As Date = Convert.ToDateTime(Format(dtpUpdate.Value, "MM/dd/yyyy"))
        Try
            If cbSelCol.SelectedIndex = 0 Then
                selUserLog("Select * from qryUserLog where DateValue(ActionDate)=#" & selDate & "#;")
            Else
                Dim dateVal As Date = Convert.ToDateTime(Format(dtpUpdate.Value, "MM/dd/yyyy"))
                Dim strCol As String = cbSelCol.SelectedItem
                selUserLog("Select * from qryUserLog where " & strCol & "='" & cbSelValue.SelectedValue & "' and DateValue(ActionDate)=#" & selDate & "#;")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class