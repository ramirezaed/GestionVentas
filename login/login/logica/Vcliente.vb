

Imports System
Imports System.Linq
Public Class Vcliente

    Private id_cliente As Integer
    Private nombre, apellido, domicilio, email As String
    Private dni_cliente, telefono As Integer
    Private fecha_nac As String
    Private estado As String

#Region "CONSTRUCTORES"
    Public Sub New(ByVal p_dni)
        setDni(p_dni)
    End Sub

    Public Sub New()


        setNombre("")
        setApellido("")
        setDireccion("")
        setTelefono(0)
        setDni(0)
        setEstado("")
        setFechaNac("")
        setEmail("")



    End Sub
    Public Sub New(ByVal p_nombre As String, ByVal p_apellido As String, ByVal p_direccion As String, ByVal p_telefono As Integer, ByVal p_dni_cliente As Integer,
                     ByVal p_estado As String, ByVal p_fecha_nac As String, ByVal p_email As String)



        setNombre(p_nombre)
        setApellido(p_apellido)
        setDireccion(p_direccion)
        setTelefono(p_telefono)
        setDni(p_dni_cliente)
        setEstado(p_estado)
        setFechaNac(p_fecha_nac)
        setEmail(p_email)



    End Sub

#End Region

#Region "GET"
    Public Function getId_Cliente()
        Return id_cliente
    End Function


    Public Function getNombre()
        Return nombre
    End Function

    Public Function getApellido()
        Return apellido
    End Function
    Public Function getDireccion()
        Return domicilio
    End Function

    Public Function getTelefono()
        Return telefono
    End Function

    Public Function getDni()
        Return dni_cliente
    End Function

    Public Function getEstado()
        Return estado
    End Function

    Public Function getFecha_Nac()
        Return fecha_nac
    End Function


    Public Function getEmail()
        Return email
    End Function







#End Region

#Region "SET"

    Sub setIdCliente(ByVal p_idcliente As Integer)
        id_cliente = p_idcliente
    End Sub



    Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Sub setApellido(ByVal p_apellido As String)
        apellido = p_apellido
    End Sub

    Sub setDireccion(ByVal p_domicilio As String)
        domicilio = p_domicilio
    End Sub


    Sub setTelefono(ByVal p_telefono As Int64)
        telefono = p_telefono
    End Sub
    Sub setDni(ByVal p_dni_cliente As Int64)
        dni_cliente = p_dni_cliente
    End Sub


    Sub setEstado(ByVal p_estado As String)
        estado = p_estado
    End Sub

    Sub setFechaNac(ByVal p_fecha_nac As String)
        fecha_nac = p_fecha_nac
    End Sub



    Sub setEmail(ByVal p_email As String)
        email = p_email
    End Sub


#End Region


    Public Function MostrarHabilitados(ByVal grid As DataGridView)
        Try

            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.cliente Where q.estado = True
                                  Select id_cliente = q.id_cliente, dni = q.dni_cliente, nombre = q.nombre, apellido = q.apellido, telefono = q.telefono, email = q.email,
                                      direccion = q.domicilio, FechaNac = q.fecha_nac, estado = q.estado).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '   Public Function MostrarClientes(ByVal grid As DataGridView)
    '  Try

    'Using Mostrar As New FERRETERIAEntities1
    'Dim objMostrar = (From q In Mostrar.cliente 'id_cliente = q.id_cliente, 
    'Select Case Num = q.id_cliente, nombre = q.nombre, apellido = q.apellido, dni = q.dni_cliente, fechaNacimiento = q.fecha_nac, email = q.email, direccion = q.domicilio, telefono = q.telefono, estado = q.estado).ToList

    '           grid.DataSource = objMostrar
    'End Using
    'Return True
    'Catch ex As Exception
    'Return False
    'End Try
    'End Function


    ' diferente a 23 porq es el cliente por defecto que no quiero eliminar, lo utilizo para
    'la venta sin datos de cliente
    Public Function MostrarClientes(ByVal grid As DataGridView)
        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.cliente
                                  Where q.id_cliente <> 23
                                  Select Num = q.id_cliente, nombre = q.nombre, apellido = q.apellido, dni = q.dni_cliente, fechaNacimiento = q.fecha_nac, email = q.email, direccion = q.domicilio, telefono = q.telefono, estado = q.estado).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function AgregarCliente(ByVal p_nombre As String, ByVal p_apellido As String, ByVal p_dni_cliente As Integer, ByVal p_email As String, ByVal p_domicilio As String, ByVal p_fecha_nac As String, ByVal p_telefono As Integer)



        Dim respuesta As MsgBoxResult = MsgBox("¿Estás seguro de agregar un nuevo cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nuevo Cliente")

        ' Verificar la respuesta del usuario
        If respuesta = MsgBoxResult.Yes Then
            Try
                Using AgregarCl As New FERRETERIAEntities1
                    Dim Datos As New cliente
                    With Datos
                        .nombre = p_nombre
                        .apellido = p_apellido
                        .dni_cliente = p_dni_cliente
                        .email = p_email
                        .domicilio = p_domicilio
                        .fecha_nac = p_fecha_nac
                        .telefono = p_telefono
                        .estado = True
                    End With
                    AgregarCl.cliente.Add(Datos)
                    AgregarCl.SaveChanges()
                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
        Else
            ' El usuario no está seguro, por lo que no se agrega el cliente
            Return False
        End If
    End Function

    Public Function ModificarCLiente(ByVal p_nombre As String,
                                     ByVal p_apellido As String,
                                     ByVal p_dni_cliente As Integer,
                                     ByVal p_fecha As String,
                                     ByVal p_email As String,
                                     ByVal p_domicilio As String,
                                     ByVal p_telefono As Integer)


        Try
            Using ctx As New FERRETERIAEntities1
                Dim cli = (From q In ctx.cliente Where (p_dni_cliente = q.dni_cliente) Select q).First
                With cli
                    .nombre = p_nombre
                    .apellido = p_apellido
                    .dni_cliente = p_dni_cliente
                    .fecha_nac = p_fecha
                    .email = p_email
                    .domicilio = p_domicilio
                    .telefono = p_telefono

                    ctx.SaveChanges()

                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Function EnlaceCliente(ByVal p_dni_cliente As Integer)
        Try
            Using EnlazarCl As New FERRETERIAEntities1
                Dim enlaceCl = (From q In EnlazarCl.cliente Select q Where (q.dni_cliente = p_dni_cliente)).First
                setIdCliente(enlaceCl.id_cliente)
                setDni(enlaceCl.dni_cliente)
                setNombre(enlaceCl.nombre)
                setApellido(enlaceCl.apellido)
                setTelefono(enlaceCl.telefono)
                setEmail(enlaceCl.email)

                setDireccion(enlaceCl.domicilio)
                setFechaNac(enlaceCl.fecha_nac)
                setEstado(enlaceCl.estado)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function VerificarCliente(ByVal p_dni_cliente As Int64)
        Try
            Using db As New FERRETERIAEntities1
                Dim verif = (From q In db.cliente
                             Select q Where (q.dni_cliente = p_dni_cliente)).First()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Shared Function MostrarInfoCliente(id As Int64) As cliente
        Using ctx As New FERRETERIAEntities1

            Dim cli = (From e In ctx.cliente
                       Where e.id_cliente = id
                       Select e).SingleOrDefault
            Return cli
        End Using




    End Function

    Public Function desactivarCliente(ByVal p_id_Cliente As Integer)
        Try
            Using User As New FERRETERIAEntities1
                Dim modif = (From q In User.cliente Where q.id_cliente = p_id_Cliente Select q).First

                If modif Is Nothing Then
                    MessageBox.Show("cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If modif.estado = False Then
                    MessageBox.Show("El cliente ya se encuentra deshabilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea dar de baja al cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Baja de usuario")

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
            MessageBox.Show("Error al desactivar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ActivarCliente(ByVal p_id_Cliente As Integer)
        Try
            Using User As New FERRETERIAEntities1
                Dim modif = (From q In User.cliente Where q.id_cliente = p_id_Cliente Select q).First

                If modif Is Nothing Then
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If modif.estado = True Then
                    MessageBox.Show("El Cliente ya está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea habilitar al cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Habilitar usuario")

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
            MessageBox.Show("Error al habilitar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function




    Public Function BuscarPorDni(ByVal p_dni As Integer, ByVal grid As DataGridView)
        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.cliente Where p_dni = q.dni_cliente
                                  Select idcliente = q.id_cliente, dni = q.dni_cliente, nombre = q.nombre, apellido = q.apellido, estado = q.estado, telefono = q.telefono, email = q.email,
                                      direccion = q.domicilio, FechaNac = q.fecha_nac).ToList

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

    Public Function BuscarCliente(ByVal p_nombre As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.cliente Where ((q.nombre = p_nombre) Or (q.apellido = p_nombre))
                                  Select id_cliente = q.id_cliente, dni = q.dni_cliente, nombre = q.nombre, apellido = q.apellido, estado = q.estado, telefono = q.telefono, email = q.email,
                                      direccion = q.domicilio, FechaNac = q.fecha_nac).ToList

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