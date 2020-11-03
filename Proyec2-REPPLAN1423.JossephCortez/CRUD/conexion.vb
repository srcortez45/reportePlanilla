
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient



Public Class Conexion


    'MODULO DE INSTANCIA DE LA CLASE

    Public Shared ReadOnly sqlconexion As MySqlConnection = New MySqlConnection
    Public Shared ReadOnly sqlcomandos As MySqlCommand = New MySqlCommand

    'MODULO PARA VERIFICAR LA CONEXION CON EL SERVIDOR
    Public Sub Conectarbd()


        sqlcomandos.Connection = sqlconexion
        Try
            sqlconexion.ConnectionString = "SERVER = 127.0.0.1; PORT=3306;DATABASE=dbplaniquin; UID= user;PWD=utp2020;SslMode = none;"

            sqlconexion.Open()
            Debug.WriteLine("CONEXION EXITOSA")

        Catch ex As MySqlException
            Debug.WriteLine(ex.ErrorCode)
            If ex.ErrorCode = -2147467259 Then
                Debug.WriteLine("CODIGO DE ERROR login:" & ex.ErrorCode)
                form_login = New form_login
            End If


        End Try
        sqlconexion.Close()

    End Sub

    Public Sub New(user As String, pass As String)
        Conectarbd()
        VerificarUser(user, pass)

    End Sub

    Public Function GetSHA256(clave As String) As String
        Dim encrip As SHA256 = SHA256.Create()
        Dim encoding As Text.ASCIIEncoding = New Text.ASCIIEncoding
        Dim stream() As Byte
        Dim secret As String = ""

        stream = encrip.ComputeHash(encoding.GetBytes(clave))

        For Each b As Byte In stream
            secret += b.ToString("x2")
        Next
        Return secret
    End Function

    Public Sub VerificarUser(user As String, pass As String)
        Dim lector As MySqlDataReader
        pass = GetSHA256(pass)
        sqlconexion.Open()
        sqlcomandos.Connection = sqlconexion
        sqlcomandos.CommandText = "SELECT * FROM Tabdelogin WHERE cedula =" & user
        lector = sqlcomandos.ExecuteReader()
        Try
            While lector.Read()
                If lector.GetString(1).Equals("") Then
                    If lector.GetString(0).Equals(user) Then
                        If lector.GetString(1).Equals(pass) Then
                            MsgBox("Usuario Autenticado")
                        End If
                        MsgBox("La contraseña no coincide")
                    Else
                        MsgBox("La contraseña o el usuario son invalidos")
                    End If
                Else
                    Dim resp = InputBox("Porfavor ingrese una clave para su cuenta", "PRIMER INGRESO", "PORFAVOR INGRESE UNA CONTRASEÑA VALIDA")
                    Debug.WriteLine(resp)
                End If

            End While
        Catch ex As Exception

        End Try
        sqlconexion.Close()
    End Sub


End Class
