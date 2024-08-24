Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        'Authenticate user

        'Get username and password from form
        Dim Username$ = Me.UsernameTextBox.Text
        Dim Password$ = Me.PasswordTextBox.Text

        'Check username and password were entered
        If Len(Username) = 0 Or Len(Password) = 0 Then

            MessageBox.Show("Must enter username and password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            'Check if username exists
            Dim Usercount%

            If Not DatabaseHelper.CountUsername(Username, Usercount) Then

                MessageBox.Show("An unexpected error occurred attempting login.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                If Usercount = 0 Then

                    MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    'Get hash and salt
                    Dim PasswordHash$ = vbNullString
                    Dim PasswordSalt$ = vbNullString

                    If Not DatabaseHelper.SelectUserPasswordData(Username, PasswordHash, PasswordSalt) Then

                        MessageBox.Show("An unexpected error occurred attempting login.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Else

                        'Compare hashes
                        If Not HashHelper.VerifyPassword(Password, PasswordSalt, PasswordHash) Then

                            MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Else

                            'Get user info

                            Dim CustomIdentity As CustomIdentity = Nothing

                            If Not DatabaseHelper.SelectUserData(Username, CustomIdentity) Then

                                MessageBox.Show("An unexpected error occurred retrieving user data.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                            Else

                                Dim CustomPrincipal As New CustomPrincipal(CustomIdentity)

                                My.User.CurrentPrincipal = CustomPrincipal

                                Dim MainForm As New MainForm()

                                MainForm.Show()

                                Me.Close()

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim RegisterForm As New RegisterForm()

        RegisterForm.Show()

        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.Close()

    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged

        Me.PasswordTextBox.PasswordChar = If(Me.ShowPasswordCheckBox.Checked, "", "*")

    End Sub
End Class
