Public Class calculater
    Dim unit As Integer
    Private Sub calculater_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.BalloonTipText = "Write Food Name and click on Fix Food name to continue"

        NotifyIcon1.ShowBalloonTip(200)
        butadddata.Enabled = False
        butupdate.Enabled = False

        Me.Width = 536
        Me.Height = 610

        connect()

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select food from foodlist where food like '%'+'" + txtfoodname.Text + "'+'%'"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            lsthint.Items.Add(dr("food"))
        End While
        cmd.Dispose()
        con.Close()

        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from userinfo where Id =" + TextBox4.Text + ""
        dr = cmd.ExecuteReader()
        While (dr.Read())
            'TextBox6.Text = dr("weight")
            TextBox5.Text = dr("freedom_leval")
            TextBox10.Text = dr("weight").ToString()

        End While
        cmd.Dispose()
        con.Close()
      
        If (TextBox5.Text = "1" Or login.txtuser.Text = "") Then
            butadddata.Enabled = True
            butupdate.Enabled = True

        End If




    End Sub

    Private Sub butadd_Click(sender As System.Object, e As System.EventArgs) Handles butadd.Click
        If (TextBox3.Text = "" Or TextBox1.Text = "0") Then
            MsgBox("Please Enter a Valid Unite of food selected,or manage it by food settings..")
            txtfoodname.Enabled = True

            txtfoodname.Focus()

        Else
            NotifyIcon1.BalloonTipText = "Click on add more data/clear  to add more data or click on generate result"
            NotifyIcon1.ShowBalloonTip(210)


            butadd.Enabled = False

            Me.Width = 1345
            Me.Height = 695
            txtfoodname.Enabled = True
            TextBox2.Clear()
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox2.Text = txtfoodname.Text
            TextBox3.Text = cmbunit.Text
            'starting of main logic


            Dim cal, uc As Double
            connect()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select calories from foodlist where food='" + TextBox2.Text + "'"
            dr = cmd.ExecuteReader()
            While (dr.Read())
                uc = (dr("calories"))
            End While
            cmd.Dispose()
            con.Close()
            TextBox9.Text = uc.ToString()
            uc = Val(TextBox9.Text) 'uc:(value of) unite calorie

            If (unit = 1 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 1

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 30

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 45

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 3) Then
                cal = uc * 60

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 4) Then
                cal = uc * 90

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 5) Then
                cal = uc * 100

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 6) Then
                cal = uc * 200

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 7) Then
                cal = uc * 250

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 8) Then
                cal = uc * 500

            End If
            If (unit = 1 And cmbunit.SelectedIndex = 9) Then
                cal = uc * 1000

            End If


            If (unit = 2 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 1

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 15

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 20

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 3) Then
                cal = uc * 25

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 4) Then
                cal = uc * 50

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 5) Then
                cal = uc * 85
            End If
            If (unit = 2 And cmbunit.SelectedIndex = 6) Then
                cal = uc * 100

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 7) Then
                cal = uc * 150

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 8) Then
                cal = uc * 1000

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 9) Then
                cal = uc * 200

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 10) Then
                cal = uc * 250

            End If
            If (unit = 2 And cmbunit.SelectedIndex = 11) Then
                cal = uc * 500

            End If


            If (unit = 3 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 0.5

            End If

            If (unit = 3 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 1

            End If
            If (unit = 3 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 2

            End If
            If (unit = 3 And cmbunit.SelectedIndex = 3) Then
                cal = uc * 3

            End If

            If (unit = 4 And cmbunit.SelectedIndex = 6) Then
                cal = uc * 0.25

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 7) Then
                cal = uc * 0.75

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 0.5

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 1

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 2

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 3) Then
                cal = uc * 3

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 4) Then
                cal = uc * 4

            End If
            If (unit = 4 And cmbunit.SelectedIndex = 5) Then
                cal = uc * 5

            End If


            If (unit = 5 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 0.5

            End If
            If (unit = 5 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 1

            End If
            If (unit = 5 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 2

            End If
            If (unit = 6 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 0.5

            End If
            If (unit = 6 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 1

            End If
            If (unit = 6 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 2

            End If

            If (unit = 7 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 0.5

            End If
            If (unit = 7 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 1

            End If
            If (unit = 7 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 2

            End If
            If (unit = 8 And cmbunit.SelectedIndex = 0) Then
                cal = uc * 1

            End If
            If (unit = 8 And cmbunit.SelectedIndex = 1) Then
                cal = uc * 3.5

            End If
            If (unit = 8 And cmbunit.SelectedIndex = 2) Then
                cal = uc * 12

            End If


            TextBox1.Text = (cal.ToString())







            'end of main logic

            'transfering value....
            ListBox1.Items.Add(TextBox2.Text)
            ListBox2.Items.Add(TextBox3.Text)
            ListBox3.Items.Add(TextBox9.Text)
            ListBox4.Items.Add(Val(TextBox9.Text) * Val(TextBox3.Text))


            Dim i, j, sum As Integer
            txttotalitem.Text = ListBox4.Items.Count()


            i = ListBox4.Items.Count.ToString()
            While (j < i)
                sum = sum + ListBox4.Items.Item(j)
                j = j + 1
            End While
            txttotalcal.Text = sum.ToString

            txtfoodname.Clear()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select food from foodlist where food like '%'+'" + txtfoodname.Text + "'+'%'"
            dr = cmd.ExecuteReader()
            While (dr.Read())
                lsthint.Items.Add(dr("food"))
            End While
            cmd.Dispose()
            con.Close()
            cmbunit.Text = "-Unit-"
            butfixfood.Enabled = False
            cmbunit.Enabled = False
            butadd.Enabled = False
            txtfoodname.Enabled = True
            txtfoodname.Focus()


        End If
       
    End Sub

    Private Sub txtfoodname_Click(sender As Object, e As System.EventArgs) Handles txtfoodname.Click
        txtfoodname.SelectAll()

    End Sub

    Private Sub txtfoodname_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtfoodname.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            butfixfood.Focus()

        End If
    End Sub

    Private Sub txtfoodname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfoodname.TextChanged
        Try

      
        ComboBox4.Items.Clear()

        lsthint.Items.Clear()
        con.Close()

        connect()
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select  food from foodlist where food like '" + txtfoodname.Text + "'+'%'"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            ComboBox1.Items.Add(dr("food"))
        End While
        cmd.Dispose()
        con.Close()
        lsthint.Items.Clear()

        connect()
        'con.ConnectionString = " Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\food02.mdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select food from foodlist where food like '%'+'" + txtfoodname.Text + "'+'%'"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            lsthint.Items.Add(dr("food"))
        End While
        cmd.Dispose()
        con.Close()
        If (lsthint.Items.Count = 1) Then
            butfixfood.Enabled = True

            ElseIf (lsthint.Items.Count = 0) Then
                NotifyIcon1.BalloonTipText = "No such Food Present Please Add this food Name to Food Database then Use this food name"
                NotifyIcon1.ShowBalloonTip(210)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub lsthint_Click(sender As Object, e As System.EventArgs) Handles lsthint.Click
        'If (lsthint.Items.Count = 0) Then

        '        Else

        'Try
        ' txtfoodname.Text = lsthint.SelectedItem.ToString()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        '
        '
        '        End Try


        'End If
    End Sub

    Private Sub lsthint_DoubleClick(sender As Object, e As System.EventArgs) Handles lsthint.DoubleClick
        If (lsthint.Items.Count = 0) Then

        Else

            Try
                txtfoodname.Text = lsthint.SelectedItem.ToString()
            Catch ex As Exception
                MsgBox(ex.Message)


            End Try

        End If
    End Sub

    Private Sub lsthint_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lsthint.SelectedIndexChanged
        Try

            If (lsthint.Items.Count = 0) Then
                NotifyIcon1.BalloonTipText = "Click on fix food name to continue"
                NotifyIcon1.ShowBalloonTip(210)

            Else
                Try
                    txtfoodname.Text = lsthint.SelectedItem.ToString()
                Catch ex As Exception
                    MsgBox(ex.Message)


                End Try


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub butfixfood_Click(sender As System.Object, e As System.EventArgs) Handles butfixfood.Click
        Try

      
        If (MsgBox("Are You sure to fix Food Name", MsgBoxStyle.YesNo, "Conformation of food  ") = MsgBoxResult.Yes) Then
                '  butadd.Enabled = True
            cmbunit.Enabled = True
            butclear.Enabled = True

            cmbunit.Items.Clear()

            con.Close()
            connect()
            txtfoodname.Enabled = False

            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from foodlist where food='" + txtfoodname.Text + "'"
            dr = cmd.ExecuteReader()
            While (dr.Read())
                ComboBox4.Items.Add(dr("food"))

            End While
            If (ComboBox4.Items.Count = 1) Then
                butfixfood.Enabled = True
                connect()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from foodlist where food='" + txtfoodname.Text + "'"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    unit = (dr("measure"))

                End While
                cmd.Dispose()
                con.Close()
                If (unit = 1) Then
                        cmbunit.Items.Add("1 ml")
                        cmbunit.Items.Add("30 ml")
                        cmbunit.Items.Add("45 ml")
                        cmbunit.Items.Add("60 ml")
                        cmbunit.Items.Add("90 ml")
                        cmbunit.Items.Add("100 ml")
                        cmbunit.Items.Add("200 ml/1cup")
                        cmbunit.Items.Add("250 ml/1 glass")
                        cmbunit.Items.Add("500 ml/1 bottle")
                        cmbunit.Items.Add("1 liter")
                ElseIf (unit = 2) Then
                    cmbunit.Items.Add("1 Gms")
                    cmbunit.Items.Add("15 Gms")
                    cmbunit.Items.Add("20 Gms")
                    cmbunit.Items.Add("25 Gms")
                    cmbunit.Items.Add("50 Gms")
                    cmbunit.Items.Add("85 Gms")
                    cmbunit.Items.Add("100 Gms")
                        cmbunit.Items.Add("150 Gms")
                        cmbunit.Items.Add("200 Gms/1 cup")
                        cmbunit.Items.Add("250 Gms/1 glass")
                        cmbunit.Items.Add("500 Gms")



                    cmbunit.Items.Add("1 KG")
                ElseIf (unit = 3) Then
                    cmbunit.Items.Add("1/2 tbsp")
                    cmbunit.Items.Add("1 tbsp")
                    cmbunit.Items.Add("2 tbsp")
                    cmbunit.Items.Add("3 tbsp")

                ElseIf (unit = 4) Then
                        cmbunit.Items.Add("1/2 Noc")
                        cmbunit.Items.Add("1 Noc")
                        cmbunit.Items.Add("2 Noc")
                        cmbunit.Items.Add("3 Noc")
                        cmbunit.Items.Add("4 Noc")
                        cmbunit.Items.Add("5 Noc")
                        cmbunit.Items.Add("1/4 Noc")
                        cmbunit.Items.Add("3/4 Noc")
                    'Cmbunit.Items.Add("Large")
                ElseIf (unit = 5) Then
                    cmbunit.Items.Add("1/2 Cup")
                    cmbunit.Items.Add("1 Cup")
                    cmbunit.Items.Add("2 Cup")

                ElseIf (unit = 6) Then
                    cmbunit.Items.Add("1/2 OZ")
                    cmbunit.Items.Add("1 OZ")
                    cmbunit.Items.Add("2 OZ")
                ElseIf (unit = 7) Then
                    cmbunit.Items.Add("1/2 Piceses")
                    cmbunit.Items.Add("1 Piceses")
                    cmbunit.Items.Add("2 Piceses")
                ElseIf (unit = 8) Then
                    cmbunit.Items.Add("1 Fl.oz")
                    cmbunit.Items.Add("3.5 Fl.oz")
                    cmbunit.Items.Add("12 Fl.oz")





                End If
                    NotifyIcon1.BalloonTipText = "Now Select Food Quantity In Next Drop Down box"
                    NotifyIcon1.ShowBalloonTip(500)

                cmbunit.Focus()


            Else
                butfixfood.Enabled = False
                txtfoodname.Clear()



                MsgBox("Please enter a valid food name...")
                txtfoodname.Clear()

            End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub butexit_Click(sender As System.Object, e As System.EventArgs) Handles butexit.Click
        If (MsgBox("Are you shure to exit..") = MsgBoxResult.Ok) Then
            My.Computer.Audio.Play(My.Resources._exit, AudioPlayMode.WaitToComplete)

            End

        End If
       End Sub

    Private Sub cmbunit_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbunit.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            butadd.Focus()

        End If
    End Sub

    Private Sub cmbunit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbunit.SelectedIndexChanged
        butadd.Enabled = True

        TextBox2.Text = txtfoodname.Text
        TextBox3.Text = cmbunit.Text

    End Sub

    Private Sub linknewuser_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linknewuser.LinkClicked
        previous_data.Show()

    End Sub

    Private Sub txttotalitem_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttotalitem.TextChanged
        Button5.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If (MsgBox("Are you sure to continue... ") = MsgBoxResult.Ok) Then


            Try

                My.Computer.Audio.Play(My.Resources.generating_result, AudioPlayMode.WaitToComplete)

                connect()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "insert into intake (ID,d,calorie) values ('" + TextBox4.Text + "','" + DateTimePicker1.Value.Date.ToString() + "'," + txttotalcal.Text + ")"
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()


                Dim w As Integer

                ' ComboBox1.Items.Clear()

                con.Close()
                connect()

                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select weight from userinfo where username ='" + login.txtuser.Text + "'"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    TextBox6.Text = dr("weight").ToString()




                End While
                cmd.Dispose()
                con.Close()
                w = Val(TextBox6.Text)
                con.Close()
                Me.Opacity = 50

                If (w < 42) Then
                    If (MsgBox("Your total calorie intake is =" + txttotalcal.Text) = MsgBoxResult.Ok) Then
                        Me.Opacity = 98


                    End If

                Else

                    TextBox7.Text = (w * 24).ToString()
                    TextBox8.Text = (w * 24) - 500

                    If (Val(TextBox7.Text) > Val(txttotalcal.Text)) Then
                        MsgBox("Total Calorie Intake=" + txttotalcal.Text + Chr(13) + "Range of Normal Calorie According To Your Total Weight=" + TextBox6.Text + Chr(13) + "Should Be In Between 1000 to " + TextBox7.Text + Chr(13) + "You Must Increase Your Calorie Intake For Normal Health" + Chr(13) + "Do Not Decrease Your Calorie Intake By=" + TextBox8.Text, MsgBoxStyle.Information, "Report")

                    ElseIf (Val(TextBox7.Text) < Val(txttotalcal.Text)) Then
                        MsgBox("Total Calorie Intake=" + txttotalcal.Text + Chr(13) + "Range of Normal Calorie According To Your Total Weight=" + TextBox6.Text + Chr(13) + "Should Be In Between 1000 to " + TextBox7.Text + Chr(13) + "Your Calorie Intake Is More Then Your maximum Limit If you Do Not Want Gain More Weight You Must Decrease Your Calorie Intake" + Chr(13) + "Do Not Decrease Your Calorie Intake By=" + TextBox8.Text, MsgBoxStyle.Information, "Report")

                    Else
                        MsgBox("Total Calories=" + txttotalcal.Text + Chr(13) + "Range of Normal Calorie According To Your Total Weight=" + TextBox6.Text + Chr(13) + "Should Be In Between 1000 to " + TextBox7.Text + Chr(13) + Chr(13) + "Do Not Decrease Your Calorie Intake By=" + TextBox8.Text, MsgBoxStyle.Information, "Report")


                    End If

                End If
                Me.Opacity = 98


                '   txttotalcal.Text
                '  DateTimePicker1.Value.Date
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles butclear.Click
        Try
            butadd.Enabled = False
       
        txtfoodname.Clear()
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select food from foodlist where food like '%'+'" + txtfoodname.Text + "'+'%'"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            lsthint.Items.Add(dr("food"))
        End While
        cmd.Dispose()
        con.Close()
        cmbunit.Text = "-Unit-"
        butfixfood.Enabled = False
        cmbunit.Enabled = False
        butadd.Enabled = False
        txtfoodname.Enabled = True

            txtfoodname.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles butadddata.Click
        up.Show()
        up.butupdate.Enabled = False

        up.butadd.Enabled = True


    End Sub

    Private Sub butupdate_Click(sender As System.Object, e As System.EventArgs) Handles butupdate.Click
        up.Show()
        up.butupdate.Enabled = True
        up.butadd.Enabled = False

    End Sub

    Private Sub butfixfood_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles butfixfood.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            cmbunit.Focus()

        End If
    End Sub
End Class