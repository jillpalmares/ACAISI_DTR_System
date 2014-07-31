<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAdminTop = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.tabEmployees = New System.Windows.Forms.TabPage()
        Me.panMenuBar = New System.Windows.Forms.Panel()
        Me.btnEmpReport = New System.Windows.Forms.Button()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmptypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acclevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb1DataSet = New WindowsApplication1.dtrdb1DataSet()
        Me.tabAdminOpt = New System.Windows.Forms.TabControl()
        Me.TblEmployeesTableAdapter = New WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter()
        Me.TblEmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabTardinessReport = New System.Windows.Forms.TabPage()
        Me.btnViewInactive = New System.Windows.Forms.Button()
        Me.pnlAdminTop.SuspendLayout()
        Me.tabEmployees.SuspendLayout()
        Me.panMenuBar.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdminOpt.SuspendLayout()
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAdminTop
        '
        Me.pnlAdminTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlAdminTop.Controls.Add(Me.btnLogout)
        Me.pnlAdminTop.Controls.Add(Me.lblWelcome)
        Me.pnlAdminTop.Location = New System.Drawing.Point(1, 1)
        Me.pnlAdminTop.Name = "pnlAdminTop"
        Me.pnlAdminTop.Size = New System.Drawing.Size(1123, 47)
        Me.pnlAdminTop.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1010, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(90, 33)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "L&og-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(859, 16)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(136, 18)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Admin!"
        '
        'tabReports
        '
        Me.tabReports.BackColor = System.Drawing.Color.Gainsboro
        Me.tabReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabReports.Location = New System.Drawing.Point(4, 33)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(1114, 545)
        Me.tabReports.TabIndex = 1
        Me.tabReports.Text = "TIME LOG"
        '
        'tabEmployees
        '
        Me.tabEmployees.BackColor = System.Drawing.Color.DarkGray
        Me.tabEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabEmployees.Controls.Add(Me.panMenuBar)
        Me.tabEmployees.Controls.Add(Me.dgvData)
        Me.tabEmployees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEmployees.Location = New System.Drawing.Point(4, 33)
        Me.tabEmployees.Name = "tabEmployees"
        Me.tabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmployees.Size = New System.Drawing.Size(1114, 545)
        Me.tabEmployees.TabIndex = 0
        Me.tabEmployees.Text = "EMPLOYEES"
        '
        'panMenuBar
        '
        Me.panMenuBar.BackColor = System.Drawing.Color.Gainsboro
        Me.panMenuBar.Controls.Add(Me.btnViewInactive)
        Me.panMenuBar.Controls.Add(Me.btnEmpReport)
        Me.panMenuBar.Controls.Add(Me.btnDeleteEmp)
        Me.panMenuBar.Controls.Add(Me.btnEditEmp)
        Me.panMenuBar.Controls.Add(Me.btnAddEmp)
        Me.panMenuBar.Location = New System.Drawing.Point(3, 2)
        Me.panMenuBar.Name = "panMenuBar"
        Me.panMenuBar.Size = New System.Drawing.Size(1108, 36)
        Me.panMenuBar.TabIndex = 1
        '
        'btnEmpReport
        '
        Me.btnEmpReport.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.report
        Me.btnEmpReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpReport.Location = New System.Drawing.Point(120, 1)
        Me.btnEmpReport.Name = "btnEmpReport"
        Me.btnEmpReport.Size = New System.Drawing.Size(34, 34)
        Me.btnEmpReport.TabIndex = 3
        Me.btnEmpReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpReport.UseVisualStyleBackColor = True
        '
        'btnDeleteEmp
        '
        Me.btnDeleteEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Delete
        Me.btnDeleteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteEmp.Location = New System.Drawing.Point(81, 1)
        Me.btnDeleteEmp.Name = "btnDeleteEmp"
        Me.btnDeleteEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnDeleteEmp.TabIndex = 2
        Me.btnDeleteEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteEmp.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.document_edit
        Me.btnEditEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditEmp.Location = New System.Drawing.Point(42, 1)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnEditEmp.TabIndex = 1
        Me.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAddEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEmp.Location = New System.Drawing.Point(3, 1)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(34, 34)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmpnumDataGridViewTextBoxColumn, Me.PinnumDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.EmpposDataGridViewTextBoxColumn, Me.EmptypeDataGridViewTextBoxColumn, Me.acclevel})
        Me.dgvData.DataSource = Me.TblEmployeesBindingSource
        Me.dgvData.Location = New System.Drawing.Point(3, 44)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(1108, 506)
        Me.dgvData.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'EmpnumDataGridViewTextBoxColumn
        '
        Me.EmpnumDataGridViewTextBoxColumn.DataPropertyName = "empnum"
        Me.EmpnumDataGridViewTextBoxColumn.HeaderText = "Employee Number"
        Me.EmpnumDataGridViewTextBoxColumn.Name = "EmpnumDataGridViewTextBoxColumn"
        Me.EmpnumDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpnumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PinnumDataGridViewTextBoxColumn
        '
        Me.PinnumDataGridViewTextBoxColumn.DataPropertyName = "pinnum"
        Me.PinnumDataGridViewTextBoxColumn.HeaderText = "DTR PIN"
        Me.PinnumDataGridViewTextBoxColumn.Name = "PinnumDataGridViewTextBoxColumn"
        Me.PinnumDataGridViewTextBoxColumn.ReadOnly = True
        Me.PinnumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmpposDataGridViewTextBoxColumn
        '
        Me.EmpposDataGridViewTextBoxColumn.DataPropertyName = "emppos"
        Me.EmpposDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.EmpposDataGridViewTextBoxColumn.Name = "EmpposDataGridViewTextBoxColumn"
        Me.EmpposDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpposDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'EmptypeDataGridViewTextBoxColumn
        '
        Me.EmptypeDataGridViewTextBoxColumn.DataPropertyName = "emptype"
        Me.EmptypeDataGridViewTextBoxColumn.HeaderText = "Employee Type"
        Me.EmptypeDataGridViewTextBoxColumn.Name = "EmptypeDataGridViewTextBoxColumn"
        Me.EmptypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmptypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'acclevel
        '
        Me.acclevel.DataPropertyName = "acclevel"
        Me.acclevel.HeaderText = "Access Level"
        Me.acclevel.Name = "acclevel"
        Me.acclevel.ReadOnly = True
        Me.acclevel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TblEmployeesBindingSource
        '
        Me.TblEmployeesBindingSource.DataMember = "tblEmployees"
        Me.TblEmployeesBindingSource.DataSource = Me.Dtrdb1DataSetBindingSource
        '
        'Dtrdb1DataSetBindingSource
        '
        Me.Dtrdb1DataSetBindingSource.DataSource = Me.Dtrdb1DataSet
        Me.Dtrdb1DataSetBindingSource.Position = 0
        '
        'Dtrdb1DataSet
        '
        Me.Dtrdb1DataSet.DataSetName = "dtrdb1DataSet"
        Me.Dtrdb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabAdminOpt
        '
        Me.tabAdminOpt.Controls.Add(Me.tabEmployees)
        Me.tabAdminOpt.Controls.Add(Me.tabReports)
        Me.tabAdminOpt.Controls.Add(Me.tabTardinessReport)
        Me.tabAdminOpt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdminOpt.Location = New System.Drawing.Point(2, 52)
        Me.tabAdminOpt.Name = "tabAdminOpt"
        Me.tabAdminOpt.Padding = New System.Drawing.Point(30, 7)
        Me.tabAdminOpt.SelectedIndex = 0
        Me.tabAdminOpt.Size = New System.Drawing.Size(1122, 582)
        Me.tabAdminOpt.TabIndex = 1
        '
        'TblEmployeesTableAdapter
        '
        Me.TblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'tabTardinessReport
        '
        Me.tabTardinessReport.BackColor = System.Drawing.Color.Gainsboro
        Me.tabTardinessReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabTardinessReport.Location = New System.Drawing.Point(4, 33)
        Me.tabTardinessReport.Name = "tabTardinessReport"
        Me.tabTardinessReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTardinessReport.Size = New System.Drawing.Size(1114, 545)
        Me.tabTardinessReport.TabIndex = 2
        Me.tabTardinessReport.Text = "TARDINESS REPORT"
        '
        'btnViewInactive
        '
        Me.btnViewInactive.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInactive.Location = New System.Drawing.Point(966, 1)
        Me.btnViewInactive.Name = "btnViewInactive"
        Me.btnViewInactive.Size = New System.Drawing.Size(135, 33)
        Me.btnViewInactive.TabIndex = 2
        Me.btnViewInactive.Text = "View Inactive List"
        Me.btnViewInactive.UseVisualStyleBackColor = True
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1121, 640)
        Me.Controls.Add(Me.pnlAdminTop)
        Me.Controls.Add(Me.tabAdminOpt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrators Log-in"
        Me.pnlAdminTop.ResumeLayout(False)
        Me.pnlAdminTop.PerformLayout()
        Me.tabEmployees.ResumeLayout(False)
        Me.panMenuBar.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdminOpt.ResumeLayout(False)
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAdminTop As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents tabReports As System.Windows.Forms.TabPage
    Friend WithEvents tabEmployees As System.Windows.Forms.TabPage
    Friend WithEvents TblEmployeesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tabAdminOpt As System.Windows.Forms.TabControl
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents panMenuBar As System.Windows.Forms.Panel
    Friend WithEvents btnEditEmp As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
    Friend WithEvents Dtrdb1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dtrdb1DataSet As WindowsApplication1.dtrdb1DataSet
    Friend WithEvents TblEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeesTableAdapter As WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmptypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acclevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEmpReport As System.Windows.Forms.Button
    Friend WithEvents tabTardinessReport As System.Windows.Forms.TabPage
    Friend WithEvents btnViewInactive As System.Windows.Forms.Button
End Class
