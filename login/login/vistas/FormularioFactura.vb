Public Class FormularioFactura
    Public vNro As Integer
    Private Sub FormularioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New reciboVenta 'CrystalReport1
        objreporte.SetParameterValue("@idVenta", vNro)
        CrystalReportViewer1.ReportSource = objreporte

    End Sub

    ' public nfac as int
    'Dim objreporte As New CrystalReport6

    '        objreporte.SetParameterValue("@fecha", id_venta)
    '       CrystalReportViewer1.ReportSource = objreporte

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        realizarVentas.Show()
        Me.Close()
    End Sub
End Class