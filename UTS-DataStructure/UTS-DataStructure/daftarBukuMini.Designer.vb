<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftarBukuMini
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJudulAsc = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbHargaAsc = New System.Windows.Forms.CheckBox()
        Me.cbJenisAsc = New System.Windows.Forms.CheckBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbHargaDesc = New System.Windows.Forms.CheckBox()
        Me.cbJenisDesc = New System.Windows.Forms.CheckBox()
        Me.cbJudulDesc = New System.Windows.Forms.CheckBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 69)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(334, 275)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("WP MultinationalA Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIBRARY BUKU MINI"
        '
        'cbJudulAsc
        '
        Me.cbJudulAsc.AutoSize = True
        Me.cbJudulAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbJudulAsc.Location = New System.Drawing.Point(9, 19)
        Me.cbJudulAsc.Name = "cbJudulAsc"
        Me.cbJudulAsc.Size = New System.Drawing.Size(51, 17)
        Me.cbJudulAsc.TabIndex = 2
        Me.cbJudulAsc.Text = "Judul"
        Me.cbJudulAsc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbHargaAsc)
        Me.GroupBox1.Controls.Add(Me.cbJenisAsc)
        Me.GroupBox1.Controls.Add(Me.cbJudulAsc)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(368, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(148, 89)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ascending"
        '
        'cbHargaAsc
        '
        Me.cbHargaAsc.AutoSize = True
        Me.cbHargaAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbHargaAsc.Location = New System.Drawing.Point(9, 65)
        Me.cbHargaAsc.Name = "cbHargaAsc"
        Me.cbHargaAsc.Size = New System.Drawing.Size(55, 17)
        Me.cbHargaAsc.TabIndex = 4
        Me.cbHargaAsc.Text = "Harga"
        Me.cbHargaAsc.UseVisualStyleBackColor = True
        '
        'cbJenisAsc
        '
        Me.cbJenisAsc.AutoSize = True
        Me.cbJenisAsc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbJenisAsc.Location = New System.Drawing.Point(9, 42)
        Me.cbJenisAsc.Name = "cbJenisAsc"
        Me.cbJenisAsc.Size = New System.Drawing.Size(50, 17)
        Me.cbJenisAsc.TabIndex = 3
        Me.cbJenisAsc.Text = "Jenis"
        Me.cbJenisAsc.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSort.Location = New System.Drawing.Point(449, 156)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbHargaDesc)
        Me.GroupBox2.Controls.Add(Me.cbJenisDesc)
        Me.GroupBox2.Controls.Add(Me.cbJudulDesc)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(522, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(148, 89)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descending"
        '
        'cbHargaDesc
        '
        Me.cbHargaDesc.AutoSize = True
        Me.cbHargaDesc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbHargaDesc.Location = New System.Drawing.Point(9, 65)
        Me.cbHargaDesc.Name = "cbHargaDesc"
        Me.cbHargaDesc.Size = New System.Drawing.Size(55, 17)
        Me.cbHargaDesc.TabIndex = 4
        Me.cbHargaDesc.Text = "Harga"
        Me.cbHargaDesc.UseVisualStyleBackColor = True
        '
        'cbJenisDesc
        '
        Me.cbJenisDesc.AutoSize = True
        Me.cbJenisDesc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbJenisDesc.Location = New System.Drawing.Point(9, 42)
        Me.cbJenisDesc.Name = "cbJenisDesc"
        Me.cbJenisDesc.Size = New System.Drawing.Size(50, 17)
        Me.cbJenisDesc.TabIndex = 3
        Me.cbJenisDesc.Text = "Jenis"
        Me.cbJenisDesc.UseVisualStyleBackColor = True
        '
        'cbJudulDesc
        '
        Me.cbJudulDesc.AutoSize = True
        Me.cbJudulDesc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbJudulDesc.Location = New System.Drawing.Point(9, 19)
        Me.cbJudulDesc.Name = "cbJudulDesc"
        Me.cbJudulDesc.Size = New System.Drawing.Size(51, 17)
        Me.cbJudulDesc.TabIndex = 2
        Me.cbJudulDesc.Text = "Judul"
        Me.cbJudulDesc.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Location = New System.Drawing.Point(368, 156)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 15
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(530, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(611, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(371, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(292, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "**Silakan tekan 'Display' untuk melihat data yang sudah ada."
        '
        'txtJudul
        '
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudul.Location = New System.Drawing.Point(12, 31)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(148, 20)
        Me.txtJudul.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Judul Buku"
        '
        'txtJenis
        '
        Me.txtJenis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJenis.Location = New System.Drawing.Point(12, 70)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(148, 20)
        Me.txtJenis.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jenis Buku"
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHarga.Location = New System.Drawing.Point(12, 109)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(148, 20)
        Me.txtHarga.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Harga (*Rp. per Piece)"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenerbit.Location = New System.Drawing.Point(174, 32)
        Me.txtPenerbit.Multiline = True
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(148, 20)
        Me.txtPenerbit.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Penerbit"
        '
        'txtJumlah
        '
        Me.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJumlah.Location = New System.Drawing.Point(174, 71)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(148, 20)
        Me.txtJumlah.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jumlah (*Piece/s)"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(174, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Data"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtJumlah)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtPenerbit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtHarga)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtJenis)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtJudul)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(352, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 150)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'daftarBukuMini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(697, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "daftarBukuMini"
        Me.Text = " Buku Mini"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbJudulAsc As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHargaAsc As System.Windows.Forms.CheckBox
    Friend WithEvents cbJenisAsc As System.Windows.Forms.CheckBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHargaDesc As System.Windows.Forms.CheckBox
    Friend WithEvents cbJenisDesc As System.Windows.Forms.CheckBox
    Friend WithEvents cbJudulDesc As System.Windows.Forms.CheckBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJenis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
