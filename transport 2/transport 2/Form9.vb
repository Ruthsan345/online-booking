Imports System.Data.DataTable
Public Class Form9
    Dim table As New DataTable("table")
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        table.Columns.Add("PLACE", Type.GetType("system.string"))
        table.Columns.Add("DURATION", Type.GetType("system.string"))
        table.Columns.Add("OFFERS", Type.GetType("system.string"))
        table.Columns.Add("PRICE", Type.GetType("system.Int32"))

        DataGridView1.Rows.Add("MANALI", "5 DAYS", "15%", 20000)
        table.Rows.Add("CALTAF", "6 DAYS", "10%", 25000)
        table.Rows.Add("ANDAMAN AND NICOBAR ", "10 DAYS", "5%", 50000)
        table.Rows.Add("LADAKH", "9 DAYS", "20%", 30000)

        DataGridView1.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Add("MANALI", "5 DAYS", "15%", 20000)
        Me.DataGridView1.Rows.Add("CALTAF", "6 DAYS", "10%", 25000)
        Me.DataGridView1.Rows.Add("ANDAMAN AND NICOBAR ", "10 DAYS", "5%", 50000)
        Me.DataGridView1.Rows.Add("LADAKH", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("AGRA", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("JAMMU AND KASHMIR", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("RAJASTHAN", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("GUJARAT", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("BIHAR", "9 DAYS", "20%", 30000)
        Me.DataGridView1.Rows.Add("SRI LANKA", "9 DAYS", "20%", 30000)
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub OFFERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFERSToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
       

    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub ADMINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub BOOKINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOOKINGSToolStripMenuItem.Click
        MessageBox.Show("PLEASE LOGIN TO START BOOKING!!!")
        Me.Show()
    End Sub
End Class