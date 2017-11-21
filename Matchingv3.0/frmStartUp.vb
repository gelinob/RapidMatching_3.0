Public Class frmStartUp
    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        'Check all input boxes for valid numeric values greater than or equal to 0. Stop from launching session if invalid.
        If IsNumeric(txtCODDuration.Text) = True AndAlso CInt(txtCODDuration.Text) >= 0 Then
            If IsNumeric(txtPtsReq.Text) = True AndAlso CInt(txtPtsReq.Text) >= 0 Then
                If IsNumeric(frmOptions.txtOptSchedAMin.Text) = True AndAlso CInt(frmOptions.txtOptSchedAMin.Text) >= 0 Then
                    If IsNumeric(frmOptions.txtOptSchedBMin.Text) = True AndAlso CInt(frmOptions.txtOptSchedBMin.Text) >= 0 Then
                        If IsNumeric(frmOptions.txtOptSchedCMin.Text) = True AndAlso CInt(frmOptions.txtOptSchedCMin.Text) >= 0 Then
                            If IsNumeric(frmOptions.txtOptSchedDMin.Text) = True AndAlso CInt(frmOptions.txtOptSchedDMin.Text) >= 0 Then
                                If IsNumeric(frmOptions.txtOptSchedAMax.Text) = True AndAlso CInt(frmOptions.txtOptSchedAMax.Text) >= 0 Then
                                    If IsNumeric(frmOptions.txtOptSchedBMax.Text) = True AndAlso CInt(frmOptions.txtOptSchedBMax.Text) >= 0 Then
                                        If IsNumeric(frmOptions.txtOptSchedCMax.Text) = True AndAlso CInt(frmOptions.txtOptSchedCMax.Text) >= 0 Then
                                            If IsNumeric(frmOptions.txtOptSchedDMax.Text) = True AndAlso CInt(frmOptions.txtOptSchedDMax.Text) >= 0 Then
                                                If rdio2Opt.Checked = True Then
                                                    frmMatching2Opt.ShowDialog()
                                                ElseIf rdio2Opt.Checked = True Then

                                                End If
                                            Else
                                                MessageBox.Show("Please enter a valid numeric value for Schedule D.")
                                                Exit Sub
                                            End If
                                        Else
                                            MessageBox.Show("Please enter a valid numeric value for Schedule C.")
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("Please enter a valid numeric value for Schedule B.")
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Please enter a valid numeric value for Schedule A.")
                                    Exit Sub
                                End If
                            Else
                                MessageBox.Show("Please enter a valid numeric value for Schedule D")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please enter a valid numeric value for Schedule C.")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid numeric value for Schedule B")
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Please enter a valid numeric value for Schedule A.")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid numeric value for points required.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for COD duration.")
            Exit Sub
        End If

    End Sub

    Private Sub btnMatchingOpt_Click(sender As Object, e As EventArgs) Handles btnMatchingOpt.Click
        frmOptions.ShowDialog()

    End Sub
End Class
