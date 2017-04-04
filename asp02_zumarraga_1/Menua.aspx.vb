Public Class Menua
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonPasahitzaAldatu_Click(sender As Object, e As EventArgs) Handles ButtonPasahitzaAldatu.Click
        Server.Transfer("PasahitzaAldatu.aspx", True)
    End Sub

    Protected Sub ButtonIrten_Click(sender As Object, e As EventArgs) Handles ButtonIrten.Click
        Server.Transfer("Amaiera.aspx", True)
    End Sub
End Class