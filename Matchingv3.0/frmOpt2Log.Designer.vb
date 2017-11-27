<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpt2Log
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpOptA2Opt = New System.Windows.Forms.GroupBox()
        Me.txtMissOptA2Opt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTimeOptA2Opt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimerOptA2Opt = New System.Windows.Forms.TextBox()
        Me.lblTimerOptA2Opt = New System.Windows.Forms.Label()
        Me.lstOptA2Opt = New System.Windows.Forms.ListBox()
        Me.txtCountOptA2Opt = New System.Windows.Forms.TextBox()
        Me.lblCountOptA2Opt = New System.Windows.Forms.Label()
        Me.txtSchedOptA2Opt = New System.Windows.Forms.TextBox()
        Me.lblSchedOptA2Opt = New System.Windows.Forms.Label()
        Me.grpOptB2Opt = New System.Windows.Forms.GroupBox()
        Me.txtMissOptB2Opt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTimeOptB2Opt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTimerOptB2Opt = New System.Windows.Forms.TextBox()
        Me.lblTimerOptB2Opt = New System.Windows.Forms.Label()
        Me.lstOptB2Opt = New System.Windows.Forms.ListBox()
        Me.txtCountOptB2Opt = New System.Windows.Forms.TextBox()
        Me.lblCountOptB2Opt = New System.Windows.Forms.Label()
        Me.txtSchedOptB2Opt = New System.Windows.Forms.TextBox()
        Me.lblSchedOptB2Opt = New System.Windows.Forms.Label()
        Me.tmrLog2Opt = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChangeover2Opt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReversals2Opt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCODClicks2Opt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalClicks2Opt = New System.Windows.Forms.TextBox()
        Me.grpOptA2Opt.SuspendLayout()
        Me.grpOptB2Opt.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptA2Opt
        '
        Me.grpOptA2Opt.Controls.Add(Me.txtMissOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.Label9)
        Me.grpOptA2Opt.Controls.Add(Me.txtTimeOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.Label7)
        Me.grpOptA2Opt.Controls.Add(Me.Label1)
        Me.grpOptA2Opt.Controls.Add(Me.txtTimerOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.lblTimerOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.lstOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.txtCountOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.lblCountOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.txtSchedOptA2Opt)
        Me.grpOptA2Opt.Controls.Add(Me.lblSchedOptA2Opt)
        Me.grpOptA2Opt.Location = New System.Drawing.Point(12, 12)
        Me.grpOptA2Opt.Name = "grpOptA2Opt"
        Me.grpOptA2Opt.Size = New System.Drawing.Size(274, 155)
        Me.grpOptA2Opt.TabIndex = 0
        Me.grpOptA2Opt.TabStop = False
        Me.grpOptA2Opt.Text = "Option A"
        '
        'txtMissOptA2Opt
        '
        Me.txtMissOptA2Opt.Location = New System.Drawing.Point(226, 43)
        Me.txtMissOptA2Opt.Name = "txtMissOptA2Opt"
        Me.txtMissOptA2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtMissOptA2Opt.TabIndex = 7
        Me.txtMissOptA2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Time Allocated:"
        '
        'txtTimeOptA2Opt
        '
        Me.txtTimeOptA2Opt.Location = New System.Drawing.Point(226, 66)
        Me.txtTimeOptA2Opt.Name = "txtTimeOptA2Opt"
        Me.txtTimeOptA2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtTimeOptA2Opt.TabIndex = 11
        Me.txtTimeOptA2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "# of Misses:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "R+ Delivery"
        '
        'txtTimerOptA2Opt
        '
        Me.txtTimerOptA2Opt.Location = New System.Drawing.Point(98, 43)
        Me.txtTimerOptA2Opt.Name = "txtTimerOptA2Opt"
        Me.txtTimerOptA2Opt.Size = New System.Drawing.Size(30, 20)
        Me.txtTimerOptA2Opt.TabIndex = 5
        Me.txtTimerOptA2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTimerOptA2Opt
        '
        Me.lblTimerOptA2Opt.AutoSize = True
        Me.lblTimerOptA2Opt.Location = New System.Drawing.Point(7, 44)
        Me.lblTimerOptA2Opt.Name = "lblTimerOptA2Opt"
        Me.lblTimerOptA2Opt.Size = New System.Drawing.Size(84, 13)
        Me.lblTimerOptA2Opt.TabIndex = 4
        Me.lblTimerOptA2Opt.Text = "Schedule Timer:"
        '
        'lstOptA2Opt
        '
        Me.lstOptA2Opt.FormattingEnabled = True
        Me.lstOptA2Opt.Location = New System.Drawing.Point(10, 93)
        Me.lstOptA2Opt.Name = "lstOptA2Opt"
        Me.lstOptA2Opt.Size = New System.Drawing.Size(248, 56)
        Me.lstOptA2Opt.TabIndex = 9
        '
        'txtCountOptA2Opt
        '
        Me.txtCountOptA2Opt.Location = New System.Drawing.Point(226, 19)
        Me.txtCountOptA2Opt.Name = "txtCountOptA2Opt"
        Me.txtCountOptA2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtCountOptA2Opt.TabIndex = 3
        Me.txtCountOptA2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCountOptA2Opt
        '
        Me.lblCountOptA2Opt.AutoSize = True
        Me.lblCountOptA2Opt.Location = New System.Drawing.Point(135, 20)
        Me.lblCountOptA2Opt.Name = "lblCountOptA2Opt"
        Me.lblCountOptA2Opt.Size = New System.Drawing.Size(85, 13)
        Me.lblCountOptA2Opt.TabIndex = 2
        Me.lblCountOptA2Opt.Text = "# of Responses:"
        '
        'txtSchedOptA2Opt
        '
        Me.txtSchedOptA2Opt.Location = New System.Drawing.Point(98, 19)
        Me.txtSchedOptA2Opt.Name = "txtSchedOptA2Opt"
        Me.txtSchedOptA2Opt.Size = New System.Drawing.Size(30, 20)
        Me.txtSchedOptA2Opt.TabIndex = 1
        Me.txtSchedOptA2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSchedOptA2Opt
        '
        Me.lblSchedOptA2Opt.AutoSize = True
        Me.lblSchedOptA2Opt.Location = New System.Drawing.Point(7, 20)
        Me.lblSchedOptA2Opt.Name = "lblSchedOptA2Opt"
        Me.lblSchedOptA2Opt.Size = New System.Drawing.Size(85, 13)
        Me.lblSchedOptA2Opt.TabIndex = 0
        Me.lblSchedOptA2Opt.Text = "Schedule Value:"
        '
        'grpOptB2Opt
        '
        Me.grpOptB2Opt.Controls.Add(Me.txtMissOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.Label10)
        Me.grpOptB2Opt.Controls.Add(Me.txtTimeOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.Label8)
        Me.grpOptB2Opt.Controls.Add(Me.Label2)
        Me.grpOptB2Opt.Controls.Add(Me.txtTimerOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.lblTimerOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.lstOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.txtCountOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.lblCountOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.txtSchedOptB2Opt)
        Me.grpOptB2Opt.Controls.Add(Me.lblSchedOptB2Opt)
        Me.grpOptB2Opt.Location = New System.Drawing.Point(12, 175)
        Me.grpOptB2Opt.Name = "grpOptB2Opt"
        Me.grpOptB2Opt.Size = New System.Drawing.Size(274, 155)
        Me.grpOptB2Opt.TabIndex = 1
        Me.grpOptB2Opt.TabStop = False
        Me.grpOptB2Opt.Text = "Option B"
        '
        'txtMissOptB2Opt
        '
        Me.txtMissOptB2Opt.Location = New System.Drawing.Point(226, 42)
        Me.txtMissOptB2Opt.Name = "txtMissOptB2Opt"
        Me.txtMissOptB2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtMissOptB2Opt.TabIndex = 7
        Me.txtMissOptB2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Time Allocated:"
        '
        'txtTimeOptB2Opt
        '
        Me.txtTimeOptB2Opt.Location = New System.Drawing.Point(226, 67)
        Me.txtTimeOptB2Opt.Name = "txtTimeOptB2Opt"
        Me.txtTimeOptB2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtTimeOptB2Opt.TabIndex = 11
        Me.txtTimeOptB2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(136, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "# of Misses:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "R+ Delivery"
        '
        'txtTimerOptB2Opt
        '
        Me.txtTimerOptB2Opt.Location = New System.Drawing.Point(97, 44)
        Me.txtTimerOptB2Opt.Name = "txtTimerOptB2Opt"
        Me.txtTimerOptB2Opt.Size = New System.Drawing.Size(31, 20)
        Me.txtTimerOptB2Opt.TabIndex = 5
        Me.txtTimerOptB2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTimerOptB2Opt
        '
        Me.lblTimerOptB2Opt.AutoSize = True
        Me.lblTimerOptB2Opt.Location = New System.Drawing.Point(6, 45)
        Me.lblTimerOptB2Opt.Name = "lblTimerOptB2Opt"
        Me.lblTimerOptB2Opt.Size = New System.Drawing.Size(84, 13)
        Me.lblTimerOptB2Opt.TabIndex = 4
        Me.lblTimerOptB2Opt.Text = "Schedule Timer:"
        '
        'lstOptB2Opt
        '
        Me.lstOptB2Opt.FormattingEnabled = True
        Me.lstOptB2Opt.Location = New System.Drawing.Point(10, 93)
        Me.lstOptB2Opt.Name = "lstOptB2Opt"
        Me.lstOptB2Opt.Size = New System.Drawing.Size(248, 56)
        Me.lstOptB2Opt.TabIndex = 9
        '
        'txtCountOptB2Opt
        '
        Me.txtCountOptB2Opt.Location = New System.Drawing.Point(226, 19)
        Me.txtCountOptB2Opt.Name = "txtCountOptB2Opt"
        Me.txtCountOptB2Opt.Size = New System.Drawing.Size(32, 20)
        Me.txtCountOptB2Opt.TabIndex = 3
        Me.txtCountOptB2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCountOptB2Opt
        '
        Me.lblCountOptB2Opt.AutoSize = True
        Me.lblCountOptB2Opt.Location = New System.Drawing.Point(135, 20)
        Me.lblCountOptB2Opt.Name = "lblCountOptB2Opt"
        Me.lblCountOptB2Opt.Size = New System.Drawing.Size(85, 13)
        Me.lblCountOptB2Opt.TabIndex = 2
        Me.lblCountOptB2Opt.Text = "# of Responses:"
        '
        'txtSchedOptB2Opt
        '
        Me.txtSchedOptB2Opt.Location = New System.Drawing.Point(98, 19)
        Me.txtSchedOptB2Opt.Name = "txtSchedOptB2Opt"
        Me.txtSchedOptB2Opt.Size = New System.Drawing.Size(30, 20)
        Me.txtSchedOptB2Opt.TabIndex = 1
        Me.txtSchedOptB2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSchedOptB2Opt
        '
        Me.lblSchedOptB2Opt.AutoSize = True
        Me.lblSchedOptB2Opt.Location = New System.Drawing.Point(7, 20)
        Me.lblSchedOptB2Opt.Name = "lblSchedOptB2Opt"
        Me.lblSchedOptB2Opt.Size = New System.Drawing.Size(85, 13)
        Me.lblSchedOptB2Opt.TabIndex = 0
        Me.lblSchedOptB2Opt.Text = "Schedule Value:"
        '
        'tmrLog2Opt
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "# of CODs:"
        '
        'txtChangeover2Opt
        '
        Me.txtChangeover2Opt.Location = New System.Drawing.Point(78, 337)
        Me.txtChangeover2Opt.Name = "txtChangeover2Opt"
        Me.txtChangeover2Opt.Size = New System.Drawing.Size(33, 20)
        Me.txtChangeover2Opt.TabIndex = 2
        Me.txtChangeover2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "# of Schedule Reversals:"
        '
        'txtReversals2Opt
        '
        Me.txtReversals2Opt.Location = New System.Drawing.Point(248, 337)
        Me.txtReversals2Opt.Name = "txtReversals2Opt"
        Me.txtReversals2Opt.Size = New System.Drawing.Size(33, 20)
        Me.txtReversals2Opt.TabIndex = 4
        Me.txtReversals2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "# of COD Clicks:"
        '
        'txtCODClicks2Opt
        '
        Me.txtCODClicks2Opt.Location = New System.Drawing.Point(100, 363)
        Me.txtCODClicks2Opt.Name = "txtCODClicks2Opt"
        Me.txtCODClicks2Opt.Size = New System.Drawing.Size(33, 20)
        Me.txtCODClicks2Opt.TabIndex = 6
        Me.txtCODClicks2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Total Clicks:"
        '
        'txtTotalClicks2Opt
        '
        Me.txtTotalClicks2Opt.Location = New System.Drawing.Point(211, 363)
        Me.txtTotalClicks2Opt.Name = "txtTotalClicks2Opt"
        Me.txtTotalClicks2Opt.Size = New System.Drawing.Size(33, 20)
        Me.txtTotalClicks2Opt.TabIndex = 8
        Me.txtTotalClicks2Opt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmOpt2Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 396)
        Me.Controls.Add(Me.txtTotalClicks2Opt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCODClicks2Opt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReversals2Opt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChangeover2Opt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpOptB2Opt)
        Me.Controls.Add(Me.grpOptA2Opt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpt2Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Log"
        Me.grpOptA2Opt.ResumeLayout(False)
        Me.grpOptA2Opt.PerformLayout()
        Me.grpOptB2Opt.ResumeLayout(False)
        Me.grpOptB2Opt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOptA2Opt As GroupBox
    Friend WithEvents lblCountOptA2Opt As Label
    Friend WithEvents txtSchedOptA2Opt As TextBox
    Friend WithEvents lblSchedOptA2Opt As Label
    Friend WithEvents lstOptA2Opt As ListBox
    Friend WithEvents txtCountOptA2Opt As TextBox
    Friend WithEvents grpOptB2Opt As GroupBox
    Friend WithEvents lstOptB2Opt As ListBox
    Friend WithEvents txtCountOptB2Opt As TextBox
    Friend WithEvents lblCountOptB2Opt As Label
    Friend WithEvents txtSchedOptB2Opt As TextBox
    Friend WithEvents lblSchedOptB2Opt As Label
    Friend WithEvents tmrLog2Opt As Timer
    Friend WithEvents lblTimerOptA2Opt As Label
    Friend WithEvents txtTimerOptA2Opt As TextBox
    Friend WithEvents lblTimerOptB2Opt As Label
    Friend WithEvents txtTimerOptB2Opt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtChangeover2Opt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReversals2Opt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCODClicks2Opt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalClicks2Opt As TextBox
    Friend WithEvents txtTimeOptA2Opt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTimeOptB2Opt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMissOptA2Opt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMissOptB2Opt As TextBox
    Friend WithEvents Label10 As Label
End Class
