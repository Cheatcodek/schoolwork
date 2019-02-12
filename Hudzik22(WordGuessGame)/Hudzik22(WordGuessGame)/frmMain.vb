Public Class frmMain
    Dim strMainString As String
    Dim intWrongGuesses As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strMainString = InputBox("Insert One Word", "Word Guess")
        strMainString = strMainString.Replace(" ", "")
        strMainString = strMainString.ToLower 'Prepares the string for use
        lblDisplayword.Text = "" 'Removes anything in displayword
        lblLength.Text = lblLength.Text & Val(strMainString.Length) 'Gives the length of the word

        For intCounter As Integer = 0 To strMainString.Length - 1
            'Loop to put "blanks" into label
            lblDisplayword.Text = lblDisplayword.Text & "_"

        Next

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim bolCorrect As Boolean = False
        Static strGuessed As String

        For intThrowaway As Integer = 0 To strMainString.Length - 1
            'Use loop to find position and existance of characters
            If txtGuess.Text = strMainString.Chars(intThrowaway) Or txtGuess.Text.ToLower = strMainString.ToLower.Chars(intThrowaway) Then

                bolCorrect = True
                lblDisplayword.Text = lblDisplayword.Text.Remove(intThrowaway, 1) 'Removes the character to be replaced
                lblDisplayword.Text = lblDisplayword.Text.Insert(intThrowaway, strMainString.Substring(intThrowaway, 1)) 'Inserts the character from the main string into the label
                strGuessed = strGuessed & lblDisplayword.Text.Chars(intThrowaway)
            End If

        Next

        If bolCorrect = False Then
            intWrongGuesses += 1
            lblWrongguesses.Text = intWrongGuesses
            MessageBox.Show("That is not in the word!" & vbNewLine & txtGuess.Text & " is not in the word!")
        End If

        If lblDisplayword.Text = strMainString Then 'Checks if the correct guesses have gotten to the length of the string
            MessageBox.Show("You have fully guessed the word!" & vbNewLine & "It was " & strMainString)
            Application.Exit()
        End If

        If intWrongGuesses = 8 Then
            MessageBox.Show("You are out of guesses" & vbNewLine & "Therefor you lose!" & vbNewLine & "The Word was " & strMainString)
            Application.Exit() 'Informs the user and then exits if they have failed
        End If

        txtGuess.Text = ""

    End Sub


End Class
