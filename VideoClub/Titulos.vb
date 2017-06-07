Imports System.Data
Imports System.Data.SqlClient

Public Class Titulos

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


    Private idGenero_ As Integer
    Public Property idGenero() As Integer
        Get
            Return idGenero_
        End Get
        Set(ByVal value As Integer)
            idGenero_ = value
        End Set
    End Property

    Private idActor_ As Integer
    Public Property idActor() As Integer
        Get
            Return idActor_
        End Get
        Set(ByVal value As Integer)
            idActor_ = value
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


    Private año_ As Integer
    Public Property año() As Integer
        Get
            Return año_
        End Get
        Set(ByVal value As Integer)
            año_ = value
        End Set
    End Property


    Private volumen_ As String
    Public Property volumen() As String
        Get
            Return volumen_
        End Get
        Set(ByVal value As String)
            volumen_ = value
        End Set
    End Property

    Private director_ As String
    Public Property director() As String
        Get
            Return director_
        End Get
        Set(ByVal value As String)
            director_ = value
        End Set
    End Property
    Public Sub TituloTraerTab(ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("TituloTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("idGenero").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("idActor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Año").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Volumen").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Director").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Cerrar()

    End Sub
    Public Function TituloInsertar(ByVal Titulo As Titulos) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("TituloInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idGenero", Titulo.idGenero)
            objComando.Parameters.AddWithValue("@idActor", Titulo.idActor)
            objComando.Parameters.AddWithValue("@nombre", Titulo.nombre)
            objComando.Parameters.AddWithValue("@año", Titulo.año)
            objComando.Parameters.AddWithValue("@Volumen", Titulo.volumen)
            objComando.Parameters.AddWithValue("@Director", Titulo.director)
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


    Public Function TituloBorrar(ByVal idTitulo As Integer) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("TituloBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTitulo", idTitulo)
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

    Public Function TituloRecuperar(ByVal idTitulo As Integer) As Titulos

        Try
            Abrir()
            Dim Titulo As New Titulos
            Dim objComando As New SqlCommand("TituloRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTitulo", idTitulo)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Titulo.id = objDataTable.Rows(0).Item("Id")
                Titulo.idGenero = objDataTable.Rows(0).Item("IdGenero")
                Titulo.idActor = objDataTable.Rows(0).Item("IdActor")
                Titulo.nombre = objDataTable.Rows(0).Item("Nombre")
                Titulo.año = objDataTable.Rows(0).Item("Año")
                Titulo.nombre = objDataTable.Rows(0).Item("Nombre")
                Titulo.volumen = objDataTable.Rows(0).Item("Volumen")
                Titulo.director = objDataTable.Rows(0).Item("Director")

                Return Titulo
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function TituloModificar(ByVal Titulo As Titulos) As Boolean

        Try
            Abrir()
            Dim objComando As New SqlCommand("TituloModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idGenero", Titulo.idGenero)
            objComando.Parameters.AddWithValue("@idActor", Titulo.idActor)
            objComando.Parameters.AddWithValue("@nombre", Titulo.nombre)
            objComando.Parameters.AddWithValue("@año", Titulo.año)
            objComando.Parameters.AddWithValue("@volumen", Titulo.volumen)
            objComando.Parameters.AddWithValue("@director", Titulo.director)
            objComando.Parameters.AddWithValue("@Id", Titulo.id)
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

    Public Sub TituloCargarActores(ByVal idTitulo As Integer, ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("TituloCargarActores", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@idTitulo", idTitulo)

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable
        tabla.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cerrar()
    End Sub
End Class