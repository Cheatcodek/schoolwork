Public Class Form1 'Algorithm Step 1
#Region "Credits"
    'Credits go to news.uci.edu, Bramble Berry, and Golden Openings
    'https://news.uci.edu/wp-content/uploads/2015/08/20271160225_bd77c6fb52_o.jpg
    'https://productimages.brambleberry.com/2014_Product/Miscellaneous/WaterSolublePaper_WSP_Main_A.jpg
    'https://goldenopenings.com/assets/images/12InchChromeLarge.jpg

#End Region

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim intUserSelection As Integer
        Dim intCompSelection As Integer
        Static intUserWins As Integer = 0
        Static intCompWins As Integer = 0 ' Initializes Variables (Algorithm step 2 & 3)
        Static intGamesPlayed As Integer = 0

        Dim bolUserWins As Boolean
        Dim bolTie As Boolean
        Dim objRandom As New Random

        intGamesPlayed += 1

        Select Case True ' Gets variables based on radio selection ( Algorithm step 4)
            Case radRock.Checked
                intUserSelection = 1
            Case radPaper.Checked
                intUserSelection = 2
            Case radScissors.Checked
                intUserSelection = 3
            Case Else
                MsgBox("You Need to select something!!") 'In case the user somehow manages to select nothing
        End Select

        intCompSelection = objRandom.Next(1, 4)

        Select Case intCompSelection 'Figures out what the computer has
            Case 1
                lblComputerSelection.Text = "Rock!"
                picCompSelection.Image = My.Resources.rok
            Case 2
                lblComputerSelection.Text = "Paper!"
                picCompSelection.Image = My.Resources.pape
            Case 3
                lblComputerSelection.Text = "Scissors!"
                picCompSelection.Image = My.Resources.scissr
        End Select


        'This giant block is used to figure out who won (Algorithm step 5)
        If intUserSelection = 1 Then ' Rock
            Select Case intCompSelection
                Case 1 'Rock
                    lblVictoryWho.Text = "Neither Wins!"
                    bolTie = True
                Case 2 'Paper
                    lblVictoryWho.Text = "---->"
                    bolUserWins = False
                Case 3 'Scissors
                    lblVictoryWho.Text = "<----"
                    bolUserWins = True
            End Select
            lblUserSelection.Text = "Rock!"
            picUserSelection.Image = My.Resources.rok
        ElseIf intUserSelection = 2 Then ' Paper
            Select Case intCompSelection
                Case 1 'Rock
                    lblVictoryWho.Text = "<----"
                    bolUserWins = True
                Case 2 'Paper
                    lblVictoryWho.Text = "Neither Wins!"
                    bolTie = True
                Case 3 'Scissors
                    lblVictoryWho.Text = "---->"
                    bolUserWins = False
            End Select
            lblUserSelection.Text = "Paper!"
            picUserSelection.Image = My.Resources.pape
        ElseIf intUserSelection = 3 Then 'Scissors
            Select Case intCompSelection
                Case 1 ' Rock
                    lblVictoryWho.Text = "---->"
                    bolUserWins = False
                Case 2 ' Paper
                    lblVictoryWho.Text = "<----"
                    bolUserWins = True
                Case 3
                    lblVictoryWho.Text = "Neither Wins!"
                    bolTie = True
            End Select
            lblUserSelection.Text = "Scissors!"
            picUserSelection.Image = My.Resources.scissr
        End If

        If bolTie = True Then 'Increments variables based on 

        ElseIf bolUserWins = True Then
            intUserWins += 1
        ElseIf bolUserWins = False Then
            intCompWins += 1
        End If

        lblUserWins.Text = intUserWins 'Displays answers (Algorithm step 6)
        lblComputerWins.Text = intCompWins
        lblGamesPlayed.Text = intGamesPlayed

    End Sub

End Class
