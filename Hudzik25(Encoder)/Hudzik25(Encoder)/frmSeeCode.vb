Public Class frmSeeCode
    Private Sub frmSeeCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intThrowaway As Integer = 0 To frmMain.strMessage.Length - 1

            lblMain.Text = lblMain.Text & vbNewLine & frmMain.strOriMessage.Chars(intThrowaway) & " = " & AscW(frmMain.strOriMessage.Chars(intThrowaway))

        Next

    End Sub
End Class