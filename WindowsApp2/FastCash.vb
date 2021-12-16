Imports System.Data.SqlClient
Public Class FastCash
    Public Property Acc As String
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
    Dim OldBalance = 0
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If OldBalance < 10000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 10000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccTable where AccountNo=" & Acc & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        OldBalance = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Bal.Text = OldBalance
        con.Close()
    End Sub
    Dim MyAcc = 0
    Private Sub FastCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
        GetBalance()
    End Sub
    Dim Amount As Integer
    Private Sub UpdateBal(Amt As Integer)
        Dim Account = Convert.ToInt32(Acc)
        Dim NewBal = OldBalance - Amt
        Try
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Update AccTable set Balance=" & NewBal & "where AccountNo=" & Acc & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Balance Updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OldBalance < 100 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 100
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OldBalance < 500 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 500
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OldBalance < 1000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 1000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If OldBalance < 2000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 2000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OldBalance < 5000 Then
            MsgBox("Not Enough Balance")
        Else
            Dim Account = Convert.ToInt32(Acc)
            Dim TrType = "Withdraw"
            Amount = 5000
            Try
                Dim Bal = 0
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Insert into Table_2 Values('" & MyAcc & "','" & TrType & "','" & Amount & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Withdraw Successful")
                con.Close()
                UpdateBal(Amount)
                Dim Obj = New Menuform()
                Obj.Acc = Acc
                Obj.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class