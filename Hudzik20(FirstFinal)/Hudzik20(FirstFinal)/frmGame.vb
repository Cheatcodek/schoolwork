Public Class frmGame

    Dim objRandom As New Random
    Dim dictDice As New Dictionary(Of Integer, Integer)
    Dim dictSelection As New Dictionary(Of Integer, Boolean)
    Dim dictDieEnabled As New Dictionary(Of Integer, Boolean)
    Dim dictDieSaved As New Dictionary(Of Integer, Boolean)
    Dim intPoints As Integer
    Dim intPointGain As Integer


#Region "Calling Subs"
    Sub Roll() 'Removes and then rolls the results of the dice
        dictDice.Remove(1)
        dictDice.Remove(2)
        dictDice.Remove(3)
        dictDice.Remove(4)
        dictDice.Remove(5)
        dictDice.Remove(6)
        dictDice.Add(1, objRandom.Next(1, 7))
        dictDice.Add(2, objRandom.Next(1, 7))
        dictDice.Add(3, objRandom.Next(1, 7))
        dictDice.Add(4, objRandom.Next(1, 7))
        dictDice.Add(5, objRandom.Next(1, 7))
        dictDice.Add(6, objRandom.Next(1, 7))
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
        dictSelection.Remove(1)
        dictSelection.Remove(2)
        dictSelection.Remove(3)
        dictSelection.Remove(4)
        dictSelection.Remove(5)
        dictSelection.Remove(6)
        lblDieSelected1.Visible = False
        lblDieSelected2.Visible = False
        lblDieSelected3.Visible = False
        lblDieSelected4.Visible = False
        lblDieSelected5.Visible = False
        lblDieSelected6.Visible = False
    End Sub

    Sub PointCount()
        Dim bolEndOfCount As Boolean = False

        'Check for ones
        For intThrow As Integer = 1 To 6
                If (dictSelection.ContainsKey(intThrow)) And (dictDice(intThrow) = 1) Then
                    intPointGain += 100
                End If
            Next
            'Check for fives
            For intThrow As Integer = 1 To 6
                If (dictSelection.ContainsKey(intThrow)) And (dictDice(intThrow) = 5) Then
                    intPointGain += 50
                End If
            Next
            'Temporary, used for checking triple numbers
            Dim intTripling As Integer 'used to check for tripling, use for when equals 3
            For intThrow As Integer = 1 To 6
                If (dictSelection.ContainsKey(intThrow)) And (dictDice(intThrow) = intThrow) Then

                    intPointGain += intThrow * 100

                End If
            Next


    End Sub
#End Region

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Roll()
        Call CreateImages()
    End Sub

    Private Sub btnEndTurn_Click(sender As Object, e As EventArgs) Handles btnEndTurn.Click
        Call PointCount()
        Dim msgBoxResult = MessageBox.Show("You will get " & intPointGain & " Points from this" & vbNewLine & "Continue?", "VBFarkle", MessageBoxButtons.YesNo)

        If msgBoxResult = DialogResult.Yes Then
            intPoints += intPointGain
            Call Roll()
            Call CreateImages()
            Call Deselect()
            intPointGain = 0
        ElseIf msgBoxResult = DialogResult.No Then
            Exit Sub
        End If
    End Sub
#Region "Selections"
    Private Sub btnDeselect_Click(sender As Object, e As EventArgs) Handles btnDeselect.Click
        Call Deselect()
    End Sub

    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click
        dictSelection(1) = True
        lblDieSelected1.Visible = True
    End Sub

    Private Sub btnSelect2_Click(sender As Object, e As EventArgs) Handles btnSelect2.Click
        dictSelection(2) = True
        lblDieSelected2.Visible = True
    End Sub

    Private Sub btnSelect3_Click(sender As Object, e As EventArgs) Handles btnSelect3.Click
        dictSelection(3) = True
        lblDieSelected3.Visible = True
    End Sub

    Private Sub btnSelect4_Click(sender As Object, e As EventArgs) Handles btnSelect4.Click
        dictSelection(4) = True
        lblDieSelected4.Visible = True
    End Sub

    Private Sub btnSelect5_Click(sender As Object, e As EventArgs) Handles btnSelect5.Click
        dictSelection(5) = True
        lblDieSelected5.Visible = True
    End Sub

    Private Sub btnSelect6_Click(sender As Object, e As EventArgs) Handles btnSelect6.Click
        dictSelection(6) = True
        lblDieSelected6.Visible = True
    End Sub
#End Region



End Class