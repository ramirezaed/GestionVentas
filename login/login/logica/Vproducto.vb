Imports System
Imports System.Linq

Public Class Vproducto
    Private id_producto, codigo_pro, categoria As Integer
    Private nombre, descripcion, imagen As String
    Private precio_compra, precio_venta As Double
    Private stock As Integer
    Private stock_minimo As Integer
    Private marca As String
    Private estado As Boolean


#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_Categoria As Int32, ByVal p_Codigo_pro As Integer, ByVal p_id_usuario As Integer, ByVal p_nombre As String,
                   ByVal p_descripcion As String, ByVal p_precio_compra As Double,
                   ByVal p_precio_venta As Double,
                   ByVal p_stock_minimo As Integer, ByVal p_stock As Integer)
        setid_producto(p_id_usuario)
        SetCategoria(p_Categoria)
        SetNombre(p_nombre)
        SetDescripcion(p_descripcion)
        SetPrecio_compra(p_precio_compra)
        SetPrecio_venta(p_precio_venta)
        setCodigo_pro(p_Codigo_pro)
        SetStock(p_stock)
        SetStock_minimo(p_stock_minimo)
        SetEstado(True)
    End Sub

    Public Sub New(ByVal p_nombre As String)
        SetNombre(p_nombre)

    End Sub
#End Region

#Region "Get/Set"

#Region "Get"
    Public Function Getid_producto()
        Return id_producto
    End Function
    Public Function GetCodigo_pro()
        Return codigo_pro
    End Function
    Public Function GetNombre()
        Return nombre
    End Function

    Public Function GetDescripcion()
        Return descripcion
    End Function

    Public Function GetPrecio_compra()
        Return precio_compra
    End Function

    Public Function GetPrecio_venta()
        Return precio_venta
    End Function

    Public Function GetImagen()
        Return imagen
    End Function

    Public Function GetStock()
        Return stock
    End Function

    Public Function GetStock_minimo()
        Return stock_minimo
    End Function

    Public Function GetEstado()
        Return estado
    End Function

    Public Function getCategoria()
        Return categoria
    End Function

#End Region
#Region "Set"

    Private Sub setid_producto(ByVal p_id_producto)
        id_producto = p_id_producto
    End Sub
    Private Sub setCodigo_pro(ByVal p_Codigo_pro)
        codigo_pro = p_Codigo_pro
    End Sub

    Private Sub SetNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Private Sub SetDescripcion(ByVal p_descripcion As String)
        descripcion = p_descripcion
    End Sub

    Private Sub SetPrecio_compra(ByVal p_precio_compra As Double)
        precio_compra = p_precio_compra
    End Sub

    Private Sub SetPrecio_venta(ByVal p_precio_venta As Double)
        precio_venta = p_precio_venta
    End Sub


    Private Sub SetStock(ByVal p_stock As Integer)
        stock = p_stock
    End Sub


    Private Sub SetStock_minimo(ByVal p_stock_minimo As Integer)
        stock_minimo = p_stock_minimo
    End Sub

    Private Sub SetCategoria(ByVal p_Categoria As Int32)
        categoria = p_Categoria
    End Sub

    Private Sub SetEstado(ByVal p_estado As String)
        estado = p_estado
    End Sub
#End Region


#End Region

#Region "Procedimientos"

    Public Function Enlace(ByVal p_nombre As String)
        Try
            Using enlazar As New FERRETERIAEntities1
                Dim link = (From q In enlazar.producto
                            Select q Where p_nombre = q.nombre).First()
                setid_producto(link.id_producto)

                SetCategoria(link.id_categoria)
                SetNombre(link.nombre)
                SetDescripcion(link.descripcion)
                SetPrecio_compra(link.precio_compra)
                SetPrecio_venta(link.precio_venta)
                SetStock_minimo(link.stock_minimo)
                SetStock(link.stock)
                SetEstado(link.estado)
                setCodigo_pro(link.codigo_pro)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarHabilitados(ByVal grid As DataGridView)
        Try

            Using Mostrar As New FERRETERIAEntities1
                Dim objMostrar = (From q In Mostrar.producto Where q.estado = True
                                  Join c In Mostrar.categoria On q.id_categoria Equals c.id_categoria
                                  Select Num = q.id_producto,
                                      Codigo = q.codigo_pro, Categoria = c.descripcion, Nombre = q.nombre, Descripcion = q.descripcion, Stock = q.stock, stockMinimo = q.stock_minimo, PrecioCompra = q.precio_compra, PrecioVenta = q.precio_venta, estado = q.estado).ToList

                grid.DataSource = objMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Sub MostrarProductos(ByVal grid As DataGridView)

        Using Mostrar As New FERRETERIAEntities1
            Dim objMostrar = (From q In Mostrar.producto
                              Join c In Mostrar.categoria On q.id_categoria Equals c.id_categoria
                              Select
                                  Num = q.id_producto,
                                  Codigo = q.codigo_pro,
                                  Categoria = c.descripcion,
                                  Nombre = q.nombre,
                                  Descripcion = q.descripcion,
                                  Stock = q.stock,
                                  stock_minimo = q.stock_minimo,
                                  PrecioCompra = q.precio_compra,
                                  PrecioVenta = q.precio_venta,
                                  estado = q.estado).ToList

            grid.DataSource = objMostrar
        End Using

    End Sub

    Public Function ModificarProductos(ByVal p_id_categoria As Integer, ByVal p_codigo_pro As Integer, ByVal p_nombre As String, ByVal p_descripcion As String, ByVal p_stock As Integer, ByVal p_stock_minimo As Integer, ByVal p_precio_compra As Double, ByVal p_precio_venta As Double)
        Try
            Using modificarPr As New FERRETERIAEntities1
                Dim cambiar = (From q In modificarPr.producto Where (p_codigo_pro = q.codigo_pro) Select q).First
                With cambiar
                    .id_categoria = p_id_categoria
                    .nombre = p_nombre
                    .descripcion = p_descripcion
                    .stock = p_stock
                    .stock_minimo = p_stock_minimo
                    .precio_compra = p_precio_compra
                    .precio_venta = p_precio_venta
                    modificarPr.SaveChanges()

                End With
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Private Function p_stock_minimo() As Integer?
        Throw New NotImplementedException()
    End Function

    Public Function Verificar(ByVal p_nombre As String)
        Try
            Using verif As New FERRETERIAEntities1
                Dim CodigoVerificacion = (From q In verif.producto Where q.nombre = p_nombre
                                          Select q).First
            End Using
        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function

    Public Function AgregarProducto(ByVal p_categoria As Integer, ByVal p_codigo_pro As Integer, ByVal p_nombre As String, ByVal p_descripcion As String,
                                    ByVal p_precio_compra As Double, ByVal p_precio_venta As Double, ByVal p_stock As Integer, ByVal p_stock_minimo As Integer)

        Dim respuesta As MsgBoxResult = MsgBox("seguro desea agregar un nuevo producto?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Nuevo Producto")

        ' Verificar la respuesta del usuario
        If respuesta = MsgBoxResult.Yes Then
            Try
                Using base As New FERRETERIAEntities1
                    Dim agregarProd As New producto
                    With agregarProd
                        .id_categoria = p_categoria
                        .codigo_pro = p_codigo_pro
                        .nombre = p_nombre
                        .descripcion = p_descripcion
                        .precio_compra = p_precio_compra
                        .precio_venta = p_precio_venta

                        .stock = p_stock
                        .stock_minimo = p_stock_minimo
                        .estado = True
                    End With
                    base.producto.Add(agregarProd)
                    base.SaveChanges()
                    Return True
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Else

            Return False
        End If
    End Function

    Shared ctx As New FERRETERIAEntities1
    Shared Sub CargarComboBox(cbo As ComboBox)
        Dim datos = (From s In ctx.categoria
                     Select s).ToList
        cbo.DataSource = datos
        cbo.DisplayMember = "Descripcion"
        cbo.ValueMember = "idCategoria"
    End Sub

    Public Function BajaProductos(ByVal p_idproducto As Integer) As Boolean
        Try
            Using modificarPr As New FERRETERIAEntities1
                Dim producto = (From q In modificarPr.producto Where (p_idproducto = q.id_producto) Select q).FirstOrDefault()

                If producto Is Nothing Then
                    MessageBox.Show("producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If producto.estado = False Then
                    MessageBox.Show("El producto ya se encuentra deshabilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea dar de baja el producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Baja de usuario")

                If respuesta = MsgBoxResult.No Then
                    Return False ' No hacer nada si el usuario selecciona "No"
                End If

                ' Desactivar al producto
                producto.estado = False
                modificarPr.SaveChanges()

                MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al desactivar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function AltaProductos(ByVal p_idproducto As Integer) As Boolean
        Try
            Using modificarPr As New FERRETERIAEntities1
                Dim cambiar = (From q In modificarPr.producto Where (p_idproducto = q.id_producto) Select q).First
                If cambiar Is Nothing Then
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If cambiar.estado = True Then
                    MessageBox.Show("El producto ya está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If

                Dim respuesta As MsgBoxResult = MsgBox("¿Seguro desea habilitar al producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Habilitar usuario")

                If respuesta = MsgBoxResult.No Then
                    Return False ' No hacer nada si el usuario selecciona "No"
                End If

                ' Habilitar al producto
                cambiar.estado = True
                modificarPr.SaveChanges()

                MessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al habilitar el proudcto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Public Function descontarStock(ByVal p_codigo_pro As Integer, ByVal cantidad As Integer)
        Dim resta As Integer
        Try
            Using descontar As New FERRETERIAEntities1
                Dim descont = (From q In descontar.producto Where (p_codigo_pro = q.id_producto) Select q).First()
                resta = descont.stock - cantidad
                descont.stock = resta
                descontar.SaveChanges()

            End Using
        Catch ex As Exception
            Return resta
        End Try
        Return False
    End Function

    Public Function devolverStock(ByVal p_codigo_pro As Integer, ByVal cantidad As Integer)
        Dim suma As Integer
        Try
            Using devolver As New FERRETERIAEntities1
                Dim devol = (From q In devolver.producto Where (p_codigo_pro = q.id_producto) Select q).First()
                suma = devol.stock + cantidad
                devol.stock = suma
                devolver.SaveChanges()
            End Using
        Catch ex As Exception
            Return suma
        End Try
        Return false
    End Function








#End Region
End Class