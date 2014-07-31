<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunchOB
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLOBMins = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLOBHr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbLOBOthers = New System.Windows.Forms.RadioButton()
        Me.rbLOBAccept = New System.Windows.Forms.RadioButton()
        Me.txtLOBReason = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLOBSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblLOBMins)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblLOBHr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 112)
        Me.Panel1.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(307, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "mins"
        '
        'lblLOBMins
        '
        Me.lblLOBMins.AutoSize = True
        Me.lblLOBMins.BackColor = System.Drawing.Color.Transparent
        Me.lblLOBMins.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLOBMins.ForeColor = System.Drawing.Color.Red
        Me.lblLOBMins.Location = New System.Drawing.Point(239, 42)
        Me.lblLOBMins.Name = "lblLOBMins"
        Me.lblLOBMins.Size = New System.Drawing.Size(78, 56)
        Me.lblLOBMins.TabIndex = 10
        Me.lblLOBMins.Text = "00"
        Me.lblLOBMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(187, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "hrs &&"
        '
        'lblLOBHr
        '
        Me.lblLOBHr.AutoSize = True
        Me.lblLOBHr.BackColor = System.Drawing.Color.Transparent
        Me.lblLOBHr.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLOBHr.ForeColor = System.Drawing.Color.Red
        Me.lblLOBHr.Location = New System.Drawing.Point(120, 42)
        Me.lblLOBHr.Name = "lblLOBHr"
        Me.lblLOBHr.Size = New System.Drawing.Size(78, 56)
        Me.lblLOBHr.TabIndex = 8
        Me.lblLOBHr.Text = "00"
        Me.lblLOBHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "You have consumed:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(20, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rbLOBOthers
        '
        Me.rbLOBOthers.AutoSize = True
        Me.rbLOBOthers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLOBOthers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbLOBOthers.Location = New System.Drawing.Point(30, 52)
        Me.rbLOBOthers.Name = "rbLOBOthers"
        Me.rbLOBOthers.Size = New System.Drawing.Size(77, 22)
        Me.rbLOBOthers.TabIndex = 4
        Me.rbLOBOthers.Text = "Others:"
        Me.rbLOBOthers.UseVisualStyleBackColor = True
        '
        'rbLOBAccept
        '
        Me.rbLOBAccept.AutoSize = True
        Me.rbLOBAccept.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLOBAccept.ForeColor = System.Drawing.Color.White
        Me.rbLOBAccept.Location = New System.Drawing.Point(30, 25)
        Me.rbLOBAccept.Name = "rbLOBAccept"
        Me.rbLOBAccept.Size = New System.Drawing.Size(169, 22)
        Me.rbLOBAccept.TabIndex = 1
        Me.rbLOBAccept.Text = "Accepting Inquiries"
        Me.rbLOBAccept.UseVisualStyleBackColor = True
        '
        'txtLOBReason
        '
        Me.txtLOBReason.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLOBReason.Location = New System.Drawing.Point(49, 79)
        Me.txtLOBReason.Multiline = True
        Me.txtLOBReason.Name = "txtLOBReason"
        Me.txtLOBReason.Size = New System.Drawing.Size(308, 96)
        Me.txtLOBReason.TabIndex = 5
        Me.txtLOBReason.TabStop = False
        Me.txtLOBReason.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbLOBOthers)
        Me.GroupBox1.Controls.Add(Me.rbLOBAccept)
        Me.GroupBox1.Controls.Add(Me.txtLOBReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 188)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REASON"
        '
        'btnLOBSubmit
        '
        Me.btnLOBSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOBSubmit.Location = New System.Drawing.Point(262, 336)
        Me.btnLOBSubmit.Name = "btnLOBSubmit"
        Me.btnLOBSubmit.Size = New System.Drawing.Size(115, 35)
        Me.btnLOBSubmit.TabIndex = 28
        Me.btnLOBSubmit.TabStop = False
        Me.btnLOBSubmit.Text = "&SUBMIT"
        Me.btnLOBSubmit.UseVisualStyleBackColor = True
        '
        'frmLunchOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(385, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLOBSubmit)
        Me.Name = "frmLunchOB"
        Me.Text = "Lunch Overbreak Reason"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbLOBOthers As System.Windows.Forms.RadioButton
    Friend WithEvents rbLOBAccept As System.Windows.Forms.RadioButton
    Friend WithEvents txtLOBReason As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLOBSubmit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLOBMins As System.Windows.Forms.Label
    Friend WithEvents lblLOBHr As System.Windows.Forms.Label
End Class
