Public Class lstClientes

    Dim cliente As New Clientes
    Private Sub lstClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cliente.TraerTabClientes(dgvCliente)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()
    End Sub

    Private Sub dgvCliente_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        Editar()
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvCliente.Rows.Count <> 0 Then
            cliente.id = dgvCliente.Item("id", dgvCliente.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If cliente.BorrarCliente(cliente.id) Then
                    MessageBox.Show("El cliente se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cliente.TraerTabClientes(dgvCliente)
                Else
                    MessageBox.Show("El cliente no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub Editar()
        frmCliente.modificar = True
        If dgvCliente.Rows.Count <> 0 Then
            frmCliente.idCliente = dgvCliente.Item("id", dgvCliente.CurrentRow.Index).Value
            frmCliente.ShowDialog()
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmCliente.modificar = False
        frmCliente.idCliente = 0
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class