Public Class formulariofechaVenta
    Public fechainicial As Date
    Public fechafinal As Date


    Private Sub formulariofechaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fechainicial <= fechafinal Then
            Try
                Dim objreporte As New CrystalReport5
                objreporte.SetParameterValue("@fecha", fechainicial)
                objreporte.SetParameterValue("@fecha2", fechafinal)
                CrystalReportViewer1.ReportSource = objreporte
            Catch ex As Exception
                MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Private Sub formulariofechaVenta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CrystalReportViewer1.ReportSource = Nothing ' Liberar recursos
        CrystalReportViewer1.Dispose()
    End Sub







End Class