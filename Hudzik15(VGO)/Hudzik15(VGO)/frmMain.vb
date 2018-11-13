Public Class frmMain



    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Dim intFirstGameAmount As Integer = System.Math.Abs(Val(txtFirstGame.Text))
        Dim intSecondGameAmout As Integer = System.Math.Abs(Val(txtSecondGame.Text)) 'Initializes variables and sets them as the absolute value of them, because someones gonna be weird enough to put a negative number in there
        Dim intThirdGameAmount As Integer = System.Math.Abs(Val(txtThirdGame.Text))

        Dim intTotalOrdered As Integer = intFirstGameAmount + intSecondGameAmout + intThirdGameAmount
        Dim decIntitialPrice As Decimal = intTotalOrdered * 59.99
        Dim decAmountTaxed As Decimal = Math.Round((decIntitialPrice * 0.0675), 2, MidpointRounding.AwayFromZero)

        Dim intBoxesShipped As Integer
        Dim intEnvelopesShipped As Integer
        Dim decEnvelopePrice As Decimal 'Boxes doesn't need to be changed here as it is the same price as amount used



        lblAmountOrdered.Text = intTotalOrdered
        lblInitialAmount.Text = "$" & decIntitialPrice
        lblTax.Text = "$" & decAmountTaxed

        intBoxesShipped = intTotalOrdered \ 3
        intEnvelopesShipped = intTotalOrdered Mod 3
        decEnvelopePrice = intEnvelopesShipped * 0.5

        lblBoxesAmount.Text = intBoxesShipped
        lblEnvelopeAmount.Text = intEnvelopesShipped
        lblShippingBoxPrice.Text = "$" & intBoxesShipped
        lblEnvelopePrice.Text = "$" & decEnvelopePrice


    End Sub


#Region "Game Change"
    Private Sub radXboxOne_CheckedChanged(sender As Object, e As EventArgs) Handles radXboxOne.Click

        picFirstGame.Image = My.Resources.xboxDestiny
        picSecondGame.Image = My.Resources.xboxFortnite
        picThirdGame.Image = My.Resources.xboxGTA
    End Sub

    Private Sub radPlaystation4_CheckedChanged(sender As Object, e As EventArgs) Handles radPlaystation4.Click

        picFirstGame.Image = My.Resources.ps4Destiny
        picSecondGame.Image = My.Resources.ps4Fortnite
        picThirdGame.Image = My.Resources.ps4GTA
    End Sub


#End Region

End Class
