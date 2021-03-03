Public Class StaffForm

    Public staffName As String

    Private Sub btnToInventory_Click(sender As Object, e As EventArgs) Handles btnToInventory.Click
        Inventory.lblUser.Text = "Staff"
        Inventory.staffName = lblStaffName.Text
        Me.Close()
        Inventory.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            StaffLoginForm.Show()
        Else

        End If
    End Sub


    Private Sub btnToManageRequests_MouseEnter(sender As Object, e As EventArgs) Handles btnToManageRequests.MouseEnter
        btnToManageRequests.BackgroundImage = My.Resources.managerequesticonhover
    End Sub

    Private Sub btnToManageRequests_MouseLeave(sender As Object, e As EventArgs) Handles btnToManageRequests.MouseLeave
        btnToManageRequests.BackgroundImage = My.Resources.managerequesticon
    End Sub

    Private Sub btnToReturn_MouseEnter(sender As Object, e As EventArgs) Handles btnToReturn.MouseEnter
        btnToReturn.BackgroundImage = My.Resources.returnrequesticonhover
    End Sub

    Private Sub btnToReturn_MouseLeave(sender As Object, e As EventArgs) Handles btnToReturn.MouseLeave
        btnToReturn.BackgroundImage = My.Resources.returnrequesticon
    End Sub

    Private Sub btnToInventory_MouseEnter(sender As Object, e As EventArgs) Handles btnToInventory.MouseEnter
        btnToInventory.BackgroundImage = My.Resources.inventoryiconhover
    End Sub

    Private Sub btnToInventory_MouseLeave(sender As Object, e As EventArgs) Handles btnToInventory.MouseLeave
        btnToInventory.BackgroundImage = My.Resources.inventoryicon
    End Sub

    Private Sub btnToManageRequests_Click(sender As Object, e As EventArgs) Handles btnToManageRequests.Click
        ManageRequests.staffName = lblStaffName.Text
        Me.Close()
        ManageRequests.Show()
    End Sub

    Private Sub btnToReturn_Click(sender As Object, e As EventArgs) Handles btnToReturn.Click
        ManagePendingReturn.staffName = lblStaffName.Text
        Me.Close()
        ManagePendingReturn.Show()
    End Sub

    Private Sub btnBlacklisted_Click(sender As Object, e As EventArgs) Handles btnBlacklisted.Click
        BlacklisForm.Show()
    End Sub
End Class