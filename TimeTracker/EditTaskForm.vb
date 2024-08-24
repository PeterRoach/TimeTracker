Public Class EditTaskForm

    Private ClockEntry As ClockEntry
    Private TaskEntry As TaskEntry

    Public Sub New(ClockEntry As ClockEntry, TaskEntry As TaskEntry)

        InitializeComponent() 'This call is required by the designer.

        Me.ClockEntry = ClockEntry
        Me.TaskEntry = TaskEntry

    End Sub

    Private Sub EditTaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TaskDescriptionTextBox.Text = Me.TaskEntry.TaskDescription

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim TaskDescription$ = Me.TaskDescriptionTextBox.Text

        If Len(TaskDescription) = 0 Then

            MessageBox.Show("Must enter task description.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            If Not DatabaseHelper.UpdateTaskEntry(Me.TaskEntry, TaskDescription) Then

                MessageBox.Show("An unexpected error occurred while updating task description.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                DirectCast(My.Application.OpenForms("ViewTasksForm"), ViewTasksForm).RefreshTasksListView()

                Me.Close()

            End If

        End If

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If MessageBox.Show("Are you sure you want to delete task?", "",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If Not DatabaseHelper.DeleteTaskEntry(Me.TaskEntry) Then

                MessageBox.Show("An unexpected error occurred while deleting task entry.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                Me.ClockEntry.Tasks.Remove(Me.TaskEntry)

                DirectCast(My.Application.OpenForms("ViewTasksForm"), ViewTasksForm).RefreshTasksListView()

                DirectCast(My.Application.OpenForms("MainForm"), MainForm).RefreshClockEntryListView()

                Me.Close()

            End If

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        Me.Close()

    End Sub

End Class