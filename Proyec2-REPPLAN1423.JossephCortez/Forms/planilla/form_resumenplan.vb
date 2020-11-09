
Public Class form_resumenplan
    ReadOnly calculos As Calculos = Calculos.Instancia

    'SE ENVIAN LOS DATOS DEL TOTAL FINAL PARA REALIZAR EL DESGLOCE DE LA PLANILLA
    Private Sub form_resumenplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculos.DesgloseDinero(lb_totalfinal.Text,
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
                                lb_totalfinal.Text)


    End Sub

    'REALIZA LA PETICIÓN DEL TOTAL FINAL 
    'AL FORMULARIO PLANILLA EMP
    Public Sub EnviarMontoPlanilla(ByRef monto)
        Me.lb_totalfinal.Text = monto
    End Sub

    'REALIZA LA PETICIÓN DE LOS DATOS DE MAYOR Y MENOR SALARIO 
    'AL FORMULARIO PLANILLA EMP
    Public Sub AsignarResultados_Sal_neto(ByRef sal_min, sal_max, name_min, name_max)
        lb_emp_neto_mayor.Text = name_max
        lb_salario_neto_mayor.Text = sal_max

        lb_emp_neto_menor.Text = name_min
        lb_salario_neto_menor.Text = sal_min
    End Sub


    Public Sub AsignarResultados_Men(ByRef sal_min, sal_max, name_min, name_max)
        lb_M_nombre_mayor.Text = name_max
        lb_M_salario_mayor.Text = sal_max

        lb_M_nombre_menor.Text = name_min
        lb_M_salario_menor.Text = sal_min
    End Sub


    Public Sub AsignarResultados_Mujer(ByRef sal_min, sal_max, name_min, name_max)
        lb_F_nombre_mayor.Text = name_max
        lb_F_salario_mayor.Text = sal_max

        lb_F_nombre_menor.Text = name_min
        lb_F_salario_menor.Text = sal_min
    End Sub


    'SE FINALIZA LA EJECUCIÓN DEL PROGRAMA
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        form_pago.Show()
        Me.Close()
    End Sub

End Class