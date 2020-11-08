Imports System.Security.Cryptography

Public Class SHA2
    Public Shared Function GetSHA256(clave As String) As String
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
End Class
