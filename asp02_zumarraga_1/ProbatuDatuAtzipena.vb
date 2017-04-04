Imports DatuAtzipenekoak.DatuAtzipena
Imports System.Data.SqlClient


Module ProbatuDatuAtzipena

    Sub Main()
        Konektatu()
        'ErabiltzaileaTxertatu("mzumarraga004@ikasle.ehu.eus", "Martin", "Zumarraga", "Galdera eskutua??", "erantzunaaa", 6, True, "123456")
        Dim emaitza As SqlDataReader = ErabiltzaileaLortu("mzumarraga004@ikasle.ehu.eus")
        'Dim emaitza As Integer = ErabiltzaileaEgiaztatu("mzumarraga004@ikasle.ehu.eus")
        'Dim emaitza As Integer = ErabiltzailearenPasahitzaAldatu("mzumarraga004@ikasle.ehu.eus", "pasahitzBerria")
        Console.WriteLine(emaitza.Read)

        While 1
        End While

        ItxiKonexioa()
    End Sub

End Module
