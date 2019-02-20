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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblStatistics = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 101)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(86, 23)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter Scores"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(13, 131)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(85, 23)
        Me.btnStatistics.TabIndex = 1
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = True
        Me.lblStatistics.Location = New System.Drawing.Point(13, 32)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(0, 13)
        Me.lblStatistics.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 170)
        Me.Controls.Add(Me.lblStatistics)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "frmMain"
        Me.Text = "Bowling Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblStatistics As Label
End Class
