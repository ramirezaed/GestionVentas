<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteProductoPorCod
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
        Me.PanelVenta = New System.Windows.Forms.Panel()
        Me.Bucar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TcodigoProducto = New System.Windows.Forms.TextBox()
        Me.Bmostrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelReporte = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.productoPorCodigo1 = New login.productoPorCodigo()
        Me.PanelVenta.SuspendLayout()
        Me.PanelReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVenta
        '
        Me.PanelVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelVenta.Controls.Add(Me.Bucar)
        Me.PanelVenta.Controls.Add(Me.Label3)
        Me.PanelVenta.Controls.Add(Me.TcodigoProducto)
        Me.PanelVenta.Controls.Add(Me.Bmostrar)
        Me.PanelVenta.Controls.Add(Me.Button1)
        Me.PanelVenta.Location = New System.Drawing.Point(0, 0)
        Me.PanelVenta.MaximumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.MinimumSize = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.Name = "PanelVenta"
        Me.PanelVenta.Size = New System.Drawing.Size(1145, 142)
        Me.PanelVenta.TabIndex = 7
        '
        'Bucar
        '
        Me.Bucar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Bucar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bucar.FlatAppearance.BorderSize = 3
        Me.Bucar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bucar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bucar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bucar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bucar.ForeColor = System.Drawing.SystemColors.Control
        Me.Bucar.Image = Global.login.My.Resources.Resources.icons8_lupa_30_color
        Me.Bucar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bucar.Location = New System.Drawing.Point(748, 81)
        Me.Bucar.Name = "Bucar"
        Me.Bucar.Size = New System.Drawing.Size(215, 38)
        Me.Bucar.TabIndex = 11
        Me.Bucar.Text = "Buscar Producto"
        Me.Bucar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(250, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Codigo de Producto"
        '
        'TcodigoProducto
        '
        Me.TcodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcodigoProducto.Location = New System.Drawing.Point(254, 87)
        Me.TcodigoProducto.Name = "TcodigoProducto"
        Me.TcodigoProducto.Size = New System.Drawing.Size(200, 26)
        Me.TcodigoProducto.TabIndex = 9
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
        Me.Bmostrar.Location = New System.Drawing.Point(490, 81)
        Me.Bmostrar.Name = "Bmostrar"
        Me.Bmostrar.Size = New System.Drawing.Size(219, 38)
        Me.Bmostrar.TabIndex = 8
        Me.Bmostrar.Text = "Mostrar Reporte"
        Me.Bmostrar.UseVisualStyleBackColor = False
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
        Me.PanelReporte.Controls.Add(Me.CrystalReportViewer1)
        Me.PanelReporte.Location = New System.Drawing.Point(0, 142)
        Me.PanelReporte.MaximumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.MinimumSize = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.Name = "PanelReporte"
        Me.PanelReporte.Size = New System.Drawing.Size(1145, 556)
        Me.PanelReporte.TabIndex = 8
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.productoPorCodigo1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1145, 556)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'reporteProductoPorCod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 661)
        Me.Controls.Add(Me.PanelReporte)
        Me.Controls.Add(Me.PanelVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporteProductoPorCod"
        Me.Text = "reporteProductoPorCod"
        Me.PanelVenta.ResumeLayout(False)
        Me.PanelVenta.PerformLayout()
        Me.PanelReporte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVenta As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelReporte As Panel
    Friend WithEvents Bucar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TcodigoProducto As TextBox
    Friend WithEvents Bmostrar As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents productoPorCodigo1 As productoPorCodigo
End Class
