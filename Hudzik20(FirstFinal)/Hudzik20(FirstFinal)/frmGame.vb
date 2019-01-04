Public Class frmGame

    Dim objRandom As New Random
    Dim dictDice As New Dictionary(Of Integer, Integer)
    Dim dictSelection As New Dictionary(Of Integer, Boolean)
    Dim intPoints As Integer
    Dim intPointGain As Integer
    Dim bolContinue As Boolean = False



#Region "Calling Subs"
    Sub Roll() 'Removes and then rolls the results of the dice
        For intYeet = 1 To 6
            dictDice.Remove(intYeet)
        Next
        For intYeet = 1 To 6
            dictDice.Add(intYeet, objRandom.Next(1, 7))
        Next
    End Sub

    Sub CreateImages()
        'Select case statements to read the result of dictDice and give the pictureboxes the correct images
        Select Case dictDice(1)
            Case 1
                picDie1.Image = My.Resources.Die1
            Case 2
                picDie1.Image = My.Resources.Die2
            Case 3
                picDie1.Image = My.Resources.Die3
            Case 4
                picDie1.Image = My.Resources.Die4
            Case 5
                picDie1.Image = My.Resources.Die5
            Case 6
                picDie1.Image = My.Resources.Die6
        End Select

        Select Case dictDice(2)
            Case 1
                picDie2.Image = My.Resources.Die1
            Case 2
                picDie2.Image = My.Resources.Die2
            Case 3
                picDie2.Image = My.Resources.Die3
            Case 4
                picDie2.Image = My.Resources.Die4
            Case 5
                picDie2.Image = My.Resources.Die5
            Case 6
                picDie2.Image = My.Resources.Die6
        End Select

        Select Case dictDice(3)
            Case 1
                picDie3.Image = My.Resources.Die1
            Case 2
                picDie3.Image = My.Resources.Die2
            Case 3
                picDie3.Image = My.Resources.Die3
            Case 4
                picDie3.Image = My.Resources.Die4
            Case 5
                picDie3.Image = My.Resources.Die5
            Case 6
                picDie3.Image = My.Resources.Die6
        End Select

        Select Case dictDice(4)
            Case 1
                picDie4.Image = My.Resources.Die1
            Case 2
                picDie4.Image = My.Resources.Die2
            Case 3
                picDie4.Image = My.Resources.Die3
            Case 4
                picDie4.Image = My.Resources.Die4
            Case 5
                picDie4.Image = My.Resources.Die5
            Case 6
                picDie4.Image = My.Resources.Die6
        End Select

        Select Case dictDice(5)
            Case 1
                picDie5.Image = My.Resources.Die1
            Case 2
                picDie5.Image = My.Resources.Die2
            Case 3
                picDie5.Image = My.Resources.Die3
            Case 4
                picDie5.Image = My.Resources.Die4
            Case 5
                picDie5.Image = My.Resources.Die5
            Case 6
                picDie5.Image = My.Resources.Die6
        End Select

        Select Case dictDice(6)
            Case 1
                picDie6.Image = My.Resources.Die1
            Case 2
                picDie6.Image = My.Resources.Die2
            Case 3
                picDie6.Image = My.Resources.Die3
            Case 4
                picDie6.Image = My.Resources.Die4
            Case 5
                picDie6.Image = My.Resources.Die5
            Case 6
                picDie6.Image = My.Resources.Die6
        End Select

    End Sub

    Sub Deselect()
        For i = 1 To 6 'This for loop is honestly the closest thing to sanity I have wrote in a while so i'm gonna keep it
            dictSelection(i) = False
        Next
        ' I'm serious, I am very much missing python's inline variable calling for statements (Or whatever that's called)
        ' Eh, maybe i'll trying some object hack to do something similar
        ' Cuz stuff like the below would be so much easier, cleaner and readable if I could
        btnSelect1.Enabled = True
        btnSelect2.Enabled = True
        btnSelect3.Enabled = True
        btnSelect4.Enabled = True
        btnSelect5.Enabled = True
        btnSelect6.Enabled = True
        lblDieSelected1.Visible = False
        lblDieSelected2.Visible = False
        lblDieSelected3.Visible = False
        lblDieSelected4.Visible = False
        lblDieSelected5.Visible = False
        lblDieSelected6.Visible = False
    End Sub

    Sub PointCount()
        Dim intPointsRemoval As Integer
        'Check for ones
        For intThrow As Integer = 1 To 6
            If (dictSelection(intThrow)) And (dictDice(intThrow) = 1) Then
                intPointGain += 100
                intPointsRemoval += 100
            End If
        Next
        'Check for fives
        For intThrow As Integer = 1 To 6
            If (dictSelection(intThrow)) And (dictDice(intThrow) = 5) Then
                intPointGain += 50
                intPointsRemoval += 50
            End If
        Next

        Dim strResults As String = ""

        For intThrow As Integer = 1 To 6
            'Note to self : only read from dictSelection in if statements

            If dictSelection(intThrow) Then
                strResults = strResults & dictDice(intThrow)
            End If
        Next

        If strResults.Length = 3 Then
            If Val(strResults.Chars(1)) = 1 Then
                intPointGain -= intPointsRemoval
                intPointGain += 1000
            ElseIf Val(strResults.Chars(1)) = 5 Then
                intPointGain -= intPointsRemoval
                intPointGain += 500
            Else
                intPointGain += 100 * Val(strResults.Chars(1))
            End If
        End If

    End Sub
#End Region

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Roll()
        Call CreateImages()
        For i = 1 To 6 'Sets the selection dictioary to have false value in all 6 keys
            dictSelection(i) = False
        Next
        If frmMainMenu.bolDebug = False Then
            mnuDebug.Visible = False
        Else
            mnuDebug.Visible = True
        End If
    End Sub

    Private Sub btnEndTurn_Click(sender As Object, e As EventArgs) Handles btnEndTurn.Click
        Call PointCount()
        Dim msgBoxResult = MessageBox.Show("You will get " & intPointGain & " Points from this" & vbNewLine & "Continue?", "VBFarkle", MessageBoxButtons.YesNo)

        If msgBoxResult = DialogResult.Yes Then
            intPoints += intPointGain
            Call Roll()
            Call CreateImages()
            Call Deselect()
            lblPlayerPoints.Text = intPoints
            intPointGain = 0
            If intPoints >= 10000 And (bolContinue = False) Then
                Dim msgResult = MessageBox.Show("You have won with " & intPoints & " Points!" & vbNewLine & "Exit Game?", "VBFarkle", MessageBoxButtons.YesNo)
                If msgResult = DialogResult.Yes Then
                    Application.Exit()
                ElseIf msgResult = DialogResult.No Then
                    bolContinue = True
                End If
            End If
        ElseIf msgBoxResult = DialogResult.No Then
            Exit Sub
        End If
    End Sub

#Region "Selections"
    Private Sub btnDeselect_Click(sender As Object, e As EventArgs) Handles btnDeselect.Click, mnuDeselect.Click
        Call Deselect()
    End Sub

    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click
        dictSelection(1) = True
        lblDieSelected1.Visible = True
        btnSelect1.Enabled = False
    End Sub

    Private Sub btnSelect2_Click(sender As Object, e As EventArgs) Handles btnSelect2.Click
        dictSelection(2) = True
        lblDieSelected2.Visible = True
        btnSelect2.Enabled = False
    End Sub

    Private Sub btnSelect3_Click(sender As Object, e As EventArgs) Handles btnSelect3.Click
        dictSelection(3) = True
        lblDieSelected3.Visible = True
        btnSelect3.Enabled = False
    End Sub

    Private Sub btnSelect4_Click(sender As Object, e As EventArgs) Handles btnSelect4.Click
        dictSelection(4) = True
        lblDieSelected4.Visible = True
        btnSelect4.Enabled = False
    End Sub

    Private Sub btnSelect5_Click(sender As Object, e As EventArgs) Handles btnSelect5.Click
        dictSelection(5) = True
        lblDieSelected5.Visible = True
        btnSelect5.Enabled = False
    End Sub

    Private Sub btnSelect6_Click(sender As Object, e As EventArgs) Handles btnSelect6.Click
        dictSelection(6) = True
        lblDieSelected6.Visible = True
        btnSelect6.Enabled = False
    End Sub

#End Region

    Private Sub mnuTest_Click(sender As Object, e As EventArgs) Handles mnuDebug.Click
        Dim intMasterNumber As Integer = InputBox("What number to set to each?", "VBFarkle")
        For intYeet = 1 To 6
            dictDice(intYeet) = Val(intMasterNumber)
        Next
    End Sub

End Class