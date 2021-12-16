
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Signupform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Bal = 0
        con.ConnectionString = ("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
        con.Open()
        cmd.Connection = con
        Dim cmd1 As Int16
        If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" And DateTimePicker1.Text = "") Then
            MsgBox("Please enter the Details")
        Else
            Try
                cmd = New SqlCommand("Insert into AccTable Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & Bal & "')", con)
                cmd1 = cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("UserId already Exists")
            End Try
        End If
        If (cmd1 = 1) Then
            MsgBox("Successfully stored", MsgBoxStyle.Information, "Success")
            Me.Show()
            con.Close()
            Reset()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New Login
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Signupform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class