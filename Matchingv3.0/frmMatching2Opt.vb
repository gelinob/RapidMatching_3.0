﻿Option Explicit On
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
    Public schedCount As Integer

    Public intCondition As Integer

    Public intConditionTime As Integer
    Public TimeA As Integer
    Public TimeB As Integer
    Public TimeCountA As Integer
    Public TimeCountB As Integer
    Public TimePicA As Integer
    Public TimePicB As Integer

    Public lstCondition As New List(Of Integer)

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

        ' Set initial condition.
        intCondition = 1

        ' Hide response options until buttons pressed.
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
        If frmOptions.rdioOptionsManSched.Checked = True AndAlso frmOptions.chkbxSchedChange.Checked = True Then
            randCondition()
        ElseIf frmOptions.rdioOptionsManSched.Checked = True AndAlso frmOptions.chkbxSchedChange.Checked = False Then
            CreateConditionList()
        End If

        checkA()
        checkB()

    End Sub

    Private Sub randCondition()
        ' Generate random number representing time (in seconds) prior to schedule switch.
        intRandCond = CInt(Math.Floor(120 - 20 + 1) * Rnd()) + 20
    End Sub
    Private Sub randPicA()
        ' Generate random number representing time (in seconds) prior to changing position of A response.
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
            checkA()
            checkB()
            intConditionTime = 0
            schedCount += 1
            randCondition()
        End If
    End Sub

    Private Sub checkA()
        If intCondition = 1 Then
            'Generate a random schedule value within parameters for condition.
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
        ElseIf intCondition = 2 Then
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
        ElseIf intCondition = 3 Then
            intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
        End If
    End Sub

    Private Sub checkB()
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
            BorderStatus()
            PhaseStatus()
            TimeA += 1
            TimeB += 1
            TimePicA += 1
            TimePicB += 1
            picAPosition()
            picBPosition()
            If frmOptions.chkbxSchedChange.Checked = True Then
                intConditionTime += 1
                ConditionCheck()
            End If
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
            If barOpt2.Value = barOpt2.Maximum Then
                ' Prompt user and stop session timer.
                If frmOptions.chkbxSchedChange.Checked = True Then
                    tmr2OptMain.Enabled = False
                    MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                    Me.Close()
                ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                    MessageBox.Show("You've earned all points in this round!")
                    ManualSchedChange()
                    ProgBarReset()
                End If
            Else
                ' If the progress bar was NOT at the specified theshold...
                ' Set a new schedule value for the button.
                checkA()
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
            If barOpt2.Value = barOpt2.Maximum Then
                If frmOptions.chkbxSchedChange.Checked = True Then
                    tmr2OptMain.Enabled = False
                    MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                    Me.Close()
                ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                    MessageBox.Show("You've earned all points in this round!")
                    ManualSchedChange()
                    ProgBarReset()
                End If
            Else
                checkB()
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
            Dim OptBx As Integer = Math.Floor((grpOptB2Opt.Width - picOptA2Opt.Width) * Rnd())
            Dim OptBy As Integer = Math.Floor((grpOptB2Opt.Height - picOptB2Opt.Height) * Rnd())

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

    Private Sub BorderStatus()
        Dim rectBorder As System.Drawing.Graphics
        rectBorder = Me.grpControlBox2Opt.CreateGraphics()
        If intCondition = 1 Then
            Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Green)
            rectBorder.DrawRectangle(myPen, 1, 5, grpControlBox2Opt.Width - 3, grpControlBox2Opt.Height - 6)
        ElseIf intCondition = 2 Then
            Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Blue)
            rectBorder.DrawRectangle(myPen, 1, 5, grpControlBox2Opt.Width - 3, grpControlBox2Opt.Height - 6)
        ElseIf intCondition = 3 Then
            Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Red)
            rectBorder.DrawRectangle(myPen, 1, 5, grpControlBox2Opt.Width - 3, grpControlBox2Opt.Height - 6)
        ElseIf intcondition = 4 Then
            Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Purple)
            rectBorder.DrawRectangle(myPen, 1, 5, grpControlBox2Opt.Width - 3, grpControlBox2Opt.Height - 6)
        End If
    End Sub

    Private Sub PhaseStatus()
        If intCondition = 1 Then
            lblPhase2Opt.Text = "Phase 1"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Green
        ElseIf intCondition = 2 Then
            lblPhase2Opt.Text = "Phase 2"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Blue
        ElseIf intcondition = 3 Then
            lblPhase2Opt.Text = "Phase 3"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Red
        ElseIf intCondition = 4 Then
            lblPhase2Opt.Text = "Phase 4"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Purple
        End If
    End Sub

    Public Sub CreateConditionList()
        lstCondition.Add(1)
        lstCondition.Add(2)
        lstCondition.Add(3)
        lstCondition.Add(4)

    End Sub

    Private Sub ManualSchedChange()
        If frmOptions.chkbxOptionsRandom.Checked = True Then
            Dim intCurrentCondition As Integer = CInt(Math.Floor(4 * Rnd())) + 1
            If intCurrentCondition = 1 And Not lstCondition.contains(intCurrentCondition) Then
                intCondition = 1
                lstCondition.Remove(1)
            ElseIf intCurrentCondition = 2 And Not lstCondition.Contains(intCurrentCondition) Then
                intCondition = 2
                lstCondition.Remove(2)
            ElseIf intCurrentCondition = 3 And Not lstCondition.Contains(intCurrentCondition) Then
                intCondition = 3
                lstCondition.Remove(3)
            ElseIf intCurrentCondition = 4 And Not lstCondition.Contains(intCurrentCondition) Then
                intCondition = CInt(Math.Floor(3 * Rnd())) + 1
                lstCondition.Remove(4)
            Else
                ManualSchedChange()
            End If
        ElseIf frmOptions.chkbxOptionsRandom.Checked = False Then
            intCondition += 1
            If intCondition = 5 Then
                tmr2OptMain.Enabled = False
                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmMatching2Opt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        btnOpt2Start.Visible = True
    End Sub

    Private Sub ProgBarReset()
        If barOpt2.Value = barOpt2.Maximum Then
            barOpt2.Value = barOpt2.Minimum
        End If
    End Sub
End Class
