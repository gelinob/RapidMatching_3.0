<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatching2Opt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatching2Opt))
        Me.barOpt2 = New System.Windows.Forms.ProgressBar()
        Me.grpControlBox2Opt = New System.Windows.Forms.GroupBox()
        Me.lblPhase2Opt = New System.Windows.Forms.Label()
        Me.grpOptA2Opt = New System.Windows.Forms.GroupBox()
        Me.picOptA2Opt = New System.Windows.Forms.PictureBox()
        Me.btnOpt2Start = New System.Windows.Forms.Button()
        Me.btnOpt2Reset = New System.Windows.Forms.Button()
        Me.btnOpt2Log = New System.Windows.Forms.Button()
        Me.grpTimeBoxOpt2 = New System.Windows.Forms.GroupBox()
        Me.lbl2OptTimer = New System.Windows.Forms.Label()
        Me.btnOpt2A = New System.Windows.Forms.Button()
        Me.grpOptB2Opt = New System.Windows.Forms.GroupBox()
        Me.picOptB2Opt = New System.Windows.Forms.PictureBox()
        Me.btnOpt2B = New System.Windows.Forms.Button()
        Me.tmr2OptMain = New System.Windows.Forms.Timer(Me.components)
        Me.grpControlBox2Opt.SuspendLayout()
        Me.grpOptA2Opt.SuspendLayout()
        CType(Me.picOptA2Opt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimeBoxOpt2.SuspendLayout()
        Me.grpOptB2Opt.SuspendLayout()
        CType(Me.picOptB2Opt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barOpt2
        '
        Me.barOpt2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barOpt2.Location = New System.Drawing.Point(12, 12)
        Me.barOpt2.Name = "barOpt2"
        Me.barOpt2.Size = New System.Drawing.Size(726, 23)
        Me.barOpt2.TabIndex = 0
        '
        'grpControlBox2Opt
        '
        Me.grpControlBox2Opt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlBox2Opt.Controls.Add(Me.lblPhase2Opt)
        Me.grpControlBox2Opt.Controls.Add(Me.grpOptA2Opt)
        Me.grpControlBox2Opt.Controls.Add(Me.btnOpt2Start)
        Me.grpControlBox2Opt.Controls.Add(Me.btnOpt2Reset)
        Me.grpControlBox2Opt.Controls.Add(Me.btnOpt2Log)
        Me.grpControlBox2Opt.Controls.Add(Me.grpTimeBoxOpt2)
        Me.grpControlBox2Opt.Controls.Add(Me.btnOpt2A)
        Me.grpControlBox2Opt.Controls.Add(Me.grpOptB2Opt)
        Me.grpControlBox2Opt.Controls.Add(Me.btnOpt2B)
        Me.grpControlBox2Opt.Location = New System.Drawing.Point(12, 41)
        Me.grpControlBox2Opt.Name = "grpControlBox2Opt"
        Me.grpControlBox2Opt.Size = New System.Drawing.Size(726, 410)
        Me.grpControlBox2Opt.TabIndex = 1
        Me.grpControlBox2Opt.TabStop = False
        '
        'lblPhase2Opt
        '
        Me.lblPhase2Opt.AutoSize = True
        Me.lblPhase2Opt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhase2Opt.Location = New System.Drawing.Point(333, 243)
        Me.lblPhase2Opt.Name = "lblPhase2Opt"
        Me.lblPhase2Opt.Size = New System.Drawing.Size(0, 20)
        Me.lblPhase2Opt.TabIndex = 9
        '
        'grpOptA2Opt
        '
        Me.grpOptA2Opt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOptA2Opt.Controls.Add(Me.picOptA2Opt)
        Me.grpOptA2Opt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptA2Opt.Location = New System.Drawing.Point(30, 33)
        Me.grpOptA2Opt.Name = "grpOptA2Opt"
        Me.grpOptA2Opt.Size = New System.Drawing.Size(228, 349)
        Me.grpOptA2Opt.TabIndex = 8
        Me.grpOptA2Opt.TabStop = False
        Me.grpOptA2Opt.Text = "Option A"
        '
        'picOptA2Opt
        '
        Me.picOptA2Opt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picOptA2Opt.Image = CType(resources.GetObject("picOptA2Opt.Image"), System.Drawing.Image)
        Me.picOptA2Opt.ImageLocation = ""
        Me.picOptA2Opt.InitialImage = Nothing
        Me.picOptA2Opt.Location = New System.Drawing.Point(93, 154)
        Me.picOptA2Opt.Name = "picOptA2Opt"
        Me.picOptA2Opt.Size = New System.Drawing.Size(40, 40)
        Me.picOptA2Opt.TabIndex = 1
        Me.picOptA2Opt.TabStop = False
        '
        'btnOpt2Start
        '
        Me.btnOpt2Start.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpt2Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt2Start.Location = New System.Drawing.Point(287, 156)
        Me.btnOpt2Start.Name = "btnOpt2Start"
        Me.btnOpt2Start.Size = New System.Drawing.Size(161, 66)
        Me.btnOpt2Start.TabIndex = 6
        Me.btnOpt2Start.Text = "Start"
        Me.btnOpt2Start.UseVisualStyleBackColor = True
        '
        'btnOpt2Reset
        '
        Me.btnOpt2Reset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpt2Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt2Reset.Location = New System.Drawing.Point(287, 86)
        Me.btnOpt2Reset.Name = "btnOpt2Reset"
        Me.btnOpt2Reset.Size = New System.Drawing.Size(161, 64)
        Me.btnOpt2Reset.TabIndex = 5
        Me.btnOpt2Reset.Text = "Reset / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change Side"
        Me.btnOpt2Reset.UseVisualStyleBackColor = True
        '
        'btnOpt2Log
        '
        Me.btnOpt2Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpt2Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt2Log.Location = New System.Drawing.Point(332, 33)
        Me.btnOpt2Log.Name = "btnOpt2Log"
        Me.btnOpt2Log.Size = New System.Drawing.Size(75, 47)
        Me.btnOpt2Log.TabIndex = 1
        Me.btnOpt2Log.Text = "Log"
        Me.btnOpt2Log.UseVisualStyleBackColor = True
        '
        'grpTimeBoxOpt2
        '
        Me.grpTimeBoxOpt2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTimeBoxOpt2.Controls.Add(Me.lbl2OptTimer)
        Me.grpTimeBoxOpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTimeBoxOpt2.Location = New System.Drawing.Point(265, 283)
        Me.grpTimeBoxOpt2.Name = "grpTimeBoxOpt2"
        Me.grpTimeBoxOpt2.Size = New System.Drawing.Size(198, 100)
        Me.grpTimeBoxOpt2.TabIndex = 4
        Me.grpTimeBoxOpt2.TabStop = False
        Me.grpTimeBoxOpt2.Text = "Elapsed Time (s)"
        '
        'lbl2OptTimer
        '
        Me.lbl2OptTimer.AutoSize = True
        Me.lbl2OptTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2OptTimer.Location = New System.Drawing.Point(95, 43)
        Me.lbl2OptTimer.Name = "lbl2OptTimer"
        Me.lbl2OptTimer.Size = New System.Drawing.Size(0, 25)
        Me.lbl2OptTimer.TabIndex = 0
        Me.lbl2OptTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpt2A
        '
        Me.btnOpt2A.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpt2A.Location = New System.Drawing.Point(30, 33)
        Me.btnOpt2A.Name = "btnOpt2A"
        Me.btnOpt2A.Size = New System.Drawing.Size(229, 350)
        Me.btnOpt2A.TabIndex = 2
        Me.btnOpt2A.Text = "A"
        Me.btnOpt2A.UseVisualStyleBackColor = True
        '
        'grpOptB2Opt
        '
        Me.grpOptB2Opt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOptB2Opt.Controls.Add(Me.picOptB2Opt)
        Me.grpOptB2Opt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptB2Opt.Location = New System.Drawing.Point(469, 33)
        Me.grpOptB2Opt.Name = "grpOptB2Opt"
        Me.grpOptB2Opt.Size = New System.Drawing.Size(228, 349)
        Me.grpOptB2Opt.TabIndex = 7
        Me.grpOptB2Opt.TabStop = False
        Me.grpOptB2Opt.Text = "Option B"
        '
        'picOptB2Opt
        '
        Me.picOptB2Opt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picOptB2Opt.Image = CType(resources.GetObject("picOptB2Opt.Image"), System.Drawing.Image)
        Me.picOptB2Opt.ImageLocation = ""
        Me.picOptB2Opt.InitialImage = Nothing
        Me.picOptB2Opt.Location = New System.Drawing.Point(179, 303)
        Me.picOptB2Opt.Name = "picOptB2Opt"
        Me.picOptB2Opt.Size = New System.Drawing.Size(40, 40)
        Me.picOptB2Opt.TabIndex = 0
        Me.picOptB2Opt.TabStop = False
        '
        'btnOpt2B
        '
        Me.btnOpt2B.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpt2B.Location = New System.Drawing.Point(469, 33)
        Me.btnOpt2B.Name = "btnOpt2B"
        Me.btnOpt2B.Size = New System.Drawing.Size(229, 350)
        Me.btnOpt2B.TabIndex = 3
        Me.btnOpt2B.Text = "B"
        Me.btnOpt2B.UseVisualStyleBackColor = True
        '
        'tmr2OptMain
        '
        Me.tmr2OptMain.Interval = 1000
        '
        'frmMatching2Opt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 463)
        Me.Controls.Add(Me.grpControlBox2Opt)
        Me.Controls.Add(Me.barOpt2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatching2Opt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matching"
        Me.grpControlBox2Opt.ResumeLayout(False)
        Me.grpControlBox2Opt.PerformLayout()
        Me.grpOptA2Opt.ResumeLayout(False)
        CType(Me.picOptA2Opt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimeBoxOpt2.ResumeLayout(False)
        Me.grpTimeBoxOpt2.PerformLayout()
        Me.grpOptB2Opt.ResumeLayout(False)
        CType(Me.picOptB2Opt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barOpt2 As ProgressBar
    Friend WithEvents grpControlBox2Opt As GroupBox
    Friend WithEvents btnOpt2Start As Button
    Friend WithEvents btnOpt2Reset As Button
    Friend WithEvents btnOpt2Log As Button
    Friend WithEvents grpTimeBoxOpt2 As GroupBox
    Friend WithEvents lbl2OptTimer As Label
    Friend WithEvents btnOpt2B As Button
    Friend WithEvents btnOpt2A As Button
    Friend WithEvents tmr2OptMain As Timer
    Friend WithEvents grpOptB2Opt As GroupBox
    Friend WithEvents picOptB2Opt As PictureBox
    Friend WithEvents grpOptA2Opt As GroupBox
    Friend WithEvents picOptA2Opt As PictureBox
    Friend WithEvents lblPhase2Opt As Label
End Class
