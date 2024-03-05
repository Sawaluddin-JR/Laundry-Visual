Imports System.Data.Odbc
Public Class FormPenyerahan

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cetak As MsgBoxStyle
        cetak = MsgBox("Struk berhasil di cetak !! ", MsgBoxStyle.Information, "Laundry visual")
        FormMenu.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Call Koneksi()
        da = New OdbcDataAdapter("select * from penyerahan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "penyerahan")
        DataGridView1.DataSource = (ds.Tables("penyerahan"))
    End Sub
End Class