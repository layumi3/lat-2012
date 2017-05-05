'Option Explicit On
Public Class Form1
    'Public Structure studentrecord
    ' Dim name As String
    '  Dim address As String
    '   Dim phone As String
    'End Structure

    '    Dim student(0 to 5) As studentrecord
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   Dim jumlah, i, j As Integer
        ' Dim tempstring As String

        '   jumlah = 2
        '  If RadioButton1.Checked = True Then
        ' student(0).name = "Benny"
        '  student(0).address = "Buah Batu"
        ' student(0).phone = "12345"
        '  student(1).name = "Victor"
        ' student(1).address = "Suka Luyu"
        ' student(1).phone = "12345"
        ' student(2).name = "Ridwan"
        '  student(2).address = "Sadang Serang"
        ' student(2).phone = "12345"
        ' MsgBox("Record Sudah Terisi", vbOKCancel)
        '  ElseIf RadioButton7.Checked = True Then
        '      FormIsi.Show()
        '  ElseIf RadioButton2.Checked = True Then
        '     tempstring = ""
        '     For i = 0 To jumlah
        '        tempstring = tempstring + student(i).name & "   " & student(i).address & "  " & student(i).phone & Chr(13)
        '   Next
        '   RichTextBox1.Text = tempstring
        '  ElseIf RadioButton3.Checked = True Then
        '    RichTextBox1.Text = ""
        '  End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   Dim jumlah, i, j As Integer
        '   Dim tempstring As String
        '   Dim temprec As studentrecord
        '   jumlah = 2
        '  If RadioButton6.Checked = True Then
        '     For i = 0 To jumlah
        'For j = jumlah To i + 1 Step -1
        'If student(j).name < student(j - 1).name Then
        '       temprec = student(j)
        'student(j) = student(j - 1)
        '   student(j - 1) = temprec
        '       End If
        '   Next j
        '   Next i
        '  For i = 0 To jumlah
        '       tempstring = tempstring + (student(i).name) & "    " & (student(i).address) & (student(i).phone) & Chr(13)
        '   Next
        '   RichTextBox1.Text = tempstring
        '   ElseIf RadioButton5.Checked = True Then
        '   For i = 0 To jumlah
        '          For j = jumlah To i + 1 Step -1
        '       If student(j).address < student(j - 1).address Then
        '     temprec = student(j)
        'student(j) = student(j - 1)
        '     student(j - 1) = temprec
        '      End If
        '    Next j
        '   Next i
        '  For i = 0 To jumlah
        '       tempstring = tempstring + (student(i).name) & "    " & (student(i).address) & (student(i).phone) & Chr(13)
        '  Next
        '   RichTextBox1.Text = tempstring
        '
        'E'lseIf RadioButton4.Checked = True Then
        'For i = 0 To jumlah
        '        For j = jumlah To i + 1 Step -1
        'If student(j).phone < student(j - 1).phone Then
        'temprec = student(j)
        'student(j) = student(j - 1)
        'student(j - 1) = temprec
        'End If
        'Next j
        'Next i
        'For i = 0 To jumlah
        '        tempstring = tempstring + (student(i).name) & "    " & (student(i).address) & (student(i).phone) & Chr(13)
        'Next
        'RichTextBox1.Text = tempstring
        'End If

    End Sub

End Class
