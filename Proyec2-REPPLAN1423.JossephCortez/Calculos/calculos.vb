Public Class calculos


    Public Shared ReadOnly Property Instancia As calculos
        Get
            Static INST As calculos = New calculos
            Return INST
        End Get
    End Property

    Function redondear(valor As String) As String
        Dim temp As Double = Convert.ToDouble(valor)
        Return Math.Round(temp, 2)
    End Function

    Function calcularSalarioQuincenal(ByVal salario_mensual As String) As String
        Return redondear(salario_mensual / 2)
    End Function


    Function calcularPorcImpRenta(ByVal sexo As String) As String
        If (sexo.Equals("M")) Then
            Return 0.1575
        Else
            Return 0.1275
        End If
    End Function

    Function calcularMontoImpRenta(ByVal salario_quincenal As String, ByVal PorcImpRenta As String) As String
        Return redondear(salario_quincenal * PorcImpRenta)
    End Function


    Function calcularMontoSegSocial(ByVal salario_quincenal As String) As String
        Return redondear(salario_quincenal * 0.0925)
    End Function



    Function calcularMontoSegEducativo(ByVal salario_quincenal As String) As String
        Return redondear(salario_quincenal * 0.0125)
    End Function



    Function calcularMonto_OtrosDesc(ByVal salario_quincenal As String, ByVal otrosDesc As String) As String
        Return redondear(salario_quincenal * (otrosDesc / 100))
    End Function



    Function calcularTotalDesc(ByVal ImpRenta As String, ByVal segSocial As String, ByVal segEduca As String, OtrosDesc As String) As String
        Return redondear(Val(ImpRenta) + Val(segSocial) + Val(segEduca) + Val((OtrosDesc / 100)))
    End Function


    Function calcularSalarioNeto(ByVal salario_quincenal As String, ByVal totalDesc As String)
        Return redondear(salario_quincenal - totalDesc)
    End Function


    Sub desgloseDinero(ByVal monto As Double,
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
        Dim cont As Integer = monedas.Length


        For cont = 0 To 9
            If monto >= monedas(cont) Then
                cantidadMonedas(cont) = Math.Floor(monto / monedas(cont))
                monto = monto - (cantidadMonedas(cont) * monedas(cont))
            End If
        Next



        txt_billetes50 = cantidadMonedas(0)
        txt_billetes20 = cantidadMonedas(1)
        txt_billetes10 = cantidadMonedas(2)
        txt_billetes5 = cantidadMonedas(3)
        txt_billetes1 = cantidadMonedas(4)

        txt_totalBilletes = (((txt_billetes50) * cantidadMonedas(0)) + ((txt_billetes20) * cantidadMonedas(1) + ((txt_billetes10) * cantidadMonedas(2)) + ((txt_billetes5)) * cantidadMonedas(3)) + ((txt_billetes1) * cantidadMonedas(4)))

        txt_monedas0_50 = cantidadMonedas(5)
        txt_monedas0_25 = cantidadMonedas(6)
        txt_monedas0_10 = cantidadMonedas(7)
        txt_monedas0_05 = cantidadMonedas(8)
        txt_monedas0_01 = cantidadMonedas(9)

        txt_totalMonedas = ((txt_monedas0_50) * cantidadMonedas(5)) + ((txt_monedas0_25) * cantidadMonedas(6)) + ((txt_monedas0_10) * cantidadMonedas(7)) + ((txt_monedas0_05) * cantidadMonedas(8)) + ((txt_monedas0_01) * cantidadMonedas(9))


        txt_totalDesgloce = (txt_totalBilletes) + (txt_totalMonedas)
    End Sub


End Class
