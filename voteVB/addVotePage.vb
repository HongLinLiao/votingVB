Public Class addVotePage

    '項目數量
    Public num As Integer


    '動態產生控制項
    Private Sub addVotePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'panel背景為透明
        'panelAdd.BackColor = System.Drawing.Color.FromArgb(0, panelAdd.BackColor)



        '實體化控制項陣列(i-1個)
        Dim nameBoxArray As TextBox() = New TextBox(num - 1) {}
        Dim positionBoxArray As TextBox() = New TextBox(num - 1) {}
        Dim remarkBoxArray As TextBox() = New TextBox(num - 1) {}

        '間隔寬度
        Dim intervalName As Double
        Dim intervalPosition As Double
        Dim intervalRemark As Double

        '用迴圈逐個實體化控制項
        Dim j As Integer = 0
        While j <> num

            nameBoxArray(j) = New TextBox()
            positionBoxArray(j) = New TextBox()
            remarkBoxArray(j) = New TextBox()
            Me.Controls.Add(nameBoxArray(j))
            Me.Controls.Add(positionBoxArray(j))
            Me.Controls.Add(remarkBoxArray(j))

            '定出控制項間隔
            intervalName = (900 - (nameBoxArray(j).Width * num)) / (num + 1)
            intervalPosition = (900 - (positionBoxArray(j).Width * num)) / (num + 1)
            remarkBoxArray(j).Width = remarkBoxArray(j).Width + 50 '備註加寬
            remarkBoxArray(j).Multiline = True
            remarkBoxArray(j).Height = remarkBoxArray(j).Width
            intervalRemark = (900 - (remarkBoxArray(j).Width * num)) / (num + 1)

            '項目名稱
            nameBoxArray(j).Name = "columeName" + (j + 1).ToString
            nameBoxArray(j).Left = j * nameBoxArray(j).Width + (j + 1) * intervalName '平均分配水平寬度
            nameBoxArray(j).Top = 130

            '圖片路徑
            positionBoxArray(j).Name = "columePosition" + (j + 1).ToString
            positionBoxArray(j).Left = j * positionBoxArray(j).Width + (j + 1) * intervalPosition '平均分配水平寬度
            positionBoxArray(j).Top = 210

            '備註
            remarkBoxArray(j).Name = "columeRemark" + (j + 1).ToString
            remarkBoxArray(j).Left = j * remarkBoxArray(j).Width + (j + 1) * intervalRemark '平均分配水平寬度
            remarkBoxArray(j).Top = 290

            j = j + 1

        End While


    End Sub


    '返回列表頁面
    Private Sub linkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked

        listPage.Show()
        Me.Dispose()

    End Sub


    '建立投票
    Private Sub linkCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreate.LinkClicked

        '控制項物件
        Dim objName As Object
        Dim objPosition As Object
        Dim objRemark As Object

        '輸出字串
        Dim columeName As String = ""
        Dim columePosition As String = ""
        Dim columeRemark As String = ""
        Dim startTime As String = dtpStart.Value.ToString
        Dim endTime As String = dtpEnd.Value.ToString
        Dim title As String = txtTitle.Text


        '用迴圈去取每個控制項的值
        For i = 1 To num

            objName = Me.Controls.Find("columeName" + i.ToString, True).First '項目標題
            objPosition = Me.Controls.Find("columePosition" + i.ToString, True).First '圖片路徑
            objRemark = Me.Controls.Find("columeRemark" + i.ToString, True).First '備註

            If (i = num) Then

                columeName = columeName + objName.Text
                columePosition = columePosition + objPosition.Text
                columeRemark = columeRemark + objRemark.Text

            Else

                columeName = columeName + objName.Text + ";"
                columePosition = columePosition + objPosition.Text + ";"
                columeRemark = columeRemark + objRemark.Text + ";"

            End If

            '圖片處理
            Dim ch As String() = New String() {"\"} '切割字元
            Dim split2 As String() = objPosition.Text.Split(ch, StringSplitOptions.RemoveEmptyEntries) '切割後的陣列
            Dim fileName As String = split2(split2.Length - 1) '檔案名稱
            '複製檔案
            FileCopy(objPosition.Text, "C:\Users\Leo\Desktop\voteVB\voteVB\src\img\fileUpload\" + fileName)

        Next

        Dim status As Boolean = vote.addVote(title, startTime, endTime, columeName, columePosition, columeRemark)

        If (status = True) Then
            MessageBox.Show("建立成功!")
            listPage.Show()
            Me.Dispose()
        Else
            MessageBox.Show("建立失敗!")
        End If


    End Sub

End Class


'取值
'Dim obj As Object = Me.Controls.Find("columeTitle1", True).First
'MessageBox.Show(obj.Text)


'Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
'    '1.建立Button物件

'    Dim btuArray As Button() = New Button(2) {}      '建立按鈕矩陣並將矩陣實體化
'    Dim i As Integer = 0


'    '2. 加入控制項
'    While i <> btuArray.Length
'        btuArray(i) = New Button()                '以迴圈逐個實體化按鈕
'        Me.Controls.Add(btuArray(i))             '加入按鈕 （Controls用法請參照延伸閱讀）
'        btuArray(i).Text = "Dynamic " & i
'        btuArray(i).Top = 12 + btuArray(i).Height * i         '按鈕生成垂直座標
'        btuArray(i).Left = 13                                           '按鈕生成水平座標

'        '3. 為Click事件註冊

'        AddHandler btuArray(i).Click, AddressOf button_Click
'        'button_Click即為按鍵矩陣將要執行的程式

'        i += 1

'    End While

'End Sub

'Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)

'    textBox1.Text = "你按下: " & DirectCast((sender), Button).Text
'    '使用DirectCast((sender), Button).Text 將自動偵測被按下之按鍵的text
'    '請於此處寫入需要執行的功能
'End Sub