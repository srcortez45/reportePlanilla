﻿Public Class ModeloTabdetapla
    ReadOnly tabdetaplaDAO As New TabdetaplaDAO()


    Public Function VerificarRegistro(cedula As String) As Boolean
        Return tabdetaplaDAO.VerificarRegistro(cedula)
    End Function

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

    Public Sub TraerRegistro(pos As String)
        tabdetaplaDAO.TraerRegistro(pos)
    End Sub

    ReadOnly Property TotalRegistros()
        Get
            Return tabdetaplaDAO.TotalRegistros()
        End Get
    End Property



End Class
