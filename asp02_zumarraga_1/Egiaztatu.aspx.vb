Imports System.Net
Imports System.Data.SqlClient
Imports DatuAtzipenekoak.DatuAtzipena

Public Class Egiaztatu
    Inherits System.Web.UI.Page
    ' Dim request As WebRequest
    Dim erabiltzailea As String
    Dim egiastatzeZenbakia As Long
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Konektatu()
        erabiltzailea = Request.QueryString("erab")
        egiastatzeZenbakia = Request.QueryString("egZenb")
        Dim erantzuna As SqlDataReader = ErabiltzaileaLortu(erabiltzailea)
        If erantzuna.Read Then
            If erantzuna.Item("egiaztatzeZenbakia") Then
                erantzuna.Close()
                ErabiltzaileaEgiaztatu(erabiltzailea)
            End If
        Else
            Label1.Text = "Ezin izan da erabiltzailea egiaztatu"
        End If

    End Sub

    Protected Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Server.Transfer("Login.aspx", True)
    End Sub
End Class