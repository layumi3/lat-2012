Public Class daftarBukuMini
    Structure buku
        Dim judul, jenis, penerbit, harga, jumlah As String
    End Structure
    Dim daftarBuku(100) As buku
    Dim totalData, i, j As Integer

    Private Sub daftarBukuMini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarBuku(0).judul = "Kancil dan Buaya" & "    "
        daftarBuku(0).jenis = "Fiksi" & "    "
        daftarBuku(0).harga = "15000" & "    "
        daftarBuku(0).penerbit = "Gramedia Pustaka" & "    "
        daftarBuku(0).jumlah = "30"

        daftarBuku(1).judul = "Taj Mahal" & "    "
        daftarBuku(1).jenis = "Novel" & "    "
        daftarBuku(1).harga = "150000" & "    "
        daftarBuku(1).penerbit = "Gramedia" & "    "
        daftarBuku(1).jumlah = "30"

        daftarBuku(2).judul = "Mengenal Angka" & "    "
        daftarBuku(2).jenis = "Education" & "    "
        daftarBuku(2).harga = "20000" & "    "
        daftarBuku(2).penerbit = "Intan Pariwara" & "    "
        daftarBuku(2).jumlah = "20"
        totalData = 2

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim diplay As String
        diplay = ""
        ListBox1.Items.Add("No || Judul Buku || Jenis Buku || Harga Buku || Penerbit || Jumlah")
        For i = 0 To totalData
            diplay = i + 1
            diplay = diplay + "  " + daftarBuku(i).judul
            diplay = diplay + daftarBuku(i).jenis
            diplay = diplay + daftarBuku(i).harga
            diplay = diplay + daftarBuku(i).penerbit
            diplay = diplay + daftarBuku(i).jumlah
            ListBox1.Items.Add(diplay)
            diplay = ""
        Next i
    End Sub

    Private Sub cbJudulAsc_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudulAsc.CheckedChanged
        If cbJudulAsc.CheckState = True Then
            cbHargaAsc.Checked = False

            cbJenisDesc.Checked = False
            cbJudulDesc.Checked = False
            cbHargaDesc.Checked = False
            cbJenisAsc.Checked = False
        End If
    End Sub

    Private Sub cbJenisAsc_CheckedChanged(sender As Object, e As EventArgs) Handles cbJenisAsc.CheckedChanged
        If cbJenisAsc.Checked = True Then
            cbHargaAsc.Checked = False
            cbJudulAsc.Checked = False
            cbJenisDesc.Checked = False
            cbJudulDesc.Checked = False
            cbHargaDesc.Checked = False

        End If

    End Sub

    Private Sub cbHargaAsc_CheckedChanged(sender As Object, e As EventArgs) Handles cbHargaAsc.CheckedChanged
        If cbHargaAsc.Checked = True Then

            cbJudulAsc.Checked = False
            cbJenisDesc.Checked = False
            cbJudulDesc.Checked = False
            cbHargaDesc.Checked = False
            cbJenisAsc.Checked = False
        End If
    End Sub

    Private Sub cbJudulDesc_CheckedChanged(sender As Object, e As EventArgs) Handles cbJudulDesc.CheckedChanged
        If cbJudulDesc.Checked = True Then
            cbHargaAsc.Checked = False
            cbJudulAsc.Checked = False
            cbJenisDesc.Checked = False

            cbHargaDesc.Checked = False
            cbJenisAsc.Checked = False
        End If
    End Sub

    Private Sub cbJenisDesc_CheckedChanged(sender As Object, e As EventArgs) Handles cbJenisDesc.CheckedChanged
        If cbJenisDesc.Checked = True Then
            cbHargaAsc.Checked = False
            cbJudulAsc.Checked = False

            cbJudulDesc.Checked = False
            cbHargaDesc.Checked = False
            cbJenisAsc.Checked = False
        End If
    End Sub

    Private Sub cbHargaDesc_CheckedChanged(sender As Object, e As EventArgs) Handles cbHargaDesc.CheckedChanged
        If cbHargaDesc.Checked = True Then
            cbHargaAsc.Checked = False
            cbJudulAsc.Checked = False
            cbJenisDesc.Checked = False
            cbJudulDesc.Checked = False

            cbJenisAsc.Checked = False
        End If
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim dataUrut As buku
        If cbJudulAsc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).judul < daftarBuku(j - 1).judul Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        ElseIf cbJenisAsc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).jenis < daftarBuku(j - 1).jenis Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        ElseIf cbHargaAsc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).harga < daftarBuku(j - 1).harga Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        ElseIf cbJudulDesc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).judul > daftarBuku(j - 1).judul Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        ElseIf cbJenisDesc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).jenis > daftarBuku(j - 1).jenis Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        ElseIf cbHargaDesc.Checked = True Then
            For i = 0 To totalData
                For j = totalData To i + 1 Step -1
                    If daftarBuku(j).harga > daftarBuku(j - 1).harga Then
                        dataUrut = daftarBuku(j)
                        daftarBuku(j) = daftarBuku(j - 1)
                        daftarBuku(j - 1) = dataUrut
                    End If
                Next j
            Next i
        End If

        Dim diplay As String
        diplay = ""
        ListBox1.Items.Clear()
        ListBox1.Items.Add("No || Judul Buku || Jenis Buku || Harga Buku || Penerbit || Jumlah")
        For i = 0 To totalData
            diplay = i + 1
            diplay = diplay + "  " + daftarBuku(i).judul
            diplay = diplay + daftarBuku(i).jenis
            diplay = diplay + daftarBuku(i).harga
            diplay = diplay + daftarBuku(i).penerbit
            diplay = diplay + daftarBuku(i).jumlah
            ListBox1.Items.Add(diplay)
            diplay = ""
        Next i
    End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    '    If GroupBox1.Enabled = True Then
    '        GroupBox2.Enabled = False
    '        MsgBox("sdfs")
    '    End If
    'End Sub

    'Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
    '    If GroupBox2.Enabled = True Then
    '        GroupBox1.Enabled = False
    '        MsgBox("sdfs")
    '    End If
    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        txtHarga.Text = ""
        txtJenis.Text = ""
        txtJudul.Text = ""
        txtJumlah.Text = ""
        txtPenerbit.Text = ""
        cbJenisAsc.Checked = False
        cbJudulAsc.Checked = False
        cbHargaAsc.Checked = False
        cbJenisDesc.Checked = False
        cbJudulDesc.Checked = False
        cbHargaDesc.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Anda Akan Keluar ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim diplay As String
        daftarBuku(totalData + 1).judul = txtJudul.Text & "    "
        daftarBuku(totalData + 1).jenis = txtJenis.Text & "    "
        daftarBuku(totalData + 1).harga = txtHarga.Text & "    "
        daftarBuku(totalData + 1).penerbit = txtPenerbit.Text & "    "
        daftarBuku(totalData + 1).jumlah = txtJumlah.Text
        totalData = totalData + 1
        diplay = ""
        ListBox1.Items.Clear()
        ListBox1.Items.Add("No || Judul Buku || Jenis Buku || Harga Buku || Penerbit || Jumlah")
        For i = 0 To totalData
            diplay = i + 1
            diplay = diplay + "  " + daftarBuku(i).judul
            diplay = diplay + daftarBuku(i).jenis
            diplay = diplay + daftarBuku(i).harga
            diplay = diplay + daftarBuku(i).penerbit
            diplay = diplay + daftarBuku(i).jumlah
            ListBox1.Items.Add(diplay)
            diplay = ""
            txtHarga.Text = ""
            txtJenis.Text = ""
            txtJudul.Text = ""
            txtJumlah.Text = ""
            txtPenerbit.Text = ""
        Next i
    End Sub

End Class