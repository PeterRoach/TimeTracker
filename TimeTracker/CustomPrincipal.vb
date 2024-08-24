Imports System.Security.Principal

Public Class CustomPrincipal
    Implements IPrincipal

    Private ReadOnly _Identity As IIdentity

    Public Sub New(Identity As IIdentity)
        _Identity = Identity
    End Sub

    Public ReadOnly Property Identity As IIdentity Implements IPrincipal.Identity
        Get
            Return _Identity
        End Get
    End Property

    Public Function IsInRole(role As String) As Boolean Implements IPrincipal.IsInRole
        Return DirectCast(_Identity, CustomIdentity).Roles.Contains(role)
    End Function

End Class
