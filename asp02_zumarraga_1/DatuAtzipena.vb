Imports System.Data.SqlClient

Public Class DatuAtzipena

    Private Shared connection As SqlConnection
    Private Shared command As SqlCommand

    Private Sub New()

    End Sub

    Public Shared Sub Konektatu()
        Dim strconSGTA_DB_Erabiltzaileak As String = "Data Source=158.227.106.20; Initial Catalog=SGTA16_DB_Erabiltzaileak;Integrated Security=False;User ID=SGTA16;Password=Zadorra;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
        Try
            connection = New SqlConnection(strconSGTA_DB_Erabiltzaileak)
            connection.Open()
        Catch ex As Exception
            Throw New ErroreaKonektatzean()
        End Try
    End Sub

    Public Shared Sub ItxiKonexioa()
        connection.Close()
    End Sub

    Public Shared Function ErabiltzaileaTxertatu(ByVal strEmail As String, ByVal strIzena As String, ByVal strAbizena As String,
                                                 ByVal strGalderaEzkutua As String, ByVal strErantzuna As String,
                                                 ByVal intEgiaztatzeZenbakia As Integer, ByVal boolEgiaztatua As Boolean, ByVal strPasahitza As String) As Integer
        'txertatutako erregistro kopurua (Integer) itzultzen du emaitzatzat
        Dim strSQL As String = "INSERT INTO Erabiltzaileak (email,izena,abizena,galderaEzkutua,erantzuna,egiaztatzeZenbakia,egiaztatua,pasahitza) VALUES ('" & strEmail & "','" & strIzena & "','" & strAbizena & "','" & strGalderaEzkutua & "','" & strErantzuna & "'," & intEgiaztatzeZenbakia & ",'" & boolEgiaztatua & "','" & strPasahitza & "')"
        command = New SqlCommand(strSQL, connection)
        Try
            Return command.ExecuteNonQuery() 'saiatu INSERT-a  exekutatzen()
        Catch
            Throw New ErroreaTxertatzea()
        End Try
    End Function

    Public Shared Function ErabiltzaileaLortu(ByVal strEmail As String) As SqlDataReader
        Try
            Dim strSQL As String = "SELECT * FROM Erabiltzaileak WHERE email='" & strEmail & "'"
            command = New SqlCommand(strSQL, connection)
            Dim reader = command.ExecuteReader()
            Return (reader)
        Catch ex As Exception
            Throw New ErroreaErabiltzaileaLortzean()
        End Try

    End Function

    Public Shared Function ErabiltzaileaEgiaztatu(ByVal strEmail As String) As Integer
        Dim strSQL As String
        Try
            strSQL = "UPDATE Erabiltzaileak SET egiaztatua='true' WHERE email='" & strEmail & "'"
            command = New SqlCommand(strSQL, connection)
            Dim reader = command.ExecuteReader()
            reader.Close()

        Catch ex As Exception
            Throw New ErroreaEgiaztatuEguneratzean()
        End Try
        Try
            strSQL = "SELECT Count(*) FROM Erabiltzaileak"
            command = New SqlCommand(strSQL, connection)
            Return (command.ExecuteScalar)
        Catch ex As Exception
            Throw New ErroreaErregistroKopuruaKontatzean()
        End Try

    End Function

    Public Shared Function ErabiltzailearenPasahitzaAldatu(ByVal strEmail As String, ByVal strPasahitza As String) As Integer
        Dim strSQL As String
        Try
            strSQL = "UPDATE Erabiltzaileak SET pasahitza='" & strPasahitza & "' WHERE email='" & strEmail & "'"
            command = New SqlCommand(strSQL, connection)
            Dim reader = command.ExecuteReader()
            reader.Close()
        Catch ex As Exception
            Throw New ErroreaPasahitzaEguneratzean()
        End Try
        Try
            command.ResetCommandTimeout()
            strSQL = "SELECT Count(*) FROM Erabiltzaileak"
            command = New SqlCommand(strSQL, connection)
            Return (command.ExecuteScalar)
        Catch ex As Exception
            Throw New ErroreaErregistroKopuruaKontatzean()
        End Try

    End Function


End Class
