Imports MySql.Data.MySqlClient
Public Class tbl_laporan_nilai
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


        If ComboBox3.Text = "RPL1A" Then
            rombel = "1"
        End If
        If ComboBox3.Text = "RPL2A" Then
            rombel = "2"
        End If
        If ComboBox3.Text = "RPL3A" Then
            rombel = "3"
        End If
        If ComboBox3.Text = "TKJ1A" Then
            rombel = "4"
        End If
        If ComboBox3.Text = "TKJ2A" Then
            rombel = "5"
        End If
        If ComboBox3.Text = "TKJ3A" Then
            rombel = "6"
        End If
        If ComboBox3.Text = "TKJ3b" Then
            rombel = "7"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "insert into akademik.tbl_laporan_nilai (id_laporan_nilai, id_nilai, kd_mapel, id_rombel, semester) VALUES ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & rombel & "','" & ComboBox4.Text & "')"
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
    Private Sub load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_laporan_nilai  "
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

    Private Sub tbl_laporan_nilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_nilai "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("id_nilai")
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
            query = "select * from akademik.tbl_laporan_nilai "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("id_laporan_nilai")
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
            query = "select * from akademik.tbl_rombel "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("nama_rombel")
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
            query = "select * from akademik.tbl_kurikulum_detail "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("id_kurikulum")
                ComboBox4.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        If ComboBox3.Text = "RPL1A" Then
            rombel = "1"
        End If
        If ComboBox3.Text = "RPL2A" Then
            rombel = "2"
        End If
        If ComboBox3.Text = "RPL3A" Then
            rombel = "3"
        End If
        If ComboBox3.Text = "TKJ1A" Then
            rombel = "4"
        End If
        If ComboBox3.Text = "TKJ2A" Then
            rombel = "5"
        End If
        If ComboBox3.Text = "TKJ3A" Then
            rombel = "6"
        End If
        If ComboBox3.Text = "TKJ3b" Then
            rombel = "7"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "update akademik.tbl_laporan_nilai set id_nilai='" & ComboBox1.Text & "',kd_mapel='" & ComboBox2.Text & "',id_rombel='" & rombel & "',semester='" & ComboBox4.Text & "' where id_laporan_nilai='" & TextBox1.Text & "'"
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


        If ComboBox3.Text = "RPL1A" Then
            rombel = "1"
        End If
        If ComboBox3.Text = "RPL2A" Then
            rombel = "2"
        End If
        If ComboBox3.Text = "RPL3A" Then
            rombel = "3"
        End If
        If ComboBox3.Text = "TKJ1A" Then
            rombel = "4"
        End If
        If ComboBox3.Text = "TKJ2A" Then
            rombel = "5"
        End If
        If ComboBox3.Text = "TKJ3A" Then
            rombel = "6"
        End If
        If ComboBox3.Text = "TKJ3b" Then
            rombel = "7"
        End If
        Try
            conn.Open()
            Dim query As String
            query = "delete from tbl_laporan_nilai where id_laporan_nilai='" & TextBox1.Text & "'"
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

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_laporan_nilai where id_laporan_nilai = '" & ComboBox5.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read

                TextBox1.Text = reader.GetUInt32("id_laporan_nilai")
                ComboBox1.Text = reader.GetUInt32("id_nilai")
                ComboBox2.Text = reader.GetString("kd_mapel")
                ComboBox3.Text = reader.GetString("id_rombel")
                ComboBox4.Text = reader.GetString("semester")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class