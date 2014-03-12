Imports System.Runtime.Serialization

<DataContract>
Public Class UserObject

    ''' <summary>
    ''' アカウント登録日を取得します
    ''' </summary>
    ''' <remarks></remarks>
    Public Function CreatedAt() As DateTime
        Return DatetimeParser.Parse(cat)
    End Function

    <DataMember(Name:="created_at")>
    Private Property cat As String

    ''' <summary>
    ''' 紹介文を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="description")>
    Public Property Description As String

    ''' <summary>
    ''' そのユーザーのお気に入り数を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="favorites_count")>
    Public Property FavoritesCount As Decimal?

    ''' <summary>
    ''' 保留中のフォローリクエストの有無
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="follow_request_sent")>
    Public Property IsFollowRequestSent As Boolean?

    ''' <summary>
    ''' フォロワー数を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="followers_count")>
    Public Property FollowersCount As Decimal?

    ''' <summary>
    ''' 対象ユーザーをフォローしているかを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="following")>
    Public Property IsFollowing As Boolean?

    ''' <summary>
    ''' フレンド数を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="friends_count")>
    Public Property FriendsCount As Decimal?

    ''' <summary>
    ''' ユーザーidを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    ''' <summary>
    ''' 位置情報を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="location")>
    Public Property Location As String

    ''' <summary>
    ''' ユーザー名を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' プロフィール画像のurlを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="profile_image_url_https")>
    Public Property ProfileImageHttps As String

    ''' <summary>
    ''' カバー画像のurlを取得します
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="cover_image_url_https")>
    Public Property CoverImageUrlHttps As String

    ''' <summary>
    ''' 非公開ユーザーかを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="protected")>
    Public Property IsProtected As Boolean?

    ''' <summary>
    ''' スクリーンネームを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

    ''' <summary>
    ''' ささやき回数を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="statuses_count")>
    Public Property StatusesCount As Decimal?

    ''' <summary>
    ''' ユーザーのurlを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="url")>
    Public Property Url As String
End Class

Public Class UserObjectList
    Inherits List(Of UserObject)
End Class