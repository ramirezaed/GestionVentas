Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient





Public Class agregarCliente

    Dim fecha As String
    Dim cli As New Vcliente()
    Dim gestionClientesForm As gestionClientes = New gestionClientes()
    Public Nomb_Usuario As String
    Public num_dni As Integer

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        Dim verificar As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(sMail, verificar)
    End Function

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


    Private Sub limpiar()
        Tnombre.Text = ""
        Tapellido.Text = ""
        Tdni.Text = ""
        Temail.Text = ""
        Tdomicilio.Text = ""
        Ttelefono.Text = ""
        fechaNacimiento.Value = DateTime.Today ' Establecer la fecha actual en el control fechaNa

    End Sub



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



#Region "BOTON CERRAR Y MINIMIZAR"
    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click

        If MsgBox("Los daos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub
#End Region

#Region "BOTON CANCELAR y guardar"

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cancelar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
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
                    Using db As New FERRETERIAEntities1
                        ' Verificar si ya existe un usuario con el mismo DNI
                        Dim queryDNI As String = "SELECT COUNT(*) FROM cliente WHERE dni_cliente = @Dni"
                        Dim cmdDNI As New SqlCommand(queryDNI, db.Database.Connection)
                        cmdDNI.Parameters.AddWithValue("@Dni", Tdni.Text)

                        db.Database.Connection.Open()
                        Dim countDNI As Integer = Convert.ToInt32(cmdDNI.ExecuteScalar())
                        db.Database.Connection.Close()

                        If countDNI > 0 Then
                            MessageBox.Show("Ya existe un usuario con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else

                            Dim insCli As New Vcliente()
                            If insCli.AgregarCliente(Tnombre.Text, Tapellido.Text, Tdni.Text, Temail.Text, Tdomicilio.Text, fecha, Ttelefono.Text) Then
                                MessageBox.Show("El Cliente ha sido agregado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                limpiar()
                                Dim gestionForm As gestionClientes = DirectCast(Application.OpenForms("gestionClientes"), gestionClientes)
                                If gestionForm IsNot Nothing Then
                                    gestionForm.ActualizarListaClientes1()
                                End If

                            End If
                            If MsgBox("Desea agregar Otro usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Agregar Usuario") = MsgBoxResult.No Then
                                Me.Close()
                            End If
                        End If
                    End Using
                End If
            End If
        End If













    End Sub

#End Region



End Class