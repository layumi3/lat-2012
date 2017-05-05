Option Explicit On
Module Module1

    Public Structure studentrecord
        Dim name As String
        Dim address As String
        Dim phone As String
    End Structure

    Dim student(0 To 5) As studentrecord
    Dim jumlah, i, j As Integer
End Module
