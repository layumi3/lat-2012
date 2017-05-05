Public Class View


    Structure dataApotik
        Dim id, nama, harga, satuan As String

    End Structure
    Dim obat(0 To 100) As dataApotik
    Dim jumlah As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display button
        obat(0).id = "M0001"
        obat(0).nama = "Decolgen 100 ml"
        obat(0).satuan = "Strip"
        obat(0).harga = "5000"

        obat(1).id = "M0002"
        obat(1).nama = "Stop Cold "
        obat(1).satuan = "Strip"
        obat(1).harga = "6500"

        obat(2).id = "M0003"
        obat(2).nama = "Beoneuron "
        obat(2).satuan = "Strip"
        obat(2).harga = "20000"

        obat(3).id = "M0004"
        obat(3).nama = "Sangobion "
        obat(3).satuan = "Strip"
        obat(3).harga = "15000"

        obat(4).id = "M0005"
        obat(4).nama = "Theragran M "
        obat(4).satuan = "Strip"
        obat(4).harga = "35000"
        jumlah = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To jumlah
            If ComboBox1.Text = obat(i).id Then
                namaObat.Text = obat(i).nama
                Satuan.Text = obat(i).satuan
                harga.Text = "Rp. " + obat(i).harga
            End If
        Next i

        'If ComboBox1.Text = "M0001" Then

        '    'idObat.Text = "M0001"
        '    namaObat.Text = "Decolgen 100 ml"
        '    Satuan.Text = "Strip"
        '    harga.Text = "Rp. " + " 5000"
        'ElseIf Co00"
        'ElseIf ComboBox1.Text = "M000mboBox1.Text = "M0002" Then
        '    '   idObat.Text = "M0002"
        '    namaObat.Text = "Stop Cold "
        '    Satuan.Text = "Strip"
        '    harga.Text = "Rp. " + " 653" Then
        '    '    idObat.Text = "M0003"
        '    namaObat.Text = "Beoneuron "
        '    Satuan.Text = "Strip"
        '    harga.Text = "Rp. " + " 20000"
        'ElseIf ComboBox1.Text = "M0004" Then
        '    ' idObat.Text = "M0004"
        '    namaObat.Text = "Sangobion "
        '    Satuan.Text = "Strip"
        '    harga.Text = "Rp. " + " 15000"
        'ElseIf ComboBox1.Text = "M0005" Then
        '    '   idObat.Text = "M0005"
        '    namaObat.Text = "Theragran M "
        '    Satuan.Text = "Strip"
        '    harga.Text = "Rp. " + " 35000"
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class