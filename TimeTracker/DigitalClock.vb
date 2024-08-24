Public Class DigitalClock

    Public Sub Start()
        Me.Label1.Text = Now
        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = Now
    End Sub
End Class
