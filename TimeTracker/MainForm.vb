Public Class MainForm

    Private ClockEntries As New List(Of ClockEntry)
    Private CurrentClockEntry As ClockEntry
    Private CurrentIndex As Integer

    Public Sub RefreshClockEntryListView()

        Dim CE As ClockEntry

        Me.ClockEntryListView.Items.Clear()

        For Each CE In ClockEntries
            Me.ClockEntryListView.Items.Add(New ListViewItem({CE.Id, CE.StartTime, If(CE.EndTime = Date.MinValue, "", CE.EndTime), CE.TimeBetweenString, CE.TaskCount}))
        Next CE

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim MyIdentity As CustomIdentity = DirectCast(My.User.CurrentPrincipal.Identity, CustomIdentity)

        Me.DigitalClock.Start()

        Me.UsernameLabel.Text = $"{MyIdentity.FirstName} {MyIdentity.LastName} ({MyIdentity.Name})"

        Me.ClockInButton.Enabled = True
        Me.ClockOutButton.Enabled = False

        If Not DatabaseHelper.SelectClockEntries(MyIdentity.UserId, Me.ClockEntries) Then

            MessageBox.Show("An unexpected error occurred retrieving clock entries.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            RefreshClockEntryListView()

        End If

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If CurrentClockEntry IsNot Nothing Then

            If Me.CurrentClockEntry.EndTime = Date.MinValue Then

                If Not DatabaseHelper.UpdateClockEntryEndTime(CurrentClockEntry, Now) Then

                    MessageBox.Show("An unexpected error occurred while updating clock entry end time.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

                'No need to refresh ClockEntryListView because form is closing

            End If

        End If

    End Sub

    Private Sub ClockInButton_Click(sender As Object, e As EventArgs) Handles ClockInButton.Click

        Dim MyIdentity As CustomIdentity = DirectCast(My.User.CurrentPrincipal.Identity, CustomIdentity)

        Dim ClockEntry As New ClockEntry With {
            .UserId = MyIdentity.UserId,
            .StartTime = Now
        }

        If Not DatabaseHelper.InsertClockEntry(ClockEntry) Then

            MessageBox.Show("An unexpected error occurred while adding clock entry.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            CurrentClockEntry = ClockEntry
            CurrentIndex = Me.ClockEntryListView.Items.Add(
                New ListViewItem({ClockEntry.Id, ClockEntry.StartTime, "", ClockEntry.TimeBetweenString, ClockEntry.TaskCount})).Index

            Me.ClockEntries.Add(ClockEntry)

            Me.ClockOutButton.Enabled = True
            Me.ClockInButton.Enabled = False

        End If

    End Sub

    Private Sub ClockOutButton_Click(sender As Object, e As EventArgs) Handles ClockOutButton.Click

        Dim EndTime As Date = Now

        If Not UpdateClockEntryEndTime(Me.CurrentClockEntry, EndTime) Then

            MessageBox.Show("An unexpected error occurred while updating clock entry end time.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Me.ClockEntryListView.Items(CurrentIndex).SubItems(2).Text = Me.CurrentClockEntry.EndTime
            Me.ClockEntryListView.Items(CurrentIndex).SubItems(3).Text = Me.CurrentClockEntry.TimeBetweenString

            Me.CurrentClockEntry = Nothing
            Me.CurrentIndex = -1

            Me.ClockInButton.Enabled = True
            Me.ClockOutButton.Enabled = False

        End If

    End Sub

    Private Sub TasksButton_Click(sender As Object, e As EventArgs) Handles TasksButton.Click

        If Me.ClockEntryListView.SelectedItems.Count = 0 Then

            MessageBox.Show("Must select a clock entry.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim SelectedId% = CInt(Me.ClockEntryListView.SelectedItems(0).SubItems(0).Text)

            Dim ClockEntry As ClockEntry = Me.ClockEntries.Find(Function(c) c.Id = SelectedId)

            Dim ViewTasksForm As New ViewTasksForm(ClockEntry)

            ViewTasksForm.ShowDialog()

        End If

    End Sub

End Class