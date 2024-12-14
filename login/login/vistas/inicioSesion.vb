Public Class inicioSesion
    Public N_Usuario As String
    'textbox usuario'
    Private Sub nusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nusuario.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then   'valido solo texto y numeros en nombre de usuario'
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras y numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '   MsgBox("debe completar todos los campos")
        End If

    End Sub
    Private Sub ncontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ncontraseña.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then   'valido solo texto en nombre de usuario'
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show(" solo letras y numeros ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            ingresarU()
        End If


    End Sub



#Region "mover con el mouse"

    Private startPoint As New Point(0, 0)
    Private IsDragging As Boolean
    Private MouseOffset As Point


    Private Sub barra_MouseDown(sender As Object, e As MouseEventArgs) Handles barra.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub barra_MouseMove(sender As Object, e As MouseEventArgs) Handles barra.MouseMove
        If IsDragging Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub
    Private Sub barra_MouseUp(sender As Object, e As MouseEventArgs) Handles barra.MouseUp
        IsDragging = False
    End Sub

#End Region


    Private Sub ingresarU()
        If nusuario.Text = "" Or ncontraseña.Text = "" Then
            MsgBox("Debe ingresar todos los datos", MsgBoxStyle.Information, "Login")
        Else

            Dim IngresoUsuario As New Vusuario(nusuario.Text, ncontraseña.Text)
            If IngresoUsuario.ControlUsuario(IngresoUsuario.getUsuario, IngresoUsuario.getContraseña) Then

                Using db As New FERRETERIAEntities1

                    IngresoUsuario.EnlaceDatos(IngresoUsuario.getUsuario)
                    N_Usuario = nusuario.Text

                    If (IngresoUsuario.getId_tipo = 1) Then

                        admin.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()
                    ElseIf (IngresoUsuario.getId_tipo = 3) Then
                        user.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()
                    ElseIf (IngresoUsuario.getId_tipo = 2) Then

                        gerente.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()

                    End If


                End Using
            Else

            End If
        End If
    End Sub

    Private Sub bingresar_Click(sender As Object, e As EventArgs) Handles bingresar.Click
        If nusuario.Text = "" Or ncontraseña.Text = "" Then
            MsgBox("Debe ingresar todos los datos", MsgBoxStyle.Information, "Login")
        Else

            Dim IngresoUsuario As New Vusuario(nusuario.Text, ncontraseña.Text)
            If IngresoUsuario.ControlUsuario(IngresoUsuario.getUsuario, IngresoUsuario.getContraseña) Then

                Using db As New FERRETERIAEntities1

                    IngresoUsuario.EnlaceDatos(IngresoUsuario.getUsuario)
                    N_Usuario = nusuario.Text

                    If (IngresoUsuario.getId_tipo = 1) Then

                        admin.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()
                    ElseIf (IngresoUsuario.getId_tipo = 3) Then

                        user.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()
                    ElseIf (IngresoUsuario.getId_tipo = 2) Then

                        gerente.Show()
                        nusuario.Text = ""
                        ncontraseña.Text = ""
                        Me.Hide()
                    End If


                End Using
            Else

            End If
        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then

            Application.Exit()

        End If
    End Sub

    Private Sub Bminimizar_Click(sender As Object, e As EventArgs) Handles Bminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class


