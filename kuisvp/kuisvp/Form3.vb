Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox2.Text = Val(TextBox9.Text) + Val(TextBox5.Text)
    
        MsgBox("Terima kasih telah mengunjungi Counter " & Chr(13) & Chr(10) & Label1.Text & Chr(13) & Chr(10) & "Uang Bayar = Rp. " & TextBox3.Text & Chr(13) & Chr(10) & "Total Bayar = Rp. " & TextBox2.Text & Chr(13) & Chr(10) & "Uang Kembalian = Rp." & TextBox4.Text & Chr(13) & Chr(10) & "Terima kasih " & TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox2.Text = Val(TextBox8.Text) - Val(TextBox9.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case (ComboBox1.Text)
            Case "Oli"
                TextBox7.Text = 50000
            Case "Ban"
                TextBox7.Text = 200000
            Case "Speaker"
                TextBox7.Text = 100000
            Case "AC"
                TextBox7.Text = 500000
            Case "Mp3"
                TextBox7.Text = 350000
            Case "Steam"
                TextBox7.Text = 300000
            Case "Pelk"
                TextBox7.Text = 250000
            Case "Bummper"
                TextBox7.Text = 600000

        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Servic A" Then
            TextBox9.Text = 75000
        ElseIf ComboBox2.Text = "Servic B" Then
            TextBox9.Text = 100000
        ElseIf ComboBox2.Text = "Servic B" Then
            TextBox9.Text = 150000
        End If
        TextBox9.Text = TextBox8.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox5.Text = Val(TextBox7.Text) * Val(TextBox6.Text)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TextBox8.Text = TextBox9.Text
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox4.Text = Val(TextBox3.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class