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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblInfoUserWins = New System.Windows.Forms.Label()
        Me.lblUserWins = New System.Windows.Forms.Label()
        Me.lblUserSelection = New System.Windows.Forms.Label()
        Me.lblInfoComputerSelection = New System.Windows.Forms.Label()
        Me.lblComputerSelection = New System.Windows.Forms.Label()
        Me.lblInfoComputerWins = New System.Windows.Forms.Label()
        Me.lblComputerWins = New System.Windows.Forms.Label()
        Me.lblInfoWhoVictory = New System.Windows.Forms.Label()
        Me.lblVictoryWho = New System.Windows.Forms.Label()
        Me.lblInfoGamesPlayed = New System.Windows.Forms.Label()
        Me.lblGamesPlayed = New System.Windows.Forms.Label()
        Me.picUserSelection = New System.Windows.Forms.PictureBox()
        Me.picCompSelection = New System.Windows.Forms.PictureBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRock = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaper = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScissors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirm = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkGraphics = New System.Windows.Forms.CheckBox()
        Me.btnWager = New System.Windows.Forms.Button()
        Me.lblInfoTotalWager = New System.Windows.Forms.Label()
        Me.lblTotalWager = New System.Windows.Forms.Label()
        Me.lblInfoPoints = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picUserSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radScissors)
        Me.GroupBox1.Controls.Add(Me.radPaper)
        Me.GroupBox1.Controls.Add(Me.radRock)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(73, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(5, 93)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(5, 57)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Checked = True
        Me.radRock.Location = New System.Drawing.Point(5, 19)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(10, 247)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 37)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm Selecton"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblInfoUserWins
        '
        Me.lblInfoUserWins.AutoSize = True
        Me.lblInfoUserWins.Location = New System.Drawing.Point(9, 58)
        Me.lblInfoUserWins.Name = "lblInfoUserWins"
        Me.lblInfoUserWins.Size = New System.Drawing.Size(101, 13)
        Me.lblInfoUserWins.TabIndex = 2
        Me.lblInfoUserWins.Text = "Times you've won : "
        '
        'lblUserWins
        '
        Me.lblUserWins.AutoSize = True
        Me.lblUserWins.Location = New System.Drawing.Point(14, 84)
        Me.lblUserWins.Name = "lblUserWins"
        Me.lblUserWins.Size = New System.Drawing.Size(13, 13)
        Me.lblUserWins.TabIndex = 3
        Me.lblUserWins.Text = "0"
        '
        'lblUserSelection
        '
        Me.lblUserSelection.AutoSize = True
        Me.lblUserSelection.Location = New System.Drawing.Point(91, 161)
        Me.lblUserSelection.Name = "lblUserSelection"
        Me.lblUserSelection.Size = New System.Drawing.Size(13, 13)
        Me.lblUserSelection.TabIndex = 4
        Me.lblUserSelection.Text = "?"
        '
        'lblInfoComputerSelection
        '
        Me.lblInfoComputerSelection.AutoSize = True
        Me.lblInfoComputerSelection.Location = New System.Drawing.Point(241, 141)
        Me.lblInfoComputerSelection.Name = "lblInfoComputerSelection"
        Me.lblInfoComputerSelection.Size = New System.Drawing.Size(115, 13)
        Me.lblInfoComputerSelection.TabIndex = 5
        Me.lblInfoComputerSelection.Text = "Computer's Selection : "
        '
        'lblComputerSelection
        '
        Me.lblComputerSelection.AutoSize = True
        Me.lblComputerSelection.Location = New System.Drawing.Point(244, 161)
        Me.lblComputerSelection.Name = "lblComputerSelection"
        Me.lblComputerSelection.Size = New System.Drawing.Size(13, 13)
        Me.lblComputerSelection.TabIndex = 6
        Me.lblComputerSelection.Text = "?"
        '
        'lblInfoComputerWins
        '
        Me.lblInfoComputerWins.AutoSize = True
        Me.lblInfoComputerWins.Location = New System.Drawing.Point(244, 58)
        Me.lblInfoComputerWins.Name = "lblInfoComputerWins"
        Me.lblInfoComputerWins.Size = New System.Drawing.Size(114, 13)
        Me.lblInfoComputerWins.TabIndex = 7
        Me.lblInfoComputerWins.Text = "Times computer won : "
        '
        'lblComputerWins
        '
        Me.lblComputerWins.AutoSize = True
        Me.lblComputerWins.Location = New System.Drawing.Point(253, 84)
        Me.lblComputerWins.Name = "lblComputerWins"
        Me.lblComputerWins.Size = New System.Drawing.Size(13, 13)
        Me.lblComputerWins.TabIndex = 8
        Me.lblComputerWins.Text = "0"
        '
        'lblInfoWhoVictory
        '
        Me.lblInfoWhoVictory.AutoSize = True
        Me.lblInfoWhoVictory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoWhoVictory.Location = New System.Drawing.Point(135, 93)
        Me.lblInfoWhoVictory.Name = "lblInfoWhoVictory"
        Me.lblInfoWhoVictory.Size = New System.Drawing.Size(87, 20)
        Me.lblInfoWhoVictory.TabIndex = 9
        Me.lblInfoWhoVictory.Text = "Victory to..."
        '
        'lblVictoryWho
        '
        Me.lblVictoryWho.AutoSize = True
        Me.lblVictoryWho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVictoryWho.Location = New System.Drawing.Point(161, 113)
        Me.lblVictoryWho.Name = "lblVictoryWho"
        Me.lblVictoryWho.Size = New System.Drawing.Size(18, 20)
        Me.lblVictoryWho.TabIndex = 10
        Me.lblVictoryWho.Text = "?"
        '
        'lblInfoGamesPlayed
        '
        Me.lblInfoGamesPlayed.AutoSize = True
        Me.lblInfoGamesPlayed.Location = New System.Drawing.Point(162, 30)
        Me.lblInfoGamesPlayed.Name = "lblInfoGamesPlayed"
        Me.lblInfoGamesPlayed.Size = New System.Drawing.Size(87, 13)
        Me.lblInfoGamesPlayed.TabIndex = 11
        Me.lblInfoGamesPlayed.Text = " Games Played : "
        '
        'lblGamesPlayed
        '
        Me.lblGamesPlayed.AutoSize = True
        Me.lblGamesPlayed.Location = New System.Drawing.Point(184, 43)
        Me.lblGamesPlayed.Name = "lblGamesPlayed"
        Me.lblGamesPlayed.Size = New System.Drawing.Size(13, 13)
        Me.lblGamesPlayed.TabIndex = 12
        Me.lblGamesPlayed.Text = "0"
        '
        'picUserSelection
        '
        Me.picUserSelection.Location = New System.Drawing.Point(87, 177)
        Me.picUserSelection.Name = "picUserSelection"
        Me.picUserSelection.Size = New System.Drawing.Size(88, 75)
        Me.picUserSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserSelection.TabIndex = 13
        Me.picUserSelection.TabStop = False
        '
        'picCompSelection
        '
        Me.picCompSelection.Location = New System.Drawing.Point(227, 177)
        Me.picCompSelection.Name = "picCompSelection"
        Me.picCompSelection.Size = New System.Drawing.Size(91, 75)
        Me.picCompSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCompSelection.TabIndex = 14
        Me.picCompSelection.TabStop = False
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSelection})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(357, 24)
        Me.mnuMain.TabIndex = 15
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuLoad, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(100, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuLoad
        '
        Me.mnuLoad.Name = "mnuLoad"
        Me.mnuLoad.Size = New System.Drawing.Size(100, 22)
        Me.mnuLoad.Text = "Load"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(100, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuSelection
        '
        Me.mnuSelection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRock, Me.mnuPaper, Me.mnuScissors, Me.mnuConfirm})
        Me.mnuSelection.Name = "mnuSelection"
        Me.mnuSelection.Size = New System.Drawing.Size(67, 20)
        Me.mnuSelection.Text = "Selection"
        '
        'mnuRock
        '
        Me.mnuRock.Name = "mnuRock"
        Me.mnuRock.Size = New System.Drawing.Size(118, 22)
        Me.mnuRock.Text = "Rock"
        '
        'mnuPaper
        '
        Me.mnuPaper.Name = "mnuPaper"
        Me.mnuPaper.Size = New System.Drawing.Size(118, 22)
        Me.mnuPaper.Text = "Paper"
        '
        'mnuScissors
        '
        Me.mnuScissors.Name = "mnuScissors"
        Me.mnuScissors.Size = New System.Drawing.Size(118, 22)
        Me.mnuScissors.Text = "Scissors"
        '
        'mnuConfirm
        '
        Me.mnuConfirm.Name = "mnuConfirm"
        Me.mnuConfirm.Size = New System.Drawing.Size(118, 22)
        Me.mnuConfirm.Text = "Confirm"
        '
        'chkGraphics
        '
        Me.chkGraphics.AutoSize = True
        Me.chkGraphics.Checked = True
        Me.chkGraphics.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphics.Location = New System.Drawing.Point(92, 259)
        Me.chkGraphics.Name = "chkGraphics"
        Me.chkGraphics.Size = New System.Drawing.Size(68, 17)
        Me.chkGraphics.TabIndex = 16
        Me.chkGraphics.Text = "Graphics"
        Me.chkGraphics.UseVisualStyleBackColor = True
        '
        'btnWager
        '
        Me.btnWager.Location = New System.Drawing.Point(12, 28)
        Me.btnWager.Name = "btnWager"
        Me.btnWager.Size = New System.Drawing.Size(56, 23)
        Me.btnWager.TabIndex = 17
        Me.btnWager.Text = "Wager"
        Me.btnWager.UseVisualStyleBackColor = True
        '
        'lblInfoTotalWager
        '
        Me.lblInfoTotalWager.AutoSize = True
        Me.lblInfoTotalWager.Location = New System.Drawing.Point(75, 24)
        Me.lblInfoTotalWager.Name = "lblInfoTotalWager"
        Me.lblInfoTotalWager.Size = New System.Drawing.Size(72, 13)
        Me.lblInfoTotalWager.TabIndex = 18
        Me.lblInfoTotalWager.Text = "Total Wager :"
        '
        'lblTotalWager
        '
        Me.lblTotalWager.AutoSize = True
        Me.lblTotalWager.Location = New System.Drawing.Point(78, 42)
        Me.lblTotalWager.Name = "lblTotalWager"
        Me.lblTotalWager.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalWager.TabIndex = 19
        Me.lblTotalWager.Text = "0"
        '
        'lblInfoPoints
        '
        Me.lblInfoPoints.AutoSize = True
        Me.lblInfoPoints.Location = New System.Drawing.Point(278, 24)
        Me.lblInfoPoints.Name = "lblInfoPoints"
        Me.lblInfoPoints.Size = New System.Drawing.Size(67, 13)
        Me.lblInfoPoints.TabIndex = 20
        Me.lblInfoPoints.Text = "Your Points :"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(306, 42)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(13, 13)
        Me.lblPoints.TabIndex = 21
        Me.lblPoints.Text = "0"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 293)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblInfoPoints)
        Me.Controls.Add(Me.lblTotalWager)
        Me.Controls.Add(Me.lblInfoTotalWager)
        Me.Controls.Add(Me.btnWager)
        Me.Controls.Add(Me.chkGraphics)
        Me.Controls.Add(Me.picCompSelection)
        Me.Controls.Add(Me.picUserSelection)
        Me.Controls.Add(Me.lblGamesPlayed)
        Me.Controls.Add(Me.lblInfoGamesPlayed)
        Me.Controls.Add(Me.lblVictoryWho)
        Me.Controls.Add(Me.lblInfoWhoVictory)
        Me.Controls.Add(Me.lblComputerWins)
        Me.Controls.Add(Me.lblInfoComputerWins)
        Me.Controls.Add(Me.lblComputerSelection)
        Me.Controls.Add(Me.lblInfoComputerSelection)
        Me.Controls.Add(Me.lblUserSelection)
        Me.Controls.Add(Me.lblUserWins)
        Me.Controls.Add(Me.lblInfoUserWins)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picUserSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblInfoUserWins As Label
    Friend WithEvents lblUserWins As Label
    Friend WithEvents lblUserSelection As Label
    Friend WithEvents lblInfoComputerSelection As Label
    Friend WithEvents lblComputerSelection As Label
    Friend WithEvents lblInfoComputerWins As Label
    Friend WithEvents lblComputerWins As Label
    Friend WithEvents lblInfoWhoVictory As Label
    Friend WithEvents lblVictoryWho As Label
    Friend WithEvents lblInfoGamesPlayed As Label
    Friend WithEvents lblGamesPlayed As Label
    Friend WithEvents picUserSelection As PictureBox
    Friend WithEvents picCompSelection As PictureBox
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuSelection As ToolStripMenuItem
    Friend WithEvents mnuRock As ToolStripMenuItem
    Friend WithEvents mnuPaper As ToolStripMenuItem
    Friend WithEvents mnuScissors As ToolStripMenuItem
    Friend WithEvents mnuConfirm As ToolStripMenuItem
    Friend WithEvents chkGraphics As CheckBox
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuLoad As ToolStripMenuItem
    Friend WithEvents btnWager As Button
    Friend WithEvents lblInfoTotalWager As Label
    Friend WithEvents lblTotalWager As Label
    Friend WithEvents lblInfoPoints As Label
    Friend WithEvents lblPoints As Label
End Class
