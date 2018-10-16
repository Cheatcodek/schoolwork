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
        Me.lblInfoEarnedPoints = New System.Windows.Forms.Label()
        Me.txtTotalPoints = New System.Windows.Forms.TextBox()
        Me.txtMaxPoints = New System.Windows.Forms.TextBox()
        Me.lblInfoMaximumPoints = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblInfoPercentage = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblPassing = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfoEarnedPoints
        '
        Me.lblInfoEarnedPoints.AutoSize = True
        Me.lblInfoEarnedPoints.Location = New System.Drawing.Point(34, 50)
        Me.lblInfoEarnedPoints.Name = "lblInfoEarnedPoints"
        Me.lblInfoEarnedPoints.Size = New System.Drawing.Size(122, 13)
        Me.lblInfoEarnedPoints.TabIndex = 0
        Me.lblInfoEarnedPoints.Text = "Enter your earned points"
        '
        'txtTotalPoints
        '
        Me.txtTotalPoints.Location = New System.Drawing.Point(162, 47)
        Me.txtTotalPoints.Name = "txtTotalPoints"
        Me.txtTotalPoints.Size = New System.Drawing.Size(54, 20)
        Me.txtTotalPoints.TabIndex = 1
        '
        'txtMaxPoints
        '
        Me.txtMaxPoints.Location = New System.Drawing.Point(162, 82)
        Me.txtMaxPoints.Name = "txtMaxPoints"
        Me.txtMaxPoints.Size = New System.Drawing.Size(54, 20)
        Me.txtMaxPoints.TabIndex = 2
        '
        'lblInfoMaximumPoints
        '
        Me.lblInfoMaximumPoints.AutoSize = True
        Me.lblInfoMaximumPoints.Location = New System.Drawing.Point(3, 85)
        Me.lblInfoMaximumPoints.Name = "lblInfoMaximumPoints"
        Me.lblInfoMaximumPoints.Size = New System.Drawing.Size(153, 13)
        Me.lblInfoMaximumPoints.TabIndex = 3
        Me.lblInfoMaximumPoints.Text = "Enter Maximum Possible Points"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(162, 122)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblInfoPercentage
        '
        Me.lblInfoPercentage.AutoSize = True
        Me.lblInfoPercentage.Location = New System.Drawing.Point(12, 177)
        Me.lblInfoPercentage.Name = "lblInfoPercentage"
        Me.lblInfoPercentage.Size = New System.Drawing.Size(68, 13)
        Me.lblInfoPercentage.TabIndex = 5
        Me.lblInfoPercentage.Text = "Percentage :"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(62, 200)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(13, 13)
        Me.lblPercentage.TabIndex = 6
        Me.lblPercentage.Text = "?"
        '
        'lblPassing
        '
        Me.lblPassing.AutoSize = True
        Me.lblPassing.Location = New System.Drawing.Point(127, 250)
        Me.lblPassing.Name = "lblPassing"
        Me.lblPassing.Size = New System.Drawing.Size(0, 13)
        Me.lblPassing.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 277)
        Me.Controls.Add(Me.lblPassing)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblInfoPercentage)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInfoMaximumPoints)
        Me.Controls.Add(Me.txtMaxPoints)
        Me.Controls.Add(Me.txtTotalPoints)
        Me.Controls.Add(Me.lblInfoEarnedPoints)
        Me.Name = "frmMain"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoEarnedPoints As Label
    Friend WithEvents txtTotalPoints As TextBox
    Friend WithEvents txtMaxPoints As TextBox
    Friend WithEvents lblInfoMaximumPoints As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblInfoPercentage As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblPassing As Label
End Class
