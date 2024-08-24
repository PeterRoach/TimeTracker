Imports System.Security.Cryptography

Module HashHelper

    Private Const SaltSize% = 16
    Private Const HashSize% = 20
    Private Const Iterations% = 10000

    Public Function GenerateSalt() As String

        Dim Salt(SaltSize - 1) As Byte

        RandomNumberGenerator.Fill(Salt)

        Return Convert.ToBase64String(Salt)

    End Function

    Public Function HashPassword(Password$, Salt$) As String

        Dim SaltBytes As Byte() = Convert.FromBase64String(Salt)

        Dim PBKDF2 As New Rfc2898DeriveBytes(Password, SaltBytes, Iterations, HashAlgorithmName.SHA256)

        Return Convert.ToBase64String(PBKDF2.GetBytes(HashSize))

    End Function

    Public Function VerifyPassword(Password$, Salt$, Hash$) As Boolean

        Dim HashedPassword As String = HashPassword(Password, Salt)

        Return HashedPassword = Hash

    End Function

End Module
