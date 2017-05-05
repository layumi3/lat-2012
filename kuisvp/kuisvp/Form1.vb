Public Class Form1
    Dim langkah, awal, akhir As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If langkah = "" Then
        '    MsgBox("Kesalahan Terjadi, Ulang", MsgBoxStyle.OkOnly)
        'ElseIf awal = "" Then
        '    MsgBox("Kesalahan Terjadi, Ulang", MsgBoxStyle.OkOnly)
        'ElseIf akhir = "" Then
        '    MsgBox("Kesalahan Terjadi, Ulang", MsgBoxStyle.OkOnly)
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        langkah = TextBox4.Text
        awal = TextBox2.Text
        akhir = TextBox3.Text

        For i = awal To akhir Step langkah
            TextBox1.Text = TextBox1.Text & i & Chr(13) & Chr(10)
        Next i

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        langkah = TextBox4.Text
        awal = TextBox2.Text
        akhir = TextBox3.Text
        Do While awal < akhir
            TextBox1.Text = TextBox1.Text & awal & Chr(13) & Chr(10)
            awal = awal + langkah
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        langkah = TextBox4.Text
        awal = TextBox2.Text
        akhir = TextBox3.Text
        Do
            TextBox1.Text = TextBox1.Text & awal & Chr(13) & Chr(10)
            awal = awal + langkah
        Loop Until akhir < awal

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        langkah = TextBox4.Text
        awal = TextBox2.Text
        akhir = TextBox3.Text
        While awal < akhir
            TextBox1.Text = TextBox1.Text & awal & Chr(13) & Chr(10)
            awal = awal + langkah
        End While
    End Sub
End Class
