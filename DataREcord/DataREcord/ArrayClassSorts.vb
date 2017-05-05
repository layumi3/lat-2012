Public Class ArrayClassSorts
    Dim RandArray(0 To 499) As Long
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To RandArray.GetUpperBound(0)
            RandArray(i) = Int(Rnd() * 1000000)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i
        Next i
    End Sub

    Private Sub ArrayClassSorts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = UBound(RandArray)
        Label1.Text = UBound(RandArray) + 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        TextBox1.Text = ""
        Array.Sort(RandArray)
        For i = 0 To UBound(RandArray)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        TextBox1.Text = ""
        Array.Reverse(RandArray)
        For i = 0 To RandArray.GetUpperBound(0)
            TextBox1.Text = TextBox1.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i
        Next i
    End Sub
End Class