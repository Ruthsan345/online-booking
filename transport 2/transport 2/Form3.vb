Imports MySql.Data.MySqlClient
Public Class Form3
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then

            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        Dim reader As MySqlDataReader
        conn.ConnectionString = "server=localhost;userid=root;password=;database=travel"
        Try
            conn.Open()
            MessageBox.Show("connected")
            Dim query As String
            query = "select * from travel.login where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("username and password are correct")
                Me.Hide()
                Form5.Show()
            ElseIf count > 1 Then
                MessageBox.Show("username and password are incorrect")
            Else
                MessageBox.Show("username and password are incorrect")
            End If
            conn.Close()
        Catch ex As MySqlException


        Finally

        End Try

       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form6.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub OFFERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFERSToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()

    End Sub

    Private Sub BOOKINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGSToolStripMenuItem.Click
        MessageBox.Show("PLEASE LOGIN TO START BOOKING!!!")
        Me.Show()

    End Sub

    Private Sub ADMINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click

    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Me.Show()

    End Sub
End Class