Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ADMINLOGINToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub USERLOGINToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ABOUTUSToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem.Click

    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click

    End Sub

    Private Sub ABOUTUSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADMINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem1.Click
        MessageBox.Show("PLEASE LOGIN TO START BOOKING!!!")
        Form3.Show()
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub ADMINToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click


    End Sub
End Class
