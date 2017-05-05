Public Class Form1
    Structure dataApotik
        Dim id, nama, harga, satuan As String

    End Structure
    Dim obat(0 To 100) As dataApotik
    Dim jumlah As Integer
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'listbox clear button
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'clear button
        TextBox1.Text = ""
        harga.Text = ""
        idObat.Text = ""
        namaObat.Text = ""
        Satuan.Text = ""

    End Sub

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
        ' insert button
        Dim sementara As String

        obat(jumlah + 1).id = idObat.Text
        obat(jumlah + 1).nama = namaObat.Text
        obat(jumlah + 1).satuan = Satuan.Text
        obat(jumlah + 1).harga = harga.Text

        jumlah = jumlah + 1
        sementara = ""
        ListBox1.Items.Clear()
        For i = 0 To jumlah
            sementara = sementara + CStr(i) + " : "
            sementara = sementara + " : " + obat(i).id + " : "
            sementara = sementara + obat(i).nama + " : "
            sementara = sementara + obat(i).satuan + " : "
            sementara = sementara + "Rp. " + obat(i).harga + " : "
            ListBox1.Items.Add(sementara)
            sementara = ""
        Next i
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'display button
        Dim sementara As String
        sementara = ""

        For i = 0 To jumlah
            sementara = sementara + CStr(i) + " : "
            sementara = sementara + " : " + obat(i).id + " : "
            sementara = sementara + obat(i).nama + " : "
            sementara = sementara + obat(i).satuan + " : "
            sementara = sementara + "Rp. " + obat(i).harga
            ListBox1.Items.Add(sementara)
            sementara = ""
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete button
        Dim i As Integer
        Dim delete As Integer
        Dim sementara As String

        delete = CStr(TextBox1.Text)
        ListBox1.Items.Clear()

        For i = delete To jumlah - 1
            obat(i) = obat(i + 1)
        Next i

        jumlah = jumlah - 1
        sementara = ""
          For i = 0 To jumlah
            sementara = sementara + CStr(i) + " : "
            sementara = sementara + " : " + obat(i).id + " : "
            sementara = sementara + obat(i).nama + " : "
            sementara = sementara + obat(i).satuan + " : "
            sementara = sementara + "Rp. " + obat(i).harga
            ListBox1.Items.Add(sementara)
            sementara = ""
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'update button
        Dim update As Integer
        Dim sementara As String

        update = CStr(TextBox1.Text)

        obat(update).id = idObat.Text
        obat(update).nama = namaObat.Text
        obat(update).satuan = Satuan.Text
        obat(update).harga = harga.Text

        sementara = ""
        ListBox1.Items.Clear()
        For i = 0 To jumlah
            sementara = sementara + CStr(i) + " : "
            sementara = sementara + " : " + obat(i).id + " : "
            sementara = sementara + obat(i).nama + " : "
            sementara = sementara + obat(i).satuan + " : "
            sementara = sementara + "Rp. " + obat(i).harga + " : "
            ListBox1.Items.Add(sementara)
            sementara = ""
        Next i
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim no_record As Integer

        no_record = ListBox1.SelectedIndex

        TextBox1.Text = CStr(no_record)
        idObat.Text = obat(no_record).id
        namaObat.Text = obat(no_record).nama
        Satuan.Text = obat(no_record).satuan
        harga.Text = obat(no_record).harga


    End Sub
End Class
