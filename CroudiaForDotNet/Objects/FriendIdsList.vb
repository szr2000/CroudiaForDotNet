Imports System.Runtime.Serialization

<DataContract>
Public Class FriendIdsList

    ''' <summary>
    ''' NextCursorを返します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal

    ''' <summary>
    ''' Idの配列を返します
    ''' </summary>
    <DataMember(Name:="ids")>
    Public Property Ids As Decimal()

    ''' <summary>
    ''' PreviousCursorを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal
End Class
