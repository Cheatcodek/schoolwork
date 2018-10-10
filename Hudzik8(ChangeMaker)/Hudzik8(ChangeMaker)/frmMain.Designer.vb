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
        Me.mnuGetChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.lblInfoQuarter = New System.Windows.Forms.Label()
        Me.lblInfoDime = New System.Windows.Forms.Label()
        Me.lblInfoPenny = New System.Windows.Forms.Label()
        Me.lblInfoNickel = New System.Windows.Forms.Label()
        Me.lblPenny = New System.Windows.Forms.Label()
        Me.lblNickel = New System.Windows.Forms.Label()
        Me.lblDime = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInfoMain = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(265, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGetChange, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuGetChange
        '
        Me.mnuGetChange.Name = "mnuGetChange"
        Me.mnuGetChange.Size = New System.Drawing.Size(180, 22)
        Me.mnuGetChange.Text = "Get Change"
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(153, 39)
        Me.txtMain.MaxLength = 2
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(100, 20)
        Me.txtMain.TabIndex = 1
        Me.txtMain.Text = "Put Amount in Here"
        '
        'lblInfoQuarter
        '
        Me.lblInfoQuarter.AutoSize = True
        Me.lblInfoQuarter.Location = New System.Drawing.Point(12, 73)
        Me.lblInfoQuarter.Name = "lblInfoQuarter"
        Me.lblInfoQuarter.Size = New System.Drawing.Size(56, 13)
        Me.lblInfoQuarter.TabIndex = 2
        Me.lblInfoQuarter.Text = "Quarters : "
        '
        'lblInfoDime
        '
        Me.lblInfoDime.AutoSize = True
        Me.lblInfoDime.Location = New System.Drawing.Point(12, 95)
        Me.lblInfoDime.Name = "lblInfoDime"
        Me.lblInfoDime.Size = New System.Drawing.Size(42, 13)
        Me.lblInfoDime.TabIndex = 3
        Me.lblInfoDime.Text = "Dimes :"
        '
        'lblInfoPenny
        '
        Me.lblInfoPenny.AutoSize = True
        Me.lblInfoPenny.Location = New System.Drawing.Point(12, 140)
        Me.lblInfoPenny.Name = "lblInfoPenny"
        Me.lblInfoPenny.Size = New System.Drawing.Size(54, 13)
        Me.lblInfoPenny.TabIndex = 5
        Me.lblInfoPenny.Text = "Pennies : "
        '
        'lblInfoNickel
        '
        Me.lblInfoNickel.AutoSize = True
        Me.lblInfoNickel.Location = New System.Drawing.Point(12, 118)
        Me.lblInfoNickel.Name = "lblInfoNickel"
        Me.lblInfoNickel.Size = New System.Drawing.Size(51, 13)
        Me.lblInfoNickel.TabIndex = 4
        Me.lblInfoNickel.Text = "Nickels : "
        '
        'lblPenny
        '
        Me.lblPenny.AutoSize = True
        Me.lblPenny.Location = New System.Drawing.Point(66, 140)
        Me.lblPenny.Name = "lblPenny"
        Me.lblPenny.Size = New System.Drawing.Size(45, 13)
        Me.lblPenny.TabIndex = 9
        Me.lblPenny.Text = "Textbox"
        '
        'lblNickel
        '
        Me.lblNickel.AutoSize = True
        Me.lblNickel.Location = New System.Drawing.Point(66, 118)
        Me.lblNickel.Name = "lblNickel"
        Me.lblNickel.Size = New System.Drawing.Size(25, 13)
        Me.lblNickel.TabIndex = 8
        Me.lblNickel.Text = "Into"
        '
        'lblDime
        '
        Me.lblDime.AutoSize = True
        Me.lblDime.Location = New System.Drawing.Point(66, 95)
        Me.lblDime.Name = "lblDime"
        Me.lblDime.Size = New System.Drawing.Size(44, 13)
        Me.lblDime.TabIndex = 7
        Me.lblDime.Text = "Change"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(66, 73)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(33, 13)
        Me.lblQuarter.TabIndex = 6
        Me.lblQuarter.Text = "Insert"
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(153, 66)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 10
        Me.btnAnswer.Text = "Get Change"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblInfoMain
        '
        Me.lblInfoMain.AutoSize = True
        Me.lblInfoMain.Location = New System.Drawing.Point(156, 24)
        Me.lblInfoMain.Name = "lblInfoMain"
        Me.lblInfoMain.Size = New System.Drawing.Size(74, 13)
        Me.lblInfoMain.TabIndex = 11
        Me.lblInfoMain.Text = "Goes up to 99"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 214)
        Me.Controls.Add(Me.lblInfoMain)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.lblPenny)
        Me.Controls.Add(Me.lblNickel)
        Me.Controls.Add(Me.lblDime)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.lblInfoPenny)
        Me.Controls.Add(Me.lblInfoNickel)
        Me.Controls.Add(Me.lblInfoDime)
        Me.Controls.Add(Me.lblInfoQuarter)
        Me.Controls.Add(Me.txtMain)
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
    Friend WithEvents txtMain As TextBox
    Friend WithEvents lblInfoQuarter As Label
    Friend WithEvents lblInfoDime As Label
    Friend WithEvents lblInfoPenny As Label
    Friend WithEvents lblInfoNickel As Label
    Friend WithEvents lblPenny As Label
    Friend WithEvents lblNickel As Label
    Friend WithEvents lblDime As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents mnuGetChange As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblInfoMain As Label
End Class
