Public Class Reporte_fecha_venta
    Dim ReporteDeVenta As New formulariofechaVenta()

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        PanelReporte.Controls.Clear() 'limpia el panel para cuando vuelva a solicitar otro reporte
        Dim ReporteDeVenta As New formulariofechaVenta
        Dim fechain As Date = CDate(DateTimePicker1.Text)
        Dim fechafin As Date = CDate(DateTimePicker2.Text)
        Dim fechaHoy As Date = Date.Now

        If fechain <= fechafin AndAlso fechafin <= fechaHoy Then
            ' Configurar el nuevo formulario de informe
            ReporteDeVenta.TopLevel = False
            ReporteDeVenta.FormBorderStyle = FormBorderStyle.None
            ReporteDeVenta.Dock = DockStyle.Fill

            ' Asignar las fechas al nuevo formulario de informe
            ReporteDeVenta.fechainicial = fechain
            ReporteDeVenta.fechafinal = fechafin

            PanelReporte.Controls.Add(ReporteDeVenta)
            ReporteDeVenta.Show()
        ElseIf fechafin > fechaHoy Then
            MessageBox.Show("La fecha final no puede ser mayor que (" & fechaHoy & ").", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Reporte_fecha_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

End Class