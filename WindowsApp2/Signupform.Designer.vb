<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signupform
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ATM MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(494, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NEW ACCOUNT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(647, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 31)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Phone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(647, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 31)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "DOB"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(485, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 47)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(485, 539)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 47)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(334, 242)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Address.Size = New System.Drawing.Size(218, 115)
        Me.Address.TabIndex = 16
        '
        'Phone
        '
        Me.Phone.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone.Location = New System.Drawing.Point(859, 239)
        Me.Phone.MaxLength = 10
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(238, 39)
        Me.Phone.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(859, 308)
        Me.DateTimePicker1.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 39)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2003, 12, 31, 0, 0, 0, 0)
        '
        'Firstname
        '
        Me.Firstname.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.Location = New System.Drawing.Point(334, 174)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(218, 39)
        Me.Firstname.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "FirstName"
        '
        'Lastname
        '
        Me.Lastname.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastname.Location = New System.Drawing.Point(859, 174)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(238, 39)
        Me.Lastname.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(647, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 31)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "LastName"
        '
        'Signupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.green_sand_paper_53876_86281
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1194, 614)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Signupform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signupform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Address As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Label5 As Label
End Class
