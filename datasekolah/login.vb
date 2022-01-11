Imports MySql.Data.MySqlClient

Public Class login
    Dim koneksi As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi = New MySqlConnection
        koneksi.ConnectionString =
            "server=localhost;userid=root;password=akar;database=akademik;"
        Dim baca As MySqlDataReader
        Try
            koneksi.Open()
            Dim que As String
            que = "select * from tbl_user where username='" & username_login.Text & "' and password='" & password_login.Text & "'"
            command = New MySqlCommand(que, koneksi)
            baca = command.ExecuteReader
            Dim hitung As Integer
            hitung = 0
            While baca.Read
                hitung += 1
            End While
            If hitung = 1 Then
                If baca("id_level_user") = "1" Then
                    admin.show()
                    Me.Hide()
                ElseIf baca("id_level_user") = "2" Then
                    wali.show()
                    Me.Hide()
                ElseIf baca("id_level_user") = "3" Then
                    guru.show()
                    Me.Hide()
                ElseIf baca("id_level_user") = "4" Then
                    keuangan.show()
                    Me.Hide()
                End If
            ElseIf hitung = 2 Then
                MsgBox("duplicated", MsgBoxStyle.Information)
            ElseIf hitung = 0 Then
                MsgBox("salah", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        koneksi.Dispose()

    End Sub
End Class
