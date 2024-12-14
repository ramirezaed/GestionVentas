Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class EditarProducto

    Dim prod As New Vproducto()
    Dim tipo_categoria As Integer
    Dim desc_cat As String

    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbuscar.Text = "Ingrese el código o nombre del producto."
        Tbuscar.ForeColor = Color.Gray

        prod.MostrarProductos(DataListadoProducto)
        ComboBoxCategorias.Items.Add("inalambrica")
        ComboBoxCategorias.Items.Add("manual")
        ComboBoxCategorias.Items.Add("electricas")

    End Sub

    Private Sub limpiar()
        TcodigoProducto.Text = ""
        Tnombre.Text = ""
        Tdescripcion.Text = ""
        Tstock.Text = ""
        Tstock_minimo.Text = ""
        TprecioCompra.Text = ""
        TprecioVenta.Text = ""
        ComboBoxCategorias.SelectedItem = ""

    End Sub

#Region "MOVER CON EL MOUSE"
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


#Region "VALIDAR TEXTTBOX"




    Private Sub ComboBoxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) 'Handles ComboBoxCategorias.SelectedIndexChanged
        Dim selectedCategory As String = ComboBoxCategorias.SelectedItem.ToString()
        ' Realiza acciones basadas en la opción seleccionada
        Select Case selectedCategory
            Case "inalambrica"
                tipo_categoria = 1
                desc_cat = "inalambrica"
            Case "manual"
                tipo_categoria = 2
                desc_cat = "manual"
            Case "electricas"
                tipo_categoria = 3
                desc_cat = "electricas"
        End Select
    End Sub

    Private Sub TcodigoProducto_keypress(sender As Object, e As KeyPressEventArgs) Handles TcodigoProducto.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = TcodigoProducto.Text

            If Char.IsDigit(e.KeyChar) Then
                ' Si ya hay 8 dígitos, bloquear el ingreso.
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("El codigo del producto debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tstock_keypress(sender As Object, e As KeyPressEventArgs) Handles Tstock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo se permiten numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tstock_minimo_keypress(sender As Object, e As KeyPressEventArgs) Handles Tstock_minimo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo se permiten numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TprecioCompra_keypress(sender As Object, e As KeyPressEventArgs) Handles TprecioCompra.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo se permiten numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then   'valido solo texto y espacio en blanco en nombre de usuario'
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" Solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TprecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TprecioVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo se permiten numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region

#Region "CERRAR CANCELAR MINIMIZAR"

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


#Region "GUARDAR"
    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        If String.IsNullOrWhiteSpace(Tnombre.Text) OrElse
       String.IsNullOrWhiteSpace(TcodigoProducto.Text) OrElse
       String.IsNullOrWhiteSpace(Tdescripcion.Text) OrElse
       String.IsNullOrWhiteSpace(TprecioCompra.Text) OrElse
       String.IsNullOrWhiteSpace(TprecioVenta.Text) OrElse
       String.IsNullOrWhiteSpace(Tstock.Text) OrElse
       String.IsNullOrWhiteSpace(Tstock_minimo.Text) OrElse
       ComboBoxCategorias.SelectedItem Is Nothing Then

            MessageBox.Show("Por favor, complete todos los campos y seleccione una categoría antes de modificar el producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim tipo_categoria As Integer
            Dim selectedCategory As String = ComboBoxCategorias.SelectedItem.ToString()
            Select Case selectedCategory
                Case "inalambrica"
                    tipo_categoria = 1
                Case "manual"
                    tipo_categoria = 2
                Case "electricas"
                    tipo_categoria = 3
            End Select

            Dim nombre As String = Tnombre.Text
            Dim codigo As Integer = TcodigoProducto.Text
            Dim descripcion As String = Tdescripcion.Text
            Dim stock As Integer = Integer.Parse(Tstock.Text)
            Dim stock_minimo As Integer = Integer.Parse(Tstock_minimo.Text)
            Dim precio_compra As Double = Double.Parse(TprecioCompra.Text)
            Dim precio_venta As Double = Double.Parse(TprecioVenta.Text)

            If MsgBox("Confirmar modificación", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar producto") = MsgBoxResult.Yes Then
                ' Llama a la función de modificación de producto con los datos actualizados.
                prod.ModificarProductos(tipo_categoria, codigo, nombre, descripcion, stock, stock_minimo, precio_compra, precio_venta)
                prod.MostrarProductos(DataListadoProducto)
                Dim listapro As gestionProductos = DirectCast(Application.OpenForms("gestionProductos"), gestionProductos)
                If listapro IsNot Nothing Then
                    listapro.ActualizarListaProductos()
                End If

                MessageBox.Show("El producto ha sido modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarP()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el producto. Verifica los valores ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub limpiarP()
        Tnombre.Clear()
        TprecioCompra.Clear()
        Tstock.Clear()
        Tstock_minimo.Clear()
        TcodigoProducto.Clear()
        TprecioVenta.Clear()
        Tdescripcion.Clear()

    End Sub


#Region "BUSCADOR POR CODIGO"
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


    Private Sub DataListadoProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoProducto.CellClick
        Dim i As Integer = DataListadoProducto.CurrentRow.Index

        TcodigoProducto.Text = DataListadoProducto(1, i).Value.ToString()
        desc_cat = DataListadoProducto(2, i).Value.ToString()
        Tnombre.Text = DataListadoProducto(3, i).Value.ToString()
        Tdescripcion.Text = DataListadoProducto(4, i).Value.ToString()
        Tstock.Text = DataListadoProducto(5, i).Value.ToString()
        Tstock_minimo.Text = DataListadoProducto(6, i).Value.ToString()
        TprecioVenta.Text = DataListadoProducto(7, i).Value.ToString()
        TprecioCompra.Text = DataListadoProducto(8, i).Value.ToString()

        ComboBoxCategorias.SelectedItem = Nothing

        Select Case desc_cat
            Case "inalambrica"
                ComboBoxCategorias.SelectedItem = "inalambrica"
            Case "manual"
                ComboBoxCategorias.SelectedItem = "manual"
            Case "electricas"
                ComboBoxCategorias.SelectedItem = "electricas"
        End Select


    End Sub

    Private Sub seleccionarProducto()
        Dim i As Integer = DataListadoProducto.CurrentRow.Index

        TcodigoProducto.Text = DataListadoProducto(1, i).Value.ToString()
        desc_cat = DataListadoProducto(2, i).Value.ToString()
        Tnombre.Text = DataListadoProducto(3, i).Value.ToString()
        Tdescripcion.Text = DataListadoProducto(4, i).Value.ToString()
        Tstock.Text = DataListadoProducto(5, i).Value.ToString()
        Tstock_minimo.Text = DataListadoProducto(6, i).Value.ToString()
        TprecioVenta.Text = DataListadoProducto(8, i).Value.ToString()
        TprecioCompra.Text = DataListadoProducto(7, i).Value.ToString()

        ComboBoxCategorias.SelectedItem = Nothing

        Select Case desc_cat
            Case "inalambrica"
                ComboBoxCategorias.SelectedItem = "inalambrica"
            Case "manual"
                ComboBoxCategorias.SelectedItem = "manual"
            Case "electricas"
                ComboBoxCategorias.SelectedItem = "electricas"
        End Select
    End Sub



    Private Sub DataListadoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles DataListadoProducto.KeyDown

        If e.KeyCode = Keys.Enter Then
            seleccionarProducto()
            e.Handled = True
        End If
    End Sub




End Class