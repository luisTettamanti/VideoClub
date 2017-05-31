Public Class lstProveedores
    Dim proveedor As New Proveedor

    Private Sub lstProveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        proveedor.traertabProveedor(dgvProveedores)
    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Editar()
    End Sub


    Private Sub dgvProveedores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        Editar()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If dgvProveedores.Rows.Count <> 0 Then
            proveedor.id = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then

                If proveedor.Eliminar(proveedor.id) Then

                    MessageBox.Show("El proveedor se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    proveedor.traertabProveedor(dgvProveedores)
                Else
                    MessageBox.Show("El proveedor no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub Editar()
        frmProveedores.modificar = True
        If dgvProveedores.Rows.Count <> 0 Then
            frmProveedores.idProveedor = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value
            frmProveedores.ShowDialog()
        End If
    End Sub

    Private Sub Agregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Agregar.Click
        frmProveedores.modificar = False
        frmProveedores.idProveedor = 0
        frmProveedores.ShowDialog()
    End Sub

    Private Sub Salir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

End Class