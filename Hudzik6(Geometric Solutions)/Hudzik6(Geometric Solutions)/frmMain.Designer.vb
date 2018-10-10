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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnswer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblInfoLength = New System.Windows.Forms.Label()
        Me.lblInfoWidth = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblInfoArea = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblInfoHex = New System.Windows.Forms.Label()
        Me.lblHexAnswer = New System.Windows.Forms.Label()
        Me.lblHexArea = New System.Windows.Forms.Label()
        Me.btnHexCalculate = New System.Windows.Forms.Button()
        Me.lblInfoHexSide = New System.Windows.Forms.Label()
        Me.lblInfoRectPerimeter = New System.Windows.Forms.Label()
        Me.lblRectPerimeter = New System.Windows.Forms.Label()
        Me.txtHexLength = New System.Windows.Forms.TextBox()
        Me.lblInfoHexPerimeter = New System.Windows.Forms.Label()
        Me.lblHexPerimeter = New System.Windows.Forms.Label()
        Me.picRectangle = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuMain.SuspendLayout()
        CType(Me.picRectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(543, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAnswer, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuAnswer
        '
        Me.mnuAnswer.Name = "mnuAnswer"
        Me.mnuAnswer.Size = New System.Drawing.Size(180, 22)
        Me.mnuAnswer.Text = "Answer"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(45, 51)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 2
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(197, 51)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 3
        '
        'lblInfoLength
        '
        Me.lblInfoLength.AutoSize = True
        Me.lblInfoLength.Location = New System.Drawing.Point(0, 54)
        Me.lblInfoLength.Name = "lblInfoLength"
        Me.lblInfoLength.Size = New System.Drawing.Size(40, 13)
        Me.lblInfoLength.TabIndex = 4
        Me.lblInfoLength.Text = "Length"
        '
        'lblInfoWidth
        '
        Me.lblInfoWidth.AutoSize = True
        Me.lblInfoWidth.Location = New System.Drawing.Point(152, 55)
        Me.lblInfoWidth.Name = "lblInfoWidth"
        Me.lblInfoWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblInfoWidth.TabIndex = 5
        Me.lblInfoWidth.Text = "Width"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(21, 90)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblInfoArea
        '
        Me.lblInfoArea.AutoSize = True
        Me.lblInfoArea.Location = New System.Drawing.Point(12, 129)
        Me.lblInfoArea.Name = "lblInfoArea"
        Me.lblInfoArea.Size = New System.Drawing.Size(41, 13)
        Me.lblInfoArea.TabIndex = 7
        Me.lblInfoArea.Text = "Area = "
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(60, 129)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(13, 13)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "?"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShape.Location = New System.Drawing.Point(21, 28)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(63, 15)
        Me.lblShape.TabIndex = 9
        Me.lblShape.Text = "Rectangle"
        '
        'lblInfoHex
        '
        Me.lblInfoHex.AutoSize = True
        Me.lblInfoHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoHex.Location = New System.Drawing.Point(32, 180)
        Me.lblInfoHex.Name = "lblInfoHex"
        Me.lblInfoHex.Size = New System.Drawing.Size(57, 15)
        Me.lblInfoHex.TabIndex = 17
        Me.lblInfoHex.Text = "Hexagon"
        '
        'lblHexAnswer
        '
        Me.lblHexAnswer.AutoSize = True
        Me.lblHexAnswer.Location = New System.Drawing.Point(69, 276)
        Me.lblHexAnswer.Name = "lblHexAnswer"
        Me.lblHexAnswer.Size = New System.Drawing.Size(13, 13)
        Me.lblHexAnswer.TabIndex = 16
        Me.lblHexAnswer.Text = "?"
        '
        'lblHexArea
        '
        Me.lblHexArea.AutoSize = True
        Me.lblHexArea.Location = New System.Drawing.Point(21, 276)
        Me.lblHexArea.Name = "lblHexArea"
        Me.lblHexArea.Size = New System.Drawing.Size(41, 13)
        Me.lblHexArea.TabIndex = 15
        Me.lblHexArea.Text = "Area = "
        '
        'btnHexCalculate
        '
        Me.btnHexCalculate.Location = New System.Drawing.Point(30, 237)
        Me.btnHexCalculate.Name = "btnHexCalculate"
        Me.btnHexCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnHexCalculate.TabIndex = 14
        Me.btnHexCalculate.Text = "Calculate"
        Me.btnHexCalculate.UseVisualStyleBackColor = True
        '
        'lblInfoHexSide
        '
        Me.lblInfoHexSide.AutoSize = True
        Me.lblInfoHexSide.Location = New System.Drawing.Point(9, 201)
        Me.lblInfoHexSide.Name = "lblInfoHexSide"
        Me.lblInfoHexSide.Size = New System.Drawing.Size(64, 13)
        Me.lblInfoHexSide.TabIndex = 12
        Me.lblInfoHexSide.Text = "Side Length"
        '
        'lblInfoRectPerimeter
        '
        Me.lblInfoRectPerimeter.AutoSize = True
        Me.lblInfoRectPerimeter.Location = New System.Drawing.Point(12, 146)
        Me.lblInfoRectPerimeter.Name = "lblInfoRectPerimeter"
        Me.lblInfoRectPerimeter.Size = New System.Drawing.Size(63, 13)
        Me.lblInfoRectPerimeter.TabIndex = 18
        Me.lblInfoRectPerimeter.Text = "Perimeter = "
        '
        'lblRectPerimeter
        '
        Me.lblRectPerimeter.AutoSize = True
        Me.lblRectPerimeter.Location = New System.Drawing.Point(69, 146)
        Me.lblRectPerimeter.Name = "lblRectPerimeter"
        Me.lblRectPerimeter.Size = New System.Drawing.Size(13, 13)
        Me.lblRectPerimeter.TabIndex = 19
        Me.lblRectPerimeter.Text = "?"
        '
        'txtHexLength
        '
        Me.txtHexLength.Location = New System.Drawing.Point(79, 198)
        Me.txtHexLength.Name = "txtHexLength"
        Me.txtHexLength.Size = New System.Drawing.Size(100, 20)
        Me.txtHexLength.TabIndex = 10
        '
        'lblInfoHexPerimeter
        '
        Me.lblInfoHexPerimeter.AutoSize = True
        Me.lblInfoHexPerimeter.Location = New System.Drawing.Point(21, 307)
        Me.lblInfoHexPerimeter.Name = "lblInfoHexPerimeter"
        Me.lblInfoHexPerimeter.Size = New System.Drawing.Size(63, 13)
        Me.lblInfoHexPerimeter.TabIndex = 20
        Me.lblInfoHexPerimeter.Text = "Perimeter = "
        '
        'lblHexPerimeter
        '
        Me.lblHexPerimeter.AutoSize = True
        Me.lblHexPerimeter.Location = New System.Drawing.Point(91, 307)
        Me.lblHexPerimeter.Name = "lblHexPerimeter"
        Me.lblHexPerimeter.Size = New System.Drawing.Size(13, 13)
        Me.lblHexPerimeter.TabIndex = 21
        Me.lblHexPerimeter.Text = "?"
        '
        'picRectangle
        '
        Me.picRectangle.ErrorImage = Nothing
        Me.picRectangle.Image = CType(resources.GetObject("picRectangle.Image"), System.Drawing.Image)
        Me.picRectangle.InitialImage = CType(resources.GetObject("picRectangle.InitialImage"), System.Drawing.Image)
        Me.picRectangle.Location = New System.Drawing.Point(303, 28)
        Me.picRectangle.Name = "picRectangle"
        Me.picRectangle.Size = New System.Drawing.Size(230, 144)
        Me.picRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRectangle.TabIndex = 22
        Me.picRectangle.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hudzik6_Geometric_Solutions_.My.Resources.Resources.hexagon
        Me.PictureBox1.Location = New System.Drawing.Point(303, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 350)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picRectangle)
        Me.Controls.Add(Me.lblHexPerimeter)
        Me.Controls.Add(Me.lblInfoHexPerimeter)
        Me.Controls.Add(Me.lblRectPerimeter)
        Me.Controls.Add(Me.lblInfoRectPerimeter)
        Me.Controls.Add(Me.lblInfoHex)
        Me.Controls.Add(Me.lblHexAnswer)
        Me.Controls.Add(Me.lblHexArea)
        Me.Controls.Add(Me.btnHexCalculate)
        Me.Controls.Add(Me.lblInfoHexSide)
        Me.Controls.Add(Me.txtHexLength)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblInfoArea)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInfoWidth)
        Me.Controls.Add(Me.lblInfoLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.picRectangle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuAnswer As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblInfoLength As Label
    Friend WithEvents lblInfoWidth As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblInfoArea As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblShape As Label
    Friend WithEvents lblInfoHex As Label
    Friend WithEvents lblHexAnswer As Label
    Friend WithEvents lblHexArea As Label
    Friend WithEvents btnHexCalculate As Button
    Friend WithEvents lblInfoHexSide As Label
    Friend WithEvents lblInfoRectPerimeter As Label
    Friend WithEvents lblRectPerimeter As Label
    Friend WithEvents txtHexLength As TextBox
    Friend WithEvents lblInfoHexPerimeter As Label
    Friend WithEvents lblHexPerimeter As Label
    Friend WithEvents picRectangle As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
