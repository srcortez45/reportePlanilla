
Imports MySql.Data.MySqlClient

Public Class UsuarioDAO
    Inherits Conexion

    'MODULO DE LOGIN 
    Public Function Login(user As String, pass As String) As Boolean
        Using conexion = getConexion()
            conexion.Open()
            Using Sqlcomandos = New MySqlCommand()
                pass = SHA2.GetSHA256(pass)
                Sqlcomandos.Connection = conexion
                Sqlcomandos.CommandText = "SELECT * FROM tabdelogin where cedula = @cedula and pass=@pass"
                Sqlcomandos.Parameters.AddWithValue("@cedula", user)
                Sqlcomandos.Parameters.AddWithValue("@pass", pass)
                Sqlcomandos.CommandType = CommandType.Text
                Dim lector = Sqlcomandos.ExecuteReader()

                If lector.HasRows Then
                    While lector.Read()
                        cedula = lector.GetString(0)
                        tipo_usuario = lector.GetString(2)

                    End While
                    lector.Dispose()
                    Return True
                Else
                    Return False
                End If

            End Using

        End Using

    End Function

End Class
