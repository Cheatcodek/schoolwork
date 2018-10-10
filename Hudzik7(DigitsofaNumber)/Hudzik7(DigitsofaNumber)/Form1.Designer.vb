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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInfoNumber = New System.Windows.Forms.Label()
        Me.lblInfoFirst = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstDigit = New System.Windows.Forms.Label()
        Me.lblSecondDigit = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(288, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(288, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip2"
        '
        'mnuFileToolStripMenuItem
        '
        Me.mnuFileToolStripMenuItem.Name = "mnuFileToolStripMenuItem"
        Me.mnuFileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.mnuFileToolStripMenuItem.Text = "File"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(137, 59)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblInfoNumber
        '
        Me.lblInfoNumber.AutoSize = True
        Me.lblInfoNumber.Location = New System.Drawing.Point(19, 62)
        Me.lblInfoNumber.Name = "lblInfoNumber"
        Me.lblInfoNumber.Size = New System.Drawing.Size(112, 13)
        Me.lblInfoNumber.TabIndex = 3
        Me.lblInfoNumber.Text = "Enter two digit number"
        '
        'lblInfoFirst
        '
        Me.lblInfoFirst.AutoSize = True
        Me.lblInfoFirst.Location = New System.Drawing.Point(41, 121)
        Me.lblInfoFirst.Name = "lblInfoFirst"
        Me.lblInfoFirst.Size = New System.Drawing.Size(83, 13)
        Me.lblInfoFirst.TabIndex = 4
        Me.lblInfoFirst.Text = "The first digit is :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The second digit is : "
        '
        'lblFirstDigit
        '
        Me.lblFirstDigit.AutoSize = True
        Me.lblFirstDigit.Location = New System.Drawing.Point(131, 121)
        Me.lblFirstDigit.Name = "lblFirstDigit"
        Me.lblFirstDigit.Size = New System.Drawing.Size(13, 13)
        Me.lblFirstDigit.TabIndex = 6
        Me.lblFirstDigit.Text = "?"
        '
        'lblSecondDigit
        '
        Me.lblSecondDigit.AutoSize = True
        Me.lblSecondDigit.Location = New System.Drawing.Point(130, 134)
        Me.lblSecondDigit.Name = "lblSecondDigit"
        Me.lblSecondDigit.Size = New System.Drawing.Size(13, 13)
        Me.lblSecondDigit.TabIndex = 7
        Me.lblSecondDigit.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 220)
        Me.Controls.Add(Me.lblSecondDigit)
        Me.Controls.Add(Me.lblFirstDigit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfoFirst)
        Me.Controls.Add(Me.lblInfoNumber)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInfoNumber As Label
    Friend WithEvents lblInfoFirst As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstDigit As Label
    Friend WithEvents lblSecondDigit As Label
End Class
