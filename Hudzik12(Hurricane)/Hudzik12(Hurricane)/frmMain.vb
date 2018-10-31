Public Class frmMain

    'This program is a mess

    Private Sub btnCalculation_Click(sender As Object, e As EventArgs) Handles btnCalculation.Click

        Dim dblMPH As Double
        Dim dblScale As Double
        Dim bolIsHurricane As Boolean
        Static intHurricaneName As Integer 'Declares variables
        Dim chrHurricaneName As Char
        Dim objRandom As New Random

        If chkRandom.Checked = False Then 'If the user does not want it to be random

            dblMPH = Val(txtMPH.Text)

        Else 'Sets random number in case user has checked random
            dblMPH = objRandom.Next(60, 158)
        End If

        txtMPH.Text = dblMPH

#Region "Hurricane MPH"

        Select Case dblMPH 'Determines what to display based on MPH
            Case 0 To 74
                bolIsHurricane = False
                lblDamage.Text = "Next to none"
            Case 74 To 96
                bolIsHurricane = True
                dblScale = 1
                lblDamage.Text = "Good homes should be fine
Branches will snap
Likely Power outage"
            Case 96 To 110
                bolIsHurricane = True
                dblScale = 2
                lblDamage.Text = "Potential Roof Damage
Possible uprooted trees
Outage for days to weeks"
            Case 111 To 129
                bolIsHurricane = True
                dblScale = 3
                lblDamage.Text = "Major Hurricane
Roof decking may be gone
Many trees uproot
Water and power out for weeks"
            Case 130 To 156
                bolIsHurricane = True
                dblScale = 4
                lblDamage.Text = "Major Hurricane
Loss of roof or wals
Most trees and power poles downed
Months of power outage"
            Case > 157
                bolIsHurricane = True
                dblScale = 5
                lblDamage.Text = "Major Hurricane
Almost all homes destroyed
Roof falure and wall collapse
Trees and pole isolate residential areas
Power outage for possibly months
Uninhabitable for potentially months"
        End Select

        If bolIsHurricane = True Then 'Sets label depending on boolean declared in previous statement

            lblIsHurricane.Text = "Yes"
        Else
            lblIsHurricane.Text = "No"
        End If

        lblOnScale.Text = dblScale
#End Region


#Region "Hurrcane Name"

        intHurricaneName += 1 'Increments variable everytime button is pressed

        If intHurricaneName = 27 Then 'The result cannot be higher than 27, therefor must be reset
            intHurricaneName = 1
        End If

        Select Case intHurricaneName 'Determines value of char using a select case statement, originally I wanted to use a dictionary or list for this but could never figure out a way to set it up correctly
            Case 1
                chrHurricaneName = "A"
            Case 2
                chrHurricaneName = "B"
            Case 3
                chrHurricaneName = "C"
            Case 4
                chrHurricaneName = "D"
            Case 5
                chrHurricaneName = "E"
            Case 6
                chrHurricaneName = "F"
            Case 7
                chrHurricaneName = "G"
            Case 8
                chrHurricaneName = "H"
            Case 9
                chrHurricaneName = "I"
            Case 10
                chrHurricaneName = "J"
            Case 11
                chrHurricaneName = "K"
            Case 12
                chrHurricaneName = "L"
            Case 13
                chrHurricaneName = "M"
            Case 14
                chrHurricaneName = "N"
            Case 15
                chrHurricaneName = "O"
            Case 16
                chrHurricaneName = "P"
            Case 17
                chrHurricaneName = "Q"
            Case 18
                chrHurricaneName = "R"
            Case 19
                chrHurricaneName = "S"
            Case 20
                chrHurricaneName = "T"
            Case 21
                chrHurricaneName = "U"
            Case 22
                chrHurricaneName = "V"
            Case 23
                chrHurricaneName = "W"
            Case 24
                chrHurricaneName = "X"
            Case 25
                chrHurricaneName = "Y"
            Case 26
                chrHurricaneName = "Z"
        End Select

        lblName.Text = chrHurricaneName 'Changes label to value of char
#End Region

    End Sub

    Private Sub txtMPH_TextChanged(sender As Object, e As EventArgs) Handles txtMPH.TextChanged

        lblIsHurricane.Text = "?"
        lblOnScale.Text = "?"
        lblDamage.Text = "?"
        lblName.Text = "?"
    End Sub
End Class
