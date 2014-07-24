<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegEmp
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtrdb1DataSet = New WindowsApplication1.dtrdb1DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblEmployeesTableAdapter = New WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmpInfoWind = New System.Windows.Forms.Label()
        CType(Me.tblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtrdb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblEmployeesBindingSource
        '
        Me.tblEmployeesBindingSource.DataMember = "tblEmployees"
        Me.tblEmployeesBindingSource.DataSource = Me.dtrdb1DataSet
        '
        'dtrdb1DataSet
        '
        Me.dtrdb1DataSet.DataSetName = "dtrdb1DataSet"
        Me.dtrdb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReportViewer1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblEmployeesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 119)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.Size = New System.Drawing.Size(817, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblEmployeesTableAdapter
        '
        Me.tblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.lblEmpInfoWind)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 71)
        Me.Panel1.TabIndex = 1
        '
        'lblEmpInfoWind
        '
        Me.lblEmpInfoWind.AutoSize = True
        Me.lblEmpInfoWind.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpInfoWind.Location = New System.Drawing.Point(11, 16)
        Me.lblEmpInfoWind.Name = "lblEmpInfoWind"
        Me.lblEmpInfoWind.Size = New System.Drawing.Size(172, 36)
        Me.lblEmpInfoWind.TabIndex = 0
        Me.lblEmpInfoWind.Text = "EMPLOYEES"
        '
        'frmRegEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRegEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACAISI Registered Employees "
        CType(Me.tblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtrdb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtrdb1DataSet As WindowsApplication1.dtrdb1DataSet
    Friend WithEvents tblEmployeesTableAdapter As WindowsApplication1.dtrdb1DataSetTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpInfoWind As System.Windows.Forms.Label
End Class
