Imports System.Data.Odbc
Public Class FormPengiriman
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim mydb As String

    Sub Koneksi()
        mydb = "Driver={Mysql ODBC 3.51 Driver};Database=db_aplikasi;server=localhost;uid=root"
        conn = New OdbcConnection(mydb)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Cileunyi" Then
            ongkir.Text = "9000"
        ElseIf ComboBox1.Text = "Cimenyan" Then
            ongkir.Text = "5000"
        ElseIf ComboBox1.Text = "Cilengkrang" Then
            ongkir.Text = "7000"
        ElseIf ComboBox1.Text = "Cicendo" Then
            ongkir.Text = "1000"
        ElseIf ComboBox1.Text = "Bojongsari" Then
            ongkir.Text = "25000"
        ElseIf ComboBox1.Text = "Margahayu" Then
            ongkir.Text = "6000"
        ElseIf ComboBox1.Text = "Margaasih" Then
            ongkir.Text = "10000"
        ElseIf ComboBox1.Text = "Majalaya" Then
            ongkir.Text = "12000"
        ElseIf ComboBox1.Text = "Katapang" Then
            ongkir.Text = "8000"
        End If
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        MsgBox("Data disimpan", MsgBoxStyle.Information)
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Dim cancel As MsgBoxStyle
        cancel = MsgBox("Yakin ingin keluar ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If cancel = MsgBoxResult.Yes Then
            FormMenu.Show()
            Me.Hide()
        End If
        namap.Focus()
    End Sub

    Private Sub FormPengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New OdbcDataAdapter("select * from pengiriman", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengiriman")
        DataGridView1.DataSource = (ds.Tables("pengiriman"))
    End Sub
End Class