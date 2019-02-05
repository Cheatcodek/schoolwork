' I am not creative
Public Class frmMain


    Dim objRandom As New Random


    'Basic Math, Variables, String Concantation, and Commenting
    Private Sub mnuExamplesBasicMath_Click(sender As Object, e As EventArgs) Handles mnuExamplesBasicmath.Click
        MessageBox.Show("You will input two numbers and they will be added" & vbNewLine & "To showcase basic math and variables")

        Dim intMathNum1 As Integer = InputBox("Input First Number", "Doing Math", "First Number")
        Dim intMathNum2 As Integer = InputBox("Input Second Number", "Doing Math", "Second Number")

        MessageBox.Show("The total of these numbers is " & intMathNum1 + intMathNum2)

    End Sub

    'If Then Else
    Private Sub mnuExampleIf_Click(sender As Object, e As EventArgs) Handles mnuExampleIf.Click
        MessageBox.Show("I will give you an input box" & vbNewLine & "If you put a word or zero into the box, I will say 'Nice Word!!' " & vbNewLine & "If you put a nonzero number, I will say 'Nice Number!!' ")

        Dim strIfString As String = InputBox("Input your input", "If Then Else")

        If Val(strIfString) = 0 Then
            MessageBox.Show("Nice Word!!")

        Else
            MessageBox.Show("Nice Number!!")
        End If

    End Sub

    'Looping
    Private Sub mnuExamplesLooping_Click(sender As Object, e As EventArgs) Handles mnuExamplesLooping.Click
        MessageBox.Show("I will give you an input box" & vbNewLine & "If you put a nonzero number into it, it will keep showing up" & vbNewLine & "If you put a word or zero into it, it will stop showing up")

        Dim strLoopString As String = InputBox("Input your input", "Looping")

        While Val(strLoopString) <> 0
            strLoopString = InputBox("Input your input", "Looping")

        End While

    End Sub

    Private Sub mnuExamplesRandom_Click(sender As Object, e As EventArgs) Handles mnuExamplesRandom.Click

        MessageBox.Show("The Number shown below is pseudorandom, between 1 and 100" & vbNewLine & objRandom.Next(1, 101))

    End Sub


#Region "Sub Procedures"
    Sub CodeSection()

        Dim intNum1 As Integer = objRandom.Next(0, 10)
        Dim intNum2 As Integer = objRandom.Next(0, 10)

        MessageBox.Show("Some Result" & vbNewLine & intNum1 + intNum2)

    End Sub

    Private Sub mnuExamplesSub_Click(sender As Object, e As EventArgs) Handles mnuExamplesSub.Click
        Call CodeSection()
    End Sub


#End Region

    Private Sub mnuExamplesString_Click(sender As Object, e As EventArgs) Handles mnuExamplesString.Click

        MessageBox.Show("Give me a string and I will change it in some ways")

        Dim strExampleString As String = InputBox("Input Something", "String Methods")

        MessageBox.Show("This is your string unmodified" & vbNewLine & strExampleString)

        strExampleString = strExampleString.ToUpper

        MessageBox.Show("This is your string in upper case" & vbNewLine & strExampleString)

        strExampleString = strExampleString.ToLower

        MessageBox.Show("This is your string in lower case" & vbNewLine & strExampleString)

        strExampleString = strExampleString.Remove(strExampleString.Length - 1, 1)

        MessageBox.Show("This is your string with the last character removed" & vbNewLine & strExampleString)

        MessageBox.Show("This is how long your string is now" & vbNewLine & strExampleString.Length)

    End Sub


    Private Sub mnuExampleSelectcase_Click(sender As Object, e As EventArgs) Handles mnuExampleSelectcase.Click

        MessageBox.Show("Another form will open showing you a random question" & vbNewLine & "The question will be determined using select case" & vbNewLine & "The answer will be determined using a compound if structure")

        frmSelectCaseQuiz.Show()
    End Sub

End Class
