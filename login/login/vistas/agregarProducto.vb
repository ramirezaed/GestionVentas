Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class agregarProducto
    Dim user1 As New Vproducto()
    Dim tipo_categoria As Integer
    Dim desc_cat As String


    Private Sub agregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCategorias.Items.Add("inalambrica")
        ComboBoxCategorias.Items.Add("manual")
        ComboBoxCategorias.Items.Add("electricas")
        ComboBoxCategorias.Items.Add("")
    End Sub

    Private Sub limpiar()
        TcodigoProducto.Text = ""
        Tnombre.Text = ""
        '    Tmarca.Text = ""
        Tdescripcion.Text = ""
        Tstock.Text = ""
        Tstock_minimo.Text = ""
        TprecioCompra.Text = ""
        TprecioVenta.Text = ""
        ComboBoxCategorias.SelectedItem = ""
    End Sub

#Region "mover con el mouse"
    Private startPoint As New Point(0, 0)
    Private IsDragging As Boolean
    Private MouseOffset As Point
    Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If IsDragging Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub
    Private Sub panel5_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel5.MouseUp
        IsDragging = False
    End Sub
#End Region


#Region "VALIDAR TEXT BOX"

    Private Sub ComboBoxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorias.SelectedIndexChanged

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
            Case Else
                MessageBox.Show("Elija una categoría valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub Tnombre_keypress(sender As Object, e As KeyPressEventArgs) Handles Tnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then   'valido solo texto y espacio en blanco en nombre de usuario'
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tdescripcion_keypress(sender As Object, e As KeyPressEventArgs) Handles Tdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Tstock_keypress(sender As Object, e As KeyPressEventArgs) Handles Tstock.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tstock.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Tstock_minimo_keypress(sender As Object, e As KeyPressEventArgs) Handles Tstock_minimo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tstock_minimo.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TprecioCompra_keypress(sender As Object, e As KeyPressEventArgs) Handles TprecioCompra.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = TprecioCompra.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TprecioVenta_keypress(sender As Object, e As KeyPressEventArgs) Handles TprecioVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = TprecioVenta.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TcodigoProducto_keypress(sender As Object, e As KeyPressEventArgs) Handles TcodigoProducto.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = TcodigoProducto.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("El Codigo del producto debe ser un valor numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "CANCELAR CERRAR MINIMIZAR"
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Los daos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


#End Region


    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If String.IsNullOrWhiteSpace(Tnombre.Text) OrElse
     String.IsNullOrWhiteSpace(TcodigoProducto.Text) OrElse
     String.IsNullOrWhiteSpace(Tdescripcion.Text) OrElse
     String.IsNullOrWhiteSpace(TprecioCompra.Text) OrElse
     String.IsNullOrWhiteSpace(TprecioVenta.Text) OrElse
     String.IsNullOrWhiteSpace(Tstock.Text) OrElse
     String.IsNullOrWhiteSpace(Tstock_minimo.Text) OrElse
     ComboBoxCategorias.SelectedItem Is Nothing Then

            MessageBox.Show("Por favor, complete todos los campos y seleccione una categoría antes de agregar el producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedCategory As String = ComboBoxCategorias.SelectedItem.ToString()
        Using db As New FERRETERIAEntities1
            Dim codigoProducto As String = TcodigoProducto.Text
            Dim countCodigo As Integer = db.producto.Where(Function(p) p.codigo_pro = codigoProducto).Count()
            If countCodigo > 0 Then
                MessageBox.Show("Ya existe un producto con este código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If user1.AgregarProducto(tipo_categoria, TcodigoProducto.Text, Tnombre.Text, Tdescripcion.Text, TprecioCompra.Text, TprecioVenta.Text, Tstock.Text, Tstock_minimo.Text) Then
                    MessageBox.Show("El Producto exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    Dim gestioForm As gestionProductos = DirectCast(Application.OpenForms("gestionProductos"), gestionProductos)
                    If gestioForm IsNot Nothing Then
                        gestioForm.ActualizarListaProductos()
                    End If
                Else
                    MessageBox.Show("Error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub





End Class