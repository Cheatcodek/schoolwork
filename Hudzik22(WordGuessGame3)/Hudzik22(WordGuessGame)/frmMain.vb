﻿Imports System.Media
Public Class frmMain
    Dim strMainString As String
    Dim bolNoise As Boolean = True
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

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click, mnuControlsConfirm.Click
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
                If bolNoise Then
                    SystemSounds.Asterisk.Play()
                End If
            End If

        Next

        If bolCorrect = False Then
            intWrongGuesses += 1
            lblWrongguesses.Text = intWrongGuesses
            If bolNoise Then
                SystemSounds.Hand.Play()
            End If
            MessageBox.Show("That is not in the word!" & vbNewLine & txtGuess.Text & " is not in the word!")
            End If

            If lblDisplayword.Text = strMainString Then 'Checks if the correct guesses have gotten to the length of the string
            tmrLength.Enabled = False
            If bolNoise Then
                My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.WaitToComplete)
            End If
            tmrVictory.Enabled = True
            MessageBox.Show("You have fully guessed the word!" & vbNewLine & "It was " & strMainString)
            Application.Exit()
        End If

        If intWrongGuesses = 8 Then
            If bolNoise Then
                My.Computer.Audio.Play(My.Resources.remove, AudioPlayMode.WaitToComplete)
            End If
            MessageBox.Show("You are out of guesses" & vbNewLine & "Therefor you lose!" & vbNewLine & "The Word was " & strMainString)
            Application.Exit() 'Informs the user and then exits if they have failed
        End If

            txtGuess.Text = ""

    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click, mnuControlsTogglemusic.Click

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
        dblTime = Math.Round(dblTime * 10, MidpointRounding.AwayFromZero) / 10
        lblTimer.Text = "Time : " & Val(dblTime)

    End Sub

    Private Sub tmrVictory_Tick(sender As Object, e As EventArgs) Handles tmrVictory.Tick
        Static intCount As Integer = 0

        Select Case intCount
            Case 1
                Me.BackColor = Color.Red
            Case 2
                Me.BackColor = Color.Blue
            Case 3
                Me.BackColor = Color.Purple
            Case 4
                Me.BackColor = Color.Gold
            Case 5
                Me.BackColor = Color.White
        End Select

        intCount += 1

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub

    Private Sub btnTogglenoise_Click(sender As Object, e As EventArgs) Handles btnTogglenoise.Click, mnuControlsTogglenoise.Click 
        'Creative addition, Toggles non music sounds being played
        bolNoise = Not bolNoise 'Toggles bolNoise
    End Sub
End Class