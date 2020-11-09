<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_pagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose( disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_pagos))
        Me.dg_empleados = New System.Windows.Forms.DataGridView()
        Me.btn_agregarRegistro = New System.Windows.Forms.Button()
        Me.btn_eliminarRegistro = New System.Windows.Forms.Button()
        Me.btn_actualizarRegistro = New System.Windows.Forms.Button()
        Me.btn_planilla = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_usuario = New System.Windows.Forms.Label()
        CType(Me.dg_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_empleados
        '
        Me.dg_empleados.AllowUserToAddRows = False
        Me.dg_empleados.AllowUserToDeleteRows = False
        Me.dg_empleados.AllowUserToResizeColumns = False
        Me.dg_empleados.AllowUserToResizeRows = False
        Me.dg_empleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dg_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dg_empleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_empleados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dg_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_empleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dg_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_empleados.DefaultCellStyle = DataGridViewCellStyle10
        Me.dg_empleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_empleados.Location = New System.Drawing.Point(21, 88)
        Me.dg_empleados.Name = "dg_empleados"
        Me.dg_empleados.ReadOnly = True
        Me.dg_empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_empleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dg_empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dg_empleados.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dg_empleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_empleados.Size = New System.Drawing.Size(856, 260)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "REGISTRO DE EMPLEADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Usuario:"
        '
        'lb_usuario
        '
        Me.lb_usuario.AutoSize = True
        Me.lb_usuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_usuario.Location = New System.Drawing.Point(17, 37)
        Me.lb_usuario.Name = "lb_usuario"
        Me.lb_usuario.Size = New System.Drawing.Size(63, 19)
        Me.lb_usuario.TabIndex = 15
        Me.lb_usuario.Text = "Label4"
        '
        'form_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.lb_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg_empleados As DataGridView
    Friend WithEvents btn_agregarRegistro As Button
    Friend WithEvents btn_eliminarRegistro As Button
    Friend WithEvents btn_actualizarRegistro As Button
    Friend WithEvents btn_planilla As Button
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_usuario As Label
End Class
