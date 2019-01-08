Public Class welcomePage

    Private Sub timeWelcome_Tick(sender As Object, e As EventArgs) Handles timeWelcome.Tick

        timeWelcome.Enabled = False
        typePage.Show() '此方法會吃記憶體,form量較多時,建議使用MDI
        Me.Hide()

    End Sub

    Private Sub welcomePage_Load(sender As Object, e As EventArgs) Handles Me.Load

        timeWelcome.Interval = 3000 '預設單位為毫秒
        timeWelcome.Enabled = True '開啟倒數

    End Sub
End Class
