
Imports MySql.Data.MySqlClient

Public MustInherit Class Conexion

    Private ReadOnly conexionString As String
    Protected Sub New()
        conexionString = "SERVER = 127.0.0.1; PORT=3306;DATABASE=dbplaniquin; UID= user;PWD=utp2020;SslMode = none;"
    End Sub

    Protected Function getConexion() As MySqlConnection
        Return New MySqlConnection(conexionString)
    End Function


End Class
