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
        Me.picComp1 = New System.Windows.Forms.PictureBox()
        Me.picComp2 = New System.Windows.Forms.PictureBox()
        Me.picComp3 = New System.Windows.Forms.PictureBox()
        Me.picUser3 = New System.Windows.Forms.PictureBox()
        Me.picUser2 = New System.Windows.Forms.PictureBox()
        Me.picUser1 = New System.Windows.Forms.PictureBox()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnStand = New System.Windows.Forms.Button()
        Me.btnWager = New System.Windows.Forms.Button()
        Me.lblWager = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameDeal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameHit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameStand = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameWager = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGameReset = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picComp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComp1
        '
        Me.picComp1.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picComp1.Location = New System.Drawing.Point(30, 33)
        Me.picComp1.Name = "picComp1"
        Me.picComp1.Size = New System.Drawing.Size(70, 87)
        Me.picComp1.TabIndex = 0
        Me.picComp1.TabStop = False
        '
        'picComp2
        '
        Me.picComp2.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picComp2.Location = New System.Drawing.Point(135, 33)
        Me.picComp2.Name = "picComp2"
        Me.picComp2.Size = New System.Drawing.Size(70, 87)
        Me.picComp2.TabIndex = 1
        Me.picComp2.TabStop = False
        '
        'picComp3
        '
        Me.picComp3.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picComp3.Location = New System.Drawing.Point(240, 33)
        Me.picComp3.Name = "picComp3"
        Me.picComp3.Size = New System.Drawing.Size(70, 87)
        Me.picComp3.TabIndex = 2
        Me.picComp3.TabStop = False
        '
        'picUser3
        '
        Me.picUser3.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picUser3.Location = New System.Drawing.Point(240, 194)
        Me.picUser3.Name = "picUser3"
        Me.picUser3.Size = New System.Drawing.Size(70, 87)
        Me.picUser3.TabIndex = 5
        Me.picUser3.TabStop = False
        '
        'picUser2
        '
        Me.picUser2.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picUser2.Location = New System.Drawing.Point(135, 194)
        Me.picUser2.Name = "picUser2"
        Me.picUser2.Size = New System.Drawing.Size(70, 87)
        Me.picUser2.TabIndex = 4
        Me.picUser2.TabStop = False
        '
        'picUser1
        '
        Me.picUser1.Image = Global.Hudzik28_CardGame_.My.Resources.Resources.cardback
        Me.picUser1.Location = New System.Drawing.Point(30, 194)
        Me.picUser1.Name = "picUser1"
        Me.picUser1.Size = New System.Drawing.Size(70, 87)
        Me.picUser1.TabIndex = 3
        Me.picUser1.TabStop = False
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(30, 141)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(75, 23)
        Me.btnDeal.TabIndex = 0
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnStand
        '
        Me.btnStand.Location = New System.Drawing.Point(235, 141)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(75, 23)
        Me.btnStand.TabIndex = 1
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'btnWager
        '
        Me.btnWager.Location = New System.Drawing.Point(12, 287)
        Me.btnWager.Name = "btnWager"
        Me.btnWager.Size = New System.Drawing.Size(75, 23)
        Me.btnWager.TabIndex = 2
        Me.btnWager.Text = "Wager"
        Me.btnWager.UseVisualStyleBackColor = True
        '
        'lblWager
        '
        Me.lblWager.AutoSize = True
        Me.lblWager.Location = New System.Drawing.Point(93, 292)
        Me.lblWager.Name = "lblWager"
        Me.lblWager.Size = New System.Drawing.Size(91, 13)
        Me.lblWager.TabIndex = 4
        Me.lblWager.Text = "Current Wager : 0"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(120, 146)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(100, 13)
        Me.lblPoints.TabIndex = 5
        Me.lblPoints.Text = "Current Points : 100"
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.GameToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(360, 24)
        Me.mnuMain.TabIndex = 3
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileRules, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGameDeal, Me.mnuGameHit, Me.mnuGameStand, Me.mnuGameWager, Me.mnuGameReset})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "&Game"
        '
        'mnuGameDeal
        '
        Me.mnuGameDeal.Name = "mnuGameDeal"
        Me.mnuGameDeal.Size = New System.Drawing.Size(180, 22)
        Me.mnuGameDeal.Text = "&Deal"
        '
        'mnuGameHit
        '
        Me.mnuGameHit.Name = "mnuGameHit"
        Me.mnuGameHit.Size = New System.Drawing.Size(180, 22)
        Me.mnuGameHit.Text = "&Hit"
        '
        'mnuGameStand
        '
        Me.mnuGameStand.Name = "mnuGameStand"
        Me.mnuGameStand.Size = New System.Drawing.Size(180, 22)
        Me.mnuGameStand.Text = "&Stand"
        '
        'mnuGameWager
        '
        Me.mnuGameWager.Name = "mnuGameWager"
        Me.mnuGameWager.Size = New System.Drawing.Size(180, 22)
        Me.mnuGameWager.Text = "&Wager"
        '
        'mnuFileRules
        '
        Me.mnuFileRules.Name = "mnuFileRules"
        Me.mnuFileRules.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileRules.Text = "Rules"
        '
        'mnuGameReset
        '
        Me.mnuGameReset.Name = "mnuGameReset"
        Me.mnuGameReset.Size = New System.Drawing.Size(180, 22)
        Me.mnuGameReset.Text = "&Reset"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 314)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblWager)
        Me.Controls.Add(Me.btnWager)
        Me.Controls.Add(Me.btnStand)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.picUser3)
        Me.Controls.Add(Me.picUser2)
        Me.Controls.Add(Me.picUser1)
        Me.Controls.Add(Me.picComp3)
        Me.Controls.Add(Me.picComp2)
        Me.Controls.Add(Me.picComp1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Blackjack"
        CType(Me.picComp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComp1 As PictureBox
    Friend WithEvents picComp2 As PictureBox
    Friend WithEvents picComp3 As PictureBox
    Friend WithEvents picUser3 As PictureBox
    Friend WithEvents picUser2 As PictureBox
    Friend WithEvents picUser1 As PictureBox
    Friend WithEvents btnDeal As Button
    Friend WithEvents btnStand As Button
    Friend WithEvents btnWager As Button
    Friend WithEvents lblWager As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuGameDeal As ToolStripMenuItem
    Friend WithEvents mnuGameHit As ToolStripMenuItem
    Friend WithEvents mnuGameStand As ToolStripMenuItem
    Friend WithEvents mnuGameWager As ToolStripMenuItem
    Friend WithEvents mnuFileRules As ToolStripMenuItem
    Friend WithEvents mnuGameReset As ToolStripMenuItem
End Class
