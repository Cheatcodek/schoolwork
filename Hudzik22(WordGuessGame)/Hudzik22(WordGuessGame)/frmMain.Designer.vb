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
        Me.lblInfoDisplayword = New System.Windows.Forms.Label()
        Me.lblDisplayword = New System.Windows.Forms.Label()
        Me.lblInfoWrongguesses = New System.Windows.Forms.Label()
        Me.lblWrongguesses = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoDisplayword
        '
        Me.lblInfoDisplayword.AutoSize = True
        Me.lblInfoDisplayword.Location = New System.Drawing.Point(74, 100)
        Me.lblInfoDisplayword.Name = "lblInfoDisplayword"
        Me.lblInfoDisplayword.Size = New System.Drawing.Size(67, 13)
        Me.lblInfoDisplayword.TabIndex = 0
        Me.lblInfoDisplayword.Text = "Your Word : "
        '
        'lblDisplayword
        '
        Me.lblDisplayword.AutoSize = True
        Me.lblDisplayword.Location = New System.Drawing.Point(89, 117)
        Me.lblDisplayword.Name = "lblDisplayword"
        Me.lblDisplayword.Size = New System.Drawing.Size(39, 13)
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
        'frmMain
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 244)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblWrongguesses)
        Me.Controls.Add(Me.lblInfoWrongguesses)
        Me.Controls.Add(Me.lblDisplayword)
        Me.Controls.Add(Me.lblInfoDisplayword)
        Me.Name = "frmMain"
        Me.Text = "Word Guess"
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
End Class
