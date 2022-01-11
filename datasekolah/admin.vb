Public Class admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            tbl_siswa.Show()
        End If
        If CheckBox2.Checked Then
            tbl_mapel.Show()
        End If

        If CheckBox3.Checked Then
            tbl_ruangan.Show()
        End If
        If CheckBox4.Checked Then
            tbl_jurusan.Show()
        End If
    End Sub
End Class