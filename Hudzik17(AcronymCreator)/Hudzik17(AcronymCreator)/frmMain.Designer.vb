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
        Me.lblInfoAcro = New System.Windows.Forms.Label()
        Me.lblAcronym = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfoAcro
        '
        Me.lblInfoAcro.AutoSize = True
        Me.lblInfoAcro.Location = New System.Drawing.Point(77, 49)
        Me.lblInfoAcro.Name = "lblInfoAcro"
        Me.lblInfoAcro.Size = New System.Drawing.Size(92, 13)
        Me.lblInfoAcro.TabIndex = 0
        Me.lblInfoAcro.Text = "Your Acronym is : "
        '
        'lblAcronym
        '
        Me.lblAcronym.AutoSize = True
        Me.lblAcronym.Location = New System.Drawing.Point(78, 71)
        Me.lblAcronym.Name = "lblAcronym"
        Me.lblAcronym.Size = New System.Drawing.Size(0, 13)
        Me.lblAcronym.TabIndex = 1
        Me.lblAcronym.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 157)
        Me.Controls.Add(Me.lblAcronym)
        Me.Controls.Add(Me.lblInfoAcro)
        Me.Name = "frmMain"
        Me.Text = "Acronym Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoAcro As Label
    Friend WithEvents lblAcronym As Label
End Class
