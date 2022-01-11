Imports MySql.Data.MySqlClient
Public Class tbl_jadwal
    Dim conn As MySqlConnection
    Dim dbDataSet As New DataTable
    Dim command As MySqlCommand
    Dim gender As String
    Dim agama As String
    Dim rombel As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        If ComboBox2.Text = "7RPL1" Then
            rombel = "1"
            TextBox4.Text = "RPL1A"
        End If
        If ComboBox2.Text = "7RPL2" Then
            rombel = "2"
            TextBox4.Text = "RPL2A"
        End If
        If ComboBox2.Text = "7RPL3" Then
            rombel = "3"
            TextBox4.Text = "RPL3A"
        End If
        If ComboBox2.Text = "7TKJ1" Then
            rombel = "4"
            TextBox4.Text = "TKJ1A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "5"
            TextBox4.Text = "TKJ2A"
        End If
        If ComboBox2.Text = "7TKJ4" Then
            rombel = "6"
            TextBox4.Text = "TKJ3A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "7"
            TextBox4.Text = "TKJ3b"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "insert into akademik.tbl_jadwal (id_jadwal, id_tahun_akademik, kd_jurusan, kelas, kd_mapel, id_guru, jam_mulai, jam_selesai, kd_ruangan, semester, hari, id_rombel) VALUES ('" & TextBox1.Text & "','" & ComboBox6.Text & "','" & ComboBox5.Text & "','" & ComboBox2.Text & "','" & ComboBox4.Text & "','" & ComboBox3.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & rombel & "')"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data saved")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try







    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_rombel "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("kelas")
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
            query = "select * from akademik.tbl_ruangan "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("kd_ruangan")
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
            query = "select * from akademik.tbl_guru "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetUInt32("id_guru")
                ComboBox3.Items.Add(sName)


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
            query = "select * from akademik.tbl_mapel "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("kd_mapel")
                ComboBox4.Items.Add(sName)


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
            query = "select * from akademik.tbl_jurusan "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("kd_jurusan")
                ComboBox5.Items.Add(sName)


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
            query = "select * from akademik.tbl_tahun_akademik "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetUInt32("id_tahun_akademik")
                ComboBox6.Items.Add(sName)


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
            query = "select * from akademik.tbl_jadwal "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetUInt32("id_jadwal")
                ComboBox7.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged, ComboBox5.SelectedIndexChanged, ComboBox6.SelectedIndexChanged
        If ComboBox2.Text = "7RPL1" Then
            rombel = "1"
            TextBox4.Text = "RPL1A"
        End If
        If ComboBox2.Text = "7RPL2" Then
            rombel = "2"
            TextBox4.Text = "RPL2A"
        End If
        If ComboBox2.Text = "7RPL3" Then
            rombel = "3"
            TextBox4.Text = "RPL3A"
        End If
        If ComboBox2.Text = "7TKJ1" Then
            rombel = "4"
            TextBox4.Text = "TKJ1A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "5"
            TextBox4.Text = "TKJ2A"
        End If
        If ComboBox2.Text = "7TKJ4" Then
            rombel = "6"
            TextBox4.Text = "TKJ3A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "7"
            TextBox4.Text = "TKJ3b"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        If ComboBox2.Text = "7RPL1" Then
            rombel = "1"
            TextBox4.Text = "RPL1A"
        End If
        If ComboBox2.Text = "7RPL2" Then
            rombel = "2"
            TextBox4.Text = "RPL2A"
        End If
        If ComboBox2.Text = "7RPL3" Then
            rombel = "3"
            TextBox4.Text = "RPL3A"
        End If
        If ComboBox2.Text = "7TKJ1" Then
            rombel = "4"
            TextBox4.Text = "TKJ1A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "5"
            TextBox4.Text = "TKJ2A"
        End If
        If ComboBox2.Text = "7TKJ4" Then
            rombel = "6"
            TextBox4.Text = "TKJ3A"
        End If
        If ComboBox2.Text = "7TKJ2" Then
            rombel = "7"
            TextBox4.Text = "TKJ3b"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "update akademik.tbl_jadwal set id_tahun_akademik='" & ComboBox6.Text & "',kd_jurusan='" & ComboBox5.Text & "',kelas='" & ComboBox2.Text & "',kd_mapel='" & ComboBox4.Text & "',id_guru='" & ComboBox3.Text & "',jam_mulai='" & TextBox7.Text & "',jam_selesai='" & TextBox8.Text & "',kd_ruangan='" & ComboBox1.Text & "',semester='" & TextBox10.Text & "',hari='" & TextBox11.Text & "',id_rombel='" & rombel & "' where id_jadwal= '" & TextBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data updated")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "delete from akademik.tbl_jadwal where id_jadwal ='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            MessageBox.Show("data deleted")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_jadwal where id_jadwal = '" & ComboBox7.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read

                TextBox1.Text = reader.GetUInt32("id_jadwal")
                ComboBox6.Text = reader.GetUInt32("id_tahun_akademik")
                ComboBox5.Text = reader.GetString("kd_jurusan")
                ComboBox2.Text = reader.GetString("kelas")
                ComboBox4.Text = reader.GetString("kd_mapel")
                ComboBox3.Text = reader.GetString("id_guru")
                TextBox7.Text = reader.GetString("jam_mulai")
                ComboBox3.Text = reader.GetUInt32("id_guru")
                TextBox8.Text = reader.GetString("jam_selesai")
                ComboBox1.Text = reader.GetString("kd_ruangan")
                TextBox10.Text = reader.GetUInt32("semester")
                TextBox11.Text = reader.GetString("hari")
                TextBox4.Text = reader.GetUInt32("id_rombel")
            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

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
            query = "select * from akademik.tbl_jadwal  "
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class