Public Class Form1
    Public Structure dataRecord
        Dim kode, nama, in1, in2 As String
        Dim sparator As String
        Dim display As String
    End Structure
    Dim tampildata(0 To 2000) As dataRecord
    Dim i, jumlah As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
        'COMMAND END
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        'COMMAND CLEAR
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Dim dis As String
        Dim sparator As String
        tampildata(i).kode = TextBox2.Text
        tampildata(i).nama = TextBox3.Text
        tampildata(i).in1 = TextBox4.Text
        tampildata(i).in2 = TextBox5.Text
        sparator = " > "


        For i = 0 To jumlah
            jumlah = 0
            tampildata(i).display = tampildata(i).kode & sparator & tampildata(i).nama & sparator & tampildata(i).in1 & sparator & tampildata(i).in2 & Chr(13)
            i = i + 2
        Next i

        For i = 0 To jumlah
            jumlah = 0
            dis = tampildata(i).kode & sparator & tampildata(i).nama & sparator & tampildata(i).in1 & sparator & tampildata(i).in2 & Chr(13)
        Next
        dis = dis + tampildata(i).display
        '  jumlah = i + 1
        'TextBox1.Text = dis

        ListBox1.Text = dis
        ListBox1.Items.Add(dis)
        ' Command Display 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j As Integer
        Dim dis As String
        Dim z As String
        Dim temp As dataRecord
        z = " > "
        jumlah = 2
        For i = 0 To jumlah
            For j = jumlah To i + 1 Step -1
                If tampildata(j).kode < tampildata(j - 1).kode Then
                    temp = tampildata(j)
                    tampildata(j) = tampildata(j - 1)
                    tampildata(j) = temp
                End If
            Next j
        Next
        For i = 0 To jumlah
            tampildata(i).display = tampildata(i).kode & tampildata(i).kode & tampildata(i).nama & tampildata(i).in1 & tampildata(i).in2 & Chr(13)
        Next
        ListBox1.Text = dis
        'command descending
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dis As String
        Dim i, j As Integer
        Dim z As String
        Dim temp As dataRecord
        z = " > "
        jumlah = 2
        For i = 0 To jumlah
            For j = jumlah To i + 1 Step 1
                If tampildata(j).kode < tampildata(j + 1).kode Then
                    temp = tampildata(j)
                    tampildata(j) = tampildata(j + 1)
                    tampildata(j) = temp
                End If
            Next j
        Next
        For i = 0 To jumlah
            tampildata(i).display = tampildata(i).kode & tampildata(i).nama & tampildata(i).in1 & tampildata(i).in2 & Chr(13)
        Next
        ListBox1.Text = dis
        'command ascending

        '    Sub ShellSort(ByVal sort() As String, ByVal numOfElements As Short)
        '    Dim temp As String
        '    Dim i, j, span As Short
        '    'The ShellSort procedure sorts the elements of sort()     
        '    'array in descending order and returns it to the calling    
        '    'procedure.       
        '    span = numOfElements \ 2
        '    Do While span > 0
        '        For i = span To numOfElements - 1
        '            For j = (i - span) To 0 Step -span
        '                If sort(j) <= sort(j + span) Then Exit For
        '                'swap array elements that are out of order                
        '                temp = sort(j)
        '                sort(j) = sort(j + span)
        '                sort(j + span) = temp
        '            Next j
        '        Next i
        '        span = span \ 2
        '    Loop
        'End Sub


        'Dim strArray() As String
        'Dim sText As String
        '    dis = ListBox1.Text
        ''replace different new line characters with one version
        '    dis = dis.Replace(vbCrLf, vbCr)
        '    dis = dis.Replace(vbLf, vbCr)
        ''remove last carriage return if it exists
        '    If dis.EndsWith(vbCr) Then
        '        dis = dis.Substring(0, dis.Length - 1)
        '    End If
        ''split each line in to an array 
        '    strArray = dis.Split(vbCr)
        ''sort array 
        '    ShellSort(strArray, strArray.Length)
        ''then display sorted array in text box 
        '    dis = ""

        '    For i = 0 To strArray.Length - 1
        '        dis = dis & strArray(i) & vbCrLf
        '    Next i
        '    ListBox1.Text = dis
        '    ListBox1.Select(0, 0)
        ''remove text selection 

    End Sub
End Class
