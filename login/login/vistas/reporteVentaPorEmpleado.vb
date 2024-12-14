Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class reporteVentaPorEmpleado
    Dim vendedor As String
    Public Sub New()
        InitializeComponent()
        CrystalReportViewer1.Visible = False
    End Sub
    Private Sub TnombreUsuario_keypress(sender As Object, e As KeyPressEventArgs) Handles TnombreUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then   'valido solo texto y espacio en blanco en nombre de usuario'
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" Solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            mostrarP()
        End If
    End Sub

    Private Sub TnombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TnombreUsuario.TextChanged
        vendedor = TnombreUsuario.Text
    End Sub

    Private Sub reporteVentaPorEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TnombreUsuario.Text = "Ingrese el nombre de usuario."
        TnombreUsuario.ForeColor = Color.Gray
    End Sub

    Private Sub TnombreUsuario_GotFocus(sender As Object, e As EventArgs) Handles TnombreUsuario.GotFocus
        If TnombreUsuario.Text = "Ingrese el nombre de usuario." Then
            TnombreUsuario.Text = ""
            TnombreUsuario.ForeColor = Color.Black ' Restaurar el color de texto a negro
        End If
    End Sub

    Private Sub TnombreUsuario_LostFocus(sender As Object, e As EventArgs) Handles TnombreUsuario.LostFocus
        If String.IsNullOrWhiteSpace(TnombreUsuario.Text) Then
            TnombreUsuario.Text = "Ingrese el nombre de usuario."
            TnombreUsuario.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        End If
    End Sub

    Private Sub Bucar_Click(sender As Object, e As EventArgs) Handles Bucar.Click
        ListaUsuarios.Show()
    End Sub

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        If String.IsNullOrEmpty(TnombreUsuario.Text) OrElse TnombreUsuario.Text = "Ingrese el nombre de usuario." Then
            MessageBox.Show("Ingrese Nombre de Usuario", "Ingrese nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' Salir del método para evitar más ejecución
        End If

        Dim fecha1 = CDate(DateTimePicker1.Text)
        Dim fecha2 = CDate(DateTimePicker2.Text)
        Dim fechahoy As Date = Date.Now

        If fecha1 <= fecha2 AndAlso fecha2 <= fechahoy Then
            Dim usuario = TnombreUsuario.Text ' Obtén el valor del usuario a verificar

            ' Verifica si el usuario existe en la base de datos
            Using db As New FERRETERIAEntities1
                Dim queryUsuario As String = "SELECT COUNT(*) FROM usuario WHERE usuario = @Usuario"
                Dim cmdUsuario As New SqlCommand(queryUsuario, db.Database.Connection)
                cmdUsuario.Parameters.AddWithValue("@Usuario", usuario)
                db.Database.Connection.Open()
                Dim countUsuario As Integer = Convert.ToInt32(cmdUsuario.ExecuteScalar())
                db.Database.Connection.Close()

                If countUsuario > 0 Then
                    ' El usuario existe en la base de datos, ahora puedes continuar con la generación del informe.
                    Try
                        Dim objreporte As New ventasPorUsuarioYFecha1
                        objreporte.SetParameterValue("@usuario", usuario) ' Usar el usuario verificado
                        objreporte.SetParameterValue("@fechaDesde", fecha1)
                        objreporte.SetParameterValue("@fechaHasta", fecha2)
                        CrystalReportViewer1.ReportSource = objreporte
                        CrystalReportViewer1.Visible = True
                    Catch ex As Exception
                        MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Nombre de usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Else
            MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mostrarP()
        If String.IsNullOrEmpty(TnombreUsuario.Text) OrElse TnombreUsuario.Text = "Ingrese el nombre de usuario." Then
            MessageBox.Show("ingrese Nombre de Usuario", "ingrese nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fecha1 = CDate(DateTimePicker1.Text)
        Dim fecha2 = CDate(DateTimePicker2.Text)
        Dim fechahoy As Date = Date.Now
        If fecha1 <= fecha2 AndAlso fecha2 <= fechahoy Then
            Try
                Dim objreporte As New ventasPorUsuarioYFecha1
                objreporte.SetParameterValue("@usuario", vendedor)
                objreporte.SetParameterValue("@fechaDesde", fecha1)
                objreporte.SetParameterValue("@fechaHasta", fecha2)
                CrystalReportViewer1.ReportSource = objreporte
                CrystalReportViewer1.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class