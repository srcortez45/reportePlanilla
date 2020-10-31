﻿Public Class form_eliminarRegistro
    Dim conexion As conexion = conexion.Instancia
    Dim sexo As String
    Sub datosEmpleado(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
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

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        form_consultar.Show()
        Me.Close()
    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim resp As Integer = MsgBox("¿Esta seguro que desea eliminar el empleado" & vbCrLf & txt_empleado.Text & " con cedula: " & txt_cedula.Text & "?", MsgBoxStyle.YesNo)
        If (resp = MsgBoxResult.Yes) Then
            conexion.eliminarRegistro(txt_empleado.Text)
            form_consultar.consultarRegistro()
            form_consultar.Show()
            Me.Close()
        End If

    End Sub

End Class