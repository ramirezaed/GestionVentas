'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class MSsubscription_agents
    Public Property id As Integer
    Public Property publisher As String
    Public Property publisher_db As String
    Public Property publication As String
    Public Property subscription_type As Integer
    Public Property queue_id As String
    Public Property update_mode As Byte
    Public Property failover_mode As Boolean
    Public Property spid As Integer
    Public Property login_time As Date
    Public Property allow_subscription_copy As Boolean
    Public Property attach_state As Integer
    Public Property attach_version As Byte()
    Public Property last_sync_status As Nullable(Of Integer)
    Public Property last_sync_summary As String
    Public Property last_sync_time As Nullable(Of Date)
    Public Property queue_server As String

End Class
