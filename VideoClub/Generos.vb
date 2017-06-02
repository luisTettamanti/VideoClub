Imports System.Data
Imports System.Data.SqlClient

Public Class Generos

    Inherits Conexion
    Private Id_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private Descripción_ As String

    Public Property Descripción() As String
        Get
            Return Descripción_
        End Get
        Set(ByVal value As String)
            Descripción_ = value
        End Set
    End Property

    Public Sub GenerosTraerTab(ByVal tabla As DataGridView)
        Abrir()

        Dim objComando As New SqlCommand("GenerosTraerTab", objConexion)

        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripción").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        
        Cerrar()

    End Sub

    Public Function GenerosInsertar(ByVal Gener As Generos) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("GenerosInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Descripción", Gener.Descripción)
           

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

    Public Function GenerosRecuperar(ByVal IdGeneros As Integer) As Generos

        Try
            Abrir()
            Dim Generos As New Generos
            Dim objComando As New SqlCommand("GenerosRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdGeneros", IdGeneros)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Generos.Id = objDataTable.Rows(0).Item("id")
                Generos.Descripción = objDataTable.Rows(0).Item("Descripción")
                
                Return Generos
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Function

    Public Function GenerosModificar(ByVal Generos As Generos) As Boolean

        Try
            Abrir()

            Dim objComando As New SqlCommand("GenerosModificar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Descripción", Generos.Descripción)
            objComando.Parameters.AddWithValue("@id", Generos.Id)
            
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

    Public Function GenerosBorrar(ByVal IdGeneros As Integer) As Boolean
        Try

            Abrir()

            Dim objComando As New SqlCommand("GenerosBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdGeneros", IdGeneros)
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
