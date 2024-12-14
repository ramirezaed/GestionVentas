<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gerente
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
        Me.BcerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Textusuario = New System.Windows.Forms.TextBox()
        Me.PanelUsuaio = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.bprodPorCodigo = New System.Windows.Forms.Button()
        Me.Bproductos = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Bprod_vendidos = New System.Windows.Forms.Button()
        Me.ventaEmpleado = New System.Windows.Forms.Button()
        Me.BventasPorFecha = New System.Windows.Forms.Button()
        Me.BreporteStockProductos = New System.Windows.Forms.Button()
        Me.BreportUsuarios = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelUsuaio.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BcerrarSesion
        '
        Me.BcerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BcerrarSesion.FlatAppearance.BorderSize = 0
        Me.BcerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.BcerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BcerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BcerrarSesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BcerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BcerrarSesion.Location = New System.Drawing.Point(0, 657)
        Me.BcerrarSesion.Name = "BcerrarSesion"
        Me.BcerrarSesion.Size = New System.Drawing.Size(219, 40)
        Me.BcerrarSesion.TabIndex = 4
        Me.BcerrarSesion.Text = "Cerrar sesion"
        Me.BcerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bprodPorCodigo)
        Me.Panel1.Controls.Add(Me.Bproductos)
        Me.Panel1.Controls.Add(Me.Textusuario)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BcerrarSesion)
        Me.Panel1.Controls.Add(Me.Bprod_vendidos)
        Me.Panel1.Controls.Add(Me.ventaEmpleado)
        Me.Panel1.Controls.Add(Me.BventasPorFecha)
        Me.Panel1.Controls.Add(Me.BreporteStockProductos)
        Me.Panel1.Controls.Add(Me.BreportUsuarios)
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 700)
        Me.Panel1.TabIndex = 7
        '
        'Textusuario
        '
        Me.Textusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Textusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textusuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textusuario.ForeColor = System.Drawing.Color.Aquamarine
        Me.Textusuario.Location = New System.Drawing.Point(0, 614)
        Me.Textusuario.Name = "Textusuario"
        Me.Textusuario.ReadOnly = True
        Me.Textusuario.Size = New System.Drawing.Size(219, 24)
        Me.Textusuario.TabIndex = 11
        Me.Textusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelUsuaio
        '
        Me.PanelUsuaio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelUsuaio.Controls.Add(Me.Panel4)
        Me.PanelUsuaio.Location = New System.Drawing.Point(219, 40)
        Me.PanelUsuaio.MaximumSize = New System.Drawing.Size(1145, 695)
        Me.PanelUsuaio.MinimumSize = New System.Drawing.Size(1145, 695)
        Me.PanelUsuaio.Name = "PanelUsuaio"
        Me.PanelUsuaio.Size = New System.Drawing.Size(1145, 695)
        Me.PanelUsuaio.TabIndex = 71
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1140, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 695)
        Me.Panel4.TabIndex = 70
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Bmini)
        Me.Panel3.Controls.Add(Me.Bcerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1364, 40)
        Me.Panel3.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(67, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Bosch Tools"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.login.My.Resources.Resources.icons8_bosch_a_german_multinational_engineering_and_technology_company_30
        Me.Button5.Location = New System.Drawing.Point(12, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 35)
        Me.Button5.TabIndex = 72
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Bmini
        '
        Me.Bmini.FlatAppearance.BorderSize = 0
        Me.Bmini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Bmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmini.Image = Global.login.My.Resources.Resources.icons8_minimizar_361
        Me.Bmini.Location = New System.Drawing.Point(1283, 2)
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
        Me.Bcerrar.Location = New System.Drawing.Point(1325, 3)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(36, 36)
        Me.Bcerrar.TabIndex = 0
        Me.Bcerrar.UseVisualStyleBackColor = True
        '
        'bprodPorCodigo
        '
        Me.bprodPorCodigo.BackColor = System.Drawing.Color.Transparent
        Me.bprodPorCodigo.FlatAppearance.BorderSize = 0
        Me.bprodPorCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.bprodPorCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.bprodPorCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bprodPorCodigo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprodPorCodigo.ForeColor = System.Drawing.SystemColors.Control
        Me.bprodPorCodigo.Image = Global.login.My.Resources.Resources.icons8_encuesta_30
        Me.bprodPorCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bprodPorCodigo.Location = New System.Drawing.Point(0, 240)
        Me.bprodPorCodigo.Name = "bprodPorCodigo"
        Me.bprodPorCodigo.Size = New System.Drawing.Size(219, 40)
        Me.bprodPorCodigo.TabIndex = 72
        Me.bprodPorCodigo.Text = "Producto Por Codigo"
        Me.bprodPorCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bprodPorCodigo.UseVisualStyleBackColor = False
        '
        'Bproductos
        '
        Me.Bproductos.FlatAppearance.BorderSize = 0
        Me.Bproductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Bproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Bproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bproductos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bproductos.ForeColor = System.Drawing.SystemColors.Control
        Me.Bproductos.Image = Global.login.My.Resources.Resources.icons8_herramientas_301
        Me.Bproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bproductos.Location = New System.Drawing.Point(3, 467)
        Me.Bproductos.Name = "Bproductos"
        Me.Bproductos.Size = New System.Drawing.Size(219, 40)
        Me.Bproductos.TabIndex = 71
        Me.Bproductos.Text = "Productos"
        Me.Bproductos.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.login.My.Resources.Resources.icons8_usuario_70__1_
        Me.Button8.Location = New System.Drawing.Point(70, 513)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 70)
        Me.Button8.TabIndex = 10
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.login.My.Resources.Resources.bosch1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 142)
        Me.Panel2.TabIndex = 0
        '
        'Bprod_vendidos
        '
        Me.Bprod_vendidos.BackColor = System.Drawing.Color.Transparent
        Me.Bprod_vendidos.FlatAppearance.BorderSize = 0
        Me.Bprod_vendidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Bprod_vendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Bprod_vendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bprod_vendidos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bprod_vendidos.ForeColor = System.Drawing.SystemColors.Control
        Me.Bprod_vendidos.Image = Global.login.My.Resources.Resources.icons8_mejora_301
        Me.Bprod_vendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bprod_vendidos.Location = New System.Drawing.Point(3, 194)
        Me.Bprod_vendidos.Name = "Bprod_vendidos"
        Me.Bprod_vendidos.Size = New System.Drawing.Size(219, 40)
        Me.Bprod_vendidos.TabIndex = 1
        Me.Bprod_vendidos.Text = "Top 10 Vendidos"
        Me.Bprod_vendidos.UseVisualStyleBackColor = False
        '
        'ventaEmpleado
        '
        Me.ventaEmpleado.FlatAppearance.BorderSize = 0
        Me.ventaEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.ventaEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.ventaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ventaEmpleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventaEmpleado.ForeColor = System.Drawing.SystemColors.Control
        Me.ventaEmpleado.Image = Global.login.My.Resources.Resources.icons8_estadísticas_301
        Me.ventaEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ventaEmpleado.Location = New System.Drawing.Point(0, 378)
        Me.ventaEmpleado.Name = "ventaEmpleado"
        Me.ventaEmpleado.Size = New System.Drawing.Size(219, 40)
        Me.ventaEmpleado.TabIndex = 5
        Me.ventaEmpleado.Text = "Ventas Empleado"
        Me.ventaEmpleado.UseVisualStyleBackColor = True
        '
        'BventasPorFecha
        '
        Me.BventasPorFecha.FlatAppearance.BorderSize = 0
        Me.BventasPorFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.BventasPorFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BventasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BventasPorFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BventasPorFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.BventasPorFecha.Image = Global.login.My.Resources.Resources.icons8_en_alza_30
        Me.BventasPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BventasPorFecha.Location = New System.Drawing.Point(0, 332)
        Me.BventasPorFecha.Name = "BventasPorFecha"
        Me.BventasPorFecha.Size = New System.Drawing.Size(219, 40)
        Me.BventasPorFecha.TabIndex = 6
        Me.BventasPorFecha.Text = "Ventas por fecha"
        Me.BventasPorFecha.UseVisualStyleBackColor = True
        '
        'BreporteStockProductos
        '
        Me.BreporteStockProductos.BackColor = System.Drawing.Color.Transparent
        Me.BreporteStockProductos.FlatAppearance.BorderSize = 0
        Me.BreporteStockProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.BreporteStockProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BreporteStockProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BreporteStockProductos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreporteStockProductos.ForeColor = System.Drawing.SystemColors.Control
        Me.BreporteStockProductos.Image = Global.login.My.Resources.Resources.icons8_test_aprobado_30
        Me.BreporteStockProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BreporteStockProductos.Location = New System.Drawing.Point(0, 148)
        Me.BreporteStockProductos.Name = "BreporteStockProductos"
        Me.BreporteStockProductos.Size = New System.Drawing.Size(219, 40)
        Me.BreporteStockProductos.TabIndex = 3
        Me.BreporteStockProductos.Text = "Lista de Productos"
        Me.BreporteStockProductos.UseVisualStyleBackColor = False
        '
        'BreportUsuarios
        '
        Me.BreportUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BreportUsuarios.FlatAppearance.BorderSize = 0
        Me.BreportUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.BreportUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BreportUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BreportUsuarios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreportUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.BreportUsuarios.Image = Global.login.My.Resources.Resources.icons8_crowd_skin_type_2_30
        Me.BreportUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BreportUsuarios.Location = New System.Drawing.Point(0, 286)
        Me.BreportUsuarios.Name = "BreportUsuarios"
        Me.BreportUsuarios.Size = New System.Drawing.Size(219, 40)
        Me.BreportUsuarios.TabIndex = 2
        Me.BreportUsuarios.Text = "Personal"
        Me.BreportUsuarios.UseVisualStyleBackColor = False
        '
        'gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 736)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelUsuaio)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(219, 40)
        Me.MaximumSize = New System.Drawing.Size(1364, 736)
        Me.MinimumSize = New System.Drawing.Size(1364, 736)
        Me.Name = "gerente"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria industrial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelUsuaio.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bprod_vendidos As Button
    Friend WithEvents BreportUsuarios As Button
    Friend WithEvents BreporteStockProductos As Button
    Friend WithEvents BcerrarSesion As Button
    Friend WithEvents ventaEmpleado As Button
    Friend WithEvents BventasPorFecha As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelUsuaio As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Textusuario As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Bproductos As Button
    Friend WithEvents bprodPorCodigo As Button
End Class
