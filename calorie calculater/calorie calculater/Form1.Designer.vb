<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.butlogin = New System.Windows.Forms.Button()
        Me.linknewuser = New System.Windows.Forms.LinkLabel()
        Me.butexit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combobox1 = New System.Windows.Forms.ComboBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usrename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(149, 64)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(163, 23)
        Me.txtuser.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtuser, "Enter Your Username Here")
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(149, 111)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(163, 23)
        Me.txtpass.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtpass, "Enter Your Password and  Press Enter or Click on Login To continue")
        Me.txtpass.UseSystemPasswordChar = True
        '
        'butlogin
        '
        Me.butlogin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butlogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed
        Me.butlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.butlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.butlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butlogin.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butlogin.Location = New System.Drawing.Point(242, 153)
        Me.butlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.butlogin.Name = "butlogin"
        Me.butlogin.Size = New System.Drawing.Size(70, 23)
        Me.butlogin.TabIndex = 4
        Me.butlogin.Text = "Login"
        Me.ToolTip1.SetToolTip(Me.butlogin, "Click to calculate Your calorie Intake")
        Me.butlogin.UseVisualStyleBackColor = True
        '
        'linknewuser
        '
        Me.linknewuser.AutoSize = True
        Me.linknewuser.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linknewuser.LinkColor = System.Drawing.Color.Black
        Me.linknewuser.Location = New System.Drawing.Point(209, 9)
        Me.linknewuser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linknewuser.Name = "linknewuser"
        Me.linknewuser.Size = New System.Drawing.Size(103, 22)
        Me.linknewuser.TabIndex = 5
        Me.linknewuser.TabStop = True
        Me.linknewuser.Text = "New User"
        '
        'butexit
        '
        Me.butexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butexit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butexit.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed
        Me.butexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive
        Me.butexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.butexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butexit.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butexit.Location = New System.Drawing.Point(164, 153)
        Me.butexit.Margin = New System.Windows.Forms.Padding(4)
        Me.butexit.Name = "butexit"
        Me.butexit.Size = New System.Drawing.Size(70, 23)
        Me.butexit.TabIndex = 6
        Me.butexit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.butexit, "Click Or Press Esc To Quite")
        Me.butexit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Mincho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "User Login"
        '
        'combobox1
        '
        Me.combobox1.BackColor = System.Drawing.SystemColors.Control
        Me.combobox1.FormattingEnabled = True
        Me.combobox1.Location = New System.Drawing.Point(20, 151)
        Me.combobox1.Margin = New System.Windows.Forms.Padding(4)
        Me.combobox1.Name = "combobox1"
        Me.combobox1.Size = New System.Drawing.Size(78, 26)
        Me.combobox1.TabIndex = 42
        Me.combobox1.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Welcome To Calorie Calculator,Please Login to Calculate Your Daily Calorie Intake" & _
    ""
        Me.NotifyIcon1.BalloonTipTitle = "Calorie Calculator"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Calorie Calculator"
        Me.NotifyIcon1.Visible = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.WindowText
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelButton = Me.butexit
        Me.ClientSize = New System.Drawing.Size(332, 185)
        Me.Controls.Add(Me.combobox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.butexit)
        Me.Controls.Add(Me.linknewuser)
        Me.Controls.Add(Me.butlogin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Opacity = 0.9R
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents butlogin As System.Windows.Forms.Button
    Friend WithEvents linknewuser As System.Windows.Forms.LinkLabel
    Friend WithEvents butexit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combobox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
