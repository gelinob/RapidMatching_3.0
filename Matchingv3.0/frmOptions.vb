Public Class frmOptions
    Private Sub rdioOptionsAutoSched_CheckedChanged(sender As Object, e As EventArgs) Handles rdioOptionsAutoSched.CheckedChanged
        ' Display further options for automatic schedules, if selected.
        If grpOptionsManSched.Visible = True Then
            grpOptionsManSched.Hide()
            btnSchedules.Show()
        End If
    End Sub

    Private Sub rdioOptionsManSched_CheckedChanged(sender As Object, e As EventArgs) Handles rdioOptionsManSched.CheckedChanged
        ' Display further options for manual schedules, if selected.
        If btnSchedules.Visible = True Then
            btnSchedules.Hide()
            grpOptionsManSched.Show()
        End If
    End Sub

    ' Check all text boxes for valid entries before closing form.

    Private Sub btnOptionsOK_Click(sender As Object, e As EventArgs) Handles btnOptionsOK.Click
        If IsNumeric(txtbxOptionsBarValue.Text) = True AndAlso CInt(txtbxOptionsBarValue.Text) >= 0 Then
            If rdioOptionsManSched.Checked = True Then
                If IsNumeric(txtOptSchedAMin.Text) = True AndAlso CInt(txtOptSchedAMin.Text) >= 0 Then
                    If IsNumeric(txtOptSchedBMin.Text) = True AndAlso CInt(txtOptSchedBMin.Text) >= 0 Then
                        If IsNumeric(txtOptSchedCMin.Text) = True AndAlso CInt(txtOptSchedCMin.Text) >= 0 Then
                            If IsNumeric(txtOptSchedDMin.Text) = True AndAlso CInt(txtOptSchedDMin.Text) >= 0 Then
                                If IsNumeric(txtOptSchedAMax.Text) = True AndAlso CInt(txtOptSchedAMax.Text) >= 0 Then
                                    If IsNumeric(txtOptSchedBMax.Text) = True AndAlso CInt(txtOptSchedBMax.Text) >= 0 Then
                                        If IsNumeric(txtOptSchedCMax.Text) = True AndAlso CInt(txtOptSchedCMax.Text) >= 0 Then
                                            If IsNumeric(txtOptSchedDMax.Text) = True AndAlso CInt(txtOptSchedDMax.Text) >= 0 Then
                                                Me.Close()
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
                Me.Close()
            End If

        Else
            MessageBox.Show("Please enter a valid numeric value for progress bar points required.")
        End If
    End Sub

    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display options for automatic or manual schedule, depending on which is selected.
        If rdioOptionsAutoSched.Checked = True Then
            btnSchedules.Show()
            grpOptionsManSched.Hide()
        ElseIf rdioOptionsManSched.Checked = True Then
            grpOptionsManSched.Show()
            btnSchedules.Hide()
        End If
    End Sub

    Private Sub btnSchedules_Click(sender As Object, e As EventArgs) Handles btnSchedules.Click
        ' Show schedules form.
        frmSchedules.ShowDialog()

    End Sub
End Class