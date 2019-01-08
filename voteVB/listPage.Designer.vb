<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listPage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listPage))
        Me.btnAddVote = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddVote
        '
        Me.btnAddVote.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAddVote.Location = New System.Drawing.Point(707, 26)
        Me.btnAddVote.Name = "btnAddVote"
        Me.btnAddVote.Size = New System.Drawing.Size(136, 33)
        Me.btnAddVote.TabIndex = 0
        Me.btnAddVote.Text = "建立投票"
        Me.btnAddVote.UseVisualStyleBackColor = True
        '
        'btnSignOut
        '
        Me.btnSignOut.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(707, 440)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(136, 33)
        Me.btnSignOut.TabIndex = 1
        Me.btnSignOut.Text = "登出"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnReload.Location = New System.Drawing.Point(707, 390)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(136, 33)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Text = "重新整理"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'listPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.voteVB.My.Resources.Resources.backgroud
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.btnAddVote)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "listPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddVote As Button
    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnReload As Button
End Class
