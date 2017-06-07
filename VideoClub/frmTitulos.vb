Public Class frmTitulo
    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property

    Private idTitulo_ As Integer
    Public Property idTitulo() As Integer
        Get
            Return idTitulo_
        End Get
        Set(ByVal value As Integer)
            idTitulo_ = value
        End Set
    End Property

    Dim Titulo As New Titulos
    Private Sub frmTitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ErrorProvider1.Clear()

        If modificar = True Then
            Me.Text = "Modificar Titulo"

            Titulo = Titulo.TituloRecuperar(idTitulo)

            txtId.Text = Titulo.id
            txtIdGenero.Text = Titulo.idGenero
            txtIdActor.Text = Titulo.idActor
            txtNombre.Text = Titulo.nombre
            txtAño.Text = Titulo.año
            txtVolumen.Text = Titulo.volumen
            txtDirector.Text = Titulo.director

            Titulo.TituloCargarActores(Titulo.id,dgvActores)

        Else
            Me.Text = "Agregar Titulo"

            txtId.Text = Nothing
            txtIdGenero.Text = Nothing
            txtIdActor.Text = Nothing
            txtNombre.Text = Nothing
            txtAño.Text = Nothing
            txtVolumen.Text = Nothing
            txtDirector.Text = Nothing
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        Titulo.idGenero = txtIdGenero.Text
        Titulo.idActor = txtIdActor.Text
        Titulo.nombre = txtNombre.Text
        Titulo.año = txtAño.Text
        Titulo.volumen = txtVolumen.Text
        Titulo.director = txtDirector.Text

        If modificar = True Then
            If Titulo.TituloModificar(Titulo) = True Then
                MsgBox("El Titulo ha sido correctamente modificado.")
                Titulo.TituloTraerTab(lstTitulos.dgvTitulo)
            Else
                MsgBox("Error al modificar el Titulo." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If Titulo.TituloInsertar(Titulo) = True Then
                MsgBox("El Titulo ha sido correctamente insertado.")
                Titulo.TituloTraerTab(lstTitulos.dgvTitulo)
            Else
                MsgBox("Error al insertar Titulo." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If
        Close()


    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Close()

    End Sub


End Class