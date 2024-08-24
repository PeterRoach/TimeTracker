Public Class ClockEntry

	Public Property Id As Integer

	Public Property UserId As Integer

	Public Property StartTime As Date

	Public Property EndTime As Date

	Public Property Tasks As New List(Of TaskEntry)

	Public ReadOnly Property TaskCount() As Integer
		Get
			Return Tasks.Count
		End Get
	End Property

	Public ReadOnly Property TimeBetweenString() As String
		Get
			If StartTime <> Date.MinValue And EndTime <> Date.MinValue Then
				Dim TimeSpan As TimeSpan = EndTime - StartTime
				Return $"{TimeSpan.Hours} hr {TimeSpan.Minutes} min"
			Else
				Return ""
			End If
		End Get
	End Property

End Class
