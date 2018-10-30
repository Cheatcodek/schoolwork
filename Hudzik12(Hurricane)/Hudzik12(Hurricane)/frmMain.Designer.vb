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
        Me.txtMPH = New System.Windows.Forms.TextBox()
        Me.lblInfoTextbox = New System.Windows.Forms.Label()
        Me.btnCalculation = New System.Windows.Forms.Button()
        Me.chkRandom = New System.Windows.Forms.CheckBox()
        Me.lblInfoName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblInfoIsHurricane = New System.Windows.Forms.Label()
        Me.lblIsHurricane = New System.Windows.Forms.Label()
        Me.lblInfoOnScale = New System.Windows.Forms.Label()
        Me.lblOnScale = New System.Windows.Forms.Label()
        Me.lblInfoDamage = New System.Windows.Forms.Label()
        Me.lblDamage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMPH
        '
        Me.txtMPH.Location = New System.Drawing.Point(12, 50)
        Me.txtMPH.Name = "txtMPH"
        Me.txtMPH.Size = New System.Drawing.Size(100, 20)
        Me.txtMPH.TabIndex = 0
        '
        'lblInfoTextbox
        '
        Me.lblInfoTextbox.AutoSize = True
        Me.lblInfoTextbox.Location = New System.Drawing.Point(13, 31)
        Me.lblInfoTextbox.Name = "lblInfoTextbox"
        Me.lblInfoTextbox.Size = New System.Drawing.Size(85, 13)
        Me.lblInfoTextbox.TabIndex = 1
        Me.lblInfoTextbox.Text = "Enter MPH Here"
        '
        'btnCalculation
        '
        Me.btnCalculation.Location = New System.Drawing.Point(16, 99)
        Me.btnCalculation.Name = "btnCalculation"
        Me.btnCalculation.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculation.TabIndex = 2
        Me.btnCalculation.Text = "Calculate"
        Me.btnCalculation.UseVisualStyleBackColor = True
        '
        'chkRandom
        '
        Me.chkRandom.AutoSize = True
        Me.chkRandom.Location = New System.Drawing.Point(17, 128)
        Me.chkRandom.Name = "chkRandom"
        Me.chkRandom.Size = New System.Drawing.Size(115, 17)
        Me.chkRandom.TabIndex = 3
        Me.chkRandom.Text = "Random Hurricane"
        Me.chkRandom.UseVisualStyleBackColor = True
        '
        'lblInfoName
        '
        Me.lblInfoName.AutoSize = True
        Me.lblInfoName.Location = New System.Drawing.Point(12, 163)
        Me.lblInfoName.Name = "lblInfoName"
        Me.lblInfoName.Size = New System.Drawing.Size(108, 13)
        Me.lblInfoName.TabIndex = 4
        Me.lblInfoName.Text = "First Letter of Name : "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(125, 164)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(13, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "?"
        '
        'lblInfoIsHurricane
        '
        Me.lblInfoIsHurricane.AutoSize = True
        Me.lblInfoIsHurricane.Location = New System.Drawing.Point(96, 9)
        Me.lblInfoIsHurricane.Name = "lblInfoIsHurricane"
        Me.lblInfoIsHurricane.Size = New System.Drawing.Size(99, 13)
        Me.lblInfoIsHurricane.TabIndex = 6
        Me.lblInfoIsHurricane.Text = "Is it a Hurricane?  : "
        '
        'lblIsHurricane
        '
        Me.lblIsHurricane.AutoSize = True
        Me.lblIsHurricane.Location = New System.Drawing.Point(191, 11)
        Me.lblIsHurricane.Name = "lblIsHurricane"
        Me.lblIsHurricane.Size = New System.Drawing.Size(13, 13)
        Me.lblIsHurricane.TabIndex = 7
        Me.lblIsHurricane.Text = "?"
        '
        'lblInfoOnScale
        '
        Me.lblInfoOnScale.AutoSize = True
        Me.lblInfoOnScale.Location = New System.Drawing.Point(102, 31)
        Me.lblInfoOnScale.Name = "lblInfoOnScale"
        Me.lblInfoOnScale.Size = New System.Drawing.Size(93, 13)
        Me.lblInfoOnScale.TabIndex = 8
        Me.lblInfoOnScale.Text = "What Catagory? : "
        '
        'lblOnScale
        '
        Me.lblOnScale.AutoSize = True
        Me.lblOnScale.Location = New System.Drawing.Point(192, 33)
        Me.lblOnScale.Name = "lblOnScale"
        Me.lblOnScale.Size = New System.Drawing.Size(13, 13)
        Me.lblOnScale.TabIndex = 9
        Me.lblOnScale.Text = "?"
        '
        'lblInfoDamage
        '
        Me.lblInfoDamage.AutoSize = True
        Me.lblInfoDamage.Location = New System.Drawing.Point(132, 53)
        Me.lblInfoDamage.Name = "lblInfoDamage"
        Me.lblInfoDamage.Size = New System.Drawing.Size(59, 13)
        Me.lblInfoDamage.TabIndex = 10
        Me.lblInfoDamage.Text = "Damage? :"
        '
        'lblDamage
        '
        Me.lblDamage.AutoSize = True
        Me.lblDamage.Location = New System.Drawing.Point(192, 54)
        Me.lblDamage.Name = "lblDamage"
        Me.lblDamage.Size = New System.Drawing.Size(13, 13)
        Me.lblDamage.TabIndex = 11
        Me.lblDamage.Text = "?"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculation
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 188)
        Me.Controls.Add(Me.lblDamage)
        Me.Controls.Add(Me.lblInfoDamage)
        Me.Controls.Add(Me.lblOnScale)
        Me.Controls.Add(Me.lblInfoOnScale)
        Me.Controls.Add(Me.lblIsHurricane)
        Me.Controls.Add(Me.lblInfoIsHurricane)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblInfoName)
        Me.Controls.Add(Me.chkRandom)
        Me.Controls.Add(Me.btnCalculation)
        Me.Controls.Add(Me.lblInfoTextbox)
        Me.Controls.Add(Me.txtMPH)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMPH As TextBox
    Friend WithEvents lblInfoTextbox As Label
    Friend WithEvents btnCalculation As Button
    Friend WithEvents chkRandom As CheckBox
    Friend WithEvents lblInfoName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblInfoIsHurricane As Label
    Friend WithEvents lblIsHurricane As Label
    Friend WithEvents lblInfoOnScale As Label
    Friend WithEvents lblOnScale As Label
    Friend WithEvents lblInfoDamage As Label
    Friend WithEvents lblDamage As Label
End Class
