Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class Login
    Public Property Acc As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from AccTable where AccountNo='" + Accno.Text + "' and PIN='" + PinNum.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        Dim v = sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Obj = New Menuform
            Obj.Acc = Accno.Text
            Me.Hide()
            Obj.Show()
            Accno.Clear()
            PinNum.Clear()
        Else
            MessageBox.Show("Login Unsuccessful. Please Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New Signupform
        Obj.Show()
    End Sub
End Class