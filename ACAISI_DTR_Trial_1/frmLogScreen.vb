﻿Public Class frmLogScreen
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection

    ' [1]
    ' 18 JULY 2014
    ' Unresolved Issue : Confirmation of PIN Entry if it is existing,
    '                    lookup inside tblEmployees. DB connection and
    '                    declarations are commented out. //jill

    ' [2]
    ' 25 JULY 2014
    ' Unresolved Error : "There is no row at position 0" Error.
    '                    Occurs if PIN entered doesn't exist.
    '                    But accepts existing pinnum from database.
    '                    Focus on btnLogIn Activity. //jill

    Private Sub frmLogScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

        'System Date Timer
        Timer1.Enabled = True

        MaximizeBox = False
        MinimizeBox = False

        btnLogIn.Refresh()

        ' btnLogin is disabled in default and will only activated upon entry of pin
        btnLogIn.Enabled = False

        If txtPin.Text = "" Then
            btnLogIn.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblDay.Text = Date.Now.ToString("dddd")
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
            Dim cmd As New OleDb.OleDbCommand

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If

            cmd.Connection = cnn

        Dim da As New OleDb.OleDbDataAdapter("SELECT pinnum FROM tblEmployees WHERE pinnum = " & txtPin.Text, cnn)

            Dim dt As New DataTable
            da.Fill(dt)

            cnn.Close()

            'Search entered PIN from database if valid or existing
            Dim dtrpin As String = dt.Rows(0).Item("pinnum")

        '[2] -------------------------------------------------------
        If dt.Rows.Count > 0 And txtPin.Text = dtrpin Then
            frmLoggedIn.Show()
        ElseIf Not txtPin.Text = dtrpin Then
            MsgBox("Invalid PIN Number.", MsgBoxStyle.RetryCancel)
            txtPin.Text = ""
        End If
        '-----------------------------------------------------------

        ' Clears text box entry
        txtPin.Text = ""

        ' Pop-up dialog box
        frmLoggedIn.Show()
    End Sub

    Private Sub AdminLogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLogInToolStripMenuItem.Click
        frmLogin.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmLogin.Show()

        ' Disabling original buttons of frmLogIn,
        ' Activating EXIT button only to terminate program
        frmLogin.btnLogin.Hide()
        frmLogin.btnExit.Hide()
        frmLogin.btnReset.Hide()
        frmLogin.btnExitApp.Show()
    End Sub

    Private Sub txtPin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPin.TextChanged
        btnLogIn.Enabled = True
    End Sub
End Class