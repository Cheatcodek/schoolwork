Public Class frmMain
    'Images used are from nCalculators.com and wikiHow
    'Rectangle https://ncalculators.com/images/formulas/rectangle.jpg
    'Hexagon https://www.wikihow.com/images/thumb/c/c4/Calculate-the-Area-of-a-Hexagon-Step-1-Version-5.jpg/aid929013-v4-728px-Calculate-the-Area-of-a-Hexagon-Step-1-Version-5.jpg


#Region "Variables"
    Dim dblLength As Double
    Dim dblWidth As Double
    Dim dblAnswer As Double
    Dim dblPerimeterAnswer As Double


    Dim dblHexLength As Double
    Dim dblHexAns As Double
    Dim dblHexPerimeter As Double
#End Region

#Region "Rectangle"
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click, mnuAnswer.Click

        dblLength = Val(txtLength.Text)
        dblWidth = Val(txtWidth.Text) 'Declares the Width and Length variables based on Inserted text

        dblAnswer = dblLength * dblWidth 'Does the calulation
        lblAnswer.Text = dblAnswer 'displays on label

        dblPerimeterAnswer = (dblLength * 2) + (dblWidth * 2)
        lblRectPerimeter.Text = dblPerimeterAnswer

    End Sub



    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged, txtWidth.TextChanged
        lblAnswer.Text = "" 'Turns area calc into nothing as to not confuse user
        lblRectPerimeter.Text = ""

    End Sub
#End Region

#Region "Hexagon"

    Private Sub btnHexCalculate_Click(sender As Object, e As EventArgs) Handles btnHexCalculate.Click, mnuAnswer.Click

        dblHexLength = Val(txtHexLength.Text) 'Turns string into double

        dblHexAns = ((3 * (Math.Sqrt(3))) \ 2) * dblHexLength ^ 2 'Is the math that calculates area (Integer division is used as to make the resulting number a less of a mess)
        lblHexAnswer.Text = dblHexAns

        dblHexPerimeter = dblHexLength * 6 'Perimeter calculation
        lblHexPerimeter.Text = dblHexPerimeter

    End Sub


    Private Sub txtHexLength_TextChanged(sender As Object, e As EventArgs) Handles txtHexLength.TextChanged

        lblHexAnswer.Text = "" 'Turns area calc into nothing as to not confuse user
        lblHexPerimeter.Text = ""


    End Sub

#End Region



    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit() 'exits application

    End Sub


End Class
