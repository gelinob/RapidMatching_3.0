<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStartUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartUp))
        Me.grpMatching = New System.Windows.Forms.GroupBox()
        Me.txtCODDuration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpMatchingOpt = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdio2Opt = New System.Windows.Forms.RadioButton()
        Me.chkbxMatching = New System.Windows.Forms.CheckBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMatchingOpt = New System.Windows.Forms.Button()
        Me.txtBlackOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMatching.SuspendLayout()
        Me.grpMatchingOpt.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMatching
        '
        Me.grpMatching.Controls.Add(Me.txtCODDuration)
        Me.grpMatching.Controls.Add(Me.Label2)
        Me.grpMatching.Controls.Add(Me.Label1)
        Me.grpMatching.Controls.Add(Me.txtBlackOut)
        Me.grpMatching.Controls.Add(Me.grpMatchingOpt)
        Me.grpMatching.Controls.Add(Me.chkbxMatching)
        Me.grpMatching.Location = New System.Drawing.Point(12, 12)
        Me.grpMatching.Name = "grpMatching"
        Me.grpMatching.Size = New System.Drawing.Size(139, 196)
        Me.grpMatching.TabIndex = 1
        Me.grpMatching.TabStop = False
        Me.grpMatching.Text = "Matching"
        '
        'txtCODDuration
        '
        Me.txtCODDuration.Location = New System.Drawing.Point(111, 117)
        Me.txtCODDuration.Name = "txtCODDuration"
        Me.txtCODDuration.Size = New System.Drawing.Size(22, 20)
        Me.txtCODDuration.TabIndex = 6
        Me.txtCODDuration.Text = "3"
        Me.txtCODDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "COD Duration (s):"
        '
        'grpMatchingOpt
        '
        Me.grpMatchingOpt.Controls.Add(Me.RadioButton2)
        Me.grpMatchingOpt.Controls.Add(Me.rdio2Opt)
        Me.grpMatchingOpt.Location = New System.Drawing.Point(7, 19)
        Me.grpMatchingOpt.Name = "grpMatchingOpt"
        Me.grpMatchingOpt.Size = New System.Drawing.Size(126, 73)
        Me.grpMatchingOpt.TabIndex = 1
        Me.grpMatchingOpt.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "4-Option (A,B,C,D)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdio2Opt
        '
        Me.rdio2Opt.AutoSize = True
        Me.rdio2Opt.Checked = True
        Me.rdio2Opt.Location = New System.Drawing.Point(6, 20)
        Me.rdio2Opt.Name = "rdio2Opt"
        Me.rdio2Opt.Size = New System.Drawing.Size(91, 17)
        Me.rdio2Opt.TabIndex = 0
        Me.rdio2Opt.TabStop = True
        Me.rdio2Opt.Text = "2-Option (A,B)"
        Me.rdio2Opt.UseVisualStyleBackColor = True
        '
        'chkbxMatching
        '
        Me.chkbxMatching.AutoSize = True
        Me.chkbxMatching.Checked = True
        Me.chkbxMatching.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxMatching.Location = New System.Drawing.Point(7, 146)
        Me.chkbxMatching.Name = "chkbxMatching"
        Me.chkbxMatching.Size = New System.Drawing.Size(121, 17)
        Me.chkbxMatching.TabIndex = 0
        Me.chkbxMatching.Text = "Record Responding"
        Me.chkbxMatching.UseVisualStyleBackColor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(117, 243)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(72, 45)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(159, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 196)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Box2"
        '
        'btnMatchingOpt
        '
        Me.btnMatchingOpt.Location = New System.Drawing.Point(117, 214)
        Me.btnMatchingOpt.Name = "btnMatchingOpt"
        Me.btnMatchingOpt.Size = New System.Drawing.Size(72, 23)
        Me.btnMatchingOpt.TabIndex = 3
        Me.btnMatchingOpt.Text = "Options"
        Me.btnMatchingOpt.UseVisualStyleBackColor = True
        '
        'txtBlackOut
        '
        Me.txtBlackOut.Location = New System.Drawing.Point(111, 95)
        Me.txtBlackOut.Name = "txtBlackOut"
        Me.txtBlackOut.Size = New System.Drawing.Size(22, 20)
        Me.txtBlackOut.TabIndex = 3
        Me.txtBlackOut.Text = "10"
        Me.txtBlackOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Blackout Duration (s):"
        '
        'frmStartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 307)
        Me.Controls.Add(Me.btnMatchingOpt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.grpMatching)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStartUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matching v3.0"
        Me.grpMatching.ResumeLayout(False)
        Me.grpMatching.PerformLayout()
        Me.grpMatchingOpt.ResumeLayout(False)
        Me.grpMatchingOpt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMatching As GroupBox
    Friend WithEvents btnLaunch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpMatchingOpt As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdio2Opt As RadioButton
    Friend WithEvents btnMatchingOpt As Button
    Friend WithEvents chkbxMatching As CheckBox
    Friend WithEvents txtCODDuration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBlackOut As TextBox
End Class
