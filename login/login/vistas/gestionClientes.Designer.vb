<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionClientes
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
        Me.BagreCliente = New System.Windows.Forms.Button()
        Me.BeditarCliente = New System.Windows.Forms.Button()
        Me.BeliminarCliente = New System.Windows.Forms.Button()
        Me.Bhabilitar = New System.Windows.Forms.Button()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.DataListadoCliente = New System.Windows.Forms.DataGridView()
        CType(Me.DataListadoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BagreCliente
        '
        Me.BagreCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BagreCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BagreCliente.FlatAppearance.BorderSize = 3
        Me.BagreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BagreCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BagreCliente.Image = Global.login.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_301
        Me.BagreCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BagreCliente.Location = New System.Drawing.Point(22, 608)
        Me.BagreCliente.Name = "BagreCliente"
        Me.BagreCliente.Size = New System.Drawing.Size(219, 40)
        Me.BagreCliente.TabIndex = 16
        Me.BagreCliente.Text = "Agregar cliente"
        Me.BagreCliente.UseVisualStyleBackColor = False
        '
        'BeditarCliente
        '
        Me.BeditarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BeditarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BeditarCliente.FlatAppearance.BorderSize = 3
        Me.BeditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeditarCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeditarCliente.Image = Global.login.My.Resources.Resources.icons8_editar_30
        Me.BeditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BeditarCliente.Location = New System.Drawing.Point(593, 608)
        Me.BeditarCliente.Name = "BeditarCliente"
        Me.BeditarCliente.Size = New System.Drawing.Size(219, 40)
        Me.BeditarCliente.TabIndex = 17
        Me.BeditarCliente.Text = "Editar Cliente"
        Me.BeditarCliente.UseVisualStyleBackColor = False
        '
        'BeliminarCliente
        '
        Me.BeliminarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BeliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BeliminarCliente.FlatAppearance.BorderSize = 3
        Me.BeliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeliminarCliente.Image = Global.login.My.Resources.Resources.icons8_basura_30
        Me.BeliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BeliminarCliente.Location = New System.Drawing.Point(907, 608)
        Me.BeliminarCliente.Name = "BeliminarCliente"
        Me.BeliminarCliente.Size = New System.Drawing.Size(219, 40)
        Me.BeliminarCliente.TabIndex = 18
        Me.BeliminarCliente.Text = "Eliminar Cliente"
        Me.BeliminarCliente.UseVisualStyleBackColor = False
        '
        'Bhabilitar
        '
        Me.Bhabilitar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bhabilitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bhabilitar.FlatAppearance.BorderSize = 3
        Me.Bhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bhabilitar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bhabilitar.Image = Global.login.My.Resources.Resources.icons8_de_acuerdo_30
        Me.Bhabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bhabilitar.Location = New System.Drawing.Point(298, 608)
        Me.Bhabilitar.Name = "Bhabilitar"
        Me.Bhabilitar.Size = New System.Drawing.Size(219, 40)
        Me.Bhabilitar.TabIndex = 37
        Me.Bhabilitar.Text = "Habilitar Cliente"
        Me.Bhabilitar.UseVisualStyleBackColor = False
        '
        'Tbuscar
        '
        Me.Tbuscar.Location = New System.Drawing.Point(661, 24)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 20)
        Me.Tbuscar.TabIndex = 38
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
        Me.buscar.TabIndex = 39
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'DataListadoCliente
        '
        Me.DataListadoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListadoCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DataListadoCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataListadoCliente.ColumnHeadersHeight = 30
        Me.DataListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataListadoCliente.EnableHeadersVisualStyles = False
        Me.DataListadoCliente.Location = New System.Drawing.Point(16, 62)
        Me.DataListadoCliente.MaximumSize = New System.Drawing.Size(1110, 512)
        Me.DataListadoCliente.MinimumSize = New System.Drawing.Size(1110, 512)
        Me.DataListadoCliente.Name = "DataListadoCliente"
        Me.DataListadoCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListadoCliente.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataListadoCliente.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataListadoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListadoCliente.Size = New System.Drawing.Size(1110, 512)
        Me.DataListadoCliente.TabIndex = 40
        '
        'gestionClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1180, 693)
        Me.Controls.Add(Me.DataListadoCliente)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Bhabilitar)
        Me.Controls.Add(Me.BeliminarCliente)
        Me.Controls.Add(Me.BeditarCliente)
        Me.Controls.Add(Me.BagreCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(956, 433)
        Me.MaximumSize = New System.Drawing.Size(1180, 693)
        Me.MinimumSize = New System.Drawing.Size(1180, 693)
        Me.Name = "gestionClientes"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        CType(Me.DataListadoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BagreCliente As Button
    Friend WithEvents BeditarCliente As Button
    Friend WithEvents BeliminarCliente As Button
    Friend WithEvents Bhabilitar As Button
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents DataListadoCliente As DataGridView
End Class
