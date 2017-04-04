Imports DatuAtzipenekoak.DatuAtzipena
Imports System.Data.SqlClient

Public Class PasahitzaBerreskuratu
    Inherits System.Web.UI.Page
    Dim erantzuna As SqlDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Server.Transfer("Login.aspx", True)
    End Sub

    Protected Sub ButtonEgiaztatu_Click(sender As Object, e As EventArgs) Handles ButtonEgiaztatu.Click
        If erantzuna.Item("erantzuna").Equals(TextBoxErantzuna.Text) Then
            LabelPasahitza.Text = "Zure pasahitza:  " & erantzuna.Item("pasahitza")
            LabelPasahitza.Visible = True
        Else
            LabelPasahitza.Visible = False
            LabelPasahitza.Visible = "Erantzun desegokia"
        End If
    End Sub

    Protected Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Dim email As String = TextBoxEmail.Text
        If email = "" Then
            LabelErroreaEmail.Text = "Bete email"
            LabelErroreaEmail.Visible = True
            LabelGalderaText.Visible = False
            LabelErantzuna.Visible = False
            LabelGalderaText.Visible = False
            LabelPasahitza.Visible = False
        Else
            erantzuna = ErabiltzaileaLortu(email)

            If erantzuna.Read Then
                LabelErroreaEmail.Visible = False
                LabelGalderaText.Visible = True
                LabelErantzuna.Visible = True
                LabelGalderaText.Visible = True
                LabelGaldera.Text = erantzuna.Item("galdera")
            Else
                LabelGalderaText.Visible = False
                LabelErantzuna.Visible = False
                LabelGalderaText.Visible = False
                LabelPasahitza.Visible = False
            End If
            erantzuna.Close()

        End If
    End Sub
End Class