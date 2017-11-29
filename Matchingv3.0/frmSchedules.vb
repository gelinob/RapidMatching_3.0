Public Class frmSchedules
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        CheckA()
    End Sub

    Private Sub CheckA()
        If IsNumeric(txtIntOptAPh1.Text) = True AndAlso CInt(txtIntOptAPh1.Text) >= 0 Then
            If IsNumeric(txtIntOptAPh2.Text) = True AndAlso CInt(txtIntOptAPh2.Text) >= 0 Then
                If IsNumeric(txtIntOptAPh3.Text) = True AndAlso CInt(txtIntOptAPh3.Text) >= 0 Then
                    If IsNumeric(txtIntOptAPh3.Text) = True AndAlso CInt(txtIntOptAPh4.Text) >= 0 Then
                        If IsNumeric(txtVIOptAPh1.Text) = True AndAlso CInt(txtVIOptAPh1.Text) >= 0 Then
                            If IsNumeric(txtVIOptAPh2.Text) = True AndAlso CInt(txtVIOptAPh2.Text) >= 0 Then
                                If IsNumeric(txtVIOptAPh3.Text) = True AndAlso CInt(txtVIOptAPh3.Text) >= 0 Then
                                    If IsNumeric(txtVIOptAPh4.Text) = True AndAlso CInt(txtVIOptAPh4.Text) >= 0 Then
                                        CheckB()
                                    Else
                                        MessageBox.Show("Please enter a valid numeric value for schedule A, phase 4.")
                                    End If
                                Else
                                    MessageBox.Show("Please enter a valid numeric value for schedule A, phase 3.")
                                End If
                            Else
                                MessageBox.Show("Please enter a valid numeric value for schedule A, phase 2.")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please enter a valid numeric value for schedule A, phase 1.")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid numeric value for schedule A, phase 4.")
                    End If
                Else
                    MessageBox.Show("Please enter a valid numeric value for schedule A, phase 3.")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid numeric value for schedule A, phase 2.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for schedule A, phase 1.")
            Exit Sub
        End If
    End Sub

    Private Sub CheckB()
        If IsNumeric(txtIntOptBPh1.Text) = True AndAlso CInt(txtIntOptBPh1.Text) >= 0 Then
            If IsNumeric(txtIntOptBPh2.Text) = True AndAlso CInt(txtIntOptBPh2.Text) >= 0 Then
                If IsNumeric(txtIntOptBPh3.Text) = True AndAlso CInt(txtIntOptBPh3.Text) >= 0 Then
                    If IsNumeric(txtIntOptBPh3.Text) = True AndAlso CInt(txtIntOptBPh4.Text) >= 0 Then
                        If IsNumeric(txtVIOptBPh1.Text) = True AndAlso CInt(txtVIOptBPh1.Text) >= 0 Then
                            If IsNumeric(txtVIOptBPh2.Text) = True AndAlso CInt(txtVIOptBPh2.Text) >= 0 Then
                                If IsNumeric(txtVIOptBPh3.Text) = True AndAlso CInt(txtVIOptBPh3.Text) >= 0 Then
                                    If IsNumeric(txtVIOptBPh4.Text) = True AndAlso CInt(txtVIOptBPh4.Text) >= 0 Then
                                        CheckC()
                                    Else
                                        MessageBox.Show("Please enter a valid numeric value for schedule B, phase 4.")
                                    End If
                                Else
                                    MessageBox.Show("Please enter a valid numeric value for schedule B, phase 3.")
                                End If
                            Else
                                MessageBox.Show("Please enter a valid numeric value for schedule B, phase 2.")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please enter a valid numeric value for schedule B, phase 1.")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid numeric value for schedule B, phase 4.")
                    End If
                Else
                    MessageBox.Show("Please enter a valid numeric value for schedule B, phase 3.")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid numeric value for schedule B, phase 2.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for schedule B, phase 1.")
            Exit Sub
        End If
    End Sub

    Private Sub CheckC()
        If IsNumeric(txtIntOptCPh1.Text) = True AndAlso CInt(txtIntOptCPh1.Text) >= 0 Then
            If IsNumeric(txtIntOptCPh2.Text) = True AndAlso CInt(txtIntOptCPh2.Text) >= 0 Then
                If IsNumeric(txtIntOptCPh3.Text) = True AndAlso CInt(txtIntOptCPh3.Text) >= 0 Then
                    If IsNumeric(txtIntOptCPh3.Text) = True AndAlso CInt(txtIntOptCPh4.Text) >= 0 Then
                        If IsNumeric(txtVIOptCPh1.Text) = True AndAlso CInt(txtVIOptCPh1.Text) >= 0 Then
                            If IsNumeric(txtVIOptCPh2.Text) = True AndAlso CInt(txtVIOptCPh2.Text) >= 0 Then
                                If IsNumeric(txtVIOptCPh3.Text) = True AndAlso CInt(txtVIOptCPh3.Text) >= 0 Then
                                    If IsNumeric(txtVIOptCPh4.Text) = True AndAlso CInt(txtVIOptCPh4.Text) >= 0 Then
                                        CheckD()
                                    Else
                                        MessageBox.Show("Please enter a valid numeric value for schedule C, phase 4.")
                                    End If
                                Else
                                    MessageBox.Show("Please enter a valid numeric value for schedule C, phase 3.")
                                End If
                            Else
                                MessageBox.Show("Please enter a valid numeric value for schedule C, phase 2.")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please enter a valid numeric value for schedule C, phase 1.")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid numeric value for schedule C, phase 4.")
                    End If
                Else
                    MessageBox.Show("Please enter a valid numeric value for schedule C, phase 3.")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid numeric value for schedule C, phase 2.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for schedule C, phase 1.")
            Exit Sub
        End If
    End Sub

    Private Sub CheckD()
        If IsNumeric(txtIntOptDPh1.Text) = True AndAlso CInt(txtIntOptDPh1.Text) >= 0 Then
            If IsNumeric(txtIntOptDPh2.Text) = True AndAlso CInt(txtIntOptDPh2.Text) >= 0 Then
                If IsNumeric(txtIntOptDPh3.Text) = True AndAlso CInt(txtIntOptDPh3.Text) >= 0 Then
                    If IsNumeric(txtIntOptDPh3.Text) = True AndAlso CInt(txtIntOptDPh4.Text) >= 0 Then
                        If IsNumeric(txtVIOptDPh1.Text) = True AndAlso CInt(txtVIOptDPh1.Text) >= 0 Then
                            If IsNumeric(txtVIOptDPh2.Text) = True AndAlso CInt(txtVIOptDPh2.Text) >= 0 Then
                                If IsNumeric(txtVIOptDPh3.Text) = True AndAlso CInt(txtVIOptDPh3.Text) >= 0 Then
                                    If IsNumeric(txtVIOptDPh4.Text) = True AndAlso CInt(txtVIOptDPh4.Text) >= 0 Then
                                        Me.Close()
                                    Else
                                        MessageBox.Show("Please enter a valid numeric value for schedule D, phase 4.")
                                    End If
                                Else
                                    MessageBox.Show("Please enter a valid numeric value for schedule D, phase 3.")
                                End If
                            Else
                                MessageBox.Show("Please enter a valid numeric value for schedule D, phase 2.")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please enter a valid numeric value for schedule D, phase 1.")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid numeric value for schedule D, phase 4.")
                    End If
                Else
                    MessageBox.Show("Please enter a valid numeric value for schedule D, phase 3.")
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a valid numeric value for schedule D, phase 2.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a valid numeric value for schedule D, phase 1.")
            Exit Sub
        End If
    End Sub

    Private Sub frmSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
