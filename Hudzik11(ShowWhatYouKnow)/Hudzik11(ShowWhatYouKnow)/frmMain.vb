Public Class frmMain 'Initializes things

    'Credits to the Steam Community, Wikimedia, and a youtube thumbnail
    'Deus Ex logo : https://steamusercontent-a.akamaihd.net/ugc/36369145561101107/B11F3EDB49B20F367443F1D749BE87845269000A/
    'Cat : https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Cat03.jpg/1200px-Cat03.jpg
    'Tank : https://i.ytimg.com/vi/cQCuNkWts8k/hqdefault.jpg

    Dim strTextSting As String
    Dim intButtonNumber As Integer 'Initializes variables


#Region "Button Things"
    Private Sub radOne_CheckedChanged(sender As Object, e As EventArgs) Handles radOne.Click

        lblMain.Text = "Label that shows stuff" 'Changes label if RadOne checked
        intButtonNumber = 0
    End Sub

    Private Sub radTwo_CheckedChanged(sender As Object, e As EventArgs) Handles radTwo.Click

        lblMain.Text = "Label that shows other stuff" 'Changes label to something else if RadTwo Checked
        intButtonNumber = 1
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click

        lblMain.Text = "Label that shows button has done stuff" 'Is a button that also does stuff and unactivates the radio buttons
        radOne.Checked = False
        radTwo.Checked = False
        intButtonNumber = 2
    End Sub

    Private Sub TheSwacher(sender As Object, e As EventArgs) Handles radOne.Click, radTwo.Click, btnThree.Click

        If strTextSting = "" Then 'It must be blank for reasons

            Select Case intButtonNumber 'It needs to know what to do
                Case 0
                    picPICTURES.Image = My.Resources.deusend
                Case 1
                    picPICTURES.Image = My.Resources.kot
                Case 2
                    lblTEXTBOX.Text = System.Math.Sin(Val(txtBOX.Text)) * 5
                    picPICTURES.Image = My.Resources.tonk
            End Select
        Else
            lblTEXTBOX.Text = "HEY STOP PRESSING BUTTONS 
WHILE THERE BE TEXT IN HERE!" 'No buttons shall be pressed with text there
        End If
    End Sub

#End Region

    Private Sub txtTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtTextBox.TextChanged


        If txtTextBox.TextLength > 0 Then 'Does stuff when text length is over 0

            lblTEXTBOX.Text = "NICE NOW THERE IS TEXT IN HERE"

        Else
            lblTEXTBOX.Text = "HEY THERE'S NO TEXT IN HERE"
        End If

        strTextSting = txtTextBox.Text
    End Sub

    Private Sub mnuDoLabelThings_Click(sender As Object, e As EventArgs) Handles mnuDoLabelThings.Click

        lblMain.Text = "That did nothing" 'It say this when menu item be click
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
