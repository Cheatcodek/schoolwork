Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strPhrase As String = InputBox("Enter Phrase", "Letter Counter")
        Dim chrChar As Char = InputBox("One Letter Character ONLY", "Letter Counter")
        Dim intLength As Integer = strPhrase.Length - 1
        Dim intCharacterAmount As Integer

        lblPhrase.Text = strPhrase
        lblLetter.Text = chrChar

        strPhrase = strPhrase.ToUpper() 'Change to upper

        For intThrowaway As Integer = 0 To intLength 'Checks each character in a string for if it is the same as the letter

            Dim chrNewChar As Char = strPhrase.Chars(intThrowaway)

            If chrNewChar = chrChar Then

                intCharacterAmount += 1
            End If

        Next

        strPhrase = strPhrase.ToLower() 'Change to lower

        For intThrowaway As Integer = 0 To intLength 'Checks each character in a string for if it is the same as the letter

            Dim chrNewChar As Char = strPhrase.Chars(intThrowaway)

            If chrNewChar = chrChar Then

                intCharacterAmount += 1
            End If

        Next

        lblAmount.Text = Val(intCharacterAmount)

    End Sub

End Class