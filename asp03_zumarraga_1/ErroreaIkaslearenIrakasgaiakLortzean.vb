Public Class ErroreaIkaslearenIrakasgaiakLortzean

    Inherits ApplicationException '

    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan dira ikaslearen irakasgaiak eskuratu.")
        MyBase.New(Mezua)
    End Sub
End Class
