Public Class frmWebBrowser 'insert jorts


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'ug'
        Me.webWindow.Navigate(txtURL.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.webWindow.GoBack() 'take a wild forkin' guess
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Me.webWindow.GoBack() 'This isn't github!!!
    End Sub

End Class
