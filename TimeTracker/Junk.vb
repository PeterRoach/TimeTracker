Module Junk

    Public Sub GetInput()

        Dim TaskDescription As String = vbNullString

        Do While Len(TaskDescription) = 0

            TaskDescription = InputBox("Enter Task Description:", " ", vbCr)

            If TaskDescription = vbCr Then

                MessageBox.Show("Must enter task description.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf TaskDescription = "" Then

                Exit Do

            End If

        Loop

        If Len(TaskDescription) > 0 Then

            MessageBox.Show(TaskDescription)

        End If

    End Sub


End Module
