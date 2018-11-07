Public Class frmMain 'Algorithm Step 1
#Region "Credits"
    'Credits go to news.uci.edu, Bramble Berry, and Golden Openings
    'https://news.uci.edu/wp-content/uploads/2015/08/20271160225_bd77c6fb52_o.jpg
    'https://productimages.brambleberry.com/2014_Product/Miscellaneous/WaterSolublePaper_WSP_Main_A.jpg
    'https://goldenopenings.com/assets/images/12InchChromeLarge.jpg

#End Region


    Dim intUserWins As Integer = 0
    Dim intCompWins As Integer = 0 ' Initializes Variables (Algorithm step 2 & 3)
    Dim intGamesPlayed As Integer = 0

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click, mnuConfirm.Click

        Dim intUserSelection As Integer
        Dim intCompSelection As Integer

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

        If bolTie = True Then 'Increments variables based on if tied and who won
            MsgBox("It's A Tie!")
        ElseIf bolUserWins = True Then
            intUserWins += 1
            MsgBox("You won this game!")
        ElseIf bolUserWins = False Then
            intCompWins += 1
            MsgBox("You lost this game!")
        End If

        lblUserWins.Text = intUserWins 'Displays answers (Algorithm step 6)
        lblComputerWins.Text = intCompWins
        lblGamesPlayed.Text = intGamesPlayed

    End Sub

#Region "Menu Stuff"
    Private Sub mnuRock_Click(sender As Object, e As EventArgs) Handles mnuRock.Click
        radRock.Checked = True
    End Sub

    Private Sub mnuPaper_Click(sender As Object, e As EventArgs) Handles mnuPaper.Click
        radPaper.Checked = True
    End Sub

    Private Sub mnuScissors_Click(sender As Object, e As EventArgs) Handles mnuScissors.Click
        radScissors.Checked = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit() 'Algorithm Step 7
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Dim FP As String = "C:\Users\106307\Documents\RPS.txt"
        Dim Write As New System.IO.StreamWriter(FP)
        If Not System.IO.File.Exists(FP) Then
            System.IO.File.Create(FP).Dispose()
        End If

        Write.WriteLine(intGamesPlayed)
        Write.WriteLine(intUserWins)
        Write.WriteLine(intCompWins)
        Write.Close()

    End Sub

    Private Sub mnuLoad_Click(sender As Object, e As EventArgs) Handles mnuLoad.Click

        Dim FP As String = "C:\Users\106307\Documents\RPS.txt"
        Dim Read As New System.IO.StreamReader(FP)
        Do While Read.Peek() <> -1

            intGamesPlayed = Read.ReadLine()
            intUserWins = Read.ReadLine()
            intCompWins = Read.ReadLine()
            Read.Close()

        Loop

        lblGamesPlayed.Text = intGamesPlayed
    End Sub

#End Region

End Class
