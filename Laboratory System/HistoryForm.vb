Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class HistoryForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim studentid, dateBorrowed As String


    Private Function GetStudentsInHistory() As DataTable
        Dim itemData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT DISTINCT [_StudentID] As [Student ID], [_StudentName] As [Student Name], [_DateBorrowed] As [Date Returned], [_StaffInCharge] As [Staff Responsible]  FROM tblHistory ORDER BY [_DateBorrowed] ", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                itemData.Load(reader)
            End Using
        End Using
        Return itemData
    End Function

    Private Function GetStudentsBorrowedItems() As DataTable
        Dim itemData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_ItemType] As [Item Type], [_Quantity] As [Quantity], [_Unit] As [Unit]  FROM tblHistory WHERE [_StudentID] = '" & studentid & "' AND [_DateBorrowed] = #" & dateBorrowed & "# ORDER BY [_DateBorrowed], [_ItemName] ", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                itemData.Load(reader)
            End Using
        End Using
        Return itemData
    End Function

    Private Function DeleteSingle() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblHistory WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function DeleteAll() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblHistory", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function


    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentsAndDateReturnedDataGridView.DataSource = GetStudentsInHistory()
        StudentsAndDateReturnedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        StudentsAndDateReturnedDataGridView.ClearSelection()
    End Sub


    Private Sub StudentsAndDateReturnedDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsAndDateReturnedDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex 'dont forget
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            selectedRow = StudentsAndDateReturnedDataGridView.Rows(index) 'dont forget
            studentid = selectedRow.Cells(0).Value.ToString()
            dateBorrowed = selectedRow.Cells(2).Value.ToString()
            TheStudentRequestedItemDataGridView.DataSource = GetStudentsBorrowedItems()
            TheStudentRequestedItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            TheStudentRequestedItemDataGridView.ClearSelection()
            btnDeleteSingle.Enabled = True
        End If
    End Sub

    Private Sub btnDeleteSingle_Click(sender As Object, e As EventArgs) Handles btnDeleteSingle.Click
        Dim result As DialogResult = MessageBox.Show("DELETE THIS STUDENT's TRANSACTION HISTORY DATA?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DeleteSingle()
            studentid = ""
            StudentsAndDateReturnedDataGridView.DataSource = GetStudentsInHistory()
            StudentsAndDateReturnedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            StudentsAndDateReturnedDataGridView.ClearSelection()
            TheStudentRequestedItemDataGridView.DataSource = GetStudentsBorrowedItems()
            TheStudentRequestedItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            TheStudentRequestedItemDataGridView.ClearSelection()
            btnDeleteSingle.Enabled = False
            MessageBox.Show("STUDENT HISTORY DATA HAS BEEN DELETED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE TO DELETE OVERALL TRANSACTION HISTORY?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DeleteAll()
            studentid = ""
            StudentsAndDateReturnedDataGridView.DataSource = GetStudentsInHistory()
            StudentsAndDateReturnedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            StudentsAndDateReturnedDataGridView.ClearSelection()
            TheStudentRequestedItemDataGridView.DataSource = GetStudentsBorrowedItems()
            TheStudentRequestedItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            TheStudentRequestedItemDataGridView.ClearSelection()
            MessageBox.Show("ALL TRANSACTION HISTORY ARE NOW DELETED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

        End If
    End Sub

    Private Sub btnDeleteSingle_MouseEnter(sender As Object, e As EventArgs) Handles btnDeleteSingle.MouseEnter
        btnDeleteSingle.BackgroundImage = My.Resources.btnDeleteSingleHistoryHover
    End Sub

    Private Sub btnDeleteSingle_MouseLeave(sender As Object, e As EventArgs) Handles btnDeleteSingle.MouseLeave
        btnDeleteSingle.BackgroundImage = My.Resources.btnDeleteSingleHistory
    End Sub

    Private Sub btnDeleteAll_MouseEnter(sender As Object, e As EventArgs) Handles btnDeleteAll.MouseEnter
        btnDeleteAll.BackgroundImage = My.Resources.btnDeleteMultipleHistoryHover
    End Sub

    Private Sub btnDeleteAll_MouseLeave(sender As Object, e As EventArgs) Handles btnDeleteAll.MouseLeave
        btnDeleteAll.BackgroundImage = My.Resources.btnDeleteMultipleHistory
    End Sub

End Class