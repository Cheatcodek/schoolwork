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
        Me.components = New System.ComponentModel.Container()
        Me.lblInfoDisplayword = New System.Windows.Forms.Label()
        Me.lblDisplayword = New System.Windows.Forms.Label()
        Me.lblInfoWrongguesses = New System.Windows.Forms.Label()
        Me.lblWrongguesses = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.tmrLength = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.tmrVictory = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControls = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControlsConfirm = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControlsTogglemusic = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTogglenoise = New System.Windows.Forms.Button()
        Me.mnuControlsTogglenoise = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoDisplayword
        '
        Me.lblInfoDisplayword.AutoSize = True
        Me.lblInfoDisplayword.Location = New System.Drawing.Point(60, 87)
        Me.lblInfoDisplayword.Name = "lblInfoDisplayword"
        Me.lblInfoDisplayword.Size = New System.Drawing.Size(67, 13)
        Me.lblInfoDisplayword.TabIndex = 0
        Me.lblInfoDisplayword.Text = "Your Word : "
        '
        'lblDisplayword
        '
        Me.lblDisplayword.AutoSize = True
        Me.lblDisplayword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayword.Location = New System.Drawing.Point(75, 104)
        Me.lblDisplayword.Name = "lblDisplayword"
        Me.lblDisplayword.Size = New System.Drawing.Size(49, 16)
        Me.lblDisplayword.TabIndex = 1
        Me.lblDisplayword.Text = "Label1"
        '
        'lblInfoWrongguesses
        '
        Me.lblInfoWrongguesses.AutoSize = True
        Me.lblInfoWrongguesses.Location = New System.Drawing.Point(26, 28)
        Me.lblInfoWrongguesses.Name = "lblInfoWrongguesses"
        Me.lblInfoWrongguesses.Size = New System.Drawing.Size(92, 13)
        Me.lblInfoWrongguesses.TabIndex = 2
        Me.lblInfoWrongguesses.Text = "Wrong Guesses : "
        '
        'lblWrongguesses
        '
        Me.lblWrongguesses.AutoSize = True
        Me.lblWrongguesses.Location = New System.Drawing.Point(41, 45)
        Me.lblWrongguesses.Name = "lblWrongguesses"
        Me.lblWrongguesses.Size = New System.Drawing.Size(13, 13)
        Me.lblWrongguesses.TabIndex = 3
        Me.lblWrongguesses.Text = "0"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(124, 140)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(49, 13)
        Me.lblLength.TabIndex = 4
        Me.lblLength.Text = "Length : "
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(12, 163)
        Me.txtGuess.MaxLength = 1
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 5
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(29, 190)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnToggle
        '
        Me.btnToggle.Location = New System.Drawing.Point(147, 218)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(87, 23)
        Me.btnToggle.TabIndex = 7
        Me.btnToggle.Text = "Toggle Music"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'tmrLength
        '
        Me.tmrLength.Enabled = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(169, 24)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(39, 13)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "Time : "
        '
        'tmrVictory
        '
        Me.tmrVictory.Interval = 500
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuControls})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(237, 24)
        Me.mnuMain.TabIndex = 9
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
        'mnuControls
        '
        Me.mnuControls.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuControlsConfirm, Me.mnuControlsTogglemusic, Me.mnuControlsTogglenoise})
        Me.mnuControls.Name = "mnuControls"
        Me.mnuControls.Size = New System.Drawing.Size(64, 20)
        Me.mnuControls.Text = "Controls"
        '
        'mnuControlsConfirm
        '
        Me.mnuControlsConfirm.Name = "mnuControlsConfirm"
        Me.mnuControlsConfirm.Size = New System.Drawing.Size(180, 22)
        Me.mnuControlsConfirm.Text = "Confirm"
        '
        'mnuControlsTogglemusic
        '
        Me.mnuControlsTogglemusic.Name = "mnuControlsTogglemusic"
        Me.mnuControlsTogglemusic.Size = New System.Drawing.Size(180, 22)
        Me.mnuControlsTogglemusic.Text = "Toggle Music"
        '
        'btnTogglenoise
        '
        Me.btnTogglenoise.Location = New System.Drawing.Point(147, 189)
        Me.btnTogglenoise.Name = "btnTogglenoise"
        Me.btnTogglenoise.Size = New System.Drawing.Size(87, 23)
        Me.btnTogglenoise.TabIndex = 10
        Me.btnTogglenoise.Text = "Toggle Noise"
        Me.btnTogglenoise.UseVisualStyleBackColor = True
        '
        'mnuControlsTogglenoise
        '
        Me.mnuControlsTogglenoise.Name = "mnuControlsTogglenoise"
        Me.mnuControlsTogglenoise.Size = New System.Drawing.Size(180, 22)
        Me.mnuControlsTogglenoise.Text = "Toggle Noise"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 244)
        Me.Controls.Add(Me.btnTogglenoise)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnToggle)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblWrongguesses)
        Me.Controls.Add(Me.lblInfoWrongguesses)
        Me.Controls.Add(Me.lblDisplayword)
        Me.Controls.Add(Me.lblInfoDisplayword)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Word Guess"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoDisplayword As Label
    Friend WithEvents lblDisplayword As Label
    Friend WithEvents lblInfoWrongguesses As Label
    Friend WithEvents lblWrongguesses As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnToggle As Button
    Friend WithEvents tmrLength As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents tmrVictory As Timer
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuControls As ToolStripMenuItem
    Friend WithEvents mnuControlsConfirm As ToolStripMenuItem
    Friend WithEvents mnuControlsTogglemusic As ToolStripMenuItem
    Friend WithEvents btnTogglenoise As Button
    Friend WithEvents mnuControlsTogglenoise As ToolStripMenuItem
End Class
