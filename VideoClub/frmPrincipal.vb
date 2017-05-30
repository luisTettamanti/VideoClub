Public Class frmPrincipal

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        lstClientes.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        lstProveedores.ShowDialog()
    End Sub

    Private Sub TítulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TítulosToolStripMenuItem.Click
        lstTitulos.ShowDialog()
    End Sub

    Private Sub ActoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActoresToolStripMenuItem.Click
        lstActores.ShowDialog()
    End Sub

    Private Sub GénerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GénerosToolStripMenuItem.Click
        lstGeneros.ShowDialog()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadosToolStripMenuItem.Click
        lstEstados.ShowDialog()
    End Sub
End Class
