

Imports System.ComponentModel
' Espacio de nombres con clases para el manejo de expresiones regulares en .NET  
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class gestionUsuarios

    Dim user As New Vusuario()
    Private usuarioSeleccionado As usuario

    Private Sub gestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datalista.ClearSelection()
        Tbuscar.Text = "Ingrese DNI de usuario."
        Tbuscar.ForeColor = Color.Gray ' Cambiar el color de texto a gris
        user.mostrarUsuarios(datalista)
        datalista.ClearSelection()
        datalista.CurrentCell = Nothing
    End Sub

    Public Sub ActualizarDataGridView() 'utilizo para actualizar lista de usuarios dps de agregar o editar
        Using db As New FERRETERIAEntities1
            Dim listaUsuarios = From q In db.usuario
                                Select id = q.id_usuario,
            Nombre = q.nombre, Apellido = q.apellido, Dni = q.dni_usuario,
                                    fechanacimiento = q.fecha_nac, Direccion = q.direccion,
                                    usuario = q.usuario1, Contrasena = q.contraseña,
                                    Tipo = q.descripcionUsuario, codUser = q.id_tipo, Estado = q.estado
            datalista.DataSource = listaUsuarios.ToList()
            datalista.ClearSelection()
        End Using
    End Sub

#Region "BUSCADOR"

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

    Private Sub Tbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            Dim currentText As String = Tbuscar.Text

            If currentText.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
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

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
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

#Region "HABILITAR - DESHABILITAR USUARIOS - AGREGAR - ELIMINAR"

    Private Sub Bagregar_Click(sender As Object, e As EventArgs) Handles Bagregar.Click
        agregarUsuario.Show()
    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        EditarUsuario.Show()
    End Sub

    Private Sub BHabilitar_Click(sender As Object, e As EventArgs) Handles BHabilitar.Click
        If datalista.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(datalista.SelectedRows(0).Cells(0).Value)
            user.HabilitarUsuario(id)
            user.mostrarUsuarios(datalista)
            datalista.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un usuario para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        datalista.ClearSelection()
    End Sub


    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click
        If datalista.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(datalista.SelectedRows(0).Cells(0).Value)
            user.DesactivarUsuario(id)
            user.mostrarUsuarios(datalista)
            datalista.ClearSelection()
        Else
            MessageBox.Show("Por favor, seleccione un usuario para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        datalista.ClearSelection()
    End Sub

#End Region


End Class