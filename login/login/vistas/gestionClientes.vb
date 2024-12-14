Public Class gestionClientes

    Dim cli As New Vcliente()

    Private Sub gestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cli.MostrarClientes(DataListadoCliente)
        DataListadoCliente.ClearSelection()
        Tbuscar.Text = "Ingrese DNI del cliente."
        Tbuscar.ForeColor = Color.Gray
    End Sub

    Public Sub ActualizarListaClientes1()
        Using db As New FERRETERIAEntities1
            ' Obtener la lista de usuarios desde la base de datos
            Dim ListadoCliente = From q In db.cliente
                                 Select nombre = q.nombre, apellido = q.apellido,
                                     dni = q.dni_cliente, fechaNacimiento = q.fecha_nac,
                                     email = q.email, direccion = q.domicilio,
                                     telefono = q.telefono, estado = q.estado

            DataListadoCliente.DataSource = ListadoCliente.ToList()
        End Using
    End Sub

    Private Sub BagreCliente_Click(sender As Object, e As EventArgs) Handles BagreCliente.Click
        agregarCliente.Show()
    End Sub

#Region "HABILITAR Y DESAHBILITAR CLIENTES"
    Private Sub Bhabilitar_Click(sender As Object, e As EventArgs) Handles Bhabilitar.Click


        If DataListadoCliente.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoCliente.SelectedRows(0).Cells(0).Value)
            cli.ActivarCliente(id)
            cli.MostrarClientes(DataListadoCliente)
            cli.MostrarClientes(DataListadoCliente)
            DataListadoCliente.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un usuario para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub BeliminarCliente_Click(sender As Object, e As EventArgs) Handles BeliminarCliente.Click
        If DataListadoCliente.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoCliente.SelectedRows(0).Cells(0).Value)
            cli.desactivarCliente(id)
            cli.MostrarClientes(DataListadoCliente)
            DataListadoCliente.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un usuario para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "BUSCAR"

    Private Sub Tbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tbuscar.Text

            If Char.IsDigit(e.KeyChar) Then

                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("ingrese el DNI del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscarP()
        End If
    End Sub

    Private Sub Tbuscar_GotFocus(sender As Object, e As EventArgs) Handles Tbuscar.GotFocus
        If Tbuscar.Text = "Ingrese DNI del cliente." Then
            Tbuscar.Text = ""
            Tbuscar.ForeColor = Color.Black ' Restaurar el color de texto a negro
        End If
    End Sub

    Private Sub Tbuscar_LostFocus(sender As Object, e As EventArgs) Handles Tbuscar.LostFocus
        If String.IsNullOrWhiteSpace(Tbuscar.Text) Then
            Tbuscar.Text = "Ingrese DNI del cliente."
            Tbuscar.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        End If
    End Sub

    'metodo buscar al presionar enter
    Private Sub buscarP()
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 7 Then
            DataListadoCliente.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In DataListadoCliente.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For 'saledel  bucle de celdas si encontro una coincidencia en la fila actual.
                    End If
                Next

                If encontradaCoincidencia Then
                    Exit For ' Sale del bucle
                End If
            Next

            If Not encontradaCoincidencia Then
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro ningun cliente con ese DNI ¿Desea agregar un nuevo cliente?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    ' Abre el formulario para agregar un cliente.
                    agregarCliente.Show()
                Else
                    Tbuscar.Clear()
                End If
            End If
        Else
            MessageBox.Show("El Dni debe tener al menos 7 digitos.", "Error de Búsqueda")
        End If
    End Sub
    'boton buscador
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 7 Then
            DataListadoCliente.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In DataListadoCliente.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For ' Salimos del bucle de celdas si encontramos una coincidencia en la fila actual.
                    End If
                Next

                If encontradaCoincidencia Then
                    Exit For ' Salimos del bucle de filas si encontramos una coincidencia.
                End If
            Next

            If Not encontradaCoincidencia Then
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro ningun cliente con ese DNI ¿Desea agregar un nuevo cliente?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    ' Abre el formulario para agregar un cliente.
                    agregarCliente.Show()
                End If
            End If
        Else
            MessageBox.Show("El Dni debe tener al menos 7 digitos.", "Error de Búsqueda")
        End If
    End Sub

#End Region
    Private Sub BeditarCliente_Click(sender As Object, e As EventArgs) Handles BeditarCliente.Click
        EditarCliente.Show()
    End Sub




End Class


