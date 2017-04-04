Imports DatuAtzipenekoak.DatuAtzipena
Imports System.Data.SqlClient

Public Class IkasleLanGenerikoak
    Inherits System.Web.UI.Page
    Private Shared dataIrakasgaiak As SqlDataAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Konektatu()
        Dim dsIrakasgaiak As New DataSet
        Dim data As SqlDataAdapter = IkasleaMatrikulatutakoIrakasgaienEgokitzaileaEskuratu("nerea@ikasle.ehu.es") 'Session("eposta"))
        Try
            data.Fill(dsIrakasgaiak, "irakasgaiak")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DropDownListIrakasgaiak.DataSource = dsIrakasgaiak.Tables("irakasgaiak")
        DropDownListIrakasgaiak.DataTextField = "irakasgaikodea"
        DropDownListIrakasgaiak.DataBind()

        dataIrakasgaiak = UstiapenekoLanGenerikoaenEgokitzaileaEskuratu()
    End Sub

    Protected Sub DropDownListIrakasgaiak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListIrakasgaiak.SelectedIndexChanged

    End Sub
End Class