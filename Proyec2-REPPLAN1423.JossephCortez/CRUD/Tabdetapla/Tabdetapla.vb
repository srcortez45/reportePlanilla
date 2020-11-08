﻿Imports MySql.Data.MySqlClient

Public Class Tabdetapla
    Inherits Conexion

    Public Shared ReadOnly Property Instancia As Tabdetapla
        Get
            Static INST As Tabdetapla = New Tabdetapla()
            Return INST
        End Get
    End Property

    Public Function VerificarRegistro(cedula As String) As Boolean
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "SELECT cedula from tabdetapla where cedula = @cedula"
                Sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
                Dim lector = Sqlcomandos.ExecuteReader()

                Return lector.HasRows

            End Using
        End Using
    End Function


    Public Sub VerRegistros(datos As DataGridView)

        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()

                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "Select * FROM tabdetapla"

                Dim dt As DataTable = New DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(Sqlcomandos)

                da.Fill(dt)
                datos.DataSource = dt

            End Using

        End Using

    End Sub


    'MODULO PARA AGREGAR REGISTRO
    Public Sub AgregarRegistro(cedula As String, empleado As String, sexo As String, salario_mensual As String, otros_desc As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "INSERT INTO `tabdetapla`(`cedula`,`empleado`, `sexo`, `salario_mensual`, `otros_desc`) VALUES (?cedula,?empleado,?sexo,?salario_mensual,?otros_desc)"
                Sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
                Sqlcomandos.Parameters.AddWithValue("?empleado", empleado)
                Sqlcomandos.Parameters.AddWithValue("?sexo", sexo)
                Sqlcomandos.Parameters.AddWithValue("?salario_mensual", salario_mensual)
                Sqlcomandos.Parameters.AddWithValue("?otros_desc", otros_desc)
                Sqlcomandos.ExecuteNonQuery()

            End Using

        End Using
    End Sub


    'MODULO PARA ELIMINAR REGISTRO
    Public Sub EliminarRegistro(cedula As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "DELETE FROM `tabdetapla` WHERE `cedula`=  ?cedula "
                Sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
                Sqlcomandos.ExecuteNonQuery()

            End Using

        End Using
        MsgBox("EL REGISTRO HA SIDO ELIMINADO", MsgBoxStyle.OkOnly, "INFORMACIÓN DE DATOS")

    End Sub


    'MODULO PARA ACTUALIZAR REGISTRO
    Public Sub ActualizarRegistro(cedula As String, empleado As String, sexo As String, salario_mensual As String, otros_desc As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "UPDATE `tabdetapla` SET cedula = @cedula ,empleado = @empleado, sexo = @sexo, salario_mensual = @salario_mensual, otros_desc = @otros_desc WHERE cedula = @cedula"
                Sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
                Sqlcomandos.Parameters.AddWithValue("@empleado", empleado)
                Sqlcomandos.Parameters.AddWithValue("@sexo", sexo)
                Sqlcomandos.Parameters.AddWithValue("@salario_mensual", salario_mensual)
                Sqlcomandos.Parameters.AddWithValue("@otros_desc", otros_desc)
                Sqlcomandos.ExecuteNonQuery()

            End Using

        End Using
        MsgBox("EL REGISTRO HA SIDO ACTUALIZADO", MsgBoxStyle.OkOnly, "INFORMACIÓN DE DATOS")
    End Sub


    'MODULO PARA TRAER REGISTRO
    Public Sub TraerRegistro(pos As String)

        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "SELECT * FROM tabdetapla LIMIT " + pos + ", 1"
                Dim lector = Sqlcomandos.ExecuteReader()
                While lector.Read()
                    form_planillaemp.lb_cedula_emp.Text = lector.GetString(0)
                    form_planillaemp.lb_empleado.Text = lector.GetString(1)
                    form_planillaemp.lb_firma_emp.Text = lector.GetString(1)
                    form_planillaemp.lb_sexo.Text = lector.GetString(2)
                    form_planillaemp.lb_salario_mensual.Text = lector.GetDecimal(3)
                    form_planillaemp.lb_porc_otros_desc.Text = lector.GetDecimal(4)
                End While
                lector.Dispose()

            End Using

        End Using

    End Sub
    ReadOnly Property TotalRegistros As String
        Get
            Using Conexion = getConexion()
                Conexion.Open()
                Using Sqlcomandos = New MySqlCommand()
                    Sqlcomandos.Connection = Conexion
                    Sqlcomandos.CommandText = "Select Count(*) from tabdetapla"
                    Dim total = Convert.ToString(Sqlcomandos.ExecuteScalar())
                    Sqlcomandos.Dispose()
                    Conexion.Dispose()
                    Return total
                End Using
            End Using
        End Get
    End Property

End Class
