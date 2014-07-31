<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLateBreaktime
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTimeLBT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbLBTOthers = New System.Windows.Forms.RadioButton()
        Me.rbLBTAccept = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLBTReason = New System.Windows.Forms.TextBox()
        Me.btnLBTSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblTimeLBT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 112)
        Me.Panel1.TabIndex = 23
        '
        'lblTimeLBT
        '
        Me.lblTimeLBT.AutoSize = True
        Me.lblTimeLBT.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLBT.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLBT.ForeColor = System.Drawing.Color.Red
        Me.lblTimeLBT.Location = New System.Drawing.Point(141, 41)
        Me.lblTimeLBT.Name = "lblTimeLBT"
        Me.lblTimeLBT.Size = New System.Drawing.Size(212, 56)
        Me.lblTimeLBT.TabIndex = 8
        Me.lblTimeLBT.Text = "00:00:00"
        Me.lblTimeLBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The Time is:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(35, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rbLBTOthers
        '
        Me.rbLBTOthers.AutoSize = True
        Me.rbLBTOthers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLBTOthers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbLBTOthers.Location = New System.Drawing.Point(30, 52)
        Me.rbLBTOthers.Name = "rbLBTOthers"
        Me.rbLBTOthers.Size = New System.Drawing.Size(77, 22)
        Me.rbLBTOthers.TabIndex = 4
        Me.rbLBTOthers.Text = "Others:"
        Me.rbLBTOthers.UseVisualStyleBackColor = True
        '
        'rbLBTAccept
        '
        Me.rbLBTAccept.AutoSize = True
        Me.rbLBTAccept.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLBTAccept.ForeColor = System.Drawing.Color.White
        Me.rbLBTAccept.Location = New System.Drawing.Point(30, 25)
        Me.rbLBTAccept.Name = "rbLBTAccept"
        Me.rbLBTAccept.Size = New System.Drawing.Size(169, 22)
        Me.rbLBTAccept.TabIndex = 1
        Me.rbLBTAccept.Text = "Accepting Inquiries"
        Me.rbLBTAccept.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbLBTOthers)
        Me.GroupBox1.Controls.Add(Me.rbLBTAccept)
        Me.GroupBox1.Controls.Add(Me.txtLBTReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 188)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REASON"
        '
        'txtLBTReason
        '
        Me.txtLBTReason.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLBTReason.Location = New System.Drawing.Point(49, 79)
        Me.txtLBTReason.Multiline = True
        Me.txtLBTReason.Name = "txtLBTReason"
        Me.txtLBTReason.Size = New System.Drawing.Size(308, 96)
        Me.txtLBTReason.TabIndex = 5
        Me.txtLBTReason.TabStop = False
        Me.txtLBTReason.Tag = ""
        '
        'btnLBTSubmit
        '
        Me.btnLBTSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLBTSubmit.Location = New System.Drawing.Point(262, 335)
        Me.btnLBTSubmit.Name = "btnLBTSubmit"
        Me.btnLBTSubmit.Size = New System.Drawing.Size(115, 35)
        Me.btnLBTSubmit.TabIndex = 22
        Me.btnLBTSubmit.TabStop = False
        Me.btnLBTSubmit.Text = "&SUBMIT"
        Me.btnLBTSubmit.UseVisualStyleBackColor = True
        '
        'frmLateBreaktime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(385, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLBTSubmit)
        Me.Name = "frmLateBreaktime"
        Me.Text = "Late Breaktime"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTimeLBT As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbLBTOthers As System.Windows.Forms.RadioButton
    Friend WithEvents rbLBTAccept As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLBTReason As System.Windows.Forms.TextBox
    Friend WithEvents btnLBTSubmit As System.Windows.Forms.Button
End Class
