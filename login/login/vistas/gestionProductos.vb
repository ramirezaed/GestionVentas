Imports System.ComponentModel

Public Class gestionProductos

    Dim user1 As New Vproducto()

    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user1.MostrarProductos(DataListadoProducto)
        DataListadoProducto.ClearSelection()
        Tbuscar.Text = "Ingrese el código o nombre del producto."
        Tbuscar.ForeColor = Color.Gray

    End Sub


    Public Sub ActualizarListaProductos() 'utilizo para mostrar los productos despues de agregar  o editar
        Using db As New FERRETERIAEntities1
            ' Obtener la lista de usuarios desde la base de datos
            Dim ListadoProducto = From q In db.producto
                                  Join c In db.categoria On q.id_categoria Equals c.id_categoria
                                  Select
                                      IdProducto = q.id_producto, Codigo = q.codigo_pro, Categoria = c.descripcion, Nombre = q.nombre, Descripcion = q.descripcion,
                                      Stock = q.stock, stock_minimo = q.stock_minimo, PrecioCompra = q.precio_compra, PrecioVenta = q.precio_venta, Estado = q.estado

            DataListadoProducto.DataSource = ListadoProducto.ToList()
        End Using
    End Sub


    Private Sub BhabilitarProd_Click(sender As Object, e As EventArgs) Handles BhabilitarProd.Click
        If DataListadoProducto.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoProducto.SelectedRows(0).Cells(0).Value)
            user1.AltaProductos(id)
            user1.MostrarProductos(DataListadoProducto)
            DataListadoProducto.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un producto para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BeliminarProducto_Click(sender As Object, e As EventArgs) Handles BeliminarProducto.Click
        If DataListadoProducto.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(DataListadoProducto.SelectedRows(0).Cells(0).Value)
            user1.BajaProductos(id)
            user1.MostrarProductos(DataListadoProducto)
            DataListadoProducto.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub BagregarProducto_Click(sender As Object, e As EventArgs) Handles BagregarProducto.Click
        agregarProducto.Show()
    End Sub

    Private Sub BEditarProducto_Click(sender As Object, e As EventArgs) Handles BEditarProducto.Click
        EditarProducto.Show()
    End Sub


#Region "BUSCADOR en la COLUMNA CODIGO"
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

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataListadoProducto.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos los nombres de las columnas en las que queremos buscar ("codigo" y "nombre").
            Dim columnasBusqueda As String() = {"codigo", "nombre"}

            For Each row As DataGridViewRow In DataListadoProducto.Rows
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
            DataListadoProducto.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            ' Especificamos los nombres de las columnas en las que queremos buscar ("codigo" y "nombre").
            Dim columnasBusqueda As String() = {"codigo", "nombre"}

            For Each row As DataGridViewRow In DataListadoProducto.Rows
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
#End Region
End Class



