Public Class frmMedia
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub
End Class