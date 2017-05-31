Imports System.Data
Imports System.Data.SqlClient

Public Class Clientes

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


    Private nombre_ As String
    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property


    Private dni_ As Integer
    Public Property dni() As Integer
        Get
            Return dni_
        End Get
        Set(ByVal value As Integer)
            dni_ = value
        End Set
    End Property



    Private localidad_ As String
    Public Property localidad() As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property


    Private direccion_ As String
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property


    Private telefono_ As String
    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value
        End Set
    End Property

    Public Function TraerTabClientes(ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("ClienteTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Dni").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Cerrar()
    End Function

    Public Function InsertarCliente(ByVal cliente As Clientes) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("ClienteInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Nombre", cliente.nombre)
            objComando.Parameters.AddWithValue("@Dni", cliente.dni)
            objComando.Parameters.AddWithValue("@Localidad", cliente.localidad)
            objComando.Parameters.AddWithValue("@Direccion", cliente.direccion)
            objComando.Parameters.AddWithValue("@Telefono", cliente.telefono)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrar()
        End Try
    End Function


    Public Function BorrarCliente(ByVal idCliente As Integer) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("ClienteBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCliente", idCliente)
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

    Public Function RecuperarCliente(ByVal idCliente As Integer) As Clientes

        Try
            Abrir()
            Dim cliente As New Clientes
            Dim objComando As New SqlCommand("ClienteRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCliente", idCliente)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                cliente.id = objDataTable.Rows(0).Item("Id")
                cliente.nombre = objDataTable.Rows(0).Item("Nombre")
                cliente.dni = objDataTable.Rows(0).Item("Dni")
                cliente.localidad = objDataTable.Rows(0).Item("Localidad")
                cliente.direccion = objDataTable.Rows(0).Item("Direccion")
                cliente.telefono = objDataTable.Rows(0).Item("Telefono")
                Return cliente
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function ModificarCliente(ByVal cliente As Clientes) As Boolean

        Try
            Abrir()
            Dim objComando As New SqlCommand("ClienteModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Nombre", cliente.nombre)
            objComando.Parameters.AddWithValue("@Dni", cliente.dni)
            objComando.Parameters.AddWithValue("@Localidad", cliente.localidad)
            objComando.Parameters.AddWithValue("@Direccion", cliente.direccion)
            objComando.Parameters.AddWithValue("@Telefono", cliente.telefono)
            objComando.Parameters.AddWithValue("@IdCliente", cliente.id)
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
