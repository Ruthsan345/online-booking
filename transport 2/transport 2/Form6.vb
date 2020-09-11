Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class Form6
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String
    Dim comman As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim strMessage As String = ""
        Dim regex As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
                                       ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
                                       RegexOptions.IgnoreCase _
                                       Or RegexOptions.CultureInvariant _
                                       Or RegexOptions.IgnorePatternWhitespace _
                                       Or RegexOptions.Compiled _
                                       )
        Dim IsMatch As Boolean = regex.IsMatch(TextBox2.Text)
        If IsMatch Then
            If TextBox1.Text.Equals(regex.Match(TextBox2.Text).ToString) Then
                strMessage = "Valid email address"
                i = 0
            Else
                strMessage = "Valid email address"
                i = 0
            End If
        Else
            strMessage = "Sorry.  Invalid email address format."
            i = 1
        End If
        If TextBox3.Text = TextBox4.Text Then
            MessageBox.Show(strMessage)
            If i = 0 Then
                conn = New MySqlConnection
                conn.ConnectionString = "server=localhost;userid=root;password=;database=travel"

                Try
                    conn.Open()
                    MessageBox.Show("connected")
                    insertstring = "insert into login (`username`, `mailid`, `password`, `confirmpass`) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                    command = New MySqlCommand(insertstring, conn)
                    reader = command.ExecuteReader
                    Dim comman As New MySqlCommand("select *from data where username= username", conn)
                    MessageBox.Show("SIGN-IN SUCCESSFULL!!! " + TextBox1.Text)
                    conn.Close()
                    Me.Hide()
                Catch ex As MySqlException


                Finally
                    conn.Dispose()

                End Try
            Else
                Me.Show()

            End If
        Else
            MessageBox.Show("password doesnt match")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox3.UseSystemPasswordChar = True Then

            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
        If TextBox4.UseSystemPasswordChar = True Then

            TextBox4.UseSystemPasswordChar = False
        Else
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub
End Class