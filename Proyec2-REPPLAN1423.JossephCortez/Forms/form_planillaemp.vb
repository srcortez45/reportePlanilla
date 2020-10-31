
Imports Calculos
Public Class form_planillaemp
    Dim calculos As calculos = calculos.Instancia
    Dim condicion As Boolean = True
    Dim totalregistros As String
    Dim conexion As conexion = conexion.Instancia
    Dim pos As Integer = 0

    Sub mostrar()
        conexion.traerRegistro(pos.ToString)
        calcularPago()
        enviarDatoPago()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If pos = Integer.Parse(totalregistros) Then
            condicion = False
            btn_aceptar.Visible = False
            MsgBox("EL ULTIMO REGISTRO YA FUE LEÍDO")
        End If
        If condicion Then
            pos += 1
            Me.Hide()
            mostrar()
            Me.Show()
        End If
    End Sub

    Private Sub form_planillaemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalregistros = conexion.totalRegistros()
    End Sub

    Private Sub calcularPago()

        lb_salario_quincenal.Text = calculos.calcularSalarioQuincenal(lb_salario_mensual.Text)

        lb_porc_impRenta.Text = calculos.calcularPorcImpRenta(lb_sexo.Text)
        lb_porc_renta.Text = Val((lb_porc_impRenta.Text) * 100)
        lb_monto_impRenta.Text = calculos.calcularMontoImpRenta(lb_salario_quincenal.Text, lb_porc_impRenta.Text)


        lb_seg_social.Text = calculos.calcularMontoSegSocial(lb_salario_quincenal.Text)
        lb_seg_edu.Text = calculos.calcularMontoSegEducativo(lb_salario_quincenal.Text)

        lb_monto_otros_desc.Text = calculos.calcularMonto_OtrosDesc(lb_salario_quincenal.Text, lb_porc_otros_desc.Text)
        lb_total_desc.Text = calculos.calcularTotalDesc(lb_monto_impRenta.Text, lb_seg_social.Text, lb_seg_edu.Text, lb_monto_otros_desc.Text)

        lb_salario_neto.Text = calculos.calcularSalarioNeto(lb_salario_quincenal.Text, lb_total_desc.Text)

        calculos.desgloseDinero(lb_salario_mensual.Text,
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
    End Sub
    Private Sub enviarDatoPago()
        conexion.enviarDatosPago(lb_cedula_emp.Text,
                                 lb_salario_quincenal.Text,
                                 lb_seg_social.Text,
                                 lb_seg_edu.Text,
                                 lb_monto_impRenta.Text,
                                 lb_monto_otros_desc.Text,
                                 lb_total_desc.Text,
                                 lb_salario_neto.Text)

    End Sub

End Class