
Imports System
Imports System.Linq


Public Class Vusuario
    Private id_usuario As Integer
    Private nombre, apellido, direccion, usuario, contraseña, correo, descripcionUsuario As String
    Private dni As Integer
    Private idTipo As Integer
    Private estado As String
    Private fecha As String

    Private _idUsuario As Integer
    Private _nombre As String
    ' Otros atributos y métodos de la clase...

#Region "Constructores"
    Public Sub New(ByVal p_dni As Integer)
        setDni(p_dni)
    End Sub

    Public Sub New(ByVal p_usuario As String)
        setUsuario(p_usuario)
    End Sub

    Public Sub New(ByVal p_nombre As String, ByVal p_apellido As String, ByVal p_direccion As String, ByVal p_telefono As Int64, ByVal p_dni As Int64,
                   ByVal p_usuario As String, ByVal p_contraseña As String, ByVal p_id_tipo As Integer, ByVal p_estado As String, ByVal p_correo As String,
                   ByVal p_fecha As String, ByVal p_descripcionUsuario As String)



        setNombre(p_nombre)
        setApellido(p_apellido)
        setDireccion(p_direccion)
        setDni(p_dni)
        setUsuario(p_usuario)
        setContraseña(p_contraseña)
        setId_tipo(p_id_tipo)
        setEstado(p_estado)
        setcorreo(p_correo)
        setfecha(p_fecha)
        setdescripcionUsuario(p_descripcionUsuario)
    End Sub



    Public Sub New()
        setIdUsuario(0)
        setNombre("")
        setApellido("")
        setDireccion("")
        setDni(0)
        setUsuario("")
        setContraseña("")
        setId_tipo(0)
        setEstado("")
        setcorreo("")
        setfecha("")
        setDescripcionUsuario("")

    End Sub

    Public Sub New(ByVal p_usuario As String, ByVal p_contraseña As String)
        setUsuario(p_usuario)
        setContraseña(p_contraseña)
    End Sub


#End Region

#Region "GET"
    Public Function getIdUsuario()
        Return id_usuario
    End Function

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getApellido()
        Return apellido
    End Function

    Public Function getDireccion()
        Return direccion
    End Function

    Public Function getDni()
        Return dni
    End Function

    Public Function getContraseña()
        Return contraseña
    End Function

    Public Function getId_tipo()
        Return idTipo
    End Function

    Public Function getEstado()
        Return estado
    End Function

    Public Function getcorreo()
        Return correo
    End Function

    Public Function getdescripcionUsuario()
        Return descripcionUsuario
    End Function



    Public Function getfecha()
        Return fecha
    End Function


    Public Function getUsuario()
        Return usuario
    End Function




#End Region

#Region "SET"

    Sub setIdUsuario(ByVal p_id_usuario As String)
        id_usuario = p_id_usuario
    End Sub


    Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Sub setApellido(ByVal p_apellido As String)
        apellido = p_apellido
    End Sub

    Sub setDireccion(ByVal p_Direccion As String)
        direccion = p_Direccion
    End Sub

    'Sub setTelefono(ByVal p_Telefono As String)
    '   telefono = p_Telefono
    'End Sub
    Sub setDni(ByVal p_dni As Integer)
        dni = p_dni
    End Sub

    Sub setfecha(ByVal p_fecha As String)
        fecha = p_fecha
    End Sub
    Sub setUsuario(ByVal p_Usuario As String)
        usuario = p_Usuario
    End Sub

    Sub setContraseña(ByVal p_contraseña As String)
        contraseña = p_contraseña
    End Sub

    Sub setId_tipo(ByRef p_id_tipo As Int32)
        idTipo = p_id_tipo
    End Sub

    Sub setEstado(ByVal p_estado As String)
        estado = p_estado
    End Sub

    Sub setcorreo(ByVal p_correo As String)
        correo = p_correo
    End Sub
    Sub setdescripcionUsuario(ByVal p_descripcionUsuario As String)
        descripcionUsuario = p_descripcionUsuario
    End Sub




#End Region

    Public Function ObtenerDatos(ByVal p_dni As Integer)
        Try
            Using db As New FERRETERIAEntities1

                Dim datos = (From q In db.usuario
                             Select q Where (q.dni_usuario = p_dni)).First()

                setNombre(datos.nombre)
                setApellido(datos.apellido)
                setDireccion(datos.direccion)
                setDni(datos.dni_usuario)
                setUsuario(datos.usuario1)
                setContraseña(datos.contraseña)
                setId_tipo(datos.id_tipo)
                setEstado(datos.estado)
                setfecha(datos.fecha_nac)
                setdescripcionUsuario(datos.descripcionUsuario)



            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EnlaceDatos(ByVal usuario As String)
        Try
            Using db As New FERRETERIAEntities1
                Dim datos = (From q In db.usuario
                             Select q Where (q.usuario1 = usuario)).First()
                setIdUsuario(datos.id_usuario)

                setNombre(datos.nombre)
                setApellido(datos.apellido)
                setDireccion(datos.direccion)

                setDni(datos.dni_usuario)
                setUsuario(datos.usuario1)
                setContraseña(datos.contraseña)
                setId_tipo(datos.id_tipo)
                setEstado(datos.estado)
                setfecha(datos.fecha_nac)
                setdescripcionUsuario(datos.descripcionUsuario)


            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    'funcion control de usurio segun el codigo de usuario para el inicio de sesion
    '    Public Function ControlUsuario(ByVal usuario As String, ByVal contraseña As String)
    '   Try
    '  Using db As New FERRETERIAEntities1
    '
    'Dim verif = (From q In db.usuario
    '  Select Case q Where (q.usuario1 = usuario And q.contraseña = contraseña And q.estado = True)).First()

    'End Using
    'Return True
    'Catch ex As Exception
    '       MsgBox("usuario no registrado o no esta habilitado")
    'Return False
    'End Try
    'End Function

    Public Function ControlUsuario(ByVal usuario As String, ByVal contraseña As String)
        Try
            Using db As New FERRETERIAEntities1
                Dim verif = (From q In db.usuario
                             Where q.usuario1.Equals(usuario, StringComparison.Ordinal) AndAlso
                               q.contraseña.Equals(contraseña, StringComparison.Ordinal) AndAlso
                               q.estado = True
                         ).FirstOrDefault()

                If verif IsNot Nothing Then
                    Return True
                Else
                    MsgBox("Usuario no registrado o no está habilitado")
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error al verificar el usuario: " & ex.Message)
            Return False
        End Try
    End Function

    'mostrar datos de usuario en data grid
    'Public Sub mostrarUsuarios(ByVal grid As DataGridView)
    'Using mostrar As New FERRETERIAEntities1
    'Dim verUser = (From q In mostrar.usuario
    'Select Case
    '                          Num = q.id_usuario, Nombre = q.nombre, Apellido = q.apellido, Dni = q.dni_usuario, fechanacimiento = q.fecha_nac, Direccion = q.direccion, usuario = q.usuario1, Contrasena = q.contraseña, Tipo = q.descripcionUsuario, Estado = q.estado).ToList 'codUser = q.id_tipo, 
    '      grid.DataSource = verUser
    'End Using
    'End Sub

    Public Sub mostrarUsuarios(ByVal grid As DataGridView)
        Using mostrar As New FERRETERIAEntities1
            Dim verUser = (From q In mostrar.usuario
                           Where q.id_usuario <> 2 ' Agregar la condición para id_usuario diferente de 1
                           Select
                           Num = q.id_usuario, Nombre = q.nombre, Apellido = q.apellido, Dni = q.dni_usuario, fechanacimiento = q.fecha_nac, Direccion = q.direccion, usuario = q.usuario1, Contrasena = q.contraseña, Tipo = q.descripcionUsuario, Estado = q.estado).ToList
            grid.DataSource = verUser
        End Using
    End Sub






    Public Function AgregarUsuario(ByVal p_nombre As String, ByVal p_apellido As String, ByVal p_dni As Integer, ByVal p_fecha As String, ByVal p_direccion As String, 'ByVal p_telefono As Int64,
                   ByVal p_usuario As String, ByVal p_contraseña As String, ByVal p_id_tipo As Integer, ByVal p_descripcionUsuario As String) ' ByVal p_id_tipo As Integer
        ' Mostrar un MsgBox para confirmar la operación
        Dim respuesta As MsgBoxResult = MsgBox("Seguro desea agregar un nuevo usuario?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo Usuario")

        ' Verificar la respuesta del usuario
        If respuesta = MsgBoxResult.Yes Then
            Try
                Using AgregaUser As New FERRETERIAEntities1
                    Dim AgregUser As New usuario
                    With AgregUser
                        .nombre = p_nombre
                        .apellido = p_apellido
                        .dni_usuario = p_dni
                        .fecha_nac = p_fecha
                        .direccion = p_direccion
                        .usuario1 = p_usuario
                        .contraseña = p_contraseña
                        .id_tipo = p_id_tipo
                        .descripcionUsuario = p_descripcionUsuario
                        .estado = True
                    End With
                    AgregaUser.usuario.Add(AgregUser)
                    AgregaUser.SaveChanges()
                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
        Else
            ' El usuario no está seguro, por lo que no se agrega el usuario
            Return False
        End If
    End Function






    'funcion para controlar que el nombre de usuario este disponible ( controlar)
    Public Function VerificarUsuario(ByVal p_usuario As String)
        Try
            Using db As New FERRETERIAEntities1
                Dim verif = (From q In db.usuario
                             Select q Where (q.usuario1 = p_usuario)).First()
            End Using
            Return True
        Catch ex As Exception
            'MsgBox("Usuario disponible")
            Return False
        End Try
    End Function


    'funcion modificar usuario
    Public Function ModificarUsuario(ByVal p_nombre As String,
                                     ByVal p_apellido As String,
                                     ByVal p_dni As Integer,
                                     ByVal p_direccion As String,
                                     ByVal p_fecha As String,
                                     ByVal p_usuario As String, ByVal p_contraseña As String,
                                     ByVal p_id_tipo As Integer, ByVal p_descripcionUsuario As String)
        Try
            Using modiU As New FERRETERIAEntities1
                Dim modif = (From q In modiU.usuario Where (p_dni = q.dni_usuario) Select q).First
                With modif
                    .nombre = p_nombre
                    .apellido = p_apellido
                    .dni_usuario = p_dni
                    .fecha_nac = p_fecha
                    .direccion = p_direccion
                    .usuario1 = p_usuario
                    .contraseña = p_contraseña
                    .id_tipo = p_id_tipo
                    .descripcionUsuario = p_descripcionUsuario


                    modiU.SaveChanges()
                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    'Habilitar usuario'
    Public Function HabilitarUsuario(ByVal p_idusuario As Integer) As Boolean
        Try
            Using User As New FERRETERIAEntities1
                Dim modif = (From q In User.usuario Where q.id_usuario = p_idusuario Select q).FirstOrDefault()

                If modif Is Nothing Then
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If modif.estado = True Then
                    MessageBox.Show("El usuario ya está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea habilitar al usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Habilitar usuario")

                If respuesta = MsgBoxResult.No Then
                    Return False ' No hacer nada si el usuario selecciona "No"
                End If

                ' Habilitar al usuario
                modif.estado = True
                User.SaveChanges()

                MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al habilitar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function




    '  ELIMINAR USUARIO
    Public Function DesactivarUsuario(ByVal p_idusuario As Integer) As Boolean
        Try
            Using User As New FERRETERIAEntities1
                Dim modif = (From q In User.usuario Where q.id_usuario = p_idusuario Select q).FirstOrDefault()

                If modif Is Nothing Then
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If modif.estado = False Then
                    MessageBox.Show("El usuario ya está deshabilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea dar de baja al usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Baja de usuario")

                If respuesta = MsgBoxResult.No Then
                    Return False ' No hacer nada si el usuario selecciona "No"
                End If

                ' Desactivar al usuario
                modif.estado = False
                User.SaveChanges()

                MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al desactivar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    'buscar usuario por dni
    Dim p_dni As Integer
    Public Function BuscarPorDni(ByVal grid As DataGridView)

        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.usuario Where p_dni = q.dni_usuario
                                  Select IdUsuario = q.id_usuario, Dni = q.dni_usuario, Nombre = q.nombre, Apellido = q.apellido, Direccion = q.direccion,
                                Usuario = q.usuario1, Contrasena = q.contraseña, Tipo = q.id_tipo,
                               Estado = q.estado).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                    'Else
                    '    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BuscarNyA(ByVal p_nombre As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.usuario Where ((q.nombre = p_nombre) Or (q.apellido = p_nombre))
                                  Select IdUsuario = q.id_usuario, Dni = q.dni_usuario, Nombre = q.nombre, Apellido = q.apellido, Direccion = q.direccion,
                              Usuario = q.usuario1, Contrasena = q.contraseña, Tipo = q.id_tipo,
                               Estado = q.estado).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function BuscarPorUsuario(ByVal p_Usuario As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.usuario Where q.usuario1 = p_Usuario
                                  Select IdUsuario = q.id_usuario, Dni = q.dni_usuario, Nombre = q.nombre, Apellido = q.apellido, Direccion = q.direccion,
                                                  Usuario = q.usuario1, Contrasena = q.contraseña, Tipo = q.id_tipo,
                                                 Estado = q.estado).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class