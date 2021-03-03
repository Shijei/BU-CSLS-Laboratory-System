Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class ToReturnForm
    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim isRequestGranted As String
    Private Function GetRequestedItems() As DataTable
        Dim requestData As New DataTable
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_UID] As [UID], [_ItemName] As [Item Name], [_ItemType] As [Item Type], [_Qty] As [Quantity], [_Unit] As [Unit] FROM tblRequest WHERE [_StudentID] = '" & lblStudentID.Text & "' ORDER BY [_ItemName]", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                requestData.Load(reader)
            End Using
        End Using
        Return requestData
    End Function

    Private Function CheckIfValidated() As DataTable
        Dim userinfo As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID],[_IsValidated] FROM tblRequestInfo WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                rowCount = userinfo.Rows.Count
                Do While (i < rowCount)
                    If userinfo.Rows(i).Item("_StudentID").ToString() = lblStudentID.Text Then
                        isRequestGranted = userinfo.Rows(i).Item("_IsValidated").ToString
                    Else

                    End If
                    i = i + 1
                Loop
                If rowCount = 0 Then
                    isRequestGranted = ""
                End If
            End Using
        End Using
        Return userinfo
    End Function

    Private Function UpdateStudentRequestCount() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tblStudent SET [_RequestCount] = 0 WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function GetStudentRequestInfo() As DataTable
        Dim userinfo As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID],[_GroupNo],[_LabSubject],[_ActivityNo],[_Purpose],[_DateNeeded] FROM tblRequestInfo WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                rowCount = userinfo.Rows.Count
                Do While (i < rowCount)
                    If userinfo.Rows(i).Item("_StudentID").ToString() = lblStudentID.Text Then
                        txtGroupno.Text = userinfo.Rows(i).Item("_GroupNo").ToString
                        txtLabSubj.Text = userinfo.Rows(i).Item("_LabSubject").ToString
                        txtActno.Text = userinfo.Rows(i).Item("_ActivityNo").ToString
                        txtPurpose.Text = userinfo.Rows(i).Item("_Purpose").ToString
                        dtpDateNeeded.Value = userinfo.Rows(i).Item("_DateNeeded").ToString
                    Else

                    End If
                    i = i + 1
                Loop
            End Using
        End Using
        Return userinfo
    End Function

    Private Function DeleteRequestedItem() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequest WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Function DeleteRequestedInformation() As DataTable
        Dim datalists As New DataTable
        Using conn As New OleDbConnection(connString)
            Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM tblRequestInfo WHERE [_StudentID] = '" & lblStudentID.Text & "'", conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As OleDbException
                MessageBox.Show("AN ERROR OCCURED, PLEASE CHECK THE FOLLOWING DATA ENTERED!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return datalists
    End Function

    Private Sub ToReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToReturnDataGridView.DataSource = GetRequestedItems()
        ToReturnDataGridView.AutoResizeColumns()
        GetStudentRequestInfo()
        CheckIfValidated()
        Timer1.Interval = 3000
        Timer1.Start()
        If isRequestGranted = True Then
            lblStudentNotif.Text = "YOUR REQUEST HAS BEEN VALIDATED, KINDLY RETURN THE ITEMS/ BELOW" + Environment.NewLine + "BEFORE OR ON " + dtpDateNeeded.Value + " TO AVOID BEING BLACKLISTED AND PENALIZED."
            btnCancelRequest.Visible = False
        Else
            lblStudentNotif.Text = "YOUR REQUEST IS STILL BEING PROCESSED"
            btnCancelRequest.Visible = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        StudentForm.Visible = True
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckIfValidated()

        If isRequestGranted = "True" Then
            lblStudentNotif.Text = "YOUR REQUEST HAS BEEN VALIDATED, KINDLY RETURN THE ITEMS/ BELOW" + Environment.NewLine + "BEFORE OR ON " + dtpDateNeeded.Value + " TO AVOID BEING BLACKLISTED AND PENALIZED."
            btnCancelRequest.Visible = False
        ElseIf isRequestGranted = "False" Then
            lblStudentNotif.Text = "YOUR REQUEST IS STILL BEING PROCESSED"
            btnCancelRequest.Visible = True
        ElseIf isRequestGranted = "" Then
            Me.Close()
            StudentForm.studentRequestCountSF = 0
            StudentForm.Visible = True
        End If
    End Sub

    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs) Handles btnCancelRequest.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO CANCEL THIS REQUEST?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            UpdateStudentRequestCount()
            DeleteRequestedItem()
            DeleteRequestedInformation()
            Me.Close()
            StudentForm.studentRequestCountSF = 0
            StudentForm.Visible = True
        Else

        End If
    End Sub

    Private Sub btnCancelRequest_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelRequest.MouseEnter
        btnCancelRequest.BackgroundImage = My.Resources.btnCancelReqHover
    End Sub

    Private Sub btnCancelRequest_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelRequest.MouseLeave
        btnCancelRequest.BackgroundImage = My.Resources.btnCancelReq
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackgroundImage = My.Resources.btnbackhover
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackgroundImage = My.Resources.btnback
    End Sub
End Class