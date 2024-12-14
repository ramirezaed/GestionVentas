Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient


Public Class EditarCliente
    Dim cli As New Vcliente()
    Dim fecha As String


    Private Sub EditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tbuscar.Text = "Ingrese DNI del cliente."
        Tbuscar.ForeColor = Color.Gray ' Cambiar el color de texto a gris

        cli.MostrarClientes(DataListadoCliente)
    End Sub

    Private Sub limpiar()
        Tnombre.Text = ""
        Tapellido.Text = ""
        Tdni.Text = ""
        fechaNacimiento.Value = DateTime.Today
        Tdomicilio.Text = ""
        Temail.Text = ""
        Ttelefono.Text = ""

    End Sub

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        Dim verificar As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(sMail, verificar)
    End Function

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
#Region "validar Text box"
    Private Sub Tnombre_keypress(sender As Object, e As KeyPressEventArgs) Handles Tnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then   'valido solo texto y espacio en blanco en nombre de usuario'
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" Solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" Solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Tdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdni.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tdni.Text
            If Char.IsDigit(e.KeyChar) Then
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números y un máximo de 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Temail_TextChanged(sender As Object, e As EventArgs) Handles Temail.TextChanged
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim emailRegex As New Regex(emailPattern)
    End Sub

    Private Sub Ttelefono_keypress(sender As Object, e As KeyPressEventArgs) Handles Ttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Ttelefono.Text
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

    Private Sub fechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles fechaNacimiento.ValueChanged
        fecha = fechaNacimiento.Value.Day & " / " & fechaNacimiento.Value.Month & " / " & fechaNacimiento.Value.Year

    End Sub

#End Region

#Region "boton mini cerrar"

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "click lista clientes"

    Private Sub DataListadoCliente_doubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataListadoCliente.CellMouseDoubleClick
        Dim i As Integer = DataListadoCliente.CurrentRow.Index

        Tnombre.Text = DataListadoCliente(1, i).Value.ToString()
        Tapellido.Text = DataListadoCliente(2, i).Value.ToString()
        Tdni.Text = DataListadoCliente(3, i).Value.ToString()
        fechaNacimiento.Value = CType(DataListadoCliente(4, i).Value, Date)
        Temail.Text = DataListadoCliente(5, i).Value.ToString()
        Tdomicilio.Text = DataListadoCliente(6, i).Value.ToString()
        Ttelefono.Text = DataListadoCliente(7, i).Value.ToString()
    End Sub




    Private Sub dobleclick()
        Dim i As Integer = DataListadoCliente.CurrentRow.Index

        Tnombre.Text = DataListadoCliente(1, i).Value.ToString()
        Tapellido.Text = DataListadoCliente(2, i).Value.ToString()
        Tdni.Text = DataListadoCliente(3, i).Value.ToString()
        fechaNacimiento.Value = CType(DataListadoCliente(4, i).Value, Date)
        Temail.Text = DataListadoCliente(5, i).Value.ToString()
        Tdomicilio.Text = DataListadoCliente(6, i).Value.ToString()
        Ttelefono.Text = DataListadoCliente(7, i).Value.ToString()
    End Sub

    Private Sub DataListadoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles DataListadoCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            dobleclick()
            e.Handled = True
        End If
    End Sub


#End Region

#Region "GUARDAR Y CANCELAR"

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        If String.IsNullOrWhiteSpace(Tnombre.Text) Or
      String.IsNullOrWhiteSpace(Tapellido.Text) Or
      String.IsNullOrWhiteSpace(Tdni.Text) Or
      String.IsNullOrWhiteSpace(Ttelefono.Text) Or
      String.IsNullOrWhiteSpace(Temail.Text) Or
      String.IsNullOrWhiteSpace(Tdomicilio.Text) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim fechaNaci As Date = fechaNacimiento.Value
            Dim edad As Integer = DateTime.Today.Year - fechaNaci.Year

            If fechaNaci.AddYears(edad) > DateTime.Today Then
                edad -= 1
            End If

            If edad < 18 Then
                MessageBox.Show("El cliente debe tener al menos 18 años de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not validar_Mail(Temail.Text) Then
                    MessageBox.Show("El formato del correo electrónico no es válido, ejempoplo: nombre@dominio.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If MsgBox("Confirmar modificación", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar cliente") = MsgBoxResult.Yes Then

                        Dim nombre As String = Tnombre.Text
                        Dim apellido As String = Tapellido.Text
                        Dim dni As Integer = Tdni.Text
                        Dim fecha As String = fechaNaci.ToString("yyyy-MM-dd")
                        Dim email As String = Temail.Text
                        Dim domicilio As String = Tdomicilio.Text

                        Dim telefono As Integer = Ttelefono.Text

                        cli.ModificarCLiente(nombre, apellido, dni, fecha, email, domicilio, telefono)


                        Dim listacli As gestionClientes = DirectCast(Application.OpenForms("gestionClientes"), gestionClientes)
                        If listacli IsNot Nothing Then
                            listacli.ActualizarListaClientes1()
                        End If



                        cli.MostrarClientes(DataListadoCliente)
                        limpiar()



                        MessageBox.Show("La operación se ha realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

        End If
    End Sub





#End Region

#Region "buscador"
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
End Class



