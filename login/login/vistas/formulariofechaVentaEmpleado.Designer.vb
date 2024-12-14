<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulariofechaVentaEmpleado
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
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ventasPorUsuarioYFecha11 = New login.ventasPorUsuarioYFecha1()
        Me.SuspendLayout()
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = -1
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer4.DisplayStatusBar = False
        Me.CrystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.ReportSource = Me.ventasPorUsuarioYFecha11
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(812, 497)
        Me.CrystalReportViewer4.TabIndex = 0
        Me.CrystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'formulariofechaVentaEmpleado
        '
        Me.ClientSize = New System.Drawing.Size(812, 497)
        Me.Controls.Add(Me.CrystalReportViewer4)
        Me.Name = "formulariofechaVentaEmpleado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents ventaUnEmpleado1 As ventaUnEmpleado
    'Friend WithEvents ventaUnEmpleado2 As ventaUnEmpleado
    'Friend WithEvents ventaUnEmpleado11 As ventaUnEmpleado1
    'Friend WithEvents ventaUnEmpleado12 As ventaUnEmpleado1
    'Friend WithEvents ventaUnEmpleado13 As ventaUnEmpleado1
    Friend WithEvents CachedCrystalReport11 As CachedCrystalReport1
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer

    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ventasPorUsuarioYFecha11 As ventasPorUsuarioYFecha1

    '  Friend WithEvents ventaUnEmpleado2 As ventaUnEmpleado
End Class
