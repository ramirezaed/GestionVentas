Public Class DiaReporte
    Public fechaInicial As Date
    Private Sub DiaReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New CrystalReport6
        objreporte.SetParameterValue("@fecha", fechaInicial)
        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class