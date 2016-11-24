Public Class Splash
    Dim G As Graphics
    Dim r As Rectangle
    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Me.Show()
        Me.Refresh()
        G = Me.CreateGraphics
        r = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        G.DrawRectangle(Pens.Black, r)
        Threading.Thread.Sleep(2000)
        Form1.Show()
        Me.Close()
    End Sub
End Class