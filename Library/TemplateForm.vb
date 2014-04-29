Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common
Imports ESD.Library

Public Class TemplateForm



    Private Sub linkChiSiamo_Click(sender As Object, e As EventArgs) Handles linkChiSiamo.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/ChiSiamo.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub lnkHome_Click(sender As Object, e As EventArgs) Handles lnkHome.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/Homepage.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub lnkIoCresco_Click(sender As Object, e As EventArgs) Handles lnkIoCresco.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/IoCresco.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub linkPercheDonare_Click(sender As Object, e As EventArgs) Handles linkPercheDonare.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/PercheDonare.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub linkChiPuoDonare_Click(sender As Object, e As EventArgs) Handles linkChiPuoDonare.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/ChiPuoDonare.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub linkComeDonare_Click(sender As Object, e As EventArgs) Handles linkComeDonare.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/ComeDonare.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub lnkDomandeFrequenti_Click(sender As Object, e As EventArgs) Handles lnkDomandeFrequenti.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/DomandeFrequenti.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub lnkLosapevi_Click(sender As Object, e As EventArgs) Handles lnkLosapevi.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/LoSapeviChe.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub

    Private Sub lnkEventi_Click(sender As Object, e As EventArgs) Handles lnkEventi.Click
        Try
            Dim urlRoot = ESD.Library.UtilityContainer.GetRootUrl(Context)
            Dim url = urlRoot + "/EventiNews.aspx"
            Context.Redirect(url)
        Catch ex As Exception
            UtilityContainer.ErrorLog(ex)
        End Try
    End Sub
End Class
