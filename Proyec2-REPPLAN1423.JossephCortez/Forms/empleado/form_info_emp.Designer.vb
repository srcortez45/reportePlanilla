<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_info_emp
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
        Me.btn_pago = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lb_empleado = New System.Windows.Forms.Label()
        Me.lb_cedula = New System.Windows.Forms.Label()
        Me.lb_sexo = New System.Windows.Forms.Label()
        Me.lb_posicion = New System.Windows.Forms.Label()
        Me.lb_salario_mensual = New System.Windows.Forms.Label()
        Me.lb_otros_desc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_pago
        '
        Me.btn_pago.BackColor = System.Drawing.Color.Yellow
        Me.btn_pago.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pago.Location = New System.Drawing.Point(136, 369)
        Me.btn_pago.Name = "btn_pago"
        Me.btn_pago.Size = New System.Drawing.Size(229, 41)
        Me.btn_pago.TabIndex = 0
        Me.btn_pago.Text = "Consultar Pago"
        Me.btn_pago.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Salario Mensual:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Posicion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Otros Desc. :"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Yellow
        Me.btn_salir.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(136, 433)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(229, 40)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'lb_empleado
        '
        Me.lb_empleado.AutoSize = True
        Me.lb_empleado.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_empleado.Location = New System.Drawing.Point(139, 18)
        Me.lb_empleado.Name = "lb_empleado"
        Me.lb_empleado.Size = New System.Drawing.Size(81, 25)
        Me.lb_empleado.TabIndex = 9
        Me.lb_empleado.Text = "Label7"
        '
        'lb_cedula
        '
        Me.lb_cedula.AutoSize = True
        Me.lb_cedula.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cedula.Location = New System.Drawing.Point(139, 66)
        Me.lb_cedula.Name = "lb_cedula"
        Me.lb_cedula.Size = New System.Drawing.Size(81, 25)
        Me.lb_cedula.TabIndex = 10
        Me.lb_cedula.Text = "Label8"
        '
        'lb_sexo
        '
        Me.lb_sexo.AutoSize = True
        Me.lb_sexo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sexo.Location = New System.Drawing.Point(139, 122)
        Me.lb_sexo.Name = "lb_sexo"
        Me.lb_sexo.Size = New System.Drawing.Size(81, 25)
        Me.lb_sexo.TabIndex = 11
        Me.lb_sexo.Text = "Label9"
        '
        'lb_posicion
        '
        Me.lb_posicion.AutoSize = True
        Me.lb_posicion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_posicion.Location = New System.Drawing.Point(156, 173)
        Me.lb_posicion.Name = "lb_posicion"
        Me.lb_posicion.Size = New System.Drawing.Size(94, 25)
        Me.lb_posicion.TabIndex = 12
        Me.lb_posicion.Text = "Label10"
        '
        'lb_salario_mensual
        '
        Me.lb_salario_mensual.AutoSize = True
        Me.lb_salario_mensual.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_salario_mensual.Location = New System.Drawing.Point(226, 226)
        Me.lb_salario_mensual.Name = "lb_salario_mensual"
        Me.lb_salario_mensual.Size = New System.Drawing.Size(94, 25)
        Me.lb_salario_mensual.TabIndex = 13
        Me.lb_salario_mensual.Text = "Label11"
        '
        'lb_otros_desc
        '
        Me.lb_otros_desc.AutoSize = True
        Me.lb_otros_desc.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_otros_desc.Location = New System.Drawing.Point(226, 279)
        Me.lb_otros_desc.Name = "lb_otros_desc"
        Me.lb_otros_desc.Size = New System.Drawing.Size(94, 25)
        Me.lb_otros_desc.TabIndex = 14
        Me.lb_otros_desc.Text = "Label12"
        '
        'form_info_emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.lb_otros_desc)
        Me.Controls.Add(Me.lb_salario_mensual)
        Me.Controls.Add(Me.lb_posicion)
        Me.Controls.Add(Me.lb_sexo)
        Me.Controls.Add(Me.lb_cedula)
        Me.Controls.Add(Me.lb_empleado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_pago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_info_emp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_info_emp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_pago As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents lb_empleado As Label
    Friend WithEvents lb_cedula As Label
    Friend WithEvents lb_sexo As Label
    Friend WithEvents lb_posicion As Label
    Friend WithEvents lb_salario_mensual As Label
    Friend WithEvents lb_otros_desc As Label
End Class
