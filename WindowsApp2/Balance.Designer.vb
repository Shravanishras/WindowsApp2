<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AccNumLbl = New System.Windows.Forms.Label()
        Me.BalLbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ATM MANAGAEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 38)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ACCOUNT NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 38)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "YOUR BALANCE"
        '
        'AccNumLbl
        '
        Me.AccNumLbl.AutoSize = True
        Me.AccNumLbl.BackColor = System.Drawing.Color.Transparent
        Me.AccNumLbl.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNumLbl.Location = New System.Drawing.Point(407, 123)
        Me.AccNumLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AccNumLbl.Name = "AccNumLbl"
        Me.AccNumLbl.Size = New System.Drawing.Size(102, 38)
        Me.AccNumLbl.TabIndex = 14
        Me.AccNumLbl.Text = "AccNo"
        '
        'BalLbl
        '
        Me.BalLbl.AutoSize = True
        Me.BalLbl.BackColor = System.Drawing.Color.Transparent
        Me.BalLbl.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalLbl.Location = New System.Drawing.Point(407, 209)
        Me.BalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BalLbl.Name = "BalLbl"
        Me.BalLbl.Size = New System.Drawing.Size(59, 38)
        Me.BalLbl.TabIndex = 15
        Me.BalLbl.Text = "Bal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 31)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "BACK"
        '
        'Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.green_sand_paper_53876_86281
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BalLbl)
        Me.Controls.Add(Me.AccNumLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Balance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AccNumLbl As Label
    Friend WithEvents BalLbl As Label
    Friend WithEvents Label6 As Label
End Class
