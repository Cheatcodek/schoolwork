Public Class frmMain


    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click

        Dim dictDice As New Dictionary(Of Integer, Integer)
        Dim objRandom As New Random
        Static intPoints As Integer = 1000
        Dim intCombined As Integer
        Dim intWager As Integer = Val(txtWager.Text)

        If intWager > intPoints Then
            MessageBox.Show("Your wager is too high!!")
            Exit Sub
        End If

        For i As Integer = 1 To 2
            dictDice.Add(i, objRandom.Next(1, 7))
        Next

        intCombined = dictDice(1) + dictDice(2)

#Region "picture box"
        Select Case dictDice(1)
            Case 1
                picDie1.Image = My.Resources.die1
            Case 2
                picDie1.Image = My.Resources.die2
            Case 3
                picDie1.Image = My.Resources.die3
            Case 4
                picDie1.Image = My.Resources.die4
            Case 5
                picDie1.Image = My.Resources.die5
            Case 6
                picDie1.Image = My.Resources.die6
        End Select

        Select Case dictDice(2)
            Case 1
                picDie2.Image = My.Resources.die1
            Case 2
                picDie2.Image = My.Resources.die2
            Case 3
                picDie2.Image = My.Resources.die3
            Case 4
                picDie2.Image = My.Resources.die4
            Case 5
                picDie2.Image = My.Resources.die5
            Case 6
                picDie2.Image = My.Resources.die6
        End Select
#End Region

        If intCombined Mod 2 <> 0 Then

            MessageBox.Show("You have Win!!")
            intPoints += intWager * 2
        Else

            MessageBox.Show("You have Loss!!")
            intPoints -= intWager
        End If

        lblPoints.Text = "Points : " & intPoints

    End Sub


End Class
