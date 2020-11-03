Imports MySql.Data.MySqlClient
Public Class Tabdetapla

    'MODULO PARA VER LOS REGISTROS
    Public Shared ReadOnly Property Instancia As Tabdetapla
        Get
            Static INST As Tabdetapla = New Tabdetapla()
            Return INST
        End Get
    End Property


    Public Sub VerRegistros(ByVal datos As DataGridView)
        Try
            Conexion.sqlconexion.Open()
            Conexion.sqlcomandos.Connection = Conexion.sqlconexion
            Conexion.sqlcomandos.CommandText = "SELECT * FROM tabdetapla"

            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(Conexion.sqlcomandos)

            da.Fill(dt)
            datos.DataSource = dt
            Conexion.sqlconexion.Close()

        Catch ex As MySqlException
            If ex.ErrorCode = -2147467259 Then
                form_login.Show()
                form_consultar.Close()
            End If
        End Try



    End Sub


    'MODULO PARA AGREGAR REGISTRO
    Public Sub AgregarRegistro(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        Conexion.sqlconexion.Open()
        Conexion.sqlcomandos.Connection = Conexion.sqlconexion
        Conexion.sqlcomandos.CommandText = "INSERT INTO `tabdetapla`(`cedula`,`empleado`, `sexo`, `salario_mensual`, `otros_desc`) VALUES (?cedula,?empleado,?sexo,?salario_mensual,?otros_desc)"
        Conexion.sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
        Conexion.sqlcomandos.Parameters.AddWithValue("?empleado", empleado)
        Conexion.sqlcomandos.Parameters.AddWithValue("?sexo", sexo)
        Conexion.sqlcomandos.Parameters.AddWithValue("?salario_mensual", salario_mensual)
        Conexion.sqlcomandos.Parameters.AddWithValue("?otros_desc", otros_desc)
        Conexion.sqlcomandos.ExecuteNonQuery()
        Conexion.sqlcomandos.Parameters.Clear()
        Conexion.sqlconexion.Close()
        MsgBox("EL REGISTRO SE AÑADIO CON EXITO", MsgBoxStyle.OkOnly, "INFORMACIÓN DE DATOS")

    End Sub


    'MODULO PARA ELIMINAR REGISTRO
    Public Sub EliminarRegistro(ByVal cedula As String)
        Conexion.sqlconexion.Open()
        Conexion.sqlcomandos.Connection = Conexion.sqlconexion
        Conexion.sqlcomandos.CommandText = "DELETE FROM `tabdetapla` WHERE `cedula`=  ?cedula "
        Conexion.sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
        Conexion.sqlcomandos.ExecuteNonQuery()
        Conexion.sqlcomandos.Parameters.Clear()
        Conexion.sqlconexion.Close()
        MsgBox("EL REGISTRO HA SIDO ELIMINADO", MsgBoxStyle.OkOnly, "INFORMACIÓN DE DATOS")
    End Sub


    'MODULO PARA ACTUALIZAR REGISTRO
    Public Sub ActualizarRegistro(ByVal cedula As String, ByVal empleado As String, ByVal sexo As String, ByVal salario_mensual As String, ByVal otros_desc As String)
        Conexion.sqlconexion.Open()
        Conexion.sqlcomandos.Connection = Conexion.sqlconexion
        Conexion.sqlcomandos.CommandText = "UPDATE `tabdetapla` SET cedula = @cedula ,empleado = @empleado, sexo = @sexo, salario_mensual = @salario_mensual, otros_desc = @otros_desc WHERE cedula = @cedula"
        Conexion.sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
        Conexion.sqlcomandos.Parameters.AddWithValue("@empleado", empleado)
        Conexion.sqlcomandos.Parameters.AddWithValue("@sexo", sexo)
        Conexion.sqlcomandos.Parameters.AddWithValue("@salario_mensual", salario_mensual)
        Conexion.sqlcomandos.Parameters.AddWithValue("@otros_desc", otros_desc)
        Conexion.sqlcomandos.ExecuteNonQuery()
        Conexion.sqlcomandos.Parameters.Clear()
        Conexion.sqlconexion.Close()
        MsgBox("EL REGISTRO HA SIDO ACTUALIZADO", MsgBoxStyle.OkOnly, "INFORMACIÓN DE DATOS")
    End Sub


    'MODULO PARA TRAER REGISTRO
    Public Sub TraerRegistro(ByVal pos As String)
        Dim lector As MySqlDataReader

        Conexion.sqlconexion.Open()
        Conexion.sqlcomandos.Connection = Conexion.sqlconexion
        Conexion.sqlcomandos.CommandText = "SELECT * FROM tabdetapla LIMIT " + pos + ", 1"
        lector = Conexion.sqlcomandos.ExecuteReader()
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
        Conexion.sqlconexion.Close()

    End Sub
    ReadOnly Property TotalRegistros As String
        Get
            Dim total As String
            Conexion.sqlconexion.Open()
            Conexion.sqlcomandos.Connection = Conexion.sqlconexion
            Conexion.sqlcomandos.CommandText = "Select Count(*) from tabdetapla"
            Try
                total = Convert.ToString(Conexion.sqlcomandos.ExecuteScalar())
            Catch ex As Exception
                total = 0
            End Try
            Conexion.sqlconexion.Close()
            Return total
        End Get
    End Property

End Class
