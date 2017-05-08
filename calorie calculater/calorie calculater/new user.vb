Public Class new_user

    Private Sub new_user_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles butexit.Click
        End

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles butback.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtpass.Focus()



        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked) Then
            txtgender.Text = "MALE"

        End If
    End Sub

    Private Sub RadioButton1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RadioButton1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtage.Focus()

        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked) Then
            txtgender.Text = "Female"

        End If
    End Sub

    Private Sub RadioButton2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles RadioButton2.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtage.Focus()

        End If

    End Sub

    Private Sub txtage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtage.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            txtweight.Focus()

        End If

    End Sub

    Private Sub txtage_Leave(sender As Object, e As System.EventArgs) Handles txtage.Leave
      
    End Sub

    Private Sub txtage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtage.TextChanged
        If (IsNumeric(txtage.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            txtage.Clear()
            txtage.Focus()

        End If
    End Sub

    Private Sub txtweight_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtweight.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            feet.Focus()

        End If

    End Sub

    Private Sub txtweight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtweight.TextChanged
        If (IsNumeric(txtweight.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            txtweight.Clear()
            txtweight.Focus()
        End If
    End Sub

    Private Sub feet_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles feet.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            inch.Focus()

        End If

    End Sub

    Private Sub feet_TextChanged(sender As System.Object, e As System.EventArgs) Handles feet.TextChanged
        If (IsNumeric(feet.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            feet.Clear()
            feet.Focus()

        End If
        Label9.Text = feet.Text + "feet" + inch.Text + "inch"
    End Sub

    Private Sub inch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles inch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtcontact.Focus()

        End If

    End Sub

    Private Sub inch_TextChanged(sender As System.Object, e As System.EventArgs) Handles inch.TextChanged

        If (IsNumeric(inch.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            inch.Clear()
            inch.Focus()

        End If
        Label9.Text = feet.Text + "feet" + " " + inch.Text + "inch"
    End Sub

    Private Sub txtcontact_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtcontact.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            CheckBox1.Focus()

        End If
    End Sub

    Private Sub txtcontact_Leave(sender As Object, e As System.EventArgs) Handles txtcontact.Leave
        If (txtcontact.Text.Count < 10) Then
            MsgBox("Please Enter Correct Contact Number")
        Else

        End If
    End Sub

    Private Sub txtcontact_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcontact.TextChanged
        If (IsNumeric(txtcontact.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            txtcontact.Clear()
            txtcontact.Focus()

        End If
    End Sub

   

    Private Sub cmbqu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (MsgBox("Are you shure to exit..") = MsgBoxResult.Ok) Then
            My.Computer.Audio.Play(My.Resources._exit, AudioPlayMode.WaitToComplete)

            End

        End If
        End
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.back, AudioPlayMode.Background)

        login.Show()

    End Sub

    Private Sub txtans_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            CheckBox1.Focus()

        End If
    End Sub

    Private Sub txtans_TextChanged(sender As System.Object, e As System.EventArgs)
        If (txtusername.Text = "") Then

        Else
            Button1.Enabled = True

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles CheckBox1.KeyDown
        butlogin.Focus()

    End Sub

    Private Sub butlogin_Click(sender As System.Object, e As System.EventArgs) Handles butlogin.Click
        Try

        
            If (txtcontact.Text = " ") Then
                MsgBox("Fill All Information Properly..")
            Else
                ComboBox2.Items.Clear()
                ComboBox3.Items.Clear()
                My.Computer.Audio.Play(My.Resources.create, AudioPlayMode.Background)

                connect()
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select  username from userinfo"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    ComboBox3.Items.Add(dr("username"))
                End While
                cmd.Dispose()
                con.Close()
                If (ComboBox3.Items.Count <= 3) Then
                    TextBox2.Text = "1"
                End If
                'code to save
                connect()


                '    con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\userinfo.mdb"
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select  username from userinfo where username='" + txtusername.Text + "'"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    ComboBox2.Items.Add(dr("username"))
                End While
                cmd.Dispose()
                con.Close()
                If (ComboBox2.Items.Count >= 1) Then
                    MsgBox("Username Already Present Please Try Another Username TO Add New Account")
                    ComboBox2.Items.Clear()

                Else
                    If (CheckBox1.Checked) Then
                        connect()
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandType = CommandType.Text

                        cmd.CommandText = "insert into userinfo (username,pass,registration_date,gender,age,weight,height,contact,question,answer,freedom_leval) values ('" + txtusername.Text + "','" + txtpass.Text + "','" + DateTimePicker1.Value.ToString + "','" + txtgender.Text + "'," + txtage.Text + "," + txtweight.Text + ",'" + Label9.Text + "','" + txtcontact.Text + "','" + ComboBox1.Text + "','" + TextBox1.Text + "'," + TextBox2.Text + ")"

                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        con.Close()







                        If (MsgBox("Congratulations!" + Chr(13) + "Your Data Saved Successfully" + Chr(13) + "Press Ok to Continue" + Chr(13), MsgBoxStyle.Information) = MsgBoxResult.Ok) Then
                            login.txtuser.Text = txtusername.Text
                            Me.Hide()
                            login.Show()

                        End If

                    Else
                        MsgBox("In order to use This calorie Calculator  please Agree , all  above information is true")
                        CheckBox1.BackColor = Color.Orange
                        CheckBox1.Focus()

                    End If
                    ' Me.Text = "success"

                End If

                ' code to save end hear

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            RadioButton1.Focus()

        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpass.TextChanged

    End Sub
End Class