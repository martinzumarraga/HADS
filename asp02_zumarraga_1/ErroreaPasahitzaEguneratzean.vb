Public Class ErroreaPasahitzaEguneratzean
    Inherits ApplicationException '

    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan da pasahitza eguneratu.")
        MyBase.New(Mezua)
    End Sub
End Class
