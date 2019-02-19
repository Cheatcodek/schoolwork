Public Class frmMain

    Dim dictScores As New Dictionary(Of Integer, Integer)
    'First int is key, second is value
    Dim intCounter As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Do Until 0 <> 0

            Dim strCarrier As String
            'Carries the string from the input box to be examined


            strCarrier = InputBox("Input score, click cancel to end")

            If strCarrier = "" Then
                Exit Do
            ElseIf strCarrier.Length >= 4 Or Val(strCarrier) > 300 Then
                MessageBox.Show("That is an invalid score")
                Exit Do
            End If

            intCounter += 1
            dictScores.Add(intCounter, Val(strCarrier))

        Loop

    End Sub


    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click

        Dim intHighscore As Integer
        Dim intLowscore As Integer

        intHighscore = dictScores.Values.Max()
        intLowscore = dictScores.Values.Min()

        'you know, I had a whole thing planned out that worked but it didn't so here is the corpse for autopsy
        'For intCount As Integer = 1 To intCounter - 1
        '    Dim intFirst As Integer
        '    Dim intSecond As Integer

        '    intFirst = dictScores(intCount)
        '    intSecond = dictScores(intCount + 1)

        '    If intFirst < intSecond Then
        '        intHighscore = intSecond

        '    End If

        'Next

        'For intCount As Integer = 1 To intCounter - 1
        '    Dim intFirst As Integer
        '    Dim intSecond As Integer

        '    intFirst = dictScores(intCount)
        '    intSecond = dictScores(intCount + 1)

        '    If intFirst > intSecond Then
        '        intLowscore = intFirst

        '    End If

        'Next

    End Sub


End Class
