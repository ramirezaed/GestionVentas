<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportePordMas
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
        Me.PanelReporte = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.top10masVendidos1 = New login.top10masVendidos()
        Me.PanelVenta = New System.Windows.Forms.Panel()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CachedCrystalReport11 = New login.CachedCrystalReport1()
        Me.PanelReporte.SuspendLayout()
        Me.PanelVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelReporte
        '
        Me.PanelReporte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelReporte.Controls.Add(Me.CrystalReportViewer1)
        Me.PanelReporte.Location = New System.Drawing.Point(0, 142)
        Me.PanelReporte.MaximumSize = New System.Drawing.Size(1145, 560)
        Me.PanelReporte.Name = "PanelReporte"
        Me.PanelReporte.Size = New System.Drawing.Size(1145, 559)
        Me.PanelReporte.TabIndex = 8
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.top10masVendidos1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1145, 559)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PanelVenta
        '
        Me.PanelVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelVenta.Controls.Add(Me.Bmostrar)
        Me.PanelVenta.Controls.Add(Me.Label2)
        Me.PanelVenta.Controls.Add(Me.DateTimePicker1)
        Me.PanelVenta.Controls.Add(Me.DateTimePicker2)
        Me.PanelVenta.Controls.Add(Me.Label1)
        Me.PanelVenta.Controls.Add(Me.Button1)
        Me.PanelVenta.Location = New System.Drawing.Point(0, 0)
        Me.PanelVenta.MaximumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.MinimumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.Name = "PanelVenta"
        Me.PanelVenta.Size = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.TabIndex = 7
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
        Me.Bmostrar.Location = New System.Drawing.Point(511, 88)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(219, 38)
        Me.Bmostrar.TabIndex = 12
        Me.Bmostrar.Text = "Mostrar Reporte"
        Me.Bmostrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(271, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Desde"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(358, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(674, 34)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(600, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hasta"
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
        Me.Button1.Size = New System.Drawing.Size(201, 136)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportePordMas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 700)
        Me.Controls.Add(Me.PanelReporte)
        Me.Controls.Add(Me.PanelVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1145, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1145, 700)
        Me.Name = "ReportePordMas"
        Me.Text = "ReportePordMas"
        Me.PanelReporte.ResumeLayout(False)
        Me.PanelVenta.ResumeLayout(False)
        Me.PanelVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelReporte As Panel
    Friend WithEvents PanelVenta As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Bmostrar As Button
    Friend WithEvents top10masVendidos1 As top10masVendidos
    Friend WithEvents CachedCrystalReport11 As CachedCrystalReport1
End Class
