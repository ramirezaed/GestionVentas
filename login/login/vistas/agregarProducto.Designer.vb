<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregarProducto
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.BackColor = System.Drawing.Color.Transparent
        Me.codigo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigo.Location = New System.Drawing.Point(228, 140)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(139, 19)
        Me.codigo.TabIndex = 61
        Me.codigo.Text = "Codigo producto"
        '
        'ComboBoxCategorias
        '
        Me.ComboBoxCategorias.FormattingEnabled = True
        Me.ComboBoxCategorias.Location = New System.Drawing.Point(231, 107)
        Me.ComboBoxCategorias.Name = "ComboBoxCategorias"
        Me.ComboBoxCategorias.Size = New System.Drawing.Size(241, 21)
        Me.ComboBoxCategorias.TabIndex = 60
        '
        'Tstock_minimo
        '
        Me.Tstock_minimo.Location = New System.Drawing.Point(498, 223)
        Me.Tstock_minimo.Name = "Tstock_minimo"
        Me.Tstock_minimo.Size = New System.Drawing.Size(241, 20)
        Me.Tstock_minimo.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(494, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 19)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Stock Minimo"
        '
        'TprecioVenta
        '
        Me.TprecioVenta.Location = New System.Drawing.Point(498, 283)
        Me.TprecioVenta.Name = "TprecioVenta"
        Me.TprecioVenta.Size = New System.Drawing.Size(241, 20)
        Me.TprecioVenta.TabIndex = 51
        '
        'TprecioCompra
        '
        Me.TprecioCompra.Location = New System.Drawing.Point(231, 282)
        Me.TprecioCompra.Name = "TprecioCompra"
        Me.TprecioCompra.Size = New System.Drawing.Size(241, 20)
        Me.TprecioCompra.TabIndex = 50
        '
        'Tstock
        '
        Me.Tstock.Location = New System.Drawing.Point(231, 222)
        Me.Tstock.Name = "Tstock"
        Me.Tstock.Size = New System.Drawing.Size(241, 20)
        Me.Tstock.TabIndex = 49
        '
        'Tdescripcion
        '
        Me.Tdescripcion.Location = New System.Drawing.Point(498, 162)
        Me.Tdescripcion.Multiline = True
        Me.Tdescripcion.Name = "Tdescripcion"
        Me.Tdescripcion.Size = New System.Drawing.Size(241, 20)
        Me.Tdescripcion.TabIndex = 48
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(498, 107)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(241, 20)
        Me.Tnombre.TabIndex = 47
        '
        'TcodigoProducto
        '
        Me.TcodigoProducto.Location = New System.Drawing.Point(231, 161)
        Me.TcodigoProducto.Name = "TcodigoProducto"
        Me.TcodigoProducto.Size = New System.Drawing.Size(241, 20)
        Me.TcodigoProducto.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(494, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Precio de lista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Precio de compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(494, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-72, -43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 31)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Datos de poducto"
        '
        'cancelar
        '
        Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cancelar.FlatAppearance.BorderSize = 3
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Image = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelar.Location = New System.Drawing.Point(253, 396)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(219, 40)
        Me.cancelar.TabIndex = 78
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bagregar.FlatAppearance.BorderSize = 3
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bagregar.Image = Global.login.My.Resources.Resources.icons8_guardar_301
        Me.Bagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bagregar.Location = New System.Drawing.Point(520, 396)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(219, 40)
        Me.Bagregar.TabIndex = 77
        Me.Bagregar.Text = "Guardar"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.login.My.Resources.Resources.icons8_mantenimiento_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 200)
        Me.Button1.TabIndex = 76
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 461)
        Me.Panel3.TabIndex = 79
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 5)
        Me.Panel2.TabIndex = 72
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(750, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 461)
        Me.Panel4.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(5, 456)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 5)
        Me.Panel1.TabIndex = 81
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Bmini)
        Me.Panel5.Controls.Add(Me.Bcerrar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(5, 0)
        Me.Panel5.MaximumSize = New System.Drawing.Size(751, 40)
        Me.Panel5.MinimumSize = New System.Drawing.Size(751, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(751, 40)
        Me.Panel5.TabIndex = 82
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_herramientas_301
        Me.Button2.Location = New System.Drawing.Point(21, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 76
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(62, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 22)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Agregar Producto"
        '
        'Bmini
        '
        Me.Bmini.FlatAppearance.BorderSize = 0
        Me.Bmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmini.Image = Global.login.My.Resources.Resources.icons8_minimizar_361
        Me.Bmini.Location = New System.Drawing.Point(670, 0)
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
        Me.Bcerrar.Location = New System.Drawing.Point(712, 0)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(36, 36)
        Me.Bcerrar.TabIndex = 0
        Me.Bcerrar.UseVisualStyleBackColor = True
        '
        'agregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(755, 461)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(755, 461)
        Me.MinimumSize = New System.Drawing.Size(751, 461)
        Me.Name = "agregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarProducto"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cancelar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
End Class
