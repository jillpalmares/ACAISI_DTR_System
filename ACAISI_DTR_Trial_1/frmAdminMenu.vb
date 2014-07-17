Imports System.Data.OleDb

Public Class frmAdminMenu
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection

    Private Sub frmAdminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False

        'RefreshData()

        'TODO: This line of code loads data into the 'AcaisidbrDataSet.tblEmployees' table. You can move, or remove it, as needed.
        'Me.TblEmployeesTableAdapter.Fill(Me.AcaisidbrDataSet.tblEmployees)

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.Jet.Oledb.4.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

        'Commands for tooltip
        Dim tooltipAddEmp As New ToolTip()
        tooltipAddEmp.SetToolTip(Me.btnAddEmp, "Add Employee")
        tooltipAddEmp.SetToolTip(Me.btnEditEmp, "Edit Information")
        tooltipAddEmp.SetToolTip(Me.btnDeleteEmp, "Delete Employee")

    End Sub
    Sub RefreshData()

        Dim cnn As New OleDb.OleDbConnection
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT EmpNo, timekeepingNo, lname, fname, mname, posi, bdate, sssNo, tinNo, philhealth, pagibigNo, rems FROM tblEMployees", cnn)

        Dim dt As New DataTable
        da.Fill(dt)

        dgvData.DataSource = dt

        cnn.Close()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnAddEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmp.Click
        frmAddEmployee.Show()
    End Sub
End Class