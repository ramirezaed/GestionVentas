
Public Class Vventa

    Private id_venta As Integer
    Private id_cliente As Integer
    Private fecha_ven As String
    Private precio_total As Double
    Private id_usuario As Integer

    Public Sub New(ByVal p_id_venta As Integer, ByVal p_id_cliente As Integer, ByVal p_fecha_ven As String, ByVal p_precio_total As Double, ByVal p_id_usuario As Integer)
        SetCodigo(p_id_venta)
        SetCliente(p_id_cliente)
        SetFecha(p_fecha_ven)
        SetPrecio(p_precio_total)
        SetEncargado(p_id_usuario)
    End Sub
    Public Sub New()
End Sub

    Public Function Getid_venta()
        Return id_venta
    End Function

    Public Function Getid_Cliente()
        Return id_cliente
    End Function
    Public Function GetFecha()
        Return fecha_ven
    End Function
    Public Function GetPrecio_total()
        Return precio_total
    End Function

    Public Function Getid_usuario()
        Return id_usuario
    End Function


    Private Sub SetCodigo(ByVal p_id_venta As Integer)
        id_venta = p_id_venta
    End Sub
    Private Sub SetCliente(ByVal p_id_cliente As Integer)
        id_cliente = p_id_cliente
    End Sub

    Private Sub SetFecha(ByVal p_fecha_Ven As String)
        fecha_ven = p_fecha_Ven
    End Sub

    Private Sub SetEncargado(ByVal p_id_usuario As Integer)
        id_usuario = p_id_usuario
    End Sub
    Private Sub SetPrecio(ByVal p_precio_total As Double)
        precio_total = p_precio_total
    End Sub


    Public Function EnlaceDatos(ByVal p_id_venta As String)
        Try
            Using db As New FERRETERIAEntities1
                Dim datos = (From q In db.venta
                             Select q Where p_id_venta = q.id_venta).First()
                SetCodigo(datos.id_venta)
                SetCliente(datos.id_cliente)
                SetFecha(datos.fecha_ven)
                SetPrecio(datos.precio_total)
                SetEncargado(datos.id_usuario)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function AdFactura(ByVal p_idventa As Integer, ByVal p_id_cliente As Integer,
                              ByVal p_fecha_ven As String, ByVal p_precio_total As Double, ByVal p_id_usuario As Integer)
        Try
            Using Add As New FERRETERIAEntities1
                Dim addFac As New venta

                With addFac
                    .id_venta = p_idventa
                    .id_cliente = p_id_cliente
                    .fecha_ven = p_fecha_ven
                    .precio_total = p_precio_total
                    .id_usuario = p_id_usuario

                End With


                Add.venta.Add(addFac)
                Add.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function MostrarFactura(ByVal grid As DataGridView)
    Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.venta
                                  Select Factura = q.id_venta, Cliente = q.id_cliente, Fecha = q.fecha_ven, Precio = q.precio_total, Vendedor = q.id_usuario).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
    Catch ex As Exception
        Return False
    End Try
End Function

Public Function MostrarFacturaV(ByVal grid As DataGridView, p_nombre As String)


    Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.venta Where q.id_usuario = (p_nombre)
                                  Select Factura = q.id_venta, Cliente = q.id_cliente, Fecha = q.fecha_ven, Precio = q.precio_total, Vendedor = q.id_usuario).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
    Catch ex As Exception
        Return False
    End Try
End Function

Public Function MostrarUltimaFactura() As Integer
    Try
            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.venta Select q).ToList.Last
                If IsNothing(objMostrar) Then
                    Return 1
                Else
                    Return objMostrar.id_venta

                End If
            End Using
            Return True
    Catch ex As Exception
        Return False
    End Try
End Function


End Class
