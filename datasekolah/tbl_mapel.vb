Imports MySql.Data.MySqlClient
Public Class tbl_mapel
    Dim conn As MySqlConnection
    Dim dbDataSet As New DataTable
    Dim command As MySqlCommand
    Dim gender As String
    Dim agama As String
    Dim rombel As String
    Private Sub tbl_mapel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_table()
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_mapel "
            Command = New MySqlCommand(query, conn)
            reader = Command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("kd_mapel")
                ComboBox1.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
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
            query = "select * from akademik.tbl_mapel"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "insert into akademik.tbl_mapel (kd_mapel, nama_mapel) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "')"
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader


        Try
            conn.Open()
            Dim query As String
            query = "update akademik.tbl_mapel set nama_mapel = '" & TextBox2.Text & "'where kd_mapel='" & TextBox1.Text & "'"
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
            query = "delete from akademik.tbl_mapel where kd_mapel='" & TextBox1.Text & "'"
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_mapel where kd_mapel = '" & ComboBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read

                TextBox1.Text = reader.GetString("kd_mapel")
                TextBox2.Text = reader.GetString("nama_mapel")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class