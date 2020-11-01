
Imports MySql.Data.MySqlClient


Public Class Conexion

    Private Sub New()
    End Sub
    'MODULO DE INSTANCIA DE LA CLASE
    Public Shared ReadOnly Property Instancia As Conexion
        Get
            Static INST As Conexion = New Conexion
            Return INST
        End Get
    End Property

    ReadOnly sqlconexion As MySqlConnection = New MySqlConnection
    ReadOnly sqlcomandos As MySqlCommand = New MySqlCommand

    'MODULO PARA VERIFICAR LA CONEXION CON EL SERVIDOR
    Public Sub Conectarbd(ByVal user As String, ByVal pass As String)


        sqlcomandos.Connection = sqlconexion
        Try
            sqlconexion.ConnectionString = "SERVER = 127.0.0.1; PORT=3306;DATABASE=dbplaniquin; UID=" & user & ";PWD=" & pass & ";SslMode = none;"
            Debug.WriteLine("CONEXION EXITOSA")
            sqlconexion.Open()

        Catch ex As Exception
            Debug.WriteLine(ex)
        End Try
        sqlconexion.Close()

    End Sub




    'MODULO PARA VER LOS REGISTROS
    Public Sub VerRegistros(ByVal datos As DataGridView)
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
    Public Sub AgregarRegistro(ByVal cedula As String, ByVal nombre As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
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
    Public Sub EliminarRegistro(ByVal cedula As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "DELETE FROM `tabdetapla` WHERE `cedula`=  ?cedula "
        sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()
        MsgBox("EL REGISTRO HA SIDO ELIMINADO")
    End Sub


    'MODULO PARA ACTUALIZAR REGISTRO
    Public Sub ActualizarRegistro(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "UPDATE `tabdetapla` SET cedula = @cedula ,empleados = @empleados, sexo = @sexo, salario_mensual = @salario_mensual, otros_desc = @otros_desc WHERE cedula = @cedula"
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
    Public Sub TraerRegistro(ByVal pos As String)
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
                form_planillaemp.lb_porc_otros_desc.Text = lector.GetDecimal(4)
            End While
        Catch ex As Exception
            Debug.WriteLine("OCURRIO UN ERROR")
        End Try
        lector.Close()
        sqlconexion.Close()

    End Sub

    'MODULO PARA ENVIAR LOS DATOS DE PAGO DEL EMPLEADO
    Public Sub EnviarDatosPago(ByVal cedula As String, ByVal salario_quincenal As String, ByVal seg_social As String, ByVal seg_edu As String, ByVal imp_renta As String, ByVal monto_otros_desc As String, ByVal total_desc As String, ByVal salario_neto As String)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "UPDATE `tabpagoplan` SET salario_quincenal = @salario_quincenal, seguro_social = @seguro_social,seguro_educativo = @seguro_educativo, imp_renta = @imp_renta, monto_otros_desc = @monto_otros_desc ,total_desc = @total_desc ,salario_neto = @salario_neto WHERE cedula = @cedula"
        sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
        sqlcomandos.Parameters.AddWithValue("@salario_quincenal", salario_quincenal)
        sqlcomandos.Parameters.AddWithValue("@seguro_social", seg_social)
        sqlcomandos.Parameters.AddWithValue("@seguro_educativo", seg_edu)
        sqlcomandos.Parameters.AddWithValue("@imp_renta", imp_renta)
        sqlcomandos.Parameters.AddWithValue("@monto_otros_desc", monto_otros_desc)
        sqlcomandos.Parameters.AddWithValue("@total_desc", total_desc)
        sqlcomandos.Parameters.AddWithValue("@salario_neto", salario_neto)


        sqlcomandos.ExecuteNonQuery()
        sqlcomandos.Parameters.Clear()
        sqlconexion.Close()


    End Sub

    'MODUULO PARA OBTENER EL TOTAL DE REGISTROS

    ReadOnly Property TotalRegistros As String
        Get
            Dim total As String
            sqlconexion.Open()
            sqlcomandos.Connection = sqlconexion
            sqlcomandos.CommandText = "Select Count(*) from tabdetapla"
            Try
                total = Convert.ToString(sqlcomandos.ExecuteScalar())
            Catch ex As Exception
                total = 0
                MsgBox(ex)
            End Try
            sqlconexion.Close()
            Return total
        End Get
    End Property

End Class
