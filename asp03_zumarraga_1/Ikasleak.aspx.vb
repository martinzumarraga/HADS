Public Class Ikasleak
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButtonLanGenerikoak_Click(sender As Object, e As EventArgs) Handles LinkButtonLanGenerikoak.Click
        Server.Transfer("IkasleLanGenerikoak.aspx", True)
    End Sub
End Class