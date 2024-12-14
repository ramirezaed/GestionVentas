Imports System.Threading
Imports System.Windows.Forms

Public Class gerente
    Private Sub gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gerente As New Vusuario
        gerente.EnlaceDatos(inicioSesion.N_Usuario)
        Textusuario.Text = inicioSesion.N_Usuario

    End Sub

#Region "variables para panel"
    Dim Gproductos As New gestionProductos()
    Dim ReporteFecha As New Reporte_fecha_venta()
    Dim GventaP As New ReportePordMas()
    Dim Rpersonal As New reportePersonal()
    Dim RstockProducto As New ReporteStock()
    Dim RventaEmpleado As New reporteVentaPorEmpleado()
    Dim RproCodigo As New reporteProductoPorCod()
#End Region

#Region "botones reportes"
    Private Sub Bproductos_Click(sender As Object, e As EventArgs) Handles Bproductos.Click
        If Gproductos IsNot Nothing AndAlso Not Gproductos.IsDisposed Then
            Gproductos.Close()
            Gproductos.Dispose()
        End If
        Gproductos = New gestionProductos()

        PanelUsuaio.Controls.Clear()
        Gproductos.TopLevel = False
        Gproductos.FormBorderStyle = FormBorderStyle.None
        Gproductos.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gproductos)
        Gproductos.Show()
    End Sub

    Private Sub BventasPorFecha_Click(sender As Object, e As EventArgs) Handles BventasPorFecha.Click
        If ReporteFecha IsNot Nothing AndAlso Not ReporteFecha.IsDisposed Then
            ReporteFecha.Close()
            ReporteFecha.Dispose()
        End If

        ReporteFecha = New Reporte_fecha_venta
        PanelUsuaio.Controls.Clear()
        ReporteFecha.TopLevel = False
        ReporteFecha.FormBorderStyle = FormBorderStyle.None
        ReporteFecha.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(ReporteFecha)
        ReporteFecha.Show()

    End Sub


    Private Sub Bprod_vendidos_Click(sender As Object, e As EventArgs) Handles Bprod_vendidos.Click
        If GventaP IsNot Nothing AndAlso Not GventaP.IsDisposed Then
            GventaP.Close()
            GventaP.Dispose()
        End If
        GventaP = New ReportePordMas()
        PanelUsuaio.Controls.Clear()
        GventaP.TopLevel = False
        GventaP.FormBorderStyle = FormBorderStyle.None
        GventaP.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(GventaP)
        GventaP.Show()
    End Sub

    Private Sub BreportUsuarios_Click(sender As Object, e As EventArgs) Handles BreportUsuarios.Click
        If Rpersonal Is Nothing AndAlso Not Rpersonal.IsDisposed Then
            Rpersonal.Close()
            Rpersonal.Dispose()
        End If
        Rpersonal = New reportePersonal()
        PanelUsuaio.Controls.Clear()
        Rpersonal.TopLevel = False
        Rpersonal.FormBorderStyle = FormBorderStyle.None
        Rpersonal.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Rpersonal)
        Rpersonal.Show()
    End Sub

    Private Sub BreporteStockProductos_Click(sender As Object, e As EventArgs) Handles BreporteStockProductos.Click
        If RstockProducto Is Nothing AndAlso Not RstockProducto.IsDisposed Then
            RstockProducto.Close()
            RstockProducto.Dispose()
        End If
        RstockProducto = New ReporteStock()
        PanelUsuaio.Controls.Clear()
        RstockProducto.TopLevel = False
        RstockProducto.FormBorderStyle = FormBorderStyle.None
        RstockProducto.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(RstockProducto)
        RstockProducto.Show()
    End Sub

    Private Sub ventaEmpleado_Click(sender As Object, e As EventArgs) Handles ventaEmpleado.Click
        If RventaEmpleado Is Nothing AndAlso Not RventaEmpleado.IsDisposed Then
            RventaEmpleado.Close()
            RventaEmpleado.Dispose()
        End If
        RventaEmpleado = New reporteVentaPorEmpleado()
        PanelUsuaio.Controls.Clear()
        RventaEmpleado.TopLevel = False
        RventaEmpleado.FormBorderStyle = FormBorderStyle.None
        RventaEmpleado.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(RventaEmpleado)
        RventaEmpleado.Show()
    End Sub

    Private Sub bprodPorCodigo_Click(sender As Object, e As EventArgs) Handles bprodPorCodigo.Click
        If RproCodigo Is Nothing AndAlso Not RproCodigo.IsDisposed Then
            RproCodigo.Close()
            RproCodigo.Dispose()
        End If
        RproCodigo = New reporteProductoPorCod()
        PanelUsuaio.Controls.Clear()
        RproCodigo.TopLevel = False
        RproCodigo.FormBorderStyle = FormBorderStyle.None
        RproCodigo.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(RproCodigo)
        RproCodigo.Show()
    End Sub


#End Region

#Region "botones cerrar mini cs"

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Seguro desea cerrar sesion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    '    Private Sub funcionCerrar()
    '   Me.Close()
    '      inicioSesion.Show()
    ' End Sub



    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub BcerrarSesions_Click(sender As Object, e As EventArgs) Handles BcerrarSesion.Click
        Dim resultado As MsgBoxResult
        resultado = MessageBox.Show(" Cerrar Sesion?", " Cerrar Sesion ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

#End Region

#Region "mover con e mouse"

    Private startPoint As New Point(0, 0)
    Private IsDragging As Boolean
    Private MouseOffset As Point

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDragging = True
            MouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If IsDragging Then
            Dim MousePos As Point = Control.MousePosition
            MousePos.Offset(MouseOffset.X, MouseOffset.Y)
            Location = MousePos
        End If
    End Sub
    Private Sub panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        IsDragging = False
    End Sub


#End Region


    ''''''''''''''''''''''''''' cerrar despues de un tempo de inactividad
#Region "temporizador"
    Private inactivityTimer As New System.Windows.Forms.Timer()
    Private inactivityTimeout As Integer = 1200  ' 300 segundos (5 minutos)

    Public Sub New()
        InitializeComponent()

        ' Configuro el temporizador.
        inactivityTimer.Interval = inactivityTimeout * 1000 ' Convierte a milisegundos
        AddHandler inactivityTimer.Tick, AddressOf InactivityTimer_Tick

        ' Activa el temporizador despues de cada actividad.
        AddHandler Me.MouseMove, AddressOf ResetInactivityTimer
        AddHandler Me.KeyDown, AddressOf ResetInactivityTimer

        ' inicia el temporizador.
        inactivityTimer.Start()
    End Sub

    Private Sub ResetInactivityTimer(sender As Object, e As EventArgs)
        'se restablece el teporizador
        inactivityTimer.Stop()
        inactivityTimer.Start()
    End Sub

    Private Sub InactivityTimer_Tick(sender As Object, e As EventArgs)
        funcionCerrar()
    End Sub


    Private Sub funcionCerrar()
        Me.Close()
        inicioSesion.Show()
    End Sub
#End Region
End Class

