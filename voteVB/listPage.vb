Public Class listPage

    Public voteTable As DataTable = New DataTable

    '登出按鈕，回到登入模式頁面
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        auth.signOut()
        typePage.Show()
        Me.Dispose()
    End Sub

    '新增投票按鈕，前往新增投票頁面
    Private Sub btnAddVote_Click(sender As Object, e As EventArgs) Handles btnAddVote.Click

        Dim num As String = InputBox("你有幾個投票項目呢?", "項目數量")

        If (num <> "") Then

            If (CInt(num) > 0) Then
                addVotePage.num = CInt(num)
                addVotePage.Show()
                Me.Dispose()
            End If

        End If

    End Sub

    '動態產生列表
    Private Sub listPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '暱稱標籤
        Dim lblNickName As Label() = New Label(0) {}
        lblNickName(0) = New Label()
        Me.Controls.Add(lblNickName(0))
        lblNickName(0).Text = "Hi！ " + auth.userData.Rows(0).Item("name").ToString
        lblNickName(0).BackColor = Color.Gray
        lblNickName(0).ForeColor = Color.White
        lblNickName(0).TextAlign = ContentAlignment.MiddleCenter
        lblNickName(0).Left = 30
        lblNickName(0).Top = 20
        lblNickName(0).Font = New Font("微軟正黑體", "30")
        lblNickName(0).Height = 100
        lblNickName(0).Width = 300

        '讀取投票
        voteTable = vote.loadVote()

        If (voteTable.Rows.Count > 0) Then

            Dim num As Integer = voteTable.Rows.Count

            '實體化陣列
            Dim lblItem As Label() = New Label(num - 1) {}
            Dim btnVote As Button() = New Button(num - 1) {}
            Dim btnDelete As Button() = New Button(num - 1) {}

            '逐個實體化
            For j = 0 To (num - 1)

                lblItem(j) = New Label()
                btnVote(j) = New Button()
                btnDelete(j) = New Button()

                Me.Controls.Add(lblItem(j))
                Me.Controls.Add(btnVote(j))
                Me.Controls.Add(btnDelete(j))

                Dim start As DateTime = DateTime.Parse(voteTable.Rows(j).Item("startTime").ToString)
                Dim ending As DateTime = DateTime.Parse(voteTable.Rows(j).Item("endTime").ToString)

                If (start > Now()) Then
                    lblItem(j).Text = "標題: " + voteTable.Rows(j).Item("title").ToString + "  投票狀態: 未開始(" + voteTable.Rows(j).Item("startTime").ToString + ")"
                    btnVote(j).Enabled = False
                    btnVote(j).Text = "還沒開始唷!"
                    btnDelete(j).Enabled = True
                Else

                    If (ending > Now()) Then
                        lblItem(j).Text = "標題: " + voteTable.Rows(j).Item("title").ToString + "  投票狀態: 投票中"
                        btnVote(j).Enabled = True
                        btnVote(j).Text = "投票!"
                        btnDelete(j).Enabled = False
                    Else
                        lblItem(j).Text = "標題: " + voteTable.Rows(j).Item("title").ToString + "  投票狀態: 已結束"
                        btnVote(j).Enabled = True
                        btnVote(j).Text = "看結果!"
                        btnDelete(j).Enabled = True
                    End If
                End If

                If (j = 0) Then
                    lblItem(j).Top = 150
                    btnVote(j).Top = 150
                    btnDelete(j).Top = 150
                Else
                    lblItem(j).Top = 150 + 10 * (j + 1) + lblItem(j).Height * j
                    btnVote(j).Top = 150 + 10 * (j + 1) + btnVote(j).Height * j
                    btnDelete(j).Top = 150 + 10 * (j + 1) + btnDelete(j).Height * j
                End If


                lblItem(j).Left = 30
                lblItem(j).Width = 400
                lblItem(j).BackColor = Color.Gray
                lblItem(j).ForeColor = Color.White
                lblItem(j).TextAlign = ContentAlignment.MiddleLeft

                btnVote(j).Name = "vote" + j.ToString
                btnVote(j).Left = 450

                btnDelete(j).Name = "delete" + j.ToString
                btnDelete(j).Left = 530
                btnDelete(j).Text = "刪除"

                If (loginPage.lblType.Text = "Admin") Then
                    btnDelete(j).Visible = True
                Else
                    btnDelete(j).Visible = False
                End If

                '註冊事件
                AddHandler btnVote(j).Click, AddressOf button_Click
                AddHandler btnDelete(j).Click, AddressOf button_Click
            Next
        End If

    End Sub

    '投票按鈕事件
    Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim type As String = DirectCast((sender), Button).Name.Substring(0, 1)

        '刪除按鈕
        If (type = "d") Then

            Dim item As Integer = CInt(DirectCast((sender), Button).Name.Substring(6, 1))

            '刪除
            Dim status As Boolean = vote.deleteVote(voteTable.Rows(item).Item("id").ToString)
            If (status = True) Then
                btnReload_Click(e, e) '觸發重整
                MessageBox.Show("刪除成功!")
            Else
                MessageBox.Show("刪除失敗!")
            End If




        Else '投票按鈕

            Dim item As Integer = CInt(DirectCast((sender), Button).Name.Substring(4, 1))

            Dim contentTable As DataTable = vote.loadVoteItem(voteTable.Rows(item).Item("id").ToString)
            Dim choiceTable As DataTable = vote.loadChoiceItem(voteTable.Rows(item).Item("id").ToString)

            '檢查投票還在不在
            If (contentTable.Rows.Count > 0) Then
                Dim start As DateTime = DateTime.Parse(voteTable.Rows(item).Item("startTime").ToString)
                Dim ending As DateTime = DateTime.Parse(voteTable.Rows(item).Item("endTime").ToString)

                votePage.choiceTable = choiceTable
                votePage.contentTable = contentTable
                votePage.Show()
                Me.Dispose()
            Else
                MessageBox.Show("該投票已被刪除!")
                btnReload_Click(e, e) '觸發重整
            End If

        End If

    End Sub

    '重新整理
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

        Me.Controls.Clear()
        InitializeComponent()
        listPage_Load(e, e)

    End Sub

End Class