

Imports CrystalDecisions.CrystalReports.Engine



Public Class ReportePordMas
    Inherits System.Windows.Forms.Form

    '  Private Sub ReportePordMas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '     Dim reporte As New reporteProdMasVendido
    '    CrystalReportViewer1.ReportSource = reporte
    'Dim rutaAbsolutaInforme As String = "C:\reportes\listaPersonal.rpt" ' Reemplaza con la ubicación absoluta de tu informe
    ' Dim rutaAbsolutaInforme As String = "C:\reportes\reporteProdMasVendido.rpt"
    ' Carga el informe desde la ruta absoluta
    'Dim informe As New reporteProdMasVendido 'llma al crystalreport 
    '   informe.Load(rutaAbsolutaInforme)

    ' Asigna el informe al CrystalReportViewer en tu formulario
    '  CrystalReportViewer1.ReportSource = informe

    'End Sub
    Public Sub New()
        InitializeComponent()
        CrystalReportViewer1.Visible = False
    End Sub
    Private Sub ReportePordMas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bucar_Click(sender As Object, e As EventArgs)
        ListaProductos.Show()
    End Sub

    Private Sub mostrarP()

        Dim fecha1 = CDate(DateTimePicker1.Text)
        Dim fecha2 = CDate(DateTimePicker2.Text)
        Dim fechahoy As Date = Date.Now
        If fecha1 <= fecha2 AndAlso fecha2 <= fechahoy Then
            ' Dim cod As String = TcodigoProducto.Text
            Try
                Dim objreporte As New top10masVendidos
                objreporte.SetParameterValue("@fecha_inicio", fecha1)
                objreporte.SetParameterValue("@fecha_final", fecha2)

                CrystalReportViewer1.ReportSource = objreporte
                CrystalReportViewer1.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        mostrarP()
    End Sub

End Class
