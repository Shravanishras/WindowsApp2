Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Text.RegularExpressions

Public Class Signupform
    Dim Generator As System.Random = New System.Random()
    Private Function GetRandom(myGenerator As System.Random, ByVal Digits As Integer) As Integer
        Dim min = 10 ^ (Digits - 1)
        Dim max = (10 ^ Digits) - 1
        Return myGenerator.Next(min, max + 1)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regex = New Regex("\d{10}", RegexOptions.None)


        Dim accNum As Integer
        Dim PinNum As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Bal = 0
        con.ConnectionString = ("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
        con.Open()
        cmd.Connection = con

        Dim cmd1 As Int16


        If Not Regex.Match(Firstname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter alpha text only.")
            Firstname.Focus()
            Return
        ElseIf Not Regex.Match(Lastname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please enter alpha text only.")
            Lastname.Focus()
            Return
        ElseIf Not regex.IsMatch(Phone.Text) Then
            MsgBox("Invalid Phone number")
            Return
        ElseIf (Firstname.Text = "" Or Lastname.Text = "" Or Address.Text = "" Or Phone.Text = "" Or DateTimePicker1.Text = "") Then
            MsgBox("Please enter all the Details")
            Return
        End If
        While True
            accNum = GetRandom(Generator, 5)
            PinNum = GetRandom(Generator, 4)

            Try
                cmd = New SqlCommand("Insert into AccountTable Values('" & accNum & "','" & Firstname.Text & "','" & Lastname.Text & "','" & Address.Text & "','" & PinNum & "','" & Phone.Text & "','" & DateTimePicker1.Text & "','" & Bal & "')", con)
                cmd1 = cmd.ExecuteNonQuery()
            Catch SqlEx As SqlException
                MsgBox(SqlEx.Message)
                MsgBox("UserId already Exists")
                Continue While
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Something went Wrong")

            End Try
            Exit While
        End While
        If (cmd1 = 1) Then
            MsgBox("Account Created", MsgBoxStyle.Information, "Success")
            MsgBox("AccountNumber = " & accNum & " PIN = " & PinNum)
            Dim Obj = New Signupform
            Obj.ResetText()
            Obj.Show()
            con.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New Login
        Me.Hide()
        Obj.Show()
    End Sub


End Class