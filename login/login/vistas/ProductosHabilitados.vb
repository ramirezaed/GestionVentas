Public Class ProductosHabilitados


    Dim Prod As New Vproducto()
    Private Sub ProductosHabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prod.MostrarHabilitados(DataProductosHab)
    End Sub
#Region "moer con el mouse"
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

#Region "cerrar minimizar cancelar"
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

#End Region

#Region "agregar PRoducto"
    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If Application.OpenForms().OfType(Of realizarVentas).Any() Then
            Dim Fventas As realizarVentas = Application.OpenForms().OfType(Of realizarVentas).First()

            Dim i As Integer = DataProductosHab.CurrentRow.Index

            Fventas.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            Fventas.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            Fventas.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            Fventas.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            Fventas.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            Me.Close()
        Else
            'si el formulario no esta abierto, lo abro
            Dim realizarVentasForm As New realizarVentas()
            Dim i As Integer = DataProductosHab.CurrentRow.Index

            realizarVentasForm.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            realizarVentasForm.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            realizarVentasForm.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            realizarVentasForm.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            realizarVentasForm.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            realizarVentasForm.Show()

            Me.Close()
        End If
    End Sub
    Private Sub DataProductosHab_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataProductosHab.CellDoubleClick
        If Application.OpenForms().OfType(Of realizarVentas).Any() Then
            Dim Fventas As realizarVentas = Application.OpenForms().OfType(Of realizarVentas).First()

            Dim i As Integer = DataProductosHab.CurrentRow.Index

            Fventas.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            Fventas.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            Fventas.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            Fventas.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            Fventas.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            Me.Close()
        Else
            'si el formulario no esta abierto, lo abro
            Dim realizarVentasForm As New realizarVentas()
            Dim i As Integer = DataProductosHab.CurrentRow.Index

            realizarVentasForm.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            realizarVentasForm.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            realizarVentasForm.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            realizarVentasForm.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            realizarVentasForm.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            realizarVentasForm.Show()

            Me.Close()
        End If
    End Sub

    Private Sub dobleclick()
        If Application.OpenForms().OfType(Of realizarVentas).Any() Then
            Dim Fventas As realizarVentas = Application.OpenForms().OfType(Of realizarVentas).First()

            Dim i As Integer = DataProductosHab.CurrentRow.Index

            Fventas.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            Fventas.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            Fventas.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            Fventas.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            Fventas.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            Me.Close()
        Else
            'si el formulario no esta abierto, lo abro
            Dim realizarVentasForm As New realizarVentas()
            Dim i As Integer = DataProductosHab.CurrentRow.Index

            realizarVentasForm.TxtIdProducto.Text = DataProductosHab(0, i).Value.ToString()
            realizarVentasForm.TxtNombreP.Text = DataProductosHab(3, i).Value.ToString()
            realizarVentasForm.TxtStock.Text = DataProductosHab(5, i).Value.ToString()
            realizarVentasForm.Txtstock_min.Text = DataProductosHab(6, i).Value.ToString()
            realizarVentasForm.TxtPrecioUnitario.Text = DataProductosHab(8, i).Value.ToString()

            realizarVentasForm.Show()

            Me.Close()
        End If
    End Sub

    Private Sub DataProductosHab_KeyDown(sender As Object, e As KeyEventArgs) Handles DataProductosHab.KeyDown
        If e.KeyCode = Keys.Enter Then
            '      TxtStock.ForeColor = Color.Red
            dobleclick()
        End If
    End Sub


#End Region



#Region "BUSCADOR"
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataProductosHab.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos el nombre de la columna en la que queremos buscar (en este caso, "codigo").
            Dim nombreColumnaBusqueda As String = "codigo"

            For Each row As DataGridViewRow In DataProductosHab.Rows
                Dim cell As DataGridViewCell = row.Cells(nombreColumnaBusqueda)

                If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                    row.Selected = True
                    encontradaCoincidencia = True
                    Exit For ' Salimos del bucle de filas si encontramos una coincidencia.
                End If
            Next

            If Not encontradaCoincidencia Then
                MessageBox.Show("No se encontraron productos con ese código.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' MessageBox.Show("No se encontraron productos con ese codigo.", "Error de Búsqueda")
            Else
                MessageBox.Show("El código debe tener al menos 1 carácter.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
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
            MessageBox.Show("ingrese el codigo del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



#End Region

End Class