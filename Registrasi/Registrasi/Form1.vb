Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegDataSet.TableReg' table. You can move, or remove it, as needed.
        Me.TableRegTableAdapter.Fill(Me.RegDataSet.TableReg)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TableRegBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TableRegBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        
        On Error GoTo SaveErr
        TableRegBindingSource.EndEdit()
        TableRegTableAdapter.Update(RegDataSet)

        MessageBox.Show("Data Disimpan")

SaveErr:
        Exit Sub

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        On Error GoTo SaveErr

        'TableRegBindingSource.EndEdit()
        TableRegBindingSource.ResetCurrentItem()


        TableRegTableAdapter.Update(RegDataSet)

        'MessageBox.Show("Perubahan Data Disimpan")

SaveErr:
        TableRegBindingSource.ResetCurrentItem()
        'Exit Sub

    End Sub

    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    '   If RadioButton1.Checked = True Then
    '      RadioButton1.Text = "Perempuan"
    '     End If
    'End Sub


    'Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    '   If RadioButton2.Checked = True Then
    '  RadioButton2.Text = "Laki-Laki"
    '  End If
    'End Sub
End Class
