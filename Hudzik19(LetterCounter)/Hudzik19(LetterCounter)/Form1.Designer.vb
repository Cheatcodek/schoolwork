<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInfoAmount = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblInfoPhrase = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblLetter = New System.Windows.Forms.Label()
        Me.lblInfoLetter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfoAmount
        '
        Me.lblInfoAmount.AutoSize = True
        Me.lblInfoAmount.Location = New System.Drawing.Point(12, 87)
        Me.lblInfoAmount.Name = "lblInfoAmount"
        Me.lblInfoAmount.Size = New System.Drawing.Size(209, 13)
        Me.lblInfoAmount.TabIndex = 0
        Me.lblInfoAmount.Text = "The letter is in the phrase this many times : "
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(103, 104)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(29, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Error"
        '
        'lblInfoPhrase
        '
        Me.lblInfoPhrase.AutoSize = True
        Me.lblInfoPhrase.Location = New System.Drawing.Point(12, 9)
        Me.lblInfoPhrase.Name = "lblInfoPhrase"
        Me.lblInfoPhrase.Size = New System.Drawing.Size(83, 13)
        Me.lblInfoPhrase.TabIndex = 2
        Me.lblInfoPhrase.Text = "Your phrase is : "
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(31, 26)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(29, 13)
        Me.lblPhrase.TabIndex = 3
        Me.lblPhrase.Text = "Error"
        '
        'lblLetter
        '
        Me.lblLetter.AutoSize = True
        Me.lblLetter.Location = New System.Drawing.Point(31, 56)
        Me.lblLetter.Name = "lblLetter"
        Me.lblLetter.Size = New System.Drawing.Size(29, 13)
        Me.lblLetter.TabIndex = 5
        Me.lblLetter.Text = "Error"
        '
        'lblInfoLetter
        '
        Me.lblInfoLetter.AutoSize = True
        Me.lblInfoLetter.Location = New System.Drawing.Point(12, 39)
        Me.lblInfoLetter.Name = "lblInfoLetter"
        Me.lblInfoLetter.Size = New System.Drawing.Size(74, 13)
        Me.lblInfoLetter.TabIndex = 4
        Me.lblInfoLetter.Text = "Your letter is : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 152)
        Me.Controls.Add(Me.lblLetter)
        Me.Controls.Add(Me.lblInfoLetter)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblInfoPhrase)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblInfoAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoAmount As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblInfoPhrase As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblLetter As Label
    Friend WithEvents lblInfoLetter As Label
End Class
