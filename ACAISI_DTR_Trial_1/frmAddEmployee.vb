﻿Imports System.Data.OleDb

Public Class frmAddEmployee
    Dim dbProvider As String
    Dim dbSource As String
    Dim cnn As New OleDb.OleDbConnection
    'Dim cmd As New OleDb.OleDbCommand

    Private Sub frmAddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False

        cnn = New OleDb.OleDbConnection()
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & Application.StartupPath & "\dtrdb1.mdb"
        cnn.ConnectionString = dbProvider + dbSource

        txtFileName.Hide()

        If txtFileName.Text = "" Then
            Me.PictureBox1.BackgroundImage = Image.FromFile("C:\Users\User\Documents\visual studio 2010\Projects\ACAISI_DTR_Trial_1\ACAISI_DTR_Trial_1\Resources\CreateAccount.png")
        Else
            Me.PictureBox1.BackgroundImage = New System.Drawing.Bitmap(txtFileName.Text)
        End If

        'Password set hidden by default
        lblDesPass.Hide()
        lblConPass.Hide()
        txtDesPass.Hide()
        txtConPass.Hide()

    End Sub

    'LIMITS KEY INPUT TO NUMBERS ONLY--
    Private Sub txtEmpNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpNum.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtTkNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTkNo.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtEmpNum.Text = ""
        txtTkNo.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtmname.Text = ""
        txtPosition.Text = ""
        DTPicker.Text = ""
        txtSss.Text = ""
        txtTin.Text = ""
        txtPHealth.Text = ""
        txtPagibig.Text = ""
        cmbRemarks.Text = ""
        lblPIN.Text = "----"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim cmd As New OleDb.OleDbCommand
        cnn.ConnectionString = dbProvider + dbSource
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO tblEmployees(empnum, tknum, lname, fname, mname, emppos, bdate, sssnum, tinnum, phealthnum, pagibignum, emptype, pinnum, acclevel, despass, conpass, picfile) " & _
                " VALUES ('" & txtEmpNum.Text & "','" & txtTkNo.Text & "','" & txtlname.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtPosition.Text & "','" & DTPicker.Text & "','" _
                & txtSss.Text & "','" & txtTin.Text & "','" & txtPHealth.Text & "','" & txtPagibig.Text & "','" & cmbRemarks.Text & "','" & lblPIN.Text & "','" & cmbAccess.Text & "','" & txtDesPass.Text & "','" _
                & txtConPass.Text & "','" & txtFileName.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()

        txtEmpNum.Text = ""
        txtTkNo.Text = ""
        txtlname.Text = ""
        txtfname.Text = ""
        txtmname.Text = ""
        txtPosition.Text = ""
        DTPicker.Text = ""
        txtSss.Text = ""
        txtTin.Text = ""
        txtPHealth.Text = ""
        txtPagibig.Text = ""
        cmbRemarks.Text = ""
        cmbAccess.Text = ""
        txtDesPass.Text = ""
        txtConPass.Text = ""
        lblPIN.Text = ""

        MessageBox.Show("New Employee Added.")
        Me.Hide()
        frmAdminMenu.Show()
        frmAdminMenu.RefreshData()

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

        frmAdminMenu.dgvData.DataSource = dt

        cnn.Close()
    End Sub

    Private Sub btnAddPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPic.Click
        Me.OpenFileDialog1.ShowDialog()

        If txtFileName.Text = "" Then
            Me.PictureBox1.BackgroundImage = Image.FromFile("C:\Users\User\Documents\visual studio 2010\Projects\ACAISI_DTR_Trial_1\ACAISI_DTR_Trial_1\Resources\CreateAccount.png")
        Else
            Me.PictureBox1.BackgroundImage = New System.Drawing.Bitmap(txtFileName.Text)
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtFilename.Text = OpenFileDialog1.FileName
    End Sub


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim rng As New Random
        Dim number As Integer = rng.Next(1000, 9999)
        Dim digits As String = number.ToString("0000")
        Console.WriteLine(digits)

        lblPIN.Text = digits

    End Sub

    Private Sub cmbAccess_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccess.SelectedIndexChanged
        If cmbAccess.Text = "Administrator" Then
            lblDesPass.Show()
            lblConPass.Show()
            txtDesPass.Show()
            txtConPass.Show()
        ElseIf cmbAccess.Text = "Employee" Then
            lblDesPass.Hide()
            lblConPass.Hide()
            txtDesPass.Hide()
            txtConPass.Hide()
        End If
    End Sub
End Class