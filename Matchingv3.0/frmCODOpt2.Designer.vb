<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCODOpt2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCODOpt2))
        Me.picCOD = New System.Windows.Forms.PictureBox()
        Me.tmrCODOpt2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCOD
        '
        Me.picCOD.Image = CType(resources.GetObject("picCOD.Image"), System.Drawing.Image)
        Me.picCOD.InitialImage = CType(resources.GetObject("picCOD.InitialImage"), System.Drawing.Image)
        Me.picCOD.Location = New System.Drawing.Point(12, 12)
        Me.picCOD.Name = "picCOD"
        Me.picCOD.Size = New System.Drawing.Size(159, 202)
        Me.picCOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCOD.TabIndex = 4
        Me.picCOD.TabStop = False
        '
        'tmrCODOpt2
        '
        Me.tmrCODOpt2.Interval = 1000
        '
        'frmCODOpt2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCOD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCODOpt2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Please wait.."
        CType(Me.picCOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCOD As PictureBox
    Friend WithEvents tmrCODOpt2 As Timer
End Class
