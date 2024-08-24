Imports System.Text.RegularExpressions

Public Class RegisterForm

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click

        Dim IsValid As Boolean = True

        'Parse form
        Dim Username$ = Me.UsernameTextBox.Text
        Dim FirstName$ = Me.FirstNameTextBox.Text
        Dim LastName$ = Me.LastNameTextBox.Text
        Dim Email$ = Me.EmailTextBox.Text
        Dim Password1$ = Me.PasswordTextBox.Text
        Dim Password2$ = Me.ConfirmPasswordTextBox.Text

        'Verify fields are filled out
        If Len(Username) = 0 Or Len(FirstName) = 0 Or Len(LastName) = 0 Or Len(Email) = 0 Or Len(Password1) = 0 Or Len(Password2) = 0 Then

            IsValid = False

            MessageBox.Show("Must fill out all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'Check if email is valid
            If Not Regex.IsMatch(Email, ".+\@.+\..+") Then

                IsValid = False

                MessageBox.Show("Must enter a valid email address.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            'Check if passwords match
            If Password1 <> Password2 Then

                IsValid = False

                MessageBox.Show("Passwords must match.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            'Check if password meets complexity requirements
            If Not Regex.IsMatch(Password1, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$") Then

                IsValid = False

                MessageBox.Show("Password must be at least 8 characters long, contain 1 uppercase letter, 1 lowercase letter, 1 number, and 1 special character.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            If IsValid Then

                'Check if username already exists
                Dim Usercount%

                If Not DatabaseHelper.CountUsername(Username, Usercount) Then

                    MessageBox.Show("An unexpected error occurred checking availability of username.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    If UserCount <> 0 Then

                        MessageBox.Show("Username is already registered.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Else

                        'Generate salt and hash password
                        Dim PasswordSalt$ = HashHelper.GenerateSalt()
                        Dim PasswordHash$ = HashHelper.HashPassword(Password1, PasswordSalt)

                        'Register user
                        If Not DatabaseHelper.RegisterUser(Username, FirstName, LastName, Email, PasswordHash, PasswordSalt) Then

                            MessageBox.Show("An unexpected error occurred while registering user.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Else

                            MessageBox.Show("User registered.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Dim LoginForm As New LoginForm()

                            LoginForm.Show()

                            Me.Close()

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Dim LoginForm As New LoginForm()

        LoginForm.Show()

        Me.Close()

    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged

        Me.PasswordTextBox.PasswordChar = If(Me.ShowPasswordCheckBox.Checked, "", "*")

        Me.ConfirmPasswordTextBox.PasswordChar = If(Me.ShowPasswordCheckBox.Checked, "", "*")

    End Sub

End Class