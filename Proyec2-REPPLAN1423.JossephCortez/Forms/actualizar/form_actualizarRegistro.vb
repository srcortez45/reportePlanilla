Public Class form_actualizarRegistro
    ReadOnly conexion As Conexion = Conexion.Instancia
    Dim sexo As String
    Dim condicion As Boolean = True

    'MODULO PARA SOLICITAR LA INFO AL FORM DE CONSULTA
    Public Sub datosEmpleado(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        txt_cedula.Text = cedula
        txt_empleado.Text = empleado
        If (sexo.Contains("M")) Then
            chbx_opcion2.Checked = False
            chbx_opcion1.Checked = True
            Me.sexo = "M"
        Else
            chbx_opcion1.Checked = False
            chbx_opcion2.Checked = True
            Me.sexo = "F"
        End If
        txt_salario_mensual.Text = salario_mensual
        txt_otros_desc.Text = otros_desc

    End Sub


    Private Sub btn_actualizarRegistro_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        'SE VERIFICAN LOS ESPACIOS EN BLANCO

        If (txt_cedula.Text.Trim = "") Then
            MsgBox("EL CAMPO CEDULA ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_cedula.Clear()
            condicion = False
        End If
        If (txt_empleado.Text.Trim = "") Then
            MsgBox("EL CAMPO NOMBRE ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_empleado.Clear()
            condicion = False
        End If
        If Not chbx_opcion1.Checked And Not chbx_opcion2.Checked Then
            MsgBox("EL CAMPO DE SEXO NO TIENE NINGUNA OPCION SELECCIONADA", MsgBoxStyle.Information, "VERIFICAR")
            condicion = False
        End If
        If (txt_salario_mensual.Text.Trim = "") Then
            MsgBox("EL CAMPO SALARIO MENSUAL ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_salario_mensual.Clear()
            condicion = False
        End If
        If (txt_otros_desc.Text.Trim = "") Then
            MsgBox("EL CAMPO OTROS DESCUENTOS ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_otros_desc.Clear()
            condicion = False
        End If

        'SI LA INFO ES VALIDA ACTUALIZA EL REGISTRO
        If (condicion) Then
            Dim resp As Integer = MsgBox("¿Esta seguro que desea actualizar el empleado" & vbCrLf & txt_empleado.Text & " con cedula: " & txt_cedula.Text & "?", MsgBoxStyle.YesNo)
            If (resp = MsgBoxResult.Yes) Then
                conexion.ActualizarRegistro(txt_cedula.Text,
                                        txt_empleado.Text,
                                        sexo,
                                        txt_salario_mensual.Text,
                                        txt_otros_desc.Text)
                form_consultar.consultarRegistro()
                form_consultar.Show()
                Me.Close()
            End If
        End If

    End Sub

    'REGRESAR AL FORM DE CONSULTA
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        form_consultar.Show()
        Me.Close()
    End Sub

    'MODULO DE VALIDACION DE LA ENTRADA DE TEXTO
    Private Sub validarCedula(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Or Asc(e.KeyChar) = 45 Then
            Else
                e.Handled = True
                MsgBox("SOLO LOS NUMEROS Y GUIONES (-) ESTAN PERMITIDOS", MsgBoxStyle.Information, "VERIFICAR")
            End If
        End If

    End Sub

    Private Sub validarNombre(sender As Object, e As KeyPressEventArgs) Handles txt_empleado.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                condicion = True
            Else
                e.Handled = True
                MsgBox("SOLO LETRAS Y ESPACIOS PERMITIDOS", MsgBoxStyle.Information, "VERIFICAR")
                txt_empleado.Focus()
            End If
        End If

    End Sub

    Private Sub chbx_opcion1_Click(sender As Object, e As EventArgs) Handles chbx_opcion1.Click
        sexo = "M"
        chbx_opcion2.Checked = False
        condicion = True
    End Sub

    Private Sub chbx_opcion2_Click(sender As Object, e As EventArgs) Handles chbx_opcion2.Click
        sexo = "F"
        chbx_opcion1.Checked = False
        condicion = True
    End Sub

    Private Sub validarSalario(sender As Object, e As KeyPressEventArgs) Handles txt_salario_mensual.KeyPress, txt_otros_desc.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Or Asc(e.KeyChar) = 46 Then
                condicion = True
            Else
                e.Handled = True
                MsgBox("SOLO LOS NUMEROS Y EL PUNTO ESTAN PERMITIDOS", MsgBoxStyle.Information, "VERIFICAR")

            End If
        End If

    End Sub



    'MODULO DE INFORMACION PARA EL USUARIO


    Private Sub info_cedula_MouseHover(sender As Object, e As EventArgs) Handles txt_cedula.MouseHover
        If txt_cedula.Focused Then
            lb_msgInfo.Text = "La cedula solo puede contener numeros y guiones"
        End If
    End Sub

    Private Sub info_cedula_MouseLeave(sender As Object, e As EventArgs) Handles txt_cedula.MouseLeave
        If txt_cedula.Focused Then
            lb_msgInfo.Text = ""
        End If
    End Sub

    Private Sub info_nombre_MouseHover(sender As Object, e As EventArgs) Handles txt_empleado.MouseHover
        If txt_empleado.Focused Then
            lb_msgInfo.Text = "El nombre solo puede contener letras y espacios"
        End If
    End Sub

    Private Sub info_nombre_MouseLeave(sender As Object, e As EventArgs) Handles txt_empleado.MouseLeave
        If Not txt_empleado.Focused Then
            lb_msgInfo.Text = ""
        End If
    End Sub

    Private Sub info_salario_mensual_MouseHover(sender As Object, e As EventArgs) Handles txt_salario_mensual.MouseHover
        If txt_salario_mensual.Focused Then
            lb_msgInfo.Text = "El salario mensual solo puede contener numeros y el punto"
        End If
    End Sub

    Private Sub info_salario_mensual_MouseLeave(sender As Object, e As EventArgs) Handles txt_salario_mensual.MouseLeave
        If Not txt_salario_mensual.Focused Then
            lb_msgInfo.Text = ""
        End If
    End Sub

    Private Sub info_sexoM_MouseHover(sender As Object, e As EventArgs) Handles chbx_opcion1.MouseHover
        If chbx_opcion1.Checked Then
            lb_msgInfo.Text = "Selecciono el sexo Masculino(M)"
        End If

    End Sub


    Private Sub info_sexoM_MouseLeave(sender As Object, e As EventArgs) Handles chbx_opcion1.MouseLeave

        If Not chbx_opcion1.Checked Then
            lb_msgInfo.Text = ""
        End If

    End Sub

    Private Sub info_sexoF_MouseHover(sender As Object, e As EventArgs) Handles chbx_opcion2.MouseHover
        If chbx_opcion2.Checked Then
            lb_msgInfo.Text = "Selecciono el sexo Femenino(F)"
        End If
    End Sub

    Private Sub info_sexoF_MouseLeave(sender As Object, e As EventArgs) Handles chbx_opcion2.MouseLeave

        If Not chbx_opcion2.Checked Then
            lb_msgInfo.Text = ""
        End If

    End Sub

    Private Sub info_otros_desc_MouseHover(sender As Object, e As EventArgs) Handles txt_otros_desc.MouseHover
        If txt_otros_desc.Focused Then
            lb_msgInfo.Text = "El descuento solo puede contener numeros y el punto"
        End If
    End Sub
    Private Sub info_otros_desc_MouseLeave(sender As Object, e As EventArgs) Handles txt_otros_desc.MouseLeave
        If Not txt_otros_desc.Focused Then
            lb_msgInfo.Text = ""
        End If
    End Sub

End Class