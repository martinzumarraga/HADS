Public Class Hasiera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonErregistratu_Click(sender As Object, e As EventArgs) Handles ButtonErregistratu.Click
        Server.Transfer("Erregistroa.aspx", True)
    End Sub

    Protected Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Server.Transfer("login.aspx", True)
    End Sub
End Class