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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.btnSeecode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(27, 76)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.Text = "Label1"
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(30, 12)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(75, 23)
        Me.btnEncode.TabIndex = 2
        Me.btnEncode.Text = "Encode"
        Me.btnEncode.UseVisualStyleBackColor = True
        '
        'btnSeecode
        '
        Me.btnSeecode.Location = New System.Drawing.Point(21, 41)
        Me.btnSeecode.Name = "btnSeecode"
        Me.btnSeecode.Size = New System.Drawing.Size(93, 23)
        Me.btnSeecode.TabIndex = 3
        Me.btnSeecode.Text = "See the Code"
        Me.btnSeecode.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 216)
        Me.Controls.Add(Me.btnSeecode)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEncode As Button
    Friend WithEvents btnSeecode As Button
End Class
