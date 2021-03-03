<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        Me.TheStudentRequestedItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentsAndDateReturnedDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnDeleteSingle = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TheStudentRequestedItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsAndDateReturnedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TheStudentRequestedItemDataGridView
        '
        Me.TheStudentRequestedItemDataGridView.AllowUserToAddRows = False
        Me.TheStudentRequestedItemDataGridView.AllowUserToDeleteRows = False
        Me.TheStudentRequestedItemDataGridView.AllowUserToResizeRows = False
        Me.TheStudentRequestedItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TheStudentRequestedItemDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TheStudentRequestedItemDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TheStudentRequestedItemDataGridView.ColumnHeadersHeight = 30
        Me.TheStudentRequestedItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TheStudentRequestedItemDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TheStudentRequestedItemDataGridView.GridColor = System.Drawing.Color.White
        Me.TheStudentRequestedItemDataGridView.Location = New System.Drawing.Point(8, 195)
        Me.TheStudentRequestedItemDataGridView.MultiSelect = False
        Me.TheStudentRequestedItemDataGridView.Name = "TheStudentRequestedItemDataGridView"
        Me.TheStudentRequestedItemDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TheStudentRequestedItemDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TheStudentRequestedItemDataGridView.RowHeadersVisible = False
        Me.TheStudentRequestedItemDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.TheStudentRequestedItemDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TheStudentRequestedItemDataGridView.RowTemplate.Height = 35
        Me.TheStudentRequestedItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TheStudentRequestedItemDataGridView.Size = New System.Drawing.Size(735, 399)
        Me.TheStudentRequestedItemDataGridView.TabIndex = 35
        '
        'StudentsAndDateReturnedDataGridView
        '
        Me.StudentsAndDateReturnedDataGridView.AllowUserToAddRows = False
        Me.StudentsAndDateReturnedDataGridView.AllowUserToDeleteRows = False
        Me.StudentsAndDateReturnedDataGridView.AllowUserToResizeRows = False
        Me.StudentsAndDateReturnedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentsAndDateReturnedDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsAndDateReturnedDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentsAndDateReturnedDataGridView.ColumnHeadersHeight = 30
        Me.StudentsAndDateReturnedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentsAndDateReturnedDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentsAndDateReturnedDataGridView.GridColor = System.Drawing.Color.White
        Me.StudentsAndDateReturnedDataGridView.Location = New System.Drawing.Point(8, 43)
        Me.StudentsAndDateReturnedDataGridView.MultiSelect = False
        Me.StudentsAndDateReturnedDataGridView.Name = "StudentsAndDateReturnedDataGridView"
        Me.StudentsAndDateReturnedDataGridView.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsAndDateReturnedDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.StudentsAndDateReturnedDataGridView.RowHeadersVisible = False
        Me.StudentsAndDateReturnedDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.StudentsAndDateReturnedDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.StudentsAndDateReturnedDataGridView.RowTemplate.Height = 35
        Me.StudentsAndDateReturnedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentsAndDateReturnedDataGridView.Size = New System.Drawing.Size(732, 107)
        Me.StudentsAndDateReturnedDataGridView.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.StudentsAndDateReturnedDataGridView, "Select a row to view past transactions on given date")
        '
        'btnDeleteSingle
        '
        Me.btnDeleteSingle.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSingle.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnDeleteSingleHistory
        Me.btnDeleteSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteSingle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSingle.FlatAppearance.BorderSize = 0
        Me.btnDeleteSingle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSingle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSingle.Location = New System.Drawing.Point(239, 603)
        Me.btnDeleteSingle.Name = "btnDeleteSingle"
        Me.btnDeleteSingle.Size = New System.Drawing.Size(249, 64)
        Me.btnDeleteSingle.TabIndex = 101
        Me.ToolTip1.SetToolTip(Me.btnDeleteSingle, "Delete selected student's transaction history")
        Me.btnDeleteSingle.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.btnDeleteMultipleHistory
        Me.btnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAll.FlatAppearance.BorderSize = 0
        Me.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAll.Location = New System.Drawing.Point(494, 603)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(249, 64)
        Me.btnDeleteAll.TabIndex = 102
        Me.ToolTip1.SetToolTip(Me.btnDeleteAll, "Simple delete all information in the transaction history")
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(298, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 28)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "REQUESTED ITEMS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(8, 159)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(735, 36)
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.leftlabel
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 36)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 28)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "STUDENTS WITH PAST TRANSACTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaboratorySystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 679)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnDeleteSingle)
        Me.Controls.Add(Me.StudentsAndDateReturnedDataGridView)
        Me.Controls.Add(Me.TheStudentRequestedItemDataGridView)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction History"
        CType(Me.TheStudentRequestedItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsAndDateReturnedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TheStudentRequestedItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StudentsAndDateReturnedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteSingle As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
