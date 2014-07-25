Public Class frmLoggedIn
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection
    Dim currentDate As System.DateTime
    Dim currentHour As Integer

    ' [1]
    ' 18 JULY 2014
    ' Unresolved Issue : Reflecting of Employee's First Name based on
    '                    PIN Entry in frmLogScreen. Trial syntax and
    '                    commands are all inside Load Class. //jill     RESOLVED: 25 JULY 2014

    ' [2]
    ' 25 JULY 2014
    ' Unresolved Issue : Reflecting of Employee's Photo based on
    '                    PIN Entry in frmLogScreen. First name and
    '                    photo should tally. //jill                     RESOLVED: 25 JULY 2014


    Private Sub frmLoggedIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

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

        ' [1]
        ' Reflected name based on PIN number entered in frmLogScreen
        Dim cmd As New OleDb.OleDbCommand

        ' Data pull for DTR PIN Number Validation
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        cmd.Connection = cnn

        Dim da As New OleDb.OleDbDataAdapter("SELECT pinnum FROM tblEmployees WHERE pinnum= " & frmLogScreen.txtPin.Text, cnn)

        Dim dt As New DataTable
        da.Fill(dt)

        cnn.Close()

        ' Data pull for First Name Display based on DTR PIN Number entered
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        cmd.Connection = cnn

        Dim dp As New OleDb.OleDbDataAdapter("SELECT fname FROM tblEmployees WHERE pinnum=" & frmLogScreen.txtPin.Text, cnn)

        Dim ds As New DataTable
        dp.Fill(ds)

        ' [2] 
        ' Data pull for Picture Display based on DTR PIN Number entered
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        cmd.Connection = cnn

        Dim df As New OleDb.OleDbDataAdapter("SELECT picfile FROM tblEmployees WHERE pinnum=" & frmLogScreen.txtPin.Text, cnn)

        Dim dtt As New DataTable
        df.Fill(dtt)

        Dim readPhoto As String = dtt.Rows(0).Item("picfile")


        'Interface display condition
        'Name and Photo display based on DTR PIN Number entered
        If frmLogScreen.txtPin.Text = dt.Rows(0).Item("pinnum") Then
            lblEmpName.Text = ds.Rows(0).Item("fname")
            PictureBox1.BackgroundImage = New System.Drawing.Bitmap(readPhoto)
            cnn.Close()
        End If

    End Sub

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click

        currentDate = Date.Now()
        currentHour = currentDate.Hour

        If currentHour >= 6 Then
            frmLateTimeIn.Show()
        Else
            ' Log In Confirmation
            MessageBox.Show("You have successfully logged in.", "My Application", _
             MessageBoxButtons.OK)
            If DialogResult.OK Then
                Me.Close()
            End If
        End If

        
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click

        ' Log Out Confirmation
        MessageBox.Show("You have successfully logged out.", "My Application", _
        MessageBoxButtons.OK)
        If DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class