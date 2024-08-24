Public Class AddTaskForm

    Private ClockEntry As ClockEntry

    Public Sub New(ClockEntry As ClockEntry)

        InitializeComponent() 'This call is required by the designer.

        Me.ClockEntry = ClockEntry

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim TaskDescription$ = Me.TaskDescriptionTextBox.Text

        If Len(Trim(TaskDescription)) = 0 Then

            MessageBox.Show("Must enter task description.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim TaskEntry As New TaskEntry With {
                .ClockEntryId = Me.ClockEntry.Id,
                .TaskDescription = TaskDescription
            }

            If Not DatabaseHelper.InsertTaskEntry(TaskEntry) Then

                MessageBox.Show("An unexpected error occurred while adding a task entry.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Me.ClockEntry.Tasks.Add(TaskEntry)

                DirectCast(My.Application.OpenForms.Item("ViewTasksForm"), ViewTasksForm).RefreshTasksListView()

                DirectCast(My.Application.OpenForms.Item("MainForm"), MainForm).RefreshClockEntryListView()

                Me.Close()

            End If

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        Me.Close()

    End Sub

End Class