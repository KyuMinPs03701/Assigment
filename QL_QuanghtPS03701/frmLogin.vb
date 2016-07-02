Public Class frmLogin
    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmSanpham.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub NhạcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhạcToolStripMenuItem.Click
        frmMedia.show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameToolStripMenuItem.Click
        frmgame.Show()
    End Sub
End Class
