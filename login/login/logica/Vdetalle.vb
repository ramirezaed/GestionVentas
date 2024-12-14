Public Class Vdetalle
    Private id_venta As Integer
    Private codigo_pro As Integer
    Private cantidad As Integer
    Private precio_subtotal As Double

#Region "Constructores"
    Public Sub New(ByVal p_id_venta As Integer, ByVal p_codigo_pro As Integer, ByVal p_cantidad As Integer, ByVal p_codigo_venta As Integer, ByVal p_precio_subtotal As Integer)
        setId_venta(p_id_venta)
        setCodigoPro(p_codigo_pro)
        setCantidad(p_cantidad)
        setPrecioSubtotal(p_precio_subtotal)
    End Sub

    Public Sub New()

    End Sub
#End Region

#Region "GET / SET"
    Public Function getIdVenta()
        Return id_venta
    End Function

    Public Function getCodigoPro()
        Return codigo_pro
    End Function

    Public Function getCantidad()
        Return cantidad
    End Function

    Public Function getPrecioSubtotal()
        Return precio_subtotal
    End Function

    Sub setId_venta(ByVal p_id_venta As Integer)
        id_venta = p_id_venta
    End Sub

    Sub setCodigoPro(ByVal p_codigo_pro As Integer)
        codigo_pro = p_codigo_pro
    End Sub

    Sub setCantidad(ByVal p_cantidad As Integer)
        cantidad = p_cantidad
    End Sub

    Sub setPrecioSubtotal(ByVal p_precio_subtotal)
        precio_subtotal = p_precio_subtotal
    End Sub

#End Region

    Public Function MostrarDetalleVenta(ByVal DataGrid As DataGridView)
        Try
            Using mostrarDetalle As New FERRETERIAEntities1
                Dim verDetalle = (From q In mostrarDetalle.detalle
                                  Select Numero_Detalle = q.id_venta, Numero_Articulo = q.id_producto, Cantidad = q.cantidad, Subtotal = q.precio_unitario)
                DataGrid.DataSource = mostrarDetalle
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ' ByVal p_codigo_venta As Integer, ByVal p_codigo_producto As Integer, ByVal p_cantidad As Integer, ByVal p_precio_subtotal As Integer)
    Public Function AdDetalle(ByVal p_codigo_venta As Integer, ByVal p_codigo_prod As Integer, ByVal p_cantidad As Integer, ByVal p_precio_subtotal As Integer)
        Try
            Using Add As New FERRETERIAEntities1
                Dim addDet As New detalle
                With addDet

                    .cantidad = p_cantidad
                    .id_venta = p_codigo_venta
                    .id_producto = p_codigo_prod
                    .precio_unitario = p_precio_subtotal

                End With

                Add.detalle.Add(addDet)
                Add.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Enlace(ByVal p_id_venta As Integer)
        Try
            Using enlazar As New FERRETERIAEntities1
                Dim link = (From q In enlazar.detalle Select q Where
                             p_id_venta = q.id_venta).First()
                setId_venta(link.id_venta)
                setCodigoPro(link.id_producto)
                setCantidad(link.cantidad)
                setPrecioSubtotal(link.precio_unitario)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
