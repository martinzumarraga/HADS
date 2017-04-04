Imports DatuAtzipenekoak.DatuAtzipena
Imports System.Data.SqlClient

Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Konektatu()
    End Sub

    Protected Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim email As String = TextBoxEmail.Text
        Dim pasahitza As String = TextBoxPasahitza.Text
        Dim erantzuna As SqlDataReader = ErabiltzaileaLortu(email)

        If Not erantzuna.Read Then
            LabelErrorea.Visible = True
            LabelErrorea.Text = "Eposta desegokia"
        Else

            If erantzuna.Item("pasahitza").Equals(TextBoxPasahitza.Text) Then
                ItxiKonexioa()
                Server.Transfer("Erreg/Menua.aspx", True)
            Else
                LabelErrorea.Visible = True
                LabelErrorea.Text = "Pasahitza desegokia"
            End If
        End If
    End Sub

    Protected Sub LinkButtonErregistratu_Click(sender As Object, e As EventArgs) Handles LinkButtonErregistratu.Click
        Server.Transfer("Erregistroa.aspx", True)
    End Sub

    Protected Sub LinkButtonPasahitzaAhaztu_Click(sender As Object, e As EventArgs) Handles LinkButtonPasahitzaAhaztu.Click
        Server.Transfer("PasahitzaBerreskuratu.aspx?erab", True)
    End Sub
End Class