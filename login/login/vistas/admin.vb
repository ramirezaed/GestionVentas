Imports System.Threading
Imports System.Windows.Forms

Public Class admin

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleado As New Vusuario
        empleado.EnlaceDatos(inicioSesion.N_Usuario)
        Textusuario.Text = inicioSesion.N_Usuario
    End Sub


#Region "CERRAR S , MINIMIZAR CERRAR"
    Private Sub Csesion_Click(sender As Object, e As EventArgs) Handles Csesion.Click
        If MsgBox("Seguro desea cerrar sesion", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If


    End Sub



    Private Sub BotonClose_Click(sender As Object, e As EventArgs) Handles BotonClose.Click
        'Application.Exit()
        If MsgBox("Seguro desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Cerrar Sesion") = MsgBoxResult.Yes Then
            Me.Close()
            inicioSesion.Show()
        End If
    End Sub

    Private Sub BotonMIni_Click(sender As Object, e As EventArgs) Handles BotonMIni.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region


    Dim Gusuarios As New gestionUsuarios()
    Dim Gbuck As New buckup()

    Private Sub Ausuario_Click(sender As Object, e As EventArgs) Handles Ausuario.Click
        If Gusuarios IsNot Nothing AndAlso Not Gusuarios.IsDisposed Then
            Gusuarios.Close()
            Gusuarios.Dispose()
        End If
        Gusuarios = New gestionUsuarios()

        PanelUsuaio.Controls.Clear()
        Gusuarios.TopLevel = False
        Gusuarios.FormBorderStyle = FormBorderStyle.None
        Gusuarios.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gusuarios)
        Gusuarios.Show()
    End Sub

    Private Sub BotonBuckup_Click(sender As Object, e As EventArgs) Handles BotonBuckup.Click
        If Gbuck IsNot Nothing AndAlso Not Gbuck.IsDisposed Then
            Gbuck.Close()
            Gbuck.Dispose()
        End If
        Gbuck = New buckup()


        PanelUsuaio.Controls.Clear()
        Gbuck.TopLevel = False
        Gbuck.FormBorderStyle = FormBorderStyle.None
        Gbuck.Dock = DockStyle.Fill
        PanelUsuaio.Controls.Add(Gbuck)
        Gbuck.Show()
    End Sub



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


