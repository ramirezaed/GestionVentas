Public Class ListaUsuarios
    Dim user As New Vusuario()

    Private Sub ListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.mostrarUsuarios(DataUsuarios)
        DataUsuarios.ClearSelection()
    End Sub

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

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        If Application.OpenForms().OfType(Of reporteVentaPorEmpleado).Any() Then
            Dim varRepor As reporteVentaPorEmpleado = Application.OpenForms().OfType(Of reporteVentaPorEmpleado).First()
            Dim i As Integer = DataUsuarios.CurrentRow.Index

            varRepor.TnombreUsuario.Text = DataUsuarios(6, i).Value.ToString()
            Me.Close()
        Else
            Dim varrepor1 As New reporteVentaPorEmpleado()
            Dim i As Integer = DataUsuarios.CurrentRow.Index
            varrepor1.TnombreUsuario.Text = DataUsuarios(6, i).Value.ToString
            varrepor1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        If MsgBox("Los datos no guardados se perderan, desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Salir") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Tbuscar_GotFocus(sender As Object, e As EventArgs) Handles Tbuscar.GotFocus
        If Tbuscar.Text = "Ingrese nombre de usuario." Then
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
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Ignore the key press
            '       MessageBox.Show("Ingrese nombre de usuario.", "Solo letras", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            buscarP()
        End If
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim valorBuscado As String = Tbuscar.Text.Trim()

        If valorBuscado.Length >= 1 Then
            DataUsuarios.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In DataUsuarios.Rows
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
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro un usuario con ese nombre ¿Desea agregar un nuevo Usuario?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

        If valorBuscado.Length >= 1 Then
            DataUsuarios.ClearSelection()
            Dim encontradaCoincidencia As Boolean = False

            For Each row As DataGridViewRow In DataUsuarios.Rows
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
                Dim respuesta As DialogResult = MessageBox.Show("No se encontro un usuario con ese nombre ¿Desea agregar un nuevo Usuario?", "Búsqueda sin resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Sub mostrarP()
        If Application.OpenForms().OfType(Of reporteVentaPorEmpleado).Any() Then
            Dim varRepor As reporteVentaPorEmpleado = Application.OpenForms().OfType(Of reporteVentaPorEmpleado).First()
            Dim i As Integer = DataUsuarios.CurrentRow.Index

            varRepor.TnombreUsuario.Text = DataUsuarios(6, i).Value.ToString()
            Me.Close()
        Else
            Dim varrepor1 As New reporteVentaPorEmpleado()
            Dim i As Integer = DataUsuarios.CurrentRow.Index
            varrepor1.TnombreUsuario.Text = DataUsuarios(6, i).Value.ToString()
            varrepor1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataUsuarios_CelldoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataUsuarios.CellDoubleClick
        mostrarP()
    End Sub

    Private Sub DataUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles DataUsuarios.KeyDown
        If e.KeyCode = Keys.Enter Then
            mostrarP()
        End If
    End Sub


End Class