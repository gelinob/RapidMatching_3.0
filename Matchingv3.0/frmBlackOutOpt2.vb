Public Class frmBlackOutOpt2
    Private intBlackOut As Integer
    Private Sub frmBlackOutOpt2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrBlackOutOpt2.Enabled = True
    End Sub

    Private Sub tmrBlackOutOpt2_Tick(sender As Object, e As EventArgs) Handles tmrBlackOutOpt2.Tick
        If intBlackOut < ((CInt(frmStartUp.txtBlackOut.Text)) - 1) Then
            If frmMatching2Opt.grpOptB2Opt.Visible = True Then
                frmMatching2Opt.grpOptB2Opt.Visible = False
            ElseIf frmMatching2Opt.grpOptA2Opt.Visible = True Then
                frmMatching2Opt.grpOptA2Opt.Visible = False
            End If
            ' Make frmCOD visible.
            frmMatching2Opt.btnOpt2A.Visible = False
            frmMatching2Opt.btnOpt2B.Visible = False
            intBlackOut += 1
        Else
            ' If COD time has passed, disable COD timer, hide frmCOD, enable buttons, and reset COD second count
            frmMatching2Opt.btnOpt2A.Visible = True
            frmMatching2Opt.btnOpt2B.Visible = True
            intBlackOut = 0
            tmrBlackOutOpt2.Enabled = False
            frmMatching2Opt.tmr2OptMain.Enabled = True
            frmMatching2Opt.ManualSchedChange()
            frmMatching2Opt.ProgBarInitialize()
            frmMatching2Opt.TimeA = 0
            frmMatching2Opt.TimeB = 0
            Me.Close()
        End If
    End Sub
End Class