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
    Public ReadOnly Property AsOf As DateTime
        Get
            Return DatetimeParser.Parse(as_of)
        End Get
    End Property

    <DataMember(Name:="as_of")>
    Private Property as_of As String

    ''' <summary>
    ''' ささやいた日時を取得します
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property

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