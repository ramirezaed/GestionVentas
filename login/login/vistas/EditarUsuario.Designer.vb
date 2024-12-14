<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Rgeren1 = New System.Windows.Forms.RadioButton()
        Me.Radmin1 = New System.Windows.Forms.RadioButton()
        Me.Rvendedor1 = New System.Windows.Forms.RadioButton()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tapellido = New System.Windows.Forms.TextBox()
        Me.Tdni = New System.Windows.Forms.TextBox()
        Me.Tdireccion = New System.Windows.Forms.TextBox()
        Me.Tcontraseña = New System.Windows.Forms.TextBox()
        Me.Tusuario = New System.Windows.Forms.TextBox()
        Me.fechaNa = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Tbuscar = New System.Windows.Forms.TextBox()
        Me.datalista = New System.Windows.Forms.DataGridView()
        Me.buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.datalista, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 64
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
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Editar Usuario"
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
        'Rgeren1
        '
        Me.Rgeren1.AutoSize = True
        Me.Rgeren1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rgeren1.Location = New System.Drawing.Point(82, 541)
        Me.Rgeren1.Name = "Rgeren1"
        Me.Rgeren1.Size = New System.Drawing.Size(94, 20)
        Me.Rgeren1.TabIndex = 62
        Me.Rgeren1.TabStop = True
        Me.Rgeren1.Text = "Vendedor"
        Me.Rgeren1.UseVisualStyleBackColor = True
        '
        'Radmin1
        '
        Me.Radmin1.AutoSize = True
        Me.Radmin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radmin1.Location = New System.Drawing.Point(7, 542)
        Me.Radmin1.Name = "Radmin1"
        Me.Radmin1.Size = New System.Drawing.Size(69, 20)
        Me.Radmin1.TabIndex = 60
        Me.Radmin1.TabStop = True
        Me.Radmin1.Text = "Admin"
        Me.Radmin1.UseVisualStyleBackColor = True
        '
        'Rvendedor1
        '
        Me.Rvendedor1.AutoSize = True
        Me.Rvendedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rvendedor1.Location = New System.Drawing.Point(182, 542)
        Me.Rvendedor1.Name = "Rvendedor1"
        Me.Rvendedor1.Size = New System.Drawing.Size(81, 20)
        Me.Rvendedor1.TabIndex = 61
        Me.Rvendedor1.TabStop = True
        Me.Rvendedor1.Text = "Gerente"
        Me.Rvendedor1.UseVisualStyleBackColor = True
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(12, 145)
        Me.Tnombre.MaxLength = 50
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(220, 20)
        Me.Tnombre.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "N° Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 520)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 19)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Tipo de usuario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 461)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 19)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 19)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Domicilio"
        '
        'Tapellido
        '
        Me.Tapellido.Location = New System.Drawing.Point(12, 200)
        Me.Tapellido.MaxLength = 50
        Me.Tapellido.Name = "Tapellido"
        Me.Tapellido.Size = New System.Drawing.Size(220, 20)
        Me.Tapellido.TabIndex = 46
        '
        'Tdni
        '
        Me.Tdni.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Tdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tdni.Location = New System.Drawing.Point(11, 259)
        Me.Tdni.MaxLength = 8
        Me.Tdni.Name = "Tdni"
        Me.Tdni.ReadOnly = True
        Me.Tdni.Size = New System.Drawing.Size(220, 26)
        Me.Tdni.TabIndex = 48
        '
        'Tdireccion
        '
        Me.Tdireccion.Location = New System.Drawing.Point(12, 373)
        Me.Tdireccion.Name = "Tdireccion"
        Me.Tdireccion.Size = New System.Drawing.Size(220, 20)
        Me.Tdireccion.TabIndex = 51
        '
        'Tcontraseña
        '
        Me.Tcontraseña.Location = New System.Drawing.Point(14, 483)
        Me.Tcontraseña.MaxLength = 20
        Me.Tcontraseña.Name = "Tcontraseña"
        Me.Tcontraseña.Size = New System.Drawing.Size(220, 20)
        Me.Tcontraseña.TabIndex = 55
        '
        'Tusuario
        '
        Me.Tusuario.Location = New System.Drawing.Point(12, 427)
        Me.Tusuario.MaxLength = 20
        Me.Tusuario.Name = "Tusuario"
        Me.Tusuario.Size = New System.Drawing.Size(220, 20)
        Me.Tusuario.TabIndex = 53
        '
        'fechaNa
        '
        Me.fechaNa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNa.Location = New System.Drawing.Point(11, 324)
        Me.fechaNa.Name = "fechaNa"
        Me.fechaNa.Size = New System.Drawing.Size(220, 20)
        Me.fechaNa.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 645)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 5)
        Me.Panel2.TabIndex = 66
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 605)
        Me.Panel3.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(895, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 605)
        Me.Panel4.TabIndex = 68
        '
        'Tbuscar
        '
        Me.Tbuscar.Location = New System.Drawing.Point(412, 87)
        Me.Tbuscar.Name = "Tbuscar"
        Me.Tbuscar.Size = New System.Drawing.Size(214, 20)
        Me.Tbuscar.TabIndex = 1
        '
        'datalista
        '
        Me.datalista.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
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
        Me.datalista.Location = New System.Drawing.Point(240, 138)
        Me.datalista.Name = "datalista"
        Me.datalista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalista.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalista.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.datalista.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalista.Size = New System.Drawing.Size(641, 365)
        Me.datalista.TabIndex = 71
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 3
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscar.Location = New System.Drawing.Point(670, 75)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(219, 40)
        Me.buscar.TabIndex = 69
        Me.buscar.Text = "Buscar"
        Me.buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.login.My.Resources.Resources.icons8_grupo_de_usuarios_hombre_y_mujer_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 69)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cancelar.FlatAppearance.BorderSize = 3
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.Image = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelar.Location = New System.Drawing.Point(339, 587)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(219, 40)
        Me.cancelar.TabIndex = 59
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
        Me.Bmodificar.Location = New System.Drawing.Point(662, 587)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(219, 40)
        Me.Bmodificar.TabIndex = 58
        Me.Bmodificar.Text = "Guardar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'EditarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 650)
        Me.Controls.Add(Me.datalista)
        Me.Controls.Add(Me.Tbuscar)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Rgeren1)
        Me.Controls.Add(Me.Radmin1)
        Me.Controls.Add(Me.Rvendedor1)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tapellido)
        Me.Controls.Add(Me.Tdni)
        Me.Controls.Add(Me.Tdireccion)
        Me.Controls.Add(Me.Tcontraseña)
        Me.Controls.Add(Me.Tusuario)
        Me.Controls.Add(Me.fechaNa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(900, 700)
        Me.MinimumSize = New System.Drawing.Size(751, 400)
        Me.Name = "EditarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datalista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Rgeren1 As RadioButton
    Friend WithEvents Radmin1 As RadioButton
    Friend WithEvents Rvendedor1 As RadioButton
    Friend WithEvents cancelar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tdni As TextBox
    Friend WithEvents Tdireccion As TextBox
    Friend WithEvents Tcontraseña As TextBox
    Friend WithEvents Tusuario As TextBox
    Friend WithEvents fechaNa As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents buscar As Button
    Friend WithEvents Tbuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents datalista As DataGridView
End Class
