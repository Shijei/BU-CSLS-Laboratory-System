Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class PeekInventory

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim searchquery As String
    Private Function SearchSomething() As DataTable
        Dim searchdata As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_Quantity] As [AvailableS Stock], [_Unit] As [Unit],[_ItemType] As [Item Type] FROM tblSupplies WHERE ([_UID] LIKE '%" & searchquery & "%' OR [_ItemName] LIKE '%" & searchquery & "%') AND [_Condition] = 'Functioning' AND [_Availability] = 'Available' AND NOT [_Quantity] = 0 ORDER BY [_ItemName]", conn)
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
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_Quantity] As [AvailableS Stock], [_Unit] As [Unit], [_ItemType] As [Item Type] FROM tblSupplies WHERE [_Condition] = 'Functioning' AND [_Availability] = 'Available' AND NOT [_Quantity] = 0 ORDER BY [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                itemData.Load(reader)
            End Using
        End Using
        Return itemData
    End Function

    Private Sub PeekInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AvailableItemsDataGridView.DataSource = GetItemData()
        AvailableItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AvailableItemsDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchquery = txtSearch.Text
        AvailableItemsDataGridView.DataSource = SearchSomething()
        AvailableItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AvailableItemsDataGridView.ClearSelection()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchquery = txtSearch.Text
        AvailableItemsDataGridView.DataSource = SearchSomething()
        AvailableItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        AvailableItemsDataGridView.ClearSelection()
    End Sub

End Class