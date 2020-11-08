
Imports MySql.Data.MySqlClient

'HEREDA LA CLASE CONEXION PARA LA DB
Public Class TabdepagoDAO
    Inherits Conexion

    'Verifica los registros de pago
    ReadOnly Property VerificarRegistroPago(cedula As String) As Boolean
        Get
            Using Conexion = getConexion()
                Conexion.Open()
                Using Sqlcomandos = New MySqlCommand()
                    Sqlcomandos.Connection = Conexion
                    Sqlcomandos.CommandText = "SELECT CEDULA FROM `tabdepago` WHERE cedula=@cedula"
                    Sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
                    Dim lector = Sqlcomandos.ExecuteReader()
                    While lector.Read()
                        If cedula.Equals(lector.GetString(0)) Then
                            VerificarRegistroPago = True
                        Else
                            VerificarRegistroPago = False
                        End If

                    End While

                End Using
            End Using
            Return VerificarRegistroPago
        End Get
    End Property


    'MODULO PARA ENVIAR LOS DATOS DE PAGO DEL EMPLEADO
    Public Sub InsertarDatosPago(cedula As String, salario_quincenal As String, seg_social As String, seg_edu As String, imp_renta As String, monto_otros_desc As String, total_desc As String, salario_neto As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "INSERT INTO `tabdepago`(`cedula`, `salario_quincenal`, `seguro_social`, `seguro_educativo`, `imp_renta`, `monto_otros_desc`, `total_desc`, `salario_neto`) VALUES (?cedula,?salario_quincenal,?seguro_social,?seguro_educativo,?imp_renta,?monto_otros_desc,?total_desc,?salario_neto)"
                Sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
                Sqlcomandos.Parameters.AddWithValue("?salario_quincenal", salario_quincenal)
                Sqlcomandos.Parameters.AddWithValue("?seguro_social", seg_social)
                Sqlcomandos.Parameters.AddWithValue("?seguro_educativo", seg_edu)
                Sqlcomandos.Parameters.AddWithValue("?imp_renta", imp_renta)
                Sqlcomandos.Parameters.AddWithValue("?monto_otros_desc", monto_otros_desc)
                Sqlcomandos.Parameters.AddWithValue("?total_desc", total_desc)
                Sqlcomandos.Parameters.AddWithValue("?salario_neto", salario_neto)
                Sqlcomandos.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    'MODULO PARA ACTUALIZAR LOS DATOS DE PAGO DEL EMPLEADO
    Public Sub ActualizarDatosPago(cedula As String, salario_quincenal As String, seg_social As String, seg_edu As String, imp_renta As String, monto_otros_desc As String, total_desc As String, salario_neto As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "UPDATE tabdepago SET salario_quincenal=@salario_quincenal,seguro_social=@seguro_social,seguro_educativo=@seguro_educativo,imp_renta=@imp_renta,monto_otros_desc=@monto_otros_desc,total_desc=@total_desc,salario_neto=@salario_neto WHERE cedula = @cedula"
                Sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
                Sqlcomandos.Parameters.AddWithValue("@salario_quincenal", salario_quincenal)
                Sqlcomandos.Parameters.AddWithValue("@seguro_social", seg_social)
                Sqlcomandos.Parameters.AddWithValue("@seguro_educativo", seg_edu)
                Sqlcomandos.Parameters.AddWithValue("@imp_renta", imp_renta)
                Sqlcomandos.Parameters.AddWithValue("@monto_otros_desc", monto_otros_desc)
                Sqlcomandos.Parameters.AddWithValue("@total_desc", total_desc)
                Sqlcomandos.Parameters.AddWithValue("@salario_neto", salario_neto)
                Sqlcomandos.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'MODULO PARA ELIMINAR LOS DATOS DE PAGO DEL EMPLEADO
    Public Sub EliminarDatosPago(cedula As String)
        Using Conexion = getConexion()
            Conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                Sqlcomandos.Connection = Conexion
                Sqlcomandos.CommandText = "DELETE FROM `tabdetapla` WHERE `cedula`=  ?cedula "
                Sqlcomandos.Parameters.AddWithValue("?cedula", cedula)
                Sqlcomandos.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
