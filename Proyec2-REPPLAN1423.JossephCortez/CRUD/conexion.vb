
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class conexion

    Private Sub New()
    End Sub
    'MODULO DE INSTANCIA DE LA CLASE
    Public Shared ReadOnly Property Instancia As conexion
        Get
            Static INST As conexion = New conexion
            Return INST
        End Get
    End Property

    Dim sqlconexion As MySqlConnection = New MySqlConnection
    Dim sqlcomandos As MySqlCommand = New MySqlCommand

    'MODULO PARA VERIFICAR LA CONEXION CON EL SERVIDOR
    Sub conectarbd(ByVal user As String, ByVal pass As String)


        sqlcomandos.Connection = sqlconexion
        Try
            sqlconexion.ConnectionString = "SERVER = 127.0.0.1; PORT=3306;DATABASE=dbplaniquin; UID=" & user & ";PWD=" & pass & ";SslMode = none;"
            sqlconexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        sqlconexion.Close()

    End Sub




    'MODULO PARA VER LOS REGISTROS
    Sub verRegistros(ByVal datos As DataGridView)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "SELECT * FROM tabdetapla"

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(sqlcomandos)

        da.Fill(dt)
        datos.DataSource = dt
        sqlconexion.Close()

    End Sub


    'MODULO PARA AGREGAR REGISTRO
    Sub agregarRegistro(ByVal cedula As String, ByVal nombre As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "INSERT INTO `tabdetapla`(`cedula`,`empleados`, `sexo`, `salario_mensual`, `otros_desc`) VALUES (?cedula,?empleados,?sexo,?salario_mensual,?otros_desc)"
        sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
        sqlcomandos.Parameters.AddWithValue("?empleados", nombre)
        sqlcomandos.Parameters.AddWithValue("?sexo", sexo)
        sqlcomandos.Parameters.AddWithValue("?salario_mensual", salario_mensual)
        sqlcomandos.Parameters.AddWithValue("?otros_desc", otros_desc)
        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()
        MsgBox("EL REGISTRO SE AÑADIO CON EXITO")

    End Sub


    'MODULO PARA ELIMINAR REGISTRO
    Sub eliminarRegistro(ByVal empleado As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "DELETE FROM `tabdetapla` WHERE `empleados`=  ?empleados "
        sqlcomandos.Parameters.AddWithValue("?empleados", empleado)
        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()
        MsgBox("EL REGISTRO HA SIDO ELIMINADO")
    End Sub


    'MODULO PARA ACTUALIZAR REGISTRO
    Sub actualizarRegistro(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "UPDATE `tabdetapla` SET cedula = @cedula ,empleados = @empleados, sexo = @sexo, salario_mensual = @salario_mensual, otros_desc = @otros_desc WHERE empleados = @empleados"
        sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
        sqlcomandos.Parameters.AddWithValue("@empleados", empleado)
        sqlcomandos.Parameters.AddWithValue("@sexo", sexo)
        sqlcomandos.Parameters.AddWithValue("@salario_mensual", salario_mensual)
        sqlcomandos.Parameters.AddWithValue("@otros_desc", otros_desc)
        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()
        MsgBox("EL REGISTRO HA SIDO ACTUALIZADO")
    End Sub


    'MODULO PARA TRAER REGISTRO
    Sub traerRegistro(ByVal pos As String)
        Dim lector As MySqlDataReader

        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "SELECT * FROM tabdetapla LIMIT " + pos + ", 1"
        lector = sqlcomandos.ExecuteReader()
        Try
            While lector.Read()
                form_planillaemp.lb_cedula_emp.Text = lector.GetString(0)
                form_planillaemp.lb_empleado.Text = lector.GetString(1)
                form_planillaemp.lb_firma_emp.Text = lector.GetString(1)
                form_planillaemp.lb_sexo.Text = lector.GetString(2)
                form_planillaemp.lb_salario_mensual.Text = lector.GetDecimal(3)
                form_planillaemp.lb_porc_otros_desc.Text = lector.GetDecimal(8)
            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        lector.Close()
        sqlconexion.Close()

    End Sub

    'MODULO PARA ENVIAR LOS DATOS DE PAGO DEL EMPLEADO
    Sub enviarDatosPago(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal salario_quincenal As String, ByVal seg_social As String, ByVal seg_edu As String, ByVal imp_renta As String, ByVal otros_desc As String, ByVal total_desc As String, ByVal salario_neto As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "UPDATE `tabdetapla` SET cedula = @cedula ,empleados = @empleados, sexo = @sexo, salario_mensual = @salario_mensual, salario_quincenal = @salario_quincenal, seguro_social = @seguro_social,seguro_educativo = @seguro_educativo, imp_renta = @imp_renta, otros_desc = @otros_desc ,total_desc = @total_desc ,salario_neto = @salario_neto WHERE cedula = @cedula"
        sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
        sqlcomandos.Parameters.AddWithValue("@empleados", empleado)
        sqlcomandos.Parameters.AddWithValue("@sexo", sexo)
        sqlcomandos.Parameters.AddWithValue("@salario_mensual", salario_mensual)
        sqlcomandos.Parameters.AddWithValue("@salario_quincenal", salario_quincenal)
        sqlcomandos.Parameters.AddWithValue("@seguro_social", seg_social)
        sqlcomandos.Parameters.AddWithValue("@seguro_educativo", seg_edu)
        sqlcomandos.Parameters.AddWithValue("@imp_renta", imp_renta)
        sqlcomandos.Parameters.AddWithValue("@otros_desc", otros_desc)
        sqlcomandos.Parameters.AddWithValue("@total_desc", total_desc)
        sqlcomandos.Parameters.AddWithValue("@salario_neto", salario_neto)
        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()
        MsgBox("LA INFORMACIÓN DE PAGO SE ENVIO CORRECTAMENTE AL REGISTRO")


    End Sub

    'MODUULO PARA OBTENER EL TOTAL DE REGISTROS
    Function totalRegistros() As String
        Dim total As String
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "Select Count(*) from tabdetapla"
        Try
            total = Convert.ToString(sqlcomandos.ExecuteScalar())
        Catch ex As Exception
            MsgBox(ex)
        End Try
        sqlconexion.Close()
        Return total

    End Function

End Class
