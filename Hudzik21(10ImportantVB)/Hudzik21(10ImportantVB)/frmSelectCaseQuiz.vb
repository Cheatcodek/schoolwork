Public Class frmSelectCaseQuiz
    'Quick note about the form, Normally you should have radio buttons in group boxes, this is not done in this as it is unneeded
    Private Sub frmSelectCaseQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objRandom As New Random
        Dim intQuestion As Integer = objRandom.Next(1, 5)

        Select Case intQuestion
            Case 1 'Han vs Greedo question
                lblQuestion.Text = "In Star Wars Episode 4, Who Shot first?"
                radFirstAns.Text = "Hans"
                radSecondAns.Text = "Greedo"
                radThirdAns.Text = "Someone elsewhere"
                radFourthAns.Text = "This question is ultimately pointless"

            Case 2 'Jojo question
                lblQuestion.Text = "What is the name of Jotaro Kujo's Stand?"
                radFirstAns.Text = "Soft Spice Diamond"
                radSecondAns.Text = "Golden Tusk"
                radThirdAns.Text = "Star Platinum"
                radFourthAns.Text = "The Chariot Over Requiem"

            Case 3 'ESIII question
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
End Class