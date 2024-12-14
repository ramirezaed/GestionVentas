Public Class reporteProductoPorCod

    Dim cod As Integer
    Public Sub New()
        InitializeComponent()
        CrystalReportViewer1.Visible = False
    End Sub

    Private Sub reporteProductoPorCod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TcodigoProducto.Text = "Ingrese el codigo del producto."
        TcodigoProducto.ForeColor = Color.Gray
    End Sub

    Private Sub TcodigoProducto_keypress(sender As Object, e As KeyPressEventArgs) Handles TcodigoProducto.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("El código debe ser un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ValidarCodigo() As Boolean
        If Integer.TryParse(TcodigoProducto.Text, cod) Then
            Return True
        Else
            MessageBox.Show("El código debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TcodigoProducto.Clear()
            Return False
        End If
    End Function

    Private Sub TcodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles TcodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If ValidarCodigo() Then
                mostrarP()
            End If
        End If
    End Sub

    Private Sub TcodigoProducto_GotFocus(sender As Object, e As EventArgs) Handles TcodigoProducto.GotFocus
        If TcodigoProducto.Text = "Ingrese el codigo del producto." Then
            TcodigoProducto.Text = ""
            TcodigoProducto.ForeColor = Color.Black ' Restaurar el color de texto a negro
        End If
    End Sub

    Private Sub TcodigoProducto_LostFocus(sender As Object, e As EventArgs) Handles TcodigoProducto.LostFocus
        If String.IsNullOrWhiteSpace(TcodigoProducto.Text) Then
            TcodigoProducto.Text = "Ingrese el codigo del producto."
            TcodigoProducto.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        End If
    End Sub

    Private Sub Bucar_Click(sender As Object, e As EventArgs) Handles Bucar.Click
        ListaProductos.Show()
    End Sub

    Private Sub mostrarP()
        If String.IsNullOrEmpty(TcodigoProducto.Text) OrElse TcodigoProducto.Text = "Ingrese el codigo del producto." Then
            MessageBox.Show("Ingrese un código de producto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TcodigoProducto.Text = ""
            Return
        End If

        Dim cod As String = TcodigoProducto.Text

        Using db As New FERRETERIAEntities1
            Dim codigoProducto As String = TcodigoProducto.Text
            Dim countCodigo As Integer = db.producto.Where(Function(p) p.codigo_pro = codigoProducto).Count()

            If countCodigo > 0 Then
                Try
                    Dim objreporte As New productoPorCodigo
                    objreporte.SetParameterValue("@cod_producto", cod)
                    CrystalReportViewer1.ReportSource = objreporte
                    CrystalReportViewer1.Visible = True
                Catch ex As Exception
                    MessageBox.Show("Error al cargar el informe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Codigo de producto incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' TcodigoProducto.Clear()
            End If
        End Using

    End Sub

    Private Sub Bmostrar_Click(sender As Object, e As EventArgs) Handles Bmostrar.Click
        If ValidarCodigo() Then
            mostrarP()
        End If
    End Sub
End Class