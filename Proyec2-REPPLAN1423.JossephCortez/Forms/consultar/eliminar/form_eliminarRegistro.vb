Public Class form_eliminarRegistro

    'MODULO PARA SOLICITAR LA INFO AL FORM CONSULTA
    Public Sub datosEmpleado(cedula As String, empleado As String, sexo As String, salario_mensual As String, otros_desc As String)
        txt_cedula.Text = cedula
        txt_empleado.Text = empleado
        If (sexo.Contains("M")) Then
            txt_sexo.Text = "Masculino(M)"
        Else
            txt_sexo.Text = "Femenino(F)"
        End If
        txt_salario_mensual.Text = salario_mensual
        txt_otros_desc.Text = otros_desc
    End Sub

    'SE REALIZA LA VERIFICACIÓN PARA ELIMINAR EL EMP
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim resp = MsgBox("¿Esta seguro que desea eliminar el empleado" & vbCrLf & txt_empleado.Text & " con cedula: " & txt_cedula.Text & "?", MsgBoxStyle.YesNo)

        If resp = MsgBoxResult.Yes Then

            ' SE ELIMINAN LOS DATOS DE PAGO ANTES DEL REGISTRO
            Dim eliminarPago As New ModeloTabdepago()
            eliminarPago.EliminarDatosPago(txt_cedula.Text)

            ' SE ELIMINA EL REGISTRO

            Dim eliminarRegistro As New ModeloTabdetapla()
            eliminarRegistro.EliminarRegistro(txt_cedula.Text)
            form_pagos.ConsultarRegistro()
            form_pagos.Show()
            Me.Close()
        End If

    End Sub

    'REGRESA AL FORM CONSULTA
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        form_pagos.Show()
        Me.Close()
    End Sub


End Class