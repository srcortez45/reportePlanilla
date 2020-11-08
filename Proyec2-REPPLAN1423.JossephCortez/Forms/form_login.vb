
Public Class form_login
    'SE CREA UNA INSTANCIA DE LA CLASE CONEXION PARA VERIFICAR EL USER Y EL PASS
    Dim condicion As Boolean = True

    'SE VERIFICAN LOS CAMPOS EN BLANCO ANTES DE PERMITIR EL LOGIN
    Private Sub btn_logindb_Click(sender As Object, e As EventArgs) Handles btn_logindb.Click
        If (txt_user.Text = "") Then
            MsgBox("EL CAMPO USUARIO ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_user.Clear()
            condicion = False
        End If
        If (txt_pass.Text = "") Then
            MsgBox("EL CAMPO CONTRASEÑA ESTA VACIO", MsgBoxStyle.Information, "VERIFICAR")
            txt_user.Clear()
            condicion = False
        End If

        If condicion Then
            Dim modeloUsuario As New ModeloUsuario()
            Dim validarLogin = modeloUsuario.Login(txt_user.Text, txt_pass.Text)
            If validarLogin Then
                form_consultar.Show()
                Me.Close()
            Else
                MsgBox("Usuario Incorrecto o contraseña incorrecta, porfavor intente nuevamente", MsgBoxStyle.Critical, "ADVERTENCIA")
                txt_pass.Clear()
                txt_pass.Focus()
            End If
        End If

    End Sub


    'ANTES DE SALIR SE CONFIRMA QUE NO SEA UN MISSCLICK
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim resp As Integer = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "CONFIRMAR")
        If (resp = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub VaciarCampos()
        txt_user.Clear()
        txt_pass.Clear()
    End Sub


End Class