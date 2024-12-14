Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class formulariofechaVentaEmpleado
    ' Public nombreUser As String
    'Public fechainicial As Date
    'Public fechafinal As Date
    'Public empleado As New Vusuario
    'Public vendedor As String
    'Public ven1 As String

    'Private Sub formulariofechaVentaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   empleado.EnlaceDatos(inicioSesion.N_Usuario)
    '  vendedor = empleado.getUsuario
    'If fechainicial <= fechafinal Then
    'Try
    'Dim objreporte As New ventasPorUsuarioYFecha1
    '           objreporte.SetParameterValue("@usuario", vendedor)
    '          objreporte.SetParameterValue("@fechaDesde", fechainicial)
    '         objreporte.SetParameterValue("@fechaHasta", fechafinal)
    '        CrystalReportViewer4.ReportSource = objreporte
    'Catch ex As Exception
    '           MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'Else
    '        MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'Me.Close()
    ' End If
    'End Sub

    'Private Sub formulariofechaVentaEmpleado_FormClosed(sender As Object, e As FormClosedEventArgs)
    '   CrystalReportViewer4.ReportSource = Nothing ' Liberar recursos
    '  CrystalReportViewer4.Dispose()
    'End Sub

End Class