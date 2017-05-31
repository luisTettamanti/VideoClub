Public Class frmCliente

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property


    Private idCliente_ As Integer
    Public Property idCliente() As Integer
        Get
            Return idCliente_
        End Get
        Set(ByVal value As Integer)
            idCliente_ = value
        End Set
    End Property

    Dim cliente As New Clientes

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If modificar = True Then
            Me.Text = "Modificar Cliente"

            cliente = cliente.RecuperarCliente(idCliente)

            txtId.Text = cliente.id
            txtNombre.Text = cliente.nombre
            txtDni.Text = cliente.dni
            txtLocalidad.Text = cliente.localidad
            txtDireccion.Text = cliente.direccion
            txtTelefono.Text = cliente.telefono


        Else
            Me.Text = "Agregar Cliente"

            txtId.Text = Nothing
            txtNombre.Text = Nothing
            txtDni.Text = Nothing
            txtLocalidad.Text = Nothing
            txtDireccion.Text = Nothing
            txtTelefono.Text = Nothing

        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        cliente.nombre = txtNombre.Text
        cliente.dni = txtDni.Text
        cliente.localidad = txtLocalidad.Text
        cliente.direccion = txtDireccion.Text
        cliente.telefono = txtTelefono.Text


        If modificar = True Then
            If cliente.ModificarCliente(cliente) = True Then
                MsgBox("El cliente ha sido correctamente modificado.")
                cliente.TraerTabClientes(lstClientes.dgvCliente)
            Else
                MsgBox("Error al modificar el cliente." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If cliente.InsertarCliente(cliente) = True Then
                MsgBox("El cliente ha sido correctamente insertado.")
                cliente.TraerTabClientes(lstClientes.dgvCliente)
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