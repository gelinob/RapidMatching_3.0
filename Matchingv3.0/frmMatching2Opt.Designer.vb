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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpOptA2Opt = New System.Windows.Forms.GroupBox()
        Me.picOptA2Opt = New System.Windows.Forms.PictureBox()
        Me.btnOpt2Start = New System.Windows.Forms.Button()
        Me.btnOpt2Reset = New System.Windows.Forms.Button()
        Me.btnOpt2Log = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl2OptTimer = New System.Windows.Forms.Label()
        Me.btnOpt2A = New System.Windows.Forms.Button()
        Me.grpOptB2Opt = New System.Windows.Forms.GroupBox()
        Me.picOptB2Opt = New System.Windows.Forms.PictureBox()
        Me.btnOpt2B = New System.Windows.Forms.Button()
        Me.tmr2OptMain = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpOptA2Opt.SuspendLayout()
        CType(Me.picOptA2Opt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grpOptB2Opt.SuspendLayout()
        CType(Me.picOptB2Opt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barOpt2
        '
        Me.barOpt2.Location = New System.Drawing.Point(12, 12)
        Me.barOpt2.Name = "barOpt2"
        Me.barOpt2.Size = New System.Drawing.Size(726, 23)
        Me.barOpt2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpOptA2Opt)
        Me.GroupBox1.Controls.Add(Me.btnOpt2Start)
        Me.GroupBox1.Controls.Add(Me.btnOpt2Reset)
        Me.GroupBox1.Controls.Add(Me.btnOpt2Log)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnOpt2A)
        Me.GroupBox1.Controls.Add(Me.grpOptB2Opt)
        Me.GroupBox1.Controls.Add(Me.btnOpt2B)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 410)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'grpOptA2Opt
        '
        Me.grpOptA2Opt.Controls.Add(Me.picOptA2Opt)
        Me.grpOptA2Opt.Location = New System.Drawing.Point(30, 33)
        Me.grpOptA2Opt.Name = "grpOptA2Opt"
        Me.grpOptA2Opt.Size = New System.Drawing.Size(228, 349)
        Me.grpOptA2Opt.TabIndex = 8
        Me.grpOptA2Opt.TabStop = False
        Me.grpOptA2Opt.Text = "Option A"
        '
        'picOptA2Opt
        '
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
        Me.btnOpt2Start.Location = New System.Drawing.Point(287, 185)
        Me.btnOpt2Start.Name = "btnOpt2Start"
        Me.btnOpt2Start.Size = New System.Drawing.Size(161, 66)
        Me.btnOpt2Start.TabIndex = 6
        Me.btnOpt2Start.Text = "Start"
        Me.btnOpt2Start.UseVisualStyleBackColor = True
        '
        'btnOpt2Reset
        '
        Me.btnOpt2Reset.Location = New System.Drawing.Point(287, 105)
        Me.btnOpt2Reset.Name = "btnOpt2Reset"
        Me.btnOpt2Reset.Size = New System.Drawing.Size(161, 64)
        Me.btnOpt2Reset.TabIndex = 5
        Me.btnOpt2Reset.Text = "Reset"
        Me.btnOpt2Reset.UseVisualStyleBackColor = True
        '
        'btnOpt2Log
        '
        Me.btnOpt2Log.Location = New System.Drawing.Point(331, 42)
        Me.btnOpt2Log.Name = "btnOpt2Log"
        Me.btnOpt2Log.Size = New System.Drawing.Size(75, 47)
        Me.btnOpt2Log.TabIndex = 1
        Me.btnOpt2Log.Text = "Log"
        Me.btnOpt2Log.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl2OptTimer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(265, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elapsed Time (s)"
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
        Me.btnOpt2A.Location = New System.Drawing.Point(30, 33)
        Me.btnOpt2A.Name = "btnOpt2A"
        Me.btnOpt2A.Size = New System.Drawing.Size(229, 350)
        Me.btnOpt2A.TabIndex = 2
        Me.btnOpt2A.Text = "A"
        Me.btnOpt2A.UseVisualStyleBackColor = True
        '
        'grpOptB2Opt
        '
        Me.grpOptB2Opt.Controls.Add(Me.picOptB2Opt)
        Me.grpOptB2Opt.Location = New System.Drawing.Point(470, 34)
        Me.grpOptB2Opt.Name = "grpOptB2Opt"
        Me.grpOptB2Opt.Size = New System.Drawing.Size(228, 349)
        Me.grpOptB2Opt.TabIndex = 7
        Me.grpOptB2Opt.TabStop = False
        Me.grpOptB2Opt.Text = "Option B"
        '
        'picOptB2Opt
        '
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barOpt2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMatching2Opt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matching"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpOptA2Opt.ResumeLayout(False)
        CType(Me.picOptA2Opt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOptB2Opt.ResumeLayout(False)
        CType(Me.picOptB2Opt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barOpt2 As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOpt2Start As Button
    Friend WithEvents btnOpt2Reset As Button
    Friend WithEvents btnOpt2Log As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl2OptTimer As Label
    Friend WithEvents btnOpt2B As Button
    Friend WithEvents btnOpt2A As Button
    Friend WithEvents tmr2OptMain As Timer
    Friend WithEvents grpOptB2Opt As GroupBox
    Friend WithEvents picOptB2Opt As PictureBox
    Friend WithEvents grpOptA2Opt As GroupBox
    Friend WithEvents picOptA2Opt As PictureBox
End Class
