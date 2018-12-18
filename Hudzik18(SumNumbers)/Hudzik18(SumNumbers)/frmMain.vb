Public Class frmMain


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intStarting As Integer
        Dim intEnding As Integer
        Dim intFinalNumber As Integer
        Dim strIntermediate As String = ""

        If (txtEnding.Text = "" Or txtStarting.Text = "") Then
            MessageBox.Show("Put something into both boxes!", "Sum Numbers")
        End If

        intStarting = Val(txtStarting.Text)
        intEnding = Val(txtEnding.Text)


        For intThrowaway As Integer = intStarting To intEnding 'Takes the starting number and ending number and then adds the throwaway to the final number, and also concantates the intermediate string

            intFinalNumber += intThrowaway

            If intThrowaway <> intEnding Then 'Unfinished
                strIntermediate = strIntermediate & Str(intThrowaway) & "+"
            End If

        Next

        strIntermediate = strIntermediate & "=" & intFinalNumber
        lblResult.Text = strIntermediate

    End Sub

End Class
