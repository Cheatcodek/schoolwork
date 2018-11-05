Public Class Form1


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim intUserSelection As Integer
        Dim intCompSelection As Integer
        Static intUserWins As Integer
        Static intCompWins As Integer

        Dim bolUserWins As Boolean
        Dim bolTie As Boolean
        Dim objRandom As New Random

        Select Case True
            Case radRock.Checked
                intUserSelection = 1
            Case radPaper.Checked
                intUserSelection = 2
            Case radScissors.Checked
                intUserSelection = 3
            Case Else
                MsgBox("You Need to select something!!")
        End Select

        intCompSelection = objRandom.Next(0, 4)

        'Do label stuff here

        If intUserSelection = 1 Then
            Select Case intCompSelection
                Case 1
                    lblVictoryWho.Text = "Neither!"
                Case 2
                    lblVictoryWho.Text = "---->"
                Case 3
                    lblVictoryWho.Text = "<----"

            End Select



        End If

    End Sub

End Class
