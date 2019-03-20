Public Class frmMain


    Private Sub THE_BIG_ONE(sender As Object, e As EventArgs) Handles btnInput.Click, btnAscending.Click, btnDescending.Click, btnFind.Click

        Static strFriends(4) As String
        Dim btnSelectedButton As Button = DirectCast(sender, Button)


        If btnSelectedButton.Tag = btnInput.Tag Then

            lblMain.Text = ""
            For i As Integer = 0 To 4

                strFriends(i) = InputBox("Enter friend " & i + 1)
                lblMain.Text = lblMain.Text & (i + 1 & ". " & strFriends(i) & vbNewLine)

            Next

            grpSort.Enabled = True

        ElseIf btnSelectedButton.Tag = btnAscending.Tag Then

            Array.Sort(strFriends)
            lblMain.Text = ""
            For i As Integer = 0 To 4

                lblMain.Text = lblMain.Text & (i + 1 & ". " & strFriends(i) & vbNewLine)

            Next

        ElseIf btnSelectedButton.Tag = btnDescending.Tag Then

            Array.Sort(strFriends)
            Array.Reverse(strFriends)
            lblMain.Text = ""
            For i As Integer = 0 To 4

                lblMain.Text = lblMain.Text & (i + 1 & ". " & strFriends(i) & vbNewLine)

            Next

        ElseIf btnSelectedButton.Tag = btnFind.Tag Then
            Dim strName As String = InputBox("Enter Name")

            For i As Integer = 0 To 4

                If strFriends(i).ToLower = strName.ToLower Then
                    MessageBox.Show("Name Found!" & vbNewLine & "It was at position " & i + 1)
                    Exit Sub
                End If

            Next

            MessageBox.Show("Search Failed!")

        Else
            MessageBox.Show("Fatal Error!!" & vbNewLine & "Cannot Get Button")

        End If



    End Sub

End Class
