Public Class Form2
    Public Structure datakelas
        Dim kodekelas, namakelas, instruktur1, instruktur2 As String
        Dim sks As Integer
        Dim sparator As String
        Dim display As String
    End Structure
    Dim tampildata(0 To 2000) As datakelas
    Dim i, j, jumlah As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("KODEKELAS")
        ComboBox1.Items.Add("NAMAKELAS")
        ComboBox1.Items.Add("INSTRUKTUR1")
        ComboBox1.Items.Add("INSTRUKTUR2")

        tampildata(0).kodekelas = "DS-111"
        tampildata(0).namakelas = "DATA STUKTUR"
        tampildata(0).sks = 4
        tampildata(0).instruktur1 = "POPON"
        tampildata(0).instruktur2 = "INZAN"

        tampildata(1).kodekelas = "WP-111"
        tampildata(1).namakelas = "WEB PROGRAMMING"
        tampildata(1).sks = 4
        tampildata(1).instruktur1 = "MIRA"
        tampildata(1).instruktur2 = "GG"

        tampildata(2).kodekelas = "DB200"
        tampildata(2).namakelas = "DATABASE ADMINISTRATION"
        tampildata(2).sks = 4
        tampildata(2).instruktur1 = "RR"
        tampildata(2).instruktur2 = "FF"

        tampildata(3).kodekelas = "DB100"
        tampildata(3).namakelas = "DATABASE 1"
        tampildata(3).sks = 4
        tampildata(3).instruktur1 = "BUDI"
        tampildata(3).instruktur2 = "JJ"

        tampildata(4).kodekelas = "CO100"
        tampildata(4).namakelas = "CISCO NETWORK"
        tampildata(4).sks = 4
        tampildata(4).instruktur1 = "BUDI"
        tampildata(4).instruktur2 = "DAVID"

        tampildata(5).kodekelas = "LN100"
        tampildata(5).namakelas = "LINUX"
        tampildata(5).sks = 4
        tampildata(5).instruktur1 = "IRAWAN"
        tampildata(5).instruktur2 = "CAKRA"
        jumlah = 5 ' VARIABEL UNTUK MENDETEKSI DATA JUMLAH DIKENAL DI SELURUH FORM 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listing As String
        Dim sort_item As String
        Dim temp_rect As datakelas
        'descending
        sort_item = ComboBox1.Text
        MsgBox("item sort " & sort_item)
        'PENGURUUTAN

        If sort_item = "KODEKELAS" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).kodekelas > tampildata(j - 1).kodekelas Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i
        ElseIf sort_item = "NAMAKELAS" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).namakelas > tampildata(j - 1).namakelas Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i

        ElseIf sort_item = "INSTRUKTUR1" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).instruktur1 > tampildata(j - 1).instruktur1 Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i
        ElseIf sort_item = "INSTRUKTUR2" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).instruktur2 > tampildata(j - 1).instruktur2 Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'ascending
        Dim listing As String
        Dim sort_item As String
        Dim temp_rect As datakelas

        sort_item = ComboBox1.Text
        MsgBox("item sort " & sort_item)
        'PENGURUUTAN

        If sort_item = "KODEKELAS" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).kodekelas < tampildata(j - 1).kodekelas Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i
        ElseIf sort_item = "NAMAKELAS" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).namakelas < tampildata(j - 1).namakelas Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i

        ElseIf sort_item = "INSTRUKTUR1" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).instruktur1 < tampildata(j - 1).instruktur1 Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i

        ElseIf sort_item = "INSTRUKTUR2" Then
            For i = 0 To jumlah
                For j = jumlah To i + 1 Step -1
                    If tampildata(j).instruktur2 < tampildata(j - 1).instruktur2 Then
                        temp_rect = tampildata(j)
                        tampildata(j) = tampildata(j - 1)
                        tampildata(j - 1) = temp_rect
                    End If
                Next j
            Next i
            ListBox1.Items.Clear()
            listing = ""
            For i = 0 To jumlah
                listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
                ListBox1.Items.Add(listing)
                listing = ""
            Next i
        End If
        'DISPLAY HASIL SORTING DENGAN COPY PASTE DARI TOMBOL DISPLAY 
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim listing As String

        Dim temp_text As String
        ListBox1.Items.Clear()
        listing = ""
        For i = 0 To jumlah
            'temp_text = temp_text & tampildata(i).kodekelas & " > "
            'temp_text = temp_text & tampildata(i).namakelas & " > "
            'temp_text = temp_text & tampildata(i).sks & " > "
            'temp_text = temp_text & tampildata(i).instruktur1 & " > "
            'temp_text = temp_text & tampildata(i).instruktur2 & " > "
            'ListBox1.Items.Add(temp_text)
            'temp_text = ""
            listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2 & Chr(13)

            ListBox1.Items.Add(listing)
            ' RichTextBox1.Text = listing
            listing = ""
        Next i
        RichTextBox1.Text = listing
        ' listing = listing + tampildata(i).display
        'jumlah = i + 1
        'RichTextBox1.Text = listing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'clear
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim listing As String
        Dim i As Integer

        tampildata(jumlah + 1).kodekelas = TextBox2.Text
        tampildata(jumlah + 1).namakelas = TextBox3.Text
        tampildata(jumlah + 1).sks = TextBox1.Text 'cINT(TEXTBOX1.TEXT) UNTUK KONVERSI INTER KE STRING
        tampildata(jumlah + 1).instruktur1 = TextBox4.Text
        tampildata(jumlah + 1).instruktur2 = TextBox5.Text
        jumlah = jumlah + 1

        ListBox1.Items.Clear()
        listing = ""
        For i = 0 To jumlah
            listing = tampildata(i).kodekelas & ">" & tampildata(i).namakelas & ">" & tampildata(i).sks & ">" & tampildata(i).instruktur1 & ">" & tampildata(i).instruktur2
            ListBox1.Items.Add(listing)
            listing = ""
        Next i

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub
End Class