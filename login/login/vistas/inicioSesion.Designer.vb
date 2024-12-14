<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicioSesion
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
        Me.bsalir = New System.Windows.Forms.Button()
        Me.bingresar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nusuario = New System.Windows.Forms.TextBox()
        Me.ncontraseña = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.barra = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bminimizar = New System.Windows.Forms.Button()
        Me.Bcerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsalir
        '
        Me.bsalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.bsalir.FlatAppearance.BorderSize = 0
        Me.bsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.bsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.ForeColor = System.Drawing.Color.Silver
        Me.bsalir.Location = New System.Drawing.Point(132, 377)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(230, 37)
        Me.bsalir.TabIndex = 3
        Me.bsalir.Text = "Salir"
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'bingresar
        '
        Me.bingresar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.bingresar.FlatAppearance.BorderSize = 0
        Me.bingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.bingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.bingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bingresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bingresar.ForeColor = System.Drawing.Color.Silver
        Me.bingresar.Location = New System.Drawing.Point(132, 334)
        Me.bingresar.Name = "bingresar"
        Me.bingresar.Size = New System.Drawing.Size(230, 37)
        Me.bingresar.TabIndex = 2
        Me.bingresar.Text = "Ingresar"
        Me.bingresar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(128, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(128, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'nusuario
        '
        Me.nusuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.nusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.nusuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nusuario.ForeColor = System.Drawing.SystemColors.Control
        Me.nusuario.Location = New System.Drawing.Point(132, 210)
        Me.nusuario.Name = "nusuario"
        Me.nusuario.Size = New System.Drawing.Size(230, 27)
        Me.nusuario.TabIndex = 0
        '
        'ncontraseña
        '
        Me.ncontraseña.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ncontraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ncontraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ncontraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.ncontraseña.Location = New System.Drawing.Point(132, 276)
        Me.ncontraseña.Name = "ncontraseña"
        Me.ncontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ncontraseña.Size = New System.Drawing.Size(230, 27)
        Me.ncontraseña.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 444)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 17)
        Me.Panel1.TabIndex = 9
        '
        'barra
        '
        Me.barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.barra.Controls.Add(Me.Button4)
        Me.barra.Controls.Add(Me.Label3)
        Me.barra.Controls.Add(Me.Bminimizar)
        Me.barra.Controls.Add(Me.Bcerrar)
        Me.barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(484, 55)
        Me.barra.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.login.My.Resources.Resources.icons8_bosch_a_german_multinational_engineering_and_technology_company_30
        Me.Button4.Location = New System.Drawing.Point(153, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 79
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(194, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Bosch Tools"
        '
        'Bminimizar
        '
        Me.Bminimizar.BackgroundImage = Global.login.My.Resources.Resources.icons8_minimizar_361
        Me.Bminimizar.FlatAppearance.BorderSize = 0
        Me.Bminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Bminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Bminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bminimizar.Location = New System.Drawing.Point(403, 12)
        Me.Bminimizar.Name = "Bminimizar"
        Me.Bminimizar.Size = New System.Drawing.Size(36, 36)
        Me.Bminimizar.TabIndex = 4
        Me.Bminimizar.UseVisualStyleBackColor = True
        '
        'Bcerrar
        '
        Me.Bcerrar.BackColor = System.Drawing.Color.Transparent
        Me.Bcerrar.BackgroundImage = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.Bcerrar.FlatAppearance.BorderSize = 0
        Me.Bcerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bcerrar.Location = New System.Drawing.Point(445, 12)
        Me.Bcerrar.Name = "Bcerrar"
        Me.Bcerrar.Size = New System.Drawing.Size(36, 36)
        Me.Bcerrar.TabIndex = 5
        Me.Bcerrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 389)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(479, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 389)
        Me.Panel3.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.login.My.Resources.Resources.icons8_bosch_a_german_multinational_engineering_and_technology_company_100__1_
        Me.Button2.Location = New System.Drawing.Point(198, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 100)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'inicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bingresar)
        Me.Controls.Add(Me.ncontraseña)
        Me.Controls.Add(Me.nusuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "inicioSesion"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        Me.barra.ResumeLayout(False)
        Me.barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsalir As Button
    Friend WithEvents ncontraseña As TextBox
    Friend WithEvents nusuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bingresar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Bcerrar As Button
    Friend WithEvents Bminimizar As Button
    Friend WithEvents barra As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
End Class
