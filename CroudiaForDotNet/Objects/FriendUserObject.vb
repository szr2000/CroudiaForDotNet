Imports System.Runtime.Serialization

<DataContract>
Public Class FriendUserObject
    ''' <summary>
    ''' NextCursorを返します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal

    ''' <summary>
    ''' ユーザーのリストを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="users")>
    Public Property Users As UserObjectList

    ''' <summary>
    ''' PreviousCursorを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal
End Class
