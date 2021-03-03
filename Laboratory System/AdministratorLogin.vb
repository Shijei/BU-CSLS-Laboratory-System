Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class AdministratorLogin

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim dbPass, inputPass As String

    Private Function GetAdminAcc() As DataTable
        Dim userinfo As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [ID], [_KeyPass] FROM tblAdmin WHERE [ID] = 1", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                If userinfo.Rows.Count > 0 Then
                    dbPass = userinfo.Rows(0).Item("_KeyPass").ToString()
                End If
            End Using
        End Using
        Return userinfo
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        SelectLoginForm.Visible = True
    End Sub

    Private Sub AdministratorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAdminAcc()
    End Sub

    Private Sub txtAdminKey_TextChanged(sender As Object, e As EventArgs) Handles txtAdminKey.TextChanged
        inputPass = txtAdminKey.Text
        If Not dbPass = inputPass Then

        Else
            AdministratorForm.oldPass = dbPass
            Me.Close()
            AdministratorForm.Show()
        End If
    End Sub

    
End Class