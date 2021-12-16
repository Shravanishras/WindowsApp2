Imports System.Data.SqlClient

Public Class Balance
    Public Property Acc As Integer
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Menuform
        Me.Hide()
        Obj.Show()
    End Sub
    Dim con = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")

    Private Sub GetBalance()
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select Balance from AccTable where AccountNo=" & Account & "", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable
        dt = New DataTable
        sda.Fill(dt)
        BalLbl.Text = Convert.ToInt32(dt.Rows(0)(0).ToString())
        con.Close()
    End Sub

    Dim Account As Integer
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Account = Convert.ToInt32(Acc)
        AccNumLbl.Text = Acc
        GetBalance()
    End Sub
End Class