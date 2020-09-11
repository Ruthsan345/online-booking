Imports MySql.Data.MySqlClient
Public Class Form5
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String
    Dim comman As MySqlCommand

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "COIMBATORE"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("ENTER THE DATA REQUIRED")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("ENTER THE DATA REQUIRED")
        ElseIf TextBox3.Text = "" Then
            MsgBox("ENTER THE DATA REQUIRED")
        ElseIf ComboBox2.SelectedItem = "" Then
            MsgBox("ENTER THE DATA REQUIRED")
        End If
        If ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "BUS" Then
            TextBox4.Text = 6000 + TextBox3.Text * 1279
        ElseIf ComboBox1.SelectedItem = "AGRA" And ComboBox2.SelectedItem = "BUS" Then
            TextBox4.Text = 5674 + TextBox3.Text * 1279
        ElseIf ComboBox1.SelectedItem = "VARANASI" And ComboBox2.SelectedItem = "BUS" Then
            TextBox4.Text = 5768 + TextBox3.Text * 1279
        ElseIf ComboBox1.SelectedItem = "JAIPUR" And ComboBox2.SelectedItem = "BUS" Then
            TextBox4.Text = 4567 + TextBox3.Text * 1279
        ElseIf ComboBox1.SelectedItem = "GOA" And ComboBox2.SelectedItem = "BUS" Then
            TextBox4.Text = 5500 + TextBox3.Text * 1279
        ElseIf ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "TRAIN" Then
            TextBox4.Text = 6000 + TextBox3.Text * 2000
        ElseIf ComboBox1.SelectedItem = "AGRA" And ComboBox2.SelectedItem = "TRAIN" Then
            TextBox4.Text = 5674 + TextBox3.Text * 2000
        ElseIf ComboBox1.SelectedItem = "VARANASI" And ComboBox2.SelectedItem = "TRAIN" Then
            TextBox4.Text = 5768 + TextBox3.Text * 2000
        ElseIf ComboBox1.SelectedItem = "JAIPUR" And ComboBox2.SelectedItem = "TRAIN" Then
            TextBox4.Text = 4567 + TextBox3.Text * 2000
        ElseIf ComboBox1.SelectedItem = "GOA" And ComboBox2.SelectedItem = "TRAIN" Then
            TextBox4.Text = 5500 + TextBox3.Text * 2000
        ElseIf ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "CRUISE" Then
            TextBox4.Text = 6000 + TextBox3.Text * 2500
        ElseIf ComboBox1.SelectedItem = "AGRA" And ComboBox2.SelectedItem = "CRUISE" Then
            TextBox4.Text = 5674 + TextBox3.Text * 2500
        ElseIf ComboBox1.SelectedItem = "VARANASI" And ComboBox2.SelectedItem = "CRUISE" Then
            TextBox4.Text = 5768 + TextBox3.Text * 2500
        ElseIf ComboBox1.SelectedItem = "JAIPUR" And ComboBox2.SelectedItem = "CRUISE" Then
            TextBox4.Text = 4567 + TextBox3.Text * 2500
        ElseIf ComboBox1.SelectedItem = "GOA" And ComboBox2.SelectedItem = "CRUISE" Then
            TextBox4.Text = 5500 + TextBox3.Text * 3000
        ElseIf ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "AIRWAYS" Then
            TextBox4.Text = 6000 + TextBox3.Text * 12000
        ElseIf ComboBox1.SelectedItem = "AGRA" And ComboBox2.SelectedItem = "AIRWAYS" Then
            TextBox4.Text = 5674 + TextBox3.Text * 10000
        ElseIf ComboBox1.SelectedItem = "VARANASI" And ComboBox2.SelectedItem = "AIRWAYS" Then
            TextBox4.Text = 5768 + TextBox3.Text * 6000
        ElseIf ComboBox1.SelectedItem = "JAIPUR" And ComboBox2.SelectedItem = "AIRWAYS" Then
            TextBox4.Text = 4567 + TextBox3.Text * 7000
        ElseIf ComboBox1.SelectedItem = "GOA" And ComboBox2.SelectedItem = "AIRWAYS" Then
            TextBox4.Text = 5500 + TextBox3.Text * 8000
        End If
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=travel1"

        Try
            conn.Open()
            MessageBox.Show("connected")
            insertstring = "INSERT INTO `data`(`username`, `start`, `destination`, `nooftickets`, `modeoftransport`, `amount`)  VALUES ('" & TextBox2.Text & "','" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "')"
            command = New MySqlCommand(insertstring, conn)
            reader = command.ExecuteReader
            MessageBox.Show("SUCCESSFUL!!")
            Me.Close()
            form7.show()
            conn.Close()
        Catch ex As MySqlException


        Finally
            conn.Dispose()

        End Try



    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "2 STAR HOTEL" Then
            TextBox4.Text = 6000 + TextBox3.Text * 1279

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "DELHI" And ComboBox2.SelectedItem = "2 STAR HOTEL" Then
            TextBox4.Text = 6000 + TextBox3.Text * 1279
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = Form3.TextBox1.Text
    End Sub
End Class