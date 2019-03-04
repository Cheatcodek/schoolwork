Public Class frmMain

    Dim intGamesPlayed As Integer = 0
    Dim intGamesWon As Integer = 0
    Dim bolGamePlayed = False

    'Creative addition, Resets the game when the user wishes to
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click, MyBase.Load

        picPearl1.Image = Nothing
        picPearl2.Image = Nothing
        picPearl3.Image = Nothing

        bolGamePlayed = False

    End Sub

    Private Sub picShell_Click(sender As Object, e As EventArgs) Handles picShell1.Click, picShell2.Click, picShell3.Click

        Dim objRandom As New Random
        Dim picSelectedShell As PictureBox = sender
        Dim intWinner As Integer = objRandom.Next(1, 4)

        'Only let this pass if the player has reset the game
        If bolGamePlayed = True Then
            MessageBox.Show("Restart the game!!" & vbNewLine & "Click Play Again!!")
            Exit Sub
        Else
            bolGamePlayed = True
        End If
        'If the user has selected the correct answer, say that they have won. Otherwise say they have failed. In either case, display the correct pearl
        If picSelectedShell.Tag = intWinner Then

            Select Case picSelectedShell.Tag
                Case Val(1)
                    picPearl1.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
                Case Val(2)
                    picPearl2.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
                Case Val(3)
                    picPearl3.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
            End Select

        Else
            Select Case intWinner
                Case Val(1)
                    picPearl1.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
                Case Val(2)
                    picPearl2.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
                Case Val(3)
                    picPearl3.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
            End Select
        End If

        'Counters for games played and displaying games played and won
        intGamesPlayed += 1
        lblGamesPlayed.Text = "Games Played : " & intGamesPlayed
        lblGamesWon.Text = "Games Won : " & intGamesWon

    End Sub

    Private Sub mnuShell_Click(sender As Object, e As EventArgs) Handles mnuShellShell1.Click, mnuShellShell2.Click, mnuShellShell3.Click

        Dim objRandom As New Random
        Dim mnuSelectedShell As ToolStripMenuItem = sender
        Dim intWinner As Integer = objRandom.Next(1, 4)

        'See comments on the picturebox handler for details
        If bolGamePlayed = True Then
            MessageBox.Show("Restart the game!!" & vbNewLine & "Click Play Again!!")
            Exit Sub
        Else
            bolGamePlayed = True
        End If

        If mnuSelectedShell.Tag = intWinner Then

            Select Case mnuSelectedShell.Tag
                Case Val(1)
                    picPearl1.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
                Case Val(2)
                    picPearl2.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
                Case Val(3)
                    picPearl3.Image = My.Resources.Pearl
                    MessageBox.Show("You are Winner!!")
                    intGamesWon += 1
            End Select

        Else
            Select Case intWinner
                Case Val(1)
                    picPearl1.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
                Case Val(2)
                    picPearl2.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
                Case Val(3)
                    picPearl3.Image = My.Resources.Pearl
                    MessageBox.Show("You have Fail!!")
            End Select
        End If


        intGamesPlayed += 1
        lblGamesPlayed.Text = "Games Played : " & intGamesPlayed
        lblGamesWon.Text = "Games Won : " & intGamesWon

    End Sub


    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub


End Class
