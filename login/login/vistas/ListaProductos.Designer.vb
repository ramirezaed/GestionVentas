<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.DataProductos = New System.Windows.Forms.DataGridView()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Bmini)
        Me.Panel1.Controls.Add(Me.Bcerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(751, 40)
        Me.Panel1.MinimumSize = New System.Drawing.Size(751, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 40)
        Me.Panel1.TabIndex = 80
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.Button2.Location = New System.Drawing.Point(21, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 76
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 22)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Buscar Producto"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 431)
        Me.Panel3.TabIndex = 82
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(746, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 431)
        Me.Panel4.TabIndex = 83
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 5)
        Me.Panel2.TabIndex = 84
        '
        'Tbuscar
        '
        Me.Tbuscar.Location = New System.Drawing.Point(263, 58)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 20)
        Me.Tbuscar.TabIndex = 91
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 3
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscar.Location = New System.Drawing.Point(521, 46)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(219, 40)
        Me.buscar.TabIndex = 90
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'DataProductos
        '
        Me.DataProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataProductos.ColumnHeadersHeight = 30
        Me.DataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataProductos.EnableHeadersVisualStyles = False
        Me.DataProductos.Location = New System.Drawing.Point(21, 92)
        Me.DataProductos.MaximumSize = New System.Drawing.Size(711, 282)
        Me.DataProductos.MinimumSize = New System.Drawing.Size(711, 282)
        Me.DataProductos.Name = "DataProductos"
        Me.DataProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataProductos.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataProductos.Size = New System.Drawing.Size(711, 282)
        Me.DataProductos.TabIndex = 92
        '
        'cancelar
        '
        Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cancelar.FlatAppearance.BorderSize = 3
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Image = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelar.Location = New System.Drawing.Point(244, 400)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(219, 40)
        Me.cancelar.TabIndex = 94
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bagregar.FlatAppearance.BorderSize = 3
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bagregar.Image = Global.login.My.Resources.Resources.icons8_vender_stock_30
        Me.Bagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bagregar.Location = New System.Drawing.Point(513, 400)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(219, 40)
        Me.Bagregar.TabIndex = 93
        Me.Bagregar.Text = "Agregar"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(751, 471)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.DataProductos)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimumSize = New System.Drawing.Size(751, 431)
        Me.Name = "ListaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaProductos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents buscar As Button
    Friend WithEvents DataProductos As DataGridView
    Friend WithEvents cancelar As Button
    Friend WithEvents Bagregar As Button
End Class
