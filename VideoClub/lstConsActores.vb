Public Class lstConsActores

    Private idTitulo_ As Integer

    Public Property idTitulo() As Integer
        Get
            Return idTitulo_
        End Get
        Set(ByVal value As Integer)
            idTitulo_ = value
        End Set
    End Property

    Dim actor As New Actores
    Dim titulo As New Titulos

    Private Sub lstConsActores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actor.TraerTabActores(dgvActor)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        actor.id = dgvActor.Item("id", dgvActor.CurrentRow.Index).Value
        titulo.TituloActorInsertar(idTitulo, actor.id)
        titulo.TituloCargarActores(idTitulo, frmTitulo.dgvActores)
        Close()
    End Sub
End Class