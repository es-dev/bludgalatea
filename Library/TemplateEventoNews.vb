Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

Public Class TemplateEventoNews

    Private _templateImage As Gizmox.WebGUI.Common.Resources.ImageResourceHandle = Nothing
    Public Property TemplateImage As Gizmox.WebGUI.Common.Resources.ImageResourceHandle
        Get
            Return _templateImage
        End Get
        Set(value As Gizmox.WebGUI.Common.Resources.ImageResourceHandle)
            _templateImage = value
            _SetImage(value)
        End Set
    End Property
 
    Private Sub _SetImage(value As Gizmox.WebGUI.Common.Resources.ImageResourceHandle)
        Try
            If (imgEvento IsNot Nothing) Then
                imgEvento.Image = value
            End If
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
            lblDescrizione.Text = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private _templateWidthDescrizione As Integer = 0
    Public Property TemplateWidthDescrizione As Integer
        Get
            Return _templateWidthDescrizione
        End Get
        Set(value As Integer)
            _templateWidthDescrizione = value
            SetWidthDescrizione(value)
        End Set
    End Property

    Private Sub SetWidthDescrizione(value As Integer)
        Try
            lblDescrizione.Width = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private _templateWidthImage As Integer
    Public Property TemplateWidthImage As Integer
        Get
            Return _templateWidthImage
        End Get
        Set(value As Integer)
            _templateWidthImage = value
            SetWidthImage(value)
        End Set
    End Property

    Private Sub SetWidthImage(value As Integer)
        Try
            imgEvento.Width = value
        Catch ex As Exception
            ESD.Library.UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

End Class
