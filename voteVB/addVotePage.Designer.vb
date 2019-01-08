<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addVotePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addVotePage))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.linkBack = New System.Windows.Forms.LinkLabel()
        Me.linkCreate = New System.Windows.Forms.LinkLabel()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTitle.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(154, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(90, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "投票標題:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(250, 31)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(164, 35)
        Me.txtTitle.TabIndex = 1
        '
        'linkBack
        '
        Me.linkBack.AutoSize = True
        Me.linkBack.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkBack.Location = New System.Drawing.Point(811, 466)
        Me.linkBack.Name = "linkBack"
        Me.linkBack.Size = New System.Drawing.Size(41, 20)
        Me.linkBack.TabIndex = 2
        Me.linkBack.TabStop = True
        Me.linkBack.Text = "返回"
        '
        'linkCreate
        '
        Me.linkCreate.AutoSize = True
        Me.linkCreate.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkCreate.Location = New System.Drawing.Point(739, 466)
        Me.linkCreate.Name = "linkCreate"
        Me.linkCreate.Size = New System.Drawing.Size(41, 20)
        Me.linkCreate.TabIndex = 3
        Me.linkCreate.TabStop = True
        Me.linkCreate.Text = "建立"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(601, 19)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(124, 22)
        Me.dtpStart.TabIndex = 4
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblStart.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblStart.Location = New System.Drawing.Point(477, 21)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(109, 20)
        Me.lblStart.TabIndex = 5
        Me.lblStart.Text = "投票開始時間:"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnd.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(477, 51)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(109, 20)
        Me.lblEnd.TabIndex = 6
        Me.lblEnd.Text = "投票結束時間:"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(601, 49)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(124, 22)
        Me.dtpEnd.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblName.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 88)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 24)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "項目名稱:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblPosition.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(12, 172)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(90, 24)
        Me.lblPosition.TabIndex = 9
        Me.lblPosition.Text = "圖片路徑:"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblRemark.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRemark.Location = New System.Drawing.Point(12, 250)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(86, 24)
        Me.lblRemark.TabIndex = 10
        Me.lblRemark.Text = "項目備註"
        '
        'addVotePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.voteVB.My.Resources.Resources.backgroud
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.linkCreate)
        Me.Controls.Add(Me.linkBack)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addVotePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addVotePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents linkBack As LinkLabel
    Friend WithEvents linkCreate As LinkLabel
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblRemark As Label
End Class
