Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Deposit
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New Menuform()
        Obj.Show()
        Obj.Acc = Acc
        Me.Hide()
    End Sub
    Dim cmd As New SqlCommand
    Dim con = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
    Dim OldBalance = 0
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccTable where AccountNo=" & Acc & "", con)
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
            Dim cmd As SqlCommand = New SqlCommand("Update AccTable set Balance=" & NewBal & "where AccountNo=" & MyAcc & "", con)
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
            MsgBox("Missing Information")
        Else

            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Deposit"
            Try
                Dim Bal = 0
                con.open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & TextBox1.Text & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Deposit Successful")
                con.Close()
                UpdateBal()
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
End Class