Imports System.Security.Principal

Public Class CustomIdentity
    Implements IIdentity

    Private _Name$
    Private _Email$
    Private _AuthenticationType$
    Private _IsAuthenticated As Boolean
    Private _Roles$()
    Private _FirstName$
    Private _LastName$
    Private _UserId%

    Public Sub New(Name$, Email$, AuthenticationType$, IsAuthenticated As Boolean, Roles$(), FirstName$, LastName$, UserId%)
        _Name = Name
        _Email = Email
        _AuthenticationType = AuthenticationType
        _IsAuthenticated = IsAuthenticated
        _Roles = Roles
        _FirstName = FirstName
        _LastName = LastName
        _UserId = UserId
    End Sub

    Public ReadOnly Property AuthenticationType As String Implements IIdentity.AuthenticationType
        Get
            Return _AuthenticationType
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements IIdentity.IsAuthenticated
        Get
            Return _IsAuthenticated
        End Get
    End Property

    Public ReadOnly Property Name As String Implements IIdentity.Name
        Get
            Return _Name
        End Get
    End Property

    Public ReadOnly Property Roles As String()
        Get
            Return _Roles
        End Get
    End Property

    Public ReadOnly Property Email As String
        Get
            Return _Email
        End Get
    End Property

    Public ReadOnly Property FirstName As String
        Get
            Return _FirstName
        End Get
    End Property

    Public ReadOnly Property LastName As String
        Get
            Return _LastName
        End Get
    End Property

    Public ReadOnly Property UserId As Integer
        Get
            Return _UserId
        End Get
    End Property

End Class
