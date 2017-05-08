Public Class previous_data

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub previous_data_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.previous_data, AudioPlayMode.Background)

        Label3.Text = login.txtuser.Text + "'s Calorie Intake"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        connect()
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from intake where ID =" + (calculater.TextBox4.Text) + ""
        dr = cmd.ExecuteReader()
        '  dataviwer.ListBox1.Items.Add()
        While (dr.Read())
            ListBox1.Items.Add(dr("d"))
            ListBox2.Items.Add(dr("calorie"))
            
        End While
        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

            Dim i As Integer
            i = ListBox1.SelectedIndex

            ListBox2.SelectedIndex = i
          

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Try

            Dim i As Integer
            i = ListBox2.SelectedIndex

            ListBox1.SelectedIndex = i


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class