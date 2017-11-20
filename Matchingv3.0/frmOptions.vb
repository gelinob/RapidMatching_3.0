Public Class frmOptions
    Private Sub rdioOptionsAutoSched_CheckedChanged(sender As Object, e As EventArgs) Handles rdioOptionsAutoSched.CheckedChanged
        If grpOptionsManSched.Visible = True Then
            grpOptionsManSched.Hide()
        End If
    End Sub

    Private Sub rdioOptionsManSched_CheckedChanged(sender As Object, e As EventArgs) Handles rdioOptionsManSched.CheckedChanged
        If grpOptionsManSched.Visible = False Then
            grpOptionsManSched.Show()
        End If
    End Sub

    Private Sub btnOptionsOK_Click(sender As Object, e As EventArgs) Handles btnOptionsOK.Click
        Me.Close()

    End Sub

    Private Sub btnOptionsCancel_Click(sender As Object, e As EventArgs) Handles btnOptionsCancel.Click
        Me.Close()

    End Sub
End Class