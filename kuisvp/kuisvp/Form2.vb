Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "TI" Then
            MsgBox("Lanjut ? ", MsgBoxStyle.OkOnly)
        ElseIf TextBox1.Text = "SI" Then
            MsgBox("Lanjut ? ", MsgBoxStyle.OkOnly)
        ElseIf TextBox1.Text = "MI" Then
            MsgBox("Lanjut ? ", MsgBoxStyle.OkOnly)
        ElseIf TextBox1.Text = "TK" Then
            MsgBox("Lanjut ? ", MsgBoxStyle.OkOnly)
        ElseIf TextBox1.Text = "KA" Then
            MsgBox("Lanjut ? ", MsgBoxStyle.OkOnly)
        ElseIf MsgBox("Masukkan hanya jurusan MI/TI/TK/KA/SI ", MsgBoxStyle.OkOnly) Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim masuk, hasil As String
        masuk = TextBox1.Text
        hasil = TextBox2.Text

        If masuk = "TI" Then
            hasil = "Teknik Informatika"
            TextBox2.Text = hasil
        ElseIf masuk = "SI" Then
            hasil = "Sistem Informasi"
            TextBox2.Text = hasil
        ElseIf masuk = "MI" Then
            hasil = "Managemen Informasi"
            TextBox2.Text = hasil
        ElseIf masuk = "TK" Then
            hasil = "Teknik Komputer"
            TextBox2.Text = hasil
        ElseIf masuk = "KA" Then
            hasil = "Komputer Akuntansi"
            TextBox2.Text = hasil
        ElseIf MsgBox("Masukkan hanya jurusan MI/TI/TK/KA/SI ", MsgBoxStyle.OkOnly) Then
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kalimat, data1, data2, data3, data4, data5, space As String
        data1 = TextBox3.Text
        data2 = TextBox4.Text
        data3 = TextBox5.Text
        data4 = TextBox6.Text
        data5 = TextBox7.Text
        space = "   "
        kalimat = data1 & space & data2 & space & data3 & space & data4 & space & data5
        TextBox8.Font = New Font("Verdana", TextBox8.Font.Size, FontStyle.Italic, FontStyle.Bold)
        TextBox8.Text = kalimat
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class