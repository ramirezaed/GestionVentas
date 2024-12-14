Imports System.Threading
Imports System.Windows.Forms

Public Class user



    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        Textusuario.Text = inicioSesion.N_Usuario
    End Sub

#Region "MOVER CON EL MOUSE"
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

#Region "CERRAR S, MINIMIZAR, CERRAR"

    Private Sub BcerrarS_Click(sender As Object, e As EventArgs) Handles BcerrarS.Click
        If MsgBox("Seguro desea cerrar sesion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Fventas.rollBack()
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub Bcerrar_Click(sender As Object, e As EventArgs) Handles Bcerrar.Click
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Fventas.rollBack()
            Me.Close()
            inicioSesion.Show()
        End If

    End Sub

    Private Sub Bmini_Click(sender As Object, e As EventArgs) Handles Bmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Variables Para El Panel"
    Public Fventas As New realizarVentas()
    Dim Gclientes As New gestionClientes()
    Dim Gproductos As New gestionProductos()
    Dim Finforme As New reporteVentaEmpleado()
    Dim ReciboDeCompra As New FormularioFactura()
#End Region

    Private FventasInPanel As Boolean = False ' Variable para realizar un seguimiento


    Private Sub Bventas_Click(sender As Object, e As EventArgs) Handles Bventas.Click
        If Not Fventas.ventaRealizada Then
            Fventas.rollBack()
        End If

        If Fventas IsNot Nothing AndAlso Not Fventas.IsDisposed Then
            Fventas.Close()
            Fventas.Dispose()
        End If

        Fventas = New realizarVentas()
        PanelUsuaio.Controls.Clear()
        Fventas.TopLevel = False
        Fventas.FormBorderStyle = FormBorderStyle.None
        Fventas.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Fventas)
        Fventas.Show()

    End Sub

    Private Sub Bclientes_Click(sender As Object, e As EventArgs) Handles Bclientes.Click
        If Gclientes IsNot Nothing AndAlso Not Gclientes.IsDisposed Then
            Gclientes.Close()
            Gclientes.Dispose()
        End If
        Gclientes = New gestionClientes()
        PanelUsuaio.Controls.Clear()
        Gclientes.TopLevel = False
        Gclientes.FormBorderStyle = FormBorderStyle.None
        Gclientes.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gclientes)
        Gclientes.Show()
    End Sub


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

    Private Sub Breporte_Click(sender As Object, e As EventArgs) Handles Breporte.Click
        If Finforme IsNot Nothing AndAlso Not Finforme.IsDisposed Then
            Finforme.Close()
            Finforme.Dispose()
        End If
        Finforme = New reporteVentaEmpleado()

        PanelUsuaio.Controls.Clear()
        Finforme.TopLevel = False
        Finforme.FormBorderStyle = FormBorderStyle.None
        Finforme.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Finforme)
        Finforme.Show()

    End Sub

#Region "temporizador"
    Private inactivityTimer As New System.Windows.Forms.Timer()
    Private inactivityTimeout As Integer = 1200  ' 300 segundos (5 minutos)

    Public Sub New()
        InitializeComponent()

        '    Configuro el temporizador.
        inactivityTimer.Interval = inactivityTimeout * 1000 ' Convierte a milisegundos
        AddHandler inactivityTimer.Tick, AddressOf InactivityTimer_Tick

        '   Activa el temporizador despues de cada actividad.
        AddHandler Me.MouseMove, AddressOf ResetInactivityTimer
        AddHandler Me.KeyDown, AddressOf ResetInactivityTimer

        'inicia el temporizador.
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