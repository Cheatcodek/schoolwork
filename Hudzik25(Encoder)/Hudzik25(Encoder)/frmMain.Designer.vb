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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.btnSeecode = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsEncode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptionsSeecode = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.lblDecode = New System.Windows.Forms.Label()
        Me.mnuOptionsDecode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(21, 40)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(75, 23)
        Me.btnEncode.TabIndex = 2
        Me.btnEncode.Text = "Encode"
        Me.btnEncode.UseVisualStyleBackColor = True
        '
        'btnSeecode
        '
        Me.btnSeecode.Enabled = False
        Me.btnSeecode.Location = New System.Drawing.Point(12, 69)
        Me.btnSeecode.Name = "btnSeecode"
        Me.btnSeecode.Size = New System.Drawing.Size(93, 23)
        Me.btnSeecode.TabIndex = 3
        Me.btnSeecode.Text = "See the Code"
        Me.btnSeecode.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOptions})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(304, 24)
        Me.mnuMain.TabIndex = 4
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOptionsEncode, Me.mnuOptionsSeecode, Me.mnuOptionsDecode})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(61, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuOptionsEncode
        '
        Me.mnuOptionsEncode.Name = "mnuOptionsEncode"
        Me.mnuOptionsEncode.Size = New System.Drawing.Size(180, 22)
        Me.mnuOptionsEncode.Text = "Encode"
        '
        'mnuOptionsSeecode
        '
        Me.mnuOptionsSeecode.Enabled = False
        Me.mnuOptionsSeecode.Name = "mnuOptionsSeecode"
        Me.mnuOptionsSeecode.Size = New System.Drawing.Size(180, 22)
        Me.mnuOptionsSeecode.Text = "See Code"
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(21, 99)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 5
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'lblDecode
        '
        Me.lblDecode.AutoSize = True
        Me.lblDecode.Location = New System.Drawing.Point(12, 129)
        Me.lblDecode.Name = "lblDecode"
        Me.lblDecode.Size = New System.Drawing.Size(0, 13)
        Me.lblDecode.TabIndex = 6
        '
        'mnuOptionsDecode
        '
        Me.mnuOptionsDecode.Name = "mnuOptionsDecode"
        Me.mnuOptionsDecode.Size = New System.Drawing.Size(180, 22)
        Me.mnuOptionsDecode.Text = "Decode"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 216)
        Me.Controls.Add(Me.lblDecode)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.btnSeecode)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Secret Code"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncode As Button
    Friend WithEvents btnSeecode As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuOptionsEncode As ToolStripMenuItem
    Friend WithEvents mnuOptionsSeecode As ToolStripMenuItem
    Friend WithEvents btnDecode As Button
    Friend WithEvents lblDecode As Label
    Friend WithEvents mnuOptionsDecode As ToolStripMenuItem
End Class
