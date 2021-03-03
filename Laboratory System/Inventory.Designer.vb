<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.SuppliesDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.cmbRoomLocation = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbShelfLocation = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbClassification = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbAvailability = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpAcDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.cmbCondition = New System.Windows.Forms.ComboBox()
        Me.cmbRemarks = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.txtUID = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.cmbCondition1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCondition2 = New System.Windows.Forms.ComboBox()
        Me.btnLookFor = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.searchbar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(31, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(371, 28)
        Me.txtSearch.TabIndex = 13
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
        Me.btnSearch.Location = New System.Drawing.Point(408, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(31, 28)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(23, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOM LOCATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(853, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "QUANTITY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(776, 93)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(886, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UNIT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(776, 133)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SHELF LOCATION"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(23, 133)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(851, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CONDITION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(776, 173)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(103, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CATEGORY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(23, 212)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox7.TabIndex = 20
        Me.PictureBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(846, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "AVAILABILITY"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(776, 253)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox8.TabIndex = 32
        Me.PictureBox8.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(78, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "CLASSIFICATION"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(23, 172)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox9.TabIndex = 28
        Me.PictureBox9.TabStop = False
        '
        'SuppliesDataGridView
        '
        Me.SuppliesDataGridView.AllowUserToAddRows = False
        Me.SuppliesDataGridView.AllowUserToDeleteRows = False
        Me.SuppliesDataGridView.AllowUserToResizeRows = False
        Me.SuppliesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SuppliesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SuppliesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.SuppliesDataGridView.ColumnHeadersHeight = 30
        Me.SuppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.SuppliesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuppliesDataGridView.GridColor = System.Drawing.Color.White
        Me.SuppliesDataGridView.Location = New System.Drawing.Point(23, 337)
        Me.SuppliesDataGridView.MultiSelect = False
        Me.SuppliesDataGridView.Name = "SuppliesDataGridView"
        Me.SuppliesDataGridView.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SuppliesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SuppliesDataGridView.RowHeadersVisible = False
        Me.SuppliesDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.SuppliesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.SuppliesDataGridView.RowTemplate.Height = 35
        Me.SuppliesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SuppliesDataGridView.Size = New System.Drawing.Size(1477, 415)
        Me.SuppliesDataGridView.TabIndex = 33
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
        Me.btnAdd.Location = New System.Drawing.Point(814, 761)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(167, 64)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.btnUpdate.Location = New System.Drawing.Point(987, 761)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(167, 64)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(1160, 761)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(167, 64)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.UseVisualStyleBackColor = False
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
        Me.btnClear.Location = New System.Drawing.Point(1333, 761)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(167, 64)
        Me.btnClear.TabIndex = 18
        Me.btnClear.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(1358, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 60)
        Me.btnBack.TabIndex = 38
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(292, 258)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(473, 27)
        Me.txtItemName.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(101, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 28)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "ITEM NAME"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(23, 253)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox10.TabIndex = 42
        Me.PictureBox10.TabStop = False
        '
        'cmbRoomLocation
        '
        Me.cmbRoomLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbRoomLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRoomLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbRoomLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRoomLocation.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomLocation.FormattingEnabled = True
        Me.cmbRoomLocation.Location = New System.Drawing.Point(288, 93)
        Me.cmbRoomLocation.Name = "cmbRoomLocation"
        Me.cmbRoomLocation.Size = New System.Drawing.Size(482, 36)
        Me.cmbRoomLocation.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(1044, 97)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(446, 27)
        Me.txtQty.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1041, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(459, 36)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmbShelfLocation
        '
        Me.cmbShelfLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbShelfLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbShelfLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbShelfLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbShelfLocation.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShelfLocation.FormattingEnabled = True
        Me.cmbShelfLocation.Location = New System.Drawing.Point(288, 133)
        Me.cmbShelfLocation.Name = "cmbShelfLocation"
        Me.cmbShelfLocation.Size = New System.Drawing.Size(482, 36)
        Me.cmbShelfLocation.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(288, 212)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(482, 36)
        Me.cmbCategory.TabIndex = 4
        '
        'cmbClassification
        '
        Me.cmbClassification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbClassification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClassification.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClassification.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.Location = New System.Drawing.Point(288, 172)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(482, 36)
        Me.cmbClassification.TabIndex = 3
        '
        'cmbUnit
        '
        Me.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnit.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(1041, 133)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(459, 36)
        Me.cmbUnit.TabIndex = 8
        '
        'cmbAvailability
        '
        Me.cmbAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAvailability.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvailability.FormattingEnabled = True
        Me.cmbAvailability.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.cmbAvailability.Location = New System.Drawing.Point(1041, 253)
        Me.cmbAvailability.Name = "cmbAvailability"
        Me.cmbAvailability.Size = New System.Drawing.Size(459, 36)
        Me.cmbAvailability.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(288, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(482, 36)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtpAcDate
        '
        Me.dtpAcDate.CalendarFont = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAcDate.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.dtpAcDate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAcDate.Location = New System.Drawing.Point(1041, 213)
        Me.dtpAcDate.Name = "dtpAcDate"
        Me.dtpAcDate.Size = New System.Drawing.Size(460, 35)
        Me.dtpAcDate.TabIndex = 10
        Me.dtpAcDate.Value = New Date(2020, 1, 22, 0, 0, 0, 0)
        '
        'cmbItemType
        '
        Me.cmbItemType.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbItemType.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Items.AddRange(New Object() {"NON-CONSUMABLE", "SOLID CHEMICAL(CONSUMABLE)", "LIQUID CHEMICAL(CONSUMABLE)", "INDICATOR(CONSUMABLE)"})
        Me.cmbItemType.Location = New System.Drawing.Point(288, 295)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(482, 36)
        Me.cmbItemType.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(109, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 28)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "ITEM TYPE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(23, 295)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox11.TabIndex = 53
        Me.PictureBox11.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(821, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 28)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "ACQUISITION DATE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(776, 213)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(268, 35)
        Me.PictureBox12.TabIndex = 55
        Me.PictureBox12.TabStop = False
        '
        'cmbCondition
        '
        Me.cmbCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.Items.AddRange(New Object() {"Functioning", "Not-Functioning", "Expired", "For Repair"})
        Me.cmbCondition.Location = New System.Drawing.Point(1041, 173)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.Size = New System.Drawing.Size(459, 36)
        Me.cmbCondition.TabIndex = 9
        '
        'cmbRemarks
        '
        Me.cmbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRemarks.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRemarks.FormattingEnabled = True
        Me.cmbRemarks.Location = New System.Drawing.Point(1041, 295)
        Me.cmbRemarks.Name = "cmbRemarks"
        Me.cmbRemarks.Size = New System.Drawing.Size(459, 36)
        Me.cmbRemarks.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(862, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 28)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "REMARKS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox13.Location = New System.Drawing.Point(776, 295)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(268, 36)
        Me.PictureBox13.TabIndex = 59
        Me.PictureBox13.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(482, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 28)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "UID:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox14.Location = New System.Drawing.Point(477, 48)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(183, 36)
        Me.PictureBox14.TabIndex = 62
        Me.PictureBox14.TabStop = False
        '
        'txtUID
        '
        Me.txtUID.AutoSize = True
        Me.txtUID.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtUID.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.ForeColor = System.Drawing.Color.White
        Me.txtUID.Location = New System.Drawing.Point(525, 51)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(126, 28)
        Me.txtUID.TabIndex = 63
        Me.txtUID.Text = "CSLSWW123"
        Me.txtUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnGenerate.Location = New System.Drawing.Point(666, 48)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(104, 36)
        Me.btnGenerate.TabIndex = 64
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'cmbCondition1
        '
        Me.cmbCondition1.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCondition1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition1.FormattingEnabled = True
        Me.cmbCondition1.Items.AddRange(New Object() {"ROOM LOCATION", "SHELF LOCATION", "CLASSIFICATION", "AVAILABILITY", "CONDITION", "CATEGORY", "ITEM TYPE", "UNIT"})
        Me.cmbCondition1.Location = New System.Drawing.Point(131, 774)
        Me.cmbCondition1.Name = "cmbCondition1"
        Me.cmbCondition1.Size = New System.Drawing.Size(308, 36)
        Me.cmbCondition1.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(20, 777)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 28)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "LOOK FOR:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCondition2
        '
        Me.cmbCondition2.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.cmbCondition2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondition2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondition2.FormattingEnabled = True
        Me.cmbCondition2.Location = New System.Drawing.Point(447, 774)
        Me.cmbCondition2.Name = "cmbCondition2"
        Me.cmbCondition2.Size = New System.Drawing.Size(289, 36)
        Me.cmbCondition2.TabIndex = 68
        '
        'btnLookFor
        '
        Me.btnLookFor.BackColor = System.Drawing.Color.Transparent
        Me.btnLookFor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLookFor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLookFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookFor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookFor.Location = New System.Drawing.Point(742, 774)
        Me.btnLookFor.Name = "btnLookFor"
        Me.btnLookFor.Size = New System.Drawing.Size(44, 36)
        Me.btnLookFor.TabIndex = 69
        Me.btnLookFor.Text = "Q"
        Me.btnLookFor.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Location = New System.Drawing.Point(849, 52)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(45, 13)
        Me.lblUser.TabIndex = 70
        Me.lblUser.Text = "Label15"
        Me.lblUser.Visible = False
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
        Me.btnPrint.Location = New System.Drawing.Point(1137, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(204, 60)
        Me.btnPrint.TabIndex = 71
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1525, 834)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnLookFor)
        Me.Controls.Add(Me.cmbCondition2)
        Me.Controls.Add(Me.cmbCondition1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.cmbRemarks)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.cmbCondition)
        Me.Controls.Add(Me.dtpAcDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.cmbItemType)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbAvailability)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmbClassification)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.cmbShelfLocation)
        Me.Controls.Add(Me.cmbRoomLocation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.SuppliesDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox10)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents SuppliesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbRoomLocation As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbShelfLocation As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClassification As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAvailability As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpAcDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCondition As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUID As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents cmbCondition1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbCondition2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnLookFor As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button

End Class
