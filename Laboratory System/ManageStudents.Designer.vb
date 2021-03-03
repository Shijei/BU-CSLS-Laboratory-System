<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudents
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudents))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtStudentid = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtStudentQR = New System.Windows.Forms.Label()
        Me.btnLookFor = New System.Windows.Forms.Button()
        Me.cmbCondition2 = New System.Windows.Forms.ComboBox()
        Me.cmbCondition1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.searchbar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 72)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(31, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(393, 28)
        Me.txtSearch.TabIndex = 7
        Me.txtSearch.Text = "SEARCH"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.searchbutton
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(435, 31)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(31, 28)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.backbutton
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1359, 22)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 60)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(95, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 28)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "STUDENT ID"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(95, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 28)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "FIRST NAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        Me.StudentDataGridView.AllowUserToResizeRows = False
        Me.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.StudentDataGridView.ColumnHeadersHeight = 30
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentDataGridView.GridColor = System.Drawing.Color.White
        Me.StudentDataGridView.Location = New System.Drawing.Point(19, 262)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.StudentDataGridView.RowHeadersVisible = False
        Me.StudentDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.StudentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.StudentDataGridView.RowTemplate.Height = 35
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(1487, 482)
        Me.StudentDataGridView.TabIndex = 97
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(19, 100)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox4.TabIndex = 98
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(19, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox2.TabIndex = 99
        Me.PictureBox2.TabStop = False
        '
        'txtStudentid
        '
        Me.txtStudentid.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtStudentid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentid.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentid.Location = New System.Drawing.Point(290, 104)
        Me.txtStudentid.Name = "txtStudentid"
        Me.txtStudentid.Size = New System.Drawing.Size(432, 27)
        Me.txtStudentid.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(287, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(441, 36)
        Me.Button3.TabIndex = 101
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(290, 143)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(432, 27)
        Me.txtFirstname.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(287, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(441, 36)
        Me.Button2.TabIndex = 103
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(19, 180)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox7.TabIndex = 104
        Me.PictureBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(84, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 28)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "MIDDLE NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(290, 183)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(432, 27)
        Me.txtMiddlename.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(287, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(441, 36)
        Me.Button1.TabIndex = 107
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(19, 220)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(269, 36)
        Me.PictureBox3.TabIndex = 108
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(101, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 28)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "LAST NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(290, 223)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(432, 27)
        Me.txtLastname.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(287, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(441, 36)
        Me.Button4.TabIndex = 111
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.clearbtn
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(1339, 758)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(167, 64)
        Me.btnClear.TabIndex = 12
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.deletebtn
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(1166, 758)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(167, 64)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.updatebtn
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(993, 758)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(167, 64)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.addbtn
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(820, 758)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(167, 64)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1075, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "COURSE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(734, 140)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(772, 36)
        Me.PictureBox5.TabIndex = 119
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(813, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 28)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "YEAR LEVEL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(734, 100)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox6.TabIndex = 118
        Me.PictureBox6.TabStop = False
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYearLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(1003, 100)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(503, 36)
        Me.cmbYearLevel.TabIndex = 5
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(734, 176)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(772, 36)
        Me.cmbCourse.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(781, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 28)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "STUDENT QR CODE:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(734, 220)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(662, 36)
        Me.PictureBox8.TabIndex = 122
        Me.PictureBox8.TabStop = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(1402, 220)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(104, 36)
        Me.btnGenerate.TabIndex = 124
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtStudentQR
        '
        Me.txtStudentQR.AutoSize = True
        Me.txtStudentQR.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtStudentQR.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentQR.ForeColor = System.Drawing.Color.White
        Me.txtStudentQR.Location = New System.Drawing.Point(998, 223)
        Me.txtStudentQR.Name = "txtStudentQR"
        Me.txtStudentQR.Size = New System.Drawing.Size(207, 28)
        Me.txtStudentQR.TabIndex = 125
        Me.txtStudentQR.Text = "STU-1810604-AST547"
        Me.txtStudentQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLookFor
        '
        Me.btnLookFor.BackColor = System.Drawing.Color.Transparent
        Me.btnLookFor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLookFor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLookFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookFor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookFor.Location = New System.Drawing.Point(739, 769)
        Me.btnLookFor.Name = "btnLookFor"
        Me.btnLookFor.Size = New System.Drawing.Size(44, 36)
        Me.btnLookFor.TabIndex = 129
        Me.btnLookFor.Text = "Q"
        Me.btnLookFor.UseVisualStyleBackColor = False
        '
        'cmbCondition2
        '
        Me.cmbCondition2.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCondition2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition2.FormattingEnabled = True
        Me.cmbCondition2.Location = New System.Drawing.Point(444, 769)
        Me.cmbCondition2.Name = "cmbCondition2"
        Me.cmbCondition2.Size = New System.Drawing.Size(289, 36)
        Me.cmbCondition2.TabIndex = 128
        '
        'cmbCondition1
        '
        Me.cmbCondition1.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCondition1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition1.FormattingEnabled = True
        Me.cmbCondition1.Items.AddRange(New Object() {"YEAR LEVEL", "COURSE"})
        Me.cmbCondition1.Location = New System.Drawing.Point(128, 769)
        Me.cmbCondition1.Name = "cmbCondition1"
        Me.cmbCondition1.Size = New System.Drawing.Size(308, 36)
        Me.cmbCondition1.TabIndex = 126
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(17, 772)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 28)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "LOOK FOR:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnPrint
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1138, 22)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(204, 60)
        Me.btnPrint.TabIndex = 130
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ManageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1525, 834)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLookFor)
        Me.Controls.Add(Me.cmbCondition2)
        Me.Controls.Add(Me.cmbCondition1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtStudentQR)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.cmbCourse)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtStudentid)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageStudents"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtStudentid As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtStudentQR As System.Windows.Forms.Label
    Friend WithEvents btnLookFor As System.Windows.Forms.Button
    Friend WithEvents cmbCondition2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCondition1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
