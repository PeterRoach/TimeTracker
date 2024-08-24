Public Class ViewTasksForm

    Private ClockEntry As ClockEntry

    Public Sub New(ClockEntry As ClockEntry)

        InitializeComponent() 'This call is required by the designer.

        Me.ClockEntry = ClockEntry

    End Sub

    Public Sub RefreshTasksListView()

        Dim TE As TaskEntry

        Me.TasksListView.Items.Clear()

        For Each TE In ClockEntry.Tasks
            Me.TasksListView.Items.Add(New ListViewItem({TE.Id, TE.TaskDescription}))
        Next TE

    End Sub

    Private Sub ViewTasksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshTasksListView()

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim AddTaskForm As New AddTaskForm(Me.ClockEntry)

        AddTaskForm.ShowDialog()

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If Me.TasksListView.SelectedItems.Count = 0 Then

            MessageBox.Show("Must select a task to edit.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim SelectedId% = CInt(Me.TasksListView.SelectedItems(0).SubItems(0).Text)

            Dim TaskEntry As TaskEntry = Me.ClockEntry.Tasks.Find(Function(a) a.Id = SelectedId)

            Dim EditTaskForm As New EditTaskForm(Me.ClockEntry, TaskEntry)

            EditTaskForm.ShowDialog()

        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

End Class