Imports System.Data.OleDb

Public Class frmAdminMenu
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection

    Private Sub frmAdminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtrdb1DataSet.tblEmployees' table. You can move, or remove it, as needed.
        Me.TblEmployeesTableAdapter.Fill(Me.Dtrdb1DataSet.tblEmployees)
        MaximizeBox = False
        MinimizeBox = False

        'Commands for tooltip
        Dim tooltipEmp As New ToolTip()
        tooltipEmp.SetToolTip(btnAddEmp, "Add Employee")
        tooltipEmp.SetToolTip(btnEditEmp, "Edit Information")
        tooltipEmp.SetToolTip(btnDeleteEmp, "Delete Employee")

        'TODO: This line of code loads data into the 'AcaisidbrDataSet.tblEmployees' table. You can move, or remove it, as needed.
        'Me.TblEmployeesTableAdapter.Fill(Me.AcaisidbrDataSet.tblEmployees)

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

        Me.RefreshData()

    End Sub
    Sub RefreshData()

        Dim cnn As New OleDb.OleDbConnection
        cnn.ConnectionString = dbProvider + dbSource
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT empnum, lname, fname, mname, emppos, bdate, emptype, pinnum, acclevel FROM tblEmployees", cnn)

        Dim dt As New DataTable
        da.Fill(dt)

        dgvData.DataSource = dt

        cnn.Close()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
    End Sub

    Private Sub btnAddEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmp.Click
        frmAddEmployee.Show()
    End Sub

    Private Sub pnlAdminTop_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAdminTop.Paint

    End Sub

    Private Sub btnEditEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEmp.Click
        If Me.dgvData.Rows.Count > 0 Then
            If Me.dgvData.SelectedRows.Count > 0 Then
                Dim empID As Integer = dgvData.SelectedRows(0).Cells("ID").Value
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblEmployees " & _
                                                     "WHERE empnum =" & empID, cnn)
                Dim dt As New DataTable
                da.Fill(dt)

                frmAddEmployee.Show()
                frmAddEmployee.txtEmpNum.Text = empID
                frmAddEmployee.txtTkNo.Text = dt.Rows(0).Item("tknum")
                frmAddEmployee.txtlname.Text = dt.Rows(0).Item("lname")
                frmAddEmployee.txtfname.Text = dt.Rows(0).Item("fname")
                frmAddEmployee.txtmname.Text = dt.Rows(0).Item("mname")
                frmAddEmployee.txtPosition.Text = dt.Rows(0).Item("emppos")
                frmAddEmployee.DTPicker.Text = dt.Rows(0).Item("bdate")
                frmAddEmployee.txtSss.Text = dt.Rows(0).Item("sssnum")
                frmAddEmployee.txtTin.Text = dt.Rows(0).Item("tinnum")
                frmAddEmployee.txtPHealth.Text = dt.Rows(0).Item("phealthnum")
                frmAddEmployee.txtPagibig.Text = dt.Rows(0).Item("pagibignum")
                frmAddEmployee.cmbRemarks.Text = dt.Rows(0).Item("emptype")
                frmAddEmployee.lblPIN.Text = dt.Rows(0).Item("pinnum")
                frmAddEmployee.cmbAccess.Text = dt.Rows(0).Item("acclevel")
                frmAddEmployee.txtFileName.Text = dt.Rows(0).Item("picfile")
                frmAddEmployee.txtEmpNum.Tag = empID

            End If
        End If


    End Sub

End Class