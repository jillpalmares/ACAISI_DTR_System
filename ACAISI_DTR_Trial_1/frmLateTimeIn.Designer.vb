<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLateTimeIn
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.rbEightam = New System.Windows.Forms.RadioButton()
        Me.rbOnsite = New System.Windows.Forms.RadioButton()
        Me.rbHalfday = New System.Windows.Forms.RadioButton()
        Me.rbOthers = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 112)
        Me.Panel1.TabIndex = 20
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbOthers)
        Me.GroupBox1.Controls.Add(Me.rbHalfday)
        Me.GroupBox1.Controls.Add(Me.rbOnsite)
        Me.GroupBox1.Controls.Add(Me.rbEightam)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 247)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REASON"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(49, 135)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(308, 96)
        Me.txtReason.TabIndex = 5
        Me.txtReason.TabStop = False
        Me.txtReason.Tag = ""
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(263, 393)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(115, 35)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.TabStop = False
        Me.btnSubmit.Text = "&SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'rbEightam
        '
        Me.rbEightam.AutoSize = True
        Me.rbEightam.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEightam.ForeColor = System.Drawing.Color.White
        Me.rbEightam.Location = New System.Drawing.Point(30, 25)
        Me.rbEightam.Name = "rbEightam"
        Me.rbEightam.Size = New System.Drawing.Size(140, 22)
        Me.rbEightam.TabIndex = 1
        Me.rbEightam.Text = "8:00 AM TIME-IN"
        Me.rbEightam.UseVisualStyleBackColor = True
        '
        'rbOnsite
        '
        Me.rbOnsite.AutoSize = True
        Me.rbOnsite.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOnsite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbOnsite.Location = New System.Drawing.Point(30, 51)
        Me.rbOnsite.Name = "rbOnsite"
        Me.rbOnsite.Size = New System.Drawing.Size(82, 22)
        Me.rbOnsite.TabIndex = 2
        Me.rbOnsite.Text = "ON-SITE"
        Me.rbOnsite.UseVisualStyleBackColor = True
        '
        'rbHalfday
        '
        Me.rbHalfday.AutoSize = True
        Me.rbHalfday.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalfday.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbHalfday.Location = New System.Drawing.Point(30, 80)
        Me.rbHalfday.Name = "rbHalfday"
        Me.rbHalfday.Size = New System.Drawing.Size(98, 22)
        Me.rbHalfday.TabIndex = 3
        Me.rbHalfday.Text = "HALF-DAY"
        Me.rbHalfday.UseVisualStyleBackColor = True
        '
        'rbOthers
        '
        Me.rbOthers.AutoSize = True
        Me.rbOthers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOthers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbOthers.Location = New System.Drawing.Point(30, 108)
        Me.rbOthers.Name = "rbOthers"
        Me.rbOthers.Size = New System.Drawing.Size(77, 22)
        Me.rbOthers.TabIndex = 4
        Me.rbOthers.Text = "Others:"
        Me.rbOthers.UseVisualStyleBackColor = True
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
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(141, 41)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(212, 56)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLateTimeIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(385, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLateTimeIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Late Time-In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents rbOthers As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalfday As System.Windows.Forms.RadioButton
    Friend WithEvents rbOnsite As System.Windows.Forms.RadioButton
    Friend WithEvents rbEightam As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
