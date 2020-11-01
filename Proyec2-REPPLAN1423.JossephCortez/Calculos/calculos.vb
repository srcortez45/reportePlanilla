
Public Class Calculos


    Public Shared ReadOnly Property Instancia As Calculos
        Get
            Static INST As Calculos = New Calculos
            Return INST
        End Get
    End Property

    Public Function Redondear(dNumero As Double, iDecimales As Integer) As Double
        Dim lMultiplicador As Long
        Dim dRetorno As Double

        If iDecimales > 9 Then iDecimales = 9
        lMultiplicador = 10 ^ iDecimales
        dRetorno = CDbl(CLng(dNumero * lMultiplicador)) / lMultiplicador

        Redondear = dRetorno
    End Function



    Function CalcularSalarioQuincenal(ByVal salario_mensual As String) As String

        Return Redondear(salario_mensual / 2, 2)
    End Function


    Function CalcularPorcImpRenta(ByVal sexo As String) As String
        If (sexo.Equals("M")) Then
            Return 0.1575
        Else
            Return 0.1275
        End If
    End Function

    Function CalcularMontoImpRenta(ByVal salario_quincenal As String, ByVal PorcImpRenta As String) As String
        Return Redondear(salario_quincenal * PorcImpRenta, 2)
    End Function


    Function CalcularMontoSegSocial(ByVal salario_quincenal As String) As String
        Return Redondear(salario_quincenal * 0.0925, 2)
    End Function



    Function CalcularMontoSegEducativo(ByVal salario_quincenal As String) As String
        Return Redondear(salario_quincenal * 0.0125, 2)
    End Function



    Function CalcularMonto_OtrosDesc(ByVal salario_quincenal As String, ByVal otrosDesc As String) As String
        Return Redondear(salario_quincenal * (otrosDesc / 100), 2)
    End Function



    Function CalcularTotalDesc(ByVal ImpRenta As String, ByVal segSocial As String, ByVal segEduca As String, OtrosDesc As String) As String
        Return Redondear(Val(ImpRenta) + Val(segSocial) + Val(segEduca) + Val((OtrosDesc / 100)), 2)
    End Function


    Public Function CalcularSalarioNeto(ByVal salario_quincenal As String, ByVal totalDesc As String)
        Return Redondear(salario_quincenal - totalDesc, 2)
    End Function

    Public Sub MayorEmp(ByVal name As String, ByVal sal As String, ByRef sal_max As String, ByRef name_max As String)
        If sal > sal_max Then
            sal_max = sal
            name_max = name
        End If
    End Sub

    Public Sub MenorEmp(ByVal name As String, ByVal sal As String, ByRef sal_min As String, ByRef name_min As String)
        If sal_min = 0 Then
            sal_min = sal
            name_min = name
        End If
        If sal < sal_min Then
            sal_min = sal
            name_min = name
        End If
    End Sub


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
                monto = Redondear(monto, 2)


            End If
        Next


        txt_billetes50 = cantidadMonedas(0)
        txt_billetes20 = cantidadMonedas(1)
        txt_billetes10 = cantidadMonedas(2)
        txt_billetes5 = cantidadMonedas(3)
        txt_billetes1 = cantidadMonedas(4)


        txt_totalBilletes = Redondear((monedas(0) * cantidadMonedas(0)) + (monedas(1) * cantidadMonedas(1)) + (monedas(2) * cantidadMonedas(2)) + (monedas(3) * cantidadMonedas(3)) + (monedas(4) * cantidadMonedas(4)), 2)


        txt_monedas0_50 = cantidadMonedas(5)
        txt_monedas0_25 = cantidadMonedas(6)
        txt_monedas0_10 = cantidadMonedas(7)
        txt_monedas0_05 = cantidadMonedas(8)
        txt_monedas0_01 = cantidadMonedas(9)



        txt_totalMonedas = Redondear((monedas(5) * cantidadMonedas(5)) + (monedas(6) * cantidadMonedas(6)) + (monedas(7) * cantidadMonedas(7)) + (monedas(8) * cantidadMonedas(8)) + (monedas(9) * cantidadMonedas(9)), 2)


        txt_totalDesgloce = Val(txt_totalBilletes) + Val(txt_totalMonedas)

    End Sub


End Class
