﻿
Public Class form_consultar

    'VARIABLES TEMPORALES
    Dim cedula, empleado, sexo, salario_mensual, otros_desc As String

    'SE INICIAN LOS REGISTROS DE LA DB
    Private Sub form_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarRegistro()
        CargarUsuario()

    End Sub
    'CARGA EL USUARIO ACTUAL
    Private Sub CargarUsuario()
        lb_usuario.Text = UsuariosActivos.cedula
        If tipo_usuario = tipo_usuarios.gerente Then
            btn_actualizarRegistro.Enabled = False
        End If
    End Sub

    'CONSULTAR LOS REGISTROS REGISTRADOS
    Public Sub ConsultarRegistro()
        Dim modeloRegistros As New ModeloTabdetapla()
        dg_empleados = modeloRegistros.VerRegistros(dg_empleados)

    End Sub

    'MODULO PARA AGREGAR UN REGISTRO
    Private Sub btn_agregarRegistro_Click(sender As Object, e As EventArgs) Handles btn_agregarRegistro.Click
        Me.Hide()
        form_agregarRegistro.Show()
    End Sub


    'MODULO PARA ACTUALIZAR UN REGISTRO SELECCIONADO
    Private Sub btn_actualizarRegistro_Click(sender As Object, e As EventArgs) Handles btn_actualizarRegistro.Click
        SeleccionarDatosEmp()
        form_actualizarRegistro.DatosEmpleado(cedula, empleado, sexo, salario_mensual, otros_desc)
        Me.Hide()
        form_actualizarRegistro.Show()
    End Sub

    Private Sub btn_pagos_Click(sender As Object, e As EventArgs) Handles btn_pagos.Click
        form_pago.Show()
        Me.Close()
    End Sub


    'MODULO PARA ELIMINAR UN REGISTRO SELECCIONADO
    Private Sub btn_eliminarRegistro_Click(sender As Object, e As EventArgs) Handles btn_eliminarRegistro.Click

        SeleccionarDatosEmp()
        form_eliminarRegistro.datosEmpleado(cedula, empleado, sexo, salario_mensual, otros_desc)
        Me.Hide()
        form_eliminarRegistro.Show()

    End Sub

    'MODULO PARA SELECCIONAR LOS DATOS EN EL DGV PARA ENVIARLOS DEPENDIENDO DE LA ACCIÓN SE QUIERA REALIZAR
    Private Sub SeleccionarDatosEmp()
        cedula = dg_empleados.CurrentRow.Cells(0).Value.ToString
        empleado = dg_empleados.CurrentRow.Cells(1).Value.ToString
        sexo = dg_empleados.CurrentRow.Cells(2).Value.ToString
        salario_mensual = dg_empleados.CurrentRow.Cells(3).Value.ToString
        otros_desc = dg_empleados.CurrentRow.Cells(4).Value.ToString
    End Sub

    'MODULO PARA MOSTRAR LOS RESULTADOS DE LA PLANILLA POR EMPLEADO
    Private Sub btn_planilla_Click(sender As Object, e As EventArgs) Handles btn_planilla.Click
        form_planillaemp.Show()
        Me.Close()
    End Sub

    'MODULO PARA CERRAR LA SESIÓN DE USUARIO LUEGO DE CONFIRMAR 
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Dim resp = MsgBox("¿Desea cerrar sesión?", MsgBoxStyle.YesNo, "CONFIRMACIÓN")
        If resp = MsgBoxResult.Yes Then
            form_login.Show()
            Me.Close()
        End If

    End Sub

End Class