<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reporteVentaEmpleado
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
        Me.PanelVenta = New System.Windows.Forms.Panel()
        Me.DateTimehasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimedesde = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.PanelReporte = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ventasPorUsuarioYFecha11 = New login.ventasPorUsuarioYFecha1()
        Me.PanelVenta.SuspendLayout()
        Me.PanelReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVenta
        '
        Me.PanelVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelVenta.Controls.Add(Me.DateTimehasta)
        Me.PanelVenta.Controls.Add(Me.DateTimedesde)
        Me.PanelVenta.Controls.Add(Me.Button1)
        Me.PanelVenta.Controls.Add(Me.Label2)
        Me.PanelVenta.Controls.Add(Me.Label1)
        Me.PanelVenta.Controls.Add(Me.Bmostrar)
        Me.PanelVenta.Location = New System.Drawing.Point(0, 0)
        Me.PanelVenta.MaximumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.MinimumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.Name = "PanelVenta"
        Me.PanelVenta.Size = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.TabIndex = 7
        '
        'DateTimehasta
        '
        Me.DateTimehasta.Location = New System.Drawing.Point(608, 48)
        Me.DateTimehasta.Name = "DateTimehasta"
        Me.DateTimehasta.Size = New System.Drawing.Size(200, 20)
        Me.DateTimehasta.TabIndex = 14
        '
        'DateTimedesde
        '
        Me.DateTimedesde.Location = New System.Drawing.Point(278, 48)
        Me.DateTimedesde.Name = "DateTimedesde"
        Me.DateTimedesde.Size = New System.Drawing.Size(200, 20)
        Me.DateTimedesde.TabIndex = 13
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(177, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(515, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hasta"
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
        Me.Bmostrar.Location = New System.Drawing.Point(477, 87)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(195, 38)
        Me.Bmostrar.TabIndex = 2
        Me.Bmostrar.Text = "Mostrar"
        Me.Bmostrar.UseVisualStyleBackColor = False
        '
        'PanelReporte
        '
        Me.PanelReporte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelReporte.Controls.Add(Me.CrystalReportViewer4)
        Me.PanelReporte.Location = New System.Drawing.Point(0, 142)
        Me.PanelReporte.MaximumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.MinimumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.Name = "PanelReporte"
        Me.PanelReporte.Size = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.TabIndex = 8
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = -1
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.ReportSource = Me.ventasPorUsuarioYFecha11
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(1145, 556)
        Me.CrystalReportViewer4.TabIndex = 0
        Me.CrystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'reporteVentaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 661)
        Me.Controls.Add(Me.PanelReporte)
        Me.Controls.Add(Me.PanelVenta)
        Me.Name = "reporteVentaEmpleado"
        Me.Text = "reporteVentaEmpleado"
        Me.PanelVenta.ResumeLayout(False)
        Me.PanelVenta.PerformLayout()
        Me.PanelReporte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVenta As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmostrar As Button
    Friend WithEvents DateTimedesde As DateTimePicker
    Friend WithEvents DateTimehasta As DateTimePicker
    Friend WithEvents PanelReporte As Panel
    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ventasPorUsuarioYFecha11 As ventasPorUsuarioYFecha1
End Class
