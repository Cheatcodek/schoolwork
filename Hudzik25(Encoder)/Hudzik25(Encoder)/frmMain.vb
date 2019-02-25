Public Class frmMain

    Public strMessage As String
    Public strOriMessage As String

    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click

        Dim strCarrier As String = ""
        Dim chrChar As Char

        strMessage = ""
        strOriMessage = ""

        While strCarrier = ""
            strCarrier = InputBox("Input Message")
        End While

        strOriMessage = strCarrier

        For intThrowaway As Integer = 0 To strCarrier.Length - 1

            chrChar = strCarrier.Chars(intThrowaway)
            strMessage = strMessage & AscW(chrChar)
        Next

    End Sub

    Private Sub btnSeecode_Click(sender As Object, e As EventArgs) Handles btnSeecode.Click
        frmSeeCode.Show()
    End Sub
End Class
