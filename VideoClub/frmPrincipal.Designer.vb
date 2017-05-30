<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TítulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GénerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ToolStripSeparator1, Me.TítulosToolStripMenuItem, Me.ActoresToolStripMenuItem, Me.GénerosToolStripMenuItem, Me.ToolStripSeparator2, Me.EstadosToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'TítulosToolStripMenuItem
        '
        Me.TítulosToolStripMenuItem.Name = "TítulosToolStripMenuItem"
        Me.TítulosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TítulosToolStripMenuItem.Text = "Títulos"
        '
        'ActoresToolStripMenuItem
        '
        Me.ActoresToolStripMenuItem.Name = "ActoresToolStripMenuItem"
        Me.ActoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActoresToolStripMenuItem.Text = "Actores"
        '
        'GénerosToolStripMenuItem
        '
        Me.GénerosToolStripMenuItem.Name = "GénerosToolStripMenuItem"
        Me.GénerosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GénerosToolStripMenuItem.Text = "Géneros"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "VideoClub"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TítulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GénerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
