Public Class votePage


    '投票內容
    Public contentTable As DataTable = New DataTable

    '票匭
    Public choiceTable As DataTable = New DataTable


    '返回鍵
    Private Sub linkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked
        listPage.Show()
        Me.Dispose()
    End Sub


    '動態產生控制項
    Private Sub votePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelRadio.BackColor = System.Drawing.Color.FromArgb(0, PanelRadio.BackColor)


        '身分證
        Dim number As String = auth.userData.Rows(0).Item("id").ToString


        Dim dr() As System.Data.DataRow
        '找有沒有投過票
        dr = choiceTable.Select("voter='" + number + "'")
        '投過的項目序號
        Dim itemIndex As Integer
        If (dr.Length > 0) Then
            Dim itemString As String = dr(0).Item("choice").ToString
            For j = 0 To Split(contentTable.Rows(0).Item("columeTitle").ToString, ";").Length - 1
                If (itemString = Split(contentTable.Rows(0).Item("columeTitle").ToString, ";")(j)) Then
                    itemIndex = j
                End If
            Next
        End If


        '實體化陣列
        Dim lblTitle As Label() = New Label(0) {}
        Dim lblStart As Label() = New Label(0) {}
        Dim lblEnd As Label() = New Label(0) {}

        '標題實體化
        lblTitle(0) = New Label
        Me.Controls.Add(lblTitle(0))
        lblTitle(0).Font = New Font("微軟正黑體", 15)
        lblTitle(0).Width = 350
        lblTitle(0).BackColor = Color.Gray
        lblTitle(0).ForeColor = Color.White
        lblTitle(0).Top = 40
        lblTitle(0).Left = (900 - lblTitle(0).Width) / 2
        lblTitle(0).Text = contentTable.Rows(0).Item("title").ToString
        lblTitle(0).TextAlign = ContentAlignment.MiddleCenter

        '起始時間
        lblStart(0) = New Label
        Me.Controls.Add(lblStart(0))
        lblStart(0).Text = "投票開始時間:" & contentTable.Rows(0).Item("startTime").ToString
        lblStart(0).Font = New Font("微軟正黑體", 8)
        lblStart(0).BackColor = Color.Gray
        lblStart(0).ForeColor = Color.White
        lblStart(0).TextAlign = ContentAlignment.MiddleLeft
        lblStart(0).Top = 40
        lblStart(0).Left = 10
        lblStart(0).Width = 222

        '結束時間
        lblEnd(0) = New Label
        Me.Controls.Add(lblEnd(0))
        lblEnd(0).Text = "投票結束時間:" & contentTable.Rows(0).Item("endTime").ToString
        lblEnd(0).Font = New Font("微軟正黑體", 8)
        lblEnd(0).BackColor = Color.Gray
        lblEnd(0).ForeColor = Color.White
        lblEnd(0).TextAlign = ContentAlignment.MiddleLeft
        lblEnd(0).Top = 70
        lblEnd(0).Left = 10
        lblEnd(0).Width = 222

        '項目數量
        Dim num As Integer = Split(contentTable.Rows(0).Item("columeTitle").ToString, ";").Length

        '實體化陣列
        Dim lblName As Label() = New Label(num - 1) {}
        Dim pbImg As PictureBox() = New PictureBox(num - 1) {}
        Dim lblRemark As Label() = New Label(num - 1) {}
        Dim radioVote As RadioButton() = New RadioButton(num - 1) {}
        Dim lblResult As Label() = New Label(num - 1) {}

        '迴圈個別實體化
        For i = 0 To num - 1

            lblName(i) = New Label
            lblResult(i) = New Label
            pbImg(i) = New PictureBox
            lblRemark(i) = New Label
            radioVote(i) = New RadioButton

            Me.Controls.Add(lblName(i))
            Me.Controls.Add(pbImg(i))
            Me.Controls.Add(lblRemark(i))
            PanelRadio.Controls.Add(radioVote(i))

            '名稱
            lblName(i).Text = Split(contentTable.Rows(0).Item("columeTitle").ToString, ";")(i)
            lblName(i).Font = New Font("微軟正黑體", 12)
            lblName(i).BackColor = Color.Gray
            lblName(i).ForeColor = Color.White
            lblName(i).TextAlign = ContentAlignment.MiddleCenter
            lblName(i).Top = 150
            lblName(i).Width = 125
            Dim intervalName As Double = (900 - (lblName(i).Width) * num) / (num + 1)
            lblName(i).Left = ((i + 1) * intervalName) + (i * lblName(i).Width)


            '照片
            pbImg(i).Image = Image.FromFile(Split(contentTable.Rows(0).Item("columeImage").ToString, ";")(i))
            pbImg(i).SizeMode = PictureBoxSizeMode.AutoSize
            pbImg(i).Top = 180
            Dim intervalImg As Double = (900 - (pbImg(i).Width) * num) / (num + 1)
            pbImg(i).Left = ((i + 1) * intervalImg) + (i * pbImg(i).Width)

            '備註
            lblRemark(i).Text = Split(contentTable.Rows(0).Item("columeRemark").ToString, ";")(i)
            lblRemark(i).Font = New Font("微軟正黑體", 12)
            lblRemark(i).BackColor = Color.Gray
            lblRemark(i).ForeColor = Color.White
            lblRemark(i).Top = 470
            lblRemark(i).Width = 180
            Dim intervalRemark As Double = (900 - (lblRemark(i).Width) * num) / (num + 1)
            lblRemark(i).Left = ((i + 1) * intervalRemark) + (i * lblRemark(i).Width)

            radioVote(i).Text = Split(contentTable.Rows(0).Item("columeTitle").ToString, ";")(i)
            radioVote(i).BackColor = Color.Gray
            radioVote(i).ForeColor = Color.White
            radioVote(i).Font = New Font("微軟正黑體", 12)
            radioVote(i).Width = 125
            Dim intervalRadio As Double = (900 - (radioVote(i).Width) * num) / (num + 1)
            radioVote(i).Left = ((i + 1) * intervalRadio) + (i * radioVote(i).Width)
            radioVote(i).Name = "radio" + i.ToString

            '是否為結果頁面
            If (DateTime.Parse(contentTable.Rows(0).Item("endTime").ToString) > Now()) Then '還在投票中

                If (dr.Length > 0) Then
                    radioVote(i).Enabled = False
                    btnSend.Visible = False
                    If (i = itemIndex) Then
                        radioVote(i).Checked = True
                    End If
                Else
                    radioVote(i).Enabled = True
                    btnSend.Visible = True
                End If

            Else '結算

                '取消radioButton與送出鍵
                radioVote(i).Enabled = False
                btnSend.Visible = False

                '結算票數
                Me.Controls.Add(lblResult(i))
                lblResult(i).Font = New Font("微軟正黑體", 20)
                lblResult(i).BackColor = Color.Gray
                lblResult(i).ForeColor = Color.White
                lblResult(i).TextAlign = ContentAlignment.MiddleCenter
                lblResult(i).Top = 100
                lblResult(i).Width = 100
                lblResult(i).Height = 30
                Dim intervalResult As Double = (900 - (lblResult(i).Width) * num) / (num + 1)
                lblResult(i).Left = ((i + 1) * intervalResult) + (i * lblResult(i).Width)

                If (i = itemIndex) Then
                    radioVote(i).Checked = True
                End If

                Dim choices() As System.Data.DataRow
                '票數計算
                choices = choiceTable.Select("choice='" + Split(contentTable.Rows(0).Item("columeTitle").ToString, ";")(i) + "'")
                lblResult(i).Text = choices.Length.ToString + " 票"

            End If

        Next

    End Sub


    '送出投票
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim objRadio As Object

        Dim selecting As Integer = -1

        For i = 0 To Split(contentTable.Rows(0).Item("columeTitle").ToString, ";").Length - 1
            objRadio = PanelRadio.Controls.Find("radio" + i.ToString, True).First
            If (objRadio.checked = True) Then
                selecting = i
            End If
        Next

        If (selecting = -1) Then
            MessageBox.Show("請做出你的選擇!")
        Else

            '投票中
            If (DateTime.Parse(contentTable.Rows(0).Item("endTime").ToString) > Now()) Then

                If MsgBox("確定要送出嗎？(送出後將不能更改)", MessageBoxButtons.OKCancel, "確認") = Windows.Forms.DialogResult.OK Then
                    Dim choice As String = Split(contentTable.Rows(0).Item("columeTitle").ToString, ";")(selecting)
                    Dim status As Boolean = vote.voting(contentTable.Rows(0).Item("id").ToString, choice)

                    If (status = True) Then
                        MessageBox.Show("投票成功!")

                        contentTable = vote.loadVoteItem(contentTable.Rows(0).Item("id").ToString)
                        choiceTable = vote.loadChoiceItem(contentTable.Rows(0).Item("id").ToString)

                        Me.Controls.Clear()
                        InitializeComponent()
                        votePage_Load(e, e)
                    Else
                        MessageBox.Show("投票失敗!")
                    End If

                End If
            Else
                MessageBox.Show("投票已結束!")

                contentTable = vote.loadVoteItem(contentTable.Rows(0).Item("id").ToString)
                choiceTable = vote.loadChoiceItem(contentTable.Rows(0).Item("id").ToString)

                Me.Controls.Clear()
                InitializeComponent()
                votePage_Load(e, e)
            End If


        End If

    End Sub



End Class