Public Class Habitaciones
    Inherits FlowLayoutPanel
    Private id_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Sub New()
        Me.Width = 541
        Me.Height = 42
        Me.FlowDirection = Windows.Forms.FlowDirection.LeftToRight
    End Sub
End Class
