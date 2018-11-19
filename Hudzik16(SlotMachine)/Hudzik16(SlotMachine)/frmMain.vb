Public Class frmMain


    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        Static intTokens As Integer = 100
        Dim objRandom As New Random

        Dim intWheelOneResult As Integer
        Dim intWheelTwoResult As Integer
        Dim intWheelThreeResult As Integer

        intWheelOneResult = objRandom.Next(1, 4)
        intWheelTwoResult = objRandom.Next(1, 4)
        intWheelThreeResult = objRandom.Next(1, 4)

        If intWheelOneResult = 1 & intWheelTwoResult = 1 & intWheelThreeResult = 1 Then

            MessageBox.Show("Jackpot! 5 Tokens!")
            intTokens += 5
        End If

        If intWheelOneResult = 2 & intWheelTwoResult = 2 & intWheelThreeResult = 2 Then

            MessageBox.Show("Jackpot! 10 Tokens!")
            intTokens += 10
        End If

        If intWheelOneResult = 3 & intWheelTwoResult = 3 & intWheelThreeResult = 3 Then

            MessageBox.Show("Jackpot! 15 Tokens!")
            intTokens += 15
        End If

        lblTokens.Text = intTokens
        lblWheelOneResult.Text = intWheelOneResult
        lblWheelTwoResult.Text = intWheelTwoResult
        lblWheelThreeResult.Text = intWheelThreeResult


    End Sub



End Class
