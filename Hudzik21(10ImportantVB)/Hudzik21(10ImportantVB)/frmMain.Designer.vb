<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamples = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamplesBasicmath = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExampleIf = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamplesLooping = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamplesRandom = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamplesSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamplesString = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExampleSelectcase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuExamples})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(224, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuExamples
        '
        Me.mnuExamples.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExamplesBasicmath, Me.mnuExampleIf, Me.mnuExamplesLooping, Me.mnuExamplesRandom, Me.mnuExamplesSub, Me.mnuExamplesString, Me.mnuExampleSelectcase})
        Me.mnuExamples.Name = "mnuExamples"
        Me.mnuExamples.Size = New System.Drawing.Size(68, 20)
        Me.mnuExamples.Text = "Examples"
        '
        'mnuExamplesBasicmath
        '
        Me.mnuExamplesBasicmath.Name = "mnuExamplesBasicmath"
        Me.mnuExamplesBasicmath.Size = New System.Drawing.Size(180, 22)
        Me.mnuExamplesBasicmath.Text = "Basic Math"
        '
        'mnuExampleIf
        '
        Me.mnuExampleIf.Name = "mnuExampleIf"
        Me.mnuExampleIf.Size = New System.Drawing.Size(180, 22)
        Me.mnuExampleIf.Text = "If Then Else"
        '
        'mnuExamplesLooping
        '
        Me.mnuExamplesLooping.Name = "mnuExamplesLooping"
        Me.mnuExamplesLooping.Size = New System.Drawing.Size(180, 22)
        Me.mnuExamplesLooping.Text = "Looping"
        '
        'mnuExamplesRandom
        '
        Me.mnuExamplesRandom.Name = "mnuExamplesRandom"
        Me.mnuExamplesRandom.Size = New System.Drawing.Size(180, 22)
        Me.mnuExamplesRandom.Text = "Random Number"
        '
        'mnuExamplesSub
        '
        Me.mnuExamplesSub.Name = "mnuExamplesSub"
        Me.mnuExamplesSub.Size = New System.Drawing.Size(180, 22)
        Me.mnuExamplesSub.Text = "Sub Procedure"
        '
        'mnuExamplesString
        '
        Me.mnuExamplesString.Name = "mnuExamplesString"
        Me.mnuExamplesString.Size = New System.Drawing.Size(180, 22)
        Me.mnuExamplesString.Text = "String Methods"
        '
        'mnuExampleSelectcase
        '
        Me.mnuExampleSelectcase.Name = "mnuExampleSelectcase"
        Me.mnuExampleSelectcase.Size = New System.Drawing.Size(180, 22)
        Me.mnuExampleSelectcase.Text = "Select Case"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 183)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "The Exampalé"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuExamples As ToolStripMenuItem
    Friend WithEvents mnuExamplesBasicmath As ToolStripMenuItem
    Friend WithEvents mnuExampleIf As ToolStripMenuItem
    Friend WithEvents mnuExamplesLooping As ToolStripMenuItem
    Friend WithEvents mnuExamplesRandom As ToolStripMenuItem
    Friend WithEvents mnuExamplesSub As ToolStripMenuItem
    Friend WithEvents mnuExamplesString As ToolStripMenuItem
    Friend WithEvents mnuExampleSelectcase As ToolStripMenuItem
End Class
