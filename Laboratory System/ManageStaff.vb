Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class ManageStaff

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim staffID, firstName, middleName, lastName, staffPass, fullName, searchquery As String

    Private Function SearchSomething() As DataTable
        Dim searchdata As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StaffID] As [Staff ID], [_FullName] As [Staff Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_StaffPassword] As [Staff Password] FROM tblStaff WHERE [_StaffID] LIKE '%" & searchquery & "%' OR [_FullName] LIKE '%" & searchquery & "%' ORDER BY [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                searchdata.Load(reader)
            End Using
        End Using
        Return searchdata
    End Function

    Private Function GetStaffData() As DataTable
        Dim staffData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StaffID] As [Staff ID], [_FullName] As [Staff Name], [_FirstName] As [Firstname], [_MiddleName] As [Middlename], [_LastName] As [Lastname], [_StaffPassword] As [Staff Password] FROM tblStaff ORDER BY [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                staffData.Load(reader)
            End Using
        End Using
        Return staffData
    End Function

    Private Function AddStaff() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblStaff([_StaffID],[_FullName],[_FirstName],[_MiddleName],[_LastName],[_StaffPassword]) VALUES (?,?,?,?,?,?)", conn)
            staffID = txtStaffid.Text
            firstName = txtFirstname.Text
            middleName = txtMiddlename.Text
            lastName = txtLastname.Text
            fullName = lastName + ", " + firstName + " " + middleName
            staffPass = txtPassword.Text

            cmd.Parameters.Add(New OleDbParameter("_StaffID", CType(staffID, String)))
            cmd.Parameters.Add(New OleDbParameter("_FullName", CType(fullName, String)))
            cmd.Parameters.Add(New OleDbParameter("_FirstName", CType(firstName, String)))
            cmd.Parameters.Add(New OleDbParameter("_MiddleName", CType(middleName, String)))
            cmd.Parameters.Add(New OleDbParameter("_LastName", CType(lastName, String)))
            cmd.Parameters.Add(New OleDbParameter("_StaffPassword", CType(staffPass, String)))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("DATA ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Catch ex As OleDbException When ex.ErrorCode = -2147467259
                MessageBox.Show("THE STAFF ID IS ALREADY USED", "ID ALREADY EXISTS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateStaff() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            staffID = txtStaffid.Text
            firstName = txtFirstname.Text
            middleName = txtMiddlename.Text
            lastName = txtLastname.Text
            fullName = lastName + ", " + firstName + " " + middleName
            staffPass = txtPassword.Text
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStaff SET [_FullName] = '" & fullName & "', [_FirstName] = '" & firstName & "', [_MiddleName] = '" & middleName & "', [_LastName] = '" & lastName & "', [_StaffPassword] = '" & staffPass & "' WHERE [_StaffID] = '" & staffID & "'", conn)
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

    Private Function DeleteStaff() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            staffID = txtStaffid.Text
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblStaff WHERE [_StaffID] = '" & staffID & "'", conn)
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
        txtSearch.Text = "SEARCH"
        txtStaffid.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        txtPassword.Text = ""
        StafftDataGridView.DataSource = GetStaffData()
        StafftDataGridView.ClearSelection()
        StafftDataGridView.Columns(5).Visible = False
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtStaffid.Enabled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        StafftDataGridView.DataSource = SearchSomething()
        StafftDataGridView.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        StafftDataGridView.DataSource = SearchSomething()
        StafftDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

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


    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            btnShowHide.Text = "HIDE"
        Else
            txtPassword.UseSystemPasswordChar = True
            btnShowHide.Text = "SHOW"
        End If
    End Sub


    Private Sub ManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StafftDataGridView.DataSource = GetStaffData()
        StafftDataGridView.AutoResizeColumns()
        StafftDataGridView.ClearSelection()
        StafftDataGridView.Columns(5).Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtStaffid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("CHECK DATA ENTRIES, YOU MIGHT MISSED SOME FIELD", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddStaff()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtStaffid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("CHECK DATA ENTRIES, YOU MIGHT MISSED SOME FIELD", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO UPDATE THIS STUDENT?", "UPDATE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                UpdateStaff()
            Else

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtStaffid.Text) Or String.IsNullOrWhiteSpace(txtFirstname.Text) Or String.IsNullOrWhiteSpace(txtMiddlename.Text) Or String.IsNullOrWhiteSpace(txtLastname.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("CHECK DATA ENTRIES, YOU MIGHT MISSED SOME FIELD", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO DELETE THIS STUDENT INFO?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteStaff()
            Else

            End If
        End If
    End Sub

    Private Sub StafftDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StafftDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            txtStaffid.Enabled = False
            selectedRow = StafftDataGridView.Rows(index)
            txtStaffid.Text = selectedRow.Cells(0).Value.ToString()
            txtFirstname.Text = selectedRow.Cells(2).Value.ToString()
            txtMiddlename.Text = selectedRow.Cells(3).Value.ToString()
            txtLastname.Text = selectedRow.Cells(4).Value.ToString()
            txtPassword.Text = selectedRow.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdministratorForm.Show()
    End Sub
End Class