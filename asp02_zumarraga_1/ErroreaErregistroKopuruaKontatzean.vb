Public Class ErroreaErregistroKopuruaKontatzean
    Inherits ApplicationException

    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan da erregistro kopurua kontatu.")
        MyBase.New(Mezua)
    End Sub
End Class
