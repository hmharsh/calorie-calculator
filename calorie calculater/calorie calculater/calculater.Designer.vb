<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculater))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.butadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsthint = New System.Windows.Forms.ListBox()
        Me.lblfodname = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.butclear = New System.Windows.Forms.Button()
        Me.linknewuser = New System.Windows.Forms.LinkLabel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbunit = New System.Windows.Forms.ComboBox()
        Me.txtfoodname = New System.Windows.Forms.TextBox()
        Me.butfixfood = New System.Windows.Forms.Button()
        Me.txtpic = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttotalitem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotalcal = New System.Windows.Forms.TextBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.butexit = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.butupdate = New System.Windows.Forms.Button()
        Me.butadddata = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Mincho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Calorie Calculator"
        '
        'butadd
        '
        Me.butadd.BackColor = System.Drawing.SystemColors.Control
        Me.butadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butadd.Enabled = False
        Me.butadd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butadd.Location = New System.Drawing.Point(367, 363)
        Me.butadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butadd.Name = "butadd"
        Me.butadd.Size = New System.Drawing.Size(75, 33)
        Me.butadd.TabIndex = 37
        Me.butadd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.butadd, "Finalize All Above data ")
        Me.butadd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(36, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Food Quantity"
        '
        'lsthint
        '
        Me.lsthint.BackColor = System.Drawing.Color.White
        Me.lsthint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsthint.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lsthint.FormattingEnabled = True
        Me.lsthint.ItemHeight = 16
        Me.lsthint.Location = New System.Drawing.Point(39, 94)
        Me.lsthint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lsthint.Name = "lsthint"
        Me.lsthint.Size = New System.Drawing.Size(403, 128)
        Me.lsthint.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.lsthint, "list to provide Help to select Food name")
        '
        'lblfodname
        '
        Me.lblfodname.AutoSize = True
        Me.lblfodname.Location = New System.Drawing.Point(20, 46)
        Me.lblfodname.Name = "lblfodname"
        Me.lblfodname.Size = New System.Drawing.Size(81, 16)
        Me.lblfodname.TabIndex = 27
        Me.lblfodname.Text = "Food Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.butclear)
        Me.GroupBox1.Controls.Add(Me.linknewuser)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cmbunit)
        Me.GroupBox1.Controls.Add(Me.butadd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lsthint)
        Me.GroupBox1.Controls.Add(Me.lblfodname)
        Me.GroupBox1.Controls.Add(Me.txtfoodname)
        Me.GroupBox1.Controls.Add(Me.butfixfood)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 97)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(483, 529)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Food Intake Details"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox10.Location = New System.Drawing.Point(396, 459)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(64, 23)
        Me.TextBox10.TabIndex = 72
        Me.TextBox10.Tag = "weight"
        Me.TextBox10.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox9.Location = New System.Drawing.Point(298, 461)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(64, 23)
        Me.TextBox9.TabIndex = 71
        Me.TextBox9.Tag = "weight"
        Me.TextBox9.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox8.Location = New System.Drawing.Point(217, 459)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(64, 23)
        Me.TextBox8.TabIndex = 70
        Me.TextBox8.Tag = "weight"
        Me.TextBox8.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox7.Location = New System.Drawing.Point(147, 459)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(64, 23)
        Me.TextBox7.TabIndex = 69
        Me.TextBox7.Tag = "weight"
        Me.TextBox7.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox6.Location = New System.Drawing.Point(77, 459)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(64, 23)
        Me.TextBox6.TabIndex = 68
        Me.TextBox6.Tag = "weight"
        Me.TextBox6.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox5.Location = New System.Drawing.Point(6, 459)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(64, 23)
        Me.TextBox5.TabIndex = 67
        Me.TextBox5.Tag = "freedom level"
        Me.TextBox5.Visible = False
        '
        'butclear
        '
        Me.butclear.BackColor = System.Drawing.SystemColors.Control
        Me.butclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butclear.Enabled = False
        Me.butclear.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butclear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butclear.Location = New System.Drawing.Point(93, 243)
        Me.butclear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butclear.Name = "butclear"
        Me.butclear.Size = New System.Drawing.Size(162, 29)
        Me.butclear.TabIndex = 52
        Me.butclear.Text = "Add More Data/Clear"
        Me.ToolTip1.SetToolTip(Me.butclear, "Clear Locked Food name or add more food Name ")
        Me.butclear.UseVisualStyleBackColor = False
        '
        'linknewuser
        '
        Me.linknewuser.AutoSize = True
        Me.linknewuser.LinkColor = System.Drawing.Color.Black
        Me.linknewuser.Location = New System.Drawing.Point(313, 412)
        Me.linknewuser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linknewuser.Name = "linknewuser"
        Me.linknewuser.Size = New System.Drawing.Size(129, 16)
        Me.linknewuser.TabIndex = 49
        Me.linknewuser.TabStop = True
        Me.linknewuser.Text = "Previous Recoards"
        Me.ToolTip1.SetToolTip(Me.linknewuser, "Click to see Previous calculated  Calorie  Intake")
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox4.Location = New System.Drawing.Point(9, 490)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(64, 23)
        Me.TextBox4.TabIndex = 51
        Me.TextBox4.Tag = "for user id"
        Me.TextBox4.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 491)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox1.TabIndex = 50
        Me.ComboBox1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox3.Location = New System.Drawing.Point(246, 492)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 23)
        Me.TextBox3.TabIndex = 49
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.Location = New System.Drawing.Point(176, 491)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 23)
        Me.TextBox2.TabIndex = 48
        Me.TextBox2.Visible = False
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.White
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(384, 490)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(93, 24)
        Me.ComboBox4.TabIndex = 42
        Me.ComboBox4.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.Location = New System.Drawing.Point(314, 492)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 23)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Visible = False
        '
        'cmbunit
        '
        Me.cmbunit.Enabled = False
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Location = New System.Drawing.Point(213, 318)
        Me.cmbunit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(229, 24)
        Me.cmbunit.TabIndex = 41
        Me.cmbunit.Text = " -Unit-"
        Me.ToolTip1.SetToolTip(Me.cmbunit, "Drop Down Combo-box and Select Unit Of Food ")
        '
        'txtfoodname
        '
        Me.txtfoodname.BackColor = System.Drawing.Color.White
        Me.txtfoodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfoodname.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtfoodname.Location = New System.Drawing.Point(240, 44)
        Me.txtfoodname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfoodname.Name = "txtfoodname"
        Me.txtfoodname.Size = New System.Drawing.Size(202, 23)
        Me.txtfoodname.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.txtfoodname, "Enter name of food you ate")
        '
        'butfixfood
        '
        Me.butfixfood.BackColor = System.Drawing.SystemColors.Control
        Me.butfixfood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butfixfood.Enabled = False
        Me.butfixfood.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butfixfood.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butfixfood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butfixfood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butfixfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butfixfood.Location = New System.Drawing.Point(279, 243)
        Me.butfixfood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butfixfood.Name = "butfixfood"
        Me.butfixfood.Size = New System.Drawing.Size(163, 29)
        Me.butfixfood.TabIndex = 29
        Me.butfixfood.Text = "Fix Food Name"
        Me.ToolTip1.SetToolTip(Me.butfixfood, "Final Food Name Now after Clicking  here Select Food's Unit To Continue")
        Me.butfixfood.UseVisualStyleBackColor = False
        '
        'txtpic
        '
        Me.txtpic.BackColor = System.Drawing.Color.White
        Me.txtpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpic.ForeColor = System.Drawing.SystemColors.Window
        Me.txtpic.Location = New System.Drawing.Point(0, 650)
        Me.txtpic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpic.Name = "txtpic"
        Me.txtpic.Size = New System.Drawing.Size(202, 23)
        Me.txtpic.TabIndex = 46
        Me.txtpic.Text = "2"
        Me.txtpic.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Total  Items:"
        Me.Label10.Visible = False
        '
        'txttotalitem
        '
        Me.txttotalitem.BackColor = System.Drawing.Color.White
        Me.txttotalitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalitem.Enabled = False
        Me.txttotalitem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttotalitem.Location = New System.Drawing.Point(143, 375)
        Me.txttotalitem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotalitem.Name = "txttotalitem"
        Me.txttotalitem.Size = New System.Drawing.Size(50, 23)
        Me.txttotalitem.TabIndex = 42
        Me.txttotalitem.Text = "0"
        Me.txttotalitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txttotalitem, "Total Food Items You have Entred")
        Me.txttotalitem.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(580, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Total Calories"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txttotalitem)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txttotalcal)
        Me.GroupBox2.Controls.Add(Me.ListBox4)
        Me.GroupBox2.Controls.Add(Me.ListBox3)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(545, 97)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(743, 473)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calorie Calculation "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Grand Total Of Total Calories:"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Calories per Unit Quantity"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(506, 412)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 45)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Generate Result"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Food Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Food Name"
        '
        'txttotalcal
        '
        Me.txttotalcal.BackColor = System.Drawing.Color.White
        Me.txttotalcal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalcal.Enabled = False
        Me.txttotalcal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txttotalcal.Location = New System.Drawing.Point(574, 378)
        Me.txttotalcal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotalcal.Name = "txttotalcal"
        Me.txttotalcal.Size = New System.Drawing.Size(120, 23)
        Me.txttotalcal.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.txttotalcal, "Total Calorie Intake")
        Me.txttotalcal.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.BackColor = System.Drawing.Color.White
        Me.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox4.Enabled = False
        Me.ListBox4.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(574, 56)
        Me.ListBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 290)
        Me.ListBox4.TabIndex = 20
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.White
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox3.Enabled = False
        Me.ListBox3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(398, 56)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 290)
        Me.ListBox3.TabIndex = 19
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.White
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.Enabled = False
        Me.ListBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(222, 56)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 290)
        Me.ListBox2.TabIndex = 18
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Enabled = False
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(46, 56)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 290)
        Me.ListBox1.TabIndex = 17
        '
        'butexit
        '
        Me.butexit.BackColor = System.Drawing.SystemColors.Control
        Me.butexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butexit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butexit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butexit.Location = New System.Drawing.Point(1213, 578)
        Me.butexit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butexit.Name = "butexit"
        Me.butexit.Size = New System.Drawing.Size(75, 33)
        Me.butexit.TabIndex = 47
        Me.butexit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.butexit, "Click or Press Esc to Exit and Close application")
        Me.butexit.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1142, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 22)
        Me.DateTimePicker1.TabIndex = 66
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.butupdate)
        Me.GroupBox3.Controls.Add(Me.butadddata)
        Me.GroupBox3.Location = New System.Drawing.Point(545, 540)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 97)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Food Database Settings"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "Options Accessible by Admin Only")
        '
        'butupdate
        '
        Me.butupdate.BackColor = System.Drawing.SystemColors.Control
        Me.butupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butupdate.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butupdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butupdate.Location = New System.Drawing.Point(193, 30)
        Me.butupdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butupdate.Name = "butupdate"
        Me.butupdate.Size = New System.Drawing.Size(135, 33)
        Me.butupdate.TabIndex = 40
        Me.butupdate.Text = "Update Data"
        Me.butupdate.UseVisualStyleBackColor = False
        '
        'butadddata
        '
        Me.butadddata.BackColor = System.Drawing.SystemColors.Control
        Me.butadddata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butadddata.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butadddata.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadddata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butadddata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadddata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butadddata.Location = New System.Drawing.Point(29, 30)
        Me.butadddata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.butadddata.Name = "butadddata"
        Me.butadddata.Size = New System.Drawing.Size(135, 33)
        Me.butadddata.TabIndex = 38
        Me.butadddata.Text = "Add New Data"
        Me.butadddata.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.Desktop
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Calorie Calculator"
        Me.NotifyIcon1.BalloonTipTitle = "Calorie Calculator"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'calculater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelButton = Me.butexit
        Me.ClientSize = New System.Drawing.Size(1316, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.butexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtpic)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "calculater"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents butadd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsthint As System.Windows.Forms.ListBox
    Friend WithEvents lblfodname As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfoodname As System.Windows.Forms.TextBox
    Friend WithEvents butfixfood As System.Windows.Forms.Button
    Friend WithEvents txtpic As System.Windows.Forms.TextBox
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotalitem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotalcal As System.Windows.Forms.TextBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents butexit As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents linknewuser As System.Windows.Forms.LinkLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents butclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents butupdate As System.Windows.Forms.Button
    Friend WithEvents butadddata As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
