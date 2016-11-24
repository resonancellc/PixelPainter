Imports System.Drawing

Public Class Form1
    ' View port
    Dim ResWidth As Integer = 750
    Dim ResHeight As Integer = 550
    Dim TileSize As Integer = 32

    ' Graphics
    Dim G As Graphics
    Dim BGG As Graphics
    Dim BG As Bitmap
    Dim r As Rectangle

    ' TPS Counter
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 0
    Dim tps As Integer = 0

    ' Map vars
    Dim Map(100, 100, 10) As Integer
    Dim MapX As Integer = 20
    Dim MapY As Integer = 20

    ' Game running ?
    Dim IsRunning As Boolean = True

    ' Mouse co-ords
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim mMapX As Integer
    Dim mMapY As Integer

    ' Paintbrush
    Dim PaintBrush As Integer = 0

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()
        Splash.Close()

        If My.Settings.IsFirstUse Then
            HowToUse.Show()
            HowToUse.Focus()
            My.Settings.IsFirstUse = False
        End If

        ' Init graphics
        G = Me.CreateGraphics
        BG = New Bitmap(ResWidth, ResHeight)

        StartGameLoop()
    End Sub

    Private Sub StartGameLoop()
        Do While IsRunning = True
            Application.DoEvents()

            DrawGraphics()

            TickCounter()
        Loop
    End Sub

    Private Sub DrawGraphics()
        ' Draw tiles
        For X = 0 To 19
            For Y = 0 To 14
                r = New Rectangle(X * TileSize, Y * TileSize, TileSize, TileSize)

                Select Case Map(MapX + X, MapY + Y, 0)
                    Case 0 ' Background color for grid
                        G.FillRectangle(Brushes.White, r)
                    Case 1 ' Red
                        G.FillRectangle(Brushes.Red, r)
                    Case 2 ' Blue
                        G.FillRectangle(Brushes.Blue, r)
                    Case 3 ' White
                        G.FillRectangle(Brushes.White, r)
                    Case 4 ' Green
                        G.FillRectangle(Brushes.Green, r)
                    Case 5 ' Black
                        G.FillRectangle(Brushes.Black, r)
                End Select

                G.DrawRectangle(Pens.Black, r)
            Next
        Next

        ' Draw final layers
        G.FillRectangle(Brushes.Red, 21 * TileSize, 4 * TileSize, TileSize, TileSize)
        G.FillRectangle(Brushes.Blue, 21 * TileSize, 6 * TileSize, TileSize, TileSize)
        G.FillRectangle(Brushes.White, 21 * TileSize, 8 * TileSize, TileSize, TileSize)
        G.FillRectangle(Brushes.Green, 21 * TileSize, 10 * TileSize, TileSize, TileSize)
        G.FillRectangle(Brushes.Black, 21 * TileSize, 12 * TileSize, TileSize, TileSize)

        G.DrawRectangle(Pens.Red, mouseX * TileSize, mouseY * TileSize, TileSize, TileSize)

        G.DrawString("FPS=" & tTicks & "/" & tps & vbCrLf & _
                     "x=" & mouseX & vbCrLf & _
                     "y=" & mouseY & vbCrLf, Me.Font, Brushes.Black, 650, 10)

        ' Copy BG to graphics object
        G = Graphics.FromImage(BG)

        ' Draw BG to screen
        Try
            BGG = Me.CreateGraphics
        Catch
            Me.Close()
        End Try
        BGG.DrawImage(BG, 0, 0, ResWidth, ResHeight)

        ' Fix overdraw
        G.Clear(Color.Wheat)
    End Sub

    Private Sub TickCounter()
        If tSec = TimeOfDay.Second And IsRunning = True Then
            tTicks = tTicks + 1
        Else
            tps = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        mouseX = Math.Floor(e.X / TileSize)
        mouseY = Math.Floor(e.Y / TileSize)

        mMapX = MapX + mouseX
        mMapY = MapY + mouseY
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        If mouseX = 21 And mouseY = 4 Then
            PaintBrush = 1
        ElseIf mouseX = 21 And mouseY = 6 Then
            PaintBrush = 2
        ElseIf mouseX = 21 And mouseY = 8 Then
            PaintBrush = 3
        ElseIf mouseX = 21 And mouseY = 10 Then
            PaintBrush = 4
        ElseIf mouseX = 21 And mouseY = 12 Then
            PaintBrush = 5
        End If

        Select Case PaintBrush
            Case 0 ' Default
                Map(mMapX, mMapY, 0) = 0
            Case 1 ' Red
                Map(mMapX, mMapY, 0) = 1
            Case 2 ' Blue
                Map(mMapX, mMapY, 0) = 2
            Case 3 ' White
                Map(mMapX, mMapY, 0) = 3
            Case 4 ' Green
                Map(mMapX, mMapY, 0) = 4
            Case 5 ' Black
                Map(mMapX, mMapY, 0) = 5
        End Select
    End Sub

    Private Sub ClearDrawingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDrawingToolStripMenuItem.Click
        For X = 0 To 19
            For Y = 0 To 14
                Map(MapX + X, MapY + Y, 0) = 0
            Next
        Next
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentationToolStripMenuItem.Click
        Process.Start("https://github.com/Nanomotion/PixelPainter/blob/master/README.md")
    End Sub

    Private Sub SourceCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceCodeToolStripMenuItem.Click
        Process.Start("https://github.com/Nanomotion/PixelPainter")
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        HowToUse.Show()
        HowToUse.Focus()
    End Sub

    Private Sub ReportAnIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportAnIssueToolStripMenuItem.Click
        Process.Start("https://github.com/Nanomotion/PixelPainter/issues")
    End Sub
End Class

