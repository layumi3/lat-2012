Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.rate = TrackBar1.Value
        sapi.speak(TextBox1.Text)
    End Sub
End Class
