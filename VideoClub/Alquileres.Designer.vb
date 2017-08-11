<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquileres
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.flpContenedor = New System.Windows.Forms.FlowLayoutPanel
        Me.flpHabitacion = New System.Windows.Forms.FlowLayoutPanel
        Me.flpContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpContenedor
        '
        Me.flpContenedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContenedor.AutoScroll = True
        Me.flpContenedor.Controls.Add(Me.flpHabitacion)
        Me.flpContenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpContenedor.Location = New System.Drawing.Point(13, 12)
        Me.flpContenedor.Name = "flpContenedor"
        Me.flpContenedor.Size = New System.Drawing.Size(595, 323)
        Me.flpContenedor.TabIndex = 1
        '
        'flpHabitacion
        '
        Me.flpHabitacion.Location = New System.Drawing.Point(3, 3)
        Me.flpHabitacion.Name = "flpHabitacion"
        Me.flpHabitacion.Size = New System.Drawing.Size(591, 37)
        Me.flpHabitacion.TabIndex = 0
        '
        'Alquileres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 391)
        Me.Controls.Add(Me.flpContenedor)
        Me.Name = "Alquileres"
        Me.Text = "Alquileres"
        Me.flpContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpContenedor As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpHabitacion As System.Windows.Forms.FlowLayoutPanel
End Class
