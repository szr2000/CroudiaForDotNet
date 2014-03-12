Imports System.Runtime.Serialization
<DataContract>
Public Class SourceObject

    ''' <summary>
    ''' クライアント名を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' クライアントのurlを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="url")>
    Public Property url As String
End Class
