Public Class form_pago

    Public Sub ConsultarPagos()

        Dim modeloPagos As New ModeloTabdepago()
        dg_pagos = modeloPagos.VerPagos(dg_pagos)

    End Sub

    Private Sub form_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarPagos()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim resp = MsgBox("¿Desea salir y cerrar la sesión?", MsgBoxStyle.YesNo, "INFORMACION")
        If resp = MsgBoxResult.Yes Then
            form_login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        form_consultar.Show()
        Me.Close()
    End Sub
End Class