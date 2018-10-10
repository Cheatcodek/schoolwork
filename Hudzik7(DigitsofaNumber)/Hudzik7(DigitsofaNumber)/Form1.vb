Public Class Form1

    Dim dblFirst As Double
    Dim dblSecond As Double
    Dim dblInput As Double

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

        dblInput = Val(txtInput.Text)

    End Sub

End Class
