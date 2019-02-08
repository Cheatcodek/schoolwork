Public Class frmMain
    Dim strMainString As String
    Dim intCorrectGuesses As Integer
    Dim intWrongGuesses As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strMainString = InputBox("Insert One Word", "Word Guess")
        strMainString = strMainString.Replace(" ", "")
        strMainString = strMainString.ToLower
        lblDisplayword.Text = ""
        lblLength.Text = lblLength.Text & Val(strMainString.Length)

        For intCounter As Integer = 0 To strMainString.Length - 1

            lblDisplayword.Text = lblDisplayword.Text & "_"

        Next

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim bolCorrect As Boolean = False

        For intThrowaway As Integer = 0 To strMainString.Length - 1


            If txtGuess.Text = strMainString.Chars(intThrowaway) Or txtGuess.Text = strMainString.ToLower.Chars(intThrowaway) Then

                intCorrectGuesses += 1
                bolCorrect = True
            End If


        Next

        If bolCorrect Then
            intWrongGuesses -= 1
        End If

    End Sub


End Class
