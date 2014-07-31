<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblEmpInfoWind = New System.Windows.Forms.Label()
        Me.lblEmpNo = New System.Windows.Forms.Label()
        Me.txtEmpNum = New System.Windows.Forms.TextBox()
        Me.lbltkNo = New System.Windows.Forms.Label()
        Me.txtTkNo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lblmname = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.lblBdate = New System.Windows.Forms.Label()
        Me.lblSss = New System.Windows.Forms.Label()
        Me.lblTin = New System.Windows.Forms.Label()
        Me.lblPHealth = New System.Windows.Forms.Label()
        Me.lblPagibig = New System.Windows.Forms.Label()
        Me.lblEmpType = New System.Windows.Forms.Label()
        Me.cmbRemarks = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtDesPass = New System.Windows.Forms.TextBox()
        Me.lblDesPass = New System.Windows.Forms.Label()
        Me.txtConPass = New System.Windows.Forms.TextBox()
        Me.lblConPass = New System.Windows.Forms.Label()
        Me.lblacclevel = New System.Windows.Forms.Label()
        Me.cmbAccess = New System.Windows.Forms.ComboBox()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.lblpinnum = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtSss = New System.Windows.Forms.MaskedTextBox()
        Me.txtTin = New System.Windows.Forms.MaskedTextBox()
        Me.txtPHealth = New System.Windows.Forms.MaskedTextBox()
        Me.txtPagibig = New System.Windows.Forms.MaskedTextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbLTS = New System.Windows.Forms.ComboBox()
        Me.lblltslot = New System.Windows.Forms.Label()
        Me.lblLTS = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.lblEmpInfoWind)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 61)
        Me.Panel1.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(609, 22)
        Me.txtID.MaxLength = 3
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(127, 22)
        Me.txtID.TabIndex = 37
        Me.txtID.Visible = False
        '
        'lblEmpInfoWind
        '
        Me.lblEmpInfoWind.AutoSize = True
        Me.lblEmpInfoWind.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpInfoWind.Location = New System.Drawing.Point(11, 16)
        Me.lblEmpInfoWind.Name = "lblEmpInfoWind"
        Me.lblEmpInfoWind.Size = New System.Drawing.Size(188, 28)
        Me.lblEmpInfoWind.TabIndex = 0
        Me.lblEmpInfoWind.Text = "ADD EMPLOYEE"
        '
        'lblEmpNo
        '
        Me.lblEmpNo.AutoSize = True
        Me.lblEmpNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNo.Location = New System.Drawing.Point(189, 82)
        Me.lblEmpNo.Name = "lblEmpNo"
        Me.lblEmpNo.Size = New System.Drawing.Size(135, 17)
        Me.lblEmpNo.TabIndex = 1
        Me.lblEmpNo.Text = "Employee Number :"
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNum.Location = New System.Drawing.Point(324, 77)
        Me.txtEmpNum.MaxLength = 3
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(127, 22)
        Me.txtEmpNum.TabIndex = 1
        '
        'lbltkNo
        '
        Me.lbltkNo.AutoSize = True
        Me.lbltkNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltkNo.Location = New System.Drawing.Point(465, 81)
        Me.lbltkNo.Name = "lbltkNo"
        Me.lbltkNo.Size = New System.Drawing.Size(153, 17)
        Me.lbltkNo.TabIndex = 3
        Me.lbltkNo.Text = "Timekeeping Number :"
        '
        'txtTkNo
        '
        Me.txtTkNo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTkNo.Location = New System.Drawing.Point(618, 76)
        Me.txtTkNo.MaxLength = 4
        Me.txtTkNo.Name = "txtTkNo"
        Me.txtTkNo.Size = New System.Drawing.Size(121, 22)
        Me.txtTkNo.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(189, 113)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name :"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(251, 110)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(150, 22)
        Me.txtlname.TabIndex = 3
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(409, 110)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(176, 22)
        Me.txtfname.TabIndex = 4
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(595, 110)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(144, 22)
        Me.txtmname.TabIndex = 5
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.Location = New System.Drawing.Point(308, 132)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(32, 16)
        Me.lbllname.TabIndex = 9
        Me.lbllname.Text = "Last"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(478, 131)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(31, 16)
        Me.lblfname.TabIndex = 10
        Me.lblfname.Text = "First"
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmname.Location = New System.Drawing.Point(644, 131)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(48, 16)
        Me.lblmname.TabIndex = 11
        Me.lblmname.Text = "Middle"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(190, 164)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(66, 17)
        Me.lblPosition.TabIndex = 12
        Me.lblPosition.Text = "Position :"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(256, 160)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(174, 22)
        Me.txtPosition.TabIndex = 6
        '
        'lblBdate
        '
        Me.lblBdate.AutoSize = True
        Me.lblBdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBdate.Location = New System.Drawing.Point(445, 164)
        Me.lblBdate.Name = "lblBdate"
        Me.lblBdate.Size = New System.Drawing.Size(74, 17)
        Me.lblBdate.TabIndex = 13
        Me.lblBdate.Text = "Birthdate :"
        '
        'lblSss
        '
        Me.lblSss.AutoSize = True
        Me.lblSss.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSss.Location = New System.Drawing.Point(190, 200)
        Me.lblSss.Name = "lblSss"
        Me.lblSss.Size = New System.Drawing.Size(61, 17)
        Me.lblSss.TabIndex = 14
        Me.lblSss.Text = "SSS No. :"
        '
        'lblTin
        '
        Me.lblTin.AutoSize = True
        Me.lblTin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTin.Location = New System.Drawing.Point(465, 200)
        Me.lblTin.Name = "lblTin"
        Me.lblTin.Size = New System.Drawing.Size(61, 17)
        Me.lblTin.TabIndex = 16
        Me.lblTin.Text = "TIN No. :"
        '
        'lblPHealth
        '
        Me.lblPHealth.AutoSize = True
        Me.lblPHealth.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHealth.Location = New System.Drawing.Point(190, 230)
        Me.lblPHealth.Name = "lblPHealth"
        Me.lblPHealth.Size = New System.Drawing.Size(79, 17)
        Me.lblPHealth.TabIndex = 18
        Me.lblPHealth.Text = "Philhealth :"
        '
        'lblPagibig
        '
        Me.lblPagibig.AutoSize = True
        Me.lblPagibig.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagibig.Location = New System.Drawing.Point(465, 230)
        Me.lblPagibig.Name = "lblPagibig"
        Me.lblPagibig.Size = New System.Drawing.Size(97, 17)
        Me.lblPagibig.TabIndex = 20
        Me.lblPagibig.Text = "Pag-Ibig No. :"
        '
        'lblEmpType
        '
        Me.lblEmpType.AutoSize = True
        Me.lblEmpType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpType.Location = New System.Drawing.Point(189, 264)
        Me.lblEmpType.Name = "lblEmpType"
        Me.lblEmpType.Size = New System.Drawing.Size(111, 17)
        Me.lblEmpType.TabIndex = 22
        Me.lblEmpType.Text = "Employee Type :"
        '
        'cmbRemarks
        '
        Me.cmbRemarks.AllowDrop = True
        Me.cmbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRemarks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRemarks.FormattingEnabled = True
        Me.cmbRemarks.Items.AddRange(New Object() {"Regular", "Contractual", "Probationary", "Special Project", "OJT"})
        Me.cmbRemarks.Location = New System.Drawing.Point(303, 258)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(127, 25)
        Me.cmbRemarks.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(449, 410)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 33)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(545, 410)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 33)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(641, 410)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(748, 452)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 738
        Me.LineShape1.Y1 = 294
        Me.LineShape1.Y2 = 293
        '
        'txtDesPass
        '
        Me.txtDesPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesPass.Location = New System.Drawing.Point(143, 340)
        Me.txtDesPass.MaxLength = 12
        Me.txtDesPass.Name = "txtDesPass"
        Me.txtDesPass.Size = New System.Drawing.Size(184, 22)
        Me.txtDesPass.TabIndex = 14
        Me.txtDesPass.UseSystemPasswordChar = True
        '
        'lblDesPass
        '
        Me.lblDesPass.AutoSize = True
        Me.lblDesPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesPass.Location = New System.Drawing.Point(6, 343)
        Me.lblDesPass.Name = "lblDesPass"
        Me.lblDesPass.Size = New System.Drawing.Size(128, 17)
        Me.lblDesPass.TabIndex = 25
        Me.lblDesPass.Text = "Desired Password :"
        '
        'txtConPass
        '
        Me.txtConPass.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPass.Location = New System.Drawing.Point(143, 368)
        Me.txtConPass.MaxLength = 12
        Me.txtConPass.Name = "txtConPass"
        Me.txtConPass.Size = New System.Drawing.Size(184, 22)
        Me.txtConPass.TabIndex = 15
        Me.txtConPass.UseSystemPasswordChar = True
        '
        'lblConPass
        '
        Me.lblConPass.AutoSize = True
        Me.lblConPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConPass.Location = New System.Drawing.Point(6, 371)
        Me.lblConPass.Name = "lblConPass"
        Me.lblConPass.Size = New System.Drawing.Size(133, 17)
        Me.lblConPass.TabIndex = 27
        Me.lblConPass.Text = "Confirm Password :"
        '
        'lblacclevel
        '
        Me.lblacclevel.AutoSize = True
        Me.lblacclevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacclevel.Location = New System.Drawing.Point(6, 312)
        Me.lblacclevel.Name = "lblacclevel"
        Me.lblacclevel.Size = New System.Drawing.Size(96, 17)
        Me.lblacclevel.TabIndex = 29
        Me.lblacclevel.Text = "Access Level :"
        '
        'cmbAccess
        '
        Me.cmbAccess.AllowDrop = True
        Me.cmbAccess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAccess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccess.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccess.FormattingEnabled = True
        Me.cmbAccess.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cmbAccess.Location = New System.Drawing.Point(108, 306)
        Me.cmbAccess.Name = "cmbAccess"
        Me.cmbAccess.Size = New System.Drawing.Size(219, 25)
        Me.cmbAccess.TabIndex = 17
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIN.Location = New System.Drawing.Point(569, 335)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(104, 56)
        Me.lblPIN.TabIndex = 30
        Me.lblPIN.Text = "----"
        '
        'lblpinnum
        '
        Me.lblpinnum.AutoSize = True
        Me.lblpinnum.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpinnum.Location = New System.Drawing.Point(450, 357)
        Me.lblpinnum.Name = "lblpinnum"
        Me.lblpinnum.Size = New System.Drawing.Size(93, 17)
        Me.lblpinnum.TabIndex = 31
        Me.lblpinnum.Text = "PIN Number :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnAddPic
        '
        Me.btnAddPic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPic.Location = New System.Drawing.Point(11, 231)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(155, 33)
        Me.btnAddPic.TabIndex = 33
        Me.btnAddPic.Text = "&Upload Photo"
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(13, 269)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(149, 20)
        Me.txtFileName.TabIndex = 34
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(448, 304)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(126, 33)
        Me.btnGenerate.TabIndex = 18
        Me.btnGenerate.Text = "&Generate PIN"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtSss
        '
        Me.txtSss.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSss.Location = New System.Drawing.Point(256, 195)
        Me.txtSss.Mask = "00-0000000-0"
        Me.txtSss.Name = "txtSss"
        Me.txtSss.Size = New System.Drawing.Size(174, 22)
        Me.txtSss.TabIndex = 10
        '
        'txtTin
        '
        Me.txtTin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTin.Location = New System.Drawing.Point(530, 195)
        Me.txtTin.Mask = "000-000-000-000"
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(209, 22)
        Me.txtTin.TabIndex = 11
        '
        'txtPHealth
        '
        Me.txtPHealth.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHealth.Location = New System.Drawing.Point(272, 227)
        Me.txtPHealth.Mask = "00-000000000-0"
        Me.txtPHealth.Name = "txtPHealth"
        Me.txtPHealth.Size = New System.Drawing.Size(158, 22)
        Me.txtPHealth.TabIndex = 12
        '
        'txtPagibig
        '
        Me.txtPagibig.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagibig.Location = New System.Drawing.Point(565, 225)
        Me.txtPagibig.Mask = "0000-0000-0000"
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(174, 22)
        Me.txtPagibig.TabIndex = 13
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(11, 231)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(155, 33)
        Me.btnRemove.TabIndex = 35
        Me.btnRemove.Text = "&Remove Photo"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(449, 410)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 33)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "U&pdate"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(521, 159)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(97, 25)
        Me.cmbMonth.TabIndex = 7
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(624, 159)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(49, 25)
        Me.cmbDay.TabIndex = 8
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014"})
        Me.cmbYear.Location = New System.Drawing.Point(679, 159)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(60, 25)
        Me.cmbYear.TabIndex = 9
        '
        'cmbLTS
        '
        Me.cmbLTS.AllowDrop = True
        Me.cmbLTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbLTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLTS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLTS.FormattingEnabled = True
        Me.cmbLTS.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbLTS.Location = New System.Drawing.Point(579, 258)
        Me.cmbLTS.Name = "cmbLTS"
        Me.cmbLTS.Size = New System.Drawing.Size(39, 25)
        Me.cmbLTS.TabIndex = 15
        '
        'lblltslot
        '
        Me.lblltslot.AutoSize = True
        Me.lblltslot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblltslot.Location = New System.Drawing.Point(465, 264)
        Me.lblltslot.Name = "lblltslot"
        Me.lblltslot.Size = New System.Drawing.Size(110, 17)
        Me.lblltslot.TabIndex = 41
        Me.lblltslot.Text = "Lunch Time Slot:"
        '
        'lblLTS
        '
        Me.lblLTS.BackColor = System.Drawing.Color.White
        Me.lblLTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLTS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLTS.Location = New System.Drawing.Point(624, 259)
        Me.lblLTS.Name = "lblLTS"
        Me.lblLTS.Size = New System.Drawing.Size(113, 22)
        Me.lblLTS.TabIndex = 16
        Me.lblLTS.Text = "                         "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 452)
        Me.Controls.Add(Me.lblLTS)
        Me.Controls.Add(Me.cmbLTS)
        Me.Controls.Add(Me.lblltslot)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.btnAddPic)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtPagibig)
        Me.Controls.Add(Me.txtPHealth)
        Me.Controls.Add(Me.txtTin)
        Me.Controls.Add(Me.txtSss)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpinnum)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.cmbAccess)
        Me.Controls.Add(Me.lblacclevel)
        Me.Controls.Add(Me.txtConPass)
        Me.Controls.Add(Me.lblConPass)
        Me.Controls.Add(Me.txtDesPass)
        Me.Controls.Add(Me.lblDesPass)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbRemarks)
        Me.Controls.Add(Me.lblEmpType)
        Me.Controls.Add(Me.lblPagibig)
        Me.Controls.Add(Me.lblPHealth)
        Me.Controls.Add(Me.lblTin)
        Me.Controls.Add(Me.lblSss)
        Me.Controls.Add(Me.lblBdate)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblmname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtTkNo)
        Me.Controls.Add(Me.lbltkNo)
        Me.Controls.Add(Me.txtEmpNum)
        Me.Controls.Add(Me.lblEmpNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmpInfoWind As System.Windows.Forms.Label
    Friend WithEvents lblEmpNo As System.Windows.Forms.Label
    Friend WithEvents txtEmpNum As System.Windows.Forms.TextBox
    Friend WithEvents lbltkNo As System.Windows.Forms.Label
    Friend WithEvents txtTkNo As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lblmname As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblBdate As System.Windows.Forms.Label
    Friend WithEvents lblSss As System.Windows.Forms.Label
    Friend WithEvents lblTin As System.Windows.Forms.Label
    Friend WithEvents lblPHealth As System.Windows.Forms.Label
    Friend WithEvents lblPagibig As System.Windows.Forms.Label
    Friend WithEvents lblEmpType As System.Windows.Forms.Label
    Friend WithEvents cmbRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtDesPass As System.Windows.Forms.TextBox
    Friend WithEvents lblDesPass As System.Windows.Forms.Label
    Friend WithEvents txtConPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConPass As System.Windows.Forms.Label
    Friend WithEvents lblacclevel As System.Windows.Forms.Label
    Friend WithEvents cmbAccess As System.Windows.Forms.ComboBox
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents lblpinnum As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddPic As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtSss As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPHealth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPagibig As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLTS As System.Windows.Forms.ComboBox
    Friend WithEvents lblltslot As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblLTS As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
