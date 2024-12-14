
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class reporteVentaEmpleado
    Public empleado As New Vusuario
    Dim vendedor As String

    Public Sub New()
        InitializeComponent()
        CrystalReportViewer4.Visible = False
    End Sub

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        '    PanelReporte.Controls.Clear()
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        vendedor = empleado.getUsuario
        Dim fecha1 = CDate(DateTimedesde.Text)
        Dim fecha2 = CDate(DateTimehasta.Text)
        Dim fechahoy As Date = Date.Now
        '  Dim fechahoy As Date = Date.Now
        If fecha1 <= fecha2 AndAlso fecha2 <= fechahoy Then
            Try
                Dim objreporte As New ventasPorUsuarioYFecha1
                objreporte.SetParameterValue("@usuario", vendedor)
                objreporte.SetParameterValue("@fechaDesde", fecha1)
                objreporte.SetParameterValue("@fechaHasta", fecha2)
                CrystalReportViewer4.ReportSource = objreporte
                CrystalReportViewer4.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class