Public Class FrmTiket

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MsgBox("Tiket Kereta " & TextBox4.Text & Chr(13) & Chr(13) &
                    "Nama        : " & TextBox3.Text & Chr(13) &
                    "No Id       : " & TextBox2.Text & Chr(13) &
                    "Tujuan      : " & ComboBox2.Text & Chr(13) &
                    "Jml Tiket   : " & TextBox6.Text & Chr(13) &
                    "Harga       : " & TextBox5.Text & Chr(13) &
                    "Biaya       : " & TextBox7.Text & Chr(13) & Chr(13) &
                    ("Terima kasih Telah Menggunakan Jasa Trasportasi Kereta Api") & Chr(13) & TextBox1.Text, MsgBoxStyle.OkOnly
                    )

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case (ComboBox1.Text)
            Case "ARG"
                TextBox4.Text = "ARGO WILIS"
            Case "TRG"
                TextBox4.Text = "TURANGGA"
            Case "MTS"
                TextBox4.Text = "MUTIARA SELATAN"
            Case "HRN"
                TextBox4.Text = "HARINA"
            Case "PRY"
                TextBox4.Text = "PARAYANGAN"
            Case "PSD"
                TextBox4.Text = "PASUNDAN"
            Case "JER"
                TextBox4.Text = "JOHAR EXPRES"
            Case "MLB"
                TextBox4.Text = "MALABAR"
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        
        
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'If RadioButton1.Checked = True And ComboBox2.Text = "Bandung-Surabaya" Then
        '    TextBox5.Text = 300000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Jakarta -Bandung" Then
        '    TextBox5.Text = 90000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Bandung-Tasik" Then
        '    TextBox5.Text = 100000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Cirebon-Bandung" Then
        '    TextBox5.Text = 120000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Solo-Bandung" Then
        '    TextBox5.Text = 200000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Jogja-Bandung" Then
        '    TextBox5.Text = 180000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Jakarta-Surabaya" Then
        '    TextBox5.Text = 350000
        'ElseIf RadioButton1.Checked = True And ComboBox2.Text = "Jakarta-Jogja" Then
        '    TextBox5.Text = 250000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Bandung-Surabaya" Then
        '    TextBox5.Text = 450000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Jakarta -Bandung" Then
        '    TextBox5.Text = 120000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Bandung-Tasik" Then
        '    TextBox5.Text = 150000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Cirebon-Bandung" Then
        '    TextBox5.Text = 160000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Solo-Bandung" Then
        '    TextBox5.Text = 250000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Jogja-Bandung" Then
        '    TextBox5.Text = 220000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Jakarta-Surabaya" Then
        '    TextBox5.Text = 500000
        'ElseIf RadioButton2.Checked = True And ComboBox2.Text = "Jakarta-Jogja" Then
        '    TextBox5.Text = 320000
        'End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox7.Text = Val(TextBox6.Text) * Val(TextBox5.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        MsgBox("Input Lagi ??", MsgBoxStyle.OkOnly
               )
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Select Case (ComboBox2.Text)
            Case "Bandung-Surabaya"
                TextBox5.Text = 300000
            Case "Jakarta-Bandung"
                TextBox5.Text = 90000
            Case "Bandung-Tasik"
                TextBox5.Text = 100000
            Case "Cirebon-Bandung"
                TextBox5.Text = 120000
            Case "Solo-Bandung"
                TextBox5.Text = 200000
            Case "Jogja-Bandung"
                TextBox5.Text = 180000
            Case "Jakarta-Surabaya"
                TextBox5.Text = 350000
            Case "Jakarta-Jogja"
                TextBox5.Text = 250000
        End Select
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Select Case (ComboBox2.Text)
            Case "Bandung-Surabaya"
                TextBox5.Text = 450000
            Case "Jakarta-Bandung"
                TextBox5.Text = 120000
            Case "Bandung-Tasik"
                TextBox5.Text = 150000
            Case "Cirebon-Bandung"
                TextBox5.Text = 160000
            Case "Solo-Bandung"
                TextBox5.Text = 250000
            Case "Jogja-Bandung"
                TextBox5.Text = 220000
            Case "Jakarta-Surabaya"
                TextBox5.Text = 500000
            Case "Jakarta-Jogja"
                TextBox5.Text = 320000
        End Select

    End Sub
End Class
