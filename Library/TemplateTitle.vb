Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

Public Class TemplateTitle
    Private _templateTitle As String = Nothing
    Public Property TemplateTitle As String
        Get
            Return _templateTitle
        End Get
        Set(value As String)
            _templateTitle = value
            SetTitle(value)
        End Set
    End Property

    Private Sub SetTitle(value As String)
        Try
            lblTitolo.Text = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

End Class
