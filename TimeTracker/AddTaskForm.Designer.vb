<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTaskForm
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
        AddButton = New Button()
        CancelButton = New Button()
        TaskDescriptionTextBox = New TextBox()
        TaskDescriptionLabel = New Label()
        SuspendLayout()
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(356, 83)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(75, 23)
        AddButton.TabIndex = 0
        AddButton.Text = "&Add Task"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(356, 112)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 1
        CancelButton.Text = "&Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' TaskDescriptionTextBox
        ' 
        TaskDescriptionTextBox.Location = New Point(12, 41)
        TaskDescriptionTextBox.Name = "TaskDescriptionTextBox"
        TaskDescriptionTextBox.Size = New Size(419, 23)
        TaskDescriptionTextBox.TabIndex = 2
        ' 
        ' TaskDescriptionLabel
        ' 
        TaskDescriptionLabel.AutoSize = True
        TaskDescriptionLabel.Location = New Point(12, 13)
        TaskDescriptionLabel.Name = "TaskDescriptionLabel"
        TaskDescriptionLabel.Size = New Size(125, 15)
        TaskDescriptionLabel.TabIndex = 3
        TaskDescriptionLabel.Text = "&Enter Task Description:"
        ' 
        ' AddTaskForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 147)
        Controls.Add(TaskDescriptionLabel)
        Controls.Add(TaskDescriptionTextBox)
        Controls.Add(CancelButton)
        Controls.Add(AddButton)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddTaskForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Task"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TaskDescriptionTextBox As TextBox
    Friend WithEvents TaskDescriptionLabel As Label
End Class
