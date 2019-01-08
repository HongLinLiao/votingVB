Imports System.Data
Imports System.Data.SqlClient

Module auth

    Public userData As New DataTable '全域使用者資料
    Public typeData As New DataTable '全域登入類型資料

    Dim con As SqlConnection

    'app.config資料庫連接字串
    Dim connectString As String = System.Configuration.ConfigurationManager.ConnectionStrings("database").ToString()

    '登入
    Function logIn(ByRef type As String, ByRef id As String, ByRef birth As String) As String

        con = New SqlConnection
        con.ConnectionString = connectString

        '處理過後的生日
        Dim allbirth As String = birthTransform(birth)

        '登入狀態
        Dim status As Boolean = False

        Try
            con.Open() '開啟連接

            Dim cmdString As String

            cmdString = "Select * From ""User"" Where id = '" + id + "' AND birth = '" + allbirth + "'"


            Dim cmd As New SqlCommand(cmdString, con)
            Dim adp As New SqlDataAdapter(cmd)

            '寫進dataTable
            adp.Fill(userData)

            If (userData.Rows.Count > 0) Then

                If (type = "Admin") Then
                    cmdString = "Select * From ""Admin"" Where id = '" + id + "'"
                ElseIf (type = "Client") Then
                    cmdString = "Select * From ""Normal"" Where id = '" + id + "'"
                End If

                cmd = New SqlCommand(cmdString, con)
                adp = New SqlDataAdapter(cmd)
                adp.Fill(typeData)

                If (typeData.Rows.Count = 0) Then
                    MessageBox.Show("你沒有此權限!")
                    status = False
                Else
                    MessageBox.Show("登入成功!")
                    status = True
                End If

            Else
                MessageBox.Show("請輸入正確的身份證字號或生日!")
                status = False
            End If
        Catch ex As SqlException
            status = False
            MessageBox.Show(ex.Message) 'Debug
        Finally
            con.Close() '關閉連接
            con.Dispose() '釋放緩存
        End Try

        Return status

    End Function


    '生日的轉換
    Function birthTransform(ByRef birth As String)

        Dim year As String = birth.Substring(0, 4) '年
        Dim month As String = birth.Substring(4, 2) '月
        Dim day As String = birth.Substring(6, 2) '日

        Return year + "/" + month + "/" + day

    End Function


    '註冊
    Function signUp()

        Dim allStatus As Boolean

        '<=================================身分證字號輸入======================================>
        Dim suId As String = "temp" 'ID number
        Dim idNum As Integer = 0 'ID計數器
        'inputBox 直接按下取消與確定會回傳長度為0的空字串
        Do While suId.Length > 0

            If (idNum = 0) Then
                idNum = idNum + 1
                suId = InputBox("請輸入身分證字號 (ex:H000000000)", "Sign Up")
            Else
                idNum = idNum + 1
                suId = InputBox("請輸入正確格式的身分證字號 (ex:H000000000)", "Sign Up")
            End If

            If (suId.Length <> 10) Then 'id不是10字元
                Continue Do
            Else '篩掉不是英數

                Dim idStatus As Boolean = True
                For i = 1 To 10
                    Dim txt As String = Mid(suId, i, 1)
                    '篩第一個字為英文
                    If (i = 1) Then
                        Select Case Asc(txt)
                            Case 65 To 90 '大寫英文
                                idStatus = True
                            Case 97 To 122 '小寫英文
                                idStatus = True
                            Case Else
                                Continue Do '不是英文的情況
                        End Select
                    Else '篩2~10個字為數字
                        Select Case Asc(txt)
                            Case 48 To 57 '數字
                                idStatus = True
                            Case Else
                                Continue Do '不是數字的情況
                        End Select
                    End If
                Next

                If (idStatus = True) Then
                    Exit Do
                End If

            End If
        Loop

        '<=================================生日輸入============================================>
        Dim suBirth As String = "temp" 'Birth
        Dim birthNum As Integer = 0 '生日計數器

        '身分證輸入篩選有過才進生日輸入篩選
        Do While (suId.Length <> 0)

            If (birthNum = 0) Then
                birthNum = birthNum + 1
                suBirth = InputBox("請輸入生日 (ex:20190101)", "Sign Up")
            Else
                birthNum = birthNum + 1
                suBirth = InputBox("請輸入正確格式的生日 (ex:20190101)", "Sign Up")
            End If

            If (suBirth.Length <> 0) Then

                If (suBirth.Length <> 8) Then
                    Continue Do
                Else
                    Dim birthStatus As Boolean = True
                    For i = 1 To 8
                        Dim txt As String = Mid(suBirth, i, 1)
                        '篩選為數字
                        Select Case Asc(txt)
                            Case 48 To 57 '數字
                                birthStatus = True
                            Case Else
                                Continue Do '不是數字的情況
                        End Select
                    Next

                    If (birthStatus = True) Then
                        Exit Do
                    End If
                End If
            Else
                Exit Do
            End If

        Loop

        '<=================================名稱輸入============================================>
        Dim suName As String = "temp"
        Dim nameNum As Integer = 0

        '身分證字號有篩選後才進
        If (suId.Length <> 0) Then

            '生日有篩選過才進
            If (suBirth.Length <> 0) Then

                Do While (suBirth.Length <> 0)

                    If (nameNum = 0) Then
                        nameNum = nameNum + 1
                        suName = InputBox("請輸入暱稱 (開頭不可為空白)", "Sign Up")
                    Else
                        nameNum = nameNum + 1
                        suName = InputBox("請輸入正確格式的暱稱 (開頭不可為空白)", "Sign Up")
                    End If

                    If (suName.Length <> 0) Then
                        Dim NameStatus As Boolean = True

                        Dim txt As String = Mid(suName, 1, 1)

                        '篩選掉開頭為空白
                        Select Case Asc(txt)
                            Case 32 '空白
                                Continue Do
                        End Select

                        If (NameStatus = True) Then
                            Exit Do
                        End If
                    Else
                        Exit Function
                    End If

                Loop

            End If
        End If


        '<=================================資料庫=============================================>
        If (suId.Length <> 0 And suBirth.Length <> 0 And suName.Length <> 0) Then

            Try
                '處理過後的生日
                Dim allbirth As String = birthTransform(suBirth)

                con = New SqlConnection
                con.ConnectionString = connectString

                con.Open() '開啟連接

                Dim cmdString As String

                '搜尋是否該身分證已建立
                cmdString = "Select * From ""User"" Where id = '" + suId + "'"

                Dim cmd As New SqlCommand(cmdString, con)
                Dim adp As New SqlDataAdapter(cmd)

                Dim tempTable As New DataTable
                '寫進dataTable
                adp.Fill(tempTable)

                '資料庫已有該身分證資料
                If (tempTable.Rows.Count <> 0) Then
                    MessageBox.Show("該身分證字號已經註冊過，請重新註冊!")
                Else

                    Dim sMonth As Integer = CInt(DateTime.Today.Month())
                    Dim sDay As Integer = CInt(DateTime.Today.Day())

                    Dim Month As String
                    Dim Day As String

                    If (sMonth < 10) Then
                        Month = "0" + sMonth.ToString
                    Else
                        Month = sMonth.ToString
                    End If

                    If (sDay < 10) Then
                        Day = "0" + sDay.ToString
                    Else
                        Day = sDay.ToString
                    End If


                    '建立user
                    cmdString = "Insert Into ""User"" (id,birth,name) Values(" + "'" + suId.ToUpper + "','" + allbirth + "','" + suName + "')
                                Insert Into ""Normal"" (id,initDate) Values(" + "'" + suId.ToUpper + "','" + DateTime.Today.Year().ToString() + "/" + Month + "/" + Day + "')"
                    cmd = New SqlCommand(cmdString, con)
                    cmd.ExecuteNonQuery()

                    'userData
                    cmdString = "Select * From ""User"" Where id = '" + suId.ToUpper + "' AND birth = '" + allbirth + "'"
                    cmd = New SqlCommand(cmdString, con)
                    adp = New SqlDataAdapter(cmd)
                    adp.Fill(userData)

                    'typeData
                    cmdString = "Select * From ""Normal"" Where id = '" + suId.ToUpper + "'"
                    cmd = New SqlCommand(cmdString, con)
                    adp = New SqlDataAdapter(cmd)
                    adp.Fill(typeData)

                    allStatus = True
                End If

            Catch ex As Exception
                allStatus = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close() '關閉連接
                con.Dispose() '釋放緩存
            End Try

        End If


        Return allStatus

    End Function


    '登出
    Sub signOut()
        userData = New DataTable
        typeData = New DataTable
    End Sub


End Module
