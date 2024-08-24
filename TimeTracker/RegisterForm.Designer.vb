<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        UsernameTextBox = New TextBox()
        UsernameLabel = New Label()
        FirstNameLabel = New Label()
        FirstNameTextBox = New TextBox()
        LastNameLabel = New Label()
        LastNameTextBox = New TextBox()
        EmailLabel = New Label()
        EmailTextBox = New TextBox()
        PasswordLabel = New Label()
        PasswordTextBox = New TextBox()
        ConfirmPasswordLabel = New Label()
        ConfirmPasswordTextBox = New TextBox()
        Register = New Button()
        Cancel = New Button()
        PictureBox1 = New PictureBox()
        ShowPasswordCheckBox = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(174, 27)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 0
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New Point(174, 9)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(63, 15)
        UsernameLabel.TabIndex = 4
        UsernameLabel.Text = "&User name"
        ' 
        ' FirstNameLabel
        ' 
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New Point(174, 54)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New Size(64, 15)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "&First Name"
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(174, 72)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(220, 23)
        FirstNameTextBox.TabIndex = 5
        ' 
        ' LastNameLabel
        ' 
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New Point(174, 100)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New Size(63, 15)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "&Last Name"
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(174, 118)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(220, 23)
        LastNameTextBox.TabIndex = 7
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(174, 148)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(36, 15)
        EmailLabel.TabIndex = 10
        EmailLabel.Text = "&Email"
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(174, 166)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(220, 23)
        EmailTextBox.TabIndex = 9
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New Point(174, 232)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(57, 15)
        PasswordLabel.TabIndex = 12
        PasswordLabel.Text = "&Password"
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(174, 250)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 11
        ' 
        ' ConfirmPasswordLabel
        ' 
        ConfirmPasswordLabel.AutoSize = True
        ConfirmPasswordLabel.Location = New Point(174, 281)
        ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        ConfirmPasswordLabel.Size = New Size(104, 15)
        ConfirmPasswordLabel.TabIndex = 14
        ConfirmPasswordLabel.Text = "Confirm Pass&word"
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.Location = New Point(174, 299)
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.PasswordChar = "*"c
        ConfirmPasswordTextBox.Size = New Size(220, 23)
        ConfirmPasswordTextBox.TabIndex = 13
        ' 
        ' Register
        ' 
        Register.Location = New Point(174, 380)
        Register.Name = "Register"
        Register.Size = New Size(94, 23)
        Register.TabIndex = 16
        Register.Text = "&Register"
        Register.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.Location = New Point(300, 380)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 17
        Cancel.Text = "&Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' ShowPasswordCheckBox
        ' 
        ShowPasswordCheckBox.AutoSize = True
        ShowPasswordCheckBox.Location = New Point(285, 332)
        ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        ShowPasswordCheckBox.Size = New Size(108, 19)
        ShowPasswordCheckBox.TabIndex = 19
        ShowPasswordCheckBox.Text = "Show Password"
        ShowPasswordCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(405, 417)
        Controls.Add(ShowPasswordCheckBox)
        Controls.Add(PictureBox1)
        Controls.Add(Cancel)
        Controls.Add(Register)
        Controls.Add(ConfirmPasswordLabel)
        Controls.Add(ConfirmPasswordTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(PasswordTextBox)
        Controls.Add(EmailLabel)
        Controls.Add(EmailTextBox)
        Controls.Add(LastNameLabel)
        Controls.Add(LastNameTextBox)
        Controls.Add(FirstNameLabel)
        Controls.Add(FirstNameTextBox)
        Controls.Add(UsernameLabel)
        Controls.Add(UsernameTextBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordLabel As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShowPasswordCheckBox As CheckBox
End Class
