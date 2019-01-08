

Public Class loginPage

    '回登入模式頁
    Private Sub linkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked
        typePage.Show()
        Me.Dispose()
    End Sub

    '登入
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtId.Text.Length <> 10) Then
            MessageBox.Show("請輸入正確的身分證字號格式!")
        ElseIf (txtBirth.Text.Length <> 8) Then
            MessageBox.Show("請輸入正確的生日格式!")
        Else
            Dim loginStatus As Boolean = auth.logIn(lblType.Text, txtId.Text.ToUpper, txtBirth.Text)

            If (loginStatus = True) Then
                'Admin才能新建投票
                If (lblType.Text = "Admin") Then
                    listPage.btnAddVote.Visible = True
                ElseIf (lblType.Text = "Client") Then
                    listPage.btnAddVote.Visible = False
                End If
                listPage.Show()
                Me.Hide()
            End If
        End If

    End Sub

    '註冊
    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked

        Dim signStatus As Boolean = auth.signUp()
        If (signStatus = False) Then
            MessageBox.Show("註冊失敗，請重新註冊!")
        Else
            MessageBox.Show("註冊成功!")
            listPage.btnAddVote.Visible = False
            listPage.Show()
            Me.Hide()
        End If

    End Sub


End Class