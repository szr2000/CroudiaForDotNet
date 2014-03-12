Imports System.Runtime.Serialization

<DataContract>
Public Class EntitiesObject

    ''' <summary>
    ''' 投稿に含まれるメディア情報を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="media")>
    Public Property Media As MediaEntities

End Class
<DataContract>
Public Class MediaEntities

    ''' <summary>
    ''' 画像のurlを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="media_url_https")>
    Public Property MediaUrlHttps As String

    ''' <summary>
    ''' メディアのタイプを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="type")>
    Public Property Type As String
End Class
