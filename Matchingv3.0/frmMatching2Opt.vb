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
    Public schedCount As Integer
    Public conditionCount As Integer

    Public intCondition As Integer

    Public intConditionTime As Integer
    Public TimeA As Integer
    Public TimeB As Integer
    Public TimeCountA As Integer
    Public TimeCountB As Integer
    Public TimePicA As Integer
    Public TimePicB As Integer

    Public viListA As New List(Of Long)
    Public viListB As New List(Of Long)

    Public lstCondition As New List(Of Integer)

    Private Sub frmMatching2Opt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmStartUp.Hide()

        ' Determine progress bar length and starting place.
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
        'Show functional buttons after start of session.
        btnOpt2A.Visible = True
        btnOpt2B.Visible = True
        lbl2OptTimer.Visible = True

        ' Hide start button.
        btnOpt2Start.Visible = False

        ' Initial VB random function (for VI schedules) and start timer.
        Randomize()
        tmr2OptMain.Enabled = True

        CreateConditionList()

        ' Call random number generation functions (below).
        If frmOptions.rdioOptionsManSched.Checked = True AndAlso frmOptions.chkbxSchedChange.Checked = True Then
            randCondition()
        End If

        ' Set initial condition.
        If frmOptions.chkbxOptionsRandom.Checked = True Then
            SchedChange()
        Else
            intCondition = 1
        End If

        If frmOptions.rdioOptionsAutoSched.Checked = True Then
            picA_FHSched()
            picB_FHSched()
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

            randVI_A = CInt(Math.Floor((viListA.Count - 1) * Rnd())) 'Minimum is zero, maximum is (range - 1)
            Debug.Print(randVI_A & " " & viListA.Count)
            viValue_A = viListA.Item(randVI_A)
            intRandA = viValue_A
            viListA.Remove(viValue_A)

        End If
    End Sub

    Private Sub checkB()
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
            Debug.Print(randVI_B)
            viValue_B = viListB.Item(randVI_B)
            intRandB = viValue_B
            viListB.Remove(viValue_B)

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
        If frmOpt2Log.Visible = True Then
            frmOpt2Log.Hide()
        ElseIf frmOpt2Log.Visible = False Then
            frmOpt2Log.Show()
        End If
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
            frmOpt2Log.DocumentA()
            ' Advance the progress bar.
            If frmOptions.chkbxBackCount.Checked = False Then
                barOpt2.Value += 1
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                barOpt2.Value -= 1
            End If
            ' If the progress bar is at the specified threshold...
            If frmOptions.chkbxBackCount.Checked = False Then
                If barOpt2.Value = barOpt2.Maximum Then
                    ' Prompt user and stop session timer.
                    tmr2OptMain.Enabled = False
                    ' If on a time-based interval:
                    If frmOptions.chkbxSchedChange.Checked = True Then
                        If frmOptions.chkbxOptionsRandom.Checked Then
                            MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                            Me.Close()
                            ' if on a ratio schedule:
                        End If
                    ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                        If frmOptions.chkbxOptionsRandom.Checked = False Then
                            If intCondition = 4 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        ElseIf frmOptions.chkbxOptionsRandom.Checked = True Then
                            If lstCondition.Count > 0 Then
                                frmBlackOutOpt2.ShowDialog()
                            ElseIf lstCondition.Count = 0 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        End If
                    Else
                        checkA()
                        TimeA = 0
                    End If
                End If
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                If barOpt2.Value = barOpt2.Minimum Then
                    tmr2OptMain.Enabled = False
                    If frmOptions.chkbxSchedChange.Checked = True Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                        If frmOptions.chkbxOptionsRandom.Checked = False Then
                            If intCondition = 4 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        ElseIf frmOptions.chkbxOptionsRandom.Checked = True Then
                            If lstCondition.Count > 0 Then
                                frmBlackOutOpt2.ShowDialog()
                            ElseIf lstCondition.Count = 0 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        End If
                    End If
                Else
                    checkA()
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
                    If frmOptions.chkbxSchedChange.Checked = True Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                        If frmOptions.chkbxOptionsRandom.Checked = False Then
                            If intCondition = 4 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        ElseIf frmOptions.chkbxOptionsRandom.Checked = True Then
                            If lstCondition.Count > 0 Then
                                frmBlackOutOpt2.ShowDialog()
                            ElseIf lstCondition.Count = 0 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        End If
                    End If
                Else
                    checkB()
                    TimeB = 0
                End If
            ElseIf frmOptions.chkbxBackCount.Checked = True Then
                If barOpt2.Value = barOpt2.Minimum Then
                    tmr2OptMain.Enabled = False
                    If frmOptions.chkbxSchedChange.Checked = True Then
                        MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                        Me.Close()
                    ElseIf frmOptions.chkbxSchedChange.Checked = False Then
                        If frmOptions.chkbxOptionsRandom.Checked = False Then
                            If intCondition = 4 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        ElseIf frmOptions.chkbxOptionsRandom.Checked = True Then
                            If lstCondition.Count > 0 Then
                                frmBlackOutOpt2.ShowDialog()
                            ElseIf lstCondition.Count = 0 Then
                                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
                                Me.Close()
                            End If
                        End If
                    End If
                Else
                    checkB()
                    TimeB = 0
                End If
            End If
        End If
    End Sub

    Private Sub picA_FHSched()

        viListA.Clear()

        Dim viProbA As New Integer 'P
        Dim viIntA As New Integer 'n
        Dim viCountA As New Integer 'N

        viIntA = 1

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
        ElseIf intCondition = 4 Then
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
        ElseIf intCondition = 3 Then
            lblPhase2Opt.Text = "Phase 3"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Red
        ElseIf intCondition = 4 Then
            lblPhase2Opt.Text = "Phase 4"
            lblPhase2Opt.ForeColor = System.Drawing.Color.Purple
        End If
    End Sub

    Public Sub CreateConditionList()
        lstCondition.Add("1")
        lstCondition.Add("2")
        lstCondition.Add("3")
        lstCondition.Add("4")

    End Sub

    Public Sub SchedChange()
        If frmOptions.chkbxOptionsRandom.Checked = True Then
            Dim intCurrentCondition As Integer = CInt(Math.Floor(4 * Rnd())) + 1
            Debug.Print("Rand # " & intCurrentCondition)
            If lstCondition.Contains("1") = True AndAlso intCurrentCondition = 1 Then
                intCondition = 1
                lstCondition.Remove("1")
                conditionCount += 1
                If frmOptions.rdioOptionsAutoSched.Checked = True Then
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
                SchedChange()
            End If
        ElseIf frmOptions.chkbxOptionsRandom.Checked = False Then
            intCondition += 1
            If intCondition = 5 Then
                tmr2OptMain.Enabled = False
                MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
        Me.Close()
            End If
            picA_FHSched()
            picB_FHSched()
        End If
        checkA()
        checkB()

        If conditionCount = 5 Then
            tmr2OptMain.Enabled = False
            MessageBox.Show("You've earned all points! Time to completion: " & lbl2OptTimer.Text & " s", "Nice Work!", 0)
            Me.Close()
        End If
    End Sub

    Private Sub frmMatching2Opt_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tmr2OptMain.Enabled = False
        btnOpt2Start.Show()
        frmStartUp.Show()
        Me.Dispose()
    End Sub

    Public Sub ProgBarInitialize()
        If frmOptions.chkbxBackCount.Checked = False Then
            barOpt2.Minimum = 0
            barOpt2.Maximum = CInt(frmOptions.txtbxOptionsBarValue.Text)
            barOpt2.Value = barOpt2.Minimum
        ElseIf frmOptions.chkbxBackCount.Checked = True Then
            barOpt2.Minimum = 0
            barOpt2.Maximum = CInt(frmOptions.txtbxOptionsBarValue.Text)
            barOpt2.Value = barOpt2.Maximum
        End If

        barOpt2.Visible = True
    End Sub

    Private Sub Condition4()

        intCondition = 4

        If frmOptions.chkbxOptionsRandom.Checked = True Then
            lstCondition.Remove("4")
        End If

        Dim varCond As Integer = CInt(Math.Floor(3 * Rnd())) + 1

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

End Class
