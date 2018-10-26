Public Class frmMain 'Algorithm Step 1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click, mnuCalculate.Click

        Dim objRandom As New Random
        Dim dblTotalPoints As Double
        Dim dblMaxPoints As Double ' Initializes variables (Algorithm Step 2 & 3)
        Dim dblPercentage As Double

        If chkRandomizer.Checked = False Then
            dblTotalPoints = Val(txtTotalPoints.Text) ' Gets data (Algorithm Step 4)
            dblMaxPoints = Val(txtMaxPoints.Text)

            dblPercentage = 100 * (dblTotalPoints / dblMaxPoints) ' Calculates percentage (Algorithm Step 5)

            lblPercentage.Text = dblPercentage ' Algorithm Step 6
        Else
            dblPercentage = objRandom.Next(1, 101)
            lblPercentage.Text = dblPercentage
        End If

        Select Case dblPercentage   'Figures out the grade from percentage
            Case 91.5 To 100
                MessageBox.Show("You passed with a A !!", "Calculate Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 83.5 To 91.5
                MessageBox.Show("You passed with a B !!", "Calculate Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 73.5 To 83.5
                MessageBox.Show("You passed with a C !!", "Calculate Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 63.5 To 73.5
                MessageBox.Show("You passed with a D !!", "Calculate Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 0 To 63.5
                MessageBox.Show("YOU HAVE FAILED !!
 STUDY MORE", "Calculate Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case Else
                MessageBox.Show("OOF 
SOME THING DID A WRONG", "OOF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Error message
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
