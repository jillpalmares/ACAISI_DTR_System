Public Class frmRegEmp

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MaximizeBox = False
        MinimizeBox = False

        'TODO: This line of code loads data into the 'dtrdb1DataSet.tblEmployees' table. You can move, or remove it, as needed.
        Me.tblEmployeesTableAdapter.Fill(Me.dtrdb1DataSet.tblEmployees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class