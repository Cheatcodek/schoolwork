<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectCaseQuiz
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.radFirstAns = New System.Windows.Forms.RadioButton()
        Me.radSecondAns = New System.Windows.Forms.RadioButton()
        Me.radThirdAns = New System.Windows.Forms.RadioButton()
        Me.radFourthAns = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(24, 28)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'radFirstAns
        '
        Me.radFirstAns.AutoSize = True
        Me.radFirstAns.Location = New System.Drawing.Point(27, 61)
        Me.radFirstAns.Name = "radFirstAns"
        Me.radFirstAns.Size = New System.Drawing.Size(90, 17)
        Me.radFirstAns.TabIndex = 1
        Me.radFirstAns.TabStop = True
        Me.radFirstAns.Text = "RadioButton1"
        Me.radFirstAns.UseVisualStyleBackColor = True
        '
        'radSecondAns
        '
        Me.radSecondAns.AutoSize = True
        Me.radSecondAns.Location = New System.Drawing.Point(27, 104)
        Me.radSecondAns.Name = "radSecondAns"
        Me.radSecondAns.Size = New System.Drawing.Size(90, 17)
        Me.radSecondAns.TabIndex = 2
        Me.radSecondAns.TabStop = True
        Me.radSecondAns.Text = "RadioButton2"
        Me.radSecondAns.UseVisualStyleBackColor = True
        '
        'radThirdAns
        '
        Me.radThirdAns.AutoSize = True
        Me.radThirdAns.Location = New System.Drawing.Point(27, 147)
        Me.radThirdAns.Name = "radThirdAns"
        Me.radThirdAns.Size = New System.Drawing.Size(90, 17)
        Me.radThirdAns.TabIndex = 3
        Me.radThirdAns.TabStop = True
        Me.radThirdAns.Text = "RadioButton3"
        Me.radThirdAns.UseVisualStyleBackColor = True
        '
        'radFourthAns
        '
        Me.radFourthAns.AutoSize = True
        Me.radFourthAns.Location = New System.Drawing.Point(27, 193)
        Me.radFourthAns.Name = "radFourthAns"
        Me.radFourthAns.Size = New System.Drawing.Size(90, 17)
        Me.radFourthAns.TabIndex = 4
        Me.radFourthAns.TabStop = True
        Me.radFourthAns.Text = "RadioButton4"
        Me.radFourthAns.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(27, 230)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'frmSelectCaseQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 278)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.radFourthAns)
        Me.Controls.Add(Me.radThirdAns)
        Me.Controls.Add(Me.radSecondAns)
        Me.Controls.Add(Me.radFirstAns)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmSelectCaseQuiz"
        Me.Text = "frmSelectCaseQuiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents radFirstAns As RadioButton
    Friend WithEvents radSecondAns As RadioButton
    Friend WithEvents radThirdAns As RadioButton
    Friend WithEvents radFourthAns As RadioButton
    Friend WithEvents btnConfirm As Button
End Class
