Imports System.Configuration
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection = ConfigurationManager.AppSettings.Get("connection")
    End Sub
End Class
