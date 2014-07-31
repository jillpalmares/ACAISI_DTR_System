Public Class frmDelEmp

    Private Sub frmAdminOpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelDelete.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnAdminMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmDelete.Click
        Me.Hide()
        frmAdminMenu.Show()
    End Sub

End Class