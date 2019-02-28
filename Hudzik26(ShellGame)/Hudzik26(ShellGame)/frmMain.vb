Public Class frmMain

    Dim intGamesPlayed As Integer = 0
    Dim intGamesWon As Integer = 0

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click, MyBase.Load

        'Dim objRandom As New Random

        'Select Case objRandom.Next(1, 4)
        '    Case 1
        '        picShell1.Tag = "1"
        '        picShell2.Tag = "0"
        '        picShell3.Tag = "0"
        '    Case 2
        '        picShell1.Tag = "0"
        '        picShell2.Tag = "1"
        '        picShell3.Tag = "0"
        '    Case 3
        '        picShell1.Tag = "0"
        '        picShell2.Tag = "0"
        '        picShell3.Tag = "1"
        'End Select



    End Sub

    Private Sub picShell_Click(sender As Object, e As EventArgs) Handles picShell1.Click, picShell2.Click, picShell3.Click

        Dim objRandom As New Random

        Dim picSelectedShell As PictureBox = sender



        If Val(picSelectedShell.Tag) = 1 Then

            MessageBox.Show("Win")
        ElseIf Val(picSelectedShell.Tag) = 0 Then

            MessageBox.Show("Loss")
        End If

    End Sub


End Class
