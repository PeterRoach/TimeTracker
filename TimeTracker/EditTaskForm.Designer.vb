<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTaskForm
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
        TaskDescriptionLabel = New Label()
        TaskDescriptionTextBox = New TextBox()
        CancelButton = New Button()
        SaveButton = New Button()
        DeleteButton = New Button()
        SuspendLayout()
        ' 
        ' TaskDescriptionLabel
        ' 
        TaskDescriptionLabel.AutoSize = True
        TaskDescriptionLabel.Location = New Point(12, 13)
        TaskDescriptionLabel.Name = "TaskDescriptionLabel"
        TaskDescriptionLabel.Size = New Size(118, 15)
        TaskDescriptionLabel.TabIndex = 7
        TaskDescriptionLabel.Text = "&Edit Task Description:"
        ' 
        ' TaskDescriptionTextBox
        ' 
        TaskDescriptionTextBox.Location = New Point(12, 41)
        TaskDescriptionTextBox.Name = "TaskDescriptionTextBox"
        TaskDescriptionTextBox.Size = New Size(419, 23)
        TaskDescriptionTextBox.TabIndex = 6
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(356, 112)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 5
        CancelButton.Text = "&Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(356, 83)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(75, 23)
        SaveButton.TabIndex = 4
        SaveButton.Text = "&Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.LightCoral
        DeleteButton.Location = New Point(275, 112)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(75, 23)
        DeleteButton.TabIndex = 8
        DeleteButton.Text = "&Delete"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' EditTaskForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 147)
        Controls.Add(DeleteButton)
        Controls.Add(TaskDescriptionLabel)
        Controls.Add(TaskDescriptionTextBox)
        Controls.Add(CancelButton)
        Controls.Add(SaveButton)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditTaskForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Task"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TaskDescriptionLabel As Label
    Friend WithEvents TaskDescriptionTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
End Class
