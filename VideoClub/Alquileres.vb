Public Class Alquileres

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arReservas() As Integer = {10, 2, 5, 3, 4, 5, 7, 8, 5, 1}
        Dim arHabitaciones() As Integer = {1, 1, 2, 2, 3, 4, 5, 5, 5, 2}
        Dim posX As Integer = 0
        Dim posY As Integer = 0
        Dim tamanio As Integer = 30
        For i = 0 To 9
            Dim btnAlquiler As New Button
            btnAlquiler.Left = posX
            btnAlquiler.Top = posY
            btnAlquiler.Width = arReservas(i) * 10
            btnAlquiler.Show()
            Me.flpHabitacion.Controls.Add(btnAlquiler)
            posY += 20
            tamanio += 30
        Next
    End Sub
End Class