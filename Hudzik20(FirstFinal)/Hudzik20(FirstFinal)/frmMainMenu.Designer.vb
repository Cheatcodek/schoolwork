<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.picCenterpiece = New System.Windows.Forms.PictureBox()
        CType(Me.picCenterpiece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(80, 133)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(105, 23)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Location = New System.Drawing.Point(80, 163)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(88, 17)
        Me.chkDebug.TabIndex = 2
        Me.chkDebug.Text = "Debug Mode"
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'picCenterpiece
        '
        Me.picCenterpiece.ErrorImage = Global.Hudzik20_FirstFinal_.My.Resources.Resources.placeholder
        Me.picCenterpiece.InitialImage = Global.Hudzik20_FirstFinal_.My.Resources.Resources.placeholder
        Me.picCenterpiece.Location = New System.Drawing.Point(38, 26)
        Me.picCenterpiece.Name = "picCenterpiece"
        Me.picCenterpiece.Size = New System.Drawing.Size(178, 89)
        Me.picCenterpiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCenterpiece.TabIndex = 1
        Me.picCenterpiece.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 189)
        Me.Controls.Add(Me.chkDebug)
        Me.Controls.Add(Me.picCenterpiece)
        Me.Controls.Add(Me.btnStartGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "VBFarkle Main Menu"
        CType(Me.picCenterpiece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartGame As Button
    Friend WithEvents picCenterpiece As PictureBox
    Friend WithEvents chkDebug As CheckBox
End Class
