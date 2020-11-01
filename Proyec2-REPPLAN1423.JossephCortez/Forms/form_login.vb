Public Class form_login

    Dim conexion As conexion = conexion.Instancia
    Dim condicion As Boolean = True
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
            conexion.Conectarbd(txt_user.Text, txt_pass.Text)
            form_consultar.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim resp As Integer = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel,"CONFIRMAR")
        If (resp = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub


End Class