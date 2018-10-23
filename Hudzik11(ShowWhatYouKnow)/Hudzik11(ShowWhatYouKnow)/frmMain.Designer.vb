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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.grpBoxofLabalChanging = New System.Windows.Forms.GroupBox()
        Me.radTwo = New System.Windows.Forms.RadioButton()
        Me.radOne = New System.Windows.Forms.RadioButton()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenuLabelThings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDoLabelThings = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.lblTEXTBOX = New System.Windows.Forms.Label()
        Me.grpBoxofLabalChanging.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(3, 28)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(110, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Label that shows stuff"
        '
        'grpBoxofLabalChanging
        '
        Me.grpBoxofLabalChanging.Controls.Add(Me.radTwo)
        Me.grpBoxofLabalChanging.Controls.Add(Me.radOne)
        Me.grpBoxofLabalChanging.Location = New System.Drawing.Point(189, 31)
        Me.grpBoxofLabalChanging.Name = "grpBoxofLabalChanging"
        Me.grpBoxofLabalChanging.Size = New System.Drawing.Size(173, 55)
        Me.grpBoxofLabalChanging.TabIndex = 1
        Me.grpBoxofLabalChanging.TabStop = False
        Me.grpBoxofLabalChanging.Text = "Box that groups"
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Location = New System.Drawing.Point(90, 20)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(77, 17)
        Me.radTwo.TabIndex = 1
        Me.radTwo.Text = "Radio Two"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Checked = True
        Me.radOne.Location = New System.Drawing.Point(7, 20)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(76, 17)
        Me.radOne.TabIndex = 0
        Me.radOne.TabStop = True
        Me.radOne.Text = "Radio One"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(17, 62)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(75, 23)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "BUTTON"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMenuLabelThings})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(374, 24)
        Me.mnuMain.TabIndex = 3
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuMenuLabelThings
        '
        Me.mnuMenuLabelThings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDoLabelThings})
        Me.mnuMenuLabelThings.Name = "mnuMenuLabelThings"
        Me.mnuMenuLabelThings.Size = New System.Drawing.Size(120, 20)
        Me.mnuMenuLabelThings.Text = "Menu Label Things"
        '
        'mnuDoLabelThings
        '
        Me.mnuDoLabelThings.Name = "mnuDoLabelThings"
        Me.mnuDoLabelThings.Size = New System.Drawing.Size(180, 22)
        Me.mnuDoLabelThings.Text = "Do Label Things"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 88)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtTextBox
        '
        Me.txtTextBox.Location = New System.Drawing.Point(189, 93)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.txtTextBox.TabIndex = 5
        '
        'lblTEXTBOX
        '
        Me.lblTEXTBOX.AutoSize = True
        Me.lblTEXTBOX.Location = New System.Drawing.Point(159, 116)
        Me.lblTEXTBOX.Name = "lblTEXTBOX"
        Me.lblTEXTBOX.Size = New System.Drawing.Size(175, 13)
        Me.lblTEXTBOX.TabIndex = 6
        Me.lblTEXTBOX.Text = "HEY THERE'S NO TEXT IN HERE"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 333)
        Me.Controls.Add(Me.lblTEXTBOX)
        Me.Controls.Add(Me.txtTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.grpBoxofLabalChanging)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpBoxofLabalChanging.ResumeLayout(False)
        Me.grpBoxofLabalChanging.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents grpBoxofLabalChanging As GroupBox
    Friend WithEvents radTwo As RadioButton
    Friend WithEvents radOne As RadioButton
    Friend WithEvents btnThree As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuMenuLabelThings As ToolStripMenuItem
    Friend WithEvents mnuDoLabelThings As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTextBox As TextBox
    Friend WithEvents lblTEXTBOX As Label
End Class
