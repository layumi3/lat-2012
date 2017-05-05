Public Class uas

    Structure dataEmployee
        Dim id, name, address, city, postcode, province, phone As String
    End Structure
    Dim employee(0 To 100) As dataEmployee
    Dim jumlah As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employee(0).id = "1"
        employee(0).name = "Rita Fang"
        employee(0).address = "1970 Napa St."
        employee(0).city = "Bothell"
        employee(0).postcode = "98011"
        employee(0).province = "79"
        employee(0).phone = "888-656565"

        employee(1).id = "2"
        employee(1).name = "James Howard"
        employee(1).address = "9888 Mt. Dias Blv."
        employee(1).city = "Bothell"
        employee(1).postcode = "98011"
        employee(1).province = "79"
        employee(1).phone = "888-777777"

        employee(2).id = "3"
        employee(2).name = "Bill Gates"
        employee(2).address = "9539 Glenside Dr."
        employee(2).city = "Bothell"
        employee(2).postcode = "98011"
        employee(2).province = "79"
        employee(2).phone = "888-131313"

        employee(3).id = "4"
        employee(3).name = "Stephani Mayers"
        employee(3).address = "1226 Shoe St."
        employee(3).city = "Bothell"
        employee(3).postcode = "98011"
        employee(3).province = "79"
        employee(3).phone = "888-454545"

        employee(4).id = "5"
        employee(4).name = "Brian May"
        employee(4).address = "1226 Shoe St."
        employee(4).city = "Springwood"
        employee(4).postcode = "27777"
        employee(4).province = "50"
        employee(4).phone = "888-919191"
        jumlah = 4
    End Sub
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim no_record As Integer

        no_record = ListBox1.SelectedIndex

        txtRecord.Text = CStr(no_record)
        txtIdEmployee.Text = employee(no_record).id
        txtNamaEmployee.Text = employee(no_record).name
        txtAddress.Text = employee(no_record).address
        txtCity.Text = employee(no_record).city
        txtPostCode.Text = employee(no_record).postcode
        txtProvince.Text = employee(no_record).province
        txtPhone.Text = employee(no_record).phone


    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        MsgBox("Keluar ?", MsgBoxStyle.OkOnly, "Record Employee")
        If MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtIdEmployee.Text = ""
        txtNamaEmployee.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtPostCode.Text = ""
        txtProvince.Text = ""
        txtPhone.Text = ""

        txtRecord.Text = ""

    End Sub

    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click
        Dim kantong As String
        kantong = ""

        For i = 0 To jumlah
            kantong = kantong + CStr(i)
            kantong = kantong + " : " + employee(i).id + " : "
            kantong = kantong + employee(i).name + " : "
            kantong = kantong + employee(i).address + " : "
            kantong = kantong + employee(i).city + " : "
            kantong = kantong + employee(i).postcode + " : "
            kantong = kantong + employee(i).province + " : "
            kantong = kantong + employee(i).phone
            ListBox1.Items.Add(kantong)
            kantong = ""
        Next i
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim update As Integer
        Dim kantong As String

        update = CStr(txtRecord.Text)

        employee(update).id = txtIdEmployee.Text
        employee(update).name = txtNamaEmployee.Text
        employee(update).address = txtAddress.Text
        employee(update).city = txtCity.Text
        employee(update).postcode = txtPostCode.Text
        employee(update).province = txtProvince.Text
        employee(update).phone = txtPhone.Text

        kantong = ""
        ListBox1.Items.Clear()
        For i = 0 To jumlah
            kantong = kantong + CStr(i)
            kantong = kantong + " : " + employee(i).id + " : "
            kantong = kantong + employee(i).name + " : "
            kantong = kantong + employee(i).address + " : "
            kantong = kantong + employee(i).city + " : "
            kantong = kantong + employee(i).postcode + " : "
            kantong = kantong + employee(i).province + " : "
            kantong = kantong + employee(i).phone
            ListBox1.Items.Add(kantong)
            kantong = ""
        Next i
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer
        Dim delete As Integer
        Dim kantong As String

        delete = CStr(txtRecord.Text)
        ListBox1.Items.Clear()

        For i = delete To jumlah - 1
            employee(i) = employee(i + 1)
        Next i

        jumlah = jumlah - 1
        kantong = ""
        For i = 0 To jumlah
            kantong = kantong + CStr(i)
            kantong = kantong + " : " + employee(i).id + " : "
            kantong = kantong + employee(i).name + " : "
            kantong = kantong + employee(i).address + " : "
            kantong = kantong + employee(i).city + " : "
            kantong = kantong + employee(i).postcode + " : "
            kantong = kantong + employee(i).province + " : "
            kantong = kantong + employee(i).phone
            ListBox1.Items.Add(kantong)
            kantong = ""
        Next i
    End Sub

    Private Sub btnClearListBox_Click(sender As Object, e As EventArgs) Handles btnClearListBox.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim kantong As String

        employee(jumlah + 1).id = txtIdEmployee.Text
        employee(jumlah + 1).name = txtNamaEmployee.Text
        employee(jumlah + 1).address = txtAddress.Text
        employee(jumlah + 1).city = txtCity.Text
        employee(jumlah + 1).postcode = txtPostCode.Text
        employee(jumlah + 1).province = txtProvince.Text
        employee(jumlah + 1).phone = txtPhone.Text

        jumlah = jumlah + 1
        kantong = ""
        ListBox1.Items.Clear()
        For i = 0 To jumlah
            kantong = kantong + CStr(i)
            kantong = kantong + " : " + employee(i).id + " : "
            kantong = kantong + employee(i).name + " : "
            kantong = kantong + employee(i).address + " : "
            kantong = kantong + employee(i).city + " : "
            kantong = kantong + employee(i).postcode + " : "
            kantong = kantong + employee(i).province + " : "
            kantong = kantong + employee(i).phone
            ListBox1.Items.Add(kantong)
            kantong = ""
        Next i
    End Sub
End Class