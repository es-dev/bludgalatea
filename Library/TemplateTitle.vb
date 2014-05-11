Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common
Imports ESD.Library

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


    'Private _templatePdf As Gizmox.WebGUI.Common.Resources. = Nothing
    'Public Property TemplatePdf As Gizmox.WebGUI.Common.Resources.FileHandle
    '    Get
    '        Return _templatePdf
    '    End Get
    '    Set(value As Gizmox.WebGUI.Common.Resources.FileHandle)
    '        _templatePdf = value
    '        _SetPdf(value)
    '    End Set
    'End Property

    'Private Sub _SetPdf(value As Gizmox.WebGUI.Common.Resources.FileHandle)
    '    Try
    '        If (filePDF IsNot Nothing) Then
    '            filePDF.Image = value
    '        End If
    '    Catch ex As Exception
    '        ESD.Library.UtilityContainer.ErrorLog(ex)
    '    End Try
    'End Sub


    'Private Sub imgPdf_Click(sender As Object, e As EventArgs) Handles imgPdf.Click
    '    Try
    '        Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
    '        Dim url = urlRoot + "/IoCresco.aspx"
    '        Context.Redirect(url)
    '    Catch ex As Exception
    '        UtilityContainer.ErrorLog(ex)
    '    End Try
    'End Sub

End Class
