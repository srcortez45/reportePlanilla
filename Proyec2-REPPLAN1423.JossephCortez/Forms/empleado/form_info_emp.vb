Public Class form_info_emp
    Private Sub form_info_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim info_empleado As New ModeloTabdetapla()
        info_empleado.TraerRegistro(cedula)
        If lb_sexo.Text = "M" Then
            lb_sexo.Text = "Masculino"
        Else
            lb_sexo.Text = "Femenino"
        End If
    End Sub

    Private Sub btn_pago_Click(sender As Object, e As EventArgs) Handles btn_pago.Click
        form_planillaemp.CargarEmpleado()
        form_planillaemp.Show()
        Me.Close()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim resp = MsgBox("¿Desea salir de la sesión?", MsgBoxStyle.YesNo, "INFORMACION")
        If resp = MsgBoxResult.Yes Then
            form_login.Show()
            Me.Close()
        End If

    End Sub
End Class