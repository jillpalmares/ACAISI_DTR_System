<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMOB
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
        Me.rbAMOBAccept = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAMOBMins = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAMOBHr = New System.Windows.Forms.Label()
        Me.lblConsumed = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbAMOBOthers = New System.Windows.Forms.RadioButton()
        Me.txtAMOBReason = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAMOBSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbAMOBAccept
        '
        Me.rbAMOBAccept.AutoSize = True
        Me.rbAMOBAccept.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAMOBAccept.ForeColor = System.Drawing.Color.White
        Me.rbAMOBAccept.Location = New System.Drawing.Point(30, 25)
        Me.rbAMOBAccept.Name = "rbAMOBAccept"
        Me.rbAMOBAccept.Size = New System.Drawing.Size(169, 22)
        Me.rbAMOBAccept.TabIndex = 1
        Me.rbAMOBAccept.Text = "Accepting Inquiries"
        Me.rbAMOBAccept.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblAMOBMins)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblAMOBHr)
        Me.Panel1.Controls.Add(Me.lblConsumed)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 112)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(308, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "mins"
        '
        'lblAMOBMins
        '
        Me.lblAMOBMins.AutoSize = True
        Me.lblAMOBMins.BackColor = System.Drawing.Color.Transparent
        Me.lblAMOBMins.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMOBMins.ForeColor = System.Drawing.Color.Red
        Me.lblAMOBMins.Location = New System.Drawing.Point(240, 42)
        Me.lblAMOBMins.Name = "lblAMOBMins"
        Me.lblAMOBMins.Size = New System.Drawing.Size(78, 56)
        Me.lblAMOBMins.TabIndex = 16
        Me.lblAMOBMins.Text = "00"
        Me.lblAMOBMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(188, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "hrs &&"
        '
        'lblAMOBHr
        '
        Me.lblAMOBHr.AutoSize = True
        Me.lblAMOBHr.BackColor = System.Drawing.Color.Transparent
        Me.lblAMOBHr.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMOBHr.ForeColor = System.Drawing.Color.Red
        Me.lblAMOBHr.Location = New System.Drawing.Point(121, 42)
        Me.lblAMOBHr.Name = "lblAMOBHr"
        Me.lblAMOBHr.Size = New System.Drawing.Size(78, 56)
        Me.lblAMOBHr.TabIndex = 14
        Me.lblAMOBHr.Text = "00"
        Me.lblAMOBHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConsumed
        '
        Me.lblConsumed.AutoSize = True
        Me.lblConsumed.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsumed.Location = New System.Drawing.Point(135, 14)
        Me.lblConsumed.Name = "lblConsumed"
        Me.lblConsumed.Size = New System.Drawing.Size(229, 25)
        Me.lblConsumed.TabIndex = 13
        Me.lblConsumed.Text = "You have consumed:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(21, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'rbAMOBOthers
        '
        Me.rbAMOBOthers.AutoSize = True
        Me.rbAMOBOthers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAMOBOthers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rbAMOBOthers.Location = New System.Drawing.Point(30, 52)
        Me.rbAMOBOthers.Name = "rbAMOBOthers"
        Me.rbAMOBOthers.Size = New System.Drawing.Size(77, 22)
        Me.rbAMOBOthers.TabIndex = 4
        Me.rbAMOBOthers.Text = "Others:"
        Me.rbAMOBOthers.UseVisualStyleBackColor = True
        '
        'txtAMOBReason
        '
        Me.txtAMOBReason.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMOBReason.Location = New System.Drawing.Point(49, 79)
        Me.txtAMOBReason.Multiline = True
        Me.txtAMOBReason.Name = "txtAMOBReason"
        Me.txtAMOBReason.Size = New System.Drawing.Size(308, 96)
        Me.txtAMOBReason.TabIndex = 5
        Me.txtAMOBReason.TabStop = False
        Me.txtAMOBReason.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbAMOBOthers)
        Me.GroupBox1.Controls.Add(Me.rbAMOBAccept)
        Me.GroupBox1.Controls.Add(Me.txtAMOBReason)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 188)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REASON"
        '
        'btnAMOBSubmit
        '
        Me.btnAMOBSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAMOBSubmit.Location = New System.Drawing.Point(262, 336)
        Me.btnAMOBSubmit.Name = "btnAMOBSubmit"
        Me.btnAMOBSubmit.Size = New System.Drawing.Size(115, 35)
        Me.btnAMOBSubmit.TabIndex = 25
        Me.btnAMOBSubmit.TabStop = False
        Me.btnAMOBSubmit.Text = "&SUBMIT"
        Me.btnAMOBSubmit.UseVisualStyleBackColor = True
        '
        'frmAMOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(385, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAMOBSubmit)
        Me.Name = "frmAMOB"
        Me.Text = "AM Overbreak Reason"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbAMOBAccept As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbAMOBOthers As System.Windows.Forms.RadioButton
    Friend WithEvents txtAMOBReason As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAMOBSubmit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAMOBMins As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAMOBHr As System.Windows.Forms.Label
    Friend WithEvents lblConsumed As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
