Public Class Maintenance
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        BookMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        AuthorMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton5_Click(sender As Object, e As EventArgs) Handles Guna2TileButton5.Click
        SupplierMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        CategoryMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        PublisherMaintenance.Show()
        Me.Hide()
    End Sub
End Class