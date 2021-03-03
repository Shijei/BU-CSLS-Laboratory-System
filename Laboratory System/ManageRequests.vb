Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class ManageRequests

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Public staffName As String
    Dim uid As String
    Dim studentid, studentname, yearLevel, studentCourse, searchquery As String
    Dim subtrahendQuery, qty, newqty As Integer
    Dim outOfStockCounter As Integer
    Dim isAnInvalidProcess As Boolean
    Dim stockQty, requestedQty As Integer


    Private Function SearchForSomething() As DataTable
        Dim studentData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_YearLevel] As [Year Level], [_Course] As [Course], [_DateNeeded] As [Date of Laboratory Activity] FROM tblRequestInfo WHERE ([_StudentID] LIKE '%" & searchquery & "%' OR [_FullName] LIKE '%" & searchquery & "%') AND [_IsValidated] = 'False' ORDER BY [_DateNeeded] ASC, [_YearLevel], [_FullName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                studentData.Load(reader)
            End Using
        End Using
        Return studentData
    End Function

    Private Function GetStudentWithRequestData() As DataTable
        Dim studentData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_YearLevel] As [Year Level], [_Course] As [Course], [_DateNeeded] As [Date of Laboratory Activity] FROM tblRequestInfo WHERE [_IsValidated] = 'False' ORDER BY [_DateNeeded] ASC, [_YearLevel], [_FullName]", conn)
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

    Private Function GetStockNumbers() As DataTable
        Dim userinfo As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID],[_Quantity] FROM tblSupplies WHERE [_UID] = '" & uid & "'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                rowCount = userinfo.Rows.Count
                Do While (i < rowCount)
                    If userinfo.Rows(i).Item("_UID").ToString() = uid Then
                        stockQty = userinfo.Rows(i).Item("_Quantity")
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

    Private Function ConfirmRequest() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblRequestInfo SET [_IsValidated] = 'True' WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    'Private Function UpdateOnRemovalOfItemRequestedTotalQuantity() As DataTable
    '    Dim datalists As New DataTable
    '    Using conn As New OleDbConnection(connString)
    '        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_RequestedTotalQuantity] = [_RequestedTotalQuantity] - " & qty & " WHERE [_UID] = '" & uid & "'", conn)
    '        Try
    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '        Catch ex As OleDbException
    '            MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    End Using
    '    Return datalists
    'End Function

    'Private Function UpdateOnEditOfItemRequestedTotalQuantity() As DataTable
    '    Dim datalists As New DataTable
    '    Using conn As New OleDbConnection(connString)
    '        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_RequestedTotalQuantity] = [_RequestedTotalQuantity] - " & subtrahendQuery & " WHERE [_UID] = '" & uid & "'", conn)
    '        Try
    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '        Catch ex As OleDbException
    '            MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    End Using
    '    Return datalists
    'End Function

    Private Function UpdateOnEditOfRequestedItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblRequest SET [_Qty] = " & newqty & " WHERE [_UID] = '" & uid & "' AND [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateValidationOnTableRequest() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblRequest SET [_IsValidated] = 'True' WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateValidationOnTableRequestInformation() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblRequestInfo SET [_IsValidated] = 'True' WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateQuantitiesOnTableSupplies() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_Quantity] = [_Quantity] - " & qty & " WHERE [_UID] = '" & uid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function DeleteRequestedItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequest WHERE [_StudentID] = '" & studentid & "' AND [_UID] = '" & uid & "'", conn)
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
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_RequestCount] = 0 WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function DeleteAllRequestedItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequest WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function DeleteRequestedInformation() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequestInfo WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub CheckStocks()
        outOfStockCounter = 0
        Dim i As Integer
        Dim rowCount As Integer
        rowCount = StudentRequestedListDataGridView.RowCount
        Do While (i < rowCount)
            uid = StudentRequestedListDataGridView.Rows(i).Cells(2).Value.ToString()
            requestedQty = StudentRequestedListDataGridView.Rows(i).Cells(5).Value.ToString()
            GetStockNumbers()
            If StudentRequestedListDataGridView.Rows(i).Cells(5).Value.ToString() > stockQty Then
                outOfStockCounter = outOfStockCounter + 1
            Else

            End If
            i = i + 1
        Loop

        If outOfStockCounter > 0 Then
            isAnInvalidProcess = True
        Else
            isAnInvalidProcess = False
        End If
    End Sub

    Private Sub ManageRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentWithRequestDataGridView.DataSource = GetStudentWithRequestData()
        StudentWithRequestDataGridView.AutoResizeColumns()
        StudentWithRequestDataGridView.ClearSelection()
        'Add an edit and delete column
        Dim btneditqty, btnremove As New DataGridViewButtonColumn()
        StudentRequestedListDataGridView.Columns.Add(btneditqty)
        StudentRequestedListDataGridView.Columns.Add(btnremove)
        btneditqty.HeaderText = ""
        btneditqty.Text = "DECREASE QTY"
        btneditqty.Name = "btneditqty"
        btneditqty.UseColumnTextForButtonValue = True
        btnremove.HeaderText = ""
        btnremove.Text = "REMOVE"
        btnremove.Name = "btnremove"
        btnremove.UseColumnTextForButtonValue = True
        'End
    End Sub

    Private Sub StudentWithRequestDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentWithRequestDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex 'dont forget
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            selectedRow = StudentWithRequestDataGridView.Rows(index) 'dont forget
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
            StudentRequestedListDataGridView.DataSource = GetStudentRequestedItems()
            StudentRequestedListDataGridView.AutoResizeColumns()
            StudentRequestedListDataGridView.ClearSelection()
            CheckStocks()  'Check if there are stocks of the requested items
        End If
    End Sub

    Private Sub StudentRequestedListDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentRequestedListDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = StudentRequestedListDataGridView.Rows(index)

        If e.ColumnIndex = 0 Then   'Edit Qty Button
            Dim userEnteredValue As String
            userEnteredValue = Microsoft.VisualBasic.InputBox("Enter new quantity:", "Baliuag University CSLS Laboratory System", "0", 600, 344)
            If String.IsNullOrWhiteSpace(userEnteredValue) Then
                MessageBox.Show("Transaction is cancelled", "EXIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf userEnteredValue = "0" Then
                MessageBox.Show("Input cannot be zero, remove this item instead", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf CheckForAlphaCharacters(userEnteredValue) Then
                MessageBox.Show("Letter is an invalid input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                studentid = lblStudentID.Text
                uid = selectedRow.Cells(2).Value.ToString
                qty = selectedRow.Cells(5).Value
                newqty = Val(userEnteredValue)
                If newqty < 0 Then
                    MessageBox.Show("Invalid input.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf newqty > qty Then
                    MessageBox.Show("Input should be lower than the requested. If really needed, ask the student to retry requesting again.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf newqty = qty Then
                    MessageBox.Show("You entered the same requested quantity", "NEUTRAL CHANGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    subtrahendQuery = qty - newqty
                    'UpdateOnEditOfItemRequestedTotalQuantity()
                    UpdateOnEditOfRequestedItem()
                    StudentRequestedListDataGridView.DataSource = GetStudentRequestedItems()
                    StudentRequestedListDataGridView.AutoResizeColumns()
                    StudentRequestedListDataGridView.ClearSelection()
                End If
            End If
        ElseIf e.ColumnIndex = 1 Then 'Delete Button
        Dim result As DialogResult = MessageBox.Show("REMOVE THIS REQUESTED ITEM?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                studentid = lblStudentID.Text
                uid = selectedRow.Cells(2).Value.ToString
                qty = selectedRow.Cells(5).Value
                'UpdateOnRemovalOfItemRequestedTotalQuantity()
                DeleteRequestedItem()
                StudentRequestedListDataGridView.DataSource = GetStudentRequestedItems()
                StudentRequestedListDataGridView.AutoResizeColumns()
                StudentRequestedListDataGridView.ClearSelection()
            Else

            End If
        End If

    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        StudentWithRequestDataGridView.DataSource = GetStudentWithRequestData()
        StudentWithRequestDataGridView.AutoResizeColumns()
        StudentWithRequestDataGridView.ClearSelection()
        panel1.Visible = True
        panel2.Visible = False
        btnNext.Enabled = False
    End Sub

    Private Sub btnConfirmRequest_Click(sender As Object, e As EventArgs) Handles btnConfirmRequest.Click
        Dim rowCount, i As Integer
        rowCount = StudentRequestedListDataGridView.RowCount
        CheckStocks()
        If isAnInvalidProcess = True Then
            MessageBox.Show("Cannot continue, kindly check the stocks before proceeding!", "ABORT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rowCount = 0 Then
            MessageBox.Show("The system detected 0 count of rows in student request list!", "ABORT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim result As DialogResult = MessageBox.Show("CONFIRM THIS REQUEST?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                studentid = lblStudentID.Text
                UpdateValidationOnTableRequest()
                UpdateValidationOnTableRequestInformation()

                Do While (i < rowCount)
                    uid = StudentRequestedListDataGridView.Rows(i).Cells(2).Value.ToString()
                    qty = StudentRequestedListDataGridView.Rows(i).Cells(5).Value.ToString()
                    UpdateQuantitiesOnTableSupplies()
                    i = i + 1
                Loop

                MessageBox.Show("REQUESTED ITEMS ARE GRANTED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                StudentWithRequestDataGridView.DataSource = GetStudentWithRequestData()
                StudentWithRequestDataGridView.AutoResizeColumns()
                StudentWithRequestDataGridView.ClearSelection()
                panel1.Visible = True
                panel2.Visible = False
                btnNext.Enabled = False
            Else

            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        StudentWithRequestDataGridView.DataSource = SearchForSomething()
        StudentWithRequestDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        StudentWithRequestDataGridView.DataSource = SearchForSomething()
        StudentWithRequestDataGridView.ClearSelection()
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

    Private Sub btnPeekInventory_Click(sender As Object, e As EventArgs) Handles btnPeekInventory.Click
        PeekInventory.Show()
    End Sub

    Private Sub btnVoidRequest_Click(sender As Object, e As EventArgs) Handles btnVoidRequest.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO VOID THIS REQUEST?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            UpdateStudentRequestCount()
            DeleteAllRequestedItem()
            DeleteRequestedInformation()
            StudentForm.studentRequestCountSF = 0
            StudentWithRequestDataGridView.DataSource = GetStudentWithRequestData()
            StudentWithRequestDataGridView.AutoResizeColumns()
            StudentWithRequestDataGridView.ClearSelection()
            panel1.Visible = True
            panel2.Visible = False
            btnNext.Enabled = False
        Else

        End If
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


    Private Sub btnVoidRequest_MouseEnter(sender As Object, e As EventArgs) Handles btnVoidRequest.MouseEnter
        btnVoidRequest.BackgroundImage = My.Resources.btnVoidRequestHover
    End Sub

    Private Sub btnVoidRequest_MouseLeave(sender As Object, e As EventArgs) Handles btnVoidRequest.MouseLeave
        btnVoidRequest.BackgroundImage = My.Resources.btnVoidRequest
    End Sub

    Private Sub btnConfirmRequest_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirmRequest.MouseEnter
        btnConfirmRequest.BackgroundImage = My.Resources.btnConfirmRequestHover
    End Sub

    Private Sub btnConfirmRequest_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirmRequest.MouseLeave
        btnConfirmRequest.BackgroundImage = My.Resources.btnConfirmRequest
    End Sub

    Private Sub btnBack2_MouseEnter(sender As Object, e As EventArgs) Handles btnBack2.MouseEnter
        btnBack2.BackgroundImage = My.Resources.btnbackhover
    End Sub

    Private Sub btnBack2_MouseLeave(sender As Object, e As EventArgs) Handles btnBack2.MouseLeave
        btnBack2.BackgroundImage = My.Resources.btnback
    End Sub
End Class