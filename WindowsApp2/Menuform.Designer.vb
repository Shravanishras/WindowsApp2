<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuform
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
        Me.Deposit = New System.Windows.Forms.Button()
        Me.FastCash = New System.Windows.Forms.Button()
        Me.ChangePIN = New System.Windows.Forms.Button()
        Me.Withdraw = New System.Windows.Forms.Button()
        Me.MiniStmt = New System.Windows.Forms.Button()
        Me.Balance = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.AccountNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT YOUR TRANSACTION PLEASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ACCOUNT NUMBER :"
        '
        'Deposit
        '
        Me.Deposit.BackColor = System.Drawing.Color.Gainsboro
        Me.Deposit.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit.Location = New System.Drawing.Point(267, 189)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(283, 49)
        Me.Deposit.TabIndex = 2
        Me.Deposit.Text = "DEPOSIT"
        Me.Deposit.UseVisualStyleBackColor = False
        '
        'FastCash
        '
        Me.FastCash.BackColor = System.Drawing.Color.Gainsboro
        Me.FastCash.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastCash.Location = New System.Drawing.Point(267, 286)
        Me.FastCash.Name = "FastCash"
        Me.FastCash.Size = New System.Drawing.Size(283, 46)
        Me.FastCash.TabIndex = 3
        Me.FastCash.Text = "FAST CASH"
        Me.FastCash.UseVisualStyleBackColor = False
        '
        'ChangePIN
        '
        Me.ChangePIN.BackColor = System.Drawing.Color.Gainsboro
        Me.ChangePIN.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePIN.Location = New System.Drawing.Point(267, 379)
        Me.ChangePIN.Name = "ChangePIN"
        Me.ChangePIN.Size = New System.Drawing.Size(283, 45)
        Me.ChangePIN.TabIndex = 4
        Me.ChangePIN.Text = "CHANGE PIN"
        Me.ChangePIN.UseVisualStyleBackColor = False
        '
        'Withdraw
        '
        Me.Withdraw.BackColor = System.Drawing.Color.Gainsboro
        Me.Withdraw.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Withdraw.Location = New System.Drawing.Point(673, 189)
        Me.Withdraw.Name = "Withdraw"
        Me.Withdraw.Size = New System.Drawing.Size(283, 49)
        Me.Withdraw.TabIndex = 5
        Me.Withdraw.Text = "WITHDRAW"
        Me.Withdraw.UseVisualStyleBackColor = False
        '
        'MiniStmt
        '
        Me.MiniStmt.BackColor = System.Drawing.Color.Gainsboro
        Me.MiniStmt.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniStmt.Location = New System.Drawing.Point(673, 286)
        Me.MiniStmt.Name = "MiniStmt"
        Me.MiniStmt.Size = New System.Drawing.Size(283, 52)
        Me.MiniStmt.TabIndex = 6
        Me.MiniStmt.Text = "MINI STATEMENT"
        Me.MiniStmt.UseVisualStyleBackColor = False
        '
        'Balance
        '
        Me.Balance.BackColor = System.Drawing.Color.Gainsboro
        Me.Balance.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance.Location = New System.Drawing.Point(673, 379)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(283, 45)
        Me.Balance.TabIndex = 7
        Me.Balance.Text = "BALANCE"
        Me.Balance.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.Gainsboro
        Me.Logout.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Location = New System.Drawing.Point(500, 502)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(195, 52)
        Me.Logout.TabIndex = 8
        Me.Logout.Text = "LOGOUT"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'AccountNo
        '
        Me.AccountNo.AutoSize = True
        Me.AccountNo.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountNo.Location = New System.Drawing.Point(724, 101)
        Me.AccountNo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.Size = New System.Drawing.Size(128, 38)
        Me.AccountNo.TabIndex = 9
        Me.AccountNo.Text = "AccNum"
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1194, 614)
        Me.Controls.Add(Me.AccountNo)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.MiniStmt)
        Me.Controls.Add(Me.Withdraw)
        Me.Controls.Add(Me.ChangePIN)
        Me.Controls.Add(Me.FastCash)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Deposit As Button
    Friend WithEvents FastCash As Button
    Friend WithEvents ChangePIN As Button
    Friend WithEvents Withdraw As Button
    Friend WithEvents MiniStmt As Button
    Friend WithEvents Balance As Button
    Friend WithEvents Logout As Button
    Friend WithEvents AccountNo As Label
End Class
