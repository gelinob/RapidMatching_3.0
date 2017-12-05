Public Class frmStartUp
    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        'Check all input boxes for valid numeric values greater than or equal to 0. Stop from launching session if invalid.
        If IsNumeric(txtCODDuration.Text) = True AndAlso CInt(txtCODDuration.Text) >= 0 Then
            If rdio2Opt.Checked = True Then
                frmMatching2Opt.ShowDialog()
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for points required.")
            Exit Sub
        End If
    End Sub

    Private Sub btnMatchingOpt_Click(sender As Object, e As EventArgs) Handles btnMatchingOpt.Click
        frmOptions.ShowDialog()
    End Sub
End Class
