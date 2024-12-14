<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class realizarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelUsuaio = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextControlar = New System.Windows.Forms.TextBox()
        Me.TextVuelto = New System.Windows.Forms.TextBox()
        Me.Tmontoingresado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Datadetalleventa = New System.Windows.Forms.DataGridView()
        Me.id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.Ltotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumFac = New System.Windows.Forms.TextBox()
        Me.TxtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Txtstock_min = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Textidcliente = New System.Windows.Forms.TextBox()
        Me.Lvendedor = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.buscar = New System.Windows.Forms.Button()
        Me.blimpiar = New System.Windows.Forms.Button()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.bRESTAR = New System.Windows.Forms.Button()
        Me.bSUMAR = New System.Windows.Forms.Button()
        Me.bQUITAR = New System.Windows.Forms.Button()
        Me.bAGREGAR = New System.Windows.Forms.Button()
        Me.BRegistrarNuevoCliente = New System.Windows.Forms.Button()
        Me.BbuscarCienteExistente = New System.Windows.Forms.Button()
        Me.PanelUsuaio.SuspendLayout()
        CType(Me.Datadetalleventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUsuaio
        '
        Me.PanelUsuaio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelUsuaio.Controls.Add(Me.Label3)
        Me.PanelUsuaio.Controls.Add(Me.TextControlar)
        Me.PanelUsuaio.Controls.Add(Me.TextVuelto)
        Me.PanelUsuaio.Controls.Add(Me.Tmontoingresado)
        Me.PanelUsuaio.Controls.Add(Me.Label14)
        Me.PanelUsuaio.Controls.Add(Me.Label10)
        Me.PanelUsuaio.Controls.Add(Me.Tbuscar)
        Me.PanelUsuaio.Controls.Add(Me.buscar)
        Me.PanelUsuaio.Controls.Add(Me.Label1)
        Me.PanelUsuaio.Controls.Add(Me.blimpiar)
        Me.PanelUsuaio.Controls.Add(Me.Datadetalleventa)
        Me.PanelUsuaio.Controls.Add(Me.DataListadoProducto)
        Me.PanelUsuaio.Controls.Add(Me.btnRealizar)
        Me.PanelUsuaio.Controls.Add(Me.Ltotal)
        Me.PanelUsuaio.Controls.Add(Me.txtTotal)
        Me.PanelUsuaio.Controls.Add(Me.TxtSubtotal)
        Me.PanelUsuaio.Controls.Add(Me.Label13)
        Me.PanelUsuaio.Controls.Add(Me.txtApellidos)
        Me.PanelUsuaio.Controls.Add(Me.Label12)
        Me.PanelUsuaio.Controls.Add(Me.bRESTAR)
        Me.PanelUsuaio.Controls.Add(Me.bSUMAR)
        Me.PanelUsuaio.Controls.Add(Me.txtNumFac)
        Me.PanelUsuaio.Controls.Add(Me.bQUITAR)
        Me.PanelUsuaio.Controls.Add(Me.bAGREGAR)
        Me.PanelUsuaio.Controls.Add(Me.TxtPrecioUnitario)
        Me.PanelUsuaio.Controls.Add(Me.Txtstock_min)
        Me.PanelUsuaio.Controls.Add(Me.TxtStock)
        Me.PanelUsuaio.Controls.Add(Me.TxtCantidad)
        Me.PanelUsuaio.Controls.Add(Me.Label11)
        Me.PanelUsuaio.Controls.Add(Me.Label9)
        Me.PanelUsuaio.Controls.Add(Me.Label8)
        Me.PanelUsuaio.Controls.Add(Me.Label7)
        Me.PanelUsuaio.Controls.Add(Me.TxtNombreP)
        Me.PanelUsuaio.Controls.Add(Me.TxtIdProducto)
        Me.PanelUsuaio.Controls.Add(Me.Label6)
        Me.PanelUsuaio.Controls.Add(Me.Label5)
        Me.PanelUsuaio.Controls.Add(Me.textFecha)
        Me.PanelUsuaio.Controls.Add(Me.Label2)
        Me.PanelUsuaio.Controls.Add(Me.TextUsuario)
        Me.PanelUsuaio.Controls.Add(Me.BRegistrarNuevoCliente)
        Me.PanelUsuaio.Controls.Add(Me.BbuscarCienteExistente)
        Me.PanelUsuaio.Controls.Add(Me.Textnombre)
        Me.PanelUsuaio.Controls.Add(Me.Textidcliente)
        Me.PanelUsuaio.Controls.Add(Me.Lvendedor)
        Me.PanelUsuaio.Controls.Add(Me.DateTimePicker1)
        Me.PanelUsuaio.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsuaio.MaximumSize = New System.Drawing.Size(1164, 700)
        Me.PanelUsuaio.MinimumSize = New System.Drawing.Size(1164, 700)
        Me.PanelUsuaio.Name = "PanelUsuaio"
        Me.PanelUsuaio.Size = New System.Drawing.Size(1164, 700)
        Me.PanelUsuaio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "text controlar"
        Me.Label3.Visible = False
        '
        'TextControlar
        '
        Me.TextControlar.Location = New System.Drawing.Point(563, 83)
        Me.TextControlar.Name = "TextControlar"
        Me.TextControlar.Size = New System.Drawing.Size(34, 20)
        Me.TextControlar.TabIndex = 136
        Me.TextControlar.Visible = False
        '
        'TextVuelto
        '
        Me.TextVuelto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextVuelto.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextVuelto.Location = New System.Drawing.Point(875, 643)
        Me.TextVuelto.Name = "TextVuelto"
        Me.TextVuelto.ReadOnly = True
        Me.TextVuelto.Size = New System.Drawing.Size(265, 44)
        Me.TextVuelto.TabIndex = 135
        Me.TextVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tmontoingresado
        '
        Me.Tmontoingresado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmontoingresado.Location = New System.Drawing.Point(875, 593)
        Me.Tmontoingresado.Name = "Tmontoingresado"
        Me.Tmontoingresado.Size = New System.Drawing.Size(265, 44)
        Me.Tmontoingresado.TabIndex = 134
        Me.Tmontoingresado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(801, 661)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 19)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "Cambio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(777, 602)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Abona con"
        '
        'Tbuscar
        '
        Me.Tbuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbuscar.Location = New System.Drawing.Point(12, 99)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(284, 22)
        Me.Tbuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(922, 493)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Subtotal"
        '
        'Datadetalleventa
        '
        Me.Datadetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datadetalleventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_factura, Me.cod_pro, Me.nombre, Me.cantidad, Me.Column1, Me.subtotal})
        Me.Datadetalleventa.Location = New System.Drawing.Point(12, 391)
        Me.Datadetalleventa.Name = "Datadetalleventa"
        Me.Datadetalleventa.RowHeadersVisible = False
        Me.Datadetalleventa.Size = New System.Drawing.Size(606, 238)
        Me.Datadetalleventa.TabIndex = 127
        '
        'id_factura
        '
        Me.id_factura.HeaderText = "N° factura"
        Me.id_factura.Name = "id_factura"
        Me.id_factura.ReadOnly = True
        '
        'cod_pro
        '
        Me.cod_pro.HeaderText = "Codigo Producto"
        Me.cod_pro.Name = "cod_pro"
        Me.cod_pro.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 120
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Precio por Unidad"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Width = 120
        '
        'DataListadoProducto
        '
        Me.DataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListadoProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataListadoProducto.Location = New System.Drawing.Point(12, 141)
        Me.DataListadoProducto.Name = "DataListadoProducto"
        Me.DataListadoProducto.RowHeadersVisible = False
        Me.DataListadoProducto.Size = New System.Drawing.Size(606, 225)
        Me.DataListadoProducto.TabIndex = 126
        '
        'Ltotal
        '
        Me.Ltotal.AutoSize = True
        Me.Ltotal.BackColor = System.Drawing.Color.Transparent
        Me.Ltotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltotal.Location = New System.Drawing.Point(823, 551)
        Me.Ltotal.Name = "Ltotal"
        Me.Ltotal.Size = New System.Drawing.Size(46, 19)
        Me.Ltotal.TabIndex = 124
        Me.Ltotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(875, 534)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(265, 44)
        Me.txtTotal.TabIndex = 123
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.Location = New System.Drawing.Point(1001, 485)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(139, 31)
        Me.TxtSubtotal.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(492, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 18)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "Cliente"
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtApellidos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(523, 30)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.ReadOnly = True
        Me.txtApellidos.Size = New System.Drawing.Size(150, 26)
        Me.txtApellidos.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 19)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "N° de factura"
        '
        'txtNumFac
        '
        Me.txtNumFac.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtNumFac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFac.Location = New System.Drawing.Point(7, 31)
        Me.txtNumFac.Name = "txtNumFac"
        Me.txtNumFac.ReadOnly = True
        Me.txtNumFac.Size = New System.Drawing.Size(55, 26)
        Me.txtNumFac.TabIndex = 114
        '
        'TxtPrecioUnitario
        '
        Me.TxtPrecioUnitario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtPrecioUnitario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecioUnitario.Location = New System.Drawing.Point(990, 172)
        Me.TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        Me.TxtPrecioUnitario.ReadOnly = True
        Me.TxtPrecioUnitario.Size = New System.Drawing.Size(146, 29)
        Me.TxtPrecioUnitario.TabIndex = 111
        '
        'Txtstock_min
        '
        Me.Txtstock_min.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Txtstock_min.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtstock_min.ForeColor = System.Drawing.Color.Red
        Me.Txtstock_min.Location = New System.Drawing.Point(875, 172)
        Me.Txtstock_min.Name = "Txtstock_min"
        Me.Txtstock_min.ReadOnly = True
        Me.Txtstock_min.Size = New System.Drawing.Size(109, 29)
        Me.Txtstock_min.TabIndex = 110
        '
        'TxtStock
        '
        Me.TxtStock.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtStock.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(756, 172)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(109, 29)
        Me.TxtStock.TabIndex = 109
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtCantidad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(820, 240)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(146, 29)
        Me.TxtCantidad.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(871, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 19)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Stock minimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1007, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Precio Unitario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(760, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 19)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(849, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Cantidad"
        '
        'TxtNombreP
        '
        Me.TxtNombreP.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtNombreP.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreP.Location = New System.Drawing.Point(624, 172)
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.ReadOnly = True
        Me.TxtNombreP.Size = New System.Drawing.Size(126, 29)
        Me.TxtNombreP.TabIndex = 103
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtIdProducto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdProducto.Location = New System.Drawing.Point(1120, 67)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.ReadOnly = True
        Me.TxtIdProducto.Size = New System.Drawing.Size(20, 26)
        Me.TxtIdProducto.TabIndex = 102
        Me.TxtIdProducto.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(624, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1074, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "id producto"
        Me.Label5.Visible = False
        '
        'textFecha
        '
        Me.textFecha.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.textFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textFecha.Location = New System.Drawing.Point(68, 31)
        Me.textFecha.Name = "textFecha"
        Me.textFecha.ReadOnly = True
        Me.textFecha.Size = New System.Drawing.Size(94, 26)
        Me.textFecha.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Usuario"
        '
        'TextUsuario
        '
        Me.TextUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TextUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuario.Location = New System.Drawing.Point(168, 31)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.ReadOnly = True
        Me.TextUsuario.Size = New System.Drawing.Size(101, 26)
        Me.TextUsuario.TabIndex = 95
        '
        'Textnombre
        '
        Me.Textnombre.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Textnombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnombre.Location = New System.Drawing.Point(367, 30)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.ReadOnly = True
        Me.Textnombre.Size = New System.Drawing.Size(150, 26)
        Me.Textnombre.TabIndex = 92
        '
        'Textidcliente
        '
        Me.Textidcliente.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Textidcliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textidcliente.Location = New System.Drawing.Point(1116, 106)
        Me.Textidcliente.Name = "Textidcliente"
        Me.Textidcliente.ReadOnly = True
        Me.Textidcliente.Size = New System.Drawing.Size(24, 26)
        Me.Textidcliente.TabIndex = 91
        Me.Textidcliente.Visible = False
        '
        'Lvendedor
        '
        Me.Lvendedor.AutoSize = True
        Me.Lvendedor.BackColor = System.Drawing.Color.Transparent
        Me.Lvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvendedor.Location = New System.Drawing.Point(1074, 109)
        Me.Lvendedor.Name = "Lvendedor"
        Me.Lvendedor.Size = New System.Drawing.Size(78, 18)
        Me.Lvendedor.TabIndex = 89
        Me.Lvendedor.Text = "ID cliente"
        Me.Lvendedor.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(563, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 88
        Me.DateTimePicker1.Visible = False
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 3
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscar.Location = New System.Drawing.Point(334, 87)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(194, 40)
        Me.buscar.TabIndex = 131
        Me.buscar.Text = "Buscar Producto"
        Me.buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buscar.UseVisualStyleBackColor = True
        '
        'blimpiar
        '
        Me.blimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.blimpiar.FlatAppearance.BorderSize = 3
        Me.blimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blimpiar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blimpiar.Image = Global.login.My.Resources.Resources.icons8_cancelar_30__2_
        Me.blimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.blimpiar.Location = New System.Drawing.Point(14, 639)
        Me.blimpiar.Name = "blimpiar"
        Me.blimpiar.Size = New System.Drawing.Size(219, 49)
        Me.blimpiar.TabIndex = 128
        Me.blimpiar.Text = "Cancelar "
        Me.blimpiar.UseVisualStyleBackColor = True
        '
        'btnRealizar
        '
        Me.btnRealizar.BackColor = System.Drawing.Color.Transparent
        Me.btnRealizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnRealizar.FlatAppearance.BorderSize = 3
        Me.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizar.Image = Global.login.My.Resources.Resources.icons8_de_acuerdo_30
        Me.btnRealizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizar.Location = New System.Drawing.Point(399, 635)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(219, 49)
        Me.btnRealizar.TabIndex = 125
        Me.btnRealizar.Text = "Confirmar Venta"
        Me.btnRealizar.UseVisualStyleBackColor = False
        '
        'bRESTAR
        '
        Me.bRESTAR.FlatAppearance.BorderSize = 0
        Me.bRESTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRESTAR.Image = Global.login.My.Resources.Resources.icons8_menos_30
        Me.bRESTAR.Location = New System.Drawing.Point(764, 233)
        Me.bRESTAR.Name = "bRESTAR"
        Me.bRESTAR.Size = New System.Drawing.Size(50, 47)
        Me.bRESTAR.TabIndex = 116
        Me.bRESTAR.Text = "-"
        Me.bRESTAR.UseVisualStyleBackColor = True
        '
        'bSUMAR
        '
        Me.bSUMAR.FlatAppearance.BorderSize = 0
        Me.bSUMAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSUMAR.Image = Global.login.My.Resources.Resources.icons8_más_30
        Me.bSUMAR.Location = New System.Drawing.Point(972, 233)
        Me.bSUMAR.Name = "bSUMAR"
        Me.bSUMAR.Size = New System.Drawing.Size(50, 47)
        Me.bSUMAR.TabIndex = 115
        Me.bSUMAR.Text = "*"
        Me.bSUMAR.UseVisualStyleBackColor = True
        '
        'bQUITAR
        '
        Me.bQUITAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bQUITAR.FlatAppearance.BorderSize = 3
        Me.bQUITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bQUITAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bQUITAR.Image = Global.login.My.Resources.Resources.icons8_basura_30
        Me.bQUITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bQUITAR.Location = New System.Drawing.Point(636, 315)
        Me.bQUITAR.Name = "bQUITAR"
        Me.bQUITAR.Size = New System.Drawing.Size(177, 51)
        Me.bQUITAR.TabIndex = 113
        Me.bQUITAR.Text = "Quitar"
        Me.bQUITAR.UseVisualStyleBackColor = True
        '
        'bAGREGAR
        '
        Me.bAGREGAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bAGREGAR.FlatAppearance.BorderSize = 3
        Me.bAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAGREGAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAGREGAR.Image = Global.login.My.Resources.Resources.icons8_de_acuerdo_30
        Me.bAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAGREGAR.Location = New System.Drawing.Point(963, 315)
        Me.bAGREGAR.Name = "bAGREGAR"
        Me.bAGREGAR.Size = New System.Drawing.Size(177, 51)
        Me.bAGREGAR.TabIndex = 112
        Me.bAGREGAR.Text = "Agregar"
        Me.bAGREGAR.UseVisualStyleBackColor = True
        '
        'BRegistrarNuevoCliente
        '
        Me.BRegistrarNuevoCliente.BackColor = System.Drawing.Color.Transparent
        Me.BRegistrarNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BRegistrarNuevoCliente.FlatAppearance.BorderSize = 3
        Me.BRegistrarNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarNuevoCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarNuevoCliente.Image = Global.login.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_30
        Me.BRegistrarNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BRegistrarNuevoCliente.Location = New System.Drawing.Point(933, 22)
        Me.BRegistrarNuevoCliente.Name = "BRegistrarNuevoCliente"
        Me.BRegistrarNuevoCliente.Size = New System.Drawing.Size(207, 40)
        Me.BRegistrarNuevoCliente.TabIndex = 94
        Me.BRegistrarNuevoCliente.Text = "Nuevo Cliente"
        Me.BRegistrarNuevoCliente.UseVisualStyleBackColor = False
        '
        'BbuscarCienteExistente
        '
        Me.BbuscarCienteExistente.BackColor = System.Drawing.Color.Transparent
        Me.BbuscarCienteExistente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BbuscarCienteExistente.FlatAppearance.BorderSize = 3
        Me.BbuscarCienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BbuscarCienteExistente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbuscarCienteExistente.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.BbuscarCienteExistente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BbuscarCienteExistente.Location = New System.Drawing.Point(708, 22)
        Me.BbuscarCienteExistente.Name = "BbuscarCienteExistente"
        Me.BbuscarCienteExistente.Size = New System.Drawing.Size(219, 40)
        Me.BbuscarCienteExistente.TabIndex = 93
        Me.BbuscarCienteExistente.Text = "Buscar Cliente"
        Me.BbuscarCienteExistente.UseVisualStyleBackColor = False
        '
        'realizarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1164, 700)
        Me.Controls.Add(Me.PanelUsuaio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1164, 700)
        Me.MinimumSize = New System.Drawing.Size(1164, 700)
        Me.Name = "realizarVentas"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        Me.PanelUsuaio.ResumeLayout(False)
        Me.PanelUsuaio.PerformLayout()
        CType(Me.Datadetalleventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelUsuaio As Panel
    Friend WithEvents blimpiar As Button
    Friend WithEvents Datadetalleventa As DataGridView
    Friend WithEvents DataListadoProducto As DataGridView
    Friend WithEvents btnRealizar As Button
    Friend WithEvents Ltotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents bRESTAR As Button
    Friend WithEvents bSUMAR As Button
    Friend WithEvents txtNumFac As TextBox
    Friend WithEvents bQUITAR As Button
    Friend WithEvents bAGREGAR As Button
    Friend WithEvents TxtPrecioUnitario As TextBox
    Friend WithEvents Txtstock_min As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textFecha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents BRegistrarNuevoCliente As Button
    Friend WithEvents BbuscarCienteExistente As Button
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Textidcliente As TextBox
    Friend WithEvents Lvendedor As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents TextVuelto As TextBox
    Friend WithEvents Tmontoingresado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextControlar As TextBox
    Friend WithEvents id_factura As DataGridViewTextBoxColumn
    Friend WithEvents cod_pro As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
