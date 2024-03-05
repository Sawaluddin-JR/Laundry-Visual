Public Class Form1
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Focus()
        password.UseSystemPasswordChar = True
    End Sub

    Private Sub login_Click_1(sender As Object, e As EventArgs) Handles login.Click
        If username.Text = "" And password.Text = "" Then
            MsgBox("Username dan Passsword tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf username.Text = "laundry visual" And password.Text = "laundry123" Then
            MsgBox("Login Berhasil !", MsgBoxStyle.Information, "Akses Berhasil")
            FormMenu.Show()
            Me.Hide()
        Else
            MsgBox("Kombinasi username dan password salah ! ", MsgBoxStyle.Critical, "Cek Username dan Password")
            Call manggil()
            username.Focus()
        End If
    End Sub

    Sub manggil()
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
        password.Focus()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Dim info As MsgBoxStyle
        info = MsgBox("Yakin ingin keluar ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If info = MsgBoxResult.Yes Then
            Application.Exit()
            Me.Hide()
        End If
        username.Focus()
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class