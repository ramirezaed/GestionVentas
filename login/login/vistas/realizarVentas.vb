Public Class realizarVentas

#Region "defino variables que voy a utiizar"
    Public tabla As New DataTable
    Public id_cliente As Integer
    Public nombre1, apellido1 As String
    Public dni As Int64

    Dim total As Double = 0
    Dim vendedor As Integer
    Public vpT As Decimal 'variable para quitar productos del detalle

#End Region

    Structure Producto
        Dim codProducto As String
        Dim nombre1 As String
        Dim cantidad1 As String
        Dim precio1 As String
        Dim Subtotal1 As String
    End Structure


    Private Sub realizarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tbuscar.Text = "Ingrese el código o nombre del producto."
        Tbuscar.ForeColor = Color.Gray

        Textidcliente.Text = "23"
        Textnombre.Text = "Final"
        txtApellidos.Text = "Consumidor"
        Tmontoingresado.Text = ""

        DateTimePicker1.Value = DateTime.Now
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        TextUsuario.Text = inicioSesion.N_Usuario
        vendedor = empleado.getIdUsuario
        textFecha.Text = DateTimePicker1.Value.ToShortDateString
        Dim ver As New Vventa
        txtNumFac.Text = ver.MostrarUltimaFactura() + 1
        tabla.Columns.Add("CODIGO", System.Type.GetType("System.String")) '0
        tabla.Columns.Add("NOMBRE", System.Type.GetType("System.String")) '1
        tabla.Columns.Add("PRECIO UNITARIO", System.Type.GetType("System.String"))  '3
        tabla.Columns.Add("CANTIDAD", System.Type.GetType("System.String")) '4
        tabla.Columns.Add("SUBTOTAL", System.Type.GetType("System.String")) '5
    End Sub

#Region "Cabecera datos cliente"
    'buscar un cliente que ya se encuentra registrado
    Private Sub BbuscarCienteExistente_Click(sender As Object, e As EventArgs) Handles BbuscarCienteExistente.Click
        clientesHabilitados.Show()
    End Sub

    'registrar un nuevo cliente
    Private Sub BRegistrarNuevoCliente_Click(sender As Object, e As EventArgs) Handles BRegistrarNuevoCliente.Click
        agregarCliente.Show()
    End Sub

    'metodo para cargar los datos del cliente, para realizar la factura
    Public Sub cargarcliente(ByVal id_cliente As Integer, ByVal nombre1 As String, ByVal apellido1 As String)
        Textidcliente.Text = id_cliente
        Textnombre.Text = nombre1
        txtApellidos.Text = apellido1
    End Sub

#End Region

#Region "insertar PRODUCTOS al detalle de venta"

    'Carga el datagrid con los productos HABILITADOS
    Dim prod As New Vproducto()
    Private Sub gestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod.MostrarHabilitados(DataListadoProducto)
    End Sub
    Dim controlar As Double
    'selecciono un producto de la lista, y verifica el stock
    Private Sub DataListadoProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListadoProducto.CellDoubleClick

        TxtCantidad.Clear()
        TxtSubtotal.Clear()
        Dim i As Integer = DataListadoProducto.CurrentRow.Index
        TxtIdProducto.Text = DataListadoProducto(0, i).Value
        TxtNombreP.Text = DataListadoProducto(3, i).Value
        TxtStock.Text = DataListadoProducto(5, i).Value
        Txtstock_min.Text = DataListadoProducto(6, i).Value
        TxtPrecioUnitario.Text = DataListadoProducto(8, i).Value
        TextControlar.Text = DataListadoProducto(5, i).Value
        DataListadoProducto.Rows(i).Selected = True
        Dim stock As Double
        Dim stockMin As Double
        '   Dim controlar As Double
        Double.TryParse(TextControlar.Text, controlar)
        If Double.TryParse(TxtStock.Text, stock) AndAlso Double.TryParse(Txtstock_min.Text, stockMin) Then
            If stock <= stockMin Then
                MessageBox.Show("controlar stock", "Control stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        bSUMAR.Enabled = True
        bRESTAR.Enabled = True
        bAGREGAR.Enabled = True

    End Sub

    Private Sub ListaProductoDobleClick()
        TxtCantidad.Clear()
        TxtSubtotal.Clear()
        Dim i As Integer = DataListadoProducto.CurrentRow.Index
        TxtIdProducto.Text = DataListadoProducto(0, i).Value
        TxtNombreP.Text = DataListadoProducto(3, i).Value
        TxtStock.Text = DataListadoProducto(5, i).Value
        Txtstock_min.Text = DataListadoProducto(6, i).Value
        TxtPrecioUnitario.Text = DataListadoProducto(8, i).Value
        TextControlar.Text = DataListadoProducto(5, i).Value
        DataListadoProducto.Rows(i).Selected = True
        Dim stock As Double
        Dim stockMin As Double
        '   Dim controlar As Double
        Double.TryParse(TextControlar.Text, controlar)
        If Double.TryParse(TxtStock.Text, stock) AndAlso Double.TryParse(Txtstock_min.Text, stockMin) Then
            If stock <= stockMin Then
                MessageBox.Show("controlar stock", "Control stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        bSUMAR.Enabled = True
        bRESTAR.Enabled = True
        bAGREGAR.Enabled = True
    End Sub


    Private Sub DataListadoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles DataListadoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListaProductoDobleClick()
            e.Handled = True
        End If
    End Sub

    'agrego el producto al detalle de la factura

    Private Sub bAGREGAR_Click(sender As Object, e As EventArgs) Handles bAGREGAR.Click
        If Not String.IsNullOrEmpty(TxtCantidad.Text) Then
            funcionSumar()
        End If

        If Not String.IsNullOrWhiteSpace(TxtIdProducto.Text) AndAlso
                         Not String.IsNullOrWhiteSpace(TxtNombreP.Text) AndAlso
                             Not String.IsNullOrWhiteSpace(TxtCantidad.Text) AndAlso
                         Not String.IsNullOrWhiteSpace(TxtPrecioUnitario.Text) AndAlso
               Not String.IsNullOrWhiteSpace(TxtSubtotal.Text) Then

            Dim cantidad As Long = Convert.ToInt64(TxtCantidad.Text)
            If cantDevolver > 0 Then
                Datadetalleventa.Rows.Add(txtNumFac.Text, TxtIdProducto.Text, TxtNombreP.Text, cantDevolver, TxtPrecioUnitario.Text, TxtSubtotal.Text)
                'Calcular el subtotal del elemento agregado y sumarlo al total
                Dim subtotal As Decimal = Convert.ToDecimal(TxtSubtotal.Text)
                total += subtotal
                txtTotal.Text = total.ToString()
                Dim descuenta1 As New Vproducto
                descuenta1.descontarStock(iddescontar, cantDevolver)
                limpiar()

            Else
                MessageBox.Show("La cantidad debe ser mayor que cero.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        prod.MostrarHabilitados(DataListadoProducto)
        DataListadoProducto.Refresh()

    End Sub

    'QUITO PRODUCTOS DEL DETALLE
    Private Sub bQUITAR_Click(sender As Object, e As EventArgs) Handles bQUITAR.Click
        If Datadetalleventa.SelectedRows.Count = 1 Then
            Dim rowIndex As Integer = Datadetalleventa.SelectedRows(0).Index

            ' Verificar si la fila no está vacía antes de permitir la eliminación
            If Not verificarFlaVacia(Datadetalleventa.Rows(rowIndex)) Then
                Dim cantidadActual As Integer = CInt(Datadetalleventa.Rows(rowIndex).Cells("cantidad").Value)

                If cantidadActual > 1 Then
                    cantidadActual -= 1
                    Datadetalleventa.Rows(rowIndex).Cells("cantidad").Value = cantidadActual
                    Dim precioPorUnidad As Decimal = CDec(Datadetalleventa.Item(4, rowIndex).Value)
                    Dim subtotal As Decimal = CDec(Datadetalleventa.Item(5, rowIndex).Value)
                    subtotal -= precioPorUnidad
                    total -= precioPorUnidad
                    Datadetalleventa.Rows(rowIndex).Cells("subtotal").Value = subtotal
                    txtTotal.Text = total.ToString()
                    Datadetalleventa.Item(5, rowIndex).Value = subtotal
                    Datadetalleventa.Refresh()
                Else
                    cantidadActual -= 1
                    Datadetalleventa.Rows(rowIndex).Cells("cantidad").Value = cantidadActual
                    Dim precioPorUnidad As Decimal = CDec(Datadetalleventa.Item(4, rowIndex).Value)
                    Dim subtotal As Decimal = CDec(Datadetalleventa.Item(5, rowIndex).Value)
                    subtotal -= precioPorUnidad
                    total -= precioPorUnidad
                    Datadetalleventa.Rows(rowIndex).Cells("subtotal").Value = subtotal
                    txtTotal.Text = total.ToString()
                    Datadetalleventa.Item(5, rowIndex).Value = subtotal
                    Datadetalleventa.Refresh()
                    ' Evitar eliminar la fila si está vacía
                    If Not verificarFlaVacia(Datadetalleventa.Rows(rowIndex)) Then
                        Datadetalleventa.Rows.RemoveAt(rowIndex)
                    End If
                End If
                If cantDevolver >= 1 Then
                    Dim descuenta2 As New Vproducto
                    descuenta2.devolverStock(iddescontar, 1)
                    TxtCantidad.Text = (CInt(TxtCantidad.Text) - 1).ToString()
                    Datadetalleventa.Refresh()
                End If
            End If
        Else
            MessageBox.Show("Por favor, selecciona un elemento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        prod.MostrarHabilitados(DataListadoProducto)
        DataListadoProducto.Refresh()
        If cantDevolver = 0 Then
            limpiar()
        End If
    End Sub

    Private Function verificarFlaVacia(row As DataGridViewRow) As Boolean
        For Each cell As DataGridViewCell In row.Cells
            If cell.Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.Value.ToString()) Then
                Return False
            End If
        Next
        Return True
    End Function

    'Selecciono la cantidad de un mismo producto "suma"
    Private Sub bSUMAR_Click(sender As Object, e As EventArgs) Handles bSUMAR.Click

        If String.IsNullOrWhiteSpace(TxtStock.Text) OrElse String.IsNullOrWhiteSpace(Txtstock_min.Text) Then
            MessageBox.Show("Seleccione un producto.", "Seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If TxtCantidad.Text = "" Then
                TxtCantidad.Text = "0"
            End If

            Dim stock As Integer = CInt(TxtStock.Text)
            Dim stockMinimo As Integer = CInt(Txtstock_min.Text)
            If stock <= 0 Then
                MessageBox.Show("El stock debe ser mayor que cero.", "Error en el Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtCantidad.Text = (CInt(TxtCantidad.Text) + 1).ToString()
                TxtSubtotal.Text = (CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)).ToString()
                TxtStock.Text = (stock - 1).ToString()
                If stock = stockMinimo Then
                    MessageBox.Show("Controlar el stock", "Control de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    'Selecciono la cantidad de un mismo producto "resta"
    Private Sub bRESTAR_Click(sender As Object, e As EventArgs) Handles bRESTAR.Click
        If String.IsNullOrWhiteSpace(TxtCantidad.Text) OrElse CInt(TxtCantidad.Text) = 0 Then
            MessageBox.Show("Seleccione un Producto.", "Seleccione Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TxtCantidad.Text = (CInt(TxtCantidad.Text) - 1).ToString()
            TxtSubtotal.Text = CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)
            TxtStock.Text = (CInt(TxtStock.Text) + 1).ToString()
        End If
    End Sub

#End Region




#Region "BUSCADOR"
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

    'textbox buscar,evalua que sea letra y numero
    Private Sub Tbuscar_keyPress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
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

    'metodo buscar que se utiliza al presionar enter en el texbox del buscador
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

    'boton de busqueda, lo hace en la columna codigo y nombre
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


#End Region




    Public ventaRealizada As Boolean = False
    Private Sub btnRealizar_Click(sender As Object, e As EventArgs) Handles btnRealizar.Click
        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        Dim DCliente As String = Textnombre.Text + "; " + txtApellidos.Text

        If String.IsNullOrWhiteSpace(txtNumFac.Text) OrElse
         String.IsNullOrWhiteSpace(Textidcliente.Text) OrElse
         String.IsNullOrWhiteSpace(textFecha.Text) OrElse
            String.IsNullOrWhiteSpace(vendedor) Then
            MessageBox.Show("verifique datos de cliente.", "Datos Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf (String.IsNullOrWhiteSpace(txtTotal.Text) OrElse
             (Not IsNumeric(txtTotal.Text) OrElse CDec(txtTotal.Text) <= 0)) Then
            MessageBox.Show("verifique total .", "Datos Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show(" confirmar venta? ", " Realizar venta ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim agregaF As New Vventa
            agregaF.AdFactura(txtNumFac.Text, Textidcliente.Text, textFecha.Text, txtTotal.Text, vendedor)
            While i < Datadetalleventa.Rows.Count
                row = Datadetalleventa.Rows(i)
                texto = ""
                For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                    If celda.Value IsNot Nothing Then
                        texto += vbTab + celda.Value.ToString()
                    End If
                Next
                Dim agregaDetalle As New Vdetalle
                agregaDetalle.AdDetalle(Datadetalleventa.Item(0, i).Value, Datadetalleventa.Item(1, i).Value, Datadetalleventa.Item(3, i).Value, Datadetalleventa.Item(4, i).Value)
                i += 1

            End While
            ventaRealizada = True

            MessageBox.Show("La Venta se realizo con exito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim numeroFactura As Integer
            Dim FacturaDeVenta As New FormularioFactura

            numeroFactura = txtNumFac.Text
            FacturaDeVenta.vNro = numeroFactura
            PanelUsuaio.Controls.Clear()
            FacturaDeVenta.TopLevel = False
            FacturaDeVenta.FormBorderStyle = FormBorderStyle.None
            FacturaDeVenta.Dock = DockStyle.Fill
            PanelUsuaio.Controls.Add(FacturaDeVenta)
            FacturaDeVenta.Show()
        Else
            MessageBox.Show("Se cancelo la venta.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#Region "CALCULAR EL VUELTO DE LA COMPRA"

    'valido que solo se ingrese numeros, y configuro el evento para la tecla enter
    Private Sub Tmontoingresado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tmontoingresado.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Ingrese un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            RealizarResta()
        End If
    End Sub

    Private Sub Tmontoingresado_TextChanged(sender As Object, e As EventArgs) Handles Tmontoingresado.TextChanged
        RealizarResta()
    End Sub

    'metodo para relalizar la resta y obtener el valor del vuelto
    Private Sub RealizarResta()
        If Tmontoingresado.Text = "" Then
            Tmontoingresado.Text = "0"
            TextVuelto.Text = ""
        End If

        Dim valorIngresado As Decimal
        If Decimal.TryParse(Tmontoingresado.Text, valorIngresado) Then
            If valorIngresado >= total Then
                Dim vuelto As Decimal = valorIngresado - total
                ' Muestra el vuelto en el TextBox TextVuelto sin formato de moneda
                TextVuelto.Text = vuelto.ToString()
            End If
        Else
            MessageBox.Show("Ingrese un valor numérico válido.")
        End If
    End Sub
#End Region

    Public Sub limpiar()
        TxtIdProducto.Clear()
        TxtNombreP.Clear()
        TxtCantidad.Text = ""
        TxtPrecioUnitario.Text = ""
        TxtSubtotal.Text = ""
        TxtStock.Text = ""
        Txtstock_min.Text = ""
        TxtSubtotal.Text = ""
        TxtNombreP.Text = ""
        TextControlar.Text = ""
        TextControlar.Clear()
    End Sub

    Dim iddescontar As Integer
    Private Sub TxtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProducto.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtIdProducto.Text) Then
            If Integer.TryParse(TxtIdProducto.Text, iddescontar) Then
            End If
        End If
    End Sub

    Private Sub funcionSumar()
        RemoveHandler TxtCantidad.TextChanged, AddressOf TxtCantidad_TextChanged
        If String.IsNullOrWhiteSpace(TxtStock.Text) OrElse String.IsNullOrWhiteSpace(Txtstock_min.Text) Then
            MessageBox.Show("Seleccione un producto.", "Seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If TxtCantidad.Text = "" Then
                TxtCantidad.Text = "0"
                TxtSubtotal.Text = ""
            End If
            Dim stock As Integer = CInt(TxtStock.Text)
            Dim stockMinimo As Integer = CInt(Txtstock_min.Text)
            If stock <= 0 Then
                MessageBox.Show("El stock debe ser mayor que cero.", "Error en el Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtCantidad.Text = CInt(TxtCantidad.Text)
                TxtSubtotal.Text = (CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)).ToString()
                TxtStock.Text = (stock - cantDevolver).ToString()
                If stock = stockMinimo Then
                    MessageBox.Show("Controlar el stock", "Control de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        AddHandler TxtCantidad.TextChanged, AddressOf TxtCantidad_TextChanged


    End Sub

    Private Sub agregarAldetalle()
        If String.IsNullOrWhiteSpace(TxtStock.Text) OrElse String.IsNullOrWhiteSpace(Txtstock_min.Text) Then
            MessageBox.Show("Seleccione un producto.", "Seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If TxtCantidad.Text = "" Then
                TxtCantidad.Text = "0"
            End If

            Dim stock As Integer = CInt(TxtStock.Text)
            Dim stockMinimo As Integer = CInt(Txtstock_min.Text)
            If stock <= 0 Then
                MessageBox.Show("El stock debe ser mayor que cero.", "Error en el Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TxtCantidad.Text = (CInt(TxtCantidad.Text) + 1).ToString()
                TxtSubtotal.Text = (CInt(TxtCantidad.Text) * CInt(TxtPrecioUnitario.Text)).ToString()
                TxtStock.Text = (stock - 1).ToString()
                If stock = stockMinimo Then
                    MessageBox.Show("Controlar el stock", "Control de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub


    Dim cantDevolver As Integer
    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged

        If Not String.IsNullOrWhiteSpace(TxtCantidad.Text) Then
            If Integer.TryParse(TxtCantidad.Text, cantDevolver) Then
                Dim stock As Integer
                If Integer.TryParse(TxtStock.Text, stock) Then
                    If cantDevolver > controlar Then
                        MessageBox.Show("La cantidad ingresada es mayor que el stock disponible.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ListaProductoDobleClick()
                    Else
                        '   funcionSumar()
                    End If
                End If
            End If
        Else
            ListaProductoDobleClick()
        End If

    End Sub
    Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            funcionSumar()
            '   agregarAldetalle()
            e.SuppressKeyPress = True ' Esto evita que se ingrese el salto de línea en el TextBox
        End If
    End Sub

    Private Sub TxtCantidad_keypress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If String.IsNullOrEmpty(TxtStock.Text) Then
            '    Si TxtStock está vacío, no permitir la entrada de datos en TxtCantidad
            e.Handled = True
        Else
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Datadetalleventa_CelldoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datadetalleventa.CellDoubleClick
        Dim i As Integer = Datadetalleventa.CurrentRow.Index
        TxtIdProducto.Text = Datadetalleventa(1, i).Value
        TxtNombreP.Text = Datadetalleventa(2, i).Value
        TxtCantidad.Text = Datadetalleventa(3, i).Value
        TxtPrecioUnitario.Text = Datadetalleventa(4, i).Value
        Datadetalleventa.Rows(i).Selected = True
        bSUMAR.Enabled = False
        bRESTAR.Enabled = False
        bAGREGAR.Enabled = False

    End Sub

    Private Sub dobleclickdetalle()
        Dim i As Integer = Datadetalleventa.CurrentRow.Index
        TxtIdProducto.Text = Datadetalleventa(1, i).Value
        TxtNombreP.Text = Datadetalleventa(2, i).Value
        TxtCantidad.Text = Datadetalleventa(3, i).Value
        TxtPrecioUnitario.Text = Datadetalleventa(4, i).Value
        Datadetalleventa.Rows(i).Selected = True
        bSUMAR.Enabled = False
        bRESTAR.Enabled = False
        bAGREGAR.Enabled = False

    End Sub


    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        Dim DCliente As String = Textnombre.Text + "; " + txtApellidos.Text
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then

            While i < Datadetalleventa.Rows.Count
            row = Datadetalleventa.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next
            Dim descuenta As New Vproducto
            descuenta.devolverStock(Datadetalleventa.Item(1, i).Value, Datadetalleventa.Item(3, i).Value)
            i += 1
        End While

        prod.MostrarHabilitados(DataListadoProducto)
        DataListadoProducto.Refresh()
        TxtIdProducto.Clear()
        TxtCantidad.Clear()
        TxtPrecioUnitario.Clear()
        TxtSubtotal.Clear()
        TxtStock.Text = ""
        Txtstock_min.Text = ""
        Textidcliente.Text = "23"
        Textnombre.Text = "s/n"
        txtApellidos.Text = "s/n"
        TxtNombreP.Clear()
        txtTotal.Clear()
        Datadetalleventa.Rows.Clear()
        TextVuelto.Clear()
        Tmontoingresado.Clear()
            total = "0"
        End If
    End Sub

    Private Sub Datadetalleventa_keydown(sender As Object, e As KeyEventArgs) Handles Datadetalleventa.KeyDown
        If e.KeyCode = Keys.Enter Then
            dobleclickdetalle()
            e.Handled = True
        End If
    End Sub


    Public Sub rollBack()
        Dim i As Integer = 0
        Dim texto As String
        Dim row As System.Windows.Forms.DataGridViewRow
        Dim DCliente As String = Textnombre.Text + "; " + txtApellidos.Text
        While i < Datadetalleventa.Rows.Count
            row = Datadetalleventa.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                If celda.Value IsNot Nothing Then
                    texto += vbTab + celda.Value.ToString()
                End If
            Next
            Dim descuenta As New Vproducto
            descuenta.devolverStock(Datadetalleventa.Item(1, i).Value, Datadetalleventa.Item(3, i).Value)
            i += 1
        End While
    End Sub

End Class