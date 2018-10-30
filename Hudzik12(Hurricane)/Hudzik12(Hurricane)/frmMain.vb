Public Class frmMain



    Private Sub btnCalculation_Click(sender As Object, e As EventArgs) Handles btnCalculation.Click

        Dim dblMPH As Double
        Dim dblScale As Double
        Dim bolIsHurricane As Boolean
        Static intHurricaneName As Integer
        Dim objRandom As New Random

        If chkRandom.Checked = False Then 'If the user does not want it to be random

            dblMPH = Val(txtMPH.Text)

        Else 'Sets random number in case user has checked random
            dblMPH = objRandom.Next(60, 158)
        End If


        Select Case dblMPH
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
Uninhabiable for potentially months"
        End Select

        If bolIsHurricane = True Then

            lblIsHurricane.Text = "Yes"
        Else
            lblIsHurricane.Text = "No"
        End If

        lblOnScale.Text = dblScale



        intHurricaneName += 1



    End Sub


End Class
