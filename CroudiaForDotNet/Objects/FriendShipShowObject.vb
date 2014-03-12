Imports System.Runtime.Serialization

<DataContract>
Public Class RelationshipObject

    ''' <summary>
    ''' Relationship
    ''' </summary>
    <DataMember(Name:="relationship")>
    Public Property Relationship As FriendShipShowObject
End Class

<DataContract>
Public Class FriendShipShowObject

    ''' <summary>
    ''' Sourceを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="source")>
    Public Property Source As FriendShipShowSource

    ''' <summary>
    ''' Targetを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="target")>
    Public Property Target As FriendShipShowTarget
End Class

<DataContract>
Public Class FriendShipShowSource

    ''' <summary>
    ''' Blockingを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="blocking")>
    Public Property Blocking As Boolean

    ''' <summary>
    ''' フォローされているかを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="followed_by")>
    Public Property FollowedBy As Boolean

    ''' <summary>
    ''' フォローしてるかを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="following")>
    Public Property Following As Boolean

    ''' <summary>
    ''' Idを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' IdのString型を取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="id_str")>
    Public Property IdStr As String

    ''' <summary>
    ''' スクリーンネームを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String
End Class

<DataContract>
Public Class FriendShipShowTarget

    ''' <summary>
    ''' フォローされているかを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="followed_by")>
    Public Property FollowedBy As Boolean

    ''' <summary>
    ''' フォローしてるかを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="following")>
    Public Property Following As Boolean

    ''' <summary>
    ''' Idを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' IdのString型を取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="id_str")>
    Public Property IdStr As String

    ''' <summary>
    ''' スクリーンネームを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String
End Class