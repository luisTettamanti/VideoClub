Public Class frmGeneros
    Private Modificar_ As Boolean
    Public Property Modificar() As Boolean
        Get
            Return Modificar_
        End Get
        Set(ByVal value As Boolean)
            Modificar_ = value
        End Set
    End Property

    Private IdGeneros_ As Integer
    Public Property IdGeneros() As Integer
        Get
            Return IdGeneros_
        End Get
        Set(ByVal value As Integer)
            IdGeneros_ = value
        End Set
    End Property

    Dim Genero As New Generos
   
    Private Sub frmGeneros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Modificar = True Then
            Me.Text = "Modificar Generos"

            Genero = Genero.GenerosRecuperar(IdGeneros)

            txtId.Text = Genero.Id
            txtDescripción.Text = Genero.Descripción

        Else
            Me.Text = "Agregar Huesped"

            txtId.Text = Nothing
            txtDescripción.Text = Nothing

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Genero.Descripción = txtDescripción.Text

        If Modificar = True Then
            If Genero.GenerosModificar(Genero) = True Then
                MsgBox("El cliente ha sido correctamente modificado.")
                Genero.GenerosTraerTab(lstGeneros.dgvGeneros)
            Else
                MsgBox("Error al modificar el cliente." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If Genero.GenerosInsertar(Genero) = True Then
                MsgBox("El cliente ha sido correctamente insertado.")
                Genero.GenerosTraerTab(lstGeneros.dgvGeneros)
            Else
                MsgBox("Error al insertar cliente." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
End Class