<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.btnSelect1 = New System.Windows.Forms.Button()
        Me.btnSelect2 = New System.Windows.Forms.Button()
        Me.btnSelect3 = New System.Windows.Forms.Button()
        Me.btnSelect6 = New System.Windows.Forms.Button()
        Me.btnSelect5 = New System.Windows.Forms.Button()
        Me.btnSelect4 = New System.Windows.Forms.Button()
        Me.btnDeselect = New System.Windows.Forms.Button()
        Me.lblInfoPlayerPoints = New System.Windows.Forms.Label()
        Me.lblPlayerPoints = New System.Windows.Forms.Label()
        Me.mnuMainGame = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeselect = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDebug = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEndTurn = New System.Windows.Forms.Button()
        Me.lblDieSelected1 = New System.Windows.Forms.Label()
        Me.lblDieSelected2 = New System.Windows.Forms.Label()
        Me.lblDieSelected3 = New System.Windows.Forms.Label()
        Me.lblDieSelected4 = New System.Windows.Forms.Label()
        Me.lblDieSelected5 = New System.Windows.Forms.Label()
        Me.lblDieSelected6 = New System.Windows.Forms.Label()
        Me.lblInfoDie1 = New System.Windows.Forms.Label()
        Me.lblInfoDie2 = New System.Windows.Forms.Label()
        Me.lblInfoDie3 = New System.Windows.Forms.Label()
        Me.lblInfoDie4 = New System.Windows.Forms.Label()
        Me.lblInfoDie5 = New System.Windows.Forms.Label()
        Me.lblInfoDie6 = New System.Windows.Forms.Label()
        Me.picDie6 = New System.Windows.Forms.PictureBox()
        Me.picDie5 = New System.Windows.Forms.PictureBox()
        Me.picDie4 = New System.Windows.Forms.PictureBox()
        Me.picDie3 = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.mnuMainGame.SuspendLayout()
        CType(Me.picDie6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelect1
        '
        Me.btnSelect1.Location = New System.Drawing.Point(18, 254)
        Me.btnSelect1.Name = "btnSelect1"
        Me.btnSelect1.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect1.TabIndex = 0
        Me.btnSelect1.Text = "Select First"
        Me.btnSelect1.UseVisualStyleBackColor = True
        '
        'btnSelect2
        '
        Me.btnSelect2.Location = New System.Drawing.Point(113, 254)
        Me.btnSelect2.Name = "btnSelect2"
        Me.btnSelect2.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect2.TabIndex = 1
        Me.btnSelect2.Text = "Select Second"
        Me.btnSelect2.UseVisualStyleBackColor = True
        '
        'btnSelect3
        '
        Me.btnSelect3.Location = New System.Drawing.Point(212, 254)
        Me.btnSelect3.Name = "btnSelect3"
        Me.btnSelect3.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect3.TabIndex = 2
        Me.btnSelect3.Text = "Select Third"
        Me.btnSelect3.UseVisualStyleBackColor = True
        '
        'btnSelect6
        '
        Me.btnSelect6.Location = New System.Drawing.Point(212, 283)
        Me.btnSelect6.Name = "btnSelect6"
        Me.btnSelect6.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect6.TabIndex = 5
        Me.btnSelect6.Text = "Select Sixth"
        Me.btnSelect6.UseVisualStyleBackColor = True
        '
        'btnSelect5
        '
        Me.btnSelect5.Location = New System.Drawing.Point(113, 283)
        Me.btnSelect5.Name = "btnSelect5"
        Me.btnSelect5.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect5.TabIndex = 4
        Me.btnSelect5.Text = "Select Fifth"
        Me.btnSelect5.UseVisualStyleBackColor = True
        '
        'btnSelect4
        '
        Me.btnSelect4.Location = New System.Drawing.Point(18, 283)
        Me.btnSelect4.Name = "btnSelect4"
        Me.btnSelect4.Size = New System.Drawing.Size(89, 23)
        Me.btnSelect4.TabIndex = 3
        Me.btnSelect4.Text = "Select Fourth"
        Me.btnSelect4.UseVisualStyleBackColor = True
        '
        'btnDeselect
        '
        Me.btnDeselect.Location = New System.Drawing.Point(18, 225)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(74, 23)
        Me.btnDeselect.TabIndex = 13
        Me.btnDeselect.Text = "Deselect"
        Me.btnDeselect.UseVisualStyleBackColor = True
        '
        'lblInfoPlayerPoints
        '
        Me.lblInfoPlayerPoints.AutoSize = True
        Me.lblInfoPlayerPoints.Location = New System.Drawing.Point(194, 66)
        Me.lblInfoPlayerPoints.Name = "lblInfoPlayerPoints"
        Me.lblInfoPlayerPoints.Size = New System.Drawing.Size(70, 13)
        Me.lblInfoPlayerPoints.TabIndex = 14
        Me.lblInfoPlayerPoints.Text = "Your Points : "
        '
        'lblPlayerPoints
        '
        Me.lblPlayerPoints.AutoSize = True
        Me.lblPlayerPoints.Location = New System.Drawing.Point(233, 87)
        Me.lblPlayerPoints.Name = "lblPlayerPoints"
        Me.lblPlayerPoints.Size = New System.Drawing.Size(13, 13)
        Me.lblPlayerPoints.TabIndex = 15
        Me.lblPlayerPoints.Text = "0"
        '
        'mnuMainGame
        '
        Me.mnuMainGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuGame})
        Me.mnuMainGame.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainGame.Name = "mnuMainGame"
        Me.mnuMainGame.Size = New System.Drawing.Size(320, 24)
        Me.mnuMainGame.TabIndex = 16
        Me.mnuMainGame.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuGame
        '
        Me.mnuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeselect, Me.mnuInstructions, Me.mnuAbout, Me.mnuDebug})
        Me.mnuGame.Name = "mnuGame"
        Me.mnuGame.Size = New System.Drawing.Size(50, 20)
        Me.mnuGame.Text = "Game"
        '
        'mnuDeselect
        '
        Me.mnuDeselect.Name = "mnuDeselect"
        Me.mnuDeselect.Size = New System.Drawing.Size(180, 22)
        Me.mnuDeselect.Text = "Deselect"
        '
        'mnuInstructions
        '
        Me.mnuInstructions.Name = "mnuInstructions"
        Me.mnuInstructions.Size = New System.Drawing.Size(180, 22)
        Me.mnuInstructions.Text = "Instructions"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuDebug
        '
        Me.mnuDebug.Name = "mnuDebug"
        Me.mnuDebug.Size = New System.Drawing.Size(180, 22)
        Me.mnuDebug.Text = "Debug Menu"
        '
        'btnEndTurn
        '
        Me.btnEndTurn.Location = New System.Drawing.Point(225, 225)
        Me.btnEndTurn.Name = "btnEndTurn"
        Me.btnEndTurn.Size = New System.Drawing.Size(76, 23)
        Me.btnEndTurn.TabIndex = 17
        Me.btnEndTurn.Text = "End Turn"
        Me.btnEndTurn.UseVisualStyleBackColor = True
        '
        'lblDieSelected1
        '
        Me.lblDieSelected1.AutoSize = True
        Me.lblDieSelected1.Location = New System.Drawing.Point(82, 66)
        Me.lblDieSelected1.Name = "lblDieSelected1"
        Me.lblDieSelected1.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected1.TabIndex = 18
        Me.lblDieSelected1.Text = "✓"
        Me.lblDieSelected1.Visible = False
        '
        'lblDieSelected2
        '
        Me.lblDieSelected2.AutoSize = True
        Me.lblDieSelected2.Location = New System.Drawing.Point(82, 120)
        Me.lblDieSelected2.Name = "lblDieSelected2"
        Me.lblDieSelected2.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected2.TabIndex = 19
        Me.lblDieSelected2.Text = "✓"
        Me.lblDieSelected2.Visible = False
        '
        'lblDieSelected3
        '
        Me.lblDieSelected3.AutoSize = True
        Me.lblDieSelected3.Location = New System.Drawing.Point(82, 172)
        Me.lblDieSelected3.Name = "lblDieSelected3"
        Me.lblDieSelected3.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected3.TabIndex = 20
        Me.lblDieSelected3.Text = "✓"
        Me.lblDieSelected3.Visible = False
        '
        'lblDieSelected4
        '
        Me.lblDieSelected4.AutoSize = True
        Me.lblDieSelected4.Location = New System.Drawing.Point(173, 66)
        Me.lblDieSelected4.Name = "lblDieSelected4"
        Me.lblDieSelected4.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected4.TabIndex = 21
        Me.lblDieSelected4.Text = "✓"
        Me.lblDieSelected4.Visible = False
        '
        'lblDieSelected5
        '
        Me.lblDieSelected5.AutoSize = True
        Me.lblDieSelected5.Location = New System.Drawing.Point(173, 120)
        Me.lblDieSelected5.Name = "lblDieSelected5"
        Me.lblDieSelected5.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected5.TabIndex = 22
        Me.lblDieSelected5.Text = "✓"
        Me.lblDieSelected5.Visible = False
        '
        'lblDieSelected6
        '
        Me.lblDieSelected6.AutoSize = True
        Me.lblDieSelected6.Location = New System.Drawing.Point(173, 172)
        Me.lblDieSelected6.Name = "lblDieSelected6"
        Me.lblDieSelected6.Size = New System.Drawing.Size(15, 13)
        Me.lblDieSelected6.TabIndex = 23
        Me.lblDieSelected6.Text = "✓"
        Me.lblDieSelected6.Visible = False
        '
        'lblInfoDie1
        '
        Me.lblInfoDie1.AutoSize = True
        Me.lblInfoDie1.Location = New System.Drawing.Point(8, 66)
        Me.lblInfoDie1.Name = "lblInfoDie1"
        Me.lblInfoDie1.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie1.TabIndex = 24
        Me.lblInfoDie1.Text = "1"
        '
        'lblInfoDie2
        '
        Me.lblInfoDie2.AutoSize = True
        Me.lblInfoDie2.Location = New System.Drawing.Point(8, 120)
        Me.lblInfoDie2.Name = "lblInfoDie2"
        Me.lblInfoDie2.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie2.TabIndex = 25
        Me.lblInfoDie2.Text = "2"
        '
        'lblInfoDie3
        '
        Me.lblInfoDie3.AutoSize = True
        Me.lblInfoDie3.Location = New System.Drawing.Point(8, 172)
        Me.lblInfoDie3.Name = "lblInfoDie3"
        Me.lblInfoDie3.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie3.TabIndex = 26
        Me.lblInfoDie3.Text = "3"
        '
        'lblInfoDie4
        '
        Me.lblInfoDie4.AutoSize = True
        Me.lblInfoDie4.Location = New System.Drawing.Point(98, 67)
        Me.lblInfoDie4.Name = "lblInfoDie4"
        Me.lblInfoDie4.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie4.TabIndex = 27
        Me.lblInfoDie4.Text = "4"
        '
        'lblInfoDie5
        '
        Me.lblInfoDie5.AutoSize = True
        Me.lblInfoDie5.Location = New System.Drawing.Point(98, 120)
        Me.lblInfoDie5.Name = "lblInfoDie5"
        Me.lblInfoDie5.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie5.TabIndex = 28
        Me.lblInfoDie5.Text = "5"
        '
        'lblInfoDie6
        '
        Me.lblInfoDie6.AutoSize = True
        Me.lblInfoDie6.Location = New System.Drawing.Point(98, 172)
        Me.lblInfoDie6.Name = "lblInfoDie6"
        Me.lblInfoDie6.Size = New System.Drawing.Size(13, 13)
        Me.lblInfoDie6.TabIndex = 29
        Me.lblInfoDie6.Text = "6"
        '
        'picDie6
        '
        Me.picDie6.Location = New System.Drawing.Point(113, 159)
        Me.picDie6.Name = "picDie6"
        Me.picDie6.Size = New System.Drawing.Size(49, 46)
        Me.picDie6.TabIndex = 12
        Me.picDie6.TabStop = False
        '
        'picDie5
        '
        Me.picDie5.Location = New System.Drawing.Point(113, 107)
        Me.picDie5.Name = "picDie5"
        Me.picDie5.Size = New System.Drawing.Size(49, 46)
        Me.picDie5.TabIndex = 11
        Me.picDie5.TabStop = False
        '
        'picDie4
        '
        Me.picDie4.Location = New System.Drawing.Point(113, 55)
        Me.picDie4.Name = "picDie4"
        Me.picDie4.Size = New System.Drawing.Size(49, 46)
        Me.picDie4.TabIndex = 10
        Me.picDie4.TabStop = False
        '
        'picDie3
        '
        Me.picDie3.Location = New System.Drawing.Point(27, 159)
        Me.picDie3.Name = "picDie3"
        Me.picDie3.Size = New System.Drawing.Size(49, 46)
        Me.picDie3.TabIndex = 9
        Me.picDie3.TabStop = False
        '
        'picDie2
        '
        Me.picDie2.Location = New System.Drawing.Point(27, 107)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(49, 46)
        Me.picDie2.TabIndex = 8
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.Location = New System.Drawing.Point(27, 55)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(49, 46)
        Me.picDie1.TabIndex = 7
        Me.picDie1.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 312)
        Me.Controls.Add(Me.lblInfoDie6)
        Me.Controls.Add(Me.lblInfoDie5)
        Me.Controls.Add(Me.lblInfoDie4)
        Me.Controls.Add(Me.lblInfoDie3)
        Me.Controls.Add(Me.lblInfoDie2)
        Me.Controls.Add(Me.lblInfoDie1)
        Me.Controls.Add(Me.lblDieSelected6)
        Me.Controls.Add(Me.lblDieSelected5)
        Me.Controls.Add(Me.lblDieSelected4)
        Me.Controls.Add(Me.lblDieSelected3)
        Me.Controls.Add(Me.lblDieSelected2)
        Me.Controls.Add(Me.lblDieSelected1)
        Me.Controls.Add(Me.btnEndTurn)
        Me.Controls.Add(Me.lblPlayerPoints)
        Me.Controls.Add(Me.lblInfoPlayerPoints)
        Me.Controls.Add(Me.btnDeselect)
        Me.Controls.Add(Me.picDie6)
        Me.Controls.Add(Me.picDie5)
        Me.Controls.Add(Me.picDie4)
        Me.Controls.Add(Me.picDie3)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.btnSelect6)
        Me.Controls.Add(Me.btnSelect5)
        Me.Controls.Add(Me.btnSelect4)
        Me.Controls.Add(Me.btnSelect3)
        Me.Controls.Add(Me.btnSelect2)
        Me.Controls.Add(Me.btnSelect1)
        Me.Controls.Add(Me.mnuMainGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainGame
        Me.Name = "frmGame"
        Me.Text = "VBFarkle"
        Me.mnuMainGame.ResumeLayout(False)
        Me.mnuMainGame.PerformLayout()
        CType(Me.picDie6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelect1 As Button
    Friend WithEvents btnSelect2 As Button
    Friend WithEvents btnSelect3 As Button
    Friend WithEvents btnSelect6 As Button
    Friend WithEvents btnSelect5 As Button
    Friend WithEvents btnSelect4 As Button
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents picDie3 As PictureBox
    Friend WithEvents picDie4 As PictureBox
    Friend WithEvents picDie5 As PictureBox
    Friend WithEvents picDie6 As PictureBox
    Friend WithEvents btnDeselect As Button
    Friend WithEvents lblInfoPlayerPoints As Label
    Friend WithEvents lblPlayerPoints As Label
    Friend WithEvents mnuMainGame As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuGame As ToolStripMenuItem
    Friend WithEvents btnEndTurn As Button
    Friend WithEvents mnuInstructions As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents lblDieSelected1 As Label
    Friend WithEvents lblDieSelected2 As Label
    Friend WithEvents lblDieSelected3 As Label
    Friend WithEvents lblDieSelected4 As Label
    Friend WithEvents lblDieSelected5 As Label
    Friend WithEvents lblDieSelected6 As Label
    Friend WithEvents lblInfoDie1 As Label
    Friend WithEvents lblInfoDie2 As Label
    Friend WithEvents lblInfoDie3 As Label
    Friend WithEvents lblInfoDie4 As Label
    Friend WithEvents lblInfoDie5 As Label
    Friend WithEvents lblInfoDie6 As Label
    Friend WithEvents mnuDebug As ToolStripMenuItem
    Friend WithEvents mnuDeselect As ToolStripMenuItem
End Class
