Public Class ListaProductos
    Dim Prod As New Vproducto()
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbuscar.Text = "Ingrese el código o nombre del producto."
        Tbuscar.ForeColor = Color.Gray
        Prod.MostrarProductos(DataProductos)
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

    Private Sub Tbuscar_keypress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tbuscar.Text
            If currentText.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
            MessageBox.Show("Ingrese el código o nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscarP()
        End If
    End Sub

    Private Sub Tbuscar_GotFocus(sender As Object, e As EventArgs) Handles Tbuscar.GotFocus
        If Tbuscar.Text = "Ingrese el código o nombre del producto." Then
            Tbuscar.Text = ""
            Tbuscar.ForeColor = Color.Black ' Restaurar el color de texto a negro
        End If
    End Sub

    Private Sub Tbuscar_LostFocus(sender As Object, e As EventArgs) Handles Tbuscar.LostFocus
        If String.IsNullOrWhiteSpace(Tbuscar.Text) Then
            Tbuscar.Text = "Ingrese el código o nombre del producto."
            Tbuscar.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        End If
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataProductos.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos los nombres de las columnas en las que queremos buscar ("codigo" y "nombre").
            Dim columnasBusqueda As String() = {"codigo", "nombre"}

            For Each row As DataGridViewRow In DataProductos.Rows
                For Each nombreColumnaBusqueda As String In columnasBusqueda
                    Dim cell As DataGridViewCell = row.Cells(nombreColumnaBusqueda)

                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(valorBuscado.ToLower()) Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For ' Salimos del bucle de filas si encontramos una coincidencia en alguna columna.
                    End If
                Next
            Next

            If Not encontradaCoincidencia Then
                MessageBox.Show("No se encontró ningún producto con este código o nombre.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El código debe tener al menos 1 carácter.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub buscarP()
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataProductos.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos los nombres de las columnas en las que queremos buscar ("codigo" y "nombre").
            Dim columnasBusqueda As String() = {"codigo", "nombre"}

            For Each row As DataGridViewRow In DataProductos.Rows
                For Each nombreColumnaBusqueda As String In columnasBusqueda
                    Dim cell As DataGridViewCell = row.Cells(nombreColumnaBusqueda)

                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(valorBuscado.ToLower()) Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For ' Salimos del bucle de filas si encontramos una coincidencia en alguna columna.
                    End If
                Next
            Next

            If Not encontradaCoincidencia Then
                MessageBox.Show("No se encontró ningún producto con este código o nombre.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El código debe tener al menos 1 carácter.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If Application.OpenForms().OfType(Of reporteProductoPorCod).Any() Then
            Dim varRepor As reporteProductoPorCod = Application.OpenForms().OfType(Of reporteProductoPorCod).First()
            Dim i As Integer = DataProductos.CurrentRow.Index
            varRepor.TcodigoProducto.Text = DataProductos(1, i).Value.ToString()
            Me.Close()
        Else
            Dim varrepor1 As New reporteProductoPorCod()
            Dim i As Integer = DataProductos.CurrentRow.Index
            varrepor1.TcodigoProducto.Text = DataProductos(1, i).Value.ToString()
            varrepor1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub mostrarP()
        If Application.OpenForms().OfType(Of reporteProductoPorCod).Any() Then
            Dim varRepor As reporteProductoPorCod = Application.OpenForms().OfType(Of reporteProductoPorCod).First()
            Dim i As Integer = DataProductos.CurrentRow.Index
            varRepor.TcodigoProducto.Text = DataProductos(1, i).Value.ToString()
            Me.Close()
        Else
            Dim varrepor1 As New reporteProductoPorCod()
            Dim i As Integer = DataProductos.CurrentRow.Index
            varrepor1.TcodigoProducto.Text = DataProductos(1, i).Value.ToString()
            varrepor1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataProductos_CelldoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataProductos.CellDoubleClick
        mostrarP()
    End Sub

    Private Sub DataListadoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles DataProductos.KeyDown
        If e.KeyCode = Keys.Enter Then
            '      TxtStock.ForeColor = Color.Red
            mostrarP()
        End If
    End Sub



#End Region





End Class