Public Class frmLateTimeIn

    Private Sub frmLateTimeIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MaximizeBox = False
        MinimizeBox = False

        txtReason.Text = "Please specify."
        txtReason.ForeColor = Color.Gray

        'Textbox for Reason disabled by default
        'Enabled only if "Others" radio button is ticked
        txtReason.Enabled = False

        btnSubmit.Enabled = False

        'Calls the system time upon clicking of TIME IN button
        lblTime.Text = frmLogScreen.lblTime.Text

    End Sub

    Private Sub txtReason_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReason.GotFocus
        txtReason.Text = "" ' clear the text box for typing
        txtReason.ForeColor = Color.Black
    End Sub

    Private Sub txtReason_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReason.LostFocus
        txtReason.Text = "Please specify." ' clear the text box for typing
    End Sub

    Private Sub rbOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOthers.CheckedChanged
        txtReason.Enabled = True

        If txtReason.Visible = String.IsNullOrWhiteSpace(txtReason.Text) Then
            btnSubmit.Enabled = True
        End If

    End Sub

    Private Sub rbHalfday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHalfday.CheckedChanged
        txtReason.Enabled = False
        btnSubmit.Enabled = True
    End Sub

    Private Sub rbOnsite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOnsite.CheckedChanged
        txtReason.Enabled = False
        btnSubmit.Enabled = True
    End Sub

    Private Sub rbEightam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEightam.CheckedChanged
        txtReason.Enabled = False
        btnSubmit.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class