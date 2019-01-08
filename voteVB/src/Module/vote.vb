Imports System.Data
Imports System.Data.SqlClient


Module vote

    Dim con As SqlConnection

    'app.config資料庫連接字串
    Dim connectString As String = System.Configuration.ConfigurationManager.ConnectionStrings("database").ToString()


    '新增投票
    Function addVote(ByRef title As String, ByRef startTime As String, ByRef endTime As String, ByRef columeTitle As String,
                     ByRef columeImage As String, ByRef columeRemark As String)

        Dim status As Boolean = False
        con = New SqlConnection
        con.ConnectionString = connectString

        Try

            con.Open()

            Dim cmdString As String

            cmdString = "Insert into ""Vote""(id,title,startTime,endTime,columeTitle,columeImage,columeRemark)
                        Values(NEWID(),'" + title + "','" + startTime + "','" + endTime + "','" + columeTitle + "','" + columeImage + "','" + columeRemark + "')"

            Dim cmd As New SqlCommand(cmdString, con)
            cmd.ExecuteNonQuery()

            status = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return status

    End Function


    '讀取所有投票
    Function loadVote()

        '回傳table
        Dim voteData As DataTable = New DataTable

        con = New SqlConnection
        con.ConnectionString = connectString

        Try
            con.Open()

            Dim cmdString As String
            cmdString = "Select * From ""Vote"" Order by endTime"

            Dim cmd As New SqlCommand(cmdString, con)
            Dim adp As New SqlDataAdapter(cmd)

            '寫進dataTable
            adp.Fill(voteData)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try


        Return voteData

    End Function


    '讀取該id投票
    Function loadVoteItem(ByRef id As String)

        '回傳table
        Dim voteData As DataTable = New DataTable

        con = New SqlConnection
        con.ConnectionString = connectString

        Try
            con.Open()

            Dim cmdString As String
            cmdString = "Select * From ""Vote"" Where id = '" + id + "'"

            Dim cmd As New SqlCommand(cmdString, con)
            Dim adp As New SqlDataAdapter(cmd)

            '寫進dataTable
            adp.Fill(voteData)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return voteData

    End Function


    '讀取該id票匭
    Function loadChoiceItem(ByRef id As String)

        '回傳table
        Dim choiceData As DataTable = New DataTable

        con = New SqlConnection
        con.ConnectionString = connectString

        Try
            con.Open()

            Dim cmdString As String
            cmdString = "Select * From ""Choice"" Where id = '" + id + "'"

            Dim cmd As New SqlCommand(cmdString, con)
            Dim adp As New SqlDataAdapter(cmd)

            '寫進dataTable
            adp.Fill(choiceData)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return choiceData

    End Function


    '投票
    Function voting(ByRef id As String, ByRef choice As String)

        '回傳狀態
        Dim status As Boolean = False
        con = New SqlConnection
        con.ConnectionString = connectString

        Dim voter As String = auth.userData.Rows(0).Item("id").ToString

        Try

            con.Open()

            Dim cmdString As String

            cmdString = "Insert into ""Choice""(id,voter,voteTime,choice)
                        Values('" + id + "','" + voter + "','" + Now().ToString + "','" + choice + "')"

            Dim cmd As New SqlCommand(cmdString, con)
            cmd.ExecuteNonQuery()

            status = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return status

    End Function


    '刪除投票
    Function deleteVote(ByRef id As String)

        '回傳狀態
        Dim status As Boolean = False
        con = New SqlConnection
        con.ConnectionString = connectString

        Try

            con.Open()

            Dim cmdString As String

            cmdString = "Delete From ""Vote"" Where id = '" + id + "' Delete From ""Choice"" Where id = '" + id + "'"

            Dim cmd As New SqlCommand(cmdString, con)
            cmd.ExecuteNonQuery()

            status = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return status

    End Function


End Module
