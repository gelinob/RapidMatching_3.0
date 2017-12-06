Public Class frmOpt2Log
    Private Sub frmOpt2Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmMatching2Opt.Left - Me.Width, frmMatching2Opt.Top)
        ' Begin timer for regular "count" updates.
        tmrLog2Opt.Enabled = True
    End Sub
    Public Sub RecountOpt2()
        ' Record number of clicks toward each response option.
        txtCountOptA2Opt.Text = CStr(frmMatching2Opt.intCountA)
        txtCountOptB2Opt.Text = CStr(frmMatching2Opt.intCountB)
    End Sub
    Private Sub SchedulesOpt2()
        ' Record schedule requirements for each response option.
        txtSchedOptA2Opt.Text = CStr(frmMatching2Opt.intRandA)
        txtSchedOptB2Opt.Text = CStr(frmMatching2Opt.intRandB)
    End Sub
    Public Sub TimerLogOpt2()
        ' Record time spent responding to each response option.
        txtTimerOptA2Opt.Text = CStr(frmMatching2Opt.TimeA)
        txtTimerOptB2Opt.Text = CStr(frmMatching2Opt.TimeB)
    End Sub

    Public Sub DocumentA()
        ' Record the session time at which each reinforcer is earned.
        lstOptA2Opt.Items.Insert(0, "Phase " & CStr(frmMatching2Opt.intCondition) & " || Point " & CStr(frmMatching2Opt.barOpt2.Value + 1) & " || " & frmMatching2Opt.lbl2OptTimer.Text & " sec.")
    End Sub

    Public Sub DocumentB()
        lstOptB2Opt.Items.Insert(0, "Phase " & CStr(frmMatching2Opt.intCondition) & " || Point " & CStr(frmMatching2Opt.barOpt2.Value + 1) & " || " & frmMatching2Opt.lbl2OptTimer.Text & " sec.")
    End Sub

    Public Sub Misses()
        ' Record the number of clicks not allocated to response option or other functional component.
        txtMissOptA2Opt.Text = frmMatching2Opt.missCountA
        txtMissOptB2Opt.Text = frmMatching2Opt.missCountB
    End Sub

    Private Sub tmrLog2Opt_Tick(sender As Object, e As EventArgs) Handles tmrLog2Opt.Tick
        ' Every .1 second, update all records as long as Log form is visible.
        If Me.Visible = True Then
            SchedulesOpt2()
            RecountOpt2()
            TimerLogOpt2()
            Misses()
            txtTimeOptA2Opt.Text = frmMatching2Opt.TimeCountA
            txtTimeOptB2Opt.Text = frmMatching2Opt.TimeCountB
            txtChangeover2Opt.Text = frmMatching2Opt.CODCount
            txtReversals2Opt.Text = frmMatching2Opt.schedCount
            txtCODClicks2Opt.Text = frmCODOpt2.intCODClickCount
            txtTotalClicks2Opt.Text = (CInt(txtCountOptA2Opt.Text)) + (CInt(txtCountOptB2Opt.Text)) + (CInt(txtCODClicks2Opt.Text)) + (CInt(txtMissOptA2Opt.Text)) + (CInt(txtMissOptB2Opt.Text))
        End If
    End Sub

End Class