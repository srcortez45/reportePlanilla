
Public Class Tabdepago
    Public Shared ReadOnly Property Instancia As Tabdepago
        Get
            Static INST As Tabdepago = New Tabdepago()
            Return INST
        End Get
    End Property
    'MODULO PARA ENVIAR LOS DATOS DE PAGO DEL EMPLEADO
    Public Sub EnviarDatosPago(ByVal cedula As String, ByVal salario_quincenal As String, ByVal seg_social As String, ByVal seg_edu As String, ByVal imp_renta As String, ByVal monto_otros_desc As String, ByVal total_desc As String, ByVal salario_neto As String)
        Conexion.sqlconexion.Open()
        Conexion.sqlcomandos.Connection = Conexion.sqlconexion
        Conexion.sqlcomandos.CommandText = "UPDATE `tabdepago` SET salario_quincenal = @salario_quincenal, seguro_social = @seguro_social,seguro_educativo = @seguro_educativo, imp_renta = @imp_renta, monto_otros_desc = @monto_otros_desc ,total_desc = @total_desc ,salario_neto = @salario_neto WHERE cedula = @cedula"
        Conexion.sqlcomandos.Parameters.AddWithValue("@cedula", cedula)
        Conexion.sqlcomandos.Parameters.AddWithValue("@salario_quincenal", salario_quincenal)
        Conexion.sqlcomandos.Parameters.AddWithValue("@seguro_social", seg_social)
        Conexion.sqlcomandos.Parameters.AddWithValue("@seguro_educativo", seg_edu)
        Conexion.sqlcomandos.Parameters.AddWithValue("@imp_renta", imp_renta)
        Conexion.sqlcomandos.Parameters.AddWithValue("@monto_otros_desc", monto_otros_desc)
        Conexion.sqlcomandos.Parameters.AddWithValue("@total_desc", total_desc)
        Conexion.sqlcomandos.Parameters.AddWithValue("@salario_neto", salario_neto)


        Conexion.sqlcomandos.ExecuteNonQuery()
        Conexion.sqlcomandos.Parameters.Clear()
        Conexion.sqlconexion.Close()


    End Sub

End Class
