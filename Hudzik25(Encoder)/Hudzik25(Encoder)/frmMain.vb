Public Class frmMain

    Public strMessage As String
    Public strOriMessage As String

    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click, mnuOptionsEncode.Click

        Dim strCarrier As String = ""

        strMessage = ""
        strOriMessage = ""

        While strCarrier = ""
            strCarrier = InputBox("Input Message")
        End While 'Forces user to enter the code

        strOriMessage = strCarrier 'Preserves initial string

        For intThrowaway As Integer = 0 To strCarrier.Length - 1
            strMessage = strMessage & AscW(strCarrier.Chars(intThrowaway))
            'Adds the unicode value to the string
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
                Exit While 'Exits the while loop if there is a cast exeption
                'Which is what usually happens when someone enters an invalid code or null
            End Try
        End While


    End Sub

    Private Sub mnuFileAbout_Click(sender As Object, e As EventArgs) Handles mnuFileAbout.Click
        MessageBox.Show("Encode will turn your string into unicode" & vbNewLine & "See the code will only unlock after entering something into encode" & vbNewLine & "It will show the character and it's unicode equivalent" & vbNewLine & "Decode will prompt for a unicode input, then give the result")
        'Creative addition, tells user about the program
    End Sub
End Class
