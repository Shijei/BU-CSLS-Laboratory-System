Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class ManagePendingReturn

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Public staffName As String
    Dim uid, itemtype, huid, hitemname, hitemtype, hunit, blacklistreason As String
    Dim hdateborrowed As Date
    Dim studentid, studentname, yearLevel, studentCourse, searchquery As String
    Dim qty, newqty, hqty As Integer

    Private Function BlacklistStudent() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_IsBlacklisted] = 'True', [_BlacklistReason] = '" & blacklistreason & "' WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function SearchForSomething() As DataTable
        Dim studentData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_YearLevel] As [Year Level], [_Course] As [Course], [_DateNeeded] As [Date of Laboratory Activity] FROM tblRequestInfo WHERE ([_StudentID] LIKE '%" & searchquery & "%' OR [_FullName] LIKE '%" & searchquery & "%') AND [_IsValidated] = 'True' ORDER BY [_DateNeeded] ASC, [_YearLevel], [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                studentData.Load(reader)
            End Using
        End Using
        Return studentData
    End Function



    Private Function GetStudentWithReturningData() As DataTable
        Dim studentData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_YearLevel] As [Year Level], [_Course] As [Course], [_DateNeeded] As [Date of Laboratory Activity] FROM tblRequestInfo WHERE [_IsValidated] = 'True' ORDER BY [_DateNeeded] ASC, [_YearLevel], [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                studentData.Load(reader)
            End Using
        End Using
        Return studentData
    End Function

    Private Function GetStudentRequestInfo() As DataTable
        Dim userinfo As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID],[_GroupNo],[_LabSubject],[_ActivityNo],[_Purpose],[_DateNeeded] FROM tblRequestInfo WHERE [_StudentID] = '" & studentid & "'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                rowCount = userinfo.Rows.Count
                Do While (i < rowCount)
                    If userinfo.Rows(i).Item("_StudentID").ToString() = studentid Then
                        txtGroupno.Text = userinfo.Rows(i).Item("_GroupNo").ToString
                        txtLabSubj.Text = userinfo.Rows(i).Item("_LabSubject").ToString
                        txtActno.Text = userinfo.Rows(i).Item("_ActivityNo").ToString
                        txtPurpose.Text = userinfo.Rows(i).Item("_Purpose").ToString
                        dtpDateNeeded.Value = userinfo.Rows(i).Item("_DateNeeded").ToString
                    Else

                    End If
                    i = i + 1
                Loop
            End Using
        End Using
        Return userinfo
    End Function

    Private Function GetStudentRequestedItems() As DataTable
        Dim requestData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_ItemType] As [Item Type], [_Qty] As [Quantity], [_Unit] As [Unit] FROM tblRequest WHERE [_StudentID] = '" & studentid & "' ORDER BY [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                requestData.Load(reader)
            End Using
        End Using
        Return requestData
    End Function

    Private Function ReturnNONConsumables() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_Quantity] = [_Quantity] + " & qty & " WHERE [_UID] = '" & uid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateStudentRequestCount() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_RequestCount] = 0 WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function AddToHistory() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblHistory([_StudentID],[_StudentName],[_UID],[_ItemName],[_ItemType],[_Quantity],[_Unit],[_DateBorrowed],[_StaffInCharge]) VALUES (?,?,?,?,?,?,?,?,?)", conn)

            studentid = lblStudentID.Text
            studentname = lblStudentName.Text

            cmd.Parameters.Add(New OleDbParameter("_StudentID", CType(studentid, String)))
            cmd.Parameters.Add(New OleDbParameter("_StudentName", CType(studentname, String)))
            cmd.Parameters.Add(New OleDbParameter("_UID", CType(huid, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemName", CType(hitemname, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemType", CType(hitemtype, String)))
            cmd.Parameters.Add(New OleDbParameter("_Quantity", CType(hqty, String)))
            cmd.Parameters.Add(New OleDbParameter("_Unit", CType(hunit, String)))
            cmd.Parameters.Add(New OleDbParameter("_DateBorrowed", CType(hdateborrowed, String)))
            cmd.Parameters.Add(New OleDbParameter("_StaffInCharge", CType(staffName, String)))
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MessageBox.Show(ex.Message)
            End Try

        End Using
        Return datalists
    End Function

    Private Function DeleteInRequestTable() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequest WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function DeleteInRequestInformationTable() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequestInfo WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Sub ManagePendingReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentWithPendingReturnLDataGridView.DataSource = GetStudentWithReturningData()
        StudentWithPendingReturnLDataGridView.AutoResizeColumns()
        StudentWithPendingReturnLDataGridView.ClearSelection()
        
    End Sub

    Private Sub StudentWithPendingReturnLDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentWithPendingReturnLDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex 'dont forget
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            selectedRow = StudentWithPendingReturnLDataGridView.Rows(index) 'dont forget
            studentid = selectedRow.Cells(0).Value.ToString()
            studentname = selectedRow.Cells(1).Value.ToString()
            yearLevel = selectedRow.Cells(2).Value.ToString()
            studentCourse = selectedRow.Cells(3).Value.ToString()
            btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        txtSearch.Text = "SEARCH"
        If String.IsNullOrWhiteSpace(studentid) Then
            MessageBox.Show("SELECT A ROW FIRST, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            panel1.Visible = False
            panel2.Visible = True
            lblStudentID.Text = studentid
            lblStudentName.Text = studentname
            lblYearLevel.Text = yearLevel
            lblStudentCourse.Text = studentCourse
            GetStudentRequestInfo()
            ReturningDataGridView.DataSource = GetStudentRequestedItems()
            ReturningDataGridView.AutoResizeColumns()
            ReturningDataGridView.ClearSelection()
        End If
    End Sub

    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles btnCleared.Click
        Dim rowCount, i As Integer
        rowCount = ReturningDataGridView.RowCount
        Dim result As DialogResult = MessageBox.Show("CLEAR UP STUDENT?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            studentid = lblStudentID.Text
            studentname = lblStudentName.Text
            Do While (i < rowCount)
                If ReturningDataGridView.Rows(i).Cells(2).Value.ToString() = "NON-CONSUMABLE" Then
                    uid = ReturningDataGridView.Rows(i).Cells(0).Value.ToString()
                    qty = ReturningDataGridView.Rows(i).Cells(3).Value
                    ReturnNONConsumables()
                End If
                huid = ReturningDataGridView.Rows(i).Cells(0).Value.ToString()
                hitemname = ReturningDataGridView.Rows(i).Cells(1).Value.ToString()
                hitemtype = ReturningDataGridView.Rows(i).Cells(2).Value.ToString()
                hqty = ReturningDataGridView.Rows(i).Cells(3).Value.ToString()
                hunit = ReturningDataGridView.Rows(i).Cells(4).Value.ToString()
                hdateborrowed = dtpDateNeeded.Value
                AddToHistory()
                i = i + 1
            Loop
            UpdateStudentRequestCount()
            DeleteInRequestTable()
            DeleteInRequestInformationTable()
            MessageBox.Show("RETURN SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StudentWithPendingReturnLDataGridView.DataSource = GetStudentWithReturningData()
            StudentWithPendingReturnLDataGridView.AutoResizeColumns()
            StudentWithPendingReturnLDataGridView.ClearSelection()
            panel1.Visible = True
            panel2.Visible = False
            btnNext.Enabled = False
        Else

        End If
    End Sub

    Private Sub btnBlacklist_Click(sender As Object, e As EventArgs) Handles btnBlacklist.Click
        studentid = lblStudentID.Text
        studentname = lblStudentName.Text
        Dim rowCount, i As Integer
        rowCount = ReturningDataGridView.RowCount
        Dim result As DialogResult = MessageBox.Show("CLEAR STUDENT'S RETURNS BUT ADD HIM/HER TO BLACKLIST?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim userEnteredValue As String
            userEnteredValue = Microsoft.VisualBasic.InputBox("Enter reason for blacklisting this student:", "Baliuag University CSLS Laboratory System", "", 600, 344)
            If String.IsNullOrWhiteSpace(userEnteredValue) Then
                MessageBox.Show("Reason cannot be empty/none!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Do While (i < rowCount)
                    If ReturningDataGridView.Rows(i).Cells(2).Value.ToString() = "NON-CONSUMABLE" Then
                        uid = ReturningDataGridView.Rows(i).Cells(0).Value.ToString()
                        qty = ReturningDataGridView.Rows(i).Cells(3).Value
                        ReturnNONConsumables()
                    End If
                    huid = ReturningDataGridView.Rows(i).Cells(0).Value.ToString()
                    hitemname = ReturningDataGridView.Rows(i).Cells(1).Value.ToString()
                    hitemtype = ReturningDataGridView.Rows(i).Cells(2).Value.ToString()
                    hqty = ReturningDataGridView.Rows(i).Cells(3).Value.ToString()
                    hunit = ReturningDataGridView.Rows(i).Cells(4).Value.ToString()
                    hdateborrowed = dtpDateNeeded.Value
                    AddToHistory()
                    i = i + 1
                Loop

                UpdateStudentRequestCount()
                DeleteInRequestTable()
                DeleteInRequestInformationTable()
                StudentWithPendingReturnLDataGridView.DataSource = GetStudentWithReturningData()
                StudentWithPendingReturnLDataGridView.AutoResizeColumns()
                StudentWithPendingReturnLDataGridView.ClearSelection()
                panel1.Visible = True
                panel2.Visible = False
                btnNext.Enabled = False
                blacklistreason = userEnteredValue
                BlacklistStudent()
                MessageBox.Show(studentname + " is now blacklisted and lost its access to the CSLS Laboratory System until compensated for the lost or damaged inventory.", "STATEMENT", MessageBoxButtons.OK, MessageBoxIcon.Information)   
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        StudentWithPendingReturnLDataGridView.DataSource = SearchForSomething()
        StudentWithPendingReturnLDataGridView.AutoResizeColumns()
        StudentWithPendingReturnLDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        StudentWithPendingReturnLDataGridView.DataSource = SearchForSomething()
        StudentWithPendingReturnLDataGridView.AutoResizeColumns()
        StudentWithPendingReturnLDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StaffForm.staffName = staffName
        StaffForm.lblStaffName.Text = staffName
        Me.Close()
        StaffForm.Show()
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        StudentWithPendingReturnLDataGridView.DataSource = GetStudentWithReturningData()
        StudentWithPendingReturnLDataGridView.AutoResizeColumns()
        StudentWithPendingReturnLDataGridView.ClearSelection()
        panel1.Visible = True
        panel2.Visible = False
        btnNext.Enabled = False
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackgroundImage = My.Resources.hoverbackbutton
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackgroundImage = My.Resources.backbutton
    End Sub

    Private Sub btnNext_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        btnNext.BackgroundImage = My.Resources.btnNextFormHover
    End Sub

    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.BackgroundImage = My.Resources.btnNextForm
    End Sub

    Private Sub btnCleared_MouseEnter(sender As Object, e As EventArgs) Handles btnCleared.MouseEnter
        btnCleared.BackgroundImage = My.Resources.btnClearedHover
    End Sub

    Private Sub btnCleared_MouseLeave(sender As Object, e As EventArgs) Handles btnCleared.MouseLeave
        btnCleared.BackgroundImage = My.Resources.btnCleared
    End Sub

    Private Sub btnBack2_MouseEnter(sender As Object, e As EventArgs) Handles btnBack2.MouseEnter
        btnBack2.BackgroundImage = My.Resources.btnbackhover
    End Sub

    Private Sub btnBack2_MouseLeave(sender As Object, e As EventArgs) Handles btnBack2.MouseLeave
        btnBack2.BackgroundImage = My.Resources.btnback
    End Sub

    

End Class