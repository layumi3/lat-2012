Public Class kalkulatorPintar
    Dim angkaPertama As Long
    Dim calculate As String

    Private Sub kalkulatorPintar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 2
        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 3
        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 4
        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 5
        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 6
        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 7
        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 8
        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 9
        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = 0
        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        angkaPertama = TextBox1.Text
        TextBox1.Text = "0"
        calculate = "+"
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        angkaPertama = TextBox1.Text
        TextBox1.Text = "0"
        calculate = "-"
    End Sub

    Private Sub Times_Click(sender As Object, e As EventArgs) Handles Times.Click
        angkaPertama = TextBox1.Text
        TextBox1.Text = "0"
        calculate = "*"
    End Sub

    Private Sub Devide_Click(sender As Object, e As EventArgs) Handles Devide.Click
        angkaPertama = TextBox1.Text
        TextBox1.Text = "0"
        calculate = "/"
    End Sub

    Private Sub process_Click(sender As Object, e As EventArgs) Handles process.Click
        Dim angkakedua As Long
        Dim hasil As Long
        angkakedua = TextBox1.Text
        If calculate = "+" Then
            hasil = angkaPertama + angkakedua
        ElseIf calculate = "-" Then
            hasil = angkaPertama - angkakedua
        ElseIf calculate = "*" Then
            hasil = angkaPertama * angkakedua
        ElseIf calculate = "/" Then
            hasil = angkaPertama / angkakedua
        End If
        angkaPertama = hasil
        TextBox1.Text = hasil
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = ""
    End Sub
End Class