Public Class frmLoggedIn
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection

    ' 18 JULY 2014
    ' Unresolved Issue : Reflecting of Employee's First Name based on
    '                    PIN Entry in frmLogScreen. Trial syntax and
    '                    commands are all inside Load Class


    Private Sub frmLoggedIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

        Dim currentDate As System.DateTime
        Dim currentHour As Integer

        currentDate = Date.Now()
        currentHour = currentDate.Hour

        'All buttons In & Out are disabled by default
        btnAmIn.Enabled = False
        btnAmOut.Enabled = False
        btnLunIn.Enabled = False
        btnLunOut.Enabled = False
        btnPmIn.Enabled = False
        btnPmOut.Enabled = False
        btnTimeIn.Enabled = False
        btnTimeOut.Enabled = False


        'for AM Break
        If currentHour = 10 Then
            btnAmIn.Enabled = True
            btnAmOut.Enabled = True
            ' for Lunch Break
        ElseIf currentHour = 11 Or currentHour = 12 Or currentHour = 13 Then
            btnLunIn.Enabled = True
            btnLunOut.Enabled = True
            'for PM Break
        ElseIf currentHour = 15 Then
            btnPmIn.Enabled = True
            btnPmOut.Enabled = True
        End If

        'TIME IN (including half day)
        If currentHour > 6 And currentHour < 14 Then
            btnTimeIn.Enabled = True
        End If

        'TIME OUT (including half day)
        If currentHour > 12 And currentHour < 21 Then
            btnTimeOut.Enabled = True
        End If

        ' Reflected name based on PIN number entered in frmLogScreen
        Dim cmd As New OleDb.OleDbCommand

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        cmd.Connection = cnn

        Dim da As New OleDb.OleDbDataAdapter("SELECT pinnum FROM tblEmployees ", cnn)

        Dim dt As New DataTable
        da.Fill(dt)

        cnn.Close()

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        cmd.Connection = cnn

        Dim dp As New OleDb.OleDbDataAdapter("SELECT fname FROM tblEmployees ", cnn)

        Dim ds As New DataTable
        dp.Fill(ds)

        If frmLogScreen.txtPin.Text = dt.Rows(4).Item("pinnum") Then
            lblEmpName.Text = ds.Rows(4).Item("fname")
            cnn.Close()
        End If


    End Sub

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click

        ' Log In Confirmation
        MessageBox.Show("You have successfully logged in.", "My Application", _
         MessageBoxButtons.OK)
        If DialogResult.OK Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click

        ' Log Out Confirmation
        MessageBox.Show("You have successfully logged out.", "My Application", _
        MessageBoxButtons.OK)
        If DialogResult.OK Then
            Me.Hide()
        End If
    End Sub
End Class