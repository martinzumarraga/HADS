Public Class ErroreaEgiaztatuEguneratzean
    Inherits ApplicationException

    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan da egiaztatu atributua eguneratu.")
        MyBase.New(Mezua)
    End Sub
End Class
