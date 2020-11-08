<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_eliminarRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_eliminarRegistro))
        Me.gp_formulario = New System.Windows.Forms.GroupBox()
        Me.txt_sexo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_otros_desc = New System.Windows.Forms.TextBox()
        Me.txt_salario_mensual = New System.Windows.Forms.TextBox()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.gp_formulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_formulario
        '
        Me.gp_formulario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gp_formulario.Controls.Add(Me.txt_sexo)
        Me.gp_formulario.Controls.Add(Me.Label5)
        Me.gp_formulario.Controls.Add(Me.txt_cedula)
        Me.gp_formulario.Controls.Add(Me.txt_otros_desc)
        Me.gp_formulario.Controls.Add(Me.txt_salario_mensual)
        Me.gp_formulario.Controls.Add(Me.txt_empleado)
        Me.gp_formulario.Controls.Add(Me.Label1)
        Me.gp_formulario.Controls.Add(Me.Label4)
        Me.gp_formulario.Controls.Add(Me.Label2)
        Me.gp_formulario.Controls.Add(Me.Label3)
        Me.gp_formulario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_formulario.Location = New System.Drawing.Point(98, 1)
        Me.gp_formulario.Name = "gp_formulario"
        Me.gp_formulario.Size = New System.Drawing.Size(498, 530)
        Me.gp_formulario.TabIndex = 10
        Me.gp_formulario.TabStop = False
        Me.gp_formulario.Text = "DATOS DEL EMPLEADO"
        '
        'txt_sexo
        '
        Me.txt_sexo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sexo.Location = New System.Drawing.Point(122, 241)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.ReadOnly = True
        Me.txt_sexo.Size = New System.Drawing.Size(233, 27)
        Me.txt_sexo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cedula:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cedula.Location = New System.Drawing.Point(122, 65)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.ReadOnly = True
        Me.txt_cedula.Size = New System.Drawing.Size(233, 27)
        Me.txt_cedula.TabIndex = 12
        '
        'txt_otros_desc
        '
        Me.txt_otros_desc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_otros_desc.Location = New System.Drawing.Point(122, 400)
        Me.txt_otros_desc.MaxLength = 4
        Me.txt_otros_desc.Name = "txt_otros_desc"
        Me.txt_otros_desc.ReadOnly = True
        Me.txt_otros_desc.Size = New System.Drawing.Size(233, 27)
        Me.txt_otros_desc.TabIndex = 8
        '
        'txt_salario_mensual
        '
        Me.txt_salario_mensual.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salario_mensual.Location = New System.Drawing.Point(122, 317)
        Me.txt_salario_mensual.Name = "txt_salario_mensual"
        Me.txt_salario_mensual.ReadOnly = True
        Me.txt_salario_mensual.Size = New System.Drawing.Size(233, 27)
        Me.txt_salario_mensual.TabIndex = 7
        '
        'txt_empleado
        '
        Me.txt_empleado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empleado.Location = New System.Drawing.Point(122, 147)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.ReadOnly = True
        Me.txt_empleado.Size = New System.Drawing.Size(233, 27)
        Me.txt_empleado.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Otros descuentos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salario mensual:"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(409, 568)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(187, 50)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_regresar
        '
        Me.btn_regresar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(98, 568)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(187, 50)
        Me.btn_regresar.TabIndex = 12
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'form_eliminarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.gp_formulario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_eliminarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELIMINAR REGISTRO DE EMPLEADO"
        Me.gp_formulario.ResumeLayout(False)
        Me.gp_formulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_regresar As Button
    Friend WithEvents gp_formulario As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_otros_desc As TextBox
    Friend WithEvents txt_salario_mensual As TextBox
    Friend WithEvents txt_empleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents txt_sexo As TextBox
End Class
