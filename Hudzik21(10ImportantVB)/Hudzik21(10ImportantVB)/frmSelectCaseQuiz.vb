Public Class frmSelectCaseQuiz
    'Quick note about the form, Normally you should have radio buttons in group boxes, this is not done in this as it is unneeded
    Dim objRandom As New Random
    Dim intQuestion As Integer = objRandom.Next(1, 5)
    Private Sub frmSelectCaseQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case intQuestion
            Case 1 'Han vs Greedo question
                lblQuestion.Text = "In Star Wars Episode 4, Who Shot first?"
                radFirstAns.Text = "Hans"
                radSecondAns.Text = "Greedo"
                radThirdAns.Text = "Someone elsewhere"
                radFourthAns.Text = "This question is ultimately pointless"

            Case 2 'Jojo question
                lblQuestion.Text = "What is the name of Jotaro Kujo's stand?"
                radFirstAns.Text = "Stone Free Reqiuem"
                radSecondAns.Text = "Golden Tusk Act 4"
                radThirdAns.Text = "Star Platinum"
                radFourthAns.Text = "The Chariot Over Heaven"

            Case 3 'ES3 question
                lblQuestion.Text = "What is the hero in The Elder Scrolls Three Morrowind called?"
                radFirstAns.Text = "The Nerevarine"
                radSecondAns.Text = "The Dragonborn"
                radThirdAns.Text = "The Hero of Kvatch"
                radFourthAns.Text = "The Grand Champion"

            Case 4 'Computer question
                lblQuestion.Text = "What does CPU stand for?"
                radFirstAns.Text = "Communist Propaganda Unleashed"
                radSecondAns.Text = "Central Proccessing Unit"
                radThirdAns.Text = "Carnival Pentagon Unknown"
                radFourthAns.Text = "Critical Pique Unequal"

        End Select



    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If intQuestion = 1 And radFourthAns.Checked Then
            MessageBox.Show("Correct!")
        ElseIf intQuestion = 2 And radThirdAns.Checked = True Then
            MessageBox.Show("Correct!")
        ElseIf intQuestion = 3 And radFirstAns.Checked = True Then
            MessageBox.Show("Correct!")
        ElseIf intQuestion = 4 And radSecondAns.Checked = True Then
            MessageBox.Show("Correct!")
        Else
            MessageBox.Show("Incorrect!")
        End If

        Application.Exit()

    End Sub

End Class