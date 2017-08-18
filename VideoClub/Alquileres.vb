Public Class Alquileres

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arReservas() As Integer = {10, 2, 5, 3, 4, 5, 7, 8, 5, 1}
        Dim arHabitaciones() As Integer = {1, 1, 2, 2, 3, 4, 5, 5, 5, 2}
        Dim posX As Integer = 0
        Dim posY As Integer = 0
        Dim tamanio As Integer = 30
        Dim btnReserva As Reservas

        Dim flpHabitacion As FlowLayoutPanel
        Dim arflpHabitaciones(10)
        'For i = 0 To 9
        '    flpHabitacion = New FlowLayoutPanel
        '    flpHabitacion.BackColor = Color.Red
        '    flpHabitacion.Width = 591
        '    flpHabitacion.Height = 32
        '    flpHabitacion.FlowDirection = FlowDirection.LeftToRight
        '    arflpHabitaciones(i) = flpHabitacion
        '    flpContenedor.Controls.Add(arflpHabitaciones(i))
        'Next

        For i = 0 To 9
            btnReserva = New Reservas
            btnReserva.id = i
            btnReserva.Left = posX
            btnReserva.Top = posY
            btnReserva.Width = arReservas(i) * 10
            flpContenedor.Controls(arHabitaciones(i)).Controls.Add(btnReserva)
            'flpContenedor.Controls.Add(btnReserva)
            btnReserva.Show()
            posY += 20
        Next
    End Sub

End Class