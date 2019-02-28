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
        Me.picShell1 = New System.Windows.Forms.PictureBox()
        Me.picShell2 = New System.Windows.Forms.PictureBox()
        Me.picShell3 = New System.Windows.Forms.PictureBox()
        Me.picPearl1 = New System.Windows.Forms.PictureBox()
        Me.picPearl2 = New System.Windows.Forms.PictureBox()
        Me.picPearl3 = New System.Windows.Forms.PictureBox()
        Me.lblGamesPlayed = New System.Windows.Forms.Label()
        Me.lblGamesWon = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picShell1
        '
        Me.picShell1.Image = Global.Hudzik26_ShellGame_.My.Resources.Resources.Shell
        Me.picShell1.Location = New System.Drawing.Point(12, 34)
        Me.picShell1.Name = "picShell1"
        Me.picShell1.Size = New System.Drawing.Size(145, 156)
        Me.picShell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell1.TabIndex = 0
        Me.picShell1.TabStop = False
        '
        'picShell2
        '
        Me.picShell2.Image = Global.Hudzik26_ShellGame_.My.Resources.Resources.Shell
        Me.picShell2.Location = New System.Drawing.Point(188, 34)
        Me.picShell2.Name = "picShell2"
        Me.picShell2.Size = New System.Drawing.Size(145, 156)
        Me.picShell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell2.TabIndex = 1
        Me.picShell2.TabStop = False
        '
        'picShell3
        '
        Me.picShell3.Image = Global.Hudzik26_ShellGame_.My.Resources.Resources.Shell
        Me.picShell3.Location = New System.Drawing.Point(356, 34)
        Me.picShell3.Name = "picShell3"
        Me.picShell3.Size = New System.Drawing.Size(145, 156)
        Me.picShell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell3.TabIndex = 2
        Me.picShell3.TabStop = False
        '
        'picPearl1
        '
        Me.picPearl1.Location = New System.Drawing.Point(59, 196)
        Me.picPearl1.Name = "picPearl1"
        Me.picPearl1.Size = New System.Drawing.Size(48, 45)
        Me.picPearl1.TabIndex = 3
        Me.picPearl1.TabStop = False
        '
        'picPearl2
        '
        Me.picPearl2.Location = New System.Drawing.Point(233, 196)
        Me.picPearl2.Name = "picPearl2"
        Me.picPearl2.Size = New System.Drawing.Size(48, 45)
        Me.picPearl2.TabIndex = 4
        Me.picPearl2.TabStop = False
        '
        'picPearl3
        '
        Me.picPearl3.Location = New System.Drawing.Point(399, 196)
        Me.picPearl3.Name = "picPearl3"
        Me.picPearl3.Size = New System.Drawing.Size(48, 45)
        Me.picPearl3.TabIndex = 5
        Me.picPearl3.TabStop = False
        '
        'lblGamesPlayed
        '
        Me.lblGamesPlayed.AutoSize = True
        Me.lblGamesPlayed.Location = New System.Drawing.Point(12, 279)
        Me.lblGamesPlayed.Name = "lblGamesPlayed"
        Me.lblGamesPlayed.Size = New System.Drawing.Size(85, 13)
        Me.lblGamesPlayed.TabIndex = 6
        Me.lblGamesPlayed.Text = "Game Played : 0"
        '
        'lblGamesWon
        '
        Me.lblGamesWon.AutoSize = True
        Me.lblGamesWon.Location = New System.Drawing.Point(12, 266)
        Me.lblGamesWon.Name = "lblGamesWon"
        Me.lblGamesWon.Size = New System.Drawing.Size(81, 13)
        Me.lblGamesWon.TabIndex = 7
        Me.lblGamesWon.Text = "Games Won : 0"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(426, 269)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayAgain.TabIndex = 8
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 296)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblGamesWon)
        Me.Controls.Add(Me.lblGamesPlayed)
        Me.Controls.Add(Me.picPearl3)
        Me.Controls.Add(Me.picPearl2)
        Me.Controls.Add(Me.picPearl1)
        Me.Controls.Add(Me.picShell3)
        Me.Controls.Add(Me.picShell2)
        Me.Controls.Add(Me.picShell1)
        Me.Name = "frmMain"
        Me.Text = "Shell Game"
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picShell1 As PictureBox
    Friend WithEvents picShell2 As PictureBox
    Friend WithEvents picShell3 As PictureBox
    Friend WithEvents picPearl1 As PictureBox
    Friend WithEvents picPearl2 As PictureBox
    Friend WithEvents picPearl3 As PictureBox
    Friend WithEvents lblGamesPlayed As Label
    Friend WithEvents lblGamesWon As Label
    Friend WithEvents btnPlayAgain As Button
End Class
