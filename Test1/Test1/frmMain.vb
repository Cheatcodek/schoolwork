Public Class frmMain

    Dim value As Decimal = 96
    Dim worker As Decimal = 1
    Dim decFactory As Decimal
    Dim decAgency As Decimal
    Dim dblWorkerUpgrade As Double = 1

#Region "timers"
    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        lblValue.Text = value
        lblWorker.Text = worker
        If value >= 50 Then
            btnFactory.Visible = True
            lblInfoFactory.Visible = True
            lblInfoFactories.Visible = True
            lblFactories.Visible = True
        End If

    End Sub


    Private Sub tmrWorker_Tick(sender As Object, e As EventArgs) Handles tmrWorker.Tick
        value = value + (System.Math.Log10(worker) / (10 / dblWorkerUpgrade))
    End Sub

    Private Sub tmrFactory_Tick(sender As Object, e As EventArgs) Handles tmrFactory.Tick
        value = value + (decFactory / 2)
    End Sub


    Private Sub tmrAgency_Tick(sender As Object, e As EventArgs) Handles tmrAgency.Tick
        worker = worker + decAgency
    End Sub


#End Region

#Region "Buttons"
    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        value = value + 1
        lblValue.Text = value
        tmrRefresh.Enabled = True
    End Sub

    Private Sub btnWorker_Click(sender As Object, e As EventArgs) Handles btnWorker.Click
        If value >= 10 Then
            worker = worker + 1
            value = value - 10
            tmrWorker.Enabled = True
        End If
        lblWorker.Text = worker
    End Sub

    Private Sub btnFactory_Click(sender As Object, e As EventArgs) Handles btnFactory.Click
        If value >= 100 Then
            decFactory = decFactory + 1
            value = value - 100
            tmrFactory.Enabled = True

        End If
        lblFactories.Text = decFactory
    End Sub

    Private Sub btnAgency_Click(sender As Object, e As EventArgs) Handles btnAgency.Click
        If value >= 300 Then
            decAgency = decAgency + 1
            value = value - 300
            tmrAgency.Enabled = True

        End If
        lblAgencies.Text = decAgency
    End Sub





#End Region


#Region "Menu Strip"

    Private Sub BasicToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuUpWorkerBTools.Click

        If value >= 150 Then
            dblWorkerUpgrade = dblWorkerUpgrade + 1
            value = value - 150
            mnuUpWorkerBTools.Visible = False
        End If
    End Sub

#End Region

End Class
