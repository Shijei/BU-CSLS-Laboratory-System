Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class ManageStudents

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim studentId, firstName, middleName, lastName, studentCourse, fullName, studentQRcode, searchquery As String
    Dim yearLevel As Integer
    Dim condition1, condition2, condition3 As String
    Dim Rand As New Random()
    Dim AlphaNumeric As String = "0123456789"
    Dim AlphaNumeric2 As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Public Function rAlphanumeric() As String
        Return AlphaNumeric(Rand.Next(0, AlphaNumeric.Length - 1))
    End Function

    Public Function rAlphanumeric2() As String
        Return AlphaNumeric2(Rand.Next(0, AlphaNumeric2.Length - 1))
    End Function


    Private Function SearchSomething() As DataTable
        Dim searchdata As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_YearLevel] As [Year Level], [_Course] As [Course], [_StudentQRCode] As [Student QR Code] FROM tblStudent WHERE [_StudentID] LIKE '%" & searchquery & "%' OR [_FullName] LIKE '%" & searchquery & "%' ORDER BY [_YearLevel], [_FullName], [_Course]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                searchdata.Load(reader)
            End Using
        End Using
        Return searchdata
    End Function

    Private Function LookForYear() As DataTable
        Dim sortData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_YearLevel] As [Year Level], [_Course] As [Course], [_StudentQRCode] As [Student QR Code] FROM tblStudent WHERE [" & condition1 & "] = " & condition2 & " ORDER BY [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                sortData.Load(reader)
            End Using
        End Using
        Return sortData
    End Function

    Private Function LookForCourse() As DataTable
        Dim sortData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_YearLevel] As [Year Level], [_Course] As [Course], [_StudentQRCode] As [Student QR Code] FROM tblStudent WHERE [" & condition1 & "] = '" & condition3 & "' ORDER BY [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                sortData.Load(reader)
            End Using
        End Using
        Return sortData
    End Function

    Private Function GetCondition2() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [" & condition1 & "] FROM tblStudent", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbCondition2.Items.Add(datalists.Rows(i).Item(condition1).ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetStudentsData() As DataTable
        Dim studentData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_YearLevel] As [Year Level], [_Course] As [Course], [_StudentQRCode] As [Student QR Code] FROM tblStudent ORDER BY [_YearLevel], [_FullName], [_Course]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                studentData.Load(reader)
            End Using
        End Using
        Return studentData
    End Function

    Private Function GetCourses() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_Course] FROM tblStudent ORDER BY  [_Course] ASC", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbCourse.Items.Add(datalists.Rows(i).Item("_Course").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function AddStudent() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblStudent([_StudentID],[_FullName],[_FirstName],[_MiddleName],[_LastName],[_YearLevel],[_Course],[_StudentQRCode],[_RequestCount],[_IsBlackListed],[_BlacklistReason]) VALUES (?,?,?,?,?,?,?,?,?,?,?)", conn)
            studentId = txtStudentid.Text
            firstName = txtFirstname.Text
            middleName = txtMiddlename.Text
            lastName = txtLastname.Text
            fullName = lastName + ", " + firstName + " " + middleName
            yearLevel = Val(cmbYearLevel.Text)
            studentCourse = cmbCourse.Text
            studentQRcode = txtStudentQR.Text


            cmd.Parameters.Add(New OleDbParameter("_StudentID", CType(studentId, String)))
            cmd.Parameters.Add(New OleDbParameter("_FullName", CType(fullName, String)))
            cmd.Parameters.Add(New OleDbParameter("_FirstName", CType(firstName, String)))
            cmd.Parameters.Add(New OleDbParameter("_MiddleName", CType(middleName, String)))
            cmd.Parameters.Add(New OleDbParameter("_LastName", CType(lastName, String)))
            cmd.Parameters.Add(New OleDbParameter("_YearLevel", CType(yearLevel, String)))
            cmd.Parameters.Add(New OleDbParameter("_Course", CType(studentCourse, String)))
            cmd.Parameters.Add(New OleDbParameter("_StudentQRCode", CType(studentQRcode, String)))
            cmd.Parameters.Add(New OleDbParameter("_RequestCount", CType(0, String)))
            cmd.Parameters.Add(New OleDbParameter("_IsBlackListed", CType("False", String)))
            cmd.Parameters.Add(New OleDbParameter("_BlacklistReason", CType("", String)))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("DATA ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAfterAdd()
            Catch ex As OleDbException When ex.ErrorCode = -2147467259
                MessageBox.Show("THE STUDENT ID IS ALREADY USED", "ID ALREADY EXISTS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateStudent() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            studentId = txtStudentid.Text
            firstName = txtFirstname.Text
            middleName = txtMiddlename.Text
            lastName = txtLastname.Text
            fullName = lastName + ", " + firstName + " " + middleName
            yearLevel = Val(cmbYearLevel.Text)
            studentCourse = cmbCourse.Text
            studentQRcode = txtStudentQR.Text
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_FullName] = '" & fullName & "', [_FirstName] = '" & firstName & "', [_MiddleName] = '" & middleName & "', [_LastName] = '" & lastName & "', [_YearLevel] = '" & yearLevel & "', [_Course] = '" & studentCourse & "', [_StudentQRCode] = '" & studentQRcode & "' WHERE [_StudentID] = '" & studentId & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("DATA UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function DeleteStudent() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            studentId = txtStudentid.Text
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblStudent WHERE [_StudentID] = '" & studentId & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("DATA DELETED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Sub ClearFields()
        Dim sAnum As String = "STU-" + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + "-" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        txtStudentQR.Text = sAnum

        txtSearch.Text = "SEARCH"
        txtStudentid.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        StudentDataGridView.DataSource = GetStudentsData()
        StudentDataGridView.AutoResizeColumns()
        StudentDataGridView.ClearSelection()
        cmbYearLevel.SelectedIndex = 0
        cmbCourse.Items.Clear()
        GetCourses()
        cmbCourse.Text = ""
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtStudentid.Enabled = True
    End Sub

    Sub ClearAfterAdd()
        Dim sAnum As String = "STU-" + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric() + "-" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        txtStudentQR.Text = sAnum

        txtSearch.Text = "SEARCH"
        txtStudentid.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        StudentDataGridView.DataSource = GetStudentsData()
        StudentDataGridView.AutoResizeColumns()
        StudentDataGridView.ClearSelection()
        cmbCourse.Items.Clear()
        GetCourses()
    End Sub

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnAdd_MouseEnter(sender As Object, e As EventArgs) Handles btnAdd.MouseEnter
        btnAdd.BackgroundImage = My.Resources.addhover
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.BackgroundImage = My.Resources.addbtn
    End Sub

    Private Sub btnUpdate_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate.MouseEnter
        btnUpdate.BackgroundImage = My.Resources.updatehover
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.BackgroundImage = My.Resources.updatebtn
    End Sub

    Private Sub btnDelete_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        btnDelete.BackgroundImage = My.Resources.deletehover
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackgroundImage = My.Resources.deletebtn
    End Sub

    Private Sub btnClear_MouseEnter(sender As Object, e As EventArgs) Handles btnClear.MouseEnter
        btnClear.BackgroundImage = My.Resources.clearhover
    End Sub

    Private Sub btnClear_MouseLeave(sender As Object, e As EventArgs) Handles btnClear.MouseLeave
        btnClear.BackgroundImage = My.Resources.clearbtn
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackgroundImage = My.Resources.hoverbackbutton
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackgroundImage = My.Resources.backbutton
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.BackgroundImage = My.Resources.searchbarhover_png
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackgroundImage = My.Resources.searchbutton
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        StudentDataGridView.DataSource = SearchSomething()
        StudentDataGridView.AutoResizeColumns()
        StudentDataGridView.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        StudentDataGridView.DataSource = SearchSomething()
        StudentDataGridView.AutoResizeColumns()
        StudentDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub


    Private Sub ManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sAnum As String = "STU-" + "0000000" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        StudentDataGridView.DataSource = GetStudentsData()
        StudentDataGridView.AutoResizeColumns()
        StudentDataGridView.ClearSelection()
        GetCourses()
        cmbYearLevel.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtStudentid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(cmbYearLevel.Text) Or String.IsNullOrWhiteSpace(cmbCourse.Text) Then
            MessageBox.Show("CHECK DATA ENTRIES, YOU MIGHT MISSED SOME FIELD", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckForAlphaCharacters(cmbYearLevel.Text) Then
            MessageBox.Show("INVALID DATA INPUT IN SOME FIELD, EDIT AND TRY AGAIN", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddStudent()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtStudentid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(cmbYearLevel.Text) Or String.IsNullOrWhiteSpace(cmbCourse.Text) Then
            MessageBox.Show("SELECT A ROW FIRST, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckForAlphaCharacters(cmbYearLevel.Text) Then
            MessageBox.Show("INVALID DATA INPUT IN SOME FIELD, EDIT AND TRY AGAIN", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO UPDATE THIS STUDENT?", "UPDATE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                UpdateStudent()
            Else

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtStudentid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(cmbYearLevel.Text) Or String.IsNullOrWhiteSpace(cmbCourse.Text) Then
            MessageBox.Show("SELECT A ROW FIRST, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO DELETE THIS STUDENT INFO?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteStudent()
            Else

            End If
        End If
    End Sub

    Private Sub StudentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            txtStudentid.Enabled = False
            selectedRow = StudentDataGridView.Rows(index)
            txtStudentid.Text = selectedRow.Cells(0).Value.ToString()
            txtFirstname.Text = selectedRow.Cells(2).Value.ToString()
            txtMiddlename.Text = selectedRow.Cells(3).Value.ToString()
            txtLastname.Text = selectedRow.Cells(4).Value.ToString()
            cmbYearLevel.Text = selectedRow.Cells(5).Value.ToString()
            cmbCourse.Text = selectedRow.Cells(6).Value.ToString()
            txtStudentQR.Text = selectedRow.Cells(7).Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdministratorForm.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim sAnum As String = "STU-" + txtStudentid.Text + "-" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        txtStudentQR.Text = sAnum
    End Sub


    Private Sub cmbCondition1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondition1.SelectedIndexChanged
        If cmbCondition1.SelectedIndex = 0 Then
            condition1 = "_YearLevel"
        ElseIf cmbCondition1.SelectedIndex = 1 Then
            condition1 = "_Course"
        End If
        cmbCondition2.Items.Clear()
        GetCondition2()
    End Sub

    Private Sub btnLookFor_Click(sender As Object, e As EventArgs) Handles btnLookFor.Click
        If String.IsNullOrWhiteSpace(cmbCondition1.Text) Or String.IsNullOrWhiteSpace(cmbCondition2.Text) Then
            MessageBox.Show("PLEASE SELECT CATEGORY TO FIND, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            condition2 = cmbCondition2.Text
            condition3 = cmbCondition2.Text
            If condition1 = "_YearLevel" Then
                StudentDataGridView.DataSource = LookForYear()
                StudentDataGridView.AutoResizeColumns()
                StudentDataGridView.ClearSelection()
            ElseIf condition1 = "_Course" Then
                StudentDataGridView.DataSource = LookForCourse()
                StudentDataGridView.AutoResizeColumns()
                StudentDataGridView.ClearSelection()
            End If
            cmbCondition1.SelectedIndex = 0
            cmbCondition1.Text = ""
            cmbCondition2.Text = ""
        End If
    End Sub

    Private Sub btnPrint_MouseEnter(sender As Object, e As EventArgs) Handles btnPrint.MouseEnter
        btnPrint.BackgroundImage = My.Resources.btnPrintHover
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackgroundImage = My.Resources.btnPrint
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim the_html_file As String = String.Empty

        Dim stylesheet As String = "  table.gridtable {margin:0 auto;width:95%;overflow:auto;font-family: helvetica,arial,sans-serif;"
        stylesheet &= "font-size:14px;color:#333333;border-width: 1px;border-color: #666666;border-collapse: collapse;text-align: center}"
        stylesheet &= "table.gridtable th {border-width: 1px;padding: 8px; border-style: solid;border-color: #666666;background-color: #94c37e;}"
        stylesheet &= "table.gridtable td {border-width: 1px;padding: 8px;border-style: solid;border-color: #666666;}"

        the_html_file = "<!DOCTYPE html><html><head><meta charset='UTF-8'><title>REPORTS</title><style>" & stylesheet & "</style></head><body>"

        the_html_file &= "<h1 style='font-family:Century Gothic; padding-left: 40px'>REGISTERED STUDENTS </h1>"
        the_html_file &= "<table class='gridtable'>"
        the_html_file &= "<thead><tr>"

        'get the column headers
        For Each column As DataGridViewColumn In StudentDataGridView.Columns
            the_html_file = the_html_file & "<th>" & column.HeaderText & "</th>"
        Next

        the_html_file = the_html_file & "</tr></thead><tbody>"

        'get the rows
        For Each row As DataGridViewRow In StudentDataGridView.Rows
            the_html_file &= "<tr>"
            'get the cells
            For Each cell As DataGridViewCell In row.Cells

                Dim cellcontent As String = cell.FormattedValue
                'replace < and > with html entities
                cellcontent = Replace(cellcontent, "<", "&lt;")
                cellcontent = Replace(cellcontent, ">", "&gt;")

                'using inline styles for column 1
                'If cell.ColumnIndex = 1 Then
                '    the_html_file = the_html_file & "<td style=color:white;background-color:red;font-weight:bold>" & cellcontent & "</td>"
                'Else
                '    the_html_file = the_html_file & "<td>" & cellcontent & "</td>"
                'End If

                'no inline styles
                the_html_file = the_html_file & "<td>" & cellcontent & "</td>"

            Next
            the_html_file &= "</tr>"
        Next

        the_html_file &= "</tbody></table>"

        the_html_file &= "</body></html>"

        ''CHANGE PATH BEFORE DEFENSE ↓↓↓↓↓↓↓↓
        'write the file
        ' My.Computer.FileSystem.WriteAllText("C:\Users\Shijei\Documents\Visual Studio 2013\Projects\LaboratorySystem\suppliesInventory.html", the_html_file, False)
        Dim fileNamePath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "studentList.html")
        My.Computer.FileSystem.WriteAllText(fileNamePath, the_html_file, False)
        'pass file to default browser
        Dim pinfo As New ProcessStartInfo()
        pinfo.WindowStyle = ProcessWindowStyle.Normal
        'pinfo.FileName = "C:\Users\Shijei\Documents\Visual Studio 2013\Projects\LaboratorySystem\suppliesInventory.html"
        pinfo.FileName = fileNamePath
        Dim p As Process = Process.Start(pinfo)
    End Sub

End Class