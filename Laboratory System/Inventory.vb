Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class Inventory

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim searchquery, uid, roomlocation, shelflocation, classification, category, itemname, itemtype, unit, condition, availability, remarks, condition1, condition2 As String
    Dim qty As Integer
    Dim acquisitiondate As Date
    Dim Rand As New Random()
    Dim AlphaNumeric As String = "0123456789"
    Dim AlphaNumeric2 As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public staffName As String

    Public Function rAlphanumeric() As String
        Return AlphaNumeric(Rand.Next(0, AlphaNumeric.Length - 1))
    End Function

    Public Function rAlphanumeric2() As String
        Return AlphaNumeric2(Rand.Next(0, AlphaNumeric2.Length - 1))
    End Function

    Private Function SearchSomething() As DataTable
        Dim searchdata As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID],[_RoomLocation] As [Room Location], [_ShelfLocation] As [Shelf Location], [_Classification] As [Classification],[_Category] As [Category] ,[_ItemName] As [Item Name],[_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit], [_Condition] As [Condition], [_AcquisitionDate] As [Acquisition Date], [_Availability] As [Availability], [_Remarks] As [Remarks] FROM tblSupplies WHERE [_UID] LIKE '%" & searchquery & "%' OR [_ItemName] LIKE '%" & searchquery & "%' OR [_Quantity] LIKE '%" & searchquery & "%' OR [_Remarks] LIKE '%" & searchquery & "%' ORDER BY [_RoomLocation], [_ShelfLocation], [_Classification], [_Category], [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                searchdata.Load(reader)
            End Using
        End Using
        Return searchdata
    End Function

    Private Function LookFor() As DataTable
        Dim sortData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID],[_RoomLocation] As [Room Location], [_ShelfLocation] As [Shelf Location], [_Classification] As [Classification],[_Category] As [Category] ,[_ItemName] As [Item Name],[_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit], [_Condition] As [Condition], [_AcquisitionDate] As [Acquisition Date], [_Availability] As [Availability], [_Remarks] As [Remarks] FROM tblSupplies WHERE [" & condition1 & "] = '" & condition2 & "' ORDER BY [_RoomLocation], [_ShelfLocation], [_Classification], [_Category], [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                sortData.Load(reader)
            End Using
        End Using
        Return sortData
    End Function

    Private Function GetSuppliesData() As DataTable
        Dim supplyData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID],[_RoomLocation] As [Room Location], [_ShelfLocation] As [Shelf Location], [_Classification] As [Classification],[_Category] As [Category] ,[_ItemName] As [Item Name],[_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit], [_Condition] As [Condition], [_AcquisitionDate] As [Acquisition Date], [_Availability] As [Availability], [_Remarks] As [Remarks] FROM tblSupplies ORDER BY [_RoomLocation], [_ShelfLocation], [_Classification], [_Category], [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                supplyData.Load(reader)
            End Using
        End Using
        Return supplyData
    End Function

    Private Function GetCondition2() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [" & condition1 & "] FROM tblSupplies", conn)
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

    Private Function GetRoomLocations() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_RoomLocation] FROM tblSupplies", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbRoomLocation.Items.Add(datalists.Rows(i).Item("_RoomLocation").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetShelfLocations() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_ShelfLocation] FROM tblSupplies", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbShelfLocation.Items.Add(datalists.Rows(i).Item("_ShelfLocation").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetClassifications() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_Classification] FROM tblSupplies", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbClassification.Items.Add(datalists.Rows(i).Item("_Classification").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetCategories() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_Category] FROM tblSupplies", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbCategory.Items.Add(datalists.Rows(i).Item("_Category").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetQtyDesc() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_Unit] FROM tblSupplies", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbUnit.Items.Add(datalists.Rows(i).Item("_Unit").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function GetRemarks() As DataTable
        Dim datalists As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_Remarks] FROM tblSupplies WHERE NOT [_Remarks] = ''", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                datalists.Load(reader)
                rowCount = datalists.Rows.Count
                Do While (i < rowCount)
                    cmbRemarks.Items.Add(datalists.Rows(i).Item("_Remarks").ToString)
                    i = i + 1
                Loop
            End Using
        End Using
        Return datalists
    End Function

    Private Function AddItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tblSupplies([_UID],[_RoomLocation],[_ShelfLocation],[_Classification],[_Category],[_ItemName],[_ItemType],[_Quantity],[_Unit],[_Condition],[_AcquisitionDate],[_Availability],[_Remarks]) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)", conn)
            uid = txtUID.Text
            roomlocation = cmbRoomLocation.Text
            shelflocation = cmbShelfLocation.Text
            classification = cmbClassification.Text
            category = cmbCategory.Text
            itemname = txtItemName.Text
            itemtype = cmbItemType.Text
            qty = Val(txtQty.Text)
            unit = cmbUnit.Text
            condition = cmbCondition.Text
            acquisitiondate = dtpAcDate.Value.ToShortDateString
            availability = cmbAvailability.Text
            remarks = cmbRemarks.Text
            
            cmd.Parameters.Add(New OleDbParameter("_UID", CType(uid, String)))
            cmd.Parameters.Add(New OleDbParameter("_RoomLocation", CType(roomlocation, String)))
            cmd.Parameters.Add(New OleDbParameter("_ShelfLocation", CType(shelflocation, String)))
            cmd.Parameters.Add(New OleDbParameter("_Classification", CType(classification, String)))
            cmd.Parameters.Add(New OleDbParameter("_Category", CType(category, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemName", CType(itemname, String)))
            cmd.Parameters.Add(New OleDbParameter("_ItemType", CType(itemtype, String)))
            cmd.Parameters.Add(New OleDbParameter("_Quantity", CType(qty, String)))
            cmd.Parameters.Add(New OleDbParameter("_Unit", CType(unit, String)))
            cmd.Parameters.Add(New OleDbParameter("_Condition", CType(condition, String)))
            cmd.Parameters.Add(New OleDbParameter("_AcquisitionDate", CType(acquisitiondate, String)))
            cmd.Parameters.Add(New OleDbParameter("_Availability", CType(availability, String)))
            cmd.Parameters.Add(New OleDbParameter("_Remarks", CType(remarks, String)))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("DATA ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearAfterAdd()
            Catch ex As OleDbException When ex.ErrorCode = -2147467259
                MessageBox.Show("THE UID IS ALREADY USED, PLEASE JUST GENERATE NEW UID", "ID ALREADY EXISTS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function UpdateItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            roomlocation = cmbRoomLocation.Text
            shelflocation = cmbShelfLocation.Text
            classification = cmbClassification.Text
            category = cmbCategory.Text
            itemname = txtItemName.Text
            itemtype = cmbItemType.Text
            qty = Val(txtQty.Text)
            unit = cmbUnit.Text
            condition = cmbCondition.Text
            acquisitiondate = dtpAcDate.Value.ToShortDateString
            availability = cmbAvailability.Text
            remarks = cmbRemarks.Text
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblSupplies SET [_RoomLocation] = '" & roomlocation & "', [_ShelfLocation] = '" & shelflocation & "', [_Classification] = '" & classification & "', [_Category] = '" & category & "', [_ItemName] = '" & itemname & "',  [_ItemType] = '" & itemtype & "',[_Quantity] = '" & qty & "', [_Unit] = '" & unit & "', [_Condition] = '" & condition & "', [_AcquisitionDate] = '" & acquisitiondate & "', [_Availability] = '" & availability & "', [_Remarks] = '" & remarks & "' WHERE [_UID] = '" & txtUID.Text & "'", conn)
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

    Private Function DeleteItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblSupplies WHERE [_UID] = '" & txtUID.Text & "'", conn)
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

    Private Function DeleteFromRequestList() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequest WHERE [_UID] = '" & txtUID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Sub ClearFields()
        Dim sAnum As String = "CSLS" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()

        txtSearch.Text = "SEARCH"
        txtUID.Text = sAnum
        cmbAvailability.SelectedIndex = 0
        cmbItemType.SelectedIndex = 0
        cmbCondition.SelectedIndex = 0
        SuppliesDataGridView.DataSource = GetSuppliesData()
        SuppliesDataGridView.ClearSelection()
        dtpAcDate.Value = DateTime.Now
        SuppliesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        cmbRoomLocation.Items.Clear()
        GetRoomLocations()
        cmbShelfLocation.Items.Clear()
        GetShelfLocations()
        cmbClassification.Items.Clear()
        GetClassifications()
        cmbCategory.Items.Clear()
        GetCategories()
        cmbUnit.Items.Clear()
        GetQtyDesc()
        cmbRemarks.Items.Clear()
        GetRemarks()
        txtItemName.Text = ""
        txtQty.Text = ""
        cmbRoomLocation.Text = ""
        cmbShelfLocation.Text = ""
        cmbClassification.Text = ""
        cmbCategory.Text = ""
        cmbUnit.Text = ""
        cmbRemarks.Text = ""
        btnGenerate.Enabled = True
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        
    End Sub

    Sub ClearAfterAdd()
        Dim sAnum As String = "CSLS" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()

        txtSearch.Text = "SEARCH"
        txtUID.Text = sAnum
        cmbAvailability.SelectedIndex = 0
        cmbItemType.SelectedIndex = 0
        cmbCondition.SelectedIndex = 0
        SuppliesDataGridView.DataSource = GetSuppliesData()
        SuppliesDataGridView.ClearSelection()
        dtpAcDate.Value = DateTime.Now
        SuppliesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        cmbRoomLocation.Items.Clear()
        GetRoomLocations()
        cmbShelfLocation.Items.Clear()
        GetShelfLocations()
        cmbClassification.Items.Clear()
        GetClassifications()
        cmbCategory.Items.Clear()
        GetCategories()
        cmbUnit.Items.Clear()
        GetQtyDesc()
        cmbRemarks.Items.Clear()
        GetRemarks()
        txtItemName.Text = ""
        txtQty.Text = ""
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


    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sAnum As String = "CSLS" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        txtUID.Text = sAnum
        cmbAvailability.SelectedIndex = 0
        cmbItemType.SelectedIndex = 0
        cmbCondition.SelectedIndex = 0
        SuppliesDataGridView.DataSource = GetSuppliesData()
        SuppliesDataGridView.ClearSelection()
        dtpAcDate.Value = DateTime.Now
        SuppliesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        GetRoomLocations()
        GetShelfLocations()
        GetClassifications()
        GetCategories()
        GetQtyDesc()
        GetRemarks()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If lblUser.Text = "Staff" Then
            StaffForm.lblStaffName.Text = staffName
            Me.Close()
            StaffForm.Show()
        ElseIf lblUser.Text = "Admin" Then
            Me.Close()
            AdministratorForm.Show()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        SuppliesDataGridView.DataSource = SearchSomething()
        SuppliesDataGridView.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        SuppliesDataGridView.DataSource = SearchSomething()
        SuppliesDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub Inventory_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'txtSearch.Text = "SEARCH"
        'SuppliesDataGridView.DataSource = GetSuppliesData()
        'SuppliesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub btnSearch_MouseEnter(sender As Object, e As EventArgs) Handles btnSearch.MouseEnter
        btnSearch.BackgroundImage = My.Resources.searchbarhover_png
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.BackgroundImage = My.Resources.searchbutton
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim sAnum As String = "CSLS" + rAlphanumeric2() + rAlphanumeric2() + rAlphanumeric() + rAlphanumeric() + rAlphanumeric()
        txtUID.Text = sAnum
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtQty.Text) Or String.IsNullOrWhiteSpace(txtItemName.Text) Or String.IsNullOrWhiteSpace(cmbRoomLocation.Text) Or String.IsNullOrWhiteSpace(cmbShelfLocation.Text) Or String.IsNullOrWhiteSpace(cmbItemType.Text) Or String.IsNullOrWhiteSpace(cmbClassification.Text) Or String.IsNullOrWhiteSpace(cmbCategory.Text) Or String.IsNullOrWhiteSpace(cmbUnit.Text) Then
            MessageBox.Show("CHECK DATA ENTRIES, YOU MIGHT MISSED SOME FIELD", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(txtQty.Text) < 0 Then
            MessageBox.Show("INVALID QUANTITY", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckForAlphaCharacters(txtQty.Text) Then
            MessageBox.Show("LETTER IS AN INVALID INPUT IN THE QUANTITY FIELD", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddItem()
        End If
    End Sub

    Private Sub SuppliesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SuppliesDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex 'dont forget
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            btnGenerate.Enabled = False
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            selectedRow = SuppliesDataGridView.Rows(index) 'dont forget
            txtUID.Text = selectedRow.Cells(0).Value.ToString()
            cmbRoomLocation.Text = selectedRow.Cells(1).Value.ToString()
            cmbShelfLocation.Text = selectedRow.Cells(2).Value.ToString()
            cmbClassification.Text = selectedRow.Cells(3).Value.ToString()
            cmbCategory.Text = selectedRow.Cells(4).Value.ToString()
            txtItemName.Text = selectedRow.Cells(5).Value.ToString()
            cmbItemType.Text = selectedRow.Cells(6).Value.ToString()
            txtQty.Text = selectedRow.Cells(7).Value.ToString()
            cmbUnit.Text = selectedRow.Cells(8).Value.ToString()
            cmbCondition.Text = selectedRow.Cells(9).Value.ToString()
            dtpAcDate.Text = selectedRow.Cells(10).Value.ToString()
            cmbAvailability.Text = selectedRow.Cells(11).Value.ToString()
            cmbRemarks.Text = selectedRow.Cells(12).Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtQty.Text) Or String.IsNullOrWhiteSpace(txtItemName.Text) Or String.IsNullOrWhiteSpace(cmbRoomLocation.Text) Or String.IsNullOrWhiteSpace(cmbShelfLocation.Text) Or String.IsNullOrWhiteSpace(cmbItemType.Text) Or String.IsNullOrWhiteSpace(cmbClassification.Text) Or String.IsNullOrWhiteSpace(cmbCategory.Text) Or String.IsNullOrWhiteSpace(cmbUnit.Text) Then
            MessageBox.Show("SELECT A ROW FIRST, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(txtQty.Text) < 0 Then
            MessageBox.Show("INVALID QUANTITY", "INCOMPLETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf CheckForAlphaCharacters(txtQty.Text) Then
            MessageBox.Show("INVALID DATA INPUT IN SOME FIELD, EDIT AND TRY AGAIN", "INVALID DATA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO UPDATE THIS ITEM?", "UPDATE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                UpdateItem()
            Else

            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtQty.Text) Or String.IsNullOrWhiteSpace(txtItemName.Text) Or String.IsNullOrWhiteSpace(cmbRoomLocation.Text) Or String.IsNullOrWhiteSpace(cmbShelfLocation.Text) Or String.IsNullOrWhiteSpace(cmbItemType.Text) Or String.IsNullOrWhiteSpace(cmbClassification.Text) Or String.IsNullOrWhiteSpace(cmbCategory.Text) Or String.IsNullOrWhiteSpace(cmbUnit.Text) Then
            MessageBox.Show("SELECT A ROW FIRST, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO DELETE THIS ITEM?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteFromRequestList()
                DeleteItem()
            Else

            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub cmbCondition1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondition1.SelectedIndexChanged
        If cmbCondition1.SelectedIndex = 0 Then
            condition1 = "_RoomLocation"
        ElseIf cmbCondition1.SelectedIndex = 1 Then
            condition1 = "_ShelfLocation"
        ElseIf cmbCondition1.SelectedIndex = 2 Then
            condition1 = "_Classification"
        ElseIf cmbCondition1.SelectedIndex = 3 Then
            condition1 = "_Availability"
        ElseIf cmbCondition1.SelectedIndex = 4 Then
            condition1 = "_Condition"
        ElseIf cmbCondition1.SelectedIndex = 5 Then
            condition1 = "_Category"
        ElseIf cmbCondition1.SelectedIndex = 6 Then
            condition1 = "_ItemType"
        ElseIf cmbCondition1.SelectedIndex = 7 Then
            condition1 = "_Unit"
        End If
        cmbCondition2.Items.Clear()
        GetCondition2()
    End Sub

    Private Sub btnLookFor_Click(sender As Object, e As EventArgs) Handles btnLookFor.Click
        If String.IsNullOrWhiteSpace(cmbCondition1.Text) Or String.IsNullOrWhiteSpace(cmbCondition2.Text) Then
            MessageBox.Show("PLEASE SELECT CATEGORY TO FIND, INVALID SELECTION!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            condition2 = cmbCondition2.Text
            SuppliesDataGridView.DataSource = LookFor()
            SuppliesDataGridView.ClearSelection()
            cmbCondition1.SelectedIndex = 0
            cmbCondition1.Text = ""
            cmbCondition2.Text = ""
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim the_html_file As String = String.Empty

        Dim stylesheet As String = "  table.gridtable {margin:0 auto;width:95%;overflow:auto;font-family: helvetica,arial,sans-serif;"
        stylesheet &= "font-size:14px;color:#333333;border-width: 1px;border-color: #666666;border-collapse: collapse;text-align: center}"
        stylesheet &= "table.gridtable th {border-width: 1px;padding: 8px; border-style: solid;border-color: #666666;background-color: #94c37e;}"
        stylesheet &= "table.gridtable td {border-width: 1px;padding: 8px;border-style: solid;border-color: #666666;}"

        the_html_file = "<!DOCTYPE html><html><head><meta charset='UTF-8'><title>REPORTS</title><style>" & stylesheet & "</style></head><body>"

        the_html_file &= "<h1 style='font-family:Century Gothic; padding-left: 40px'>INVENTORY AS OF " & Date.Today & "</h1>"
        the_html_file &= "<table class='gridtable'>"
        the_html_file &= "<thead><tr>"

        'get the column headers
        For Each column As DataGridViewColumn In SuppliesDataGridView.Columns
            the_html_file = the_html_file & "<th>" & column.HeaderText & "</th>"
        Next

        the_html_file = the_html_file & "</tr></thead><tbody>"

        'get the rows
        For Each row As DataGridViewRow In SuppliesDataGridView.Rows
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

        the_html_file &= "<br><br><h5 style='font-family:Century Gothic; padding-left: 40px'> APPROVED BY:                       </h5>"
        the_html_file &= "<h5 style='font-family:Century Gothic; padding-left: 40px'> ______________________________________________</h5>"
        the_html_file &= "<h5 style='font-family:Century Gothic; padding-left: 40px; margin-top: 0px'>       Signature over printed name</h5>"

        the_html_file &= "</body></html>"

        'CHANGE PATH BEFORE DEFENSE ↓↓↓↓↓↓↓↓
        'write the file
        ' My.Computer.FileSystem.WriteAllText("C:\Users\Shijei\Documents\Visual Studio 2013\Projects\LaboratorySystem\suppliesInventory.html", the_html_file, False)
        Dim fileNamePath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "suppliesInventory.html")
        My.Computer.FileSystem.WriteAllText(fileNamePath, the_html_file, False)
        'pass file to default browser
        Dim pinfo As New ProcessStartInfo()
        pinfo.WindowStyle = ProcessWindowStyle.Normal
        'pinfo.FileName = "C:\Users\Shijei\Documents\Visual Studio 2013\Projects\LaboratorySystem\suppliesInventory.html"
        pinfo.FileName = fileNamePath
        Dim p As Process = Process.Start(pinfo)
    End Sub


    Private Sub btnPrint_MouseEnter(sender As Object, e As EventArgs) Handles btnPrint.MouseEnter
        btnPrint.BackgroundImage = My.Resources.btnPrintHover
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackgroundImage = My.Resources.btnPrint
    End Sub

End Class
