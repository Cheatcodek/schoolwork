Public Class frmMain 'Algorithm Step 1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblTotalPoints As Double
        Dim dblMaxPoints As Double ' Initializes variables (Algorithm Step 2 & 3)
        Dim dblPercentage As Double

        dblTotalPoints = Val(txtTotalPoints.Text) ' Gets data (Algorithm Step 4)
        dblMaxPoints = Val(txtMaxPoints.Text)

        dblPercentage = 100 * (dblTotalPoints / dblMaxPoints) ' Calculates percentage (Algorithm Step 5)

        lblPercentage.Text = dblPercentage ' Algorithm Step 6

        If dblPercentage >= 64 Then
            lblPassing.Text = "You Passed !!"

        Else
            lblPassing.Text = "You FAILED !!!
Study More"

        End If

    End Sub


    Private Sub txtTotalPoints_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPoints.TextChanged, txtMaxPoints.TextChanged

        lblPercentage.Text = "" 'Changes text to nothing if text changed (Algorithm Step 7)
        lblPassing.Text = ""

    End Sub

End Class
