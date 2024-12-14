

'Public Class reportePersonal

'Private Sub reportePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    Dim reporte As New listaPersonal
'   CrystalReportViewer3.ReportSource = reporte
'End Sub
'End Class


'```vbnet
Imports CrystalDecisions.CrystalReports.Engine

Public Class reportePersonal
    Inherits System.Windows.Forms.Form

    Private Sub reportePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Especifica la ruta absoluta del informe
        Dim rutaAbsolutaInforme As String = "C:\reportes\listaPersonal.rpt" ' Reemplaza con la ubicación absoluta de tu informe

        ' Carga el informe desde la ruta absoluta
        Dim informe As New listaPersonal
        informe.Load(rutaAbsolutaInforme)

        ' Asigna el informe al CrystalReportViewer en tu formulario
        CrystalReportViewer1.ReportSource = informe
    End Sub
End Class