Imports System.Globalization

Friend Module DatetimeParser
    Friend Function Parse(ByVal str As String) As DateTime
        If String.IsNullOrEmpty(str) Then Return New DateTime()
        Return DateTime.ParseExact(str, "ddd, dd MMM yyyy HH:mm:ss zzzz", CultureInfo.InvariantCulture)
    End Function
End Module
