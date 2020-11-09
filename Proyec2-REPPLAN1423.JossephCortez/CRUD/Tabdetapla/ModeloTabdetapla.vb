Public Class ModeloTabdetapla
    ReadOnly tabdetaplaDAO As New TabdetaplaDAO()


    'RETORNA LAS FUNCIONES DE LA CLASE TABDETAPLA



    Public Function VerificarRegistro(cedula As String) As Boolean
        Return tabdetaplaDAO.VerificarRegistro(cedula)
    End Function

    Public Sub TraerRegistro(cedula As String, Optional ByVal condicion As Boolean = True)
        tabdetaplaDAO.TraerRegistro(cedula, condicion)
    End Sub

    Public Function VerRegistros(datos As DataGridView) As DataGridView
        Return tabdetaplaDAO.VerRegistros(datos)
    End Function

    Public Sub AgregarRegistro(cedula As String, empleado As String, sexo As String, salario_mensual As String, otros_desc As String)
        tabdetaplaDAO.AgregarRegistro(cedula, empleado, sexo, salario_mensual, otros_desc)
    End Sub

    Public Sub EliminarRegistro(cedula As String)
        tabdetaplaDAO.EliminarRegistro(cedula)
    End Sub

    Public Sub ActualizarRegistro(cedula As String, empleado As String, sexo As String, salario_mensual As String, otros_desc As String)
        tabdetaplaDAO.ActualizarRegistro(cedula, empleado, sexo, salario_mensual, otros_desc)
    End Sub

    Public Sub PasarRegistro(pos As String)
        tabdetaplaDAO.PasarRegistro(pos)
    End Sub

    ReadOnly Property TotalRegistros()
        Get
            Return tabdetaplaDAO.TotalRegistros()
        End Get
    End Property



End Class
