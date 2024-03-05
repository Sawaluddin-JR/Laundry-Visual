Imports System.Data.Odbc

Public Class FormPenyimpananData

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
        FormInputData.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As MsgBoxStyle
        response = MsgBox("Yakin ingin keluar ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            FormInputData.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub FormStructure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New OdbcDataAdapter("select * from data_pelanggan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_pelanggan")
        DataGridView1.DataSource = (ds.Tables("data_pelanggan"))
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class