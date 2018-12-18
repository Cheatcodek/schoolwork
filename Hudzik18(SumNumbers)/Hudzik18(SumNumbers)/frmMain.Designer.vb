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
        Me.txtStarting = New System.Windows.Forms.TextBox()
        Me.txtEnding = New System.Windows.Forms.TextBox()
        Me.lblInfoStarting = New System.Windows.Forms.Label()
        Me.lblInfoEnding = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStarting
        '
        Me.txtStarting.Location = New System.Drawing.Point(121, 29)
        Me.txtStarting.Name = "txtStarting"
        Me.txtStarting.Size = New System.Drawing.Size(100, 20)
        Me.txtStarting.TabIndex = 0
        '
        'txtEnding
        '
        Me.txtEnding.Location = New System.Drawing.Point(121, 71)
        Me.txtEnding.Name = "txtEnding"
        Me.txtEnding.Size = New System.Drawing.Size(100, 20)
        Me.txtEnding.TabIndex = 1
        '
        'lblInfoStarting
        '
        Me.lblInfoStarting.AutoSize = True
        Me.lblInfoStarting.Location = New System.Drawing.Point(26, 35)
        Me.lblInfoStarting.Name = "lblInfoStarting"
        Me.lblInfoStarting.Size = New System.Drawing.Size(92, 13)
        Me.lblInfoStarting.TabIndex = 2
        Me.lblInfoStarting.Text = "Starting Number : "
        '
        'lblInfoEnding
        '
        Me.lblInfoEnding.AutoSize = True
        Me.lblInfoEnding.Location = New System.Drawing.Point(26, 71)
        Me.lblInfoEnding.Name = "lblInfoEnding"
        Me.lblInfoEnding.Size = New System.Drawing.Size(89, 13)
        Me.lblInfoEnding.TabIndex = 3
        Me.lblInfoEnding.Text = "Ending Number : "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(90, 152)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(67, 118)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 202)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInfoEnding)
        Me.Controls.Add(Me.lblInfoStarting)
        Me.Controls.Add(Me.txtEnding)
        Me.Controls.Add(Me.txtStarting)
        Me.Name = "frmMain"
        Me.Text = "Sum Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStarting As TextBox
    Friend WithEvents txtEnding As TextBox
    Friend WithEvents lblInfoStarting As Label
    Friend WithEvents lblInfoEnding As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResult As Label
End Class
