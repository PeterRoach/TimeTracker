<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTasksForm
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
        TasksListView = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        AddButton = New Button()
        EditButton = New Button()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' TasksListView
        ' 
        TasksListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        TasksListView.FullRowSelect = True
        TasksListView.Location = New Point(12, 12)
        TasksListView.Name = "TasksListView"
        TasksListView.Size = New Size(438, 323)
        TasksListView.TabIndex = 0
        TasksListView.UseCompatibleStateImageBehavior = False
        TasksListView.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Width = 0
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Task Description:"
        ColumnHeader2.Width = 415
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(12, 348)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(75, 23)
        AddButton.TabIndex = 1
        AddButton.Text = "&Add New"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(93, 348)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(75, 23)
        EditButton.TabIndex = 2
        EditButton.Text = "&Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(375, 348)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(75, 23)
        CloseButton.TabIndex = 3
        CloseButton.Text = "&Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ViewTasksForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 383)
        Controls.Add(CloseButton)
        Controls.Add(EditButton)
        Controls.Add(AddButton)
        Controls.Add(TasksListView)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ViewTasksForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tasks"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TasksListView As ListView
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
