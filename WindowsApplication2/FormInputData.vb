Imports System.Data.Odbc
Public Class FormInputData

    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim mydb As String
    Dim cmd As OdbcCommand
    Dim serah As OdbcCommand
    Dim kirim As OdbcCommand

    Sub Koneksi()
        mydb = "Driver={Mysql ODBC 3.51 Driver};Database=db_aplikasi;server=localhost;uid=root"
        conn = New OdbcConnection(mydb)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Pakaian" Then
            harga.Text = "9000"
        ElseIf ComboBox1.Text = "Boneka" Then
            harga.Text = "8000"
        ElseIf ComboBox1.Text = "Selimut" Then
            harga.Text = "10000"
        ElseIf ComboBox1.Text = "Karpet" Then
            harga.Text = "12000"
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
        If uang.Text < hargatotal.Text Then
            MsgBox("Uang anda kurang !", MsgBoxStyle.Exclamation, "Input Uang Sesuai Harga Total atau Lebih")
        ElseIf uang.Text > hargatotal.Text Then
            kembalian = p - q
            kembali.Text = kembalian
        End If
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
        If nama.Text = "" Or berat.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("pastikan anda sudah menginputkan semua data")
        Else
            Call Koneksi()
            Dim penyerahan As String = "Insert into penyerahan values ('" & berat.Text & "','" & ComboBox1.Text & "','" & harga.Text & "','" & hargatotal.Text & "') "
            serah = New OdbcCommand(penyerahan, conn)
            serah.ExecuteNonQuery()

            Call Koneksi()
            Dim pengiriman As String = "Insert into pengiriman values ('" & nama.Text & "','" & berat.Text & "','" & ComboBox1.Text & "','" & harga.Text & "','" & hargatotal.Text & "','" & DateTimePicker1.Value & "') "
            kirim = New OdbcCommand(pengiriman, conn)
            kirim.ExecuteNonQuery()

            Call Koneksi()
            Dim simpan_data As String = "Insert into data_pelanggan values ('" & nama.Text & "','" & berat.Text & "','" & ComboBox1.Text & "','" & harga.Text & "','" & stand.Checked & "','" & hargatotal.Text & "','" & uang.Text & "','" & kembali.Text & "','" & DateTimePicker1.Value & "') "
            cmd = New OdbcCommand(simpan_data, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasi di input !!")
            FormPenyimpananData.Show()
            Me.Close()
        End If
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Dim respon As MsgBoxStyle
        respon = MsgBox("Yakin ingin keluar ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If respon = MsgBoxResult.Yes Then
            FormMenu.Show()
            Me.Hide()
        End If
        nama.Focus()
    End Sub

    Private Sub berat_TextChanged(sender As Object, e As EventArgs) Handles berat.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FormInputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class