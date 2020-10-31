Public Class form_login

    Dim conexion As conexion = conexion.Instancia

    Private Sub btn_logindb_Click(sender As Object, e As EventArgs) Handles btn_logindb.Click
        conexion.conectarbd(txt_user.Text, txt_pass.Text)
        form_consultar.Show()
        Me.Close()

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim resp As Integer = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel)
        If (resp = MsgBoxResult.Ok) Then
            Me.Close()
        End If

    End Sub
End Class