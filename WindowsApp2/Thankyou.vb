Public Class Thankyou
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        If (ProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            Me.Close()
            Login.Show()
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Thankyou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class