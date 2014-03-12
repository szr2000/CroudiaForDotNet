Imports System.Runtime.Serialization

<DataContract>
Public Class SearchObject

    ''' <summary>
    ''' ステータスを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="statuses")>
    Public Property Statuses As StatusObjectList

    ''' <summary>
    ''' メタデータを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="serach_metadata")>
    Public Property Metadata As SearchMetadata
End Class

<DataContract>
Public Class SearchMetadata

    ''' <summary>
    ''' 検索に要した時間を返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="completed_in")>
    Public Property CompletedIn As Decimal

    ''' <summary>
    ''' MaxIdを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="max_id")>
    Public Property MaxId As Decimal

    ''' <summary>
    ''' Sinceidを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="since_id")>
    Public Property SinceId As Decimal

    ''' <summary>
    ''' Countを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="count")>
    Public Property Count As Decimal

    ''' <summary>
    ''' 次の検索結果を得るためのクエリ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="next_results")>
    Public Property NextResults As String

    ''' <summary>
    ''' クエリを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="query")>
    Public Property Query As String

    ''' <summary>
    ''' 最新の検索結果を得るためのクエリを返します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="refresh_url")>
    Public Property RefreshUrl As String
End Class
