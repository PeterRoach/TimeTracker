<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        DigitalClock = New DigitalClock()
        UsernameLabel = New Label()
        ClockInButton = New Button()
        ClockOutButton = New Button()
        ClockEntryListView = New ListView()
        IdColumnHeader = New ColumnHeader()
        ClockInColumnHeader = New ColumnHeader()
        ClockOutColumnHeader = New ColumnHeader()
        TimeColumnHeader = New ColumnHeader()
        TaskCountColumnHeader = New ColumnHeader()
        TasksButton = New Button()
        SuspendLayout()
        ' 
        ' DigitalClock
        ' 
        DigitalClock.Location = New Point(12, 12)
        DigitalClock.Name = "DigitalClock"
        DigitalClock.Size = New Size(333, 48)
        DigitalClock.TabIndex = 0
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        UsernameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameLabel.Location = New Point(364, 27)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.RightToLeft = RightToLeft.No
        UsernameLabel.Size = New Size(365, 21)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "Username"
        UsernameLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ClockInButton
        ' 
        ClockInButton.Font = New Font("Segoe UI", 12F)
        ClockInButton.Location = New Point(12, 81)
        ClockInButton.Name = "ClockInButton"
        ClockInButton.Size = New Size(126, 42)
        ClockInButton.TabIndex = 3
        ClockInButton.Text = "Clock &In"
        ClockInButton.UseVisualStyleBackColor = True
        ' 
        ' ClockOutButton
        ' 
        ClockOutButton.Font = New Font("Segoe UI", 12F)
        ClockOutButton.Location = New Point(182, 81)
        ClockOutButton.Name = "ClockOutButton"
        ClockOutButton.Size = New Size(126, 42)
        ClockOutButton.TabIndex = 4
        ClockOutButton.Text = "Clock &Out"
        ClockOutButton.UseVisualStyleBackColor = True
        ' 
        ' ClockEntryListView
        ' 
        ClockEntryListView.Columns.AddRange(New ColumnHeader() {IdColumnHeader, ClockInColumnHeader, ClockOutColumnHeader, TimeColumnHeader, TaskCountColumnHeader})
        ClockEntryListView.FullRowSelect = True
        ClockEntryListView.Location = New Point(12, 145)
        ClockEntryListView.Name = "ClockEntryListView"
        ClockEntryListView.Size = New Size(717, 293)
        ClockEntryListView.TabIndex = 5
        ClockEntryListView.UseCompatibleStateImageBehavior = False
        ClockEntryListView.View = View.Details
        ' 
        ' IdColumnHeader
        ' 
        IdColumnHeader.Text = "Id"
        IdColumnHeader.Width = 0
        ' 
        ' ClockInColumnHeader
        ' 
        ClockInColumnHeader.Text = "Clock In"
        ClockInColumnHeader.Width = 190
        ' 
        ' ClockOutColumnHeader
        ' 
        ClockOutColumnHeader.Text = "Clock Out"
        ClockOutColumnHeader.Width = 190
        ' 
        ' TimeColumnHeader
        ' 
        TimeColumnHeader.Text = "Time"
        TimeColumnHeader.Width = 190
        ' 
        ' TaskCountColumnHeader
        ' 
        TaskCountColumnHeader.Text = "Task Count"
        TaskCountColumnHeader.Width = 100
        ' 
        ' TasksButton
        ' 
        TasksButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TasksButton.Location = New Point(654, 100)
        TasksButton.Name = "TasksButton"
        TasksButton.Size = New Size(75, 23)
        TasksButton.TabIndex = 6
        TasksButton.Text = "&View Tasks"
        TasksButton.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 450)
        Controls.Add(TasksButton)
        Controls.Add(ClockEntryListView)
        Controls.Add(ClockOutButton)
        Controls.Add(ClockInButton)
        Controls.Add(UsernameLabel)
        Controls.Add(DigitalClock)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TimeTracker"
        ResumeLayout(False)
    End Sub

    Friend WithEvents DigitalClock As DigitalClock
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents ClockInButton As Button
    Friend WithEvents ClockOutButton As Button
    Friend WithEvents ClockEntryListView As ListView
    Friend WithEvents ClockInColumnHeader As ColumnHeader
    Friend WithEvents ClockOutColumnHeader As ColumnHeader
    Friend WithEvents TaskCountColumnHeader As ColumnHeader
    Friend WithEvents IdColumnHeader As ColumnHeader
    Friend WithEvents TasksButton As Button
    Friend WithEvents TimeColumnHeader As ColumnHeader

End Class
