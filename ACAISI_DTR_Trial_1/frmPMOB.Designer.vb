<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMOB
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
        Me.rbPMOBOthers = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPMOBAccept = New System.Windows.Forms.RadioButton()
        Me.txtPMOBReason = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPMOBMins = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPMOBHr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPMOBSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbPMOBOthers
        '
        Me.rbPMOBOthers.AutoSize = True
        Me.rbPMOBOthers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPMOBOthers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbPMOBOthers.Location = New System.Drawing.Point(30, 52)
        Me.rbPMOBOthers.Name = "rbPMOBOthers"
        Me.rbPMOBOthers.Size = New System.Drawing.Size(77, 22)
        Me.rbPMOBOthers.TabIndex = 4
        Me.rbPMOBOthers.Text = "Others:"
        Me.rbPMOBOthers.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbPMOBOthers)
        Me.GroupBox1.Controls.Add(Me.rbPMOBAccept)
        Me.GroupBox1.Controls.Add(Me.txtPMOBReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 188)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REASON"
        '
        'rbPMOBAccept
        '
        Me.rbPMOBAccept.AutoSize = True
        Me.rbPMOBAccept.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPMOBAccept.ForeColor = System.Drawing.Color.White
        Me.rbPMOBAccept.Location = New System.Drawing.Point(30, 25)
        Me.rbPMOBAccept.Name = "rbPMOBAccept"
        Me.rbPMOBAccept.Size = New System.Drawing.Size(169, 22)
        Me.rbPMOBAccept.TabIndex = 1
        Me.rbPMOBAccept.Text = "Accepting Inquiries"
        Me.rbPMOBAccept.UseVisualStyleBackColor = True
        '
        'txtPMOBReason
        '
        Me.txtPMOBReason.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPMOBReason.Location = New System.Drawing.Point(49, 79)
        Me.txtPMOBReason.Multiline = True
        Me.txtPMOBReason.Name = "txtPMOBReason"
        Me.txtPMOBReason.Size = New System.Drawing.Size(308, 96)
        Me.txtPMOBReason.TabIndex = 5
        Me.txtPMOBReason.TabStop = False
        Me.txtPMOBReason.Tag = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblPMOBMins)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPMOBHr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 112)
        Me.Panel1.TabIndex = 32
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
        'lblPMOBMins
        '
        Me.lblPMOBMins.AutoSize = True
        Me.lblPMOBMins.BackColor = System.Drawing.Color.Transparent
        Me.lblPMOBMins.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPMOBMins.ForeColor = System.Drawing.Color.Red
        Me.lblPMOBMins.Location = New System.Drawing.Point(239, 42)
        Me.lblPMOBMins.Name = "lblPMOBMins"
        Me.lblPMOBMins.Size = New System.Drawing.Size(78, 56)
        Me.lblPMOBMins.TabIndex = 10
        Me.lblPMOBMins.Text = "00"
        Me.lblPMOBMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblPMOBHr
        '
        Me.lblPMOBHr.AutoSize = True
        Me.lblPMOBHr.BackColor = System.Drawing.Color.Transparent
        Me.lblPMOBHr.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPMOBHr.ForeColor = System.Drawing.Color.Red
        Me.lblPMOBHr.Location = New System.Drawing.Point(120, 42)
        Me.lblPMOBHr.Name = "lblPMOBHr"
        Me.lblPMOBHr.Size = New System.Drawing.Size(78, 56)
        Me.lblPMOBHr.TabIndex = 8
        Me.lblPMOBHr.Text = "00"
        Me.lblPMOBHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnPMOBSubmit
        '
        Me.btnPMOBSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPMOBSubmit.Location = New System.Drawing.Point(262, 336)
        Me.btnPMOBSubmit.Name = "btnPMOBSubmit"
        Me.btnPMOBSubmit.Size = New System.Drawing.Size(115, 35)
        Me.btnPMOBSubmit.TabIndex = 31
        Me.btnPMOBSubmit.TabStop = False
        Me.btnPMOBSubmit.Text = "&SUBMIT"
        Me.btnPMOBSubmit.UseVisualStyleBackColor = True
        '
        'frmPMOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(385, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPMOBSubmit)
        Me.Name = "frmPMOB"
        Me.Text = "PM Overbreak Reason"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbPMOBOthers As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPMOBAccept As System.Windows.Forms.RadioButton
    Friend WithEvents txtPMOBReason As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPMOBMins As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPMOBHr As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPMOBSubmit As System.Windows.Forms.Button
End Class
