Public Class frmLogin

    
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False

        btnReset.Visible = False
        btnExitApp.Enabled = False

        ' By default, Exit button for terminating the whole program is hidden
        ' Will only be activated when frmLogin is triggered from frmLogScreen's menustrip
        btnExitApp.Visible = False

    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged

        'Enabling of Reset and Exit buttons
        If txtEmpNo.Text = "" And txtPass.Text = "" Then
            btnReset.Visible = False
            btnExit.Visible = True
        Else
            btnExitApp.Enabled = True
            btnExit.Visible = False
            btnReset.Visible = True
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        txtEmpNo.Text = ""
        txtPass.Text = ""

        'Confirmation of Terminating the Window
        If MessageBox.Show("Do you want to exit?", "My Application", _
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        'Resets the textboxes for new text input
        txtEmpNo.Text = ""
        txtPass.Text = ""

        If txtEmpNo.Text = "" And txtPass.Text = "" Then
            btnReset.Visible = False
            btnExit.Visible = True
        Else
            btnExit.Visible = False
            btnReset.Visible = True
        End If

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        'For testing only
        If txtEmpNo.Text = "040" And txtPass.Text = "admin" Then
            frmAdminMenu.Show()
            Me.Hide()
            txtEmpNo.Text = ""
            txtPass.Text = ""

            'Notification of Invalid Credentials; RetryCancel Type
        ElseIf MessageBox.Show("Invalid Log-in Credentials", "My Application", _
         MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) _
         = DialogResult.Retry Then
            txtEmpNo.Text = ""
            txtPass.Text = ""
        ElseIf DialogResult.Cancel Then
            End

        End If
    End Sub

    Private Sub btnExitApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitApp.Click

        'For testing only----------------------------------------
        If txtEmpNo.Text = "040" And txtPass.Text = "admin" Then
            End
        ElseIf MessageBox.Show("Invalid Credentials", "My Application", _
         MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) _
         = DialogResult.Retry Then
            txtEmpNo.Text = ""
            txtPass.Text = ""
        End If
        '--------------------------------------------------------
    End Sub

    'LIMITS KEY INPUT TO NUMBERS ONLY--
    Private Sub txtEmpNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpNo.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class
