Public Class Form4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Enabled = True Then
            Timer1.Start()
            Label2.Text = Label2.Text + 1
        End If
        If Label2.Text = 10 Then
            MsgBox("Anda Harus Lanjut Ke pertanyaan Selanjutnya")
            Timer1.Stop()
            Form5.Show()
            Form3.Hide()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jawaban(3) As String
        jawaban(0) = RadioButton1.Text
        jawaban(1) = RadioButton2.Text
        jawaban(2) = RadioButton3.Text
        jawaban(3) = RadioButton4.Text

        If RadioButton2.Checked = True Then
            MsgBox("Jawaban Anda Adalah Benar")
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak("Correct Answer")
        Else
            MsgBox("Jawaban Anda Adalah Salah")
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak("Wrong Answer")
        End If

    End Sub

End Class