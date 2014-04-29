Imports System.Drawing
Imports System.Data

Imports Library
Imports ESD.Library


Public Class ChiPuoDonare
    Inherits Library.TemplateForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'TODO: Add any initialization after the InitializeComponent call
    End Sub

    Private Sub ChiPuoDonare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pathRoot = UtilityContainer.GetRootPath(Context)
            Dim pathFileContent = pathRoot + "chiPuoDonare.html"
            Dim reader = IO.File.OpenText(pathFileContent)
            Dim data = reader.ReadToEnd
            reader.Close()
            htmlChiPuoDonare.Html = data
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

End Class
