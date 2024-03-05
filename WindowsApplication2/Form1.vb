Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Pakaian" Then
            harga.Text = "9000"
        ElseIf ComboBox1.Text = "Boneka" Then
            harga.Text = "8000"
        ElseIf ComboBox1.Text = "Selimut" Then
            harga.Text = "100000"
        ElseIf ComboBox1.Text = "Karpet" Then
            harga.Text = "120000"
        ElseIf ComboBox1.Text = "Gorden" Then
            harga.Text = "70000"
        End If
    End Sub

    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        Dim a, b As Integer
        Dim c = "5000"
        Dim hasil As Integer
        a = berat.Text
        b = harga.Text
        c = "5000"
        hasil = a * b
        hargatotal.Text = hasil
        If kilat.Checked Then
            hargatotal.Text = hasil + c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim p, q, kembalian As Integer
        p = uang.Text
        q = hargatotal.Text
        kembalian = p - q
        kembali.Text = kembalian
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        nama.Text = ""
        berat.Text = ""
        harga.Text = ""
        kembali.Text = ""
        hargatotal.Text = ""
        uang.Text = ""
        DateTimePicker1.Text = ""
        kilat.Checked = False
        stand.Checked = False
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Form2.DataGridView1.Rows.Add(1)
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = nama.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = berat.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = ComboBox1.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = hargatotal.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = DateTimePicker1.Value
        MsgBox("Data disimpan", MsgBoxStyle.Information)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Application.Exit()
    End Sub
End Class
