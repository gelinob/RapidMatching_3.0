Public Class frmCODOpt2
    Private intCOD As Integer
    Public intCODClickCount As Integer

    Private Sub frmCODOpt2_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Begin COD timer.
        tmrCODOpt2.Enabled = True
    End Sub

    Private Sub tmrCODOpt2_Tick(sender As Object, e As EventArgs) Handles tmrCODOpt2.Tick
        ' If less than COD time has been spent in COD, hide all response options.
        If intCOD < ((CInt(frmStartUp.txtCODDuration.Text)) - 1) Then
            If frmMatching2Opt.grpOptB2Opt.Visible = True Then
                frmMatching2Opt.grpOptB2Opt.Visible = False
            ElseIf frmMatching2Opt.grpOptA2Opt.Visible = True Then
                frmMatching2Opt.grpOptA2Opt.Visible = False
            End If
            frmMatching2Opt.btnOpt2A.Visible = False
            frmMatching2Opt.btnOpt2B.Visible = False
            ' Increase value of time spent in COD by 1.
            intCOD += 1
        Else
            ' If COD time has passed, disable COD timer, hide frmCOD, enable buttons, and reset COD second count
            frmMatching2Opt.btnOpt2A.Visible = True
            frmMatching2Opt.btnOpt2B.Visible = True
            intCOD = 0
            tmrCODOpt2.Enabled = False
            Me.Close()
        End If

    End Sub

    Private Sub frmCODOpt2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ' If click logged during COD, increase count of COD clicks by 1.
        intCODClickCount += 1
    End Sub

    Private Sub picCOD_MouseClick(sender As Object, e As MouseEventArgs) Handles picCOD.MouseClick
        intCODClickCount += 1
    End Sub
End Class