<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
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
        Me.Csesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Textusuario = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Ausuario = New System.Windows.Forms.Button()
        Me.BotonBuckup = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonMIni = New System.Windows.Forms.Button()
        Me.BotonClose = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PanelUsuaio = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelUsuaio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Csesion
        '
        Me.Csesion.FlatAppearance.BorderSize = 0
        Me.Csesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Csesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Csesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Csesion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Csesion.ForeColor = System.Drawing.Color.Transparent
        Me.Csesion.Location = New System.Drawing.Point(0, 659)
        Me.Csesion.Name = "Csesion"
        Me.Csesion.Size = New System.Drawing.Size(219, 33)
        Me.Csesion.TabIndex = 3
        Me.Csesion.Text = "Cerrar Sesion"
        Me.Csesion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Textusuario)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Ausuario)
        Me.Panel1.Controls.Add(Me.Csesion)
        Me.Panel1.Controls.Add(Me.BotonBuckup)
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.MaximumSize = New System.Drawing.Size(219, 700)
        Me.Panel1.MinimumSize = New System.Drawing.Size(219, 600)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 695)
        Me.Panel1.TabIndex = 11
        '
        'Textusuario
        '
        Me.Textusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Textusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textusuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textusuario.ForeColor = System.Drawing.Color.Aquamarine
        Me.Textusuario.Location = New System.Drawing.Point(0, 615)
        Me.Textusuario.Name = "Textusuario"
        Me.Textusuario.ReadOnly = True
        Me.Textusuario.Size = New System.Drawing.Size(219, 24)
        Me.Textusuario.TabIndex = 6
        Me.Textusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.login.My.Resources.Resources.icons8_usuario_70__1_
        Me.Button1.Location = New System.Drawing.Point(79, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.login.My.Resources.Resources.bosh1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.MaximumSize = New System.Drawing.Size(219, 142)
        Me.Panel2.MinimumSize = New System.Drawing.Size(219, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 142)
        Me.Panel2.TabIndex = 4
        '
        'Ausuario
        '
        Me.Ausuario.BackColor = System.Drawing.Color.Transparent
        Me.Ausuario.FlatAppearance.BorderSize = 0
        Me.Ausuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Ausuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Ausuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ausuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ausuario.ForeColor = System.Drawing.SystemColors.Control
        Me.Ausuario.Image = Global.login.My.Resources.Resources.icons8_clientes_30_color
        Me.Ausuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ausuario.Location = New System.Drawing.Point(0, 158)
        Me.Ausuario.Name = "Ausuario"
        Me.Ausuario.Size = New System.Drawing.Size(219, 33)
        Me.Ausuario.TabIndex = 1
        Me.Ausuario.Text = "Usuarios"
        Me.Ausuario.UseVisualStyleBackColor = False
        '
        'BotonBuckup
        '
        Me.BotonBuckup.BackColor = System.Drawing.Color.Transparent
        Me.BotonBuckup.FlatAppearance.BorderSize = 0
        Me.BotonBuckup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.BotonBuckup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BotonBuckup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuckup.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBuckup.ForeColor = System.Drawing.Color.Transparent
        Me.BotonBuckup.Image = Global.login.My.Resources.Resources.icons8_guardar_301
        Me.BotonBuckup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonBuckup.Location = New System.Drawing.Point(0, 209)
        Me.BotonBuckup.Name = "BotonBuckup"
        Me.BotonBuckup.Size = New System.Drawing.Size(213, 33)
        Me.BotonBuckup.TabIndex = 2
        Me.BotonBuckup.Text = "Buck Up"
        Me.BotonBuckup.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1359, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 736)
        Me.Panel4.TabIndex = 69
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 736)
        Me.Panel5.TabIndex = 69
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 736)
        Me.Panel3.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Administrador"
        '
        'BotonMIni
        '
        Me.BotonMIni.BackgroundImage = Global.login.My.Resources.Resources.icons8_minimizar_361
        Me.BotonMIni.FlatAppearance.BorderSize = 0
        Me.BotonMIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.BotonMIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BotonMIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMIni.Location = New System.Drawing.Point(1283, 0)
        Me.BotonMIni.Name = "BotonMIni"
        Me.BotonMIni.Size = New System.Drawing.Size(36, 36)
        Me.BotonMIni.TabIndex = 14
        Me.BotonMIni.UseVisualStyleBackColor = True
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.BackgroundImage = Global.login.My.Resources.Resources.icons8_cerrar_ventana_36
        Me.BotonClose.FlatAppearance.BorderSize = 0
        Me.BotonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BotonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BotonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonClose.Location = New System.Drawing.Point(1325, 0)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(36, 36)
        Me.BotonClose.TabIndex = 0
        Me.BotonClose.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.login.My.Resources.Resources.icons8_bosch_a_german_multinational_engineering_and_technology_company_30
        Me.Button4.Location = New System.Drawing.Point(3, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 78
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PanelUsuaio
        '
        Me.PanelUsuaio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelUsuaio.Controls.Add(Me.Panel6)
        Me.PanelUsuaio.Location = New System.Drawing.Point(219, 40)
        Me.PanelUsuaio.Name = "PanelUsuaio"
        Me.PanelUsuaio.Size = New System.Drawing.Size(1145, 695)
        Me.PanelUsuaio.TabIndex = 79
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1140, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 695)
        Me.Panel6.TabIndex = 70
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 736)
        Me.Controls.Add(Me.PanelUsuaio)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BotonMIni)
        Me.Controls.Add(Me.BotonClose)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1364, 736)
        Me.MinimumSize = New System.Drawing.Size(1364, 736)
        Me.Name = "admin"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS Ferreteria Industrial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.PanelUsuaio.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ausuario As Button
    Friend WithEvents Csesion As Button
    Friend WithEvents BotonBuckup As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BotonClose As Button
    Friend WithEvents BotonMIni As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Textusuario As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PanelUsuaio As Panel
    Friend WithEvents Panel6 As Panel
End Class
