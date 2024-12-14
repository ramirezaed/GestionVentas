<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataListadoProducto = New System.Windows.Forms.DataGridView()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.BhabilitarProd = New System.Windows.Forms.Button()
        Me.BeliminarProducto = New System.Windows.Forms.Button()
        Me.BEditarProducto = New System.Windows.Forms.Button()
        Me.BagregarProducto = New System.Windows.Forms.Button()
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataListadoProducto
        '
        Me.DataListadoProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListadoProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DataListadoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataListadoProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataListadoProducto.ColumnHeadersHeight = 30
        Me.DataListadoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataListadoProducto.EnableHeadersVisualStyles = False
        Me.DataListadoProducto.Location = New System.Drawing.Point(16, 62)
        Me.DataListadoProducto.MaximumSize = New System.Drawing.Size(1110, 512)
        Me.DataListadoProducto.MinimumSize = New System.Drawing.Size(1110, 512)
        Me.DataListadoProducto.Name = "DataListadoProducto"
        Me.DataListadoProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListadoProducto.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataListadoProducto.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataListadoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListadoProducto.Size = New System.Drawing.Size(1110, 512)
        Me.DataListadoProducto.TabIndex = 42
        '
        'Tbuscar
        '
        Me.Tbuscar.Location = New System.Drawing.Point(672, 24)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 20)
        Me.Tbuscar.TabIndex = 43
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 3
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscar.Location = New System.Drawing.Point(907, 12)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(219, 40)
        Me.buscar.TabIndex = 44
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'BhabilitarProd
        '
        Me.BhabilitarProd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BhabilitarProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BhabilitarProd.FlatAppearance.BorderSize = 3
        Me.BhabilitarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BhabilitarProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BhabilitarProd.Image = Global.login.My.Resources.Resources.icons8_de_acuerdo_30
        Me.BhabilitarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BhabilitarProd.Location = New System.Drawing.Point(284, 608)
        Me.BhabilitarProd.Name = "BhabilitarProd"
        Me.BhabilitarProd.Size = New System.Drawing.Size(219, 40)
        Me.BhabilitarProd.TabIndex = 35
        Me.BhabilitarProd.Text = "Habilitar producto"
        Me.BhabilitarProd.UseVisualStyleBackColor = False
        '
        'BeliminarProducto
        '
        Me.BeliminarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BeliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BeliminarProducto.FlatAppearance.BorderSize = 3
        Me.BeliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeliminarProducto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeliminarProducto.Image = Global.login.My.Resources.Resources.icons8_basura_30
        Me.BeliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BeliminarProducto.Location = New System.Drawing.Point(907, 608)
        Me.BeliminarProducto.Name = "BeliminarProducto"
        Me.BeliminarProducto.Size = New System.Drawing.Size(219, 40)
        Me.BeliminarProducto.TabIndex = 18
        Me.BeliminarProducto.Text = "Eliminar Producto"
        Me.BeliminarProducto.UseVisualStyleBackColor = False
        '
        'BEditarProducto
        '
        Me.BEditarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BEditarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BEditarProducto.FlatAppearance.BorderSize = 3
        Me.BEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarProducto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditarProducto.Image = Global.login.My.Resources.Resources.icons8_editar_30
        Me.BEditarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditarProducto.Location = New System.Drawing.Point(593, 608)
        Me.BEditarProducto.Name = "BEditarProducto"
        Me.BEditarProducto.Size = New System.Drawing.Size(219, 40)
        Me.BEditarProducto.TabIndex = 17
        Me.BEditarProducto.Text = "Editar Producto"
        Me.BEditarProducto.UseVisualStyleBackColor = False
        '
        'BagregarProducto
        '
        Me.BagregarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BagregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BagregarProducto.FlatAppearance.BorderSize = 3
        Me.BagregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BagregarProducto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagregarProducto.Image = Global.login.My.Resources.Resources.icons8_herramientas_301
        Me.BagregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BagregarProducto.Location = New System.Drawing.Point(22, 608)
        Me.BagregarProducto.Name = "BagregarProducto"
        Me.BagregarProducto.Size = New System.Drawing.Size(219, 40)
        Me.BagregarProducto.TabIndex = 16
        Me.BagregarProducto.Text = "Agregar Producto"
        Me.BagregarProducto.UseVisualStyleBackColor = False
        '
        'gestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.DataListadoProducto)
        Me.Controls.Add(Me.BhabilitarProd)
        Me.Controls.Add(Me.BeliminarProducto)
        Me.Controls.Add(Me.BEditarProducto)
        Me.Controls.Add(Me.BagregarProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1164, 700)
        Me.MinimumSize = New System.Drawing.Size(1150, 700)
        Me.Name = "gestionProductos"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        CType(Me.DataListadoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BagregarProducto As Button
    Friend WithEvents BEditarProducto As Button
    Friend WithEvents BeliminarProducto As Button
    Friend WithEvents BhabilitarProd As Button
    Friend WithEvents DataListadoProducto As DataGridView
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents buscar As Button
End Class
