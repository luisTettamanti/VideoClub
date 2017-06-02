Public Class lstActores
    Dim Actores As New Actores


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub InsertarActores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarActores.Click
        frmActores.modificar = False
        frmActores.idActores = 0
        frmActores.ShowDialog()
    End Sub

    Private Sub ModificarActores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarActores.Click
        Editar()
    End Sub

    Private Sub BorrarActores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarActores.Click
        If dgvActores.Rows.Count <> 0 Then
            Actores.id = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Actores.BorrarActores(Actores.id) Then
                    MessageBox.Show("El Actor se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Actores.TraerTabActores(dgvActores)
                Else
                    MessageBox.Show("El Actor no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub lstActores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Actores.TraerTabActores(dgvActores)


    End Sub

    Private Sub dgvActores_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvActores.CellMouseDoubleClick
        Editar()


    End Sub
    Private Sub Editar()
        frmActores.modificar = True
        If dgvActores.Rows.Count <> 0 Then
            frmActores.idActores = dgvActores.Item("id", dgvActores.CurrentRow.Index).Value
            frmActores.ShowDialog()
        End If
    End Sub
End Class