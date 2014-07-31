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
        Me.pnlAdminTop = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.dgvDataTL = New System.Windows.Forms.DataGridView()
        Me.TblTimeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb2DataSet = New WindowsApplication1.dtrdb2DataSet()
        Me.tabEmployees = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.QryDGViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb2DataSet1 = New WindowsApplication1.dtrdb2DataSet1()
        Me.panMenuBar = New System.Windows.Forms.Panel()
        Me.btnViewInactive = New System.Windows.Forms.Button()
        Me.btnEmpReport = New System.Windows.Forms.Button()
        Me.btnDeleteEmp = New System.Windows.Forms.Button()
        Me.btnEditEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.QryLateAMBrkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryempnameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dtrdb1DataSet = New WindowsApplication1.dtrdb1DataSet()
        Me.tabAdminOpt = New System.Windows.Forms.TabControl()
        Me.tabTardinessReport = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblTimeLogBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabOverbreakReport = New System.Windows.Forms.TabPage()
        Me.TblEmployeesTableAdapter = New WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter()
        Me.TblEmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesTableAdapter1 = New WindowsApplication1.dtrdb2DataSetTableAdapters.tblEmployeesTableAdapter()
        Me.QryempnameTableAdapter = New WindowsApplication1.dtrdb2DataSetTableAdapters.qryempnameTableAdapter()
        Me.QryLateAMBrkTableAdapter = New WindowsApplication1.dtrdb2DataSetTableAdapters.qryLateAMBrkTableAdapter()
        Me.QryDGViewTableAdapter = New WindowsApplication1.dtrdb2DataSet1TableAdapters.qryDGViewTableAdapter()
        Me.TblTimeLogTableAdapter = New WindowsApplication1.dtrdb2DataSetTableAdapters.tblTimeLogTableAdapter()
        Me.TblTimeLogBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlAdminTop.SuspendLayout()
        Me.tabReports.SuspendLayout()
        CType(Me.dgvDataTL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTimeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEmployees.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryDGViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panMenuBar.SuspendLayout()
        CType(Me.QryLateAMBrkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryempnameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtrdb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdminOpt.SuspendLayout()
        Me.tabTardinessReport.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTimeLogBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTimeLogBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabReports.Controls.Add(Me.dgvDataTL)
        Me.tabReports.Location = New System.Drawing.Point(4, 33)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(1114, 545)
        Me.tabReports.TabIndex = 1
        Me.tabReports.Text = "TIME LOG"
        '
        'dgvDataTL
        '
        Me.dgvDataTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataTL.Location = New System.Drawing.Point(1, 46)
        Me.dgvDataTL.Name = "dgvDataTL"
        Me.dgvDataTL.Size = New System.Drawing.Size(1108, 489)
        Me.dgvDataTL.TabIndex = 0
        '
        'TblTimeLogBindingSource
        '
        Me.TblTimeLogBindingSource.DataMember = "tblTimeLog"
        Me.TblTimeLogBindingSource.DataSource = Me.Dtrdb2DataSetBindingSource
        '
        'Dtrdb2DataSetBindingSource
        '
        Me.Dtrdb2DataSetBindingSource.DataSource = Me.Dtrdb2DataSet
        Me.Dtrdb2DataSetBindingSource.Position = 0
        '
        'Dtrdb2DataSet
        '
        Me.Dtrdb2DataSet.DataSetName = "dtrdb2DataSet"
        Me.Dtrdb2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tabEmployees
        '
        Me.tabEmployees.BackColor = System.Drawing.Color.DarkGray
        Me.tabEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabEmployees.Controls.Add(Me.dgvData)
        Me.tabEmployees.Controls.Add(Me.panMenuBar)
        Me.tabEmployees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEmployees.Location = New System.Drawing.Point(4, 33)
        Me.tabEmployees.Name = "tabEmployees"
        Me.tabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmployees.Size = New System.Drawing.Size(1114, 545)
        Me.tabEmployees.TabIndex = 0
        Me.tabEmployees.Text = "EMPLOYEES"
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(3, 44)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(1106, 491)
        Me.dgvData.TabIndex = 2
        '
        'QryDGViewBindingSource
        '
        Me.QryDGViewBindingSource.DataMember = "qryDGView"
        Me.QryDGViewBindingSource.DataSource = Me.Dtrdb2DataSet1
        '
        'Dtrdb2DataSet1
        '
        Me.Dtrdb2DataSet1.DataSetName = "dtrdb2DataSet1"
        Me.Dtrdb2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'QryLateAMBrkBindingSource
        '
        Me.QryLateAMBrkBindingSource.DataMember = "qryLateAMBrk"
        Me.QryLateAMBrkBindingSource.DataSource = Me.Dtrdb2DataSetBindingSource
        '
        'QryempnameBindingSource
        '
        Me.QryempnameBindingSource.DataMember = "qryempname"
        Me.QryempnameBindingSource.DataSource = Me.Dtrdb2DataSetBindingSource
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
        Me.tabAdminOpt.Controls.Add(Me.tabOverbreakReport)
        Me.tabAdminOpt.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdminOpt.Location = New System.Drawing.Point(2, 52)
        Me.tabAdminOpt.Name = "tabAdminOpt"
        Me.tabAdminOpt.Padding = New System.Drawing.Point(30, 7)
        Me.tabAdminOpt.SelectedIndex = 0
        Me.tabAdminOpt.Size = New System.Drawing.Size(1122, 582)
        Me.tabAdminOpt.TabIndex = 1
        '
        'tabTardinessReport
        '
        Me.tabTardinessReport.BackColor = System.Drawing.Color.Gainsboro
        Me.tabTardinessReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabTardinessReport.Controls.Add(Me.DataGridView1)
        Me.tabTardinessReport.Location = New System.Drawing.Point(4, 33)
        Me.tabTardinessReport.Name = "tabTardinessReport"
        Me.tabTardinessReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTardinessReport.Size = New System.Drawing.Size(1114, 545)
        Me.tabTardinessReport.TabIndex = 2
        Me.tabTardinessReport.Text = "TARDINESS REPORT"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1108, 489)
        Me.DataGridView1.TabIndex = 0
        '
        'TblTimeLogBindingSource2
        '
        Me.TblTimeLogBindingSource2.DataMember = "tblTimeLog"
        Me.TblTimeLogBindingSource2.DataSource = Me.Dtrdb2DataSetBindingSource
        '
        'tabOverbreakReport
        '
        Me.tabOverbreakReport.BackColor = System.Drawing.Color.Gainsboro
        Me.tabOverbreakReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabOverbreakReport.Location = New System.Drawing.Point(4, 33)
        Me.tabOverbreakReport.Name = "tabOverbreakReport"
        Me.tabOverbreakReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverbreakReport.Size = New System.Drawing.Size(1114, 545)
        Me.tabOverbreakReport.TabIndex = 3
        Me.tabOverbreakReport.Text = "OVERBREAK REPORT"
        '
        'TblEmployeesTableAdapter
        '
        Me.TblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'TblEmployeesBindingSource2
        '
        Me.TblEmployeesBindingSource2.DataMember = "tblEmployees"
        Me.TblEmployeesBindingSource2.DataSource = Me.Dtrdb2DataSetBindingSource
        '
        'TblEmployeesTableAdapter1
        '
        Me.TblEmployeesTableAdapter1.ClearBeforeFill = True
        '
        'QryempnameTableAdapter
        '
        Me.QryempnameTableAdapter.ClearBeforeFill = True
        '
        'QryLateAMBrkTableAdapter
        '
        Me.QryLateAMBrkTableAdapter.ClearBeforeFill = True
        '
        'QryDGViewTableAdapter
        '
        Me.QryDGViewTableAdapter.ClearBeforeFill = True
        '
        'TblTimeLogTableAdapter
        '
        Me.TblTimeLogTableAdapter.ClearBeforeFill = True
        '
        'TblTimeLogBindingSource1
        '
        Me.TblTimeLogBindingSource1.DataMember = "tblTimeLog"
        Me.TblTimeLogBindingSource1.DataSource = Me.Dtrdb2DataSetBindingSource
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
        Me.tabReports.ResumeLayout(False)
        CType(Me.dgvDataTL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTimeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEmployees.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryDGViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panMenuBar.ResumeLayout(False)
        CType(Me.QryLateAMBrkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryempnameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtrdb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdminOpt.ResumeLayout(False)
        Me.tabTardinessReport.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTimeLogBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTimeLogBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAdminTop As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents tabReports As System.Windows.Forms.TabPage
    Friend WithEvents tabEmployees As System.Windows.Forms.TabPage
    Friend WithEvents TblEmployeesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tabAdminOpt As System.Windows.Forms.TabControl
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents panMenuBar As System.Windows.Forms.Panel
    Friend WithEvents btnEditEmp As System.Windows.Forms.Button
    Friend WithEvents btnDeleteEmp As System.Windows.Forms.Button
    Friend WithEvents Dtrdb1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dtrdb1DataSet As WindowsApplication1.dtrdb1DataSet
    Friend WithEvents TblEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeesTableAdapter As WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents btnEmpReport As System.Windows.Forms.Button
    Friend WithEvents tabTardinessReport As System.Windows.Forms.TabPage
    Friend WithEvents btnViewInactive As System.Windows.Forms.Button
    Friend WithEvents Dtrdb2DataSet As WindowsApplication1.dtrdb2DataSet
    Friend WithEvents Dtrdb2DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeesTableAdapter1 As WindowsApplication1.dtrdb2DataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents QryempnameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryempnameTableAdapter As WindowsApplication1.dtrdb2DataSetTableAdapters.qryempnameTableAdapter
    Friend WithEvents QryLateAMBrkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryLateAMBrkTableAdapter As WindowsApplication1.dtrdb2DataSetTableAdapters.qryLateAMBrkTableAdapter
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Dtrdb2DataSet1 As WindowsApplication1.dtrdb2DataSet1
    Friend WithEvents QryDGViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryDGViewTableAdapter As WindowsApplication1.dtrdb2DataSet1TableAdapters.qryDGViewTableAdapter
    Friend WithEvents tabOverbreakReport As System.Windows.Forms.TabPage
    Friend WithEvents dgvDataTL As System.Windows.Forms.DataGridView
    Friend WithEvents TblTimeLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTimeLogTableAdapter As WindowsApplication1.dtrdb2DataSetTableAdapters.tblTimeLogTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TblTimeLogBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblTimeLogBindingSource1 As System.Windows.Forms.BindingSource
End Class
