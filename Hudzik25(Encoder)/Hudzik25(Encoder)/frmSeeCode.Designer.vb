<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeeCode
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(13, 40)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(31, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "hecc"
        '
        'frmSeeCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 283)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "frmSeeCode"
        Me.Text = "frmSeeCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
End Class
