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
        If IsNumeric(txtOptSchedAMin.Text) = True AndAlso CInt(txtOptSchedAMin.Text) >= 0 Then
            If IsNumeric(txtOptSchedBMin.Text) = True AndAlso CInt(txtOptSchedBMin.Text) >= 0 Then
                If IsNumeric(txtOptSchedCMin.Text) = True AndAlso CInt(txtOptSchedCMin.Text) >= 0 Then
                    If IsNumeric(txtOptSchedDMin.Text) = True AndAlso CInt(txtOptSchedDMin.Text) >= 0 Then
                        If IsNumeric(txtOptSchedAMax.Text) = True AndAlso CInt(txtOptSchedAMax.Text) >= 0 Then
                            If IsNumeric(txtOptSchedBMax.Text) = True AndAlso CInt(txtOptSchedBMax.Text) >= 0 Then
                                If IsNumeric(txtOptSchedCMax.Text) = True AndAlso CInt(txtOptSchedCMax.Text) >= 0 Then
                                    If IsNumeric(txtOptSchedDMax.Text) = True AndAlso CInt(txtOptSchedDMax.Text) >= 0 Then
                                        If IsNumeric(txtbxOptionsBarValue.Text) = True AndAlso CInt(txtbxOptionsBarValue.Text) >= 0 Then
                                            Me.Close()
                                        Else
                                            MessageBox.Show("Please enter a valid numeric value for progress bar points required.")
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
    End Sub

End Class