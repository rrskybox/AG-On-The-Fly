Public Class AGOTFform

    Private Sub AGOTFform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Upon load, hitch on to the TSX Autoguider, download and display the settings
        MsgBox(overviewmsg)

        Dim tsx_ag As Object

        Try
            tsx_ag = CreateObject("TheSkyX.ccdsoftCamera")
        Catch ex As Exception
            MsgBox("TSX Connection Error")
            Return
        End Try

        tsx_ag.Autoguider = 1
        tsx_ag.ShowAutoguider = True

        ExposureBox.Value = tsx_ag.AutoGuiderExposureTime
        AggressivenessBox.Value = tsx_ag.AutoguiderAggressiveness
        MinMoveBox.Value = tsx_ag.AutoguiderMinimumMove / 1000
        MaxMoveBox.Value = tsx_ag.AutoguiderMaximumMove / 1000
        BacklashXBox.Value = tsx_ag.AutoguiderBacklashXAxis
        BacklashYBox.Value = tsx_ag.AutoguiderBacklashYAxis

        Return

    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        'Stop AG, upload the new settings, then restart guiding

        Dim tsx_ag As Object

        Try
            tsx_ag = CreateObject("TheSkyX.ccdsoftCamera")
        Catch ex As Exception
            MsgBox("TSX Connection Error")
            Return
        End Try

        tsx_ag.Autoguider = 1
        tsx_ag.Abort()

        tsx_ag.AutoGuiderExposureTime = Convert.ToDouble(ExposureBox.Value)
        tsx_ag.AutoguiderAggressiveness = Convert.ToInt32(AggressivenessBox.Value)
        tsx_ag.AutoguiderMinimumMove = Convert.ToDouble(MinMoveBox.Value * 1000)  'Undocumented: Min move value in msecs 
        tsx_ag.AutoguiderMaximumMove = Convert.ToDouble(MaxMoveBox.Value * 1000) 'Undocumented: Max move value in msecs 
        tsx_ag.AutoguiderBacklashXAxis = Convert.ToDouble(BacklashXBox.Value * 1000)
        tsx_ag.AutoguiderBacklashYAxis = Convert.ToDouble(BacklashYBox.Value * 1000)

        Try
            Dim agstat = tsx_ag.Autoguide()
        Catch ex As Exception
            MsgBox("Autoguiding error -- check start up instructions")
        End Try

        tsx_ag = Nothing
        Return

    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'Clean up and close
        Close()
        Return
    End Sub


End Class
