Public Class frmActores


    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property


    Private idActores_ As Integer
    Public Property idActores() As Integer
        Get
            Return idActores_
        End Get
        Set(ByVal value As Integer)
            idActores_ = value
        End Set
    End Property

    Dim Actores As New Actores

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub frmActores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If modificar = True Then
            Me.Text = "Modificar Actores"

            Actores = Actores.RecuperarActores(idActores)

            txtId.Text = Actores.id
            txtNombre.Text = Actores.nombre


        Else
            Me.Text = "Agregar Actores"

            txtId.Text = Nothing
            txtNombre.Text = Nothing


        End If

    End Sub


    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Actores.nombre = txtNombre.Text


        If modificar = True Then
            If Actores.ModificarActores(Actores) = True Then
                MsgBox("El Actor ha sido correctamente modificado.")
                Actores.TraerTabActores(lstActores.dgvActores)
            Else
                MsgBox("Error al modificar el Actor." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If Actores.InsertarActores(Actores) = True Then
                MsgBox("El Actor ha sido correctamente insertado.")
                Actores.TraerTabActores(lstActores.dgvActores)
            Else
                MsgBox("Error al insertar el Actor." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If
        Close()
    End Sub
End Class
