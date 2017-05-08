Public Class up

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.back, AudioPlayMode.Background)

        Me.Hide()


    End Sub

    Private Sub up_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            ComboBox1.Focus()


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            TextBox3.Focus()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim s As Integer

        If (ComboBox1.SelectedItem = "ml/l") Then
            s = 1
            Label5.Text = "ml"
        ElseIf (ComboBox1.SelectedItem = "Grams/Kg") Then
            s = 2
            Label5.Text = "gm"
        ElseIf (ComboBox1.SelectedItem = "Tbsp") Then
            s = 3
            Label5.Text = "tbsp"
        ElseIf (ComboBox1.SelectedItem = "Small/Medium") Then
            s = 4
            Label5.Text = "Noc"
        ElseIf (ComboBox1.SelectedItem = "Cup") Then
            s = 5
            Label5.Text = "cup"
        ElseIf (ComboBox1.SelectedItem = "Oz") Then
            s = 6
            Label5.Text = "oz"
        ElseIf (ComboBox1.SelectedItem = "Pices") Then
            s = 7
            Label5.Text = "Pices"
        ElseIf (ComboBox1.SelectedItem = "Fl.Oz") Then
            s = 8
            Label5.Text = "Fl oz"

        End If
        TextBox2.Text = s.ToString()




    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            butupdate.Focus()

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If (IsNumeric(TextBox3.Text)) Then
        Else
            MsgBox("Enter A Valid Number")
            TextBox3.Clear()
            TextBox3.Focus()

        End If
    End Sub

    Private Sub butupdate_Click(sender As System.Object, e As System.EventArgs) Handles butupdate.Click
        If (TextBox3.Text.Count = 0 Or TextBox1.Text.Count = 0) Then
            MsgBox("Please Fill All Info. properly")

        Else

            connect()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update foodlist set food='" + TextBox1.Text + "',measure='" + TextBox2.Text + "',calories='" + TextBox3.Text + "' where food='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub butadd_Click(sender As System.Object, e As System.EventArgs) Handles butadd.Click
        If (TextBox3.Text.Count = 0 Or TextBox1.Text.Count = 0) Then
            MsgBox("Please Fill All Info. properly")
        Else
            connect()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into foodlist (food,measure,calories) values ('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ")"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Data Saved Successfully", MsgBoxStyle.Information)

        End If

    End Sub
End Class