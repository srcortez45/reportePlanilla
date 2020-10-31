<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_consultar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_consultar))
        Me.dg_empleados = New System.Windows.Forms.DataGridView()
        Me.btn_agregarRegistro = New System.Windows.Forms.Button()
        Me.btn_eliminarRegistro = New System.Windows.Forms.Button()
        Me.btn_actualizarRegistro = New System.Windows.Forms.Button()
        Me.btn_planilla = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        CType(Me.dg_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_empleados
        '
        Me.dg_empleados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dg_empleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_empleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_empleados.Location = New System.Drawing.Point(21, 88)
        Me.dg_empleados.Name = "dg_empleados"
        Me.dg_empleados.ReadOnly = True
        Me.dg_empleados.Size = New System.Drawing.Size(856, 279)
        Me.dg_empleados.TabIndex = 3
        '
        'btn_agregarRegistro
        '
        Me.btn_agregarRegistro.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarRegistro.Location = New System.Drawing.Point(21, 406)
        Me.btn_agregarRegistro.Name = "btn_agregarRegistro"
        Me.btn_agregarRegistro.Size = New System.Drawing.Size(150, 70)
        Me.btn_agregarRegistro.TabIndex = 6
        Me.btn_agregarRegistro.Text = "Agregar registro"
        Me.btn_agregarRegistro.UseVisualStyleBackColor = True
        '
        'btn_eliminarRegistro
        '
        Me.btn_eliminarRegistro.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminarRegistro.Location = New System.Drawing.Point(244, 406)
        Me.btn_eliminarRegistro.Name = "btn_eliminarRegistro"
        Me.btn_eliminarRegistro.Size = New System.Drawing.Size(150, 70)
        Me.btn_eliminarRegistro.TabIndex = 7
        Me.btn_eliminarRegistro.Text = "Eliminar Registro"
        Me.btn_eliminarRegistro.UseVisualStyleBackColor = True
        '
        'btn_actualizarRegistro
        '
        Me.btn_actualizarRegistro.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizarRegistro.Location = New System.Drawing.Point(499, 406)
        Me.btn_actualizarRegistro.Name = "btn_actualizarRegistro"
        Me.btn_actualizarRegistro.Size = New System.Drawing.Size(150, 70)
        Me.btn_actualizarRegistro.TabIndex = 8
        Me.btn_actualizarRegistro.Text = "Actualizar Registro"
        Me.btn_actualizarRegistro.UseVisualStyleBackColor = True
        '
        'btn_planilla
        '
        Me.btn_planilla.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_planilla.Location = New System.Drawing.Point(727, 406)
        Me.btn_planilla.Name = "btn_planilla"
        Me.btn_planilla.Size = New System.Drawing.Size(150, 70)
        Me.btn_planilla.TabIndex = 9
        Me.btn_planilla.Text = "Ver planillas"
        Me.btn_planilla.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.ErrorImage = Nothing
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(754, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(82, 70)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrar.TabIndex = 11
        Me.btn_cerrar.TabStop = False
        '
        'form_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_planilla)
        Me.Controls.Add(Me.btn_actualizarRegistro)
        Me.Controls.Add(Me.btn_eliminarRegistro)
        Me.Controls.Add(Me.btn_agregarRegistro)
        Me.Controls.Add(Me.dg_empleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAR BASE DE DATOS"
        CType(Me.dg_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_empleados As DataGridView
    Friend WithEvents btn_agregarRegistro As Button
    Friend WithEvents btn_eliminarRegistro As Button
    Friend WithEvents btn_actualizarRegistro As Button
    Friend WithEvents btn_planilla As Button
    Friend WithEvents btn_cerrar As PictureBox
End Class
