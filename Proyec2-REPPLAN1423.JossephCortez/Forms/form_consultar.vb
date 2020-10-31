Public Class form_consultar

    Dim conexion As conexion = conexion.Instancia
    Dim cedula, empleado, sexo, salario_mensual, otros_desc As String


    Private Sub btn_agregarRegistro_Click(sender As Object, e As EventArgs) Handles btn_agregarRegistro.Click
        Me.Hide()
        form_agregarRegistro.Show()
    End Sub

    Private Sub btn_eliminarRegistro_Click(sender As Object, e As EventArgs) Handles btn_eliminarRegistro.Click

        seleccionarDatosEmp()
        form_eliminarRegistro.datosEmpleado(cedula, empleado, sexo, salario_mensual, otros_desc)
        Me.Hide()
        form_eliminarRegistro.Show()


    End Sub

    Private Sub btn_planilla_Click(sender As Object, e As EventArgs) Handles btn_planilla.Click
        form_planillaemp.mostrar()
        form_planillaemp.Show()
        Me.Close()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Dim resp = MsgBox("¿Desea cerrar sesión?", MsgBoxStyle.YesNo)
        If (resp = MsgBoxResult.Yes) Then
            form_login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btn_actualizarRegistro_Click(sender As Object, e As EventArgs) Handles btn_actualizarRegistro.Click

        seleccionarDatosEmp()
        form_actualizarRegistro.datosEmpleado(cedula, empleado, sexo, salario_mensual, otros_desc)
        Me.Hide()
        form_actualizarRegistro.Show()
    End Sub

    Sub consultarRegistro()
        conexion.verRegistros(dg_empleados)
    End Sub

    Private Sub form_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarRegistro()
    End Sub

    Private Sub seleccionarDatosEmp()
        cedula = dg_empleados.CurrentRow.Cells(0).Value.ToString
        empleado = dg_empleados.CurrentRow.Cells(1).Value.ToString
        sexo = dg_empleados.CurrentRow.Cells(2).Value.ToString
        salario_mensual = dg_empleados.CurrentRow.Cells(3).Value.ToString
        otros_desc = dg_empleados.CurrentRow.Cells(4).Value.ToString
    End Sub




End Class