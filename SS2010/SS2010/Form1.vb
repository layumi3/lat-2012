Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lastname As String
        lastname = "Ayumsari"
        Label1.Text = lastname

        lastname = "Lilis Ayumsari"
        Label2.Text = lastname




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim prompt, fullname As String
        prompt = "Please enter your name"
        fullname = InputBox(prompt)
        Label4.Text = fullname
        MsgBox(fullname, , "In Result")



    End Sub
End Class
