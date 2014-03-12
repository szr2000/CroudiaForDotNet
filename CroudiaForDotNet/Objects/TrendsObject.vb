Imports System.Runtime.Serialization

<DataContract>
Public Class TrendsObject

    ''' <summary>
    ''' トレンドのテキスト
    ''' </summary>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' トレンドのクエリ
    ''' </summary>
    <DataMember(Name:="query")>
    Public Property Query As String
End Class

<DataContract>
Public Class TrendsObjectList

    ''' <summary>
    ''' asof
    ''' </summary>
    Public Function AsOf() As DateTime
        Return DatetimeParser.Parse(as_of)
    End Function

    <DataMember(Name:="as_of")>
    Private Property as_of As String

    ''' <summary>
    ''' ささやいた日時を取得します
    ''' </summary>
    ''' <remarks></remarks>
    Public Function CreatedAt() As DateTime
        Return DatetimeParser.Parse(cat)
    End Function

    <DataMember(Name:="created_at")>
    Private Property cat As String

    ''' <summary>
    ''' 位置情報
    ''' </summary>
    <DataMember(Name:="locations")>
    Public Property Locations As LocationObject

    ''' <summary>
    ''' トレンドのリスト
    ''' </summary>
    <DataMember(Name:="trends")>
    Public Property Trends As List(Of TrendsObject)
End Class

<DataContract>
Public Class LocationObject

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="woeid")>
    Public Property Woeid As Decimal?
End Class