﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgeMatching2Opt = New System.Windows.Forms.TabPage()
        Me.grpOptionsManSched = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOptMin = New System.Windows.Forms.Label()
        Me.txtOptSchedDMax = New System.Windows.Forms.TextBox()
        Me.txtOptSchedCMax = New System.Windows.Forms.TextBox()
        Me.txtOptSchedBMax = New System.Windows.Forms.TextBox()
        Me.txtOptSchedAMax = New System.Windows.Forms.TextBox()
        Me.txtOptSchedDMin = New System.Windows.Forms.TextBox()
        Me.txtOptSchedCMin = New System.Windows.Forms.TextBox()
        Me.txtOptSchedBMin = New System.Windows.Forms.TextBox()
        Me.txtOptSchedAMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSchedA = New System.Windows.Forms.Label()
        Me.chkbxOptionsRandom = New System.Windows.Forms.CheckBox()
        Me.chkbxSchedChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdioOptionsManSched = New System.Windows.Forms.RadioButton()
        Me.rdioOptionsAutoSched = New System.Windows.Forms.RadioButton()
        Me.btnSchedules = New System.Windows.Forms.Button()
        Me.pgeProgBar = New System.Windows.Forms.TabPage()
        Me.chkbxBackCount = New System.Windows.Forms.CheckBox()
        Me.txtbxOptionsBarValue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOptionsOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.pgeMatching2Opt.SuspendLayout()
        Me.grpOptionsManSched.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pgeProgBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgeMatching2Opt)
        Me.TabControl1.Controls.Add(Me.pgeProgBar)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 312)
        Me.TabControl1.TabIndex = 0
        '
        'pgeMatching2Opt
        '
        Me.pgeMatching2Opt.Controls.Add(Me.grpOptionsManSched)
        Me.pgeMatching2Opt.Controls.Add(Me.chkbxOptionsRandom)
        Me.pgeMatching2Opt.Controls.Add(Me.chkbxSchedChange)
        Me.pgeMatching2Opt.Controls.Add(Me.GroupBox2)
        Me.pgeMatching2Opt.Controls.Add(Me.btnSchedules)
        Me.pgeMatching2Opt.Location = New System.Drawing.Point(4, 22)
        Me.pgeMatching2Opt.Name = "pgeMatching2Opt"
        Me.pgeMatching2Opt.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeMatching2Opt.Size = New System.Drawing.Size(232, 286)
        Me.pgeMatching2Opt.TabIndex = 0
        Me.pgeMatching2Opt.Text = "Schedules"
        Me.pgeMatching2Opt.UseVisualStyleBackColor = True
        '
        'grpOptionsManSched
        '
        Me.grpOptionsManSched.Controls.Add(Me.Label4)
        Me.grpOptionsManSched.Controls.Add(Me.lblOptMin)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedDMax)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedCMax)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedBMax)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedAMax)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedDMin)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedCMin)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedBMin)
        Me.grpOptionsManSched.Controls.Add(Me.txtOptSchedAMin)
        Me.grpOptionsManSched.Controls.Add(Me.Label3)
        Me.grpOptionsManSched.Controls.Add(Me.Label2)
        Me.grpOptionsManSched.Controls.Add(Me.Label1)
        Me.grpOptionsManSched.Controls.Add(Me.lblSchedA)
        Me.grpOptionsManSched.Location = New System.Drawing.Point(6, 138)
        Me.grpOptionsManSched.Name = "grpOptionsManSched"
        Me.grpOptionsManSched.Size = New System.Drawing.Size(220, 142)
        Me.grpOptionsManSched.TabIndex = 1
        Me.grpOptionsManSched.TabStop = False
        Me.grpOptionsManSched.Text = "Schedule Values"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Maximum"
        '
        'lblOptMin
        '
        Me.lblOptMin.AutoSize = True
        Me.lblOptMin.Location = New System.Drawing.Point(87, 20)
        Me.lblOptMin.Name = "lblOptMin"
        Me.lblOptMin.Size = New System.Drawing.Size(48, 13)
        Me.lblOptMin.TabIndex = 0
        Me.lblOptMin.Text = "Minimum"
        '
        'txtOptSchedDMax
        '
        Me.txtOptSchedDMax.Location = New System.Drawing.Point(152, 111)
        Me.txtOptSchedDMax.Name = "txtOptSchedDMax"
        Me.txtOptSchedDMax.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedDMax.TabIndex = 13
        Me.txtOptSchedDMax.Text = "30"
        Me.txtOptSchedDMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedCMax
        '
        Me.txtOptSchedCMax.Location = New System.Drawing.Point(152, 88)
        Me.txtOptSchedCMax.Name = "txtOptSchedCMax"
        Me.txtOptSchedCMax.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedCMax.TabIndex = 10
        Me.txtOptSchedCMax.Text = "20"
        Me.txtOptSchedCMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedBMax
        '
        Me.txtOptSchedBMax.Location = New System.Drawing.Point(152, 65)
        Me.txtOptSchedBMax.Name = "txtOptSchedBMax"
        Me.txtOptSchedBMax.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedBMax.TabIndex = 7
        Me.txtOptSchedBMax.Text = "10"
        Me.txtOptSchedBMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedAMax
        '
        Me.txtOptSchedAMax.Location = New System.Drawing.Point(152, 41)
        Me.txtOptSchedAMax.Name = "txtOptSchedAMax"
        Me.txtOptSchedAMax.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedAMax.TabIndex = 4
        Me.txtOptSchedAMax.Text = "5"
        Me.txtOptSchedAMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedDMin
        '
        Me.txtOptSchedDMin.Location = New System.Drawing.Point(90, 111)
        Me.txtOptSchedDMin.Name = "txtOptSchedDMin"
        Me.txtOptSchedDMin.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedDMin.TabIndex = 12
        Me.txtOptSchedDMin.Text = "5"
        Me.txtOptSchedDMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedCMin
        '
        Me.txtOptSchedCMin.Location = New System.Drawing.Point(90, 88)
        Me.txtOptSchedCMin.Name = "txtOptSchedCMin"
        Me.txtOptSchedCMin.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedCMin.TabIndex = 9
        Me.txtOptSchedCMin.Text = "5"
        Me.txtOptSchedCMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedBMin
        '
        Me.txtOptSchedBMin.Location = New System.Drawing.Point(90, 65)
        Me.txtOptSchedBMin.Name = "txtOptSchedBMin"
        Me.txtOptSchedBMin.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedBMin.TabIndex = 6
        Me.txtOptSchedBMin.Text = "1"
        Me.txtOptSchedBMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOptSchedAMin
        '
        Me.txtOptSchedAMin.Location = New System.Drawing.Point(90, 41)
        Me.txtOptSchedAMin.Name = "txtOptSchedAMin"
        Me.txtOptSchedAMin.Size = New System.Drawing.Size(40, 20)
        Me.txtOptSchedAMin.TabIndex = 3
        Me.txtOptSchedAMin.Text = "1"
        Me.txtOptSchedAMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Schedule D:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Schedule C:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Schedule B:"
        '
        'lblSchedA
        '
        Me.lblSchedA.AutoSize = True
        Me.lblSchedA.Location = New System.Drawing.Point(6, 44)
        Me.lblSchedA.Name = "lblSchedA"
        Me.lblSchedA.Size = New System.Drawing.Size(65, 13)
        Me.lblSchedA.TabIndex = 2
        Me.lblSchedA.Text = "Schedule A:"
        '
        'chkbxOptionsRandom
        '
        Me.chkbxOptionsRandom.AutoSize = True
        Me.chkbxOptionsRandom.Location = New System.Drawing.Point(12, 34)
        Me.chkbxOptionsRandom.Name = "chkbxOptionsRandom"
        Me.chkbxOptionsRandom.Size = New System.Drawing.Size(141, 17)
        Me.chkbxOptionsRandom.TabIndex = 9
        Me.chkbxOptionsRandom.Text = "Randomize Phase Order"
        Me.chkbxOptionsRandom.UseVisualStyleBackColor = True
        '
        'chkbxSchedChange
        '
        Me.chkbxSchedChange.AutoSize = True
        Me.chkbxSchedChange.Location = New System.Drawing.Point(12, 13)
        Me.chkbxSchedChange.Name = "chkbxSchedChange"
        Me.chkbxSchedChange.Size = New System.Drawing.Size(142, 17)
        Me.chkbxSchedChange.TabIndex = 8
        Me.chkbxSchedChange.Text = "Variable Phase Changes"
        Me.chkbxSchedChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdioOptionsManSched)
        Me.GroupBox2.Controls.Add(Me.rdioOptionsAutoSched)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 69)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule Values"
        '
        'rdioOptionsManSched
        '
        Me.rdioOptionsManSched.AutoSize = True
        Me.rdioOptionsManSched.Location = New System.Drawing.Point(7, 44)
        Me.rdioOptionsManSched.Name = "rdioOptionsManSched"
        Me.rdioOptionsManSched.Size = New System.Drawing.Size(140, 17)
        Me.rdioOptionsManSched.TabIndex = 1
        Me.rdioOptionsManSched.Text = "Set Constraints (Manual)"
        Me.rdioOptionsManSched.UseVisualStyleBackColor = True
        '
        'rdioOptionsAutoSched
        '
        Me.rdioOptionsAutoSched.AutoSize = True
        Me.rdioOptionsAutoSched.Checked = True
        Me.rdioOptionsAutoSched.Location = New System.Drawing.Point(6, 21)
        Me.rdioOptionsAutoSched.Name = "rdioOptionsAutoSched"
        Me.rdioOptionsAutoSched.Size = New System.Drawing.Size(123, 17)
        Me.rdioOptionsAutoSched.TabIndex = 0
        Me.rdioOptionsAutoSched.TabStop = True
        Me.rdioOptionsAutoSched.Text = "Algorithm Generation"
        Me.rdioOptionsAutoSched.UseVisualStyleBackColor = True
        '
        'btnSchedules
        '
        Me.btnSchedules.Location = New System.Drawing.Point(79, 142)
        Me.btnSchedules.Name = "btnSchedules"
        Me.btnSchedules.Size = New System.Drawing.Size(75, 35)
        Me.btnSchedules.TabIndex = 16
        Me.btnSchedules.Text = "Edit Schedules"
        Me.btnSchedules.UseVisualStyleBackColor = True
        '
        'pgeProgBar
        '
        Me.pgeProgBar.Controls.Add(Me.chkbxBackCount)
        Me.pgeProgBar.Controls.Add(Me.txtbxOptionsBarValue)
        Me.pgeProgBar.Controls.Add(Me.Label5)
        Me.pgeProgBar.Location = New System.Drawing.Point(4, 22)
        Me.pgeProgBar.Name = "pgeProgBar"
        Me.pgeProgBar.Size = New System.Drawing.Size(232, 286)
        Me.pgeProgBar.TabIndex = 1
        Me.pgeProgBar.Text = "Progress Bar"
        Me.pgeProgBar.UseVisualStyleBackColor = True
        '
        'chkbxBackCount
        '
        Me.chkbxBackCount.AutoSize = True
        Me.chkbxBackCount.Location = New System.Drawing.Point(32, 33)
        Me.chkbxBackCount.Name = "chkbxBackCount"
        Me.chkbxBackCount.Size = New System.Drawing.Size(108, 17)
        Me.chkbxBackCount.TabIndex = 8
        Me.chkbxBackCount.Text = "Rerverse Scoring"
        Me.chkbxBackCount.UseVisualStyleBackColor = True
        '
        'txtbxOptionsBarValue
        '
        Me.txtbxOptionsBarValue.Location = New System.Drawing.Point(159, 11)
        Me.txtbxOptionsBarValue.Name = "txtbxOptionsBarValue"
        Me.txtbxOptionsBarValue.Size = New System.Drawing.Size(40, 20)
        Me.txtbxOptionsBarValue.TabIndex = 5
        Me.txtbxOptionsBarValue.Text = "10"
        Me.txtbxOptionsBarValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Points for Phase Completion:"
        '
        'btnOptionsOK
        '
        Me.btnOptionsOK.Location = New System.Drawing.Point(259, 35)
        Me.btnOptionsOK.Name = "btnOptionsOK"
        Me.btnOptionsOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOptionsOK.TabIndex = 1
        Me.btnOptionsOK.Text = "OK"
        Me.btnOptionsOK.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.btnOptionsOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 334)
        Me.Controls.Add(Me.btnOptionsOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.pgeMatching2Opt.ResumeLayout(False)
        Me.pgeMatching2Opt.PerformLayout()
        Me.grpOptionsManSched.ResumeLayout(False)
        Me.grpOptionsManSched.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pgeProgBar.ResumeLayout(False)
        Me.pgeProgBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pgeMatching2Opt As TabPage
    Friend WithEvents grpOptionsManSched As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOptMin As Label
    Friend WithEvents txtOptSchedDMax As TextBox
    Friend WithEvents txtOptSchedCMax As TextBox
    Friend WithEvents txtOptSchedBMax As TextBox
    Friend WithEvents txtOptSchedAMax As TextBox
    Friend WithEvents txtOptSchedDMin As TextBox
    Friend WithEvents txtOptSchedCMin As TextBox
    Friend WithEvents txtOptSchedBMin As TextBox
    Friend WithEvents txtOptSchedAMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSchedA As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdioOptionsManSched As RadioButton
    Friend WithEvents rdioOptionsAutoSched As RadioButton
    Friend WithEvents btnOptionsOK As Button
    Friend WithEvents pgeProgBar As TabPage
    Friend WithEvents chkbxSchedChange As CheckBox
    Friend WithEvents txtbxOptionsBarValue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkbxBackCount As CheckBox
    Friend WithEvents chkbxOptionsRandom As CheckBox
    Friend WithEvents btnSchedules As Button
End Class
