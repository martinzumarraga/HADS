Imports DatuAtzipenekoak.DatuAtzipena

Public Class Erregistroa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Konektatu()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonErregistroa.Click
        Dim email As String = TextBoxEmail.Text
        Dim izena As String = TextBoxIzena.Text
        Dim abizena As String = TextBoxAbizena.Text
        Dim galdera As String = TextBoxgalderaEskutua.Text
        Dim erantzuna As String = TextBoxErantzuna.Text
        Dim pasahitza As String = TextBoxPasahitza.Text
        Dim errorea As Boolean = False
        If email = "" Then
            LabelErroreaEmail.Text = "Bete email"
            LabelErroreaEmail.Visible = True
            errorea = True
        Else
            Dim reader = ErabiltzaileaLortu(email)
            If reader.Read Then
                LabelErroreaEmail.Text = "Email hau jada badago"
                LabelErroreaEmail.Visible = True
                errorea = True
            Else
                LabelErroreaEmail.Visible = False
            End If
            reader.Close()
        End If

        If izena = "" Then
            LabelErrorIzena.Visible = True
            errorea = True
        Else
            LabelErrorIzena.Visible = False
        End If
        If abizena = "" Then
            LabelErrorAbizena.Visible = True
            errorea = True
        Else
            LabelErrorAbizena.Visible = False
        End If
        If galdera = "" Then
            LabelErrorGaldera.Visible = True
            errorea = True
        Else
            LabelErrorGaldera.Visible = False
        End If
        If erantzuna = "" Then
            LabelErrorErantzuna.Visible = True
            errorea = True
        Else
            LabelErrorErantzuna.Visible = False
        End If
        If pasahitza = "" Then
            LabelErrorPasahitza.Visible = True
            errorea = True
        Else
            LabelErrorPasahitza.Visible = False
        End If
        If Not errorea Then
            Randomize()
            Dim egiaztatzeZenb As Long = CLng(Rnd() * 9000000) + 1000000
            ErabiltzaileaTxertatu(email, izena, abizena, galdera, erantzuna, egiaztatzeZenb, False, pasahitza)
            ItxiKonexioa()
            LabelMezua.Visible = True
            HyperLink1.Visible = True
            HyperLink1.NavigateUrl = "http://localhost:55793/Egiaztatu.aspx?erab=" & email & "&Zenb=" & egiaztatzeZenb
        End If
    End Sub

End Class