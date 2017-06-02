Public Class lstTitulos
    Dim Titulo As New Titulos
    Private Sub lstTitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Titulo.TituloTraerTab(dgvTitulo)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Editar()

    End Sub

    Private Sub dgvTitulo_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTitulo.CellDoubleClick

        Editar()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If dgvTitulo.Rows.Count <> 0 Then
            Titulo.id = dgvTitulo.Item("id", dgvTitulo.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Titulo.TituloBorrar(Titulo.id) Then
                    MessageBox.Show("El Titulo se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Titulo.TituloTraerTab(dgvTitulo)
                Else
                    MessageBox.Show("El Titulo no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub Editar()
        frmTitulo.modificar = True
        If dgvTitulo.Rows.Count <> 0 Then
            frmTitulo.idTitulo = dgvTitulo.Item("id", dgvTitulo.CurrentRow.Index).Value
            frmTitulo.ShowDialog()
            'Else          
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmTitulo.modificar = False
        frmTitulo.idTitulo = 0
        frmTitulo.ShowDialog()
    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub
End Class