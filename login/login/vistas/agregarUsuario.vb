Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient


Public Class agregarUsuario
    Dim user As New Vusuario()
    Dim listaUsuariosForm As gestionUsuarios = New gestionUsuarios()
    Public Nomb_Usuario As String
    Public num_dni As Integer

    Private Sub limpiar()
        Tnombre.Text = ""
        Tapellido.Text = ""
        Tdni.Text = ""
        Tdireccion.Text = ""
        Tusuario.Text = ""
        Tcontraseña.Text = ""
        fechaNa.Value = DateTime.Today ' Establecer la fecha actual en el control fechaNa
        Radmin1.Checked = False
        Rvendedor1.Checked = False
        Rgeren1.Checked = False
    End Sub

#Region "BOTONES MINIMIZAR CERRAR"

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click

        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub
#End Region

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
#Region "VALIDAR TEXTBOX"

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
        Dim verificar As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(sMail, verificar)
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

#End Region


#Region "VALIDAR TIPO USUARIO"

    'creo variables para tipo y descripcion de usuario'
    Dim tipo_usuario As Integer
    Dim desc As String
    Public Property CbBusqueda As Object

    Private Sub admin_CheckedChanged(sender As Object, e As EventArgs) Handles Radmin1.CheckedChanged
        tipo_usuario = 1
        desc = "administrador"
    End Sub

    Private Sub Rusuario_CheckedChanged(sender As Object, e As EventArgs) Handles Rvendedor1.CheckedChanged
        tipo_usuario = 2
        desc = "gerente"
    End Sub

    Private Sub Rgerente_CheckedChanged(sender As Object, e As EventArgs) Handles Rgeren1.CheckedChanged
        tipo_usuario = 3
        desc = "vendedor"
    End Sub

#End Region


#Region "AGREGAR USUARIO"

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If String.IsNullOrWhiteSpace(Tnombre.Text) Or
            String.IsNullOrWhiteSpace(Tapellido.Text) Or
            String.IsNullOrWhiteSpace(Tdni.Text) Or
            String.IsNullOrWhiteSpace(Tdireccion.Text) Or
            String.IsNullOrWhiteSpace(Tusuario.Text) Or
            String.IsNullOrWhiteSpace(Tcontraseña.Text) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not (Radmin1.Checked Or Rvendedor1.Checked Or Rgeren1.Checked) Then
            MessageBox.Show("Debe seleccionar un tipo de perfil de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim fechaNacimiento As Date = fechaNa.Value
            Dim edad As Integer = DateTime.Today.Year - fechaNacimiento.Year

            If fechaNacimiento.AddYears(edad) > DateTime.Today Then
                edad -= 1 ' Corrección si todavía no ha cumplido años este año
            End If

            If edad < 18 Then
                MessageBox.Show("El usuario debe tener al menos 18 años de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Using db As New FERRETERIAEntities1
                    ' Verificar si ya existe un usuario con el mismo DNI
                    Dim queryDNI As String = "SELECT COUNT(*) FROM usuario WHERE dni_usuario = @Dni"
                    Dim cmdDNI As New SqlCommand(queryDNI, db.Database.Connection)
                    cmdDNI.Parameters.AddWithValue("@Dni", Tdni.Text)
                    db.Database.Connection.Open()
                    Dim countDNI As Integer = Convert.ToInt32(cmdDNI.ExecuteScalar())
                    db.Database.Connection.Close()

                    If countDNI > 0 Then
                        MessageBox.Show("Ya existe un usuario con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        ' Verificar si ya existe un usuario con el mismo usuario
                        Dim queryUsuario As String = "SELECT COUNT(*) FROM usuario WHERE usuario = @Usuario"
                        Dim cmdUsuario As New SqlCommand(queryUsuario, db.Database.Connection)
                        cmdUsuario.Parameters.AddWithValue("@Usuario", Tusuario.Text)
                        db.Database.Connection.Open()
                        Dim countUsuario As Integer = Convert.ToInt32(cmdUsuario.ExecuteScalar())
                        db.Database.Connection.Close()

                        If countUsuario > 0 Then
                            MessageBox.Show("Ya existe un usuario con este nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            ' Si no hay duplicados, agregar el usuario
                            user.AgregarUsuario(Tnombre.Text, Tapellido.Text, Tdni.Text, fecha, Tdireccion.Text, Tusuario.Text, Tcontraseña.Text, tipo_usuario, desc)
                            MessageBox.Show("El Usuario ha sido agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            limpiar()
                            Dim listaUsuariosForm As gestionUsuarios = DirectCast(Application.OpenForms("ListaUsuarios"), gestionUsuarios)
                            If listaUsuariosForm IsNot Nothing Then
                                listaUsuariosForm.ActualizarDataGridView()
                            End If
                            If MsgBox("Desea agregar Otro usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Usuario") = MsgBoxResult.No Then
                                Me.Close()
                            End If

                        End If
                        '  If MsgBox("Desea agregar Otro usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Usuario") = MsgBoxResult.No Then
                        ' Me.Close()
                        'End If
                    End If
                End Using
            End If
        End If
    End Sub

#End Region

#Region "BOTON CANCELAR"

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

#End Region

End Class


