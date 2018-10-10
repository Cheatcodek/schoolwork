Public Class frmMain ' Algorithm Step 1



    Private Sub Celsius(sender As Object, e As EventArgs) Handles btnFtC.Click, mnuCelsius.Click

        Dim dblFTemp As Double
        Dim dblCTemp As Double ' Initializes Variables (Algorithm Step 2 & 3)

        dblFTemp = Val(txtTemp.Text) ' Get information from user (Algorithmn Step 4)

        dblCTemp = (dblFTemp - 32) * (5 / 9) ' Preform Calculation (Algorithmn Step 5)
        lblTemp.Text = dblCTemp ' Displays information (Algorithm Step 6)

    End Sub

    Private Sub Farhentheit(sender As Object, e As EventArgs) Handles btnCtF.Click, mnuFahrenheit.Click

        Dim dblFTemp As Double
        Dim dblCTemp As Double 'Variables

        dblCTemp = Val(txtTemp.Text) 'Gets information

        dblFTemp = (dblCTemp * (9 / 5)) + 32 'Calculation
        lblTemp.Text = dblFTemp 'Display

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
