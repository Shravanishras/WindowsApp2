Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Deposit
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim cmd As New SqlCommand
    Dim con = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
    Dim OldBalance = 0
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccountTable where AccountNo=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.Close()
    End Sub
    Private Sub UpdateBal()
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance + Convert.ToInt32(TextBox1.Text)
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Update AccountTable set Balance=" & NewBal & "where AccountNo=" & MyAcc & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Property Acc As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Or Convert.ToInt32(TextBox1.Text) < 1 Then
            MsgBox("Please enter Amount")
        Else
            Dim TrDate As DateTime = DateTime.Now
            Dim strDate As String = TrDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Deposit"
            Try
                Dim Bal = 0
                con.open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into TrsnTable Values('" & MyAcc & "','" & TrType & "','" & TextBox1.Text & "','" & strDate & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Deposit Successful")
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
    Dim MyAcc As Integer
    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub
    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class