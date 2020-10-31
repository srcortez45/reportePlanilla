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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_consultar))
        Me.dg_empleados = New System.Windows.Forms.DataGridView()
        Me.btn_agregarRegistro = New System.Windows.Forms.Button()
        Me.btn_eliminarRegistro = New System.Windows.Forms.Button()
        Me.btn_actualizarRegistro = New System.Windows.Forms.Button()
        Me.btn_planilla = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_administracion = New System.Windows.Forms.Button()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_empleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_empleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_empleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_empleados.Location = New System.Drawing.Point(21, 88)
        Me.dg_empleados.Name = "dg_empleados"
        Me.dg_empleados.ReadOnly = True
        Me.dg_empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_empleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dg_empleados.RowsDefaultCellStyle = DataGridViewCellStyle4
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
        'btn_administracion
        '
        Me.btn_administracion.Location = New System.Drawing.Point(31, 37)
        Me.btn_administracion.Name = "btn_administracion"
        Me.btn_administracion.Size = New System.Drawing.Size(79, 23)
        Me.btn_administracion.TabIndex = 13
        Me.btn_administracion.Text = "Button1"
        Me.btn_administracion.UseVisualStyleBackColor = True
        '
        'form_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.btn_administracion)
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
    Friend WithEvents btn_administracion As Button
End Class
