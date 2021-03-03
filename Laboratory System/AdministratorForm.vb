Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class AdministratorForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Public oldPass, newPass As String

    Private Function UpdatePassword() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblAdmin SET [_KeyPass] = '" & newPass & "' WHERE [ID] = 1", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function Update1to3() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_YearLevel] = [_YearLevel] + 1 WHERE [_YearLevel] < 4", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("1st to 3rd Year Students year levels are incremented by 1", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function Update1to4() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_YearLevel] = [_YearLevel] + 1 WHERE [_YearLevel] < 5", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("1st to 4th Year Students year levels are incremented by 1", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using
        Return datalists
    End Function

    Private Function Delete4() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblStudent WHERE [_YearLevel] = 4", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("4th year students are deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function Delete5() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblStudent WHERE [_YearLevel] = 5", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("5th year students are deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Dim intSwitch As String = 0
    Private Sub btnStaff_MouseEnter(sender As Object, e As EventArgs) Handles btnManageStaff.MouseEnter
        btnManageStaff.BackgroundImage = My.Resources.staffloginiconhover1
    End Sub

    Private Sub btnStaff_MouseLeave(sender As Object, e As EventArgs) Handles btnManageStaff.MouseLeave
        btnManageStaff.BackgroundImage = My.Resources.staffloginicon
    End Sub

    Private Sub btnStudent_MouseEnter(sender As Object, e As EventArgs) Handles btnManageStudent.MouseEnter
        btnManageStudent.BackgroundImage = My.Resources.studentloginiconhover2
    End Sub

    Private Sub btnStudent_MouseLeave(sender As Object, e As EventArgs) Handles btnManageStudent.MouseLeave
        btnManageStudent.BackgroundImage = My.Resources.studentloginicon1
    End Sub

    Private Sub btnInventory_MouseEnter(sender As Object, e As EventArgs) Handles btnInventory.MouseEnter
        btnInventory.BackgroundImage = My.Resources.inventoryiconhover
    End Sub

    Private Sub btnInventory_MouseLeave(sender As Object, e As EventArgs) Handles btnInventory.MouseLeave
        btnInventory.BackgroundImage = My.Resources.inventoryicon
    End Sub

    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        btnConfirm.BackgroundImage = My.Resources.btnConfirmPassHover
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        btnConfirm.BackgroundImage = My.Resources.btnConfirmPass
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnManageStaff.Click
        ManageStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        ManageStudents.Show()
        Me.Hide()
    End Sub

    Private Sub AdministratorForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        panelChangepass.Visible = False
    End Sub

    Private Sub btnUpdate1To3_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate1To3.MouseEnter
        btnUpdate1To3.BackgroundImage = My.Resources.btn1Hover
    End Sub

    Private Sub btnUpdate1To3_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate1To3.MouseLeave
        btnUpdate1To3.BackgroundImage = My.Resources.btn1stTo3rdUpdate
    End Sub

    Private Sub btnUpdate1To4_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdate1To4.MouseEnter
        btnUpdate1To4.BackgroundImage = My.Resources.btn3Hover
    End Sub

    Private Sub btnUpdate1To4_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate1To4.MouseLeave
        btnUpdate1To4.BackgroundImage = My.Resources.btn1stTo4thUpdate
    End Sub

    Private Sub btnDelete4_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete4.MouseEnter
        btnDelete4.BackgroundImage = My.Resources.btn2Hover
    End Sub

    Private Sub btnDelete4_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete4.MouseLeave
        btnDelete4.BackgroundImage = My.Resources.btn4thYearDelete
    End Sub

    Private Sub btnDelete5_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete5.MouseEnter
        btnDelete5.BackgroundImage = My.Resources.btn4Hover
    End Sub

    Private Sub btnDelete5_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete5.MouseLeave
        btnDelete5.BackgroundImage = My.Resources.btn5thYearDelete
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Inventory.lblUser.Text = "Admin"
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            SelectLoginForm.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        HistoryForm.Show()
    End Sub

    Private Sub btnChangepass_Click(sender As Object, e As EventArgs) Handles btnChangepass.Click
        If panelChangepass.Visible = True Then
            panelChangepass.Visible = False
        ElseIf panelChangepass.Visible = False Then
            panelChangepass.Visible = True
        End If
        'If intSwitch = 0 Then

        '    intSwitch = intSwitch + 1
        'ElseIf intSwitch = 1 Then
        '    panelChangepass.Visible = False
        '    intSwitch = intSwitch - 1
        'End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtOldpass.Text = oldPass Then
            newPass = txtNewPass.Text
            If String.IsNullOrWhiteSpace(newPass) Then
                MessageBox.Show("New password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO CHANGE PASS?", "CONFIRMATION", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    UpdatePassword()
                    MessageBox.Show("Password Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    oldPass = newPass
                Else
                    MessageBox.Show("Transaction Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                txtOldpass.Text = ""
                txtNewPass.Text = ""
                panelChangepass.Visible = False
            End If
        ElseIf String.IsNullOrWhiteSpace(txtOldpass.Text) Then
            MessageBox.Show("Old password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Wrong old password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBlacklisted_Click(sender As Object, e As EventArgs) Handles btnBlacklisted.Click
        BlacklisForm.Show()
    End Sub

    Private Sub btnUpdateSY_Click(sender As Object, e As EventArgs) Handles btnUpdateSY.Click
        If panelNewSchoolYearOption.Visible = True Then
            panelNewSchoolYearOption.Visible = False
        ElseIf panelNewSchoolYearOption.Visible = False Then
            panelNewSchoolYearOption.Visible = True
        End If
    End Sub

    Private Sub btnUpdate1To3_Click(sender As Object, e As EventArgs) Handles btnUpdate1To3.Click
        Dim result As DialogResult = MessageBox.Show("INCREMENT ALL 1st TO 3rd YEAR STUDENTS BY 1?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Update1to3()
        Else

        End If
    End Sub

    Private Sub btnUpdate1To4_Click(sender As Object, e As EventArgs) Handles btnUpdate1To4.Click
        Dim result As DialogResult = MessageBox.Show("INCREMENT ALL 1st TO 4th YEAR STUDENTS BY 1?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Update1to4()
        Else

        End If
    End Sub

    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click
        Dim result As DialogResult = MessageBox.Show("DELETE ALL 4th Year Students Information?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Delete4()
        Else

        End If
    End Sub

    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click
        Dim result As DialogResult = MessageBox.Show("DELETE ALL 5th Year Students Information?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Delete5()
        Else

        End If
    End Sub


End Class