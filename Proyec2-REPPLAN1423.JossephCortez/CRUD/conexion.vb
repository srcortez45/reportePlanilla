
Imports MySql.Data.MySqlClient

'CLASE CONEXION
Public MustInherit Class Conexion

    Private ReadOnly conexionString As String

    'CONEXION
    Protected Sub New()
        conexionString = "SERVER = 127.0.0.1; PORT=3306;DATABASE=dbplaniquin; UID= user;PWD=utp2020;SslMode = none;"
    End Sub

    'RETORNA LA CONEXION
    Protected Function getConexion() As MySqlConnection
        Return New MySqlConnection(conexionString)
    End Function


End Class
