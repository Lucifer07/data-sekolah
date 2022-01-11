Imports MySql.Data.MySqlClient
Public Class tbl_siswa
    Dim conn As MySqlConnection
    Dim dbDataSet As New DataTable
    Dim command As MySqlCommand
    Dim gender As String
    Dim agama As String
    Dim rombel As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_agama "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("nama_agama")
                ComboBox1.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_rombel "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("nama_rombel")
                ComboBox2.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_siswa "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetUInt32("nim")
                ComboBox3.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader

        If ComboBox1.Text = "ISLAM" Then
            agama = "01"
        End If
        If ComboBox1.Text = "KRISTEN/PROTESTAN" Then
            agama = "02"
        End If
        If ComboBox1.Text = "KATHOLIK" Then
            agama = "03"
        End If
        If ComboBox1.Text = "HINDU" Then
            agama = "04"
        End If
        If ComboBox1.Text = "BUDHA" Then
            agama = "05"
        End If
        If ComboBox1.Text = "KHONG HU CHU" Then
            agama = "06"
        End If
        If ComboBox1.Text = "LAIN  LAIN" Then
            agama = "99"
        End If
        If ComboBox2.Text = "RPL1A" Then
            rombel = "1"
        End If
        If ComboBox2.Text = "RPL2A" Then
            rombel = "2"
        End If
        If ComboBox2.Text = "RPL3A" Then
            rombel = "3"
        End If
        If ComboBox2.Text = "TKJ1A" Then
            rombel = "4"
        End If
        If ComboBox2.Text = "TKJ2A" Then
            rombel = "5"
        End If
        If ComboBox2.Text = "TKJ3A" Then
            rombel = "6"
        End If
        If ComboBox2.Text = "TKJ3b" Then
            rombel = "7"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "insert into akademik.tbl_siswa (nim, nama, gender, tanggal_lahir, tempat_lahir, kd_agama, foto, id_rombel) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & gender & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & agama & "','" & TextBox7.Text & "','" & rombel & "')"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data saved")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

        load_table()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        gender = "W"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        gender = "P"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader

        If ComboBox1.Text = "ISLAM" Then
            agama = "01"
        End If
        If ComboBox1.Text = "KRISTEN/PROSakademikAN" Then
            agama = "02"
        End If
        If ComboBox1.Text = "KATHOLIK" Then
            agama = "03"
        End If
        If ComboBox1.Text = "HINDU" Then
            agama = "04"
        End If
        If ComboBox1.Text = "BUDHA" Then
            agama = "05"
        End If
        If ComboBox1.Text = "KHONG HU CHU" Then
            agama = "06"
        End If
        If ComboBox1.Text = "LAIN  LAIN" Then
            agama = "99"
        End If
        If ComboBox2.Text = "RPL1A" Then
            rombel = "1"
        End If
        If ComboBox2.Text = "RPL2A" Then
            rombel = "2"
        End If
        If ComboBox2.Text = "RPL3A" Then
            rombel = "3"
        End If
        If ComboBox2.Text = "TKJ1A" Then
            rombel = "4"
        End If
        If ComboBox2.Text = "TKJ2A" Then
            rombel = "5"
        End If
        If ComboBox2.Text = "TKJ3A" Then
            rombel = "6"
        End If
        If ComboBox2.Text = "TKJ3B" Then
            rombel = "7"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "update akademik.tbl_siswa set nama= '" & TextBox2.Text & "',gender='" & gender & "',tanggal_lahir='" & DateTimePicker1.Text & "',tempat_lahir='" & TextBox5.Text & "',kd_agama='" & agama & "',foto='" & TextBox7.Text & "',id_rombel='" & rombel & "' where nim='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data updated")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
        load_table()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "delete from akademik.tbl_siswa where nim ='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data deleted")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
        load_table()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_siswa where nim = '" & ComboBox3.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read

                TextBox1.Text = reader.GetUInt32("nim")
                TextBox2.Text = reader.GetString("nama")
                If reader.GetString("gender") = "W" Then
                    RadioButton1.Checked = True
                    RadioButton2.Checked = False
                End If
                If reader.GetString("gender") = "P" Then
                    RadioButton2.Checked = True
                    RadioButton1.Checked = False
                End If
                ComboBox2.Text = reader.GetString("id_rombel")
                TextBox5.Text = reader.GetString("tempat_lahir")
                TextBox7.Text = reader.GetString("foto")
                ComboBox1.Text = reader.GetString("kd_agama")
                DateTimePicker1.Text = reader.GetDateTime("tanggal_lahir")
                If ComboBox2.Text = "1" Then
                    ComboBox2.Text = "RPL1A"
                End If
                If ComboBox2.Text = "2" Then
                    ComboBox2.Text = "RPL2A"
                End If
                If ComboBox2.Text = "3" Then
                    ComboBox2.Text = "RPL3A"
                End If
                If ComboBox2.Text = "4" Then
                    ComboBox2.Text = "TKJ1A"
                End If
                If ComboBox2.Text = "5" Then
                    ComboBox2.Text = "TKJ2A"
                End If
                If ComboBox2.Text = "6" Then
                    ComboBox2.Text = "TKJ3A"
                End If
                If ComboBox2.Text = "7" Then
                    ComboBox2.Text = "TKJ3b"
                End If
                If ComboBox1.Text = "01" Then
                    ComboBox1.Text = "ISLAM"
                End If
                If ComboBox1.Text = "02" Then
                    ComboBox1.Text = "KRISTEN/ PROakademikAN"
                End If
                If ComboBox1.Text = "03" Then
                    ComboBox1.Text = "KATHOLIK"
                End If
                If ComboBox1.Text = "04" Then
                    ComboBox1.Text = "HINDU"
                End If
                If ComboBox1.Text = "05" Then
                    ComboBox1.Text = "BUDHA"
                End If
                If ComboBox1.Text = "06" Then
                    ComboBox1.Text = "KHONG HU CHU"
                End If
                If ComboBox1.Text = "99" Then
                    ComboBox1.Text = "LAIN LAIN"
                End If
            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select nim,nama,gender,tanggal_lahir,tempat_lahir,a.nama_agama 'agama',foto,b.nama_rombel 'rombongan belajar' from tbl_siswa inner join tbl_agama a using(kd_agama) inner join tbl_rombel b using(id_rombel) group by nim "
            command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)

            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
