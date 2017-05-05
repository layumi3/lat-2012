Public Class kusi
    Public Structure DataRecord
        Dim kode As String
        Dim kelas As String
        Dim Sks As String
        Dim Instruktur1 As String
        Dim Instruktur2 As String
        Dim display As String
    End Structure
    Dim recod(0 To 200) As DataRecord
    Dim Display As String
    Dim jumlah, i As Integer
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim spasi As String
        spasi = " > "
        For i = 0 To jumlah
            Display = recod(i).kode + spasi & recod(i).kelas + spasi & recod(i).Sks + spasi & recod(i).Instruktur1 + spasi & recod(i).Instruktur2 + Chr(13)
        Next i
        Display = Display + recod(i).display
        jumlah = i + 1
        RichTextBox1.Text = Display
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        recod(i).kode = TextBox1.Text
        recod(i).kelas = TextBox2.Text
        recod(i).Sks = TextBox3.Text
        recod(i).Instruktur1 = TextBox4.Text
        recod(i).Instruktur2 = TextBox5.Text
        recod(i).display = recod(i).kode & recod(i).kelas & recod(i).Sks & recod(i).Instruktur1 & recod(i).Instruktur2 & Chr(13)
        i = i + 2
        jumlah = 0
        recod(i).kode = ""
        recod(i).kelas = ""
        recod(i).Sks = ""
        recod(i).Instruktur1 = ""
        recod(i).Instruktur2 = ""
        MsgBox("Data Disimpan")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j As Integer
        Dim z As String
        Dim temp As DataRecord
        z = " > "
        jumlah = 2
        For i = 0 To jumlah
            For j = jumlah To i + 1 Step -1
                If recod(j).kelas < recod(j - 1).kelas Then
                    temp = recod(j)
                    recod(j) = recod(j - 1)
                    recod(j - 1) = temp
                End If
            Next j
        Next
        For i = 0 To jumlah
            recod(i).display = recod(i).kode & recod(i).kelas & recod(i).Sks & recod(i).Instruktur1 & recod(i).Instruktur2 & Chr(13)
        Next
        '  RichTextBox1.Text = recod(i)
    End Sub
 Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        Dim z As String
        Dim temp As DataRecord
        z = " > "
        jumlah = 2
        For i = 0 To jumlah
            For j = jumlah To i + 1 Step 1
                If recod(j).kelas < recod(j + 1).kelas Then
                    temp = recod(j)
                    recod(j) = recod(j + 1)
                    recod(j) = temp
                End If
            Next j
        Next
        For i = 0 To jumlah
            recod(i).display = recod(i).kode & recod(i).kelas & recod(i).Sks & recod(i).Instruktur1 & recod(i).Instruktur2 & Chr(13)
        Next
        'RichTextBox1.Text = recod(i)
    End Sub
End Class