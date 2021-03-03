<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectLoginForm))
        Me.btnStaffLogin = New System.Windows.Forms.Button()
        Me.btnStudentLogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSecretbutton = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.btnSecretbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStaffLogin
        '
        Me.btnStaffLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnStaffLogin.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.staffloginicon
        Me.btnStaffLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStaffLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaffLogin.FlatAppearance.BorderSize = 0
        Me.btnStaffLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStaffLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStaffLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffLogin.Location = New System.Drawing.Point(350, 239)
        Me.btnStaffLogin.Name = "btnStaffLogin"
        Me.btnStaffLogin.Size = New System.Drawing.Size(310, 335)
        Me.btnStaffLogin.TabIndex = 11
        Me.btnStaffLogin.UseVisualStyleBackColor = False
        '
        'btnStudentLogin
        '
        Me.btnStudentLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentLogin.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.studentloginicon1
        Me.btnStudentLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStudentLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentLogin.FlatAppearance.BorderSize = 0
        Me.btnStudentLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStudentLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentLogin.Location = New System.Drawing.Point(767, 239)
        Me.btnStudentLogin.Name = "btnStudentLogin"
        Me.btnStudentLogin.Size = New System.Drawing.Size(310, 335)
        Me.btnStudentLogin.TabIndex = 12
        Me.btnStudentLogin.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(392, 583)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(226, 60)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(807, 583)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 60)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(457, 594)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "STAFF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(860, 594)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 37)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "STUDENT"
        '
        'btnSecretbutton
        '
        Me.btnSecretbutton.BackColor = System.Drawing.Color.Transparent
        Me.btnSecretbutton.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.footerLogo
        Me.btnSecretbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSecretbutton.Location = New System.Drawing.Point(504, -2)
        Me.btnSecretbutton.Name = "btnSecretbutton"
        Me.btnSecretbutton.Size = New System.Drawing.Size(399, 123)
        Me.btnSecretbutton.TabIndex = 17
        Me.btnSecretbutton.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(1314, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 62)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'SelectLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1387, 758)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSecretbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnStudentLogin)
        Me.Controls.Add(Me.btnStaffLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectLoginForm"
        CType(Me.btnSecretbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStaffLogin As System.Windows.Forms.Button
    Friend WithEvents btnStudentLogin As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSecretbutton As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
