Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class BlacklisForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim studentid, searchquery As String

    Private Function GetBlackListedStudents() As DataTable
        Dim itemData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID] As [Student ID], [_FullName] As [Student Name], [_YearLevel] As [Year Level], [_Course] As [Course],[_BlacklistReason] As [BLACKLIST REASON]  FROM tblStudent WHERE [_IsBlackListed] = 'True' ORDER BY [_YearLevel],[_FullName] ", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                itemData.Load(reader)
            End Using
        End Using
        Return itemData
    End Function

    Private Function SettleStudent() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_IsBlackListed] = 'False' WHERE [_StudentID] = '" & studentid & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Sub BlacklisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlackListedStudentDataGridView.DataSource = GetBlackListedStudents()
        BlackListedStudentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        BlackListedStudentDataGridView.ClearSelection()
    End Sub

    Private Sub btnSettleStudent_MouseEnter(sender As Object, e As EventArgs) Handles btnSettleStudent.MouseEnter
        btnSettleStudent.BackgroundImage = My.Resources.btnSettleHover
    End Sub

    Private Sub btnSettleStudent_MouseLeave(sender As Object, e As EventArgs) Handles btnSettleStudent.MouseLeave
        btnSettleStudent.BackgroundImage = My.Resources.btnSettle
    End Sub

    Private Sub BlackListedStudentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BlackListedStudentDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex 'dont forget
        Dim selectedRow As DataGridViewRow
        If index < 0 Then

        Else
            selectedRow = BlackListedStudentDataGridView.Rows(index) 'dont forget
            studentid = selectedRow.Cells(0).Value.ToString()
            btnSettleStudent.Enabled = True
        End If
    End Sub

    Private Sub btnSettleStudent_Click(sender As Object, e As EventArgs) Handles btnSettleStudent.Click
        Dim result As DialogResult = MessageBox.Show("SETTLE STUDENT AND ALLOW HIM TO USE THE SYSTEM AGAIN?", "SETTLE CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            SettleStudent()
            MessageBox.Show("STUDENT WHITELISTED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BlackListedStudentDataGridView.DataSource = GetBlackListedStudents()
            BlackListedStudentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            BlackListedStudentDataGridView.ClearSelection()
            studentid = ""
        Else

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        BlackListedStudentDataGridView.DataSource = GetBlackListedStudents()
        BlackListedStudentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        BlackListedStudentDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        BlackListedStudentDataGridView.DataSource = GetBlackListedStudents()
        BlackListedStudentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        BlackListedStudentDataGridView.ClearSelection()
    End Sub

End Class