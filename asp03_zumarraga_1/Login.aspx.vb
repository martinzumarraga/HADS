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
                Session("eposta") = email
                If erantzuna.Item("erabiltzaileMota").Equals("ik") Then
                    Server.Transfer("Erreg/Ikasleak/Ikasleak.aspx", True)
                Else
                    Server.Transfer("Erreg/Irakasleak/Irakasleak.aspx", True)
                End If
                ItxiKonexioa()
            Else
                LabelErrorea.Visible = True
                LabelErrorea.Text = "Pasahitza desegokia"
            End If
            End If
        erantzuna.Close()
    End Sub

    Protected Sub LinkButtonErregistratu_Click(sender As Object, e As EventArgs) Handles LinkButtonErregistratu.Click
        Server.Transfer("Erregistroa.aspx", True)
    End Sub

    Protected Sub LinkButtonPasahitzaAhaztu_Click(sender As Object, e As EventArgs) Handles LinkButtonPasahitzaAhaztu.Click
        Server.Transfer("PasahitzaBerreskuratu.aspx?erab", True)
    End Sub
End Class