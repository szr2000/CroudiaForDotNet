Imports System.Runtime.Serialization

<DataContract>
Public Class FriendShipLookupObject

    ''' <summary>
    ''' Connectionsを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="connections")>
    Public Property Connections As String()

    ''' <summary>
    ''' Idを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    ''' <summary>
    ''' Nameを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' スクリーンネームを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String
End Class

Public Class FriendShipLookupObjectList
    Inherits List(Of FriendShipLookupObject)
End Class