<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OKButton = New Button()
        CancelButton = New Button()
        RegisterButton = New Button()
        PictureBox1 = New PictureBox()
        ShowPasswordCheckBox = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(172, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(172, 81)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(174, 44)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(174, 101)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OKButton
        ' 
        OKButton.Location = New Point(197, 177)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(94, 23)
        OKButton.TabIndex = 4
        OKButton.Text = "&OK"
        ' 
        ' CancelButton
        ' 
        CancelButton.DialogResult = DialogResult.Cancel
        CancelButton.Location = New Point(300, 177)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(94, 23)
        CancelButton.TabIndex = 5
        CancelButton.Text = "&Cancel"
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(300, 230)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(94, 23)
        RegisterButton.TabIndex = 6
        RegisterButton.Text = "&Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' ShowPasswordCheckBox
        ' 
        ShowPasswordCheckBox.AutoSize = True
        ShowPasswordCheckBox.Location = New Point(286, 130)
        ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        ShowPasswordCheckBox.Size = New Size(108, 19)
        ShowPasswordCheckBox.TabIndex = 8
        ShowPasswordCheckBox.Text = "Show Password"
        ShowPasswordCheckBox.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AcceptButton = OKButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(402, 264)
        Controls.Add(ShowPasswordCheckBox)
        Controls.Add(PictureBox1)
        Controls.Add(RegisterButton)
        Controls.Add(CancelButton)
        Controls.Add(OKButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox

End Class
