Public Class MyBirth

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & DateTimePicker1.Value.DayOfYear.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim input As String = """"
        If CheckBox1.Checked Then
            input += CheckBox1.Text + " = " + TextBox1.Text + ","
        End If
        If CheckBox2.Checked Then
            input += CheckBox2.Text + " = " + TextBox2.Text + ","
        End If
        If CheckBox3.Checked Then
            input += CheckBox3.Text + " = " + TextBox3.Text + ","
        End If
        If CheckBox4.Checked Then
            input += CheckBox4.Text + " = " + TextBox4.Text + ","
        End If
        MsgBox("Nilai " + input)
    End Sub
End Class