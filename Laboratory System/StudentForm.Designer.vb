<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnToReturn = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStudentName
        '
        Me.lblStudentName.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.White
        Me.lblStudentName.Location = New System.Drawing.Point(11, 75)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(456, 27)
        Me.lblStudentName.TabIndex = 46
        Me.lblStudentName.Text = "STUDENT NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "WELCOME!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftwelcomebg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 131)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 28)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "HOW CAN WE HELP YOU?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Button4.Location = New System.Drawing.Point(424, 554)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 60)
        Me.Button4.TabIndex = 48
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(478, 562)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 41)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "REQUEST"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.Transparent
        Me.btnRequest.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnRequest
        Me.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequest.FlatAppearance.BorderSize = 0
        Me.btnRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequest.Location = New System.Drawing.Point(458, 322)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(191, 204)
        Me.btnRequest.TabIndex = 50
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(828, 562)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 41)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "MY REQUEST"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Button2.Location = New System.Drawing.Point(791, 554)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(259, 60)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "s"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.btnToReturn.Location = New System.Drawing.Point(808, 320)
        Me.btnToReturn.Name = "btnToReturn"
        Me.btnToReturn.Size = New System.Drawing.Size(229, 230)
        Me.btnToReturn.TabIndex = 53
        Me.btnToReturn.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(1322, 90)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(41, 40)
        Me.btnLogout.TabIndex = 55
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
        Me.btnBack.Location = New System.Drawing.Point(1290, 75)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 71)
        Me.btnBack.TabIndex = 54
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1387, 758)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnToReturn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnToReturn As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
