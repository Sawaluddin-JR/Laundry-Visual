<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Image = Global.WindowsApplication2.My.Resources.Resources.pngegg__4_
        Me.Button1.Location = New System.Drawing.Point(704, 158)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(316, 283)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 772)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(356, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 64)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Laundry Visual"
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.Red
        Me.cancel.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Image = Global.WindowsApplication2.My.Resources.Resources._3017963_close_error_exit_failure_invalid_icon
        Me.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancel.Location = New System.Drawing.Point(785, 518)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(226, 85)
        Me.cancel.TabIndex = 27
        Me.cancel.Text = "Keluar"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Lime
        Me.login.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.Black
        Me.login.Image = Global.WindowsApplication2.My.Resources.Resources._3017953_accomplishment_check_outline_success_triumph_icon_removebg_preview__3_
        Me.login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.login.Location = New System.Drawing.Point(131, 518)
        Me.login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(238, 85)
        Me.login.TabIndex = 26
        Me.login.Text = "Masuk"
        Me.login.UseVisualStyleBackColor = False
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Font = New System.Drawing.Font("Cambria Math", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(45, 255)
        Me.pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(166, 134)
        Me.pass.TabIndex = 25
        Me.pass.Text = "Password"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(273, 406)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(190, 31)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Lihat passwrod"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.Cornsilk
        Me.username.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(273, 228)
        Me.username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(283, 33)
        Me.username.TabIndex = 22
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Cambria Math", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(45, 172)
        Me.user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(170, 134)
        Me.user.TabIndex = 21
        Me.user.Text = "Username"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(273, 311)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(283, 33)
        Me.password.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1102, 663)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.user)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents pass As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox

End Class
