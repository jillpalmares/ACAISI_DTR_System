<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelEmp
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
        Me.lblDelEmpHeader = New System.Windows.Forms.Label()
        Me.btnConfirmDelete = New System.Windows.Forms.Button()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.gbDelEmpReason = New System.Windows.Forms.GroupBox()
        Me.DTPickerDelEmp = New System.Windows.Forms.DateTimePicker()
        Me.lbldateeffective = New System.Windows.Forms.Label()
        Me.txtDelReason = New System.Windows.Forms.TextBox()
        Me.lblDelReason = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbDelEmpReason.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblDelEmpHeader)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 52)
        Me.Panel1.TabIndex = 0
        '
        'lblDelEmpHeader
        '
        Me.lblDelEmpHeader.AutoSize = True
        Me.lblDelEmpHeader.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelEmpHeader.ForeColor = System.Drawing.Color.White
        Me.lblDelEmpHeader.Location = New System.Drawing.Point(4, 12)
        Me.lblDelEmpHeader.Name = "lblDelEmpHeader"
        Me.lblDelEmpHeader.Size = New System.Drawing.Size(210, 28)
        Me.lblDelEmpHeader.TabIndex = 0
        Me.lblDelEmpHeader.Text = "DELETE EMPLOYEE"
        '
        'btnConfirmDelete
        '
        Me.btnConfirmDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmDelete.Location = New System.Drawing.Point(75, 258)
        Me.btnConfirmDelete.Name = "btnConfirmDelete"
        Me.btnConfirmDelete.Size = New System.Drawing.Size(98, 35)
        Me.btnConfirmDelete.TabIndex = 2
        Me.btnConfirmDelete.Text = "&Confirm"
        Me.btnConfirmDelete.UseVisualStyleBackColor = True
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelete.Location = New System.Drawing.Point(179, 258)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(98, 35)
        Me.btnCancelDelete.TabIndex = 3
        Me.btnCancelDelete.Text = "C&ancel"
        Me.btnCancelDelete.UseVisualStyleBackColor = True
        '
        'gbDelEmpReason
        '
        Me.gbDelEmpReason.BackColor = System.Drawing.Color.Gainsboro
        Me.gbDelEmpReason.Controls.Add(Me.DTPickerDelEmp)
        Me.gbDelEmpReason.Controls.Add(Me.lbldateeffective)
        Me.gbDelEmpReason.Controls.Add(Me.txtDelReason)
        Me.gbDelEmpReason.Controls.Add(Me.lblDelReason)
        Me.gbDelEmpReason.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDelEmpReason.Location = New System.Drawing.Point(7, 62)
        Me.gbDelEmpReason.Name = "gbDelEmpReason"
        Me.gbDelEmpReason.Size = New System.Drawing.Size(270, 190)
        Me.gbDelEmpReason.TabIndex = 4
        Me.gbDelEmpReason.TabStop = False
        '
        'DTPickerDelEmp
        '
        Me.DTPickerDelEmp.Location = New System.Drawing.Point(36, 145)
        Me.DTPickerDelEmp.Name = "DTPickerDelEmp"
        Me.DTPickerDelEmp.Size = New System.Drawing.Size(228, 23)
        Me.DTPickerDelEmp.TabIndex = 3
        '
        'lbldateeffective
        '
        Me.lbldateeffective.AutoSize = True
        Me.lbldateeffective.Location = New System.Drawing.Point(6, 113)
        Me.lbldateeffective.Name = "lbldateeffective"
        Me.lbldateeffective.Size = New System.Drawing.Size(126, 17)
        Me.lbldateeffective.TabIndex = 2
        Me.lbldateeffective.Text = "Date of Effectivity:"
        '
        'txtDelReason
        '
        Me.txtDelReason.Location = New System.Drawing.Point(6, 38)
        Me.txtDelReason.Multiline = True
        Me.txtDelReason.Name = "txtDelReason"
        Me.txtDelReason.Size = New System.Drawing.Size(258, 61)
        Me.txtDelReason.TabIndex = 1
        '
        'lblDelReason
        '
        Me.lblDelReason.AutoSize = True
        Me.lblDelReason.Location = New System.Drawing.Point(4, 18)
        Me.lblDelReason.Name = "lblDelReason"
        Me.lblDelReason.Size = New System.Drawing.Size(147, 17)
        Me.lblDelReason.TabIndex = 0
        Me.lblDelReason.Text = "Please specify reason:"
        '
        'frmDelEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(284, 301)
        Me.Controls.Add(Me.gbDelEmpReason)
        Me.Controls.Add(Me.btnCancelDelete)
        Me.Controls.Add(Me.btnConfirmDelete)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDelEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbDelEmpReason.ResumeLayout(False)
        Me.gbDelEmpReason.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDelEmpHeader As System.Windows.Forms.Label
    Friend WithEvents btnConfirmDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents gbDelEmpReason As System.Windows.Forms.GroupBox
    Friend WithEvents DTPickerDelEmp As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldateeffective As System.Windows.Forms.Label
    Friend WithEvents txtDelReason As System.Windows.Forms.TextBox
    Friend WithEvents lblDelReason As System.Windows.Forms.Label
End Class
