Imports System.Drawing
Imports System.Data

Imports Library
Imports ESD.Library


Public Class Homepage
    Inherits Library.TemplateForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'TODO: Add any initialization after the InitializeComponent call
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pathRoot = UtilityContainer.GetRootPath(Context)
            Dim pathFileContent = pathRoot + "Homepage.html"
            Dim reader = IO.File.OpenText(pathFileContent)
            Dim data = reader.ReadToEnd
            reader.Close()
            Dim urlRoot = UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/homepage.html"
            htmlHomepage.Url = url
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

End Class
