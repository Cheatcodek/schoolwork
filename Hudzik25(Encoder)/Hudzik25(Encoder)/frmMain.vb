Public Class frmMain

    Public strMessage As String
    Public strOriMessage As String

    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click, mnuOptionsEncode.Click

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

        btnSeecode.Enabled = True
        mnuOptionsSeecode.Enabled = True

    End Sub

    Private Sub btnSeecode_Click(sender As Object, e As EventArgs) Handles btnSeecode.Click, mnuOptionsSeecode.Click
        frmSeeCode.Show()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub

    Private Sub btnDecode_Click(sender As Object, e As EventArgs) Handles btnDecode.Click, mnuOptionsDecode.Click

        Dim strDecodee As String = ""
        Dim strCarrier As String = " "

        While strCarrier <> ""
            strCarrier = InputBox("Insert ONE letter in unicode")
            Try
                lblDecode.Text = lblDecode.Text & ChrW(strCarrier)
            Catch
                Exit While 'Exits the while loop if there is an error
            End Try
        End While


    End Sub
End Class
