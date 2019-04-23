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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 327)
        Me.Controls.Add(Me.radEasyMode)
        Me.Controls.Add(Me.radNormalMode)
        Me.Controls.Add(Me.lblBoxesLeft)
        Me.Controls.Add(Me.btnHidePrizes)
        Me.Name = "frmMain"
        Me.Text = "Hidden Prizes!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHidePrizes As Button
    Friend WithEvents lblBoxesLeft As Label
    Friend WithEvents radNormalMode As RadioButton
    Friend WithEvents radEasyMode As RadioButton
End Class
