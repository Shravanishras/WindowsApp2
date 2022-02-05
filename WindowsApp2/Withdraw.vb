Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataSetDateTime
Public Class Withdraw
    Public Property Acc As String
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim MyAcc As Integer
    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub
    Dim OldBalance = 0
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTable where AccountNo=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Balance.Text = OldBalance
        con.Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If AmountW.Text = "" Then
            MsgBox("Please enter Amount Information")
        ElseIf Convert.ToInt32(AmountW.Text) > OldBalance Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Try
                Dim Bal = 0
                Dim TrDate As DateTime = DateTime.Now
                Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
                con.Open()

                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & AmountW.Text & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal()
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Convert.ToInt32(AmountW.Text)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Update AccountTable set Balance=" & NewBal & "where AccountNo=" & Acc & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AmountW_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles AmountW.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class