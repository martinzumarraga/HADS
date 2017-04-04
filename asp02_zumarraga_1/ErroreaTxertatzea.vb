Public Class ErroreaTxertatzea
    Inherits ApplicationException 
    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan da datu-basean txertaketa gauzatu.")
        MyBase.New(Mezua)
    End Sub
End Class
