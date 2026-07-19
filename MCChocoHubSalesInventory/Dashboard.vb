Public Class Dashboard
    Private Sub SupplierMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierMaintenanceToolStripMenuItem.Click
        SupplierMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub BookMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookMaintenanceToolStripMenuItem.Click
        BookMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub CategoryMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryMaintenanceToolStripMenuItem.Click
        CategoryMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub AuthorMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorMaintenanceToolStripMenuItem.Click
        AuthorMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub PublisherMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublisherMaintenanceToolStripMenuItem.Click
        PublisherMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub LibrarianMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrarianMaintenanceToolStripMenuItem.Click
        LibrarianMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub TeacherMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherMaintenanceToolStripMenuItem.Click

    End Sub

    Private Sub StudentMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentMaintenanceToolStripMenuItem.Click
        StudentMaintenance.Show()
        Me.Hide()
    End Sub
End Class