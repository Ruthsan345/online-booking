Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "password" Then
            MsgBox(".")
            Form8.Show()
        Else
            MsgBox("USERNAME OR PASSWORD IS INVALID.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then

            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub OFFERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFERSToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
      
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTUSToolStripMenuItem.Click

    End Sub

    Private Sub ADMINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BOOKINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGSToolStripMenuItem.Click
        MessageBox.Show("PLEASE LOGIN TO START BOOKING!!!")
        Me.Show()
    End Sub
End Class