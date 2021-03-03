Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class StudentForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Public studentIDSF, studentNameSF, yearLevelSF, studentCourseSF As String
    Public studentRequestCountSF As Integer
    Public isRequestGranted As Boolean

    'Private Function CheckIfValidated() As DataTable
    '    Dim userinfo As New DataTable
    '    Dim i As Integer
    '    Dim rowCount As Integer
    '    Using conn As New OleDbConnection(connString)
    '        Using cmd As New OleDbCommand("SELECT [_StudentID],[_IsValidated] FROM tblRequestInfo WHERE [_StudentID] = '" & studentIDSF & "'", conn)
    '            conn.Open()
    '            Dim reader As OleDbDataReader = cmd.ExecuteReader()
    '            userinfo.Load(reader)
    '            rowCount = userinfo.Rows.Count
    '            Do While (i < rowCount)
    '                If userinfo.Rows(i).Item("_StudentID").ToString() = studentIDSF Then
    '                    isRequestGranted = userinfo.Rows(i).Item("_IsValidated")
    '                Else

    '                End If
    '                i = i + 1
    '            Loop
    '        End Using
    '    End Using
    '    Return userinfo
    'End Function

    Private Sub btnToReturn_MouseHover(sender As Object, e As EventArgs) Handles btnToReturn.MouseEnter
        btnToReturn.BackgroundImage = My.Resources.returnrequesticonhover
    End Sub

    Private Sub btnToReturn_MouseLeave(sender As Object, e As EventArgs) Handles btnToReturn.MouseLeave
        btnToReturn.BackgroundImage = My.Resources.returnrequesticon
    End Sub

    Private Sub btnRequest_MouseHover(sender As Object, e As EventArgs) Handles btnRequest.MouseEnter
        btnRequest.BackgroundImage = My.Resources.btnRequesthover
    End Sub

    Private Sub btnRequest_Mouseleave(sender As Object, e As EventArgs) Handles btnRequest.MouseLeave
        btnRequest.BackgroundImage = My.Resources.btnRequest
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        If studentRequestCountSF = 0 Then
            RequestForm.lblUserType.Text = "Student"
            RequestForm.studentID = studentIDSF
            RequestForm.studentName = studentNameSF
            RequestForm.yearLevel = yearLevelSF
            RequestForm.studentCourse = studentCourseSF
            RequestForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("1 REQUEST PER STUDENT ONLY", "LIMITED REQUEST", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            SelectLoginForm.Visible = True
            MessageBox.Show("THANK YOU FOR USING" + Environment.NewLine + "BALIUAG UNIVERSITY" + Environment.NewLine + "CSLS LABORATORY SYSTEM", "LOGOUT SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

        End If
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        TopMost = False
        StuLoginForm.Timer1.Stop()
    End Sub

    Private Sub btnToReturn_Click(sender As Object, e As EventArgs) Handles btnToReturn.Click
        If studentRequestCountSF = 1 Then
            ToReturnForm.lblUserType.Text = "Student"
            ToReturnForm.lblStudentID.Text = studentIDSF
            ToReturnForm.lblStudentName.Text = studentNameSF
            ToReturnForm.lblYearLevel.Text = yearLevelSF
            ToReturnForm.lblStudentCourse.Text = studentCourseSF
            ToReturnForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("KINDLY REQUEST ITEM/S FIRST", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub StudentForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        
    End Sub

End Class

