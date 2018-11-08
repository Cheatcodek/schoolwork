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
        Me.grpPlatform = New System.Windows.Forms.GroupBox()
        Me.radPlaystation4 = New System.Windows.Forms.RadioButton()
        Me.radXboxOne = New System.Windows.Forms.RadioButton()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.txtFirstGame = New System.Windows.Forms.TextBox()
        Me.txtSecondGame = New System.Windows.Forms.TextBox()
        Me.txtThirdGame = New System.Windows.Forms.TextBox()
        Me.picThirdGame = New System.Windows.Forms.PictureBox()
        Me.picSecondGame = New System.Windows.Forms.PictureBox()
        Me.picFirstGame = New System.Windows.Forms.PictureBox()
        Me.lblInfoPrice = New System.Windows.Forms.Label()
        Me.lblInfoRecipt = New System.Windows.Forms.Label()
        Me.lblInfoOrdered = New System.Windows.Forms.Label()
        Me.lblAmountOrdered = New System.Windows.Forms.Label()
        Me.lblInitialAmount = New System.Windows.Forms.Label()
        Me.lblInfoTax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblInfoShipping = New System.Windows.Forms.Label()
        Me.lblBoxesAmount = New System.Windows.Forms.Label()
        Me.lblShippingBoxPrice = New System.Windows.Forms.Label()
        Me.lblInfoEnvelopes = New System.Windows.Forms.Label()
        Me.lblEnvelopeAmount = New System.Windows.Forms.Label()
        Me.lblEnvelopePrice = New System.Windows.Forms.Label()
        Me.grpPlatform.SuspendLayout()
        CType(Me.picThirdGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSecondGame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFirstGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPlatform
        '
        Me.grpPlatform.Controls.Add(Me.radPlaystation4)
        Me.grpPlatform.Controls.Add(Me.radXboxOne)
        Me.grpPlatform.Location = New System.Drawing.Point(147, 31)
        Me.grpPlatform.Name = "grpPlatform"
        Me.grpPlatform.Size = New System.Drawing.Size(146, 66)
        Me.grpPlatform.TabIndex = 0
        Me.grpPlatform.TabStop = False
        Me.grpPlatform.Text = "Platform"
        '
        'radPlaystation4
        '
        Me.radPlaystation4.AutoSize = True
        Me.radPlaystation4.Location = New System.Drawing.Point(7, 43)
        Me.radPlaystation4.Name = "radPlaystation4"
        Me.radPlaystation4.Size = New System.Drawing.Size(85, 17)
        Me.radPlaystation4.TabIndex = 1
        Me.radPlaystation4.TabStop = True
        Me.radPlaystation4.Text = "Playstation 4"
        Me.radPlaystation4.UseVisualStyleBackColor = True
        '
        'radXboxOne
        '
        Me.radXboxOne.AutoSize = True
        Me.radXboxOne.Location = New System.Drawing.Point(7, 20)
        Me.radXboxOne.Name = "radXboxOne"
        Me.radXboxOne.Size = New System.Drawing.Size(72, 17)
        Me.radXboxOne.TabIndex = 0
        Me.radXboxOne.TabStop = True
        Me.radXboxOne.Text = "Xbox One"
        Me.radXboxOne.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(179, 98)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtFirstGame
        '
        Me.txtFirstGame.Location = New System.Drawing.Point(4, 140)
        Me.txtFirstGame.Name = "txtFirstGame"
        Me.txtFirstGame.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstGame.TabIndex = 2
        '
        'txtSecondGame
        '
        Me.txtSecondGame.Location = New System.Drawing.Point(170, 140)
        Me.txtSecondGame.Name = "txtSecondGame"
        Me.txtSecondGame.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondGame.TabIndex = 3
        '
        'txtThirdGame
        '
        Me.txtThirdGame.Location = New System.Drawing.Point(349, 140)
        Me.txtThirdGame.Name = "txtThirdGame"
        Me.txtThirdGame.Size = New System.Drawing.Size(100, 20)
        Me.txtThirdGame.TabIndex = 4
        '
        'picThirdGame
        '
        Me.picThirdGame.Image = Global.Hudzik15_VGO_.My.Resources.Resources.xboxGTA
        Me.picThirdGame.Location = New System.Drawing.Point(349, 186)
        Me.picThirdGame.Name = "picThirdGame"
        Me.picThirdGame.Size = New System.Drawing.Size(146, 198)
        Me.picThirdGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThirdGame.TabIndex = 7
        Me.picThirdGame.TabStop = False
        '
        'picSecondGame
        '
        Me.picSecondGame.Image = Global.Hudzik15_VGO_.My.Resources.Resources.xboxFortnite
        Me.picSecondGame.Location = New System.Drawing.Point(170, 186)
        Me.picSecondGame.Name = "picSecondGame"
        Me.picSecondGame.Size = New System.Drawing.Size(146, 198)
        Me.picSecondGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSecondGame.TabIndex = 6
        Me.picSecondGame.TabStop = False
        '
        'picFirstGame
        '
        Me.picFirstGame.Image = Global.Hudzik15_VGO_.My.Resources.Resources.xboxDestiny
        Me.picFirstGame.Location = New System.Drawing.Point(4, 186)
        Me.picFirstGame.Name = "picFirstGame"
        Me.picFirstGame.Size = New System.Drawing.Size(146, 198)
        Me.picFirstGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFirstGame.TabIndex = 5
        Me.picFirstGame.TabStop = False
        '
        'lblInfoPrice
        '
        Me.lblInfoPrice.AutoSize = True
        Me.lblInfoPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPrice.Location = New System.Drawing.Point(260, 112)
        Me.lblInfoPrice.Name = "lblInfoPrice"
        Me.lblInfoPrice.Size = New System.Drawing.Size(87, 9)
        Me.lblInfoPrice.TabIndex = 8
        Me.lblInfoPrice.Text = "*Every Game Costs $60"
        '
        'lblInfoRecipt
        '
        Me.lblInfoRecipt.AutoSize = True
        Me.lblInfoRecipt.Location = New System.Drawing.Point(514, 247)
        Me.lblInfoRecipt.Name = "lblInfoRecipt"
        Me.lblInfoRecipt.Size = New System.Drawing.Size(47, 13)
        Me.lblInfoRecipt.TabIndex = 9
        Me.lblInfoRecipt.Text = "Receipt "
        '
        'lblInfoOrdered
        '
        Me.lblInfoOrdered.AutoSize = True
        Me.lblInfoOrdered.Location = New System.Drawing.Point(501, 274)
        Me.lblInfoOrdered.Name = "lblInfoOrdered"
        Me.lblInfoOrdered.Size = New System.Drawing.Size(87, 13)
        Me.lblInfoOrdered.TabIndex = 10
        Me.lblInfoOrdered.Text = "Amount Ordered "
        '
        'lblAmountOrdered
        '
        Me.lblAmountOrdered.AutoSize = True
        Me.lblAmountOrdered.Location = New System.Drawing.Point(595, 273)
        Me.lblAmountOrdered.Name = "lblAmountOrdered"
        Me.lblAmountOrdered.Size = New System.Drawing.Size(13, 13)
        Me.lblAmountOrdered.TabIndex = 11
        Me.lblAmountOrdered.Text = "?"
        '
        'lblInitialAmount
        '
        Me.lblInitialAmount.AutoSize = True
        Me.lblInitialAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblInitialAmount.Location = New System.Drawing.Point(626, 273)
        Me.lblInitialAmount.Name = "lblInitialAmount"
        Me.lblInitialAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblInitialAmount.TabIndex = 12
        Me.lblInitialAmount.Text = "?"
        Me.lblInitialAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfoTax
        '
        Me.lblInfoTax.AutoSize = True
        Me.lblInfoTax.Location = New System.Drawing.Point(501, 288)
        Me.lblInfoTax.Name = "lblInfoTax"
        Me.lblInfoTax.Size = New System.Drawing.Size(81, 13)
        Me.lblInfoTax.TabIndex = 13
        Me.lblInfoTax.Text = "Taxed at 6.75%"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(626, 288)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(13, 13)
        Me.lblTax.TabIndex = 14
        Me.lblTax.Text = "?"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfoShipping
        '
        Me.lblInfoShipping.AutoSize = True
        Me.lblInfoShipping.Location = New System.Drawing.Point(504, 302)
        Me.lblInfoShipping.Name = "lblInfoShipping"
        Me.lblInfoShipping.Size = New System.Drawing.Size(83, 13)
        Me.lblInfoShipping.TabIndex = 15
        Me.lblInfoShipping.Text = "Shipping Boxes "
        '
        'lblBoxesAmount
        '
        Me.lblBoxesAmount.AutoSize = True
        Me.lblBoxesAmount.Location = New System.Drawing.Point(598, 302)
        Me.lblBoxesAmount.Name = "lblBoxesAmount"
        Me.lblBoxesAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblBoxesAmount.TabIndex = 16
        Me.lblBoxesAmount.Text = "?"
        '
        'lblShippingBoxPrice
        '
        Me.lblShippingBoxPrice.AutoSize = True
        Me.lblShippingBoxPrice.Location = New System.Drawing.Point(626, 302)
        Me.lblShippingBoxPrice.Name = "lblShippingBoxPrice"
        Me.lblShippingBoxPrice.Size = New System.Drawing.Size(13, 13)
        Me.lblShippingBoxPrice.TabIndex = 17
        Me.lblShippingBoxPrice.Text = "?"
        Me.lblShippingBoxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfoEnvelopes
        '
        Me.lblInfoEnvelopes.AutoSize = True
        Me.lblInfoEnvelopes.Location = New System.Drawing.Point(522, 318)
        Me.lblInfoEnvelopes.Name = "lblInfoEnvelopes"
        Me.lblInfoEnvelopes.Size = New System.Drawing.Size(57, 13)
        Me.lblInfoEnvelopes.TabIndex = 18
        Me.lblInfoEnvelopes.Text = "Envelopes"
        '
        'lblEnvelopeAmount
        '
        Me.lblEnvelopeAmount.AutoSize = True
        Me.lblEnvelopeAmount.Location = New System.Drawing.Point(598, 319)
        Me.lblEnvelopeAmount.Name = "lblEnvelopeAmount"
        Me.lblEnvelopeAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblEnvelopeAmount.TabIndex = 19
        Me.lblEnvelopeAmount.Text = "?"
        '
        'lblEnvelopePrice
        '
        Me.lblEnvelopePrice.AutoSize = True
        Me.lblEnvelopePrice.Location = New System.Drawing.Point(626, 319)
        Me.lblEnvelopePrice.Name = "lblEnvelopePrice"
        Me.lblEnvelopePrice.Size = New System.Drawing.Size(13, 13)
        Me.lblEnvelopePrice.TabIndex = 20
        Me.lblEnvelopePrice.Text = "?"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 406)
        Me.Controls.Add(Me.lblEnvelopePrice)
        Me.Controls.Add(Me.lblEnvelopeAmount)
        Me.Controls.Add(Me.lblInfoEnvelopes)
        Me.Controls.Add(Me.lblShippingBoxPrice)
        Me.Controls.Add(Me.lblBoxesAmount)
        Me.Controls.Add(Me.lblInfoShipping)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblInfoTax)
        Me.Controls.Add(Me.lblInitialAmount)
        Me.Controls.Add(Me.lblAmountOrdered)
        Me.Controls.Add(Me.lblInfoOrdered)
        Me.Controls.Add(Me.lblInfoRecipt)
        Me.Controls.Add(Me.lblInfoPrice)
        Me.Controls.Add(Me.picThirdGame)
        Me.Controls.Add(Me.picSecondGame)
        Me.Controls.Add(Me.picFirstGame)
        Me.Controls.Add(Me.txtThirdGame)
        Me.Controls.Add(Me.txtSecondGame)
        Me.Controls.Add(Me.txtFirstGame)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpPlatform)
        Me.Name = "frmMain"
        Me.Text = "Video Game Order"
        Me.grpPlatform.ResumeLayout(False)
        Me.grpPlatform.PerformLayout()
        CType(Me.picThirdGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSecondGame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFirstGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPlatform As GroupBox
    Friend WithEvents radPlaystation4 As RadioButton
    Friend WithEvents radXboxOne As RadioButton
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtFirstGame As TextBox
    Friend WithEvents txtSecondGame As TextBox
    Friend WithEvents txtThirdGame As TextBox
    Friend WithEvents picFirstGame As PictureBox
    Friend WithEvents picSecondGame As PictureBox
    Friend WithEvents picThirdGame As PictureBox
    Friend WithEvents lblInfoPrice As Label
    Friend WithEvents lblInfoRecipt As Label
    Friend WithEvents lblInfoOrdered As Label
    Friend WithEvents lblAmountOrdered As Label
    Friend WithEvents lblInitialAmount As Label
    Friend WithEvents lblInfoTax As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblInfoShipping As Label
    Friend WithEvents lblBoxesAmount As Label
    Friend WithEvents lblShippingBoxPrice As Label
    Friend WithEvents lblInfoEnvelopes As Label
    Friend WithEvents lblEnvelopeAmount As Label
    Friend WithEvents lblEnvelopePrice As Label
End Class
