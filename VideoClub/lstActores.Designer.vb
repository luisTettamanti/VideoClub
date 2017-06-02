<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstActores
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
        Me.dgvActores = New System.Windows.Forms.DataGridView
        Me.InsertarActores = New System.Windows.Forms.Button
        Me.ModificarActores = New System.Windows.Forms.Button
        Me.BorrarActores = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvActores
        '
        Me.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActores.Location = New System.Drawing.Point(25, 13)
        Me.dgvActores.Name = "dgvActores"
        Me.dgvActores.Size = New System.Drawing.Size(538, 150)
        Me.dgvActores.TabIndex = 0
        '
        'InsertarActores
        '
        Me.InsertarActores.Location = New System.Drawing.Point(25, 186)
        Me.InsertarActores.Name = "InsertarActores"
        Me.InsertarActores.Size = New System.Drawing.Size(75, 23)
        Me.InsertarActores.TabIndex = 1
        Me.InsertarActores.Text = "Agregar"
        Me.InsertarActores.UseVisualStyleBackColor = True
        '
        'ModificarActores
        '
        Me.ModificarActores.Location = New System.Drawing.Point(106, 186)
        Me.ModificarActores.Name = "ModificarActores"
        Me.ModificarActores.Size = New System.Drawing.Size(75, 23)
        Me.ModificarActores.TabIndex = 2
        Me.ModificarActores.Text = "Modificar"
        Me.ModificarActores.UseVisualStyleBackColor = True
        '
        'BorrarActores
        '
        Me.BorrarActores.Location = New System.Drawing.Point(187, 186)
        Me.BorrarActores.Name = "BorrarActores"
        Me.BorrarActores.Size = New System.Drawing.Size(75, 23)
        Me.BorrarActores.TabIndex = 3
        Me.BorrarActores.Text = "Eliminar"
        Me.BorrarActores.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(487, 185)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'lstActores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 238)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.BorrarActores)
        Me.Controls.Add(Me.ModificarActores)
        Me.Controls.Add(Me.InsertarActores)
        Me.Controls.Add(Me.dgvActores)
        Me.Name = "lstActores"
        Me.Text = "Listado de Actores"
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvActores As System.Windows.Forms.DataGridView
    Friend WithEvents InsertarActores As System.Windows.Forms.Button
    Friend WithEvents ModificarActores As System.Windows.Forms.Button
    Friend WithEvents BorrarActores As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
End Class
