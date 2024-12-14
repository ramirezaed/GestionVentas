Public Class clientesHabilitados

    Dim cliHA As New Vcliente()

    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliHA.MostrarHabilitados(DataclienteHab)

    End Sub

#Region "mover con el mouse"
    Private startPoint As New Point(0, 0)
    Private IsDragging As Boolean
    Private MouseOffset As Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsDragging Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub
    Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        IsDragging = False
    End Sub

#End Region

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If Application.OpenForms().OfType(Of realizarVentas).Any() Then
            Dim Fventas As realizarVentas = Application.OpenForms().OfType(Of realizarVentas).First()

            Dim i As Integer = DataclienteHab.CurrentRow.Index

            Fventas.Textidcliente.Text = DataclienteHab(0, i).Value.ToString()
            Fventas.Textnombre.Text = DataclienteHab(2, i).Value.ToString()
            Fventas.txtApellidos.Text = DataclienteHab(3, i).Value.ToString()

            Me.Close()
        Else
            'si el formulario no esta abierto, lo abro
            Dim realizarVentasForm As New realizarVentas()
            Dim i As Integer = DataclienteHab.CurrentRow.Index
            realizarVentasForm.Textidcliente.Text = DataclienteHab(0, i).Value.ToString()
            realizarVentasForm.Textnombre.Text = DataclienteHab(2, i).Value.ToString()
            realizarVentasForm.txtApellidos.Text = DataclienteHab(3, i).Value.ToString()

            realizarVentasForm.Show()

            Me.Close()
        End If
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub


#Region "buscador"

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 7 Then
            DataclienteHab.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In DataclienteHab.Rows
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
                    Me.Close()
                    agregarCliente.Show()
                End If
            End If
        Else
            MessageBox.Show("El Dni debe tener al menos 7 digitos.", "Error de Búsqueda")
        End If
    End Sub

    Private Sub Tbuscar_keypress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
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
    End Sub

    Private Sub DataclienteHab_CelldoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataclienteHab.CellDoubleClick
        mostrarP()
    End Sub

    Public Sub mostrarP()
        If Application.OpenForms().OfType(Of realizarVentas).Any() Then
            Dim Fventas As realizarVentas = Application.OpenForms().OfType(Of realizarVentas).First()

            Dim i As Integer = DataclienteHab.CurrentRow.Index

            Fventas.Textidcliente.Text = DataclienteHab(0, i).Value.ToString()
            Fventas.Textnombre.Text = DataclienteHab(2, i).Value.ToString()
            Fventas.txtApellidos.Text = DataclienteHab(3, i).Value.ToString()

            Me.Close()
        Else
            'si el formulario no esta abierto, lo abro
            Dim realizarVentasForm As New realizarVentas()
            Dim i As Integer = DataclienteHab.CurrentRow.Index
            realizarVentasForm.Textidcliente.Text = DataclienteHab(0, i).Value.ToString()
            realizarVentasForm.Textnombre.Text = DataclienteHab(2, i).Value.ToString()
            realizarVentasForm.txtApellidos.Text = DataclienteHab(3, i).Value.ToString()

            realizarVentasForm.Show()

            Me.Close()
        End If
    End Sub


    Private Sub DataclienteHab_KeyDown(sender As Object, e As KeyEventArgs) Handles DataclienteHab.KeyDown
        If e.KeyCode = Keys.Enter Then
            mostrarP()
        End If
    End Sub

#End Region



End Class