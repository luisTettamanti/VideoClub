Public Class lstConsActores

    Private idActor_ As Integer

    Public Property idActor() As Integer
        Get
            Return idActor_
        End Get
        Set(ByVal value As Integer)
            idActor_ = value
        End Set
    End Property

    Dim actor As New Actores

    Private Sub lstConsActores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actor.TraerTabActores(dgvActor)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub
End Class