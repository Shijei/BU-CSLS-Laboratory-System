Imports MessagingToolkit.QRCode.Codec
Imports BasselTech_CamCapture
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class StuLoginForm

    Dim connString As String = ConfigurationManager.ConnectionStrings("db").ConnectionString
    Dim cam As Camera
    Dim reader As QRCodeDecoder
    Dim capturedImage As Bitmap
    Dim flag As Integer = 0
    Public studentidSLF, fullNameSLF, studentCourseSLF, yearLevelSLF, studentQRcode As String
    Public studentRequestCountSLF As Integer
    Dim isAccountValid As Boolean

    Private Function GetStudentAccount() As DataTable
        Dim userinfo As New DataTable
        Dim i As Integer
        Dim rowCount As Integer
        isAccountValid = False
        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT [_StudentID], [_FullName], [_YearLevel], [_Course],[_StudentQRCode],[_RequestCount] FROM tblStudent WHERE [_StudentQRCode] = '" & studentQRcode & "' AND [_IsBlackListed] = 'False'", conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                userinfo.Load(reader)
                rowCount = userinfo.Rows.Count
                Do While (i < rowCount)
                    If userinfo.Rows(i).Item("_StudentQRCode").ToString() = studentQRcode Then
                        studentidSLF = userinfo.Rows(i).Item("_StudentID").ToString()
                        fullNameSLF = userinfo.Rows(i).Item("_Fullname").ToString()
                        yearLevelSLF = userinfo.Rows(i).Item("_YearLevel").ToString()
                        studentCourseSLF = userinfo.Rows(i).Item("_Course").ToString()
                        studentRequestCountSLF = userinfo.Rows(i).Item("_RequestCount").ToString()
                        isAccountValid = True  'ROW WITH THE SAME ID IN QR WAS FOUND SO THE VALUE OF isAccountValid isTrue
                    Else
                        isAccountValid = False  'ROW WITH THE SAME ID IN QR WAS NOT FOUND SO THE VALUE OF isAccountValid is False
                    End If
                    i = i + 1
                Loop
            End Using
        End Using
        Return userinfo
    End Function

    Private Sub StuLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isAccountValid = False
        BackgroundWorker1.WorkerSupportsCancellation = True
        MessageBox.Show("IF A CAMERA SOURCE DIALOG BOX OR AN ERROR APPEAR, KINDLY ASK OUR STAFF TO CONFIGURE IT. THANK YOU", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        StartWebcam()
        Timer1.Start()
    End Sub

    Private Sub StartWebcam()
        Try
            StopWebcam()
            cam = New Camera(PictureBox1)
            cam.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            cam.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Sub OpenStudentForm()
        StudentForm.lblStudentName.Text = fullNameSLF
        StudentForm.studentIDSF = studentidSLF
        StudentForm.studentNameSF = fullNameSLF
        StudentForm.yearLevelSF = yearLevelSLF
        StudentForm.studentCourseSF = studentCourseSLF
        StudentForm.studentRequestCountSF = studentRequestCountSLF
        Me.Close()
        StudentForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        capturedImage = cam.GetBitmap()
        If Not BackgroundWorker1.IsBusy Then
            If isAccountValid = True Then
                Timer1.Stop()
            Else
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'CheckForIllegalCrossThreadCalls = False 'if anything goes wrong use this fvcking line, hello future debuggers, this is my really old system presented to BU :D
        ' The purpose of this function is to read the qr, then if the value read is in the database it will direct you to the student menus
        Try
            reader = New QRCodeDecoder
            studentQRcode = reader.decode(New Data.QRCodeBitmapImage(capturedImage))
            GetStudentAccount()
            If isAccountValid = True Then
                BeginInvoke(New MethodInvoker(AddressOf OpenStudentForm))
            Else
                MessageBox.Show("STUDENT IS BLACKLISTED OR NOT PRESENT IN THE DATABASE", "ACCOUNT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnSecretbutton_DoubleClick(sender As Object, e As EventArgs) Handles btnSecretbutton.DoubleClick
        If flag = 0 Then
            btnBack.Enabled = True
            flag = flag + 1
        ElseIf flag = 1 Then
            btnBack.Enabled = False
            flag = flag - 1
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        SelectLoginForm.Visible = True
    End Sub

    Private Sub StuLoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If isAccountValid = True Then
            Timer1.Stop()
        End If
    End Sub

    'NOTE: Future devs, when this form is running a backgroundworker, the capability of using copy-paste loses
    'my theory is the backgroundworker affects system processs, sorry I'm not sure because I didn't fully understand the function
    'of using backgroundworker

End Class