<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutGame
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
        Me.lblInfoMainText7 = New System.Windows.Forms.Label()
        Me.lblInfoMainText6 = New System.Windows.Forms.Label()
        Me.lblInfoMainText5 = New System.Windows.Forms.Label()
        Me.lblInfoMainText4 = New System.Windows.Forms.Label()
        Me.lblInfoMainText3 = New System.Windows.Forms.Label()
        Me.lblInfoMainText2 = New System.Windows.Forms.Label()
        Me.lblInfoMainText1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInfoHowToPlay = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfoMainText7
        '
        Me.lblInfoMainText7.AutoSize = True
        Me.lblInfoMainText7.Location = New System.Drawing.Point(12, 141)
        Me.lblInfoMainText7.Name = "lblInfoMainText7"
        Me.lblInfoMainText7.Size = New System.Drawing.Size(243, 13)
        Me.lblInfoMainText7.TabIndex = 17
        Me.lblInfoMainText7.Text = "This has been removed for development purposes"
        '
        'lblInfoMainText6
        '
        Me.lblInfoMainText6.AutoSize = True
        Me.lblInfoMainText6.Location = New System.Drawing.Point(13, 128)
        Me.lblInfoMainText6.Name = "lblInfoMainText6"
        Me.lblInfoMainText6.Size = New System.Drawing.Size(240, 13)
        Me.lblInfoMainText6.TabIndex = 16
        Me.lblInfoMainText6.Text = "Normally you would lose when you run out of dice"
        '
        'lblInfoMainText5
        '
        Me.lblInfoMainText5.AutoSize = True
        Me.lblInfoMainText5.Location = New System.Drawing.Point(12, 102)
        Me.lblInfoMainText5.Name = "lblInfoMainText5"
        Me.lblInfoMainText5.Size = New System.Drawing.Size(223, 13)
        Me.lblInfoMainText5.TabIndex = 15
        Me.lblInfoMainText5.Text = "All other dice are only worth anything in threes"
        '
        'lblInfoMainText4
        '
        Me.lblInfoMainText4.AutoSize = True
        Me.lblInfoMainText4.Location = New System.Drawing.Point(12, 88)
        Me.lblInfoMainText4.Name = "lblInfoMainText4"
        Me.lblInfoMainText4.Size = New System.Drawing.Size(152, 13)
        Me.lblInfoMainText4.TabIndex = 14
        Me.lblInfoMainText4.Text = "Fives are worth 50 points each"
        '
        'lblInfoMainText3
        '
        Me.lblInfoMainText3.AutoSize = True
        Me.lblInfoMainText3.Location = New System.Drawing.Point(12, 74)
        Me.lblInfoMainText3.Name = "lblInfoMainText3"
        Me.lblInfoMainText3.Size = New System.Drawing.Size(158, 13)
        Me.lblInfoMainText3.TabIndex = 13
        Me.lblInfoMainText3.Text = "Ones are worth 100 points each"
        '
        'lblInfoMainText2
        '
        Me.lblInfoMainText2.AutoSize = True
        Me.lblInfoMainText2.Location = New System.Drawing.Point(13, 52)
        Me.lblInfoMainText2.Name = "lblInfoMainText2"
        Me.lblInfoMainText2.Size = New System.Drawing.Size(202, 13)
        Me.lblInfoMainText2.TabIndex = 12
        Me.lblInfoMainText2.Text = "After this you choose which dice to count"
        '
        'lblInfoMainText1
        '
        Me.lblInfoMainText1.AutoSize = True
        Me.lblInfoMainText1.Location = New System.Drawing.Point(13, 39)
        Me.lblInfoMainText1.Name = "lblInfoMainText1"
        Me.lblInfoMainText1.Size = New System.Drawing.Size(162, 13)
        Me.lblInfoMainText1.TabIndex = 11
        Me.lblInfoMainText1.Text = "Farkle is played by rolling six dice"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hudzik20_FirstFinal_.My.Resources.Resources.FarkleDiceTable
        Me.PictureBox1.Location = New System.Drawing.Point(16, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblInfoHowToPlay
        '
        Me.lblInfoHowToPlay.AutoSize = True
        Me.lblInfoHowToPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoHowToPlay.Location = New System.Drawing.Point(12, 9)
        Me.lblInfoHowToPlay.Name = "lblInfoHowToPlay"
        Me.lblInfoHowToPlay.Size = New System.Drawing.Size(114, 20)
        Me.lblInfoHowToPlay.TabIndex = 9
        Me.lblInfoHowToPlay.Text = "How to Play : "
        '
        'frmAboutGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 361)
        Me.Controls.Add(Me.lblInfoMainText7)
        Me.Controls.Add(Me.lblInfoMainText6)
        Me.Controls.Add(Me.lblInfoMainText5)
        Me.Controls.Add(Me.lblInfoMainText4)
        Me.Controls.Add(Me.lblInfoMainText3)
        Me.Controls.Add(Me.lblInfoMainText2)
        Me.Controls.Add(Me.lblInfoMainText1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInfoHowToPlay)
        Me.Name = "frmAboutGame"
        Me.Text = "frmAboutGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoMainText7 As Label
    Friend WithEvents lblInfoMainText6 As Label
    Friend WithEvents lblInfoMainText5 As Label
    Friend WithEvents lblInfoMainText4 As Label
    Friend WithEvents lblInfoMainText3 As Label
    Friend WithEvents lblInfoMainText2 As Label
    Friend WithEvents lblInfoMainText1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInfoHowToPlay As Label
End Class
