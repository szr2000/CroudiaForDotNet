Imports System.Runtime.Serialization.Json
Imports System.IO
Imports System.Text
Imports System.Net

Public Class ResponseObject(Of T)
    Private parser As New DataContractJsonSerializer(GetType(T))

    Public Sub New(ByVal s As WebResponse)
        ResponsedText = New StreamReader(s.GetResponseStream, Text.Encoding.UTF8).ReadToEnd
        ResponseCode = CType(s, HttpWebResponse).StatusCode
        If Not String.IsNullOrEmpty(ResponsedText) Then
            'Parse
            Objects = CType(parser.ReadObject(New MemoryStream(Encoding.UTF8.GetBytes(ResponsedText))), T)
        End If
    End Sub

    ''' <summary>
    ''' The json of responsed.
    ''' </summary>
    Public Property ResponsedText As String

    ''' <summary>
    ''' The object of parsed data.
    ''' </summary>
    Public Property Objects As T

    ''' <summary>
    ''' The number of http status.
    ''' </summary>
    Public Property ResponseCode As Decimal?
End Class