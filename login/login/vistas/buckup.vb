
Imports System.Data.SqlClient


Public Class buckup
    Dim conex As New SqlConnection("data source=.\SQLEXPRESS;initial catalog=FERRETERIA;integrated security=True ")

    Private Sub buckup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Archivos de copia de seguridad (*.bak)|*.bak"
        saveFileDialog1.Title = "Guardar copia de seguridad"
        saveFileDialog1.FileName = "MiCopiaDeSeguridad.bak"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim nombreArchivo As String = saveFileDialog1.FileName

            Dim consulta As String = $"BACKUP DATABASE [FERRETERIA] TO DISK = N'{nombreArchivo}' WITH NOFORMAT, NOINIT, NAME = N'FERRETERIA-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD, STATS = 10"

            Dim cmd As SqlCommand = New SqlCommand(consulta, conex)

            Try
                conex.Open()
                cmd.ExecuteNonQuery()
                MsgBox("La copia de seguridad se ha realizado correctamente")
            Catch ex As Exception
                MsgBox("Ocurrió un error al realizar la copia de seguridad: " & ex.Message)
            Finally
                conex.Close()
                conex.Dispose()
            End Try
        End If
    End Sub
End Class




