<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_agregarRegistro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_agregarRegistro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gp_formulario = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lb_msgInfo = New System.Windows.Forms.Label()
        Me.chbx_opcion2 = New System.Windows.Forms.CheckBox()
        Me.chbx_opcion1 = New System.Windows.Forms.CheckBox()
        Me.txt_otros_desc = New System.Windows.Forms.TextBox()
        Me.txt_salario_mensual = New System.Windows.Forms.TextBox()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.gp_formulario.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 193)
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
        'gp_formulario
        '
        Me.gp_formulario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gp_formulario.Controls.Add(Me.Label5)
        Me.gp_formulario.Controls.Add(Me.txt_cedula)
        Me.gp_formulario.Controls.Add(Me.lb_msgInfo)
        Me.gp_formulario.Controls.Add(Me.chbx_opcion2)
        Me.gp_formulario.Controls.Add(Me.chbx_opcion1)
        Me.gp_formulario.Controls.Add(Me.txt_otros_desc)
        Me.gp_formulario.Controls.Add(Me.txt_salario_mensual)
        Me.gp_formulario.Controls.Add(Me.txt_empleado)
        Me.gp_formulario.Controls.Add(Me.Label1)
        Me.gp_formulario.Controls.Add(Me.Label4)
        Me.gp_formulario.Controls.Add(Me.Label2)
        Me.gp_formulario.Controls.Add(Me.Label3)
        Me.gp_formulario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_formulario.Location = New System.Drawing.Point(90, -1)
        Me.gp_formulario.Name = "gp_formulario"
        Me.gp_formulario.Size = New System.Drawing.Size(498, 532)
        Me.gp_formulario.TabIndex = 4
        Me.gp_formulario.TabStop = False
        Me.gp_formulario.Text = "Formulario de registro de empleado"
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
        Me.txt_cedula.MaxLength = 20
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(233, 27)
        Me.txt_cedula.TabIndex = 12
        '
        'lb_msgInfo
        '
        Me.lb_msgInfo.AutoSize = True
        Me.lb_msgInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_msgInfo.ForeColor = System.Drawing.Color.Navy
        Me.lb_msgInfo.Location = New System.Drawing.Point(49, 463)
        Me.lb_msgInfo.Name = "lb_msgInfo"
        Me.lb_msgInfo.Size = New System.Drawing.Size(67, 20)
        Me.lb_msgInfo.TabIndex = 11
        Me.lb_msgInfo.Text = "MsgInfo"
        '
        'chbx_opcion2
        '
        Me.chbx_opcion2.AutoSize = True
        Me.chbx_opcion2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbx_opcion2.Location = New System.Drawing.Point(311, 227)
        Me.chbx_opcion2.Name = "chbx_opcion2"
        Me.chbx_opcion2.Size = New System.Drawing.Size(112, 22)
        Me.chbx_opcion2.TabIndex = 10
        Me.chbx_opcion2.Text = "Femenino"
        Me.chbx_opcion2.UseVisualStyleBackColor = True
        '
        'chbx_opcion1
        '
        Me.chbx_opcion1.AutoSize = True
        Me.chbx_opcion1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbx_opcion1.Location = New System.Drawing.Point(56, 227)
        Me.chbx_opcion1.Name = "chbx_opcion1"
        Me.chbx_opcion1.Size = New System.Drawing.Size(112, 22)
        Me.chbx_opcion1.TabIndex = 9
        Me.chbx_opcion1.Text = "Masculino"
        Me.chbx_opcion1.UseVisualStyleBackColor = True
        '
        'txt_otros_desc
        '
        Me.txt_otros_desc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_otros_desc.Location = New System.Drawing.Point(122, 400)
        Me.txt_otros_desc.MaxLength = 5
        Me.txt_otros_desc.Name = "txt_otros_desc"
        Me.txt_otros_desc.Size = New System.Drawing.Size(233, 27)
        Me.txt_otros_desc.TabIndex = 8
        '
        'txt_salario_mensual
        '
        Me.txt_salario_mensual.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salario_mensual.Location = New System.Drawing.Point(122, 317)
        Me.txt_salario_mensual.MaxLength = 15
        Me.txt_salario_mensual.Name = "txt_salario_mensual"
        Me.txt_salario_mensual.Size = New System.Drawing.Size(233, 27)
        Me.txt_salario_mensual.TabIndex = 7
        '
        'txt_empleado
        '
        Me.txt_empleado.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empleado.Location = New System.Drawing.Point(122, 147)
        Me.txt_empleado.MaxLength = 20
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(233, 27)
        Me.txt_empleado.TabIndex = 6
        '
        'btn_registrar
        '
        Me.btn_registrar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Location = New System.Drawing.Point(401, 569)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(187, 50)
        Me.btn_registrar.TabIndex = 5
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btn_regresar
        '
        Me.btn_regresar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(90, 569)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(187, 50)
        Me.btn_regresar.TabIndex = 10
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'form_agregarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.gp_formulario)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_agregarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE EMPLEADO"
        Me.gp_formulario.ResumeLayout(False)
        Me.gp_formulario.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gp_formulario As GroupBox
    Friend WithEvents txt_otros_desc As TextBox
    Friend WithEvents txt_salario_mensual As TextBox
    Friend WithEvents txt_empleado As TextBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents chbx_opcion2 As CheckBox
    Friend WithEvents chbx_opcion1 As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lb_msgInfo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents btn_regresar As Button
End Class
