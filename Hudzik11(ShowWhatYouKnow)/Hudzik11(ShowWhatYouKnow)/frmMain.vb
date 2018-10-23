Public Class frmMain 'Initializes things

    Dim strSTRINGO As String


#Region "Button Things"
    Private Sub radOne_CheckedChanged(sender As Object, e As EventArgs) Handles radOne.Click

        lblMain.Text = "Label that shows stuff" 'Changes label if RadOne checked
    End Sub

    Private Sub radTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radTwo.Click

        lblMain.Text = "Label that shows other stuff" 'Changes label to something else if RadTwo Checked
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click

        lblMain.Text = "Label that shows button has done stuff" 'Is a button that also does stuff and unactivates the radio buttons
        radOne.Checked = False
        radTwo.Checked = False
    End Sub


#End Region

    Private Sub txtTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtTextBox.TextChanged

        If txtTextBox.TextLength > 0 Then

            lblTEXTBOX.Text = "NICE NOW THERE IS TEXT IN HERE"

        Else
            lblTEXTBOX.Text = "HEY THERE'S NO TEXT IN HERE"
        End If

        strSTRINGO = txtTextBox.Text
    End Sub

End Class
