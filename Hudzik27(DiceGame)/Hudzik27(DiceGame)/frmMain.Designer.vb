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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.txtWager = New System.Windows.Forms.TextBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(112, 188)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'picDie1
        '
        Me.picDie1.Location = New System.Drawing.Point(23, 45)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(109, 113)
        Me.picDie1.TabIndex = 1
        Me.picDie1.TabStop = False
        '
        'picDie2
        '
        Me.picDie2.Location = New System.Drawing.Point(162, 45)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(109, 113)
        Me.picDie2.TabIndex = 2
        Me.picDie2.TabStop = False
        '
        'txtWager
        '
        Me.txtWager.Location = New System.Drawing.Point(124, 217)
        Me.txtWager.Name = "txtWager"
        Me.txtWager.Size = New System.Drawing.Size(54, 20)
        Me.txtWager.TabIndex = 3
        Me.txtWager.Text = "Wager"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(112, 244)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(69, 13)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Points : 1000"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 266)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.txtWager)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.btnRoll)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRoll As Button
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents txtWager As TextBox
    Friend WithEvents lblPoints As Label
End Class
