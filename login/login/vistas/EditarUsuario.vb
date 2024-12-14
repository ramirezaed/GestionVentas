Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class EditarUsuario
    Dim user As New Vusuario()
    Dim tipo_usuario As Integer
    Dim desc As String
    Public num_dni As Integer

    Private Sub EditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tbuscar.Text = "Ingrese el DNI del usuario."
        ' Tbuscar.ForeColor = Color.Gray
        user.mostrarUsuarios(datalista)

    End Sub

    Private Sub LimpiarCampos()
        Tnombre.Text = ""
        Tapellido.Text = ""
        Tdni.Text = ""
        Tdireccion.Text = ""
        Tusuario.Text = ""
        Tcontraseña.Text = ""
        fechaNa.Value = DateTime.Today
        Radmin1.Checked = False
        Rvendedor1.Checked = False
        Rgeren1.Checked = False
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



#Region "validar-campos"

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

    'solo letras apellido'
    Private Sub Tapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then   'valido solo texto y espacio en blanco en nombre de usuario'
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'SOLO LETRAS Y NUMERO EN EL CAMPO DIRECCIUON
    Private Sub Tdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdireccion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False                                              'si el controlador handled es falso
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras y numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'solo numeros dni Y MAXIMO DE 8 DIGITOS'
    Private Sub Tdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdni.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tdni.Text

            If Char.IsDigit(e.KeyChar) Then
                ' Si ya hay 8 dígitos, bloquear el ingreso.
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten números y un máximo de 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' FECHA
    Dim fecha As String
    Private Sub fechaNa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechaNa.ValueChanged
        fecha = fechaNa.Value.Day & " / " & fechaNa.Value.Month & " / " & fechaNa.Value.Year
    End Sub


    'VALIDO FORMATO PARA INGRESAR DIRECCION DE CORREO
    Private Function validar_Mail(ByVal sMail As String) As Boolean
        '  retorna True o false   
        Return Regex.IsMatch(sMail,
       "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    'nombre de usuario
    Private Sub Tusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tusuario.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then   'valido solo texto en nombre de usuario'
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras y numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    'contraseña usuario
    Private Sub Tcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tcontraseña.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then   'valido solo texto en nombre de usuario'
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras y numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'tipo de perfil de usuario 
    Private Sub admin_CheckedChanged(sender As Object, e As EventArgs) Handles Radmin1.CheckedChanged
        tipo_usuario = 1
        desc = "administrador"
    End Sub



    'tipo de perfil de usuario
    Private Sub Rusuario_CheckedChanged(sender As Object, e As EventArgs) Handles Rvendedor1.CheckedChanged
        tipo_usuario = 2
        desc = "gerente"
    End Sub



    'tipo de perfil de usuario
    Private Sub Rgerente_CheckedChanged(sender As Object, e As EventArgs) Handles Rgeren1.CheckedChanged
        tipo_usuario = 3
        desc = "vendedor"
    End Sub


#End Region

#Region "BOTONES MINIZAR CERAR"

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click

        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub


#End Region


#Region "BOTONES GUARDAR Y CANCELAR"

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then
            Me.Close()
            Dim listaUsuariosForm As New gestionUsuarios()
            listaUsuariosForm.ActualizarDataGridView()
        End If
    End Sub


    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        If ((Tnombre.Text) = "") Or ((Tapellido.Text) = "") Or ((Tdni.Text) = "") Or ((Tusuario.Text) = "") Or ((Tcontraseña.Text) = "") Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (tipo_usuario = 0) Then
                MessageBox.Show("Confirme el perfil de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim fechaNacimiento As Date = fechaNa.Value
                Dim edad As Integer = DateTime.Today.Year - fechaNacimiento.Year
                If fechaNacimiento.AddYears(edad) > DateTime.Today Then
                    edad -= 1 ' Corrección si todavía no ha cumplido años este año
                End If

                If edad < 18 Then
                    MessageBox.Show("El usuario debe tener al menos 18 años de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If MsgBox("Seguro desea modificar el usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Modificar Usuario") = MsgBoxResult.Yes Then
                        Dim nombre As String = Tnombre.Text
                        Dim apellido As String = Tapellido.Text
                        Dim dni As Integer = Tdni.Text
                        Dim direccion As String = Tdireccion.Text
                        Dim fecha As String = fechaNacimiento.ToString("yyyy-MM-dd")
                        Dim usuario As String = Tusuario.Text
                        Dim contrasena As String = Tcontraseña.Text
                        Dim descripcionUsuario As String = desc
                        Dim id_tipo As Integer = tipo_usuario

                        user.ModificarUsuario(nombre, apellido, dni, direccion, fecha, usuario, contrasena, id_tipo, descripcionUsuario)

                        Dim listaUsuariosForm As gestionUsuarios = DirectCast(Application.OpenForms("ListaUsuarios"), gestionUsuarios)
                        If listaUsuariosForm IsNot Nothing Then
                            listaUsuariosForm.ActualizarDataGridView()
                        End If

                        user.mostrarUsuarios(datalista)
                        MessageBox.Show("La operación se realizo con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        LimpiarCampos()


                    End If
                End If
            End If
        End If
    End Sub


#End Region


    'DataListadoProducto
#Region "BUSCADOR"
    Private Sub Tbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tbuscar.Text

            If Char.IsDigit(e.KeyChar) Then
                ' Si ya hay 8 dígitos, bloquear el ingreso.
                If currentText.Length >= 8 Then
                    e.Handled = True
                End If
            End If
        Else
            e.Handled = True
            MessageBox.Show("Ingrese el numero de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscarP()
        End If

    End Sub



    Private Sub Tbuscar_GotFocus(sender As Object, e As EventArgs) Handles Tbuscar.GotFocus
        If Tbuscar.Text = "Ingrese DNI de usuario." Then
            Tbuscar.Text = ""
            Tbuscar.ForeColor = Color.Black ' Restaurar el color de texto a negro
        End If
    End Sub

    Private Sub Tbuscar_LostFocus(sender As Object, e As EventArgs) Handles Tbuscar.LostFocus
        If String.IsNullOrWhiteSpace(Tbuscar.Text) Then
            Tbuscar.Text = "Ingrese DNI de usuario."
            Tbuscar.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        End If
    End Sub





    Private Sub buscar_Click_1(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 7 Then
            datalista.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In datalista.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For
                    End If
                Next

                If encontradaCoincidencia Then
                    Exit For
                End If
            Next

            If Not encontradaCoincidencia Then
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro un usuario con ese DNI ¿Desea agregar un nuevo Usuario?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    ' Abre el formulario para agregar un cliente.
                    agregarUsuario.Show()
                Else
                    Tbuscar.Clear()
                End If
            End If
        Else
            MessageBox.Show("El Dni debe tener al menos 7 digitos.", "Error de Búsqueda")
        End If
    End Sub



    Private Sub buscarP()
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 7 Then
            datalista.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In datalista.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString() = valorBuscado Then
                        row.Selected = True
                        encontradaCoincidencia = True
                        Exit For
                    End If
                Next

                If encontradaCoincidencia Then
                    Exit For
                End If
            Next

            If Not encontradaCoincidencia Then
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro un usuario con ese DNI ¿Desea agregar un nuevo Usuario?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    ' Abre el formulario para agregar un cliente.
                    agregarUsuario.Show()
                Else
                    Tbuscar.Clear()
                End If
            End If
        Else
            MessageBox.Show("El Dni debe tener al menos 7 digitos.", "Error de Búsqueda")
        End If
    End Sub



#End Region


#Region "DOBLE-CLICK"

    Private Sub datalista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalista.CellContentClick
        Dim i As Integer = datalista.CurrentRow.Index

        Tnombre.Text = datalista(1, i).Value.ToString()
        Tapellido.Text = datalista(2, i).Value.ToString()
        Tdni.Text = datalista(3, i).Value.ToString()
        fechaNa.Value = CType(datalista(4, i).Value, Date)
        Tdireccion.Text = datalista(5, i).Value.ToString()
        Tusuario.Text = datalista(6, i).Value.ToString()
        Tcontraseña.Text = datalista(7, i).Value.ToString()
        desc = datalista(8, i).Value.ToString()

        Select Case desc
            Case "administrador"
                Radmin1.Checked = True
            Case "gerente"
                Rvendedor1.Checked = True
            Case "vendedor"
                Rgeren1.Checked = True
        End Select
    End Sub


    Private Sub dobleClik()
        Dim i As Integer = datalista.CurrentRow.Index

        Tnombre.Text = datalista(1, i).Value.ToString()
        Tapellido.Text = datalista(2, i).Value.ToString()
        Tdni.Text = datalista(3, i).Value.ToString()
        fechaNa.Value = CType(datalista(4, i).Value, Date)
        Tdireccion.Text = datalista(5, i).Value.ToString()
        Tusuario.Text = datalista(6, i).Value.ToString()
        Tcontraseña.Text = datalista(7, i).Value.ToString()
        desc = datalista(8, i).Value.ToString()

        Select Case desc
            Case "administrador"
                Radmin1.Checked = True
            Case "gerente"
                Rvendedor1.Checked = True
            Case "vendedor"
                Rgeren1.Checked = True
        End Select
    End Sub

    Private Sub DataListadoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles datalista.KeyDown
        If e.KeyCode = Keys.Enter Then
            dobleClik()
            e.Handled = True
        End If
    End Sub

#End Region

End Class