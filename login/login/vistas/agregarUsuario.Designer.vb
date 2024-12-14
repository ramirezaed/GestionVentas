<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarUsuario
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
        Me.fechaNa = New System.Windows.Forms.DateTimePicker()
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
        Me.Radmin = New System.Windows.Forms.RadioButton()
        Me.Tusuario = New System.Windows.Forms.TextBox()
        Me.Rvendedor = New System.Windows.Forms.RadioButton()
        Me.Rgeren = New System.Windows.Forms.RadioButton()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Radmin1 = New System.Windows.Forms.RadioButton()
        Me.Rvendedor1 = New System.Windows.Forms.RadioButton()
        Me.Rgeren1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fechaNa
        '
        Me.fechaNa.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaNa.Location = New System.Drawing.Point(475, 180)
        Me.fechaNa.Name = "fechaNa"
        Me.fechaNa.Size = New System.Drawing.Size(220, 20)
        Me.fechaNa.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "N° Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(471, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Tipo de usuario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(471, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 19)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(228, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(227, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Domicilio"
        '
        'Tapellido
        '
        Me.Tapellido.Location = New System.Drawing.Point(472, 107)
        Me.Tapellido.MaxLength = 50
        Me.Tapellido.Name = "Tapellido"
        Me.Tapellido.Size = New System.Drawing.Size(223, 20)
        Me.Tapellido.TabIndex = 21
        '
        'Tdni
        '
        Me.Tdni.Location = New System.Drawing.Point(231, 180)
        Me.Tdni.MaxLength = 8
        Me.Tdni.Name = "Tdni"
        Me.Tdni.Size = New System.Drawing.Size(226, 20)
        Me.Tdni.TabIndex = 23
        '
        'Tdireccion
        '
        Me.Tdireccion.Location = New System.Drawing.Point(231, 253)
        Me.Tdireccion.Name = "Tdireccion"
        Me.Tdireccion.Size = New System.Drawing.Size(227, 20)
        Me.Tdireccion.TabIndex = 26
        '
        'Tcontraseña
        '
        Me.Tcontraseña.Location = New System.Drawing.Point(475, 314)
        Me.Tcontraseña.MaxLength = 20
        Me.Tcontraseña.Name = "Tcontraseña"
        Me.Tcontraseña.Size = New System.Drawing.Size(226, 20)
        Me.Tcontraseña.TabIndex = 30
        '
        'Radmin
        '
        Me.Radmin.AutoSize = True
        Me.Radmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radmin.Location = New System.Drawing.Point(294, 484)
        Me.Radmin.Name = "Radmin"
        Me.Radmin.Size = New System.Drawing.Size(69, 20)
        Me.Radmin.TabIndex = 32
        Me.Radmin.TabStop = True
        Me.Radmin.Text = "Admin"
        Me.Radmin.UseVisualStyleBackColor = True
        '
        'Tusuario
        '
        Me.Tusuario.Location = New System.Drawing.Point(228, 314)
        Me.Tusuario.MaxLength = 20
        Me.Tusuario.Name = "Tusuario"
        Me.Tusuario.Size = New System.Drawing.Size(226, 20)
        Me.Tusuario.TabIndex = 28
        '
        'Rvendedor
        '
        Me.Rvendedor.AutoSize = True
        Me.Rvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rvendedor.Location = New System.Drawing.Point(469, 484)
        Me.Rvendedor.Name = "Rvendedor"
        Me.Rvendedor.Size = New System.Drawing.Size(81, 20)
        Me.Rvendedor.TabIndex = 34
        Me.Rvendedor.TabStop = True
        Me.Rvendedor.Text = "Gerente"
        Me.Rvendedor.UseVisualStyleBackColor = True
        '
        'Rgeren
        '
        Me.Rgeren.AutoSize = True
        Me.Rgeren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rgeren.Location = New System.Drawing.Point(369, 484)
        Me.Rgeren.Name = "Rgeren"
        Me.Rgeren.Size = New System.Drawing.Size(94, 20)
        Me.Rgeren.TabIndex = 33
        Me.Rgeren.TabStop = True
        Me.Rgeren.Text = "Vendedor"
        Me.Rgeren.UseVisualStyleBackColor = True
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(231, 107)
        Me.Tnombre.MaxLength = 50
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(223, 20)
        Me.Tnombre.TabIndex = 35
        '
        'Radmin1
        '
        Me.Radmin1.AutoSize = True
        Me.Radmin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radmin1.Location = New System.Drawing.Point(470, 253)
        Me.Radmin1.Name = "Radmin1"
        Me.Radmin1.Size = New System.Drawing.Size(69, 20)
        Me.Radmin1.TabIndex = 38
        Me.Radmin1.TabStop = True
        Me.Radmin1.Text = "Admin"
        Me.Radmin1.UseVisualStyleBackColor = True
        '
        'Rvendedor1
        '
        Me.Rvendedor1.AutoSize = True
        Me.Rvendedor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rvendedor1.Location = New System.Drawing.Point(645, 253)
        Me.Rvendedor1.Name = "Rvendedor1"
        Me.Rvendedor1.Size = New System.Drawing.Size(81, 20)
        Me.Rvendedor1.TabIndex = 39
        Me.Rvendedor1.TabStop = True
        Me.Rvendedor1.Text = "Gerente"
        Me.Rvendedor1.UseVisualStyleBackColor = True
        '
        'Rgeren1
        '
        Me.Rgeren1.AutoSize = True
        Me.Rgeren1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rgeren1.Location = New System.Drawing.Point(544, 253)
        Me.Rgeren1.Name = "Rgeren1"
        Me.Rgeren1.Size = New System.Drawing.Size(94, 20)
        Me.Rgeren1.TabIndex = 40
        Me.Rgeren1.TabStop = True
        Me.Rgeren1.Text = "Vendedor"
        Me.Rgeren1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.login.My.Resources.Resources.icons8_grupo_de_usuarios_hombre_y_mujer_100
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 200)
        Me.Button1.TabIndex = 41
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
        Me.cancelar.Location = New System.Drawing.Point(264, 396)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(219, 40)
        Me.cancelar.TabIndex = 37
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
        Me.Bagregar.TabIndex = 36
        Me.Bagregar.Text = "Guargar"
        Me.Bagregar.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(751, 40)
        Me.Panel1.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_30
        Me.Button2.Location = New System.Drawing.Point(12, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 71
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(53, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 22)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Agregar Usuario"
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
        Me.Bcerrar.Location = New System.Drawing.Point(715, 0)
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
        Me.Panel3.Size = New System.Drawing.Size(5, 421)
        Me.Panel3.TabIndex = 68
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(746, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 421)
        Me.Panel4.TabIndex = 69
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(5, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 5)
        Me.Panel2.TabIndex = 70
        '
        'agregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(751, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Rgeren1)
        Me.Controls.Add(Me.Radmin1)
        Me.Controls.Add(Me.Rvendedor1)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bagregar)
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
        Me.Controls.Add(Me.Radmin)
        Me.Controls.Add(Me.Tusuario)
        Me.Controls.Add(Me.Rvendedor)
        Me.Controls.Add(Me.Rgeren)
        Me.Controls.Add(Me.fechaNa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fechaNa As DateTimePicker
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
    Friend WithEvents Radmin As RadioButton
    Friend WithEvents Tusuario As TextBox
    Friend WithEvents Rvendedor As RadioButton
    Friend WithEvents Rgeren As RadioButton
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Bagregar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Radmin1 As RadioButton
    Friend WithEvents Rvendedor1 As RadioButton
    Friend WithEvents Rgeren1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
