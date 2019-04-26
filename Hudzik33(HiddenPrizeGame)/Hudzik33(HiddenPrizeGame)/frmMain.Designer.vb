<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHidePrizes = New System.Windows.Forms.Button()
        Me.lblBoxesLeft = New System.Windows.Forms.Label()
        Me.radNormalMode = New System.Windows.Forms.RadioButton()
        Me.radEasyMode = New System.Windows.Forms.RadioButton()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStartEasy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStartNormal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHidePrizes
        '
        Me.btnHidePrizes.Location = New System.Drawing.Point(111, 259)
        Me.btnHidePrizes.Name = "btnHidePrizes"
        Me.btnHidePrizes.Size = New System.Drawing.Size(75, 56)
        Me.btnHidePrizes.TabIndex = 0
        Me.btnHidePrizes.Text = "HIDE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THOSE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRIZES !!"
        Me.btnHidePrizes.UseVisualStyleBackColor = True
        '
        'lblBoxesLeft
        '
        Me.lblBoxesLeft.AutoSize = True
        Me.lblBoxesLeft.Location = New System.Drawing.Point(13, 259)
        Me.lblBoxesLeft.Name = "lblBoxesLeft"
        Me.lblBoxesLeft.Size = New System.Drawing.Size(74, 13)
        Me.lblBoxesLeft.TabIndex = 1
        Me.lblBoxesLeft.Text = "Boxes left : 10"
        Me.lblBoxesLeft.Visible = False
        '
        'radNormalMode
        '
        Me.radNormalMode.AutoSize = True
        Me.radNormalMode.Checked = True
        Me.radNormalMode.Location = New System.Drawing.Point(193, 257)
        Me.radNormalMode.Name = "radNormalMode"
        Me.radNormalMode.Size = New System.Drawing.Size(88, 17)
        Me.radNormalMode.TabIndex = 2
        Me.radNormalMode.TabStop = True
        Me.radNormalMode.Text = "Normal Mode"
        Me.radNormalMode.UseVisualStyleBackColor = True
        '
        'radEasyMode
        '
        Me.radEasyMode.AutoSize = True
        Me.radEasyMode.Location = New System.Drawing.Point(193, 281)
        Me.radEasyMode.Name = "radEasyMode"
        Me.radEasyMode.Size = New System.Drawing.Size(78, 17)
        Me.radEasyMode.TabIndex = 3
        Me.radEasyMode.Text = "Easy Mode"
        Me.radEasyMode.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuStart})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(307, 24)
        Me.mnuMain.TabIndex = 4
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
        'mnuStart
        '
        Me.mnuStart.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStartEasy, Me.mnuStartNormal})
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(43, 20)
        Me.mnuStart.Text = "Start"
        '
        'mnuStartEasy
        '
        Me.mnuStartEasy.Name = "mnuStartEasy"
        Me.mnuStartEasy.Size = New System.Drawing.Size(180, 22)
        Me.mnuStartEasy.Tag = "1"
        Me.mnuStartEasy.Text = "Easy Mode"
        '
        'mnuStartNormal
        '
        Me.mnuStartNormal.Name = "mnuStartNormal"
        Me.mnuStartNormal.Size = New System.Drawing.Size(180, 22)
        Me.mnuStartNormal.Tag = "2"
        Me.mnuStartNormal.Text = "Normal Mode"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 327)
        Me.Controls.Add(Me.radEasyMode)
        Me.Controls.Add(Me.radNormalMode)
        Me.Controls.Add(Me.lblBoxesLeft)
        Me.Controls.Add(Me.btnHidePrizes)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Hidden Prizes!!"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHidePrizes As Button
    Friend WithEvents lblBoxesLeft As Label
    Friend WithEvents radNormalMode As RadioButton
    Friend WithEvents radEasyMode As RadioButton
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuStart As ToolStripMenuItem
    Friend WithEvents mnuStartEasy As ToolStripMenuItem
    Friend WithEvents mnuStartNormal As ToolStripMenuItem
End Class
