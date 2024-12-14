<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.DataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.Label()
        Me.ComboBoxCategorias = New System.Windows.Forms.ComboBox()
        Me.Tstock_minimo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TprecioVenta = New System.Windows.Forms.TextBox()
        Me.TprecioCompra = New System.Windows.Forms.TextBox()
        Me.Tstock = New System.Windows.Forms.TextBox()
        Me.Tdescripcion = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.TcodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Bmini)
        Me.Panel1.Controls.Add(Me.Bcerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 40)
        Me.Panel1.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_editar_30
        Me.Button2.Location = New System.Drawing.Point(12, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 80
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(53, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Editar Producto"
        '
        'Bmini
        '
        Me.Bmini.FlatAppearance.BorderSize = 0
        Me.Bmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmini.Image = Global.login.My.Resources.Resources.icons8_minimizar_361
        Me.Bmini.Location = New System.Drawing.Point(819, 0)
        Me.Bmini.Name = "Bmini"
        Me.Bmini.Size = New System.Drawing.Size(36, 36)
        Me.Bmini.TabIndex = 1
        Me.Bmini.UseVisualStyleBackColor = True
        '
        'Bcerrar
        '
        Me.Bcerrar.FlatAppearance.BorderSize = 0
        Me.Bcerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcerrar.Image = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.Bcerrar.Location = New System.Drawing.Point(861, 0)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(36, 36)
        Me.Bcerrar.TabIndex = 0
        Me.Bcerrar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cancelar.FlatAppearance.BorderSize = 3
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Image = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelar.Location = New System.Drawing.Point(421, 598)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(219, 40)
        Me.cancelar.TabIndex = 67
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bmodificar.FlatAppearance.BorderSize = 3
        Me.Bmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmodificar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmodificar.Image = Global.login.My.Resources.Resources.icons8_guardar_301
        Me.Bmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bmodificar.Location = New System.Drawing.Point(669, 598)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(219, 40)
        Me.Bmodificar.TabIndex = 66
        Me.Bmodificar.Text = "Guardar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'Tbuscar
        '
        Me.Tbuscar.Location = New System.Drawing.Point(411, 79)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 20)
        Me.Tbuscar.TabIndex = 72
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 3
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscar.Location = New System.Drawing.Point(669, 67)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(219, 40)
        Me.buscar.TabIndex = 71
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'DataListadoProducto
        '
        Me.DataListadoProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DataListadoProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataListadoProducto.ColumnHeadersHeight = 30
        Me.DataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataListadoProducto.EnableHeadersVisualStyles = False
        Me.DataListadoProducto.Location = New System.Drawing.Point(247, 127)
        Me.DataListadoProducto.Name = "DataListadoProducto"
        Me.DataListadoProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataListadoProducto.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.DataListadoProducto.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListadoProducto.Size = New System.Drawing.Size(641, 431)
        Me.DataListadoProducto.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.login.My.Resources.Resources.icons8_mantenimiento_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 69)
        Me.Button1.TabIndex = 74
        Me.Button1.UseVisualStyleBackColor = True
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.BackColor = System.Drawing.Color.Transparent
        Me.codigo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.Location = New System.Drawing.Point(12, 181)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(139, 19)
        Me.codigo.TabIndex = 90
        Me.codigo.Text = "Codigo producto"
        '
        'ComboBoxCategorias
        '
        Me.ComboBoxCategorias.FormattingEnabled = True
        Me.ComboBoxCategorias.Location = New System.Drawing.Point(12, 145)
        Me.ComboBoxCategorias.Name = "ComboBoxCategorias"
        Me.ComboBoxCategorias.Size = New System.Drawing.Size(227, 21)
        Me.ComboBoxCategorias.TabIndex = 89
        '
        'Tstock_minimo
        '
        Me.Tstock_minimo.Location = New System.Drawing.Point(12, 435)
        Me.Tstock_minimo.Name = "Tstock_minimo"
        Me.Tstock_minimo.Size = New System.Drawing.Size(228, 20)
        Me.Tstock_minimo.TabIndex = 88
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 19)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Stock Minimo"
        '
        'TprecioVenta
        '
        Me.TprecioVenta.Location = New System.Drawing.Point(13, 495)
        Me.TprecioVenta.Name = "TprecioVenta"
        Me.TprecioVenta.Size = New System.Drawing.Size(228, 20)
        Me.TprecioVenta.TabIndex = 86
        '
        'TprecioCompra
        '
        Me.TprecioCompra.Location = New System.Drawing.Point(11, 567)
        Me.TprecioCompra.Name = "TprecioCompra"
        Me.TprecioCompra.Size = New System.Drawing.Size(228, 20)
        Me.TprecioCompra.TabIndex = 85
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(12, 377)
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(228, 20)
        Me.Tstock.TabIndex = 84
        '
        'Tdescripcion
        '
        Me.Tdescripcion.Location = New System.Drawing.Point(12, 316)
        Me.Tdescripcion.Multiline = True
        Me.Tdescripcion.Name = "Tdescripcion"
        Me.Tdescripcion.Size = New System.Drawing.Size(228, 20)
        Me.Tdescripcion.TabIndex = 83
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(12, 261)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(228, 20)
        Me.Tnombre.TabIndex = 82
        '
        'TcodigoProducto
        '
        Me.TcodigoProducto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TcodigoProducto.Location = New System.Drawing.Point(12, 202)
        Me.TcodigoProducto.Name = "TcodigoProducto"
        Me.TcodigoProducto.ReadOnly = True
        Me.TcodigoProducto.Size = New System.Drawing.Size(227, 20)
        Me.TcodigoProducto.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Precio de lista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 19)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Precio de compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Categoria"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 645)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 5)
        Me.Panel2.TabIndex = 91
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(895, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 605)
        Me.Panel4.TabIndex = 92
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 605)
        Me.Panel3.TabIndex = 93
        '
        'EditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.ComboBoxCategorias)
        Me.Controls.Add(Me.Tstock_minimo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TprecioVenta)
        Me.Controls.Add(Me.TprecioCompra)
        Me.Controls.Add(Me.Tstock)
        Me.Controls.Add(Me.Tdescripcion)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.TcodigoProducto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataListadoProducto)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(900, 650)
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "EditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents DataListadoProducto As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents codigo As Label
    Friend WithEvents ComboBoxCategorias As ComboBox
    Friend WithEvents Tstock_minimo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TprecioVenta As TextBox
    Friend WithEvents TprecioCompra As TextBox
    Friend WithEvents Tstock As TextBox
    Friend WithEvents Tdescripcion As TextBox
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents TcodigoProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
