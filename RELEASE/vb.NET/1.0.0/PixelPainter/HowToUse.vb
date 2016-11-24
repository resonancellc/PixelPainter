Public Class HowToUse

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("https://github.com/Nanomotion")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("https://github.com/Nanomotion")
    End Sub

    Private Sub HowToUse_HelpButtonClicked(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Process.Start("https://github.com/Nanomotion/PixelPainter/blob/master/README.md")
    End Sub
End Class