Public Class frmLateTimeIn

    Private Sub frmLateTimeIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MaximizeBox = False
        MinimizeBox = False

        txtLTIReason.Text = "Please specify."
        txtLTIReason.ForeColor = Color.Gray

        'Textbox for Reason disabled by default
        'Enabled only if "Others" radio button is ticked
        txtLTIReason.Enabled = False

        btnLTISubmit.Enabled = False

        'Calls the system time upon clicking of TIME IN button
        lblTimeLTI.Text = frmLogScreen.lblTime.Text

    End Sub

    Private Sub txtReason_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLTIReason.GotFocus
        txtLTIReason.Text = "" ' clear the text box for typing
        txtLTIReason.ForeColor = Color.Black
    End Sub

    Private Sub txtReason_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLTIReason.LostFocus
        txtLTIReason.Text = "Please specify." ' clear the text box for typing
    End Sub

    Private Sub rbOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLTIOthers.CheckedChanged
        txtLTIReason.Enabled = True

        If txtLTIReason.Visible = String.IsNullOrWhiteSpace(txtLTIReason.Text) Then
            btnLTISubmit.Enabled = True
        End If

    End Sub

    Private Sub rbHalfday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHalfday.CheckedChanged
        txtLTIReason.Enabled = False
        btnLTISubmit.Enabled = True
    End Sub

    Private Sub rbOnsite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOnsite.CheckedChanged
        txtLTIReason.Enabled = False
        btnLTISubmit.Enabled = True
    End Sub

    Private Sub rbEightam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEightam.CheckedChanged
        txtLTIReason.Enabled = False
        btnLTISubmit.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class