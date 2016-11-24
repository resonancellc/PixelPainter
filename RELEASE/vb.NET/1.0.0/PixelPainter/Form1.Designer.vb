<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolBar = New System.Windows.Forms.ToolStripDropDownButton
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SourceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportAnIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 499)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(744, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolBar
        '
        Me.ToolBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ClearDrawingToolStripMenuItem})
        Me.ToolBar.Image = CType(resources.GetObject("ToolBar.Image"), System.Drawing.Image)
        Me.ToolBar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(64, 20)
        Me.ToolBar.Text = "Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.SourceCodeToolStripMenuItem, Me.HowToUseToolStripMenuItem, Me.ReportAnIssueToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DocumentationToolStripMenuItem.Text = "&Documentation"
        '
        'SourceCodeToolStripMenuItem
        '
        Me.SourceCodeToolStripMenuItem.Name = "SourceCodeToolStripMenuItem"
        Me.SourceCodeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SourceCodeToolStripMenuItem.Text = "Source &Code"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HowToUseToolStripMenuItem.Text = "How to &Use"
        '
        'ReportAnIssueToolStripMenuItem
        '
        Me.ReportAnIssueToolStripMenuItem.Name = "ReportAnIssueToolStripMenuItem"
        Me.ReportAnIssueToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReportAnIssueToolStripMenuItem.Text = "&Report an issue"
        '
        'ClearDrawingToolStripMenuItem
        '
        Me.ClearDrawingToolStripMenuItem.Name = "ClearDrawingToolStripMenuItem"
        Me.ClearDrawingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearDrawingToolStripMenuItem.Text = "Clear drawing"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(744, 521)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PixelPainter"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolBar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportAnIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
