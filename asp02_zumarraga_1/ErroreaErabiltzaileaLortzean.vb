Public Class ErroreaErabiltzaileaLortzean
    Inherits ApplicationException 'aplikazio-salbuespenen klasea
    'eraikitzailea birdefinitu (gurasoarenaz baliatuz)
    Public Sub New _
    (Optional ByVal Mezua As String = _
    "Errorea: Ezin izan da erabiltzailea lortu.")
        MyBase.New(Mezua) 'gurasoaren eraikitzaileari deituz
    End Sub
End Class
