<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class votePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(votePage))
        Me.linkBack = New System.Windows.Forms.LinkLabel()
        Me.PanelRadio = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'linkBack
        '
        Me.linkBack.AutoSize = True
        Me.linkBack.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkBack.Location = New System.Drawing.Point(815, 31)
        Me.linkBack.Name = "linkBack"
        Me.linkBack.Size = New System.Drawing.Size(41, 20)
        Me.linkBack.TabIndex = 0
        Me.linkBack.TabStop = True
        Me.linkBack.Text = "返回"
        '
        'PanelRadio
        '
        Me.PanelRadio.Location = New System.Drawing.Point(0, 582)
        Me.PanelRadio.Name = "PanelRadio"
        Me.PanelRadio.Size = New System.Drawing.Size(884, 67)
        Me.PanelRadio.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnSend.Location = New System.Drawing.Point(702, 23)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(73, 34)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "送出"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'votePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.voteVB.My.Resources.Resources.backgroud_900x700_
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.PanelRadio)
        Me.Controls.Add(Me.linkBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "votePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "votePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents linkBack As LinkLabel
    Friend WithEvents PanelRadio As Panel
    Friend WithEvents btnSend As Button
End Class
