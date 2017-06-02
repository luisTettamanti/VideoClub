Imports System.Data
Imports System.Data.SqlClient
Public Class Actores
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


    Public Function TraerTabActores(ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("TraerTabActores", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Cerrar()
    End Function

    Public Function InsertarActores(ByVal Actores As Actores) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("ActoresInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Nombre", Actores.nombre)

            If objComando.ExecuteNonQuery() Then

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


    Public Function BorrarActores(ByVal idActores As Integer) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("ActoresBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", idActores)
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

    Public Function RecuperarActores(ByVal idActores As Integer) As Actores

        Try
            Abrir()
            Dim Actores As New Actores
            Dim objComando As New SqlCommand("ActoresRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdActores", idActores)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Actores.id = objDataTable.Rows(0).Item("Id")
                Actores.nombre = objDataTable.Rows(0).Item("Nombre")

                Return Actores
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function ModificarActores(ByVal Actores As Actores) As Boolean

        Try
            Abrir()
            Dim objComando As New SqlCommand("ActoresModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Id", Actores.id)
            objComando.Parameters.AddWithValue("@Nombre", Actores.nombre)


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
