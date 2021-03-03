Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class StaffLoginForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim checkid, staffid, staffpass As String
    Dim inputstaffid, inputstaffpass As String
    Public staffname As String
    Private Function GetStaffAcc() As DataTable
        Dim userinfo As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StaffID], [_StaffPassword], [_FullName] FROM tblStaff WHERE [_StaffID] = '" & checkid & "'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                If userinfo.Rows.Count > 0 Then
                    staffid = userinfo.Rows(0).Item("_StaffID").ToString()
                    staffpass = userinfo.Rows(0).Item("_StaffPassword").ToString()
                    staffname = userinfo.Rows(0).Item("_FullName").ToString()
                End If
            End Using
        End Using
        Return userinfo
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        SelectLoginForm.Visible = True
    End Sub


    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackgroundImage = My.Resources.btnLoginHover
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackgroundImage = My.Resources.btnLogin
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        checkid = txtUser.Text
        inputstaffid = txtUser.Text
        inputstaffpass = txtPass.Text
        GetStaffAcc()
        If String.IsNullOrWhiteSpace(txtUser.Text) Or String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("EMPTY FIELDS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf inputstaffid = staffid And inputstaffpass = staffpass Then
            StaffForm.lblStaffName.Text = staffname
            Me.Close()
            StaffForm.Show()
        Else
            MessageBox.Show("INVALID USER CREDENTIALS, TRY AGAIN!", "ACCOUNT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class