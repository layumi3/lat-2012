Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jawaban As String
        jawaban = ComboBox1.Text
        Select Case jawaban
            Case "17 Agustus"
                Label2.Text = ComboBox1.Text
                Dim sapi
                sapi = CreateObject("sapi.spvoice")
                sapi.speak("Correct Answer")
            Case "18 Agustus"
                Label2.Text = "Wrong"
                Dim sapi
                sapi = CreateObject("sapi.spvoice")
                sapi.speak("Wrong wrong wrong wrong")
            Case "21 April"
                Label2.Text = "True"
                Dim sapi
                sapi = CreateObject("sapi.spvoice")
                sapi.speak("Wrong wrong wrong wrong")
            Case "24 April"
                Label2.Text = "Wrong"
                Dim sapi
                sapi = CreateObject("sapi.spvoice")
                sapi.speak("Wrong wrong wrong wrong")
        End Select
        'ComboBox1.Text = Label2.Text
        'Label2.Text = ComboBox1.Text


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Enabled = True Then
            Timer1.Start()
            Label3.Text = Label3.Text + 1
        End If
        If Label3.Text = 10 Then
            MsgBox("Anda Harus Lanjut Ke pertanyaan Selanjutnya")
            Timer1.Stop()
            Form4.Show()
            Form2.Hide()


        End If
    End Sub
End Class