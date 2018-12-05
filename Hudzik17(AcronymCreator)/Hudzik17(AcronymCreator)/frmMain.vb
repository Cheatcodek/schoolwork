Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intWordNumber As Integer
        Dim strAcronym As String

        intWordNumber = Val(InputBox("How many words?", "Word Number"))


        For i As Integer = 1 To intWordNumber

            Dim chrChar As Char
            Dim strWord As String

            strWord = InputBox("Insert Word")
            chrChar = strWord.Chars(0) 'It crashes when closed kek
            strAcronym = strAcronym & chrChar


        Next

        strAcronym = strAcronym.ToUpper()
        lblAcronym.Text = strAcronym

    End Sub



End Class
