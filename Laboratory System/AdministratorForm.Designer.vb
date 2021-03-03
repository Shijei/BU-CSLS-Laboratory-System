<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministratorForm))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnManageStudent = New System.Windows.Forms.Button()
        Me.btnManageStaff = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBlacklisted = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnChangepass = New System.Windows.Forms.Button()
        Me.panelChangepass = New System.Windows.Forms.Panel()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOldpass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpdateSY = New System.Windows.Forms.Button()
        Me.btnUpdate1To3 = New System.Windows.Forms.Button()
        Me.btnUpdate1To4 = New System.Windows.Forms.Button()
        Me.btnDelete5 = New System.Windows.Forms.Button()
        Me.btnDelete4 = New System.Windows.Forms.Button()
        Me.panelNewSchoolYearOption = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChangepass.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNewSchoolYearOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLogout.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.exitbutton
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1331, 65)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(41, 40)
        Me.btnLogout.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnLogout, "Logout")
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.backbutton
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Enabled = False
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1067, 50)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(320, 71)
        Me.btnBack.TabIndex = 42
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblStaffName
        '
        Me.lblStaffName.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblStaffName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.ForeColor = System.Drawing.Color.White
        Me.lblStaffName.Location = New System.Drawing.Point(10, 66)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(189, 25)
        Me.lblStaffName.TabIndex = 46
        Me.lblStaffName.Text = "ADMINISTRATOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "WELCOME!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftwelcomebg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 76)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(631, 533)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 37)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "MANAGE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(213, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 37)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "MANAGE"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.scanqrcodebg
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(566, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(254, 100)
        Me.Button3.TabIndex = 50
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnManageStudent
        '
        Me.btnManageStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnManageStudent.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.studentloginicon1
        Me.btnManageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageStudent.FlatAppearance.BorderSize = 0
        Me.btnManageStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnManageStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageStudent.Location = New System.Drawing.Point(537, 178)
        Me.btnManageStudent.Name = "btnManageStudent"
        Me.btnManageStudent.Size = New System.Drawing.Size(310, 335)
        Me.btnManageStudent.TabIndex = 48
        Me.btnManageStudent.UseVisualStyleBackColor = False
        '
        'btnManageStaff
        '
        Me.btnManageStaff.BackColor = System.Drawing.Color.Transparent
        Me.btnManageStaff.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.staffloginicon
        Me.btnManageStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageStaff.FlatAppearance.BorderSize = 0
        Me.btnManageStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnManageStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageStaff.Location = New System.Drawing.Point(130, 178)
        Me.btnManageStaff.Name = "btnManageStaff"
        Me.btnManageStaff.Size = New System.Drawing.Size(310, 335)
        Me.btnManageStaff.TabIndex = 47
        Me.btnManageStaff.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1006, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 37)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "INVENTORY"
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.inventoryicon
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Location = New System.Drawing.Point(982, 205)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(197, 308)
        Me.btnInventory.TabIndex = 55
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(625, 570)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 37)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "STUDENTS"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.scanqrcodebg
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(157, 519)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 100)
        Me.Button2.TabIndex = 57
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(231, 570)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 37)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "STAFF"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.scanqrcodebg
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(955, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 100)
        Me.Button1.TabIndex = 59
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBlacklisted
        '
        Me.btnBlacklisted.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBlacklisted.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.blockstudent
        Me.btnBlacklisted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBlacklisted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlacklisted.FlatAppearance.BorderSize = 0
        Me.btnBlacklisted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBlacklisted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnBlacklisted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlacklisted.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlacklisted.ForeColor = System.Drawing.Color.White
        Me.btnBlacklisted.Location = New System.Drawing.Point(1265, 65)
        Me.btnBlacklisted.Name = "btnBlacklisted"
        Me.btnBlacklisted.Size = New System.Drawing.Size(41, 40)
        Me.btnBlacklisted.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.btnBlacklisted, "Blacklisted Students")
        Me.btnBlacklisted.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnHistory.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnHistory
        Me.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(1203, 66)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(43, 40)
        Me.btnHistory.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.btnHistory, "Transaction History")
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnChangepass
        '
        Me.btnChangepass.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnChangepass.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnChangepassword
        Me.btnChangepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangepass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangepass.FlatAppearance.BorderSize = 0
        Me.btnChangepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnChangepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnChangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangepass.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangepass.ForeColor = System.Drawing.Color.White
        Me.btnChangepass.Location = New System.Drawing.Point(1146, 66)
        Me.btnChangepass.Name = "btnChangepass"
        Me.btnChangepass.Size = New System.Drawing.Size(43, 40)
        Me.btnChangepass.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.btnChangepass, "Change password")
        Me.btnChangepass.UseVisualStyleBackColor = False
        '
        'panelChangepass
        '
        Me.panelChangepass.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.panelChangepass.Controls.Add(Me.btnConfirm)
        Me.panelChangepass.Controls.Add(Me.Label9)
        Me.panelChangepass.Controls.Add(Me.txtNewPass)
        Me.panelChangepass.Controls.Add(Me.PictureBox3)
        Me.panelChangepass.Controls.Add(Me.Label8)
        Me.panelChangepass.Controls.Add(Me.txtOldpass)
        Me.panelChangepass.Controls.Add(Me.Label7)
        Me.panelChangepass.Controls.Add(Me.PictureBox2)
        Me.panelChangepass.Location = New System.Drawing.Point(631, 120)
        Me.panelChangepass.Name = "panelChangepass"
        Me.panelChangepass.Size = New System.Drawing.Size(561, 413)
        Me.panelChangepass.TabIndex = 63
        Me.panelChangepass.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnConfirmPass
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(210, 324)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(170, 60)
        Me.btnConfirm.TabIndex = 33
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(28, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 37)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "NEW PASSWORD:"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        Me.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(52, 257)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(472, 36)
        Me.txtNewPass.TabIndex = 31
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PictureBox3.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.textboxbackground
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(35, 247)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(503, 55)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 37)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "OLD PASSWORD:"
        '
        'txtOldpass
        '
        Me.txtOldpass.BackColor = System.Drawing.Color.White
        Me.txtOldpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldpass.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldpass.Location = New System.Drawing.Point(46, 143)
        Me.txtOldpass.Name = "txtOldpass"
        Me.txtOldpass.Size = New System.Drawing.Size(472, 36)
        Me.txtOldpass.TabIndex = 28
        Me.txtOldpass.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(516, 37)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "CHANGE ADMINISTRATOR ACCESS KEY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.textboxbackground
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(29, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(503, 55)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'btnUpdateSY
        '
        Me.btnUpdateSY.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdateSY.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnUpdateSY1
        Me.btnUpdateSY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateSY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateSY.FlatAppearance.BorderSize = 0
        Me.btnUpdateSY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdateSY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdateSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSY.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSY.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSY.Location = New System.Drawing.Point(1089, 68)
        Me.btnUpdateSY.Name = "btnUpdateSY"
        Me.btnUpdateSY.Size = New System.Drawing.Size(43, 40)
        Me.btnUpdateSY.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.btnUpdateSY, "Change password")
        Me.btnUpdateSY.UseVisualStyleBackColor = False
        '
        'btnUpdate1To3
        '
        Me.btnUpdate1To3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To3.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btn1stTo3rdUpdate
        Me.btnUpdate1To3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate1To3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate1To3.FlatAppearance.BorderSize = 0
        Me.btnUpdate1To3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate1To3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate1To3.ForeColor = System.Drawing.Color.White
        Me.btnUpdate1To3.Location = New System.Drawing.Point(39, 255)
        Me.btnUpdate1To3.Name = "btnUpdate1To3"
        Me.btnUpdate1To3.Size = New System.Drawing.Size(165, 137)
        Me.btnUpdate1To3.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.btnUpdate1To3, "Change password")
        Me.btnUpdate1To3.UseVisualStyleBackColor = False
        '
        'btnUpdate1To4
        '
        Me.btnUpdate1To4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To4.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btn1stTo4thUpdate
        Me.btnUpdate1To4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate1To4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate1To4.FlatAppearance.BorderSize = 0
        Me.btnUpdate1To4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnUpdate1To4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate1To4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate1To4.ForeColor = System.Drawing.Color.White
        Me.btnUpdate1To4.Location = New System.Drawing.Point(249, 255)
        Me.btnUpdate1To4.Name = "btnUpdate1To4"
        Me.btnUpdate1To4.Size = New System.Drawing.Size(165, 137)
        Me.btnUpdate1To4.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.btnUpdate1To4, "Change password")
        Me.btnUpdate1To4.UseVisualStyleBackColor = False
        '
        'btnDelete5
        '
        Me.btnDelete5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete5.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btn5thYearDelete
        Me.btnDelete5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete5.FlatAppearance.BorderSize = 0
        Me.btnDelete5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete5.ForeColor = System.Drawing.Color.White
        Me.btnDelete5.Location = New System.Drawing.Point(249, 88)
        Me.btnDelete5.Name = "btnDelete5"
        Me.btnDelete5.Size = New System.Drawing.Size(165, 137)
        Me.btnDelete5.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.btnDelete5, "Change password")
        Me.btnDelete5.UseVisualStyleBackColor = False
        '
        'btnDelete4
        '
        Me.btnDelete4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete4.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btn4thYearDelete
        Me.btnDelete4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete4.FlatAppearance.BorderSize = 0
        Me.btnDelete4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnDelete4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete4.ForeColor = System.Drawing.Color.White
        Me.btnDelete4.Location = New System.Drawing.Point(39, 88)
        Me.btnDelete4.Name = "btnDelete4"
        Me.btnDelete4.Size = New System.Drawing.Size(165, 137)
        Me.btnDelete4.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.btnDelete4, "Change password")
        Me.btnDelete4.UseVisualStyleBackColor = False
        '
        'panelNewSchoolYearOption
        '
        Me.panelNewSchoolYearOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.panelNewSchoolYearOption.Controls.Add(Me.btnDelete5)
        Me.panelNewSchoolYearOption.Controls.Add(Me.btnDelete4)
        Me.panelNewSchoolYearOption.Controls.Add(Me.btnUpdate1To4)
        Me.panelNewSchoolYearOption.Controls.Add(Me.btnUpdate1To3)
        Me.panelNewSchoolYearOption.Controls.Add(Me.Label10)
        Me.panelNewSchoolYearOption.Location = New System.Drawing.Point(638, 50)
        Me.panelNewSchoolYearOption.Name = "panelNewSchoolYearOption"
        Me.panelNewSchoolYearOption.Size = New System.Drawing.Size(445, 424)
        Me.panelNewSchoolYearOption.TabIndex = 65
        Me.panelNewSchoolYearOption.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(36, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(378, 37)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "NEW SCHOOL YEAR OPTION"
        '
        'AdministratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1387, 758)
        Me.Controls.Add(Me.panelNewSchoolYearOption)
        Me.Controls.Add(Me.btnUpdateSY)
        Me.Controls.Add(Me.panelChangepass)
        Me.Controls.Add(Me.btnChangepass)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnBlacklisted)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnManageStudent)
        Me.Controls.Add(Me.btnManageStaff)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministratorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministratorForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChangepass.ResumeLayout(False)
        Me.panelChangepass.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNewSchoolYearOption.ResumeLayout(False)
        Me.panelNewSchoolYearOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnManageStudent As System.Windows.Forms.Button
    Friend WithEvents btnManageStaff As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBlacklisted As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnChangepass As System.Windows.Forms.Button
    Friend WithEvents panelChangepass As System.Windows.Forms.Panel
    Friend WithEvents txtOldpass As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnUpdateSY As System.Windows.Forms.Button
    Friend WithEvents panelNewSchoolYearOption As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate1To3 As System.Windows.Forms.Button
    Friend WithEvents btnDelete5 As System.Windows.Forms.Button
    Friend WithEvents btnDelete4 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate1To4 As System.Windows.Forms.Button
End Class
