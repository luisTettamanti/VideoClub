Public Class Reservas
    Inherits Button
    Private id_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private Sub Reservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        MessageBox.Show("Esta es la reserva: " + Str(id))
    End Sub

End Class
