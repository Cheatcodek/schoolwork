Public Class frmMain 'Initializes things




#Region "Label Things"
    Private Sub radOne_CheckedChanged(sender As Object, e As EventArgs) Handles radOne.Click

        lblMain.Text = "Label that shows stuff"
    End Sub

    Private Sub radTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radTwo.Click

        lblMain.Text = "Label that shows other stuff"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click

        lblMain.Text = "Label that shows button has done stuff"
        radOne.Checked = False
        radTwo.Checked = False
    End Sub
#End Region


End Class
