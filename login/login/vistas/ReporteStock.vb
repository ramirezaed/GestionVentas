Public Class ReporteStock

    Dim cod As Integer
    Private Sub ReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaAbsolutaInforme As String = "C:\reportes\CrystalReport2.rpt"
        Dim informe As New CrystalReport2 'llma al crystalreport 
        informe.Load(rutaAbsolutaInforme)
        CrystalReportViewer1.ReportSource = informe
        'Dim objreport As New CrystalReport2
        'CrystalReportViewer1.ReportSource = objreport
    End Sub

End Class