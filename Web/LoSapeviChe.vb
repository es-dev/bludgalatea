Imports System.Drawing
Imports System.Data

Imports Library
Imports ESD.Library


Public Class LoSapeviChe
    Inherits Library.TemplateForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'TODO: Add any initialization after the InitializeComponent call
    End Sub

   
    Private Sub htmlLoSapeviChe_Load(sender As Object, e As EventArgs) Handles htmlLoSapeviChe.Load
        Try
            Dim pathRoot = UtilityContainer.GetRootPath(Context)
            Dim pathFileContent = pathRoot + "LoSapeviChe.html"
            Dim reader = IO.File.OpenText(pathFileContent)
            Dim data = reader.ReadToEnd
            reader.Close()
            htmlLoSapeviChe.Html = data
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub
End Class
