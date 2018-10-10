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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCelsius = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFahrenheit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.lblInfoTemperature = New System.Windows.Forms.Label()
        Me.lblInfoFinalTemp = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.btnFtC = New System.Windows.Forms.Button()
        Me.btnCtF = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(274, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCelsius, Me.mnuFahrenheit, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuCelsius
        '
        Me.mnuCelsius.Name = "mnuCelsius"
        Me.mnuCelsius.Size = New System.Drawing.Size(193, 22)
        Me.mnuCelsius.Text = "Celsius Conversion"
        '
        'mnuFahrenheit
        '
        Me.mnuFahrenheit.Name = "mnuFahrenheit"
        Me.mnuFahrenheit.Size = New System.Drawing.Size(193, 22)
        Me.mnuFahrenheit.Text = "Fahrenheit Conversion"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(193, 22)
        Me.mnuExit.Text = "Exit"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(12, 55)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp.TabIndex = 1
        '
        'lblInfoTemperature
        '
        Me.lblInfoTemperature.AutoSize = True
        Me.lblInfoTemperature.Location = New System.Drawing.Point(12, 36)
        Me.lblInfoTemperature.Name = "lblInfoTemperature"
        Me.lblInfoTemperature.Size = New System.Drawing.Size(113, 13)
        Me.lblInfoTemperature.TabIndex = 2
        Me.lblInfoTemperature.Text = "Enter the Temperature"
        '
        'lblInfoFinalTemp
        '
        Me.lblInfoFinalTemp.AutoSize = True
        Me.lblInfoFinalTemp.Location = New System.Drawing.Point(12, 114)
        Me.lblInfoFinalTemp.Name = "lblInfoFinalTemp"
        Me.lblInfoFinalTemp.Size = New System.Drawing.Size(104, 13)
        Me.lblInfoFinalTemp.TabIndex = 3
        Me.lblInfoFinalTemp.Text = "The temperature is : "
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(12, 127)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(13, 13)
        Me.lblTemp.TabIndex = 4
        Me.lblTemp.Text = "?"
        '
        'btnFtC
        '
        Me.btnFtC.Location = New System.Drawing.Point(15, 156)
        Me.btnFtC.Name = "btnFtC"
        Me.btnFtC.Size = New System.Drawing.Size(75, 23)
        Me.btnFtC.TabIndex = 5
        Me.btnFtC.Text = "F to C"
        Me.btnFtC.UseVisualStyleBackColor = True
        '
        'btnCtF
        '
        Me.btnCtF.Location = New System.Drawing.Point(15, 185)
        Me.btnCtF.Name = "btnCtF"
        Me.btnCtF.Size = New System.Drawing.Size(75, 23)
        Me.btnCtF.TabIndex = 6
        Me.btnCtF.Text = "C to F"
        Me.btnCtF.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 230)
        Me.Controls.Add(Me.btnCtF)
        Me.Controls.Add(Me.btnFtC)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblInfoFinalTemp)
        Me.Controls.Add(Me.lblInfoTemperature)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuCelsius As ToolStripMenuItem
    Friend WithEvents mnuFahrenheit As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents lblInfoTemperature As Label
    Friend WithEvents lblInfoFinalTemp As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents btnFtC As Button
    Friend WithEvents btnCtF As Button
End Class
