Public Class lstGeneros

    Dim Genero As New Generos

    Private Sub lstGeneros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Genero.GenerosTraerTab(dgvGeneros)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()
    End Sub

    Private Sub dgvGeneros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGeneros.CellDoubleClick
        Editar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvGeneros.Rows.Count <> 0 Then
            Genero.Id = dgvGeneros.Item("id", dgvGeneros.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Genero.GenerosBorrar(Genero.Id) Then
                    MessageBox.Show("El huesped se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Genero.GenerosTraerTab(dgvGeneros)
                Else
                    MessageBox.Show("El huesped no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Editar()
        frmGeneros.Modificar = True
        If dgvGeneros.Rows.Count <> 0 Then
            frmGeneros.IdGeneros = dgvGeneros.Item("Id", dgvGeneros.CurrentRow.Index).Value
            frmGeneros.ShowDialog()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmGeneros.Modificar = False
        frmGeneros.IdGeneros = 0
        frmGeneros.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class