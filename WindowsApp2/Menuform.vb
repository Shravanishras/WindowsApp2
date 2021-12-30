Public Class Menuform
    Public Property Acc As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ChangePIN.Click
        Dim Obj = New ChangePIN()
        Obj.Acc = AccountNo.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Deposit.Click
        Dim Obj = New Deposit()
        Obj.Acc = AccountNo.Text
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim Obj = New Thankyou()
        Obj.Show()
        'Acc = AccountNo.Text'
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        Dim Obj = New Withdraw()
        Obj.Acc = AccountNo.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FastCash.Click
        Dim Obj = New FastCash()
        Obj.Acc = AccountNo.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles MiniStmt.Click
        Dim Obj = New MiniStatement()
        Obj.Acc = AccountNo.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Balance.Click
        Dim Obj = New Balance()
        Obj.Acc = AccountNo.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub GetBalance()

    End Sub
    Private Sub Menuform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountNo.Text = Acc
    End Sub

End Class