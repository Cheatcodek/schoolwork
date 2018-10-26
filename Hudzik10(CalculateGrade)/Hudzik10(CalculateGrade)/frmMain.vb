Public Class frmMain 'Algorithm Step 1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click, mnuCalculate.Click

        Dim dblTotalPoints As Double
        Dim dblMaxPoints As Double ' Initializes variables (Algorithm Step 2 & 3)
        Dim dblPercentage As Double

        dblTotalPoints = Val(txtTotalPoints.Text) ' Gets data (Algorithm Step 4)
        dblMaxPoints = Val(txtMaxPoints.Text)

        dblPercentage = 100 * (dblTotalPoints / dblMaxPoints) ' Calculates percentage (Algorithm Step 5)

        lblPercentage.Text = dblPercentage ' Algorithm Step 6

        Select Case dblPercentage   'Figures out the grade from percentage
            Case 91.5 To 100
                lblPassing.Text = "You Passed with an A !!"
            Case 83.5 To 91.5
                lblPassing.Text = "You Passed with a B !!"
            Case 73.5 To 83.5
                lblPassing.Text = "You passed with a C !!"
            Case 63.5 To 73.5
                lblPassing.Text = "You passed with a D !!"
            Case 0 To 63.5
                lblPassing.Text = "You FAILED !!!
Study More"
            Case Else
                lblPassing.Text = "Either I did something wrong
You did something wrong
Or something else messed up"
        End Select

    End Sub


    Private Sub txtTotalPoints_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPoints.TextChanged, txtMaxPoints.TextChanged

        lblPercentage.Text = "" 'Changes text to nothing if text changed (Algorithm Step 7)
        lblPassing.Text = ""

    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

End Class
