Public Class Openpage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 10
        Label3.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            Me.Hide()
            Login.Show()
            ProgressBar1.Value = 0
        End If
    End Sub
End Class
