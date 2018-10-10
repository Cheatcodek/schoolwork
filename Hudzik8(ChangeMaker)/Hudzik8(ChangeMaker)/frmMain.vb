Public Class frmMain 'Algorithm Step One



    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click, mnuGetChange.Click
#Region "Variable Initialization"
        Dim dblChange As Double
        Dim dblQuarter As Double
        Dim dblDime As Double
        Dim dblNickel As Double
        Dim dblPenny As Double 'Initializes the variables (Algorithm Step 3)

        dblChange = Val(txtMain.Text) 'Gets change from textbox (Algorithm Step 4)
#End Region

#Region "Math" 'Algorithm Step 5
        dblQuarter = dblChange \ 25
        dblChange = dblChange - (dblQuarter * 25)

        dblDime = dblChange \ 10
        dblChange = dblChange - (dblDime * 10)

        dblNickel = dblChange \ 5
        dblChange = dblChange - (dblNickel * 5)

        dblPenny = dblChange
#End Region

#Region "Label Display" 'Algorithm Step 6
        lblQuarter.Text = dblQuarter
        lblDime.Text = dblDime
        lblNickel.Text = dblNickel
        lblPenny.Text = dblPenny
#End Region

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit() 'Algorithm Step 7
    End Sub

End Class
