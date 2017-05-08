Public Class login

    Private Sub butexit_Click(sender As System.Object, e As System.EventArgs) Handles butexit.Click
        My.Computer.Audio.Play(My.Resources._exit, AudioPlayMode.WaitToComplete)

        End

    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtpass.Focus()

        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            butlogin.Focus()

        End If
    End Sub

    Private Sub txtpass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.ShowBalloonTip(150)
        txtuser.Focus()

    End Sub

    Private Sub butlogin_Click(sender As System.Object, e As System.EventArgs) Handles butlogin.Click
        Try

       
        con.Close()
        connect()

        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\userinfo.mdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from userinfo where username='" + txtuser.Text + "'"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            If ((dr("pass").ToString = txtpass.Text)) Then
                combobox1.Items.Add(dr("username"))

                calculater.TextBox4.Text = dr("ID").ToString()


            Else

                ' MsgBox("Please Enter A Valid PAssword", MsgBoxStyle.Information, "Wrong Password")
                'txtpass.Clear()

            End If

        End While
        If (combobox1.Items.Count = 1) Then
                Me.Hide()
                My.Computer.Audio.Play(My.Resources.login_successful, AudioPlayMode.Background)

            calculater.Show()
        Else
            MsgBox("Please Enter Valid Username And Password", MsgBoxStyle.Information, "User Login")
            txtuser.Clear()

            txtpass.Clear()
            txtuser.Focus()



        End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub linknewuser_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linknewuser.LinkClicked
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.create_a_new_user_account, AudioPlayMode.Background)

        new_user.Show()

    End Sub
End Class
