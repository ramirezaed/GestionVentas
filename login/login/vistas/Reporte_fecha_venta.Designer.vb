<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_fecha_venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelVenta = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelReporte = New System.Windows.Forms.Panel()
        Me.PanelVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(298, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(614, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Bmostrar
        '
        Me.Bmostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bmostrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bmostrar.FlatAppearance.BorderSize = 3
        Me.Bmostrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bmostrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bmostrar.ForeColor = System.Drawing.SystemColors.Control
        Me.Bmostrar.Image = Global.login.My.Resources.Resources.icons8_informe_30
        Me.Bmostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bmostrar.Location = New System.Drawing.Point(455, 96)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(185, 38)
        Me.Bmostrar.TabIndex = 2
        Me.Bmostrar.Text = "Mostrar"
        Me.Bmostrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(540, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(211, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde"
        '
        'PanelVenta
        '
        Me.PanelVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelVenta.Controls.Add(Me.Button1)
        Me.PanelVenta.Controls.Add(Me.Label2)
        Me.PanelVenta.Controls.Add(Me.DateTimePicker1)
        Me.PanelVenta.Controls.Add(Me.DateTimePicker2)
        Me.PanelVenta.Controls.Add(Me.Label1)
        Me.PanelVenta.Controls.Add(Me.Bmostrar)
        Me.PanelVenta.Location = New System.Drawing.Point(0, 0)
        Me.PanelVenta.MaximumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.MinimumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.Name = "PanelVenta"
        Me.PanelVenta.Size = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.login.My.Resources.Resources.icons8_en_alza_100
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 136)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelReporte
        '
        Me.PanelReporte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelReporte.Location = New System.Drawing.Point(0, 140)
        Me.PanelReporte.MaximumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.MinimumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.Name = "PanelReporte"
        Me.PanelReporte.Size = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.TabIndex = 7
        '
        'Reporte_fecha_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 695)
        Me.Controls.Add(Me.PanelReporte)
        Me.Controls.Add(Me.PanelVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1145, 695)
        Me.MinimumSize = New System.Drawing.Size(1145, 695)
        Me.Name = "Reporte_fecha_venta"
        Me.Text = "fecha_venta"
        Me.PanelVenta.ResumeLayout(False)
        Me.PanelVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Bmostrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelVenta As Panel
    Friend WithEvents PanelReporte As Panel
    Friend WithEvents Button1 As Button
End Class
