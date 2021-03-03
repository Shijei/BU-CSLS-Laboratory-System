Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class RequestForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Public studentID, studentName, yearLevel, studentCourse, searchquery As String
    Public studentRequestCount As Integer
    Dim uid, itemName, itemType, itemUnit, itemQty As String
    Dim requestedQty As Integer
    Dim isInTheList As Boolean
    Dim isValidated As Boolean
    Dim buLightGreen, buDarkGreen As Color

    'Date Variables
    Dim currentDate As Date = Date.Today
    Dim dateNeed As Date

    'End of Date Variables

    'Ons screen keyboard necessary variable
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "C:\Windows\System32\osk.exe"
    'end of osk variables

    Private Function SearchSomething() As DataTable
        Dim searchdata As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit] FROM tblSupplies WHERE ([_UID] LIKE '%" & searchquery & "%' OR [_ItemName] LIKE '%" & searchquery & "%') AND [_Condition] = 'Functioning' AND [_Availability] = 'Available' AND NOT [_Quantity] = 0 ORDER BY [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                searchdata.Load(reader)
            End Using
        End Using
        Return searchdata
    End Function


    Private Function GetItemData() As DataTable
        Dim itemData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit] FROM tblSupplies WHERE [_Condition] = 'Functioning' AND [_Availability] = 'Available' AND NOT [_Quantity] = 0 ORDER BY [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                itemData.Load(reader)
            End Using
        End Using
        Return itemData
    End Function

    Private Function UpdateStudentRequestCount() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_RequestCount] = 1 WHERE [_StudentID] = '" & studentID & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    'Private Function UpdateItemRequestedCount() As DataTable
    '    Dim datalists As New DataTable
    '    Using conn As New OleDbConnection(connString)
    '        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_RequestedTotalQuantity] = [_RequestedTotalQuantity] + '" & requestedQty & "' WHERE [_UID] = '" & uid & "'", conn)
    '        Try
    '            conn.Open()
    '            cmd.ExecuteNonQuery()
    '        Catch ex As OleDbException
    '            MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Using
    '    Return datalists
    'End Function

    Private Function CheckValidation() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_RequestCount] = 1 WHERE [_StudentID] = '" & studentID & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function AddRequest() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblRequest([_StudentID],[_FullName],[_UID],[_ItemName],[_ItemType],[_Qty],[_Unit],[_IsValidated]) VALUES (?,?,?,?,?,?,?,?)", conn)
            

            cmd.Parameters.Add(New OleDbParameter("_StudentID", CType(studentID, String)))
            cmd.Parameters.Add(New OleDbParameter("_FullName", CType(studentName, String)))
            cmd.Parameters.Add(New OleDbParameter("_UID", CType(uid, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemName", CType(itemName, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemType", CType(itemType, String)))
            cmd.Parameters.Add(New OleDbParameter("_Qty", CType(requestedQty, String)))
            cmd.Parameters.Add(New OleDbParameter("_Unit", CType(itemUnit, String)))
            cmd.Parameters.Add(New OleDbParameter("_IsValidated", CType(isValidated, String)))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As OleDbException When ex.ErrorCode = -2147467259
                MessageBox.Show(ex.Message)
                MessageBox.Show("IDENTICAL ID DETECTED, THIS IS A PROGRAMMATICAL ERROR, KINDLY CONTACT 09060937764", "UNEXPECTED ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function AddRequestInfo() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblRequestInfo([_StudentID],[_FullName],[_YearLevel],[_Course],[_GroupNo],[_LabSubject],[_ActivityNo],[_Purpose],[_DateNeeded],[_IsValidated]) VALUES (?,?,?,?,?,?,?,?,?,?)", conn)


            cmd.Parameters.Add(New OleDbParameter("_StudentID", CType(studentID, String)))
            cmd.Parameters.Add(New OleDbParameter("_FullName", CType(studentName, String)))
            cmd.Parameters.Add(New OleDbParameter("_YearLevel", CType(yearLevel, String)))
            cmd.Parameters.Add(New OleDbParameter("_Course", CType(studentCourse, String)))
            cmd.Parameters.Add(New OleDbParameter("_GroupNo", CType(txtGroupno.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("_LabSubject", CType(txtLabSubj.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("_ActivityNo", CType(txtActno.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("_Purpose", CType(txtPurpose.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("_DateNeeded", CType(dateNeed, String)))
            cmd.Parameters.Add(New OleDbParameter("_IsValidated", CType(isValidated, String)))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException When ex.ErrorCode = -2147467259
                MessageBox.Show(ex.Message)
                MessageBox.Show("IDENTICAL ID DETECTED, THIS IS A PROGRAMMATICAL ERROR, KINDLY CONTACT 09060937764", "UNEXPECTED ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        panel1.Visible = False
        panel2.Visible = True
        txtSearch.Text = "SEARCH"
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        panel1.Visible = True
        panel2.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If lblUserType.Text = "Student" Then
            Me.Close()
            StudentForm.Show()
        ElseIf lblUserType.Text = "Staff" Then
            Me.Close()
            StaffForm.Show()
        End If
    End Sub

    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnOSK_Click(sender As Object, e As EventArgs) Handles btnOSK.Click
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start(osk)
        End If
    End Sub

    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buLightGreen = Color.FromArgb(148, 195, 126)
        buDarkGreen = Color.FromArgb(7, 83, 23)
        dtpDateNeeded.Value = DateTime.Today
        ItemsDataGridView.DataSource = GetItemData()
        ItemsDataGridView.AutoResizeColumns()
        ItemsDataGridView.ClearSelection()
        RequestDataGridview.ColumnCount = 6
        RequestDataGridview.Columns(0).Name = "UID"
        RequestDataGridview.Columns(1).Name = "Item Name"
        RequestDataGridview.Columns(2).Name = "Item Type"
        RequestDataGridview.Columns(3).Name = "Quantity"
        RequestDataGridview.Columns(4).Name = "Unit"
        RequestDataGridview.Columns(5).Name = ""
        RequestDataGridview.Columns(5).CellTemplate.Style.SelectionBackColor = buLightGreen
        RequestDataGridview.Columns(5).CellTemplate.Style.SelectionForeColor = Color.White
        RequestDataGridview.Columns(5).CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'SET VALUE FOR StudentID, StudentName, yearLevel, course from StudentForm to this Form

    End Sub

    Private Sub ItemsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        Dim i As Integer
        Dim rowCount As Integer
        isInTheList = False

        If index < 0 Then

        Else
            Dim userEnteredValue As String
            userEnteredValue = Microsoft.VisualBasic.InputBox("Enter item quantity:", "Baliuag University CSLS Laboratory System", "0", 600, 344)
            selectedRow = ItemsDataGridView.Rows(index)
            If String.IsNullOrWhiteSpace(userEnteredValue) Then
                MessageBox.Show("Transaction is cancelled", "EXIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf userEnteredValue = "0" Then
                MessageBox.Show("Quantity cannot be zero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Val(userEnteredValue) < 0 Then
                MessageBox.Show("INVALID QUANTITY", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf CheckForAlphaCharacters(userEnteredValue) Then
                MessageBox.Show("Letter is an invalid input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                
                requestedQty = Val(userEnteredValue)
                uid = selectedRow.Cells(0).Value.ToString()
                itemName = selectedRow.Cells(1).Value.ToString()
                itemType = selectedRow.Cells(2).Value.ToString()
                itemQty = selectedRow.Cells(3).Value.ToString()
                itemUnit = selectedRow.Cells(4).Value.ToString()

                If requestedQty > itemQty Then
                    MessageBox.Show("Entered quantity is greater than the available stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    rowCount = RequestDataGridview.RowCount

                    If rowCount = 0 Then
                        MessageBox.Show("Item added to request list", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RequestDataGridview.Rows.Add(uid, itemName, itemType, requestedQty, itemUnit, "REMOVE")
                    Else
                        Do While (i < rowCount)                                              'LOOK IF THE ITEM IS ALREADY REQUESTED IN THE DATAGRIDVIEW
                            If uid = RequestDataGridview.Rows(i).Cells(0).Value.ToString() Then
                                isInTheList = True
                            End If
                            i = i + 1
                        Loop

                        If isInTheList = True Then
                            MessageBox.Show("You already requested this item", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ElseIf isInTheList = False Then
                            MessageBox.Show("Item added to request list", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            RequestDataGridview.Rows.Add(uid, itemName, itemType, requestedQty, itemUnit, "REMOVE")
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub RequestDataGridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RequestDataGridview.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim rowToDelete As Integer
            rowToDelete = RequestDataGridview.CurrentCell.RowIndex
            Dim result As DialogResult = MessageBox.Show("REMOVE THIS ITEM FROM YOUR REQUEST LIST?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                RequestDataGridview.Rows.RemoveAt(rowToDelete)
            Else

            End If
        End If
    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        Dim rowCount, i As Integer
        rowCount = RequestDataGridview.RowCount
        dateNeed = dtpDateNeeded.Value

        If String.IsNullOrWhiteSpace(txtActno.Text) Or String.IsNullOrWhiteSpace(txtGroupno.Text) Or String.IsNullOrWhiteSpace(txtLabSubj.Text) Or String.IsNullOrWhiteSpace(txtPurpose.Text) Then
            MessageBox.Show("Please fill-up the form completely.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckForAlphaCharacters(txtGroupno.Text) Or CheckForAlphaCharacters(txtActno.Text) Then
            MessageBox.Show("Invalid Group or Act. No.", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(txtGroupno.Text) < 0 Or Val(txtActno.Text) < 0 Then
            MessageBox.Show("INVALID GROUP OR ACT. NUMBER", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dateNeed < currentDate Then
            MessageBox.Show("Invalid date has been entered", "DATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf rowCount < 0 Or rowCount = 0 Then
            MessageBox.Show("No item is being requested", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)      
        Else
            Dim result As DialogResult = MessageBox.Show("SEND REQUEST?", "CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Do While (i < rowCount)
                    uid = RequestDataGridview.Rows(i).Cells(0).Value.ToString()
                    itemName = RequestDataGridview.Rows(i).Cells(1).Value.ToString()
                    itemType = RequestDataGridview.Rows(i).Cells(2).Value.ToString()
                    requestedQty = RequestDataGridview.Rows(i).Cells(3).Value.ToString()
                    itemUnit = RequestDataGridview.Rows(i).Cells(4).Value.ToString()
                    isValidated = False
                    AddRequest()
                    'UpdateItemRequestedCount()
                    i = i + 1
                Loop
                AddRequestInfo()
                UpdateStudentRequestCount()
                StudentForm.studentRequestCountSF = 1
                MessageBox.Show("YOUR REQEUST HAS BEEN SENT TO OUR STAFF, KINDLY WAIT FOR THEM TO VALIDATE IT", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                StudentForm.Visible = True
            Else

            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        ItemsDataGridView.DataSource = SearchSomething()
        ItemsDataGridView.AutoResizeColumns()
        ItemsDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        ItemsDataGridView.DataSource = SearchSomething()
        ItemsDataGridView.AutoResizeColumns()
        ItemsDataGridView.ClearSelection()
    End Sub

    Private Sub btnNext_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        btnNext.BackgroundImage = My.Resources.btnNextFormHover
    End Sub


    Private Sub btnNext_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        btnNext.BackgroundImage = My.Resources.btnNextForm
    End Sub

    Private Sub btnSendRequest_MouseEnter(sender As Object, e As EventArgs) Handles btnSendRequest.MouseEnter
        btnSendRequest.BackgroundImage = My.Resources.btnSendreqHover
    End Sub

    Private Sub btnSendRequest_MouseLeave(sender As Object, e As EventArgs) Handles btnSendRequest.MouseLeave
        btnSendRequest.BackgroundImage = My.Resources.btnSendreq
    End Sub

    Private Sub btnBack2_MouseEnter(sender As Object, e As EventArgs) Handles btnBack2.MouseEnter
        btnBack2.BackgroundImage = My.Resources.btnbackhover
    End Sub

    Private Sub btnBack2_MouseLeave(sender As Object, e As EventArgs) Handles btnBack2.MouseLeave
        btnBack2.BackgroundImage = My.Resources.btnback
    End Sub
End Class