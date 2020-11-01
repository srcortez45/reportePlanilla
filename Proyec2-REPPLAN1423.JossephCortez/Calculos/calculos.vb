Public Class Calculos


    Public Shared ReadOnly Property Instancia As Calculos
        Get
            Static INST As Calculos = New Calculos
            Return INST
        End Get
    End Property

    Function Redondear(valor As String) As String
        Dim temp As Double = Convert.ToDouble(valor)
        Return Math.Round(temp, 2, MidpointRounding.ToEven)
    End Function

    Function CalcularSalarioQuincenal(ByVal salario_mensual As String) As String
        Return Redondear(salario_mensual / 2)
    End Function


    Function CalcularPorcImpRenta(ByVal sexo As String) As String
        If (sexo.Equals("M")) Then
            Return 0.1575
        Else
            Return 0.1275
        End If
    End Function

    Function CalcularMontoImpRenta(ByVal salario_quincenal As String, ByVal PorcImpRenta As String) As String
        Return Redondear(salario_quincenal * PorcImpRenta)
    End Function


    Function CalcularMontoSegSocial(ByVal salario_quincenal As String) As String
        Return Redondear(salario_quincenal * 0.0925)
    End Function



    Function CalcularMontoSegEducativo(ByVal salario_quincenal As String) As String
        Return Redondear(salario_quincenal * 0.0125)
    End Function



    Function CalcularMonto_OtrosDesc(ByVal salario_quincenal As String, ByVal otrosDesc As String) As String
        Return Redondear(salario_quincenal * (otrosDesc / 100))
    End Function



    Function CalcularTotalDesc(ByVal ImpRenta As String, ByVal segSocial As String, ByVal segEduca As String, OtrosDesc As String) As String
        Return Redondear(Val(ImpRenta) + Val(segSocial) + Val(segEduca) + Val((OtrosDesc / 100)))
    End Function


    Public Function CalcularSalarioNeto(ByVal salario_quincenal As String, ByVal totalDesc As String)
        Return Redondear(salario_quincenal - totalDesc)
    End Function

    Private Function RoundUp(value As Double, decimals As Integer) As Double

        Return Math.Ceiling(value * (10 ^ decimals)) / (10 ^ decimals)

    End Function
    Public Function Redondear2_0(dNumero As Double, iDecimales As Integer) As Double
        Dim lMultiplicador As Long
        Dim dRetorno As Double

        If iDecimales > 9 Then iDecimales = 9
        lMultiplicador = 10 ^ iDecimales
        dRetorno = CDbl(CLng(dNumero * lMultiplicador)) / lMultiplicador

        Redondear2_0 = dRetorno
    End Function


    Public Sub DesgloseDinero(ByVal monto As Double,
                               ByRef txt_billetes50 As String,
                               ByRef txt_billetes20 As String,
                               ByRef txt_billetes10 As String,
                               ByRef txt_billetes5 As String,
                               ByRef txt_billetes1 As String,
                               ByRef txt_monedas0_50 As String,
                               ByRef txt_monedas0_25 As String,
                               ByRef txt_monedas0_10 As String,
                               ByRef txt_monedas0_05 As String,
                               ByRef txt_monedas0_01 As String,
                               ByRef txt_totalBilletes As String,
                               ByRef txt_totalMonedas As String,
                               ByRef txt_totalDesgloce As String)


        Dim monedas() As Double = {50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}
        Dim cantidadMonedas() As Double = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim cont As Integer

        For cont = 0 To 9
            If monto >= monedas(cont) Then
                cantidadMonedas(cont) = Math.Floor(monto / monedas(cont))
                monto -= (cantidadMonedas(cont) * monedas(cont))
                monto = Redondear2_0(monto, 2)


            End If
        Next


        txt_billetes50 = cantidadMonedas(0)
        txt_billetes20 = cantidadMonedas(1)
        txt_billetes10 = cantidadMonedas(2)
        txt_billetes5 = cantidadMonedas(3)
        txt_billetes1 = cantidadMonedas(4)


        txt_totalBilletes = (monedas(0) * cantidadMonedas(0)) + (monedas(1) * cantidadMonedas(1)) + (monedas(2) * cantidadMonedas(2)) + (monedas(3) * cantidadMonedas(3)) + (monedas(4) * cantidadMonedas(4))


        txt_monedas0_50 = cantidadMonedas(5)
        txt_monedas0_25 = cantidadMonedas(6)
        txt_monedas0_10 = cantidadMonedas(7)
        txt_monedas0_05 = cantidadMonedas(8)
        txt_monedas0_01 = cantidadMonedas(9)



        txt_totalMonedas = (monedas(5) * cantidadMonedas(5)) + (monedas(6) * cantidadMonedas(6)) + (monedas(7) * cantidadMonedas(7)) + (monedas(8) * cantidadMonedas(8)) + (monedas(9) * cantidadMonedas(9))


        txt_totalDesgloce = Val(txt_totalBilletes) + Val(txt_totalMonedas)

    End Sub


End Class
