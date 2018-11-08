Public Class frmMain



    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        Dim intFirstGameAmount As Integer = Val(txtFirstGame)
        Dim intSecondGameAmout As Integer = Val(txtSecondGame) 'Initializes variables and sets them
        Dim intThirdGameAmount As Integer = Val(txtThirdGame)




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
