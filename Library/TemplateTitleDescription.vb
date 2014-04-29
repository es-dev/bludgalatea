Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

Public Class TemplateTitleDescription
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
            lblTitle.Text = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private _templateDescription As String = Nothing
    Public Property TemplateDescription As String
        Get
            Return _templateDescription
        End Get
        Set(value As String)
            _templateDescription = value
            SetDescription(value)
        End Set
    End Property

    Private Sub SetDescription(value As String)
        Try
            lblDescription.Text = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub
End Class
