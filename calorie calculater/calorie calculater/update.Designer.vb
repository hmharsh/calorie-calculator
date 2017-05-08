<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class up
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.butupdate = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.butadd = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(247, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 31)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.Button3, "Click to move back at Calorie Calculator")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'butupdate
        '
        Me.butupdate.BackColor = System.Drawing.SystemColors.Control
        Me.butupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butupdate.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butupdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butupdate.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.butupdate.Location = New System.Drawing.Point(385, 241)
        Me.butupdate.Name = "butupdate"
        Me.butupdate.Size = New System.Drawing.Size(63, 31)
        Me.butupdate.TabIndex = 40
        Me.butupdate.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.butupdate, "Click to Update infrormation")
        Me.butupdate.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Location = New System.Drawing.Point(258, 188)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 25)
        Me.TextBox3.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.TextBox3, "write calorie present in unit quantity of  food (divide total calorie in perticul" & _
        "ar quantity by perticular quantity) ")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Calorie Per Unit Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(21, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Quantity Measured In Unit"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(258, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 25)
        Me.TextBox1.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Enter Name of  Food Item Here ,if you are updating Information then this Name mus" & _
        "t be present in food database ")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Food Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Mincho", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 25)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Update/Add New"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ml/l", "Grams/Kg", "Tbsp", "Small/Medium/Noc", "Cup", "Oz", "Pices", "Fl.Oz"})
        Me.ComboBox1.Location = New System.Drawing.Point(258, 130)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(190, 25)
        Me.ComboBox1.TabIndex = 68
        Me.ComboBox1.Text = " -Select Unit-"
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Select Food's Unit in which Quantity of food measured")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(454, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = " Unit"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(457, 131)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(48, 25)
        Me.TextBox2.TabIndex = 70
        Me.TextBox2.Visible = False
        '
        'butadd
        '
        Me.butadd.BackColor = System.Drawing.SystemColors.Control
        Me.butadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butadd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butadd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.butadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.butadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butadd.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.butadd.Location = New System.Drawing.Point(316, 241)
        Me.butadd.Name = "butadd"
        Me.butadd.Size = New System.Drawing.Size(63, 31)
        Me.butadd.TabIndex = 71
        Me.butadd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.butadd, "Click to add this New data at food database")
        Me.butadd.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.Desktop
        '
        'up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(527, 284)
        Me.Controls.Add(Me.butadd)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.butupdate)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Fax", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "up"
        Me.Opacity = 0.99R
        Me.Text = "Update/Add New"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents butupdate As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents butadd As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
