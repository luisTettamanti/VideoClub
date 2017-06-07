<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitulo
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
        Me.components = New System.ComponentModel.Container
        Me.txtDirector = New System.Windows.Forms.TextBox
        Me.lblDirector = New System.Windows.Forms.Label
        Me.txtIdActor = New System.Windows.Forms.TextBox
        Me.lblIdActor = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.txtVolumen = New System.Windows.Forms.TextBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtIdGenero = New System.Windows.Forms.TextBox
        Me.txtAño = New System.Windows.Forms.TextBox
        Me.lblVolumen = New System.Windows.Forms.Label
        Me.lblIdGenero = New System.Windows.Forms.Label
        Me.lblAño = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvActores = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAgregarActor = New System.Windows.Forms.Button
        Me.btnBorrarActor = New System.Windows.Forms.Button
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(114, 181)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(129, 20)
        Me.txtDirector.TabIndex = 22
        Me.txtDirector.Tag = "*"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.BackColor = System.Drawing.Color.Transparent
        Me.lblDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(11, 184)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(56, 13)
        Me.lblDirector.TabIndex = 27
        Me.lblDirector.Text = "Director:"
        '
        'txtIdActor
        '
        Me.txtIdActor.Location = New System.Drawing.Point(114, 77)
        Me.txtIdActor.Name = "txtIdActor"
        Me.txtIdActor.Size = New System.Drawing.Size(129, 20)
        Me.txtIdActor.TabIndex = 15
        Me.txtIdActor.Tag = "*"
        '
        'lblIdActor
        '
        Me.lblIdActor.AutoSize = True
        Me.lblIdActor.BackColor = System.Drawing.Color.Transparent
        Me.lblIdActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdActor.Location = New System.Drawing.Point(11, 80)
        Me.lblIdActor.Name = "lblIdActor"
        Me.lblIdActor.Size = New System.Drawing.Size(52, 13)
        Me.lblIdActor.TabIndex = 26
        Me.lblIdActor.Text = "IdActor:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(11, 28)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 13)
        Me.lblId.TabIndex = 13
        Me.lblId.Text = "Id:"
        '
        'txtVolumen
        '
        Me.txtVolumen.Location = New System.Drawing.Point(114, 155)
        Me.txtVolumen.Name = "txtVolumen"
        Me.txtVolumen.Size = New System.Drawing.Size(129, 20)
        Me.txtVolumen.TabIndex = 21
        Me.txtVolumen.Tag = "*"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(167, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 103)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 17
        Me.txtNombre.Tag = "*"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(114, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(59, 20)
        Me.txtId.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(86, 404)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(11, 106)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre:"
        '
        'txtIdGenero
        '
        Me.txtIdGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdGenero.Location = New System.Drawing.Point(114, 51)
        Me.txtIdGenero.Name = "txtIdGenero"
        Me.txtIdGenero.Size = New System.Drawing.Size(171, 20)
        Me.txtIdGenero.TabIndex = 12
        Me.txtIdGenero.Tag = "*"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(114, 129)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(129, 20)
        Me.txtAño.TabIndex = 19
        Me.txtAño.Tag = ""
        '
        'lblVolumen
        '
        Me.lblVolumen.AutoSize = True
        Me.lblVolumen.BackColor = System.Drawing.Color.Transparent
        Me.lblVolumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumen.Location = New System.Drawing.Point(11, 158)
        Me.lblVolumen.Name = "lblVolumen"
        Me.lblVolumen.Size = New System.Drawing.Size(59, 13)
        Me.lblVolumen.TabIndex = 18
        Me.lblVolumen.Text = "Volumen:"
        '
        'lblIdGenero
        '
        Me.lblIdGenero.AutoSize = True
        Me.lblIdGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblIdGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGenero.Location = New System.Drawing.Point(11, 54)
        Me.lblIdGenero.Name = "lblIdGenero"
        Me.lblIdGenero.Size = New System.Drawing.Size(63, 13)
        Me.lblIdGenero.TabIndex = 16
        Me.lblIdGenero.Text = "IdGenero:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.BackColor = System.Drawing.Color.Transparent
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(12, 132)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(33, 13)
        Me.lblAño.TabIndex = 20
        Me.lblAño.Text = "Año:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dgvActores
        '
        Me.dgvActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActores.Location = New System.Drawing.Point(12, 229)
        Me.dgvActores.Name = "dgvActores"
        Me.dgvActores.Size = New System.Drawing.Size(272, 156)
        Me.dgvActores.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Actores"
        '
        'btnAgregarActor
        '
        Me.btnAgregarActor.Location = New System.Drawing.Point(290, 229)
        Me.btnAgregarActor.Name = "btnAgregarActor"
        Me.btnAgregarActor.Size = New System.Drawing.Size(56, 23)
        Me.btnAgregarActor.TabIndex = 30
        Me.btnAgregarActor.Text = "Agregar"
        Me.btnAgregarActor.UseVisualStyleBackColor = True
        '
        'btnBorrarActor
        '
        Me.btnBorrarActor.Location = New System.Drawing.Point(290, 258)
        Me.btnBorrarActor.Name = "btnBorrarActor"
        Me.btnBorrarActor.Size = New System.Drawing.Size(56, 23)
        Me.btnBorrarActor.TabIndex = 31
        Me.btnBorrarActor.Text = "Borrar"
        Me.btnBorrarActor.UseVisualStyleBackColor = True
        '
        'frmTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 439)
        Me.Controls.Add(Me.btnBorrarActor)
        Me.Controls.Add(Me.btnAgregarActor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvActores)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.txtIdActor)
        Me.Controls.Add(Me.lblIdActor)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtVolumen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtIdGenero)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.lblVolumen)
        Me.Controls.Add(Me.lblIdGenero)
        Me.Controls.Add(Me.lblAño)
        Me.Name = "frmTitulo"
        Me.Text = "frmTitulos"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDirector As System.Windows.Forms.TextBox
    Friend WithEvents lblDirector As System.Windows.Forms.Label
    Friend WithEvents txtIdActor As System.Windows.Forms.TextBox
    Friend WithEvents lblIdActor As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtVolumen As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtIdGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents lblVolumen As System.Windows.Forms.Label
    Friend WithEvents lblIdGenero As System.Windows.Forms.Label
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvActores As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrarActor As System.Windows.Forms.Button
    Friend WithEvents btnAgregarActor As System.Windows.Forms.Button
End Class
