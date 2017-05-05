Option Explicit On
Public Class Form1

    Dim A(0 To 5) As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        A1.Text = ""
        A2.Text = ""
        A3.Text = ""
        A4.Text = ""
        A5.Text = ""
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        in1.Text = ""
        in2.Text = ""
        in3.Text = ""
        in4.Text = ""
        in5.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, temp As Integer
        If RadioButton1.Checked = True Then ' isi dari program
            A(1) = 25
            A(2) = 15
            A(3) = 37
            A(4) = 12
            A(5) = 5
            A1.Text = Str(A(1))
            A2.Text = Str(A(2))
            A3.Text = Str(A(3))
            A4.Text = Str(A(4))
            A5.Text = Str(A(5))
        ElseIf RadioUser.Checked = True Then ' isi dari interface
            A(1) = CInt(in1.Text)
            A(2) = CInt(in2.Text)
            A(3) = CInt(in3.Text)
            A(4) = CInt(in4.Text)
            A(5) = CInt(in5.Text)
            A1.Text = Str(A(1))
            A2.Text = Str(A(2))
            A3.Text = Str(A(3))
            A4.Text = Str(A(4))
            A5.Text = Str(A(5))
        ElseIf RadioAsc.Checked = True Then
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
            B1.Text = Str(A(1))
            B2.Text = Str(A(2))
            B3.Text = Str(A(3))
            B4.Text = Str(A(4))
            B5.Text = Str(A(5))
        ElseIf RadioDesc.Checked = True Then
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
            B1.Text = Str(A(1))
            B2.Text = Str(A(2))
            B3.Text = Str(A(3))
            B4.Text = Str(A(4))
            B5.Text = Str(A(5))

        End If

    End Sub
End Class
