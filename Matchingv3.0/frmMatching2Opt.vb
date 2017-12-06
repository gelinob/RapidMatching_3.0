Option Explicit On
Imports VB = Microsoft.VisualBasic

Public Class frmMatching2Opt

    ' ##Create variables to be used throughout the procedure##

    ' Create variables to hold VI value for various components.
    Public intRandA As Integer
    Public intRandB As Integer
    Public intRandCond As Integer
    Public intRandPicA As Integer
    Public intRandPicB As Integer

    ' Create variables to track count of various components.
    Public intCountA As Integer
    Public intCountB As Integer
    Public CODCount As Integer
    Public missCountA As Integer
    Public missCountB As Integer
    Public schedCount As Integer
    Public conditionCount As Integer

    ' Create variable to set the current condition.
    Public intCondition As Integer

    ' Create variables to track time passed for various components.
    Public intConditionTime As Integer
    Public TimeA As Integer
    Public TimeB As Integer
    Public TimeCountA As Integer
    Public TimeCountB As Integer
    Public TimePicA As Integer
    Public TimePicB As Integer

    ' Create list to hold generate FH VI values.
    Public viListA As New List(Of Long)
    Public viListB As New List(Of Long)

    ' Create list to hold condition values to prevent repetition of condition presentation.
    Public lstCondition As New List(Of Integer)

    Private Sub frmMatching2Opt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ##Events to occur when session panel first loads##

        ' Hide initial startup form.
        frmStartUp.Hide()

        ' Determine progress bar features and initialize (see sub).
        ProgBarInitialize()

        ' Hide buttons/timer prior to starting session.
        btnOpt2A.Visible = False
        btnOpt2B.Visible = False
        btnOpt2Reset.Visible = False
        lbl2OptTimer.Visible = False

        ' Hide response options until buttons pressed.
        grpOptA2Opt.Visible = False
        picOptA2Opt.Visible = False
        grpOptB2Opt.Visible = False
        picOptB2Opt.Visible = False

    End Sub

    Private Sub btnOpt2Start_Click(sender As Object, e As EventArgs) Handles btnOpt2Start.Click

        ' ##Functions that occur when session starts##

        ' Show label that holds value of timer, subsequently starting time (see sub for Tick events).
        lbl2OptTimer.Visible = True

        ' Hide start button.
        btnOpt2Start.Visible = False

        'Show functional buttons.
        btnOpt2A.Visible = True
        btnOpt2B.Visible = True

        ' Initialize VB random function and start timer.
        Randomize()
        tmr2OptMain.Enabled = True

        ' Populate condition list with appropriate condition values (see sub).
        CreateConditionList()

        ' If conditions change based on random time schedules, generate random condition length (see sub).
        If frmOptions.chkbxSchedChange.Checked = True Then
            randCondition()
        End If

        ' Set initial condition.
        SchedChange()

    End Sub

    Private Sub randCondition()
        ' Generate random number representing condition duration.
        ' ~~ Should individuals be able to set this value? ~~
        intRandCond = CInt(Math.Floor(30 - 10 + 1) * Rnd()) + 10
    End Sub
    Private Sub randPicA()
        ' Generate random number representing time (in seconds) prior to changing position of A response.
        intRandPicA = CInt(Math.Floor(8 - 2 + 1) * Rnd()) + 2
    End Sub
    Private Sub randPicB()
        ' Generate random number representing time (in seconds) prior to changing position of B response.
        intRandPicB = CInt(Math.Floor(8 - 2 + 1) * Rnd()) + 2
    End Sub

    Private Sub ConditionTimeCheck()
        ' If the condition time meets the random thresholdfor change:
        If intConditionTime >= intRandCond Then
            ' Update current condition
            SchedChange()
            ' Update schedules based on new condition
            SchedValuesA()
            SchedValuesB()
            ' Reset current elapsed time to zero.
            intConditionTime = 0
            ' Update count of schedule changes.
            schedCount += 1
            ' Generate new random length for selected condition.
            randCondition()
        End If
    End Sub

    Private Sub SchedValuesA()
        ' Update schedule values for button depending on condition and type of schedule generation.
        If frmOptions.rdioOptionsManSched.Checked = True Then
            If intCondition = 1 Then
                'Generate a random schedule value within parameters for condition.
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
            ElseIf intCondition = 2 Then
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
            ElseIf intCondition = 3 Then
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
            ElseIf intCondition = 4 Then
                Condition4()
            End If
        ElseIf frmOptions.rdioOptionsAutoSched.Checked = True Then
            Dim randVI_A As New Integer
            Dim viValue_A As New Long

            ' Randomly select one of the FH values from the option A list. Remove that value to prevent repetition.
            randVI_A = CInt(Math.Floor((viListA.Count - 1) * Rnd())) 'Minimum is zero, maximum is (range - 1)
            viValue_A = viListA.Item(randVI_A)
            intRandA = viValue_A
            viListA.Remove(viValue_A)

        End If
    End Sub

    Private Sub SchedValuesB()
        If frmOptions.rdioOptionsManSched.Checked = True Then
            If intCondition = 1 Then
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
            ElseIf intCondition = 2 Then
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
            ElseIf intCondition = 3 Then
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) * CInt(frmOptions.txtOptSchedBMin.Text)
            ElseIf intCondition = 4 Then
                Condition4()
            End If
        ElseIf frmOptions.rdioOptionsAutoSched.Checked = True Then
            Dim randVI_B As New Integer
            Dim viValue_B As New Long

            randVI_B = CInt(Math.Floor((viListB.Count - 1) * Rnd()))
            viValue_B = viListB.Item(randVI_B)
            intRandB = viValue_B
            viListB.Remove(viValue_B)

        End If
    End Sub

    Private Sub btnOpt2A_Click(sender As Object, e As EventArgs) Handles btnOpt2A.Click
        ' If button is selected, hide both buttons and reveal response item for selected side. Make COD button visible.
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
        ' If the log is visible, hide it.
        If frmOpt2Log.Visible = True Then
            frmOpt2Log.Hide()
            ' If the log is hidden, show it.
        ElseIf frmOpt2Log.Visible = False Then
            frmOpt2Log.Show()
        End If
    End Sub

    Private Sub tmr2OptMain_Tick(sender As Object, e As EventArgs) Handles tmr2OptMain.Tick
        ' If COD NOT in effect:
        If frmCODOpt2.tmrCODOpt2.Enabled = False Then
            ' Update border based on condition number.
            BorderStatus()
            ' Update phase label text and color based on condition number.
            PhaseStatus()
            ' Increase value of variables recording time.
            TimeA += 1
            TimeB += 1
            TimePicA += 1
            TimePicB += 1
            ' Update location of picture response options based on randomly selected locations (see sub).
            picAPosition()
            picBPosition()
            ' If schedules set to change based on random timer:
            If frmOptions.chkbxSchedChange.Checked = True Then
                ' Increase value of variable recording condition time elapsed.
                intConditionTime += 1
                ' Check to determine time elapsed relative to preset condition duration.
                ConditionTimeCheck()
            End If
        End If

        ' If only one button is enabled, and thus an option has been selected, initialize timer to record time allocated to each response option.
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
        ' Increase value of variable recording number of responses on picture response option.
        intCountA += 1
        ' If VI schedule satisfied:
        If TimeA >= intRandA Then
            ' Document time at which the reinforcer is earned.
            frmOpt2Log.DocumentA()
            ' Advance the progress bar in the correct direction.
            If frmOptions.chkbxBackCount.Checked = False Then
                barOpt2.Value += 1
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                barOpt2.Value -= 1
            End If
            ' If the progress bar is at the specified threshold for counting up:
            If frmOptions.chkbxBackCount.Checked = False Then
                If barOpt2.Value = barOpt2.Maximum Then
                    ' Stop session timer.
                    tmr2OptMain.Enabled = False
                    ' If items remain on the condition list
                    If lstCondition.Count > 0 Then
                        ' Show blackout form (see form).
                        frmBlackOutOpt2.ShowDialog()
                        ' Else if all conditions have been presented.
                    ElseIf lstCondition.Count = 0 Then
                        ' Prompt user and end condition.
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    End If
                    ' If the progress bar is NOT at the threshold, update schedule value and reset current time elapsed to zero.
                Else
                    SchedValuesA()
                    TimeA = 0
                End If
                ' Same procedure as above, but for progress bar counting down.
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                If barOpt2.Value = barOpt2.Minimum Then
                    tmr2OptMain.Enabled = False
                    If lstCondition.Count > 0 Then
                        frmBlackOutOpt2.ShowDialog()
                    ElseIf lstCondition.Count = 0 Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    End If
                Else
                    SchedValuesA()
                    TimeA = 0
                End If
            End If
        End If
    End Sub

    Private Sub picOptB2Opt_Click(sender As Object, e As EventArgs) Handles picOptB2Opt.Click
        intCountB += 1
        If TimeB >= intRandB Then
            frmOpt2Log.DocumentB()
            If frmOptions.chkbxBackCount.Checked = False Then
                barOpt2.Value += 1
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                barOpt2.Value -= 1
            End If
            If frmOptions.chkbxBackCount.Checked = False Then
                If barOpt2.Value = barOpt2.Maximum Then
                    tmr2OptMain.Enabled = False
                    If lstCondition.Count > 0 Then
                        frmBlackOutOpt2.ShowDialog()
                    ElseIf lstCondition.Count = 0 Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    End If
                Else
                    SchedValuesB()
                    TimeB = 0
                End If
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                If barOpt2.Value = barOpt2.Minimum Then
                    tmr2OptMain.Enabled = False
                    If lstCondition.Count > 0 Then
                        frmBlackOutOpt2.ShowDialog()
                    ElseIf lstCondition.Count = 0 Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    End If

                Else
                    SchedValuesB()
                    TimeB = 0
                End If
            End If
        End If
    End Sub

    Private Sub picA_FHSched()
        ' ##Function generates FH values and populates respective list.##

        ' Clear any existing values from list.
        viListA.Clear()

        ' Create variables to represent those in the FH equation.
        Dim viProbA As New Integer 'P
        Dim viIntA As New Integer 'n
        Dim viCountA As New Integer 'N

        ' Set value recording the number of values generated to 1. See below.
        viIntA = 1

        ' Depending on the current condition, set equation values to those specified in options form.
        If intCondition = 1 Then
            viCountA = CInt(frmSchedules.txtIntOptAPh1.Text)
            viProbA = CInt(frmSchedules.txtVIOptAPh1.Text)
        ElseIf intCondition = 2 Then
            viCountA = CInt(frmSchedules.txtIntOptAPh2.Text)
            viProbA = CInt(frmSchedules.txtVIOptAPh2.Text)
        ElseIf intCondition = 3 Then
            viCountA = CInt(frmSchedules.txtIntOptAPh3.Text)
            viProbA = CInt(frmSchedules.txtVIOptAPh3.Text)
        ElseIf intCondition = 4 Then
            Condition4()
            Exit Sub
        End If

        ' As long as the number of items created is less than or equal to the desired number, run the components of the equation to generate values, then add them to list
        Do While viIntA <= viCountA
            If viIntA = viCountA Then
                Dim viValue As Long = viProbA * (1 + Math.Log(viCountA))
                viListA.Add(viValue)
                Debug.Print(viValue)
                viIntA += 1
            Else
                Dim viValue As Long = viProbA * (1 + Math.Log(viCountA) + (viCountA - viIntA) * Math.Log(viCountA - viIntA) - (viCountA - viIntA + 1) * Math.Log(viCountA - viIntA + 1))
                viListA.Add(viValue)
                Debug.Print(viValue)
                viIntA += 1
            End If

        Loop


    End Sub
    Private Sub picB_FHSched()

        viListB.Clear()

        Dim viProbB As New Integer 'P
        Dim viIntB As New Integer 'n
        Dim viCountB As New Integer 'N

        viIntB = 1
        If intCondition = 1 Then
            viCountB = CInt(frmSchedules.txtIntOptBPh1.Text)
            viProbB = CInt(frmSchedules.txtVIOptBPh1.Text)
        ElseIf intCondition = 2 Then
            viCountB = CInt(frmSchedules.txtIntOptBPh2.Text)
            viProbB = CInt(frmSchedules.txtVIOptBPh2.Text)
        ElseIf intCondition = 3 Then
            viCountB = CInt(frmSchedules.txtIntOptBPh3.Text)
            viProbB = CInt(frmSchedules.txtVIOptBPh3.Text)
        ElseIf intCondition = 4 Then
            Condition4()
            Exit Sub
        End If

        Do While viIntB <= viCountB
            If viIntB = viCountB Then
                Dim viValue As Long = viProbB * (1 + Math.Log(viCountB))
                viListB.Add(viValue)
                Debug.Print(viValue)
                viIntB += 1
            Else
                Dim viValue As Long = viProbB * (1 + Math.Log(viCountB) + (viCountB - viIntB) * Math.Log(viCountB - viIntB) - (viCountB - viIntB + 1) * Math.Log(viCountB - viIntB + 1))
                viListB.Add(viValue)
                Debug.Print(viValue)
                viIntB += 1
            End If

        Loop


    End Sub

    Private Sub picAPosition()
        ' If the randomly generated duration of picture location reaches the threshold:
        If TimePicA >= intRandPicA Then
            ' Create new random values for X and Y coordinates (upper left corner) that are constrained to the group box container.
            Dim OptAx As Integer = Math.Floor((grpOptA2Opt.Width - picOptA2Opt.Width) * Rnd())
            Dim OptAy As Integer = Math.Floor((grpOptA2Opt.Height - picOptB2Opt.Height) * Rnd())

            ' Set picture location to new coordinates.
            picOptA2Opt.Left = OptAx
            picOptA2Opt.Top = OptAy

            ' Reset timer and generate new duration for current picture response option location.
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
        ' If the user misses the picture response option and clicks the group box background instead, increase miss count by 1.
        missCountA += 1
    End Sub

    Private Sub grpOptB2Opt_Click(sender As Object, e As EventArgs) Handles grpOptB2Opt.Click
        missCountB += 1
    End Sub

    Private Sub BorderStatus()
        ' ##Creates a colored border around the greater group box that corresponds to the current condition. Refreshed every timer tick.##
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
        ElseIf intCondition = 4 Then
            Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Purple)
            rectBorder.DrawRectangle(myPen, 1, 5, grpControlBox2Opt.Width - 3, grpControlBox2Opt.Height - 6)
        End If
    End Sub

    Private Sub PhaseStatus()
        ' ##Changes the text and color of the phase label, depending on the current condition. Updates every timer tick.##
        If intCondition = 1 Then
            lblPhase2Opt.Text = "Phase 1"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Green
        ElseIf intCondition = 2 Then
            lblPhase2Opt.Text = "Phase 2"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Blue
        ElseIf intCondition = 3 Then
            lblPhase2Opt.Text = "Phase 3"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Red
        ElseIf intCondition = 4 Then
            lblPhase2Opt.Text = "Phase 4"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Purple
        End If
    End Sub

    Public Sub CreateConditionList()
        ' ##Generates values for each condition and adds them to a list, to be pulled from in later events.##
        lstCondition.Add("1")
        lstCondition.Add("2")
        lstCondition.Add("3")
        lstCondition.Add("4")

    End Sub

    Public Sub SchedChange()
        ' ##Updates the condition based on the selected method of progression.##

        ' If conditions are to progress in random order:
        If frmOptions.chkbxOptionsRandom.Checked = True Then
            ' Generate a random value between 1 and 4
            Dim intCurrentCondition As Integer = CInt(Math.Floor(4 * Rnd())) + 1
            ' If the list contains the selected number:
            If lstCondition.Contains("1") = True AndAlso intCurrentCondition = 1 Then
                ' Set the current condition to that value.
                intCondition = 1
                ' Remove the value from the list to prevent future repetition.
                lstCondition.Remove("1")
                ' Increase the count of condition changes by 1.
                conditionCount += 1
                ' If values are generated automatically:
                If frmOptions.rdioOptionsAutoSched.Checked = True Then
                    ' Initiate FH value generation.
                    picA_FHSched()
                    picB_FHSched()
                End If
            ElseIf lstCondition.Contains("2") = True AndAlso intCurrentCondition = 2 Then
                intCondition = 2
                lstCondition.Remove("2")
                conditionCount += 1
                If frmOptions.rdioOptionsAutoSched.Checked = True Then
                    picA_FHSched()
                    picB_FHSched()
                End If
            ElseIf lstCondition.Contains("3") = True AndAlso intCurrentCondition = 3 Then
                intCondition = 3
                lstCondition.Remove("3")
                conditionCount += 1
                If frmOptions.rdioOptionsAutoSched.Checked = True Then
                    picA_FHSched()
                    picB_FHSched()
                End If
            ElseIf lstCondition.Contains("4") = True AndAlso intCurrentCondition = 4 Then
                Condition4()
            Else
                ' If the generated value has already been used, generate new value.
                SchedChange()
            End If
        ElseIf frmOptions.chkbxOptionsRandom.Checked = False Then
            ' If conditions do NOT progress in a random order, advance to the next numerically-valued condition.
            intCondition += 1
            ' If condition count reaches 5, stop the timer, prompt the user, and end the session
            If intCondition = 5 Then
                tmr2OptMain.Enabled = False
                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                Me.Close()
            End If
            ' If schedules are automatically generated, initiate respective subs.
            If frmOptions.rdioOptionsAutoSched.Checked = True Then
                picA_FHSched()
                picB_FHSched()
            End If
        End If

        ' Update schedule values based on selected condition.
        SchedValuesA()
        SchedValuesB()

        If conditionCount = 5 Then
            ' If 4 conditions have passed, stop timer, prompt user, and end session.
            tmr2OptMain.Enabled = False
            MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
            Me.Close()
        End If
    End Sub

    Private Sub frmMatching2Opt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' When closing session window, show the startup form and reset session form.
        frmStartUp.Show()
        Me.Dispose()
    End Sub

    Public Sub ProgBarInitialize()
        ' ##Sets progress bar paramters according to selected options.##
        If frmOptions.chkbxBackCount.Checked = False Then
            barOpt2.Minimum = 0
            barOpt2.Maximum = CInt(frmOptions.txtbxOptionsBarValue.Text)
            barOpt2.Value = barOpt2.Minimum
        ElseIf frmOptions.chkbxBackCount.Checked = True Then
            barOpt2.Minimum = 0
            barOpt2.Maximum = CInt(frmOptions.txtbxOptionsBarValue.Text)
            barOpt2.Value = barOpt2.Maximum
        End If

        ' Make bar visible.
        barOpt2.Visible = True
    End Sub

    Private Sub Condition4()
        ' ##Randomly selects a condition of options 1-3 to implement on condition 4.

        ' Set condition to value of 4.
        intCondition = 4

        ' If not progressing sequentially, removes condition 4 from list.
        If frmOptions.chkbxOptionsRandom.Checked = True Then
            lstCondition.Remove("4")
        End If

        ' Create a random variable set to value 1-3
        Dim varCond As Integer = CInt(Math.Floor(3 * Rnd())) + 1

        ' If schedules are manually set, do so according to random variable selected (above).
        If frmOptions.rdioOptionsManSched.Checked = True Then
            If varCond = 1 Then
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
            ElseIf intCondition = 2 Then
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedBMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedAMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedAMin.Text)
            ElseIf intCondition = 3 Then
                intRandA = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) + CInt(frmOptions.txtOptSchedBMin.Text)
                intRandB = CInt(Math.Floor(((CInt(frmOptions.txtOptSchedAMax.Text)) - (CInt(frmOptions.txtOptSchedBMin.Text)) + 1) * Rnd())) * CInt(frmOptions.txtOptSchedBMin.Text)
            End If
            ' If schedules are automatically generated, create values and populate lists for A and B according to random variable selected (above).
        ElseIf frmOptions.rdioOptionsAutoSched.Checked = True Then
            viListA.Clear()
            viListB.Clear()

            Dim viProbA As New Integer 'P
            Dim viProbB As New Integer
            Dim viIntA As New Integer 'n
            Dim viIntB As New Integer
            Dim viCountA As New Integer 'N
            Dim viCountB As New Integer

            Dim randomSched As Integer = CInt(Math.Floor(3 * Rnd())) + 1

            viIntA = 1
            viIntB = 1

            If randomSched = 1 Then
                viCountA = CInt(frmSchedules.txtIntOptAPh1.Text)
                viProbA = CInt(frmSchedules.txtVIOptAPh1.Text)
                viCountB = CInt(frmSchedules.txtIntOptBPh1.Text)
                viProbB = CInt(frmSchedules.txtVIOptBPh1.Text)
            ElseIf randomSched = 2 Then
                viCountA = CInt(frmSchedules.txtIntOptAPh2.Text)
                viProbA = CInt(frmSchedules.txtVIOptAPh2.Text)
                viCountB = CInt(frmSchedules.txtIntOptBPh2.Text)
                viProbB = CInt(frmSchedules.txtVIOptBPh2.Text)
            ElseIf randomSched = 3 Then
                viCountA = CInt(frmSchedules.txtIntOptAPh3.Text)
                viProbA = CInt(frmSchedules.txtVIOptAPh3.Text)
                viCountB = CInt(frmSchedules.txtIntOptBPh3.Text)
                viProbB = CInt(frmSchedules.txtVIOptBPh3.Text)
            End If
            Do While viIntA <= viCountA
                If viIntA = viCountA Then
                    Dim viValue As Long = viProbA * (1 + Math.Log(viCountA))
                    viListA.Add(viValue)
                    Debug.Print(viValue)
                    viIntA += 1
                Else
                    Dim viValue As Long = viProbA * (1 + Math.Log(viCountA) + (viCountA - viIntA) * Math.Log(viCountA - viIntA) - (viCountA - viIntA + 1) * Math.Log(viCountA - viIntA + 1))
                    viListA.Add(viValue)
                    Debug.Print(viValue)
                    viIntA += 1
                End If

            Loop

            Do While viIntB <= viCountB
                If viIntB = viCountB Then
                    Dim viValue As Long = viProbB * (1 + Math.Log(viCountB))
                    viListB.Add(viValue)
                    Debug.Print(viValue)
                    viIntB += 1
                Else
                    Dim viValue As Long = viProbB * (1 + Math.Log(viCountB) + (viCountB - viIntB) * Math.Log(viCountB - viIntB) - (viCountB - viIntB + 1) * Math.Log(viCountB - viIntB + 1))
                    viListB.Add(viValue)
                    Debug.Print(viValue)
                    viIntB += 1
                End If

            Loop
        End If
    End Sub

    Private Sub frmMatching2Opt_Move(sender As Object, e As EventArgs) Handles Me.Move
        ' If the log from is visible, set location to left side of session form.
        If frmOpt2Log.Visible = True Then
            frmOpt2Log.Location = New Point(Me.Left - frmOpt2Log.Width, Me.Top)
        End If
    End Sub
End Class
