﻿Public Class ModeloUsuario
    ReadOnly usuarioDao As New usuarioDAO()

    Public Function Login(user As String, pass As String) As Boolean
        Return usuarioDao.Login(user, pass)
    End Function

End Class