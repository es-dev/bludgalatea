Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common
Imports ESD.Library

Public Class TemplateHtml



    Private _html As String = Nothing
    Public Property Html As String
        Get
            Return _html
        End Get
        Set(value As String)
            _html = value
            SetHTMLBox(_html)

        End Set
    End Property

    Private Sub SetHTMLBox(html As String)
        Try
            htmlBox.Html = html
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private _url As String = Nothing
    Public Property Url As String
        Get
            Return _url
        End Get
        Set(value As String)
            _url = value
            SetUrl(_url)

        End Set
    End Property

    Private Sub SetUrl(_url As String)
        Try
            htmlBox.Url = _url
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

End Class
