Public Class Form3
    Public Structure dataProduct
        Dim product_id As String
        Dim product_name As String
        Dim product_price As String
        Dim qhh As Integer
    End Structure

    Dim product(0 To 100) As dataProduct
    Dim i, j, k, jumlah As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'displa
        Dim temptext As String
        temptext = ""
        ListBox1.Items.Clear()

        For i = 0 To jumlah
            temptext = CStr(i + 1) + "    "
            temptext = temptext + product(i).product_id + " `"
            temptext = temptext + product(i).product_name + "`"
            temptext = temptext + product(i).product_price + "  "
            temptext = temptext + product(i).qhh
            temptext = temptext
            ListBox1.Items.Add(temptext)

        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'INSERT

        jumlah = jumlah + 1
        product(jumlah).product_id = TextBox1.Text
        product(jumlah).product_name = TextBox2.Text
        product(jumlah).product_price = TextBox3.Text
        product(jumlah).qhh = CInt(TextBox4.Text)

        Dim temptext As String
        temptext = ""
        For i = 0 To jumlah
            temptext = CStr(i + 1) + "    "
            temptext = temptext + product(i).product_id + " "
            temptext = temptext + product(i).product_name + "   "
            temptext = temptext + product(i).product_price + "  "
            temptext = temptext + CStr(product(i).qhh)
            temptext = temptext
            ListBox1.Items.Add(temptext)
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class