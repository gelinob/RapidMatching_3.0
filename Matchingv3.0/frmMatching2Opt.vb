Option Explicit On
Imports VB = Microsoft.VisualBasic

Public Class frmMatching2Opt

    Public intRandA As Integer
    Public intRandB As Integer
    Public intRandCond As Integer
    Public intRandPicA As Integer
    Public intRandPicB As Integer

    Public intCountA As Integer
    Public intCountB As Integer
    Public CODCount As Integer
    Public missCountA As Integer
    Public missCountB As Integer

    Public intCondition As Integer

    Public intConditionTime As Integer
    Public TimeA As Integer
    Public TimeB As Integer
    Public TimeCountA As Integer
    Public TimeCountB As Integer
    Public TimePicA As Integer
    Public TimePicB As Integer


    Private Sub frmMatching2Opt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Determine progress bar length and starting place.
        barOpt2.Minimum = 0
        barOpt2.Maximum = CInt(frmStartUp.txtPtsReq.Text)
        barOpt2.Visible = True
        barOpt2.Value = barOpt2.Minimum

        ' Hide buttons/timer prior to starting session.
        btnOpt2A.Visible = False
        btnOpt2B.Visible = False
        btnOpt2Reset.Visible = False
        lbl2OptTimer.Visible = False

        intCondition = 1

        grpOptA2Opt.Visible = False
        picOptA2Opt.Visible = False
        grpOptB2Opt.Visible = False
        picOptB2Opt.Visible = False

    End Sub

    Private Sub btnOpt2Start_Click(sender As Object, e As EventArgs) Handles btnOpt2Start.Click
        'Show functional buttons after start of session.
        btnOpt2A.Visible = True
        btnOpt2B.Visible = True
        lbl2OptTimer.Visible = True

        ' Hide start button.
        btnOpt2Start.Visible = False

        ' Initial VB random function (for VI schedules) and start timer.
        Randomize()
        tmr2OptMain.Enabled = True

        ' Call random number generation functions (below).
        randCondition()
        randNumbA()
        randNumbB()

    End Sub

    Private Sub randCondition()
        ' Generate random number representing time (in seconds) prior to schedule switch.
        intRandCond = CInt(Math.Floor(120 - 20 + 1) * Rnd()) + 20
    End Sub
    Private Sub randPicA()
        ' Generate random number representing time (in seconds) prior to changing positing of A response.
        intRandPicA = CInt(Math.Floor(8 - 2 + 1) * Rnd()) + 2
    End Sub
    Private Sub randPicB()
        ' Generate random number representing time (in seconds) prior to changing position of B response.
        intRandPicB = CInt(Math.Floor(8 - 2 + 1) * Rnd()) + 2
    End Sub

    Private Sub ConditionCheck()
        ' If the random condition timer is beyond the random value threshold, pick new random condition and reset schedule values.
        If intConditionTime >= intRandCond Then
            intCondition = CInt(Math.Floor(3 * Rnd())) + 1
            intCondition = Int(Rnd() * 3) + 1
            randNumbA()
            randNumbB()
            intConditionTime = 0
            randCondition()
        End If
    End Sub

    Private Sub randNumbA()
        If intCondition = 1 Then
            'Generate a random schedule value within parameters for condition.
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
        ElseIf intCondition = 2 Then
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
        ElseIf intCondition = 3 Then
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
        End If
    End Sub

    Private Sub randNumbB()
        If intCondition = 1 Then
            intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
        ElseIf intCondition = 2 Then
            intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
        ElseIf intCondition = 3 Then
            intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) * CInt(frmOptions.txtOptSchedBMin.Text)
        End If
    End Sub

    Private Sub btnOpt2A_Click(sender As Object, e As EventArgs) Handles btnOpt2A.Click
        btnOpt2A.Visible = False
        btnOpt2B.Visible = False
        grpOptA2Opt.Visible = True
        picOptA2Opt.Visible = True
        btnOpt2Reset.Visible = True
    End Sub

    Private Sub btnOpt2B_Click(sender As Object, e As EventArgs) Handles btnOpt2B.Click
        btnOpt2B.Visible = False
        btnOpt2A.Visible = False
        grpOptB2Opt.Visible = True
        picOptB2Opt.Visible = True
        btnOpt2Reset.Visible = True
    End Sub

    Private Sub btnOpt2Log_Click(sender As Object, e As EventArgs) Handles btnOpt2Log.Click
        frmOpt2Log.Show()

    End Sub

    Private Sub tmr2OptMain_Tick(sender As Object, e As EventArgs) Handles tmr2OptMain.Tick
        ' If COD NOT in effect, run schedule timers.
        If frmCODOpt2.tmrCODOpt2.Enabled = False Then
            TimeA += 1
            TimeB += 1
            intConditionTime += 1
            TimePicA += 1
            TimePicB += 1
            ConditionCheck()
            picAPosition()
            picBPosition()
        End If

        ' If only one button is enabled, and thus an option has been selected, initial timer to record time allocated to each response option.
        If grpOptA2Opt.Visible = True And grpOptB2Opt.Visible = False Then
            TimeCountA += 1
        ElseIf grpOptB2Opt.Visible = True And grpOptA2Opt.Visible = False Then
            TimeCountB += 1
        End If

        ' If timer label is visible (i.e., session begun), begin recording session length.
        If lbl2OptTimer.Visible = True Then
            lbl2OptTimer.Text = Val(lbl2OptTimer.Text) + 1
        End If
    End Sub

    Private Sub btnOpt2Reset_Click(sender As Object, e As EventArgs) Handles btnOpt2Reset.Click
        ' Initiate COD, add to COD count, and hide COD button.
        CODCount += 1
        frmCODOpt2.ShowDialog()
        btnOpt2Reset.Visible = False
    End Sub

    Private Sub picOptA2Opt_Click(sender As Object, e As EventArgs) Handles picOptA2Opt.Click
        intCountA += 1
        ' If amount of time specified with random integer has passed...
        If TimeA >= intRandA Then
            ' Document time at which the point was earned.
            frmOpt2Log.lstOptA2Opt.Items.Insert(0, lbl2OptTimer.Text)
            ' Advance the progress bar.
            barOpt2.Value += 1
            ' If the progress bar is at the specified threshold...
            If barOpt2.Value > (CInt(frmStartUp.txtPtsReq.Text) - 1) Then
                ' Prompt user and stop session timer.
                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                tmr2OptMain.Enabled = False
            Else
                ' If the progress bar was NOT at the specified theshold...
                ' Set a new schedule value for the button.
                randNumbA()
                ' Reset the button's timer.
                TimeA = 0
            End If
        End If
    End Sub

    Private Sub picOptB2Opt_Click(sender As Object, e As EventArgs) Handles picOptB2Opt.Click
        intCountB += 1
        If TimeB >= intRandB Then
            frmOpt2Log.lstOptB2Opt.Items.Insert(0, lbl2OptTimer.Text)
            barOpt2.Value += 1
            If barOpt2.Value > (CInt(frmStartUp.txtPtsReq.Text) - 1) Then
                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                tmr2OptMain.Enabled = False
            Else
                randNumbB()
                TimeB = 0
            End If
        End If
    End Sub

    Private Sub picAPosition()
        If TimePicA >= intRandPicA Then
            Dim OptAx As Integer = Math.Floor((grpOptA2Opt.Width - picOptA2Opt.Width) * Rnd())
            Dim OptAy As Integer = Math.Floor((grpOptA2Opt.Height - picOptB2Opt.Height) * Rnd())

            picOptA2Opt.Left = OptAx
            picOptA2Opt.Top = OptAy

            TimePicA = 0
            randPicA()
        End If
    End Sub

    Private Sub picBPosition()
        If TimePicB >= intRandPicB Then
            Dim OptBx As Integer = Math.Floor((grpOptB2Opt.Width - 2) * Rnd())
            Dim OptBy As Integer = Math.Floor((grpOptB2Opt.Height - 2) * Rnd())

            picOptB2Opt.Left = OptBx
            picOptB2Opt.Top = OptBy

            TimePicB = 0
            randPicB()
        End If
    End Sub

    Private Sub grpOptA2Opt_Click(sender As Object, e As EventArgs) Handles grpOptA2Opt.Click
        missCountA += 1
    End Sub

    Private Sub grpOptB2Opt_Click(sender As Object, e As EventArgs) Handles grpOptB2Opt.Click
        missCountB += 1
    End Sub
End Class
