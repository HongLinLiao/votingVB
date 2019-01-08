Imports System.Data
Imports System.Data.SqlClient

Public Class typePage

    Public type As loginPage

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

        loginPage.lblType.Text = "Admin"

        '註冊鈕不顯示
        loginPage.linkSignUp.Visible = False

        loginPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click

        loginPage.lblType.Text = "Client"

        '註冊鈕顯示
        loginPage.linkSignUp.Visible = True

        loginPage.Show()
        Me.Hide()

    End Sub

End Class