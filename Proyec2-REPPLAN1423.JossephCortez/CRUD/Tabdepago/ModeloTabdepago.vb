Public Class ModeloTabdepago


    ReadOnly TabdepagoDAO As New TabdepagoDAO()

    'RETORNA LAS LAS FUNCIONES DE TABDEPAGODAO

    Public Function VerificarRegistroPago(cedula As String) As Boolean
        Return TabdepagoDAO.VerificarRegistroPago(cedula)
    End Function

    Public Sub InsertarDatosPago(cedula As String, salario_quincenal As String, seg_social As String, seg_edu As String, imp_renta As String, monto_otros_desc As String, total_desc As String, salario_neto As String)
        TabdepagoDAO.InsertarDatosPago(cedula, salario_quincenal, seg_social, seg_edu, imp_renta, monto_otros_desc, total_desc, salario_neto)
    End Sub

    Public Sub ActualizarDatosPago(cedula As String, salario_quincenal As String, seg_social As String, seg_edu As String, imp_renta As String, monto_otros_desc As String, total_desc As String, salario_neto As String)
        TabdepagoDAO.ActualizarDatosPago(cedula, salario_quincenal, seg_social, seg_edu, imp_renta, monto_otros_desc, total_desc, salario_neto)
    End Sub

    Public Sub EliminarDatosPago(cedula As String)
        TabdepagoDAO.EliminarDatosPago(cedula)
    End Sub



End Class
