Imports System.Data.SqlClient

Public Class ChangePIN
    Public Property Acc As String
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-R22F8PKB\DATACAMP_SQL;Initial Catalog=ATMManagementDB;Integrated Security=True")
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New Menuform()
        Obj.Acc = Acc
        Obj.Show()
        Me.Hide()
    End Sub
    Dim MyAcc As Integer
    Private Sub ChangePIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyAcc = Convert.ToInt32(Acc)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If NewPinTb.Text = "" Or ConPinTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf NewPinTb.Text = ConPinTb.Text Then
            Try
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("Update AccountTable set PIN='" & NewPinTb.Text & "' where AccountNo='" & MyAcc & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("PIN Changed Successfully")
                con.Close()
                Dim log = New Login()
                log.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("New Pin and Confirmed Pin doesn't Match")
        End If
    End Sub
    Private Sub NewPinTb_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NewPinTb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub ConPinTb_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ConPinTb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class