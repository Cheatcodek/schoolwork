Imports System.Media
Public Class frmMain
    Dim strMainString As String
    'Fighting Gold is by CODA, recreated in a band arangement by Musescore

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strMainString = InputBox("Insert One Word", "Word Guess")
        strMainString = strMainString.Replace(" ", "")
        strMainString = strMainString.ToLower 'Prepares the string for use

        lblDisplayword.Text = "" 'Removes anything in displayword
        lblLength.Text = lblLength.Text & Val(strMainString.Length) 'Gives the length of the word

        For intCounter As Integer = 0 To strMainString.Length - 1
            'Loop to put "blanks" into label
            lblDisplayword.Text = lblDisplayword.Text & "-"
        Next

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim bolCorrect As Boolean = False
        Static strGuessed As String
        Static intWrongGuesses As Integer

        For intThrowaway As Integer = 0 To strMainString.Length - 1
            'Use loop to find position and existance of characters
            If txtGuess.Text = strMainString.Chars(intThrowaway) Or txtGuess.Text.ToLower = strMainString.ToLower.Chars(intThrowaway) Then
                'If the character of txtGuess is equal to the character of the string, or the lowercase version is equal, 
                'Turn the bolCorrect to true, remove the specific character from lblDisplayword, insert the character, then put the character into the check guess string
                bolCorrect = True
                lblDisplayword.Text = lblDisplayword.Text.Remove(intThrowaway, 1) 'Removes the character to be replaced
                lblDisplayword.Text = lblDisplayword.Text.Insert(intThrowaway, strMainString.Substring(intThrowaway, 1)) 'Inserts the character from the main string into the label
                strGuessed = strGuessed & lblDisplayword.Text.Chars(intThrowaway)
                SystemSounds.Asterisk.Play()
            End If

        Next

        If bolCorrect = False Then
            intWrongGuesses += 1
            lblWrongguesses.Text = intWrongGuesses
            SystemSounds.Hand.Play()
            MessageBox.Show("That is not in the word!" & vbNewLine & txtGuess.Text & " is not in the word!")
        End If

        If lblDisplayword.Text = strMainString Then 'Checks if the correct guesses have gotten to the length of the string
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.WaitToComplete)
            'Win timer WIP
            For intCounter As Integer = 1 To 3

                Select Case intCounter
                    Case 1
                        Me.BackColor = Color.Red
                    Case 2
                        Me.BackColor = Color.Blue
                    Case 3
                        Me.BackColor = Color.Purple
                End Select

                For i As Integer = 1 To 99
                    My.Application.DoEvents()
                Next

            Next
                MessageBox.Show("You have fully guessed the word!" & vbNewLine & "It was " & strMainString)
            Application.Exit()
        End If

        If intWrongGuesses = 8 Then
            My.Computer.Audio.Play(My.Resources.remove, AudioPlayMode.WaitToComplete)
            MessageBox.Show("You are out of guesses" & vbNewLine & "Therefor you lose!" & vbNewLine & "The Word was " & strMainString)
            Application.Exit() 'Informs the user and then exits if they have failed
        End If

        txtGuess.Text = ""

    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click

        Static bolMusic As Boolean = False

        If bolMusic Then
            My.Computer.Audio.Stop()
            bolMusic = False
        Else
            My.Computer.Audio.Play(My.Resources.Fighting_Gold_Band_Arrangement, AudioPlayMode.BackgroundLoop)
            bolMusic = True
        End If

    End Sub

    Private Sub tmrLength_Tick(sender As Object, e As EventArgs) Handles tmrLength.Tick

        Static dblTime As Double

        dblTime += 0.1
        lblTimer.Text = "Time : " & Val(dblTime)

    End Sub

End Class