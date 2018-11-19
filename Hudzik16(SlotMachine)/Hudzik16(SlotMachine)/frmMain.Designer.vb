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
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.lblInfoWheelOne = New System.Windows.Forms.Label()
        Me.lblInfoWheelTwo = New System.Windows.Forms.Label()
        Me.lblInfoWheelThree = New System.Windows.Forms.Label()
        Me.lblWheelOneResult = New System.Windows.Forms.Label()
        Me.lblWheelTwoResult = New System.Windows.Forms.Label()
        Me.lblWheelThreeResult = New System.Windows.Forms.Label()
        Me.lblInfoTokens = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(12, 260)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin!"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'lblInfoWheelOne
        '
        Me.lblInfoWheelOne.AutoSize = True
        Me.lblInfoWheelOne.Location = New System.Drawing.Point(67, 105)
        Me.lblInfoWheelOne.Name = "lblInfoWheelOne"
        Me.lblInfoWheelOne.Size = New System.Drawing.Size(70, 13)
        Me.lblInfoWheelOne.TabIndex = 1
        Me.lblInfoWheelOne.Text = "Wheel One : "
        '
        'lblInfoWheelTwo
        '
        Me.lblInfoWheelTwo.AutoSize = True
        Me.lblInfoWheelTwo.Location = New System.Drawing.Point(154, 105)
        Me.lblInfoWheelTwo.Name = "lblInfoWheelTwo"
        Me.lblInfoWheelTwo.Size = New System.Drawing.Size(71, 13)
        Me.lblInfoWheelTwo.TabIndex = 2
        Me.lblInfoWheelTwo.Text = "Wheel Two : "
        '
        'lblInfoWheelThree
        '
        Me.lblInfoWheelThree.AutoSize = True
        Me.lblInfoWheelThree.Location = New System.Drawing.Point(239, 105)
        Me.lblInfoWheelThree.Name = "lblInfoWheelThree"
        Me.lblInfoWheelThree.Size = New System.Drawing.Size(78, 13)
        Me.lblInfoWheelThree.TabIndex = 3
        Me.lblInfoWheelThree.Text = "Wheel Three : "
        '
        'lblWheelOneResult
        '
        Me.lblWheelOneResult.AutoSize = True
        Me.lblWheelOneResult.Location = New System.Drawing.Point(98, 129)
        Me.lblWheelOneResult.Name = "lblWheelOneResult"
        Me.lblWheelOneResult.Size = New System.Drawing.Size(13, 13)
        Me.lblWheelOneResult.TabIndex = 4
        Me.lblWheelOneResult.Text = "?"
        '
        'lblWheelTwoResult
        '
        Me.lblWheelTwoResult.AutoSize = True
        Me.lblWheelTwoResult.Location = New System.Drawing.Point(186, 129)
        Me.lblWheelTwoResult.Name = "lblWheelTwoResult"
        Me.lblWheelTwoResult.Size = New System.Drawing.Size(13, 13)
        Me.lblWheelTwoResult.TabIndex = 5
        Me.lblWheelTwoResult.Text = "?"
        '
        'lblWheelThreeResult
        '
        Me.lblWheelThreeResult.AutoSize = True
        Me.lblWheelThreeResult.Location = New System.Drawing.Point(287, 129)
        Me.lblWheelThreeResult.Name = "lblWheelThreeResult"
        Me.lblWheelThreeResult.Size = New System.Drawing.Size(13, 13)
        Me.lblWheelThreeResult.TabIndex = 6
        Me.lblWheelThreeResult.Text = "?"
        '
        'lblInfoTokens
        '
        Me.lblInfoTokens.AutoSize = True
        Me.lblInfoTokens.Location = New System.Drawing.Point(13, 37)
        Me.lblInfoTokens.Name = "lblInfoTokens"
        Me.lblInfoTokens.Size = New System.Drawing.Size(49, 13)
        Me.lblInfoTokens.TabIndex = 7
        Me.lblInfoTokens.Text = "Tokens :"
        '
        'lblTokens
        '
        Me.lblTokens.AutoSize = True
        Me.lblTokens.Location = New System.Drawing.Point(22, 54)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(25, 13)
        Me.lblTokens.TabIndex = 8
        Me.lblTokens.Text = "100"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 352)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.lblInfoTokens)
        Me.Controls.Add(Me.lblWheelThreeResult)
        Me.Controls.Add(Me.lblWheelTwoResult)
        Me.Controls.Add(Me.lblWheelOneResult)
        Me.Controls.Add(Me.lblInfoWheelThree)
        Me.Controls.Add(Me.lblInfoWheelTwo)
        Me.Controls.Add(Me.lblInfoWheelOne)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents lblInfoWheelOne As Label
    Friend WithEvents lblInfoWheelTwo As Label
    Friend WithEvents lblInfoWheelThree As Label
    Friend WithEvents lblWheelOneResult As Label
    Friend WithEvents lblWheelTwoResult As Label
    Friend WithEvents lblWheelThreeResult As Label
    Friend WithEvents lblInfoTokens As Label
    Friend WithEvents lblTokens As Label
End Class
