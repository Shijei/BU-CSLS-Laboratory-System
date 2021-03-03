<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBlacklisted = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.btnToReturn = New System.Windows.Forms.Button()
        Me.btnToManageRequests = New System.Windows.Forms.Button()
        Me.btnToInventory = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftwelcomebg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 102)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.btnBack.Location = New System.Drawing.Point(1222, 43)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 71)
        Me.btnBack.TabIndex = 39
        Me.btnBack.UseVisualStyleBackColor = False
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
        Me.btnBlacklisted.Location = New System.Drawing.Point(1252, 58)
        Me.btnBlacklisted.Name = "btnBlacklisted"
        Me.btnBlacklisted.Size = New System.Drawing.Size(41, 40)
        Me.btnBlacklisted.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.btnBlacklisted, "Blacklisted Students")
        Me.btnBlacklisted.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(1322, 58)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(41, 40)
        Me.btnLogout.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.btnLogout, "Click to logout")
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "WELCOME!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStaffName
        '
        Me.lblStaffName.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblStaffName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.ForeColor = System.Drawing.Color.White
        Me.lblStaffName.Location = New System.Drawing.Point(12, 60)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(456, 38)
        Me.lblStaffName.TabIndex = 43
        Me.lblStaffName.Text = "STAFF NAME "
        '
        'btnToReturn
        '
        Me.btnToReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnToReturn.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.returnrequesticon
        Me.btnToReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToReturn.FlatAppearance.BorderSize = 0
        Me.btnToReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnToReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnToReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToReturn.Location = New System.Drawing.Point(604, 269)
        Me.btnToReturn.Name = "btnToReturn"
        Me.btnToReturn.Size = New System.Drawing.Size(199, 215)
        Me.btnToReturn.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.btnToReturn, "Click to proceed in Student's Return Requests Form")
        Me.btnToReturn.UseVisualStyleBackColor = False
        '
        'btnToManageRequests
        '
        Me.btnToManageRequests.BackColor = System.Drawing.Color.Transparent
        Me.btnToManageRequests.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.managerequesticon
        Me.btnToManageRequests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToManageRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToManageRequests.FlatAppearance.BorderSize = 0
        Me.btnToManageRequests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnToManageRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnToManageRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToManageRequests.Location = New System.Drawing.Point(205, 312)
        Me.btnToManageRequests.Name = "btnToManageRequests"
        Me.btnToManageRequests.Size = New System.Drawing.Size(242, 172)
        Me.btnToManageRequests.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnToManageRequests, "Click to proceed Manage Student Requests Form")
        Me.btnToManageRequests.UseVisualStyleBackColor = False
        '
        'btnToInventory
        '
        Me.btnToInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnToInventory.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.inventoryicon
        Me.btnToInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToInventory.FlatAppearance.BorderSize = 0
        Me.btnToInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnToInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnToInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToInventory.Location = New System.Drawing.Point(968, 252)
        Me.btnToInventory.Name = "btnToInventory"
        Me.btnToInventory.Size = New System.Drawing.Size(160, 227)
        Me.btnToInventory.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.btnToInventory, "Click to proceed in Inventory Form")
        Me.btnToInventory.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.scanqrcodebg
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(190, 516)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 87)
        Me.Button4.TabIndex = 47
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(245, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 82)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "MANAGE REQUESTS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(604, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 82)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "PENDING RETURNS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Button3.Location = New System.Drawing.Point(574, 516)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 87)
        Me.Button3.TabIndex = 49
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(930, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 82)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "INVENTORY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.scanqrcodebg
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(922, 516)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(259, 87)
        Me.Button5.TabIndex = 51
        Me.Button5.UseVisualStyleBackColor = False
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1387, 758)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnToInventory)
        Me.Controls.Add(Me.btnToReturn)
        Me.Controls.Add(Me.btnToManageRequests)
        Me.Controls.Add(Me.lblStaffName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBlacklisted)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBlacklisted As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStaffName As System.Windows.Forms.Label
    Friend WithEvents btnToReturn As System.Windows.Forms.Button
    Friend WithEvents btnToManageRequests As System.Windows.Forms.Button
    Friend WithEvents btnToInventory As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
