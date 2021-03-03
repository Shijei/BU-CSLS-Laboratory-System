Public Class SelectLoginForm

    Private Sub btnStaffLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnStaffLogin.MouseEnter
        btnStaffLogin.BackgroundImage = My.Resources.staffloginiconhover1
    End Sub

    Private Sub btnStaffLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnStaffLogin.MouseLeave
        btnStaffLogin.BackgroundImage = My.Resources.staffloginicon
    End Sub

    Private Sub btnStudentLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnStudentLogin.MouseEnter
        btnStudentLogin.BackgroundImage = My.Resources.studentloginiconhover2
    End Sub

    Private Sub btnStudentLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnStudentLogin.MouseLeave
        btnStudentLogin.BackgroundImage = My.Resources.studentloginicon1
    End Sub

    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        StaffLoginForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click
        StuLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSecretbutton_DoubleClick(sender As Object, e As EventArgs) Handles btnSecretbutton.DoubleClick
        AdministratorLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



End Class