<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPage))
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.linkBack = New System.Windows.Forms.LinkLabel()
        Me.lblPointId = New System.Windows.Forms.Label()
        Me.lblPointBirth = New System.Windows.Forms.Label()
        Me.linkSignUp = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblType.Font = New System.Drawing.Font("微軟正黑體", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblType.Location = New System.Drawing.Point(381, 68)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(124, 42)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Sign In"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblId.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblId.Location = New System.Drawing.Point(218, 185)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(155, 34)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "ID number:"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblBirth.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBirth.Location = New System.Drawing.Point(292, 259)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(81, 34)
        Me.lblBirth.TabIndex = 3
        Me.lblBirth.Text = "Birth:"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtId.Location = New System.Drawing.Point(388, 185)
        Me.txtId.MaxLength = 10
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtId.Size = New System.Drawing.Size(177, 34)
        Me.txtId.TabIndex = 4
        '
        'txtBirth
        '
        Me.txtBirth.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtBirth.Location = New System.Drawing.Point(388, 259)
        Me.txtBirth.MaxLength = 8
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(177, 34)
        Me.txtBirth.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(388, 377)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 39)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'linkBack
        '
        Me.linkBack.AutoSize = True
        Me.linkBack.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkBack.Location = New System.Drawing.Point(693, 400)
        Me.linkBack.Name = "linkBack"
        Me.linkBack.Size = New System.Drawing.Size(34, 16)
        Me.linkBack.TabIndex = 7
        Me.linkBack.TabStop = True
        Me.linkBack.Text = "Back"
        '
        'lblPointId
        '
        Me.lblPointId.AutoSize = True
        Me.lblPointId.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblPointId.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPointId.ForeColor = System.Drawing.Color.Red
        Me.lblPointId.Location = New System.Drawing.Point(571, 203)
        Me.lblPointId.Name = "lblPointId"
        Me.lblPointId.Size = New System.Drawing.Size(96, 16)
        Me.lblPointId.TabIndex = 8
        Me.lblPointId.Text = "ex:H000000000"
        '
        'lblPointBirth
        '
        Me.lblPointBirth.AutoSize = True
        Me.lblPointBirth.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblPointBirth.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPointBirth.ForeColor = System.Drawing.Color.Red
        Me.lblPointBirth.Location = New System.Drawing.Point(571, 277)
        Me.lblPointBirth.Name = "lblPointBirth"
        Me.lblPointBirth.Size = New System.Drawing.Size(80, 16)
        Me.lblPointBirth.TabIndex = 9
        Me.lblPointBirth.Text = "ex:20190101"
        '
        'linkSignUp
        '
        Me.linkSignUp.AutoSize = True
        Me.linkSignUp.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linkSignUp.Location = New System.Drawing.Point(504, 400)
        Me.linkSignUp.Name = "linkSignUp"
        Me.linkSignUp.Size = New System.Drawing.Size(53, 16)
        Me.linkSignUp.TabIndex = 10
        Me.linkSignUp.TabStop = True
        Me.linkSignUp.Text = "Sign Up"
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.voteVB.My.Resources.Resources.backgroud
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.linkSignUp)
        Me.Controls.Add(Me.lblPointBirth)
        Me.Controls.Add(Me.lblPointId)
        Me.Controls.Add(Me.linkBack)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblType As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents linkBack As LinkLabel
    Friend WithEvents lblPointId As Label
    Friend WithEvents lblPointBirth As Label
    Friend WithEvents linkSignUp As LinkLabel
End Class
