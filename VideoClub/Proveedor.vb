Imports System.Data
Imports System.Data.SqlClient

Public Class Proveedor
    Inherits Conexion

    Private id_ As Integer
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private Nombre_ As String
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property


    Private Cuit_ As Integer
    Public Property Cuit() As Integer
        Get
            Return Cuit_
        End Get
        Set(ByVal value As Integer)
            Cuit_ = value
        End Set
    End Property


    Private Direccion_ As String
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property


    Private Telefono_ As String
    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set

    End Property

    Private RazonSocial_ As String
    Public Property RazonSocial() As String
        Get
            Return RazonSocial_
        End Get
        Set(ByVal value As String)
            RazonSocial_ = value
        End Set
    End Property

    Private Localidad_ As String
    Public Property Localidad() As String
        Get
            Return Localidad_
        End Get
        Set(ByVal value As String)
            Localidad_ = value
        End Set
    End Property

    Public Sub traertabProveedor(ByVal tabla As DataGridView)
        Abrir()

        Dim objcomando As New SqlCommand("TraerTabProveedor", objConexion)
        objcomando.CommandType = CommandType.StoredProcedure

        Dim objdatatable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objcomando)
        objDataAdapter.Fill(objdatatable)
        tabla.DataSource = objdatatable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Cuit").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("RazonSocial").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Cerrar()

    End Sub

    Public Function RecuperarProveedor(ByVal idproveedor As Integer) As Proveedor
        Try
            Abrir()
            Dim proveedor As New Proveedor
            Dim objcomando As New SqlCommand("RecuperarProveedor", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure
            objcomando.Parameters.AddWithValue("@idProveedor", idproveedor)
            Dim objDataAdapter As New SqlDataAdapter(objcomando)
            Dim objdatatable As New Data.DataTable
            objDataAdapter.Fill(objdatatable)
            If objdatatable.Rows.Count > 0 Then
                objDataAdapter.Fill(objdatatable)
                proveedor.id = objdatatable.Rows(0).Item("id")
                proveedor.Nombre = objdatatable.Rows(0).Item("Nombre")
                proveedor.Cuit = objdatatable.Rows(0).Item("Cuit")
                proveedor.Direccion = objdatatable.Rows(0).Item("Direccion")
                proveedor.Telefono = objdatatable.Rows(0).Item("Telefono")
                proveedor.RazonSocial = objdatatable.Rows(0).Item("RazonSocial")
                proveedor.Localidad = objdatatable.Rows(0).Item("Localidad")

                Return proveedor

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try

    End Function

    Public Function ModificarProveedor(ByVal proveedor As Proveedor) As Boolean

        Try
            Abrir()

            Dim objcomando As New SqlCommand("ModificarProveedor", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure


            objcomando.Parameters.AddWithValue("@Id", proveedor.id)
            objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            objcomando.Parameters.AddWithValue("@Cuit", proveedor.Cuit)
            objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            objcomando.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial)
            objcomando.Parameters.AddWithValue("@Localidad", proveedor.Localidad)

            If objcomando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Finally
        End Try
    End Function

    Public Function InsertarProveedor(ByVal proveedor As Proveedor) As Boolean

        Try
            Abrir()

            Dim objcomando As New SqlCommand("InsertarProveedor", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure

            objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            objcomando.Parameters.AddWithValue("@Cuit", proveedor.Cuit)
            objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            objcomando.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial)
            objcomando.Parameters.AddWithValue("@Localidad", proveedor.Localidad)

            If objcomando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try
    End Function

    Public Function Eliminar(ByVal idProveedor As Integer) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("EliminarProveedor", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdProveedor", idProveedor)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Cerrar()
        End Try

    End Function

End Class
