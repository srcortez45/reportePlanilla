﻿
Public Class form_planillaemp
    ReadOnly calculos As Calculos = Calculos.Instancia
    ReadOnly tabla As Tabdetapla = Tabdetapla.Instancia
    ReadOnly pago As Tabdepago = Tabdepago.Instancia
    Dim totalregistros As String
    Dim pos As Integer

    'VARIABLES TEMPORALES PARA GUARDAR LOS DATOS SOLICITADOS

    Dim TotalPlanilla As Double

    Dim name_min, name_max, sal_min, sal_max As String

    Dim name_min_M, name_max_M, sal_min_M, sal_max_M As String

    Dim name_min_F, name_max_F, sal_min_F, sal_max_F As String

    'SE VERIFICA EL TOTAL DE REGISTROS
    Private Sub form_planillaemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalregistros = tabla.TotalRegistros
        Mostrar()
    End Sub

    'SE CARGA EL REGISTRO, SE REALIZAN LOS CALCULOS, SE ENVIAN LOS DATOS DE PAGO 
    'Y SE NORMALIZA LA SALIDA PARA QUE SE MUESTRE CORRECTAMENTE 
    Private Sub Mostrar()
        tabla.TraerRegistro(pos.ToString)
        CalcularPago()
        EnviarDatoPago()
        NormalizarSalida()
        pos += 1
    End Sub

    'MIENTRAS LA CONDICION SEA VERDADERA SE VOLVERA A MOSTRAR EL SIGUIENTE REGISTRO
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If pos = Integer.Parse(totalregistros) Then
            btn_aceptar.Visible = False
            Dim resp As Integer = MsgBox("¿Desea ver el resumen de la planilla?", MsgBoxStyle.YesNo, "INFORMACIÓN")
            If (resp = MsgBoxResult.Yes) Then
                form_resumenplan.EnviarMontoPlanilla(TotalPlanilla)

                form_resumenplan.AsignarResultados_Sal_neto(name_min, name_max, sal_min, sal_max)
                form_resumenplan.AsignarResultados_Men(name_min_M, name_max_M, sal_min_M, sal_max_M)
                form_resumenplan.AsignarResultados_Mujer(name_min_F, name_max_F, sal_min_F, sal_max_F)

                form_resumenplan.Show()
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Mostrar()
        End If





    End Sub

    Private Sub CalcularPago()

        lb_salario_quincenal.Text = calculos.CalcularSalarioQuincenal(lb_salario_mensual.Text)

        lb_porc_impRenta.Text = calculos.CalcularPorcImpRenta(lb_sexo.Text)
        lb_porc_renta.Text = Val((lb_porc_impRenta.Text) * 100)
        lb_monto_impRenta.Text = calculos.CalcularMontoImpRenta(lb_salario_quincenal.Text, lb_porc_impRenta.Text)


        lb_seg_social.Text = calculos.CalcularMontoSegSocial(lb_salario_quincenal.Text)
        lb_seg_edu.Text = calculos.CalcularMontoSegEducativo(lb_salario_quincenal.Text)

        lb_monto_otros_desc.Text = calculos.CalcularMonto_OtrosDesc(lb_salario_quincenal.Text, lb_porc_otros_desc.Text)
        lb_total_desc.Text = calculos.CalcularTotalDesc(lb_monto_impRenta.Text, lb_seg_social.Text, lb_seg_edu.Text, lb_monto_otros_desc.Text)

        lb_salario_neto.Text = calculos.CalcularSalarioNeto(lb_salario_quincenal.Text, lb_total_desc.Text)



        calculos.DesgloseDinero(lb_salario_mensual.Text,
                                txt_billetes50.Text,
                                txt_billetes20.Text,
                                txt_billetes10.Text,
                                txt_billetes5.Text,
                                txt_billetes1.Text,
                                txt_monedas0_50.Text,
                                txt_monedas0_25.Text,
                                txt_monedas0_10.Text,
                                txt_monedas0_05.Text,
                                txt_monedas0_01.Text,
                                lb_totalbilletes.Text,
                                lb_totalmonedas.Text,
                                lb_totaldesgloce.Text)

        TotalPlanilla += lb_totaldesgloce.Text
        Max_Mix_Sal()
    End Sub


    'MODULO PARA CALCULAR EL MAYOR Y MENOR
    Private Sub Max_Mix_Sal()


        calculos.MenorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                          name_min, sal_min)

        calculos.MayorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                          name_max, sal_max)

        If lb_sexo.Text.Equals("M") Then

            calculos.MenorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                              name_min_M, sal_min_M)

            calculos.MayorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                          name_max_M, sal_max_M)

        Else

            calculos.MenorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                              name_min_F, sal_min_F)

            calculos.MayorEmp(lb_empleado.Text, lb_salario_mensual.Text,
                         name_max_F, sal_max_F)
        End If

    End Sub

    'MODULO PARA ENVIAR LOS DATOS DE PAGO AL REGISTRO
    Private Sub EnviarDatoPago()
        If pago.VerificarRegistroPago(lb_cedula_emp.Text) Then

            pago.ActualizarDatosPago(lb_cedula_emp.Text,
                                 lb_salario_quincenal.Text,
                                 lb_seg_social.Text,
                                 lb_seg_edu.Text,
                                 lb_monto_impRenta.Text,
                                 lb_monto_otros_desc.Text,
                                 lb_total_desc.Text,
                                 lb_salario_neto.Text)
        Else
            pago.InsertarDatosPago(lb_cedula_emp.Text,
                     lb_salario_quincenal.Text,
                     lb_seg_social.Text,
                     lb_seg_edu.Text,
                     lb_monto_impRenta.Text,
                     lb_monto_otros_desc.Text,
                     lb_total_desc.Text,
                     lb_salario_neto.Text)


        End If

    End Sub

    'MODULO PARA NORMALIZAR LA SALIDA Y QUE SE MUESTRE CORRECTAMENTE
    Private Sub NormalizarSalida()
        lb_salario_mensual.Text += " $"
        lb_salario_quincenal.Text += " $"

        lb_porc_renta.Text += " %"

        lb_seg_social.Text += " $"
        lb_seg_edu.Text += " $"

        lb_porc_otros_desc.Text = "(" + lb_porc_otros_desc.Text + "%):"

        lb_porc_impRenta.Text = "(" & Val(lb_porc_impRenta.Text * 100) & "%):"
        lb_monto_impRenta.Text += " $"

        lb_total_desc.Text += " $"
        lb_salario_neto.Text += " $"
    End Sub

End Class