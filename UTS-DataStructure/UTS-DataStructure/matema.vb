Public Class matema
    Dim luas, keliling As String
    Dim alas, tinggi As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas = 0
        alas = 0
        tinggi = 0
        'If alas = "" Or tinggi = "" Then
        '    MsgBoxStyle.RetryCancel.ToString("Masukkan Angka Perhitungan!")
        'End If
        alas = MaskedTextBox1.Text.ToString
        tinggi = MaskedTextBox2.Text.ToString
        If CheckBox1.Checked = True Then
            luas = (alas * tinggi) / 2
            MsgBox("alas = " + MaskedTextBox1.Text + "\n" + MaskedTextBox2.Text + "\n" + "/n maka luasnnya?")
            'TextBox1.Text = luas
        ElseIf CheckBox2.Checked = True Then
            luas = MaskedTextBox1.Text * MaskedTextBox2.Text
        ElseIf CheckBox3.Checked = True Then
            luas = (22 / 7) * MaskedTextBox1.Text * MaskedTextBox1.Text
        End If
        TextBox1.Text = luas

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        alas = MaskedTextBox1.Text.ToString
        tinggi = MaskedTextBox2.Text.ToString
        If CheckBox1.Checked = True Then
            keliling = alas + tinggi + tinggi
        ElseIf CheckBox2.Checked = True Then
            keliling = (2 * MaskedTextBox1.Text) + (2 * MaskedTextBox2.Text)
        ElseIf CheckBox3.Checked = True Then
            keliling = 2 * (22 / 7) * MaskedTextBox1.Text
        End If
        TextBox1.Text = keliling
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = False Then
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            labelA.Text = "Ukuran A"
            labelB.Text = "Ukuran B"
        ElseIf CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            labelA.Text = "Ukuran Alas"
            labelB.Text = "Ukuran Tinggi/sisi"
            labelB.Visible = True
            MaskedTextBox2.Enabled = True
            MaskedTextBox2.Visible = True

        End If
        'If CheckBox1.CheckState = CheckState.Checked Then
        '    labelA.Text = "Ukuran Alas" And labelB.Text = "Ukuran Tinggi"
        'End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            labelA.Text = "Ukuran A"
            labelB.Text = "Ukuran B"
        ElseIf CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            labelA.Text = "Ukuran Panjang"
            labelB.Text = "Ukuran Lebar"
            labelB.Visible = True
            MaskedTextBox2.Enabled = True
            MaskedTextBox2.Visible = True

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            labelA.Text = "Ukuran A"
            labelB.Text = "Ukuran B"
        ElseIf CheckBox3.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            labelA.Text = "Ukuran Jari-Jari"
            labelB.Visible = False
            MaskedTextBox2.Enabled = False
            MaskedTextBox2.Visible = False
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            labelA.Text = "Ukuran A"
            labelB.Text = "Ukuran B"
        End If
        
    End Sub

    'Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
    '    If MaskedTextBox1.Text = "" Then
    '        MessageBox.Show("Masukkan Ukuran berupa angka!!")
    '    End If
    'End Sub
    'Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected
    '    If MaskedTextBox2.Text = "" Then
    '        MessageBox.Show("Masukkan Ukuran berupa angka!!")
    '    End If
    'End Sub

    
End Class