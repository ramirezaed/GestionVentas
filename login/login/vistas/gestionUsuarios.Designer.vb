<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.BHabilitar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.datalista = New System.Windows.Forms.DataGridView()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        CType(Me.datalista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Beliminar
        '
        Me.Beliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Beliminar.FlatAppearance.BorderSize = 3
        Me.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beliminar.Image = Global.login.My.Resources.Resources.icons8_basura_30
        Me.Beliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Beliminar.Location = New System.Drawing.Point(907, 608)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(219, 40)
        Me.Beliminar.TabIndex = 23
        Me.Beliminar.Text = "Eliminar Usuario"
        Me.Beliminar.UseVisualStyleBackColor = False
        '
        'Bmodificar
        '
        Me.Bmodificar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bmodificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bmodificar.FlatAppearance.BorderSize = 3
        Me.Bmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmodificar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmodificar.Image = Global.login.My.Resources.Resources.icons8_editar_30
        Me.Bmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bmodificar.Location = New System.Drawing.Point(593, 608)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(219, 40)
        Me.Bmodificar.TabIndex = 22
        Me.Bmodificar.Text = "Editar Usuario"
        Me.Bmodificar.UseVisualStyleBackColor = False
        '
        'BHabilitar
        '
        Me.BHabilitar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BHabilitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BHabilitar.FlatAppearance.BorderSize = 3
        Me.BHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BHabilitar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHabilitar.Image = Global.login.My.Resources.Resources.icons8_de_acuerdo_30
        Me.BHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BHabilitar.Location = New System.Drawing.Point(291, 608)
        Me.BHabilitar.Name = "BHabilitar"
        Me.BHabilitar.Size = New System.Drawing.Size(219, 40)
        Me.BHabilitar.TabIndex = 21
        Me.BHabilitar.Text = "Habilitar Usuario"
        Me.BHabilitar.UseVisualStyleBackColor = False
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
        Me.buscar.TabIndex = 1
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'Bagregar
        '
        Me.Bagregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bagregar.FlatAppearance.BorderSize = 3
        Me.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bagregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bagregar.Image = Global.login.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_30
        Me.Bagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bagregar.Location = New System.Drawing.Point(22, 608)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(219, 40)
        Me.Bagregar.TabIndex = 2
        Me.Bagregar.Text = "Agregar Usuario"
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'datalista
        '
        Me.datalista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalista.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.datalista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datalista.ColumnHeadersHeight = 30
        Me.datalista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datalista.EnableHeadersVisualStyles = False
        Me.datalista.Location = New System.Drawing.Point(16, 62)
        Me.datalista.MaximumSize = New System.Drawing.Size(1110, 512)
        Me.datalista.MinimumSize = New System.Drawing.Size(1110, 512)
        Me.datalista.Name = "datalista"
        Me.datalista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalista.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalista.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.datalista.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalista.Size = New System.Drawing.Size(1110, 512)
        Me.datalista.TabIndex = 41
        '
        'Tbuscar
        '
        Me.Tbuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbuscar.Location = New System.Drawing.Point(628, 20)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 26)
        Me.Tbuscar.TabIndex = 1
        '
        'gestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.datalista)
        Me.Controls.Add(Me.Beliminar)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.BHabilitar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Bagregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1164, 700)
        Me.MinimumSize = New System.Drawing.Size(1150, 700)
        Me.Name = "gestionUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarUser"
        CType(Me.datalista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bagregar As Button
    Friend WithEvents buscar As Button
    Friend WithEvents BHabilitar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents datalista As DataGridView
    Friend WithEvents Tbuscar As TextBox
End Class
