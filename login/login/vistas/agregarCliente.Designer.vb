<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarCliente
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
        Me.Temail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ttelefono = New System.Windows.Forms.TextBox()
        Me.fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Tdomicilio = New System.Windows.Forms.TextBox()
        Me.Tdni = New System.Windows.Forms.TextBox()
        Me.Tapellido = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bmini = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Temail
        '
        Me.Temail.Location = New System.Drawing.Point(498, 161)
        Me.Temail.Name = "Temail"
        Me.Temail.Size = New System.Drawing.Size(241, 20)
        Me.Temail.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(495, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Correo"
        '
        'Ttelefono
        '
        Me.Ttelefono.Location = New System.Drawing.Point(231, 282)
        Me.Ttelefono.MaxLength = 10
        Me.Ttelefono.Name = "Ttelefono"
        Me.Ttelefono.Size = New System.Drawing.Size(241, 20)
        Me.Ttelefono.TabIndex = 48
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaNacimiento.Location = New System.Drawing.Point(498, 222)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(241, 20)
        Me.fechaNacimiento.TabIndex = 47
        '
        'Tdomicilio
        '
        Me.Tdomicilio.Location = New System.Drawing.Point(231, 222)
        Me.Tdomicilio.Name = "Tdomicilio"
        Me.Tdomicilio.Size = New System.Drawing.Size(241, 20)
        Me.Tdomicilio.TabIndex = 46
        '
        'Tdni
        '
        Me.Tdni.Location = New System.Drawing.Point(231, 161)
        Me.Tdni.MaxLength = 8
        Me.Tdni.Name = "Tdni"
        Me.Tdni.Size = New System.Drawing.Size(241, 20)
        Me.Tdni.TabIndex = 45
        '
        'Tapellido
        '
        Me.Tapellido.Location = New System.Drawing.Point(498, 107)
        Me.Tapellido.Name = "Tapellido"
        Me.Tapellido.Size = New System.Drawing.Size(241, 20)
        Me.Tapellido.TabIndex = 44
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(231, 107)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(241, 20)
        Me.Tnombre.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(228, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(495, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 18)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "N° Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(495, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Apellido"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(228, 86)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(68, 18)
        Me.Nombre.TabIndex = 37
        Me.Nombre.Text = "Nombre"
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
        Me.Panel1.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_30
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
        Me.Label1.Size = New System.Drawing.Size(157, 22)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Agregar Cliente"
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(746, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 421)
        Me.Panel4.TabIndex = 70
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 456)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(746, 5)
        Me.Panel2.TabIndex = 71
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 416)
        Me.Panel3.TabIndex = 72
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
        Me.cancelar.TabIndex = 75
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
        Me.Bagregar.TabIndex = 74
        Me.Bagregar.Text = "Guardar"
        Me.Bagregar.UseVisualStyleBackColor = True
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
        Me.Button1.TabIndex = 73
        Me.Button1.UseVisualStyleBackColor = True
        '
        'agregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(751, 461)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Bagregar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Temail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ttelefono)
        Me.Controls.Add(Me.fechaNacimiento)
        Me.Controls.Add(Me.Tdomicilio)
        Me.Controls.Add(Me.Tdni)
        Me.Controls.Add(Me.Tapellido)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(751, 461)
        Me.MinimumSize = New System.Drawing.Size(751, 461)
        Me.Name = "agregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Temail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Ttelefono As TextBox
    Friend WithEvents fechaNacimiento As DateTimePicker
    Friend WithEvents Tdomicilio As TextBox
    Friend WithEvents Tdni As TextBox
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bmini As Button
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
