Public Class frmMain 'Algorithm Step 1
#Region "Credits"
    'Credits go to news.uci.edu, Bramble Berry, and Golden Openings
    'https://news.uci.edu/wp-content/uploads/2015/08/20271160225_bd77c6fb52_o.jpg
    'https://productimages.brambleberry.com/2014_Product/Miscellaneous/WaterSolublePaper_WSP_Main_A.jpg
    'https://goldenopenings.com/assets/images/12InchChromeLarge.jpg

#End Region

    Dim intUserWins As Integer = 0
    Dim intCompWins As Integer = 0 ' Initializes Variables (Algorithm step 2 & 3)
    Dim intGamesPlayed As Integer = 0 'They need to be global so they can be saved and loaded from
    Dim intPoints As Integer
    Dim intWager As Integer

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
                MessageBox.Show("You Need to select something!!") 'In case the user somehow manages to select nothing
        End Select

        intCompSelection = objRandom.Next(1, 4)

        Select Case intCompSelection 'Figures out what the computer has
            Case 1
                lblComputerSelection.Text = "Rock!"
                If chkGraphics.Checked Then
                    picCompSelection.Image = My.Resources.rok
                End If
            Case 2
                lblComputerSelection.Text = "Paper!"
                If chkGraphics.Checked Then
                    picCompSelection.Image = My.Resources.pape
                End If
            Case 3
                lblComputerSelection.Text = "Scissors!"
                If chkGraphics.Checked Then
                    picCompSelection.Image = My.Resources.scissr
                End If
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
            If chkGraphics.Checked Then
                picUserSelection.Image = My.Resources.rok
            End If
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
                If chkGraphics.Checked Then
                    picUserSelection.Image = My.Resources.pape
                End If
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
            If chkGraphics.Checked Then
                picUserSelection.Image = My.Resources.scissr
            End If
        End If



        If bolTie = True Then 'Increments variables based on if tied and who won
            MessageBox.Show("It's A Tie!")
        ElseIf bolUserWins = True Then
            intUserWins += 1
            MessageBox.Show("You won this game!")
            intPoints += intWager
        ElseIf bolUserWins = False Then
            intCompWins += 1
            MessageBox.Show("You lost this game!")
            intPoints -= intWager
        End If

        intWager = 0

        Call Display()

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

        Dim FP As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Documents\RPS.txt" 'Finds file path
        Dim Write As New System.IO.StreamWriter(FP) 'Sets write as the path writer
        If Not System.IO.File.Exists(FP) Then 'If the file doesn't exist, create it
            System.IO.File.Create(FP)
        End If

        Write.WriteLine(intGamesPlayed)
        Write.WriteLine(intUserWins)  'Write the variables to the lines
        Write.WriteLine(intCompWins)
        Write.WriteLine(intPoints)
        Write.Close()

    End Sub

    Private Sub mnuLoad_Click(sender As Object, e As EventArgs) Handles mnuLoad.Click

        Dim FP As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Documents\RPS.txt" 'Finds file path
        If Not System.IO.File.Exists(FP) Then 'If the file doesn't exist, throw error and exit sub procedure
            MessageBox.Show("No file to load!", "RPS", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim Read As New System.IO.StreamReader(FP) 'Sets read as the path reader

        Do While Read.Peek() <> -1 'After its done reading the file, it will return a -1, therefor we stop looping when -1 is returned
            'It's looped just to make sure that it reads everything, it could be done without a loop but it's better to make sure
            intGamesPlayed = Read.ReadLine()
            intUserWins = Read.ReadLine() 'Reads the lines and sets the variables
            intCompWins = Read.ReadLine()
            intPoints = Read.ReadLine()

        Loop

        Read.Close() 'File needs to be closed in order to be used again

        Call Display()
    End Sub


#End Region

    Sub Display()
        lblUserWins.Text = intUserWins 'Displays answers (Algorithm step 6)
        lblComputerWins.Text = intCompWins
        lblGamesPlayed.Text = intGamesPlayed
        lblPoints.Text = intPoints
        lblTotalWager.Text = intWager

    End Sub

    Private Sub chkGraphics_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphics.CheckedChanged
        picUserSelection.Image = Nothing
        picCompSelection.Image = Nothing 'Removes graphics when checkbox clicked
    End Sub

    Private Sub btnWager_Click(sender As Object, e As EventArgs) Handles btnWager.Click

        intWager += 1
        lblTotalWager.Text = intWager
    End Sub
End Class
