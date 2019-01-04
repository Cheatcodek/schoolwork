Public Class frmMainMenu

    Public bolDebug As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If chkDebug.Checked = True Then
            bolDebug = True
        Else
            bolDebug = False
        End If
        frmGame.Show()
    End Sub
End Class
