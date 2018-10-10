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
        Me.components = New System.ComponentModel.Container()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnWorker = New System.Windows.Forms.Button()
        Me.lblWorker = New System.Windows.Forms.Label()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.lblNameValue = New System.Windows.Forms.Label()
        Me.lblNameWorker = New System.Windows.Forms.Label()
        Me.tmrWorker = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfoWorker = New System.Windows.Forms.Label()
        Me.btnFactory = New System.Windows.Forms.Button()
        Me.lblInfoFactory = New System.Windows.Forms.Label()
        Me.tmrFactory = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAgency = New System.Windows.Forms.Timer(Me.components)
        Me.btnAgency = New System.Windows.Forms.Button()
        Me.lblInfoAgency = New System.Windows.Forms.Label()
        Me.lblInfoAgencies = New System.Windows.Forms.Label()
        Me.lblAgencies = New System.Windows.Forms.Label()
        Me.lblInfoFactories = New System.Windows.Forms.Label()
        Me.lblFactories = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpgrades = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpWorker = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpWorkerBTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnValue
        '
        Me.btnValue.Location = New System.Drawing.Point(13, 224)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(86, 23)
        Me.btnValue.TabIndex = 0
        Me.btnValue.Text = "Create Value"
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(61, 28)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(13, 13)
        Me.lblValue.TabIndex = 1
        Me.lblValue.Text = "0"
        '
        'btnWorker
        '
        Me.btnWorker.Location = New System.Drawing.Point(13, 254)
        Me.btnWorker.Name = "btnWorker"
        Me.btnWorker.Size = New System.Drawing.Size(86, 23)
        Me.btnWorker.TabIndex = 2
        Me.btnWorker.Text = "Buy Worker"
        Me.btnWorker.UseVisualStyleBackColor = True
        '
        'lblWorker
        '
        Me.lblWorker.AutoSize = True
        Me.lblWorker.Location = New System.Drawing.Point(61, 51)
        Me.lblWorker.Name = "lblWorker"
        Me.lblWorker.Size = New System.Drawing.Size(13, 13)
        Me.lblWorker.TabIndex = 3
        Me.lblWorker.Text = "0"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 10
        '
        'lblNameValue
        '
        Me.lblNameValue.AutoSize = True
        Me.lblNameValue.Location = New System.Drawing.Point(12, 28)
        Me.lblNameValue.Name = "lblNameValue"
        Me.lblNameValue.Size = New System.Drawing.Size(43, 13)
        Me.lblNameValue.TabIndex = 4
        Me.lblNameValue.Text = "Value : "
        '
        'lblNameWorker
        '
        Me.lblNameWorker.AutoSize = True
        Me.lblNameWorker.Location = New System.Drawing.Point(7, 51)
        Me.lblNameWorker.Name = "lblNameWorker"
        Me.lblNameWorker.Size = New System.Drawing.Size(48, 13)
        Me.lblNameWorker.TabIndex = 5
        Me.lblNameWorker.Text = "Worker :"
        '
        'tmrWorker
        '
        Me.tmrWorker.Interval = 1000
        '
        'lblInfoWorker
        '
        Me.lblInfoWorker.AutoSize = True
        Me.lblInfoWorker.Location = New System.Drawing.Point(105, 259)
        Me.lblInfoWorker.Name = "lblInfoWorker"
        Me.lblInfoWorker.Size = New System.Drawing.Size(48, 13)
        Me.lblInfoWorker.TabIndex = 6
        Me.lblInfoWorker.Text = "Costs 10"
        '
        'btnFactory
        '
        Me.btnFactory.Location = New System.Drawing.Point(13, 283)
        Me.btnFactory.Name = "btnFactory"
        Me.btnFactory.Size = New System.Drawing.Size(86, 23)
        Me.btnFactory.TabIndex = 7
        Me.btnFactory.Text = "Buy Factory"
        Me.btnFactory.UseVisualStyleBackColor = True
        Me.btnFactory.Visible = False
        '
        'lblInfoFactory
        '
        Me.lblInfoFactory.AutoSize = True
        Me.lblInfoFactory.Location = New System.Drawing.Point(106, 293)
        Me.lblInfoFactory.Name = "lblInfoFactory"
        Me.lblInfoFactory.Size = New System.Drawing.Size(54, 13)
        Me.lblInfoFactory.TabIndex = 8
        Me.lblInfoFactory.Text = "Costs 100"
        Me.lblInfoFactory.Visible = False
        '
        'tmrFactory
        '
        Me.tmrFactory.Interval = 500
        '
        'tmrAgency
        '
        Me.tmrAgency.Interval = 10000
        '
        'btnAgency
        '
        Me.btnAgency.Location = New System.Drawing.Point(159, 224)
        Me.btnAgency.Name = "btnAgency"
        Me.btnAgency.Size = New System.Drawing.Size(96, 36)
        Me.btnAgency.TabIndex = 9
        Me.btnAgency.Text = "Buy Recruitment Agency"
        Me.btnAgency.UseVisualStyleBackColor = True
        '
        'lblInfoAgency
        '
        Me.lblInfoAgency.AutoSize = True
        Me.lblInfoAgency.Location = New System.Drawing.Point(262, 246)
        Me.lblInfoAgency.Name = "lblInfoAgency"
        Me.lblInfoAgency.Size = New System.Drawing.Size(54, 13)
        Me.lblInfoAgency.TabIndex = 10
        Me.lblInfoAgency.Text = "Costs 300"
        '
        'lblInfoAgencies
        '
        Me.lblInfoAgencies.AutoSize = True
        Me.lblInfoAgencies.Location = New System.Drawing.Point(-1, 68)
        Me.lblInfoAgencies.Name = "lblInfoAgencies"
        Me.lblInfoAgencies.Size = New System.Drawing.Size(60, 13)
        Me.lblInfoAgencies.TabIndex = 11
        Me.lblInfoAgencies.Text = "Agencies : "
        '
        'lblAgencies
        '
        Me.lblAgencies.AutoSize = True
        Me.lblAgencies.Location = New System.Drawing.Point(61, 68)
        Me.lblAgencies.Name = "lblAgencies"
        Me.lblAgencies.Size = New System.Drawing.Size(13, 13)
        Me.lblAgencies.TabIndex = 12
        Me.lblAgencies.Text = "0"
        '
        'lblInfoFactories
        '
        Me.lblInfoFactories.AutoSize = True
        Me.lblInfoFactories.Location = New System.Drawing.Point(156, 28)
        Me.lblInfoFactories.Name = "lblInfoFactories"
        Me.lblInfoFactories.Size = New System.Drawing.Size(59, 13)
        Me.lblInfoFactories.TabIndex = 13
        Me.lblInfoFactories.Text = "Factories : "
        Me.lblInfoFactories.Visible = False
        '
        'lblFactories
        '
        Me.lblFactories.AutoSize = True
        Me.lblFactories.Location = New System.Drawing.Point(217, 28)
        Me.lblFactories.Name = "lblFactories"
        Me.lblFactories.Size = New System.Drawing.Size(13, 13)
        Me.lblFactories.TabIndex = 14
        Me.lblFactories.Text = "0"
        Me.lblFactories.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuUpgrades})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(316, 24)
        Me.mnuMain.TabIndex = 15
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuUpgrades
        '
        Me.mnuUpgrades.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpWorker})
        Me.mnuUpgrades.Name = "mnuUpgrades"
        Me.mnuUpgrades.Size = New System.Drawing.Size(69, 20)
        Me.mnuUpgrades.Text = "Upgrades"
        '
        'mnuUpWorker
        '
        Me.mnuUpWorker.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpWorkerBTools})
        Me.mnuUpWorker.Name = "mnuUpWorker"
        Me.mnuUpWorker.Size = New System.Drawing.Size(180, 22)
        Me.mnuUpWorker.Text = "Worker"
        '
        'mnuUpWorkerBTools
        '
        Me.mnuUpWorkerBTools.Name = "mnuUpWorkerBTools"
        Me.mnuUpWorkerBTools.Size = New System.Drawing.Size(180, 22)
        Me.mnuUpWorkerBTools.Text = "Basic Tools (150)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 317)
        Me.Controls.Add(Me.lblFactories)
        Me.Controls.Add(Me.lblInfoFactories)
        Me.Controls.Add(Me.lblAgencies)
        Me.Controls.Add(Me.lblInfoAgencies)
        Me.Controls.Add(Me.lblInfoAgency)
        Me.Controls.Add(Me.btnAgency)
        Me.Controls.Add(Me.lblInfoFactory)
        Me.Controls.Add(Me.btnFactory)
        Me.Controls.Add(Me.lblInfoWorker)
        Me.Controls.Add(Me.lblNameWorker)
        Me.Controls.Add(Me.lblNameValue)
        Me.Controls.Add(Me.lblWorker)
        Me.Controls.Add(Me.btnWorker)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Click Thing"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValue As Button
    Friend WithEvents lblValue As Label
    Friend WithEvents btnWorker As Button
    Friend WithEvents lblWorker As Label
    Friend WithEvents lblNameValue As Label
    Friend WithEvents lblNameWorker As Label
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents tmrWorker As Timer
    Friend WithEvents lblInfoWorker As Label
    Friend WithEvents btnFactory As Button
    Friend WithEvents lblInfoFactory As Label
    Friend WithEvents tmrFactory As Timer
    Friend WithEvents tmrAgency As Timer
    Friend WithEvents btnAgency As Button
    Friend WithEvents lblInfoAgency As Label
    Friend WithEvents lblInfoAgencies As Label
    Friend WithEvents lblAgencies As Label
    Friend WithEvents lblInfoFactories As Label
    Friend WithEvents lblFactories As Label
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuUpgrades As ToolStripMenuItem
    Friend WithEvents mnuUpWorker As ToolStripMenuItem
    Friend WithEvents mnuUpWorkerBTools As ToolStripMenuItem
End Class
