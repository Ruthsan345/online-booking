Imports MySql.Data.MySqlClient
Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=travel1"
        Dim command As New MySqlCommand("select *from data where username= username", conn)
        command.Parameters.Add("username", MySqlDbType.String).Value = TextBox5.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        conn.Open()
        command.ExecuteNonQuery()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then

            ' return only 1 row
            ComboBox1.Text = table.Rows(0)(1).ToString()
            TextBox2.Text = table.Rows(0)(2).ToString()
            TextBox3.Text = table.Rows(0)(3).ToString()
            TextBox4.Text = table.Rows(0)(4).ToString()
            TextBox6.Text = table.Rows(0)(5).ToString()
        Else

            MessageBox.Show("no data found")
            conn.Close()
        End If
    End Sub
End Class