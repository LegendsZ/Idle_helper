<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdle_Help
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtPos1 = New System.Windows.Forms.TextBox()
        Me.txtPos2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbDrag = New System.Windows.Forms.RadioButton()
        Me.rdbClick = New System.Windows.Forms.RadioButton()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.bwAnimate = New System.ComponentModel.BackgroundWorker()
        Me.chkTM = New System.Windows.Forms.CheckBox()
        Me.lblMem = New System.Windows.Forms.Label()
        Me.tmrMem = New System.Windows.Forms.Timer(Me.components)
        Me.btnDM = New System.Windows.Forms.Button()
        Me.tmrInterval = New System.Windows.Forms.Timer(Me.components)
        Me.bwMain = New System.ComponentModel.BackgroundWorker()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.pnlControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.White
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(12, 142)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(231, 50)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'txtPos1
        '
        Me.txtPos1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPos1.Location = New System.Drawing.Point(80, 64)
        Me.txtPos1.Name = "txtPos1"
        Me.txtPos1.Size = New System.Drawing.Size(163, 30)
        Me.txtPos1.TabIndex = 2
        Me.txtPos1.Text = "0,0"
        Me.txtPos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPos2
        '
        Me.txtPos2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPos2.Location = New System.Drawing.Point(80, 104)
        Me.txtPos2.Name = "txtPos2"
        Me.txtPos2.Size = New System.Drawing.Size(163, 30)
        Me.txtPos2.TabIndex = 3
        Me.txtPos2.Text = "0,0"
        Me.txtPos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "POS1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "POS2:"
        '
        'rdbDrag
        '
        Me.rdbDrag.AutoSize = True
        Me.rdbDrag.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDrag.Location = New System.Drawing.Point(12, 231)
        Me.rdbDrag.Name = "rdbDrag"
        Me.rdbDrag.Size = New System.Drawing.Size(67, 26)
        Me.rdbDrag.TabIndex = 6
        Me.rdbDrag.TabStop = True
        Me.rdbDrag.Text = "Drag"
        Me.rdbDrag.UseVisualStyleBackColor = True
        '
        'rdbClick
        '
        Me.rdbClick.AutoSize = True
        Me.rdbClick.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbClick.Location = New System.Drawing.Point(171, 231)
        Me.rdbClick.Name = "rdbClick"
        Me.rdbClick.Size = New System.Drawing.Size(71, 26)
        Me.rdbClick.TabIndex = 7
        Me.rdbClick.TabStop = True
        Me.rdbClick.Text = "Click"
        Me.rdbClick.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(12, 366)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(231, 42)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Stop!"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(18, 304)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(223, 23)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "INTERVAL (MINUTES):"
        '
        'txtInterval
        '
        Me.txtInterval.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterval.Location = New System.Drawing.Point(12, 330)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(231, 30)
        Me.txtInterval.TabIndex = 9
        Me.txtInterval.Text = "3"
        Me.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(2, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(63, 23)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Idler | "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(208, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 39)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.lblTitle)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(256, 35)
        Me.pnlControl.TabIndex = 14
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.White
        Me.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMore.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMore.Location = New System.Drawing.Point(12, 198)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(231, 29)
        Me.btnMore.TabIndex = 15
        Me.btnMore.Text = "Show More"
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'bwAnimate
        '
        Me.bwAnimate.WorkerSupportsCancellation = True
        '
        'chkTM
        '
        Me.chkTM.AutoSize = True
        Me.chkTM.Checked = True
        Me.chkTM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTM.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTM.Location = New System.Drawing.Point(88, 232)
        Me.chkTM.Name = "chkTM"
        Me.chkTM.Size = New System.Drawing.Size(67, 26)
        Me.chkTM.TabIndex = 17
        Me.chkTM.Text = "T.M."
        Me.chkTM.UseVisualStyleBackColor = True
        '
        'lblMem
        '
        Me.lblMem.AutoSize = True
        Me.lblMem.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblMem.Location = New System.Drawing.Point(8, 412)
        Me.lblMem.Name = "lblMem"
        Me.lblMem.Size = New System.Drawing.Size(110, 19)
        Me.lblMem.TabIndex = 18
        Me.lblMem.Text = "Memory Usage: "
        '
        'tmrMem
        '
        Me.tmrMem.Interval = 250
        '
        'btnDM
        '
        Me.btnDM.BackColor = System.Drawing.Color.White
        Me.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDM.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.btnDM.Location = New System.Drawing.Point(12, 264)
        Me.btnDM.Name = "btnDM"
        Me.btnDM.Size = New System.Drawing.Size(231, 30)
        Me.btnDM.TabIndex = 19
        Me.btnDM.Text = "Dark Mode"
        Me.btnDM.UseVisualStyleBackColor = False
        '
        'tmrInterval
        '
        Me.tmrInterval.Interval = 1000
        '
        'bwMain
        '
        Me.bwMain.WorkerSupportsCancellation = True
        '
        'lblClicks
        '
        Me.lblClicks.AutoSize = True
        Me.lblClicks.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblClicks.Location = New System.Drawing.Point(8, 39)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(143, 19)
        Me.lblClicks.TabIndex = 20
        Me.lblClicks.Text = " # OF Drags/Clicks: 0"
        '
        'frmIdle_Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(255, 436)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.btnDM)
        Me.Controls.Add(Me.lblMem)
        Me.Controls.Add(Me.chkTM)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.rdbClick)
        Me.Controls.Add(Me.rdbDrag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPos2)
        Me.Controls.Add(Me.txtPos1)
        Me.Controls.Add(Me.btnGo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIdle_Help"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idle Helper"
        Me.TopMost = True
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtPos1 As TextBox
    Friend WithEvents txtPos2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbDrag As RadioButton
    Friend WithEvents rdbClick As RadioButton
    Friend WithEvents btnStop As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMore As Button
    Friend WithEvents bwAnimate As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkTM As CheckBox
    Friend WithEvents lblMem As Label
    Friend WithEvents tmrMem As Timer
    Friend WithEvents btnDM As Button
    Friend WithEvents tmrInterval As Timer
    Friend WithEvents bwMain As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblClicks As Label
End Class
