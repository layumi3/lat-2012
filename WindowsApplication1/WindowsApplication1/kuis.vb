Option Explicit On
Public Class kuis

    Dim Record As String
    Dim A(0 To 5) As String
    Dim i, j, temp As Integer
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'command end
        End
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' command clear
        RichTextBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim kode, nama, sks, ins1, ins2, space As String

        space = "    "
        kode = TextBox1.Text
        nama = TextBox2.Text
        sks = TextBox3.Text
        ins1 = TextBox4.Text
        ins2 = TextBox5.Text

        Record = kode & space & nama & space & sks & ins1 & space & ins2
        RichTextBox1.Text = Record
         
    End Sub

    Private Sub B_Add_Click(sender As Object, e As EventArgs) Handles B_Add.Click
        ' command add record
        Dim record As New Generic.List(Of String)

        Dim inputrecord As String
        Dim kode, nama, sks, ins1, ins2, space As String
        space = "    "
        kode = TextBox1.Text
        nama = TextBox2.Text
        sks = TextBox3.Text
        ins1 = TextBox4.Text
        ins2 = TextBox5.Text
        inputrecord = kode & space & nama & space & sks & ins1 & space & ins2
        record.Add(inputrecord)
        
        'determine how many names are in the collection and display a message 
        If record.Count >= 2 Then
            RichTextBox1.Text = "There are " & record.Count & " names: " & vbCrLf
            'sort names in alphabetical order     
            record.Sort()
        ElseIf record.Count = 1 Then
            RichTextBox1.Text = "There is 1 name:" & vbCrLf
        End If
        'then loop through collection, trim trailing spaces, and display 
        For Each Name As String In record
            RichTextBox1.Text = RichTextBox1.Text & Name.TrimEnd & vbCrLf

        Next



        'Dim kode, nama, sks, ins1, ins2 As String
        'kode = TextBox1.Text
        'nama = TextBox2.Text
        'sks = TextBox3.Text
        'ins1 = TextBox4.Text
        'ins2 = TextBox5.Text
        'Record(i) = kode & nama & sks & i1 & 12
        'RichTextBox1.Text = Record(i)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'command asc
        Dim nilaimin, indexmin As Integer

        For i = 1 To 5
            nilaimin = A(i)
            For j = i To 5
                If nilaimin > A(j) Then
                    nilaimin = A(j)
                    indexmin = j
                End If
            Next j
            If indexmin <> i Then
                temp = A(indexmin)
                A(indexmin) = A(i)
                A(i) = temp

            End If
        Next i


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'command desc
        Dim nilaimax, indexmax As Integer

        For i = 1 To 5

            nilaimax = -10000
            indexmax = 0
            For j = i To 5
                If nilaimax < A(j) Then
                    nilaimax = A(j)
                    indexmax = j
                End If
            Next j
            If indexmax <> i Then
                temp = A(indexmax)
                A(indexmax) = A(i)
                A(i) = temp

            End If
        Next i

    End Sub

    Private Sub kuis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class