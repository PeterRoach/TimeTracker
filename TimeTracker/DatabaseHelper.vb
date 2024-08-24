Imports Microsoft.Data.SqlClient

Module DatabaseHelper

    Public Function InsertClockEntry(ClockEntry As ClockEntry) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspInsertClockEntry"
                    .Parameters.Add("@tt_user_id", SqlDbType.Int).Value = ClockEntry.UserId
                    .Parameters.Add("@start_time", SqlDbType.DateTime2).Value = ClockEntry.StartTime
                    .Parameters.Add("@end_time", SqlDbType.DateTime2).Value = DBNull.Value
                    ClockEntry.Id = CInt(.ExecuteScalar())
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function InsertTaskEntry(TaskEntry As TaskEntry) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspInsertTaskEntry"
                    .Parameters.Add("@clock_entry_id", SqlDbType.Int).Value = TaskEntry.ClockEntryId
                    .Parameters.Add("@task_description", SqlDbType.VarChar, -1).Value = TaskEntry.TaskDescription
                    TaskEntry.Id = CInt(.ExecuteScalar())
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function UpdateClockEntryEndTime(ClockEntry As ClockEntry, EndTime As Date) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspUpdateClockEntryEndTime"
                    .Parameters.Add("@id", SqlDbType.Int).Value = ClockEntry.Id
                    .Parameters.Add("@end_time", SqlDbType.DateTime2).Value = EndTime
                    .ExecuteNonQuery()
                    .Dispose()
                End With

                ClockEntry.EndTime = EndTime

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function UpdateTaskEntry(TaskEntry As TaskEntry, TaskDescription$)

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspUpdateTaskEntryDescription"
                    .Parameters.Add("@id", SqlDbType.Int).Value = TaskEntry.Id
                    .Parameters.Add("@task_description", SqlDbType.VarChar, -1).Value = TaskDescription
                    .ExecuteNonQuery()
                    .Dispose()
                End With

                TaskEntry.TaskDescription = TaskDescription

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function DeleteTaskEntry(TaskEntry As TaskEntry) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspDeleteTaskEntry"
                    .Parameters.Add("@id", SqlDbType.Int).Value = TaskEntry.Id
                    .ExecuteNonQuery()
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function SelectClockEntries(UserId%, ClockEntries As List(Of ClockEntry)) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Dim Command As SqlCommand
                Dim Reader As SqlDataReader
                Dim TaskEntries As New List(Of TaskEntry)
                Dim TE As TaskEntry
                Dim CE As ClockEntry

                Connection.Open()

                'Get task entries
                Command = New SqlCommand()
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspSelectUserTaskEntry"
                    .Parameters.Add("@tt_user_id", SqlDbType.Int).Value = UserId
                    Reader = .ExecuteReader()
                    Do While Reader.Read()
                        TE = New TaskEntry With {
                            .Id = Reader.GetInt32(0),
                            .ClockEntryId = Reader.GetInt32(1),
                            .TaskDescription = Reader.GetString(2)
                        }
                        TaskEntries.Add(TE)
                    Loop
                    Reader.Close()
                    .Dispose()
                End With

                'Get clock entries
                Command = New SqlCommand()
                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspSelectUserClockEntry"
                    .Parameters.Add("@tt_user_id", SqlDbType.Int).Value = UserId
                    Reader = .ExecuteReader()
                    Do While Reader.Read()
                        CE = New ClockEntry With {
                            .Id = Reader.GetInt32(0),
                            .UserId = UserId,
                            .StartTime = Reader.GetDateTime(1)
                        }
                        If Not Reader.IsDBNull(2) Then
                            CE.EndTime = Reader.GetDateTime(2)
                        End If
                        'Add task entries to clock entries
                        For Each TE In TaskEntries
                            If TE.ClockEntryId = CE.Id Then
                                CE.Tasks.Add(TE)
                            End If
                        Next TE
                        ClockEntries.Add(CE)
                    Loop
                    Reader.Close()
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function SelectUserData(Username$, ByRef CustomIdentity As CustomIdentity) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Dim Command As SqlCommand
                Dim Reader As SqlDataReader

                Dim UserId%
                Dim Name$
                Dim FirstName$
                Dim LastName$
                Dim Email$

                Connection.Open()

                Command = New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspSelectUserData"
                    .Parameters.Add("@username", SqlDbType.VarChar, -1).Value = Username
                    Reader = .ExecuteReader()
                    Reader.Read()
                    UserId = Reader.GetInt32(0)
                    Name = Reader.GetString(1)
                    FirstName = Reader.GetString(2)
                    LastName = Reader.GetString(3)
                    Email = Reader.GetString(4)
                    Reader.Close()
                    .Dispose()
                End With

                Dim RoleList As New List(Of String)

                Command = New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspSelectUserRole"
                    .Parameters.Add("@tt_user_id", SqlDbType.Int).Value = UserId
                    Reader = .ExecuteReader()
                    Do While Reader.Read()
                        RoleList.Add(Reader.GetString(2))
                    Loop
                    Reader.Close()
                    .Dispose()
                End With

                CustomIdentity = New CustomIdentity(
                    Name,
                    Email,
                    "Custom",
                    True,
                    RoleList.ToArray(),
                    FirstName,
                    LastName,
                    UserId
                )

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function SelectUserPasswordData(Username$, ByRef PasswordHash$, ByRef PasswordSalt$) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()
                Dim Reader As SqlDataReader

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspSelectUserPasswordData"
                    .Parameters.Add("@username", SqlDbType.VarChar, -1).Value = Username
                    Reader = .ExecuteReader()
                    Reader.Read()
                    PasswordHash = Reader.GetString(0)
                    PasswordSalt = Reader.GetString(1)
                    Reader.Close()
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function CountUsername(Username$, ByRef Usercount%) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)
            Try
                Connection.Open()

                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspCountUsername"
                    .Parameters.Add("@username", SqlDbType.VarChar, -1).Value = Username
                    Usercount = CInt(.ExecuteScalar())
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

    Public Function RegisterUser(Username$, FirstName$, LastName$, Email$, PasswordHash$, PasswordSalt$) As Boolean

        Using Connection As New SqlConnection(Constants.TimeTrackerConnectionString)

            Try
                Connection.Open()

                'Register user
                Dim Command As New SqlCommand()

                With Command
                    .Connection = Connection
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "uspInsertUser"
                    .Parameters.Add("@username", SqlDbType.VarChar, -1).Value = Username
                    .Parameters.Add("@password_hash", SqlDbType.VarChar, -1).Value = PasswordHash
                    .Parameters.Add("@password_salt", SqlDbType.VarChar, -1).Value = PasswordSalt
                    .Parameters.Add("@first_name", SqlDbType.VarChar, -1).Value = FirstName
                    .Parameters.Add("@last_name", SqlDbType.VarChar, -1).Value = LastName
                    .Parameters.Add("@email", SqlDbType.VarChar, -1).Value = Email
                    .ExecuteNonQuery()
                    .Dispose()
                End With

                Return True

            Catch ex As Exception

                Return False

            End Try
        End Using

    End Function

End Module
