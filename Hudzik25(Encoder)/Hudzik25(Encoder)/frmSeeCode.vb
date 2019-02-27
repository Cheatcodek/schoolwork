Public Class frmSeeCode
    Private Sub frmSeeCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intThrowaway As Integer = 0 To frmMain.strOriMessage.Length - 1
            'For the length of the original message, add the character, a =, and the value
            lblMain.Text = lblMain.Text & vbNewLine & frmMain.strOriMessage.Chars(intThrowaway) & " = " & AscW(frmMain.strOriMessage.Chars(intThrowaway))
        Next

        Me.Size = New Size(247, (150 + (12 * frmMain.strOriMessage.Length)))
        'Resize to length of string multiplied by twelve plus 150

    End Sub
End Class