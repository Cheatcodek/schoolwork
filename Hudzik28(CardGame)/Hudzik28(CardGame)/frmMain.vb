Public Class frmMain



    'Initialize Dictionary of Integer and Integer
    Dim diiPlayerCards As New Dictionary(Of Integer, Integer)
    Dim diiCompCards As New Dictionary(Of Integer, Integer)
    'Boolean for if the third is revealed
    Dim bolThirdRevealed As Boolean
    Dim intWager As Integer
    Dim intPoints As Integer = 100
    Dim bolGamestart As Boolean


    Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click, mnuGameDeal.Click

        If bolGamestart Then
            MessageBox.Show("You can't quite now!!" & vbNewLine & "You've already started")
            Exit Sub
        End If

        Call Reset()
        Call Deal()
        Call ImageSet()
        bolGamestart = True

        While diiCompCards(1) + diiCompCards(2) + diiCompCards(3) >= 21
            'Prevents the computer from instantly losing
            Call Deal()
            Call ImageSet()
            bolGamestart = True
        End While


    End Sub


    Private Sub btnWager_Click(sender As Object, e As EventArgs) Handles btnWager.Click, mnuGameWager.Click
        'Creative additon, wagering can be done
        intWager = Val(InputBox("Wager amount"))
        lblWager.Text = "Current Wager : " & intWager


    End Sub

    Private Sub picUser3_Click(sender As Object, e As EventArgs) Handles picUser3.Click, mnuGameHit.Click

        Dim intPlayerTotal As Integer = diiPlayerCards(1) + diiPlayerCards(2) + diiPlayerCards(3)
        Dim intCompTotal As Integer = diiCompCards(1) + diiCompCards(2) + diiCompCards(3)

        If Not bolGamestart Then
            Exit Sub
        End If

        Select Case diiPlayerCards(3)
            Case 1
                picUser3.Image = My.Resources.card1
            Case 2
                picUser3.Image = My.Resources.card2
            Case 3
                picUser3.Image = My.Resources.card3
            Case 4
                picUser3.Image = My.Resources.card4
            Case 5
                picUser3.Image = My.Resources.card5
            Case 6
                picUser3.Image = My.Resources.card6
            Case 7
                picUser3.Image = My.Resources.card7
            Case 8
                picUser3.Image = My.Resources.card8
            Case 9
                picUser3.Image = My.Resources.card9
            Case 10
                picUser3.Image = My.Resources.card10
        End Select

        If intPlayerTotal <= 21 And intPlayerTotal > intCompTotal Then
            Call Victory()
        Else
            Call Defeat()
        End If

    End Sub

    Private Sub btnStand_Click(sender As Object, e As EventArgs) Handles btnStand.Click, mnuGameStand.Click
        Dim intPlayerTotal As Integer = diiPlayerCards(1) + diiPlayerCards(2)
        Dim intCompTotal As Integer = diiCompCards(1) + diiCompCards(2) + diiCompCards(3)

        If Not bolGamestart Then
            Exit Sub
        End If

        If intPlayerTotal < 21 And intPlayerTotal > intCompTotal Then
            Call Victory()
        Else
            Call Defeat()
        End If

    End Sub

    Sub ImageSet()
        'Assumes the dictionary values have already been set
        Select Case diiPlayerCards(1)
            Case 1
                picUser1.Image = My.Resources.card1
            Case 2
                picUser1.Image = My.Resources.card2
            Case 3
                picUser1.Image = My.Resources.card3
            Case 4
                picUser1.Image = My.Resources.card4
            Case 5
                picUser1.Image = My.Resources.card5
            Case 6
                picUser1.Image = My.Resources.card6
            Case 7
                picUser1.Image = My.Resources.card7
            Case 8
                picUser1.Image = My.Resources.card8
            Case 9
                picUser1.Image = My.Resources.card9
            Case 10
                picUser1.Image = My.Resources.card10
        End Select

        Select Case diiPlayerCards(2)
            Case 1
                picUser2.Image = My.Resources.card1
            Case 2
                picUser2.Image = My.Resources.card2
            Case 3
                picUser2.Image = My.Resources.card3
            Case 4
                picUser2.Image = My.Resources.card4
            Case 5
                picUser2.Image = My.Resources.card5
            Case 6
                picUser2.Image = My.Resources.card6
            Case 7
                picUser2.Image = My.Resources.card7
            Case 8
                picUser2.Image = My.Resources.card8
            Case 9
                picUser2.Image = My.Resources.card9
            Case 10
                picUser2.Image = My.Resources.card10
        End Select

        If bolThirdRevealed Then
            Select Case diiPlayerCards(3)
                Case 1
                    picUser3.Image = My.Resources.card1
                Case 2
                    picUser3.Image = My.Resources.card2
                Case 3
                    picUser3.Image = My.Resources.card3
                Case 4
                    picUser3.Image = My.Resources.card4
                Case 5
                    picUser3.Image = My.Resources.card5
                Case 6
                    picUser3.Image = My.Resources.card6
                Case 7
                    picUser3.Image = My.Resources.card7
                Case 8
                    picUser3.Image = My.Resources.card8
                Case 9
                    picUser3.Image = My.Resources.card9
                Case 10
                    picUser3.Image = My.Resources.card10
            End Select
        Else
            picUser3.Image = My.Resources.cardback
        End If

        Select Case diiCompCards(1)
            Case 1
                picComp1.Image = My.Resources.card1
            Case 2
                picComp1.Image = My.Resources.card2
            Case 3
                picComp1.Image = My.Resources.card3
            Case 4
                picComp1.Image = My.Resources.card4
            Case 5
                picComp1.Image = My.Resources.card5
            Case 6
                picComp1.Image = My.Resources.card6
            Case 7
                picComp1.Image = My.Resources.card7
            Case 8
                picComp1.Image = My.Resources.card8
            Case 9
                picComp1.Image = My.Resources.card9
            Case 10
                picComp1.Image = My.Resources.card10
        End Select

        Select Case diiCompCards(2)
            Case 1
                picComp2.Image = My.Resources.card1
            Case 2
                picComp2.Image = My.Resources.card2
            Case 3
                picComp2.Image = My.Resources.card3
            Case 4
                picComp2.Image = My.Resources.card4
            Case 5
                picComp2.Image = My.Resources.card5
            Case 6
                picComp2.Image = My.Resources.card6
            Case 7
                picComp2.Image = My.Resources.card7
            Case 8
                picComp2.Image = My.Resources.card8
            Case 9
                picComp2.Image = My.Resources.card9
            Case 10
                picComp2.Image = My.Resources.card10
        End Select

        Select Case diiCompCards(3)
            Case 1
                picComp3.Image = My.Resources.card1
            Case 2
                picComp3.Image = My.Resources.card2
            Case 3
                picComp3.Image = My.Resources.card3
            Case 4
                picComp3.Image = My.Resources.card4
            Case 5
                picComp3.Image = My.Resources.card5
            Case 6
                picComp3.Image = My.Resources.card6
            Case 7
                picComp3.Image = My.Resources.card7
            Case 8
                picComp3.Image = My.Resources.card8
            Case 9
                picComp3.Image = My.Resources.card9
            Case 10
                picComp3.Image = My.Resources.card10
        End Select

    End Sub

    Sub Deal()

        bolThirdRevealed = False
        'Removes the value of the dictionaries
        For i As Integer = 1 To 3
            diiPlayerCards.Remove(i)
        Next
        'Sets the value of the dictionaries
        For i As Integer = 1 To 3
            diiPlayerCards.Add(i, Rand(1, 10))
        Next

        For i As Integer = 1 To 3
            diiCompCards.Remove(i)
        Next
        For i As Integer = 1 To 3
            diiCompCards.Add(i, Rand(1, 10))
        Next

    End Sub

    Function Rand(ByVal intLow, ByVal intHigh) As Integer
        Static objRandom As New Random
        Return objRandom.Next(intLow, intHigh + 1)
    End Function

    Sub Victory()
        MessageBox.Show("VICTORY HATH BEEN ACHIEVED")
        intPoints += intWager * 2
        lblPoints.Text = "Current Points : " & intPoints
        intWager = 0
        lblWager.Text = "Current Wager : " & intWager
    End Sub

    Sub Defeat()
        MessageBox.Show("WE HAVE BEEN ROUTED" & vbNewLine & "DEFEAT IS INEVITABLE")
        intPoints -= intWager
        lblPoints.Text = "Current Points : " & intPoints
        intWager = 0
        lblWager.Text = "Current Wager : " & intWager
    End Sub

    Sub Reset()

        For i As Integer = 1 To 3
            diiPlayerCards.Remove(i)
            diiCompCards.Remove(i)
        Next
        bolThirdRevealed = False
        bolGamestart = False

    End Sub

    Private Sub mnuFileRules_Click(sender As Object, e As EventArgs) Handles mnuFileRules.Click
        MessageBox.Show("This is the game of blackjack" & vbNewLine & "To win, you must get a higher total then the dealer" & vbNewLine & "However, you musn't go over 21")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGameReset.Click
        Call Reset()
    End Sub
End Class
