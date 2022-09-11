Public Class LoadingForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.PBar1.Value = PBar1.Value + 1
        If PBar1.Value >= 100 Then
            Timer1.Stop()
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class