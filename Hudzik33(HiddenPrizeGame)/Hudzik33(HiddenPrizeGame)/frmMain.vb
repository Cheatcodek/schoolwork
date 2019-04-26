
Public Class frmMain

    Dim btnHiddenBoxes(4, 4) As Button

    Dim intButtonsGiven As Integer
    Dim strPrize As String
    Dim objRandom As New Random

    Sub CreateButtons(ByVal intButtonAmount As Integer)


        'For loops to create buttons
        For i As Integer = 0 To intButtonAmount

            For j As Integer = 0 To intButtonAmount

                btnHiddenBoxes(i, j) = New Button
                btnHiddenBoxes(i, j).Text = (i + 1) & ", " & (j + 1)
                btnHiddenBoxes(i, j).Size = New Size(50, 30)
                btnHiddenBoxes(i, j).Location = New Point(i * 56, (j * 32) + 30)
                btnHiddenBoxes(i, j).Enabled = False
                Controls.Add(btnHiddenBoxes(i, j))

                AddHandler btnHiddenBoxes(i, j).Click, AddressOf PrizeRevealer

            Next

        Next

    End Sub

    Private Sub btnHidePrizes_Click(sender As Object, e As EventArgs) Handles btnHidePrizes.Click, mnuStartEasy.Click, mnuStartNormal.Click


        If TypeOf sender Is Button And radNormalMode.Checked = True Then
            intButtonsGiven = 4
        ElseIf TypeOf sender Is Button And radEasyMode.Checked = True Then
            intButtonsGiven = 2
        ElseIf TypeOf sender Is MenuStrip Then

            Dim mnuSender As MenuStrip = sender

            If mnuSender.Tag = "1" Then
                intButtonsGiven = 2
            Else
                intButtonsGiven = 4
            End If

        End If

        ReDim btnHiddenBoxes(intButtonsGiven, intButtonsGiven)
        CreateButtons(intButtonsGiven)
        HidePrizes(intButtonsGiven)
        btnHidePrizes.Enabled = False
    End Sub


    Sub HidePrizes(ByVal intButtonAmount As Integer)

        For i As Integer = 0 To intButtonAmount
            For j As Integer = 0 To intButtonAmount
                btnHiddenBoxes(i, j).Enabled = True
            Next
        Next


        'Gives the values of "Comp" and "uter" randomly
        'Somtimes will assign multiple strings for some reason,
        'Leading to a stackoverflow
        'No idea how to fix this
        If intButtonAmount = 2 Then
            btnHiddenBoxes(objRandom.Next(1, intButtonAmount + 1), objRandom.Next(1, intButtonAmount + 1)).Tag = "Computer"

        ElseIf intButtonAmount = 4 Then
            btnHiddenBoxes(objRandom.Next(1, intButtonAmount + 1), objRandom.Next(1, intButtonAmount + 1)).Tag = "Comp"
            btnHiddenBoxes(objRandom.Next(1, intButtonAmount + 1), objRandom.Next(1, intButtonAmount + 1)).Tag = "uter"
        End If

        Dim strCheckString As String = ""


        For i As Integer = 0 To intButtonAmount
            For j As Integer = 0 To intButtonAmount
                strCheckString = strCheckString & btnHiddenBoxes(i, j).Tag
            Next
        Next

        'If the tags are not on the buttons, redo
        If (strCheckString = "Computer") Or (strCheckString = "uterComp") Then
        Else
            Call HidePrizes(intButtonsGiven)
        End If

        lblBoxesLeft.Visible = True


    End Sub


    Private Sub PrizeRevealer(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btnScannedButton As Button = sender
        Static strCheckString As String = ""
        Static intBoxesLeft As Integer = 10

        btnScannedButton.Enabled = False

        'These two ifs check if the user got comp or user then adds it to the checkstring
        If sender.Tag = "Comp" Then
            MessageBox.Show("You got Comp !!")
            strCheckString = strCheckString & "Comp"
        End If

        If sender.Tag = "uter" Then
            MessageBox.Show("You got uter !!")
            strCheckString = strCheckString & "uter"
        End If

        'Victory condition
        If ((strCheckString = "Computer") Or (strCheckString = "uterComp")) Or sender.Tag = "Computer" Then
            MessageBox.Show("You got Computer!!" & vbNewLine & "You won the computer")
            Application.Exit()
        End If

        intBoxesLeft -= 1
        lblBoxesLeft.Text = "Boxes left : " & intBoxesLeft


        If intBoxesLeft <= 0 Then
            MessageBox.Show("You've ran out of uses!!" & vbNewLine & "Goodbye")
            Application.Exit()
        End If


    End Sub

End Class
