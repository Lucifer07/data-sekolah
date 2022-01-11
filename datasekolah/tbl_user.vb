Imports MySql.Data.MySqlClient
Public Class tbl_user
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
            query = "select * from akademik.tbl_user "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("id_user")
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
            query = "select * from akademik.tbl_guru "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("nama_guru")
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
            query = "select * from akademik.tbl_guru "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("username")
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
            query = "select * from akademik.tbl_guru "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("password")
                ComboBox5.Items.Add(sName)


            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
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
            query = "select * from akademik.tbl_user"
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
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        conn = New MySqlConnection

        conn.ConnectionString =
            "server=localhost;user ID=root;password=akar;database=akademik"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from akademik.tbl_user where id_user = '" & ComboBox2.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read

                TextBox1.Text = reader.GetUInt32("id_user")
                ComboBox3.Text = reader.GetString("nama_guru")
                ComboBox4.Text = reader.GetString("username")
                ComboBox5.Text = reader.GetString("password")
                ComboBox1.Text = reader.GetUInt32("id_level_user")
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



        Try
            conn.Open()
            Dim query As String
            query = "insert into akademik.tbl_user (id_user,nama_guru, username,password,id_level_user) VALUES ('" & TextBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox1.Text & "') "
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
            query = "update akademik.tbl_user set nama_guru='" & ComboBox3.Text & "',username='" & ComboBox4.Text & "',password='" & ComboBox5.Text & "',id_level_user='" & ComboBox1.Text & "'where id_user='" & TextBox1.Text & "'"
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
            query = "delete from akademik.tbl_user where id_user='" & TextBox1.Text & "'"
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
End Class