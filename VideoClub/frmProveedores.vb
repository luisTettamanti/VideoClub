Public Class frmProveedores

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value

        End Set
    End Property


    Private idProveedor_ As Integer
    Public Property idProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property

    Dim Proveedor As New Proveedor

    Private Sub frmProveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If modificar = True Then

            Proveedor = Proveedor.RecuperarProveedor(idProveedor)
            txtId.Text = Proveedor.id
            txtNombre.Text = Proveedor.Nombre
            txtCuit.Text = Proveedor.Cuit
            txtDireccion.Text = Proveedor.Direccion
            txtTelefono.Text = Proveedor.Telefono
            txtTelefono.Text = Proveedor.RazonSocial
            txtLocalidad.Text = Proveedor.Localidad
            Me.Text = "Modificar Proveedor"

        Else
            txtId.Text = Nothing
            txtNombre.Text = Nothing
            txtCuit.Text = Nothing
            txtDireccion.Text = Nothing
            txtTelefono.Text = Nothing
            txtRazonSocial.Text = Nothing
            txtLocalidad.Text = Nothing
            Me.Text = "Agregar Proveedor"

        End If
    End Sub

    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Proveedor.Nombre = txtNombre.Text
        Proveedor.Cuit = txtCuit.Text
        Proveedor.Direccion = txtDireccion.Text
        Proveedor.Telefono = txtTelefono.Text
        Proveedor.RazonSocial = txtRazonSocial.Text
        Proveedor.Localidad = txtLocalidad.Text

        If modificar = True Then
            If Proveedor.ModificarProveedor(Proveedor) = True Then
                MsgBox("El proveedor ha sido correctamente modificado.")
                Proveedor.traertabProveedor(lstProveedores.dgvProveedores)
            Else
                MsgBox("Error al modificar el proveedor." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If Proveedor.InsertarProveedor(Proveedor) = True Then
                MsgBox("El proveedor ha sido correctamente insertado.")
                Proveedor.traertabProveedor(lstProveedores.dgvProveedores)
            Else
                MsgBox("Error al insertar proveedor." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If
        Close()

        MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")

    End Sub

    Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()

    End Sub

End Class