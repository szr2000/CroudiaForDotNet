Imports System.Runtime.Serialization
Imports CroudiaForDotNet.CroudiaAccess
Imports System.Net

<DataContract>
Public Class OauthTokens

    ''' <summary>
    ''' ConsumerKey
    ''' </summary>
    Public Property ConsumerKey As String

    ''' <summary>
    ''' ConsumerSecret
    ''' </summary>
    Public Property ConsumerSecret As String

    ''' <summary>
    ''' AccessToken
    ''' </summary>
    <DataMember(Name:="access_token")>
    Public Property AccessToken As String

    ''' <summary>
    ''' TokenType
    ''' </summary>
    <DataMember(Name:="token_type")>
    Public Property TokenType As String

    ''' <summary>
    ''' ExpiresIn
    ''' </summary>
    <DataMember(Name:="expires_in")>
    Public Property ExpiresIn As Decimal

    ''' <summary>
    ''' RefreshToken
    ''' </summary>
    <DataMember(Name:="refresh_token")>
    Public Property RefreshToken As String

    Private LastUpdate As DateTime

    Public Sub New()
        If Not String.IsNullOrEmpty(AccessToken) And Not String.IsNullOrEmpty(RefreshToken) Then
            TokenRefresh()
        End If
    End Sub

    Friend Function PrepareAccess(ByVal Method As HttpMethod, ByVal EndPoint As String, Optional ByVal parameter As RequestParam = Nothing) As WebResponse
        If Method = HttpMethod.HttpGET Then
            Return GETAccess(EndPoint, Me, parameter)
        ElseIf Method = HttpMethod.HttpPOST Then
            Return POSTAccess(EndPoint, Me, parameter)
        ElseIf Method = HttpMethod.HttpPOSTMultipart Then
            Return MultiPartPOSTAccess(EndPoint, Me, parameter)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Generate Authorize Url
    ''' </summary>
    Public Function GenerateAuthorizeUrl() As Uri
        If String.IsNullOrEmpty(ConsumerKey) Or String.IsNullOrEmpty(ConsumerSecret) Then
            Throw New ArgumentException("ConsumerKey or ConsumerSecret!")
        End If
        Return New Uri(EndPoints.Oauth_Authorize & "?response_type=code&client_id=" & ConsumerKey)
    End Function

    ''' <summary>
    ''' Codeを使ってAccessTokenを取得します
    ''' </summary>
    ''' <param name="code">code</param>
    Public Function AuthToken(ByVal code As String) As Boolean
        Dim p As New RequestParam() From {
            {"grant_type", "authorization_code"}, _
            {"client_id", ConsumerKey}, _
            {"client_secret", ConsumerSecret}, _
            {"code", code}}
        Dim r As New ResponseObject(Of OauthTokens)(POSTAccess(EndPoints.Oauth_AccessToken, Me, p))
        If Not r.ResponseCode = 200 Then Return False
        Me.AccessToken = r.Objects.AccessToken
        Me.TokenType = r.Objects.TokenType
        Me.ExpiresIn = r.Objects.ExpiresIn
        Me.RefreshToken = r.Objects.RefreshToken
        LastUpdate = Now
        Return True
    End Function

    ''' <summary>
    ''' トークンをリフレッシュします
    ''' </summary>
    Public Function TokenRefresh() As Boolean
        Dim p As New RequestParam() From {
            {"grant_type", "refresh_token"}, _
            {"client_id", ConsumerKey}, _
            {"client_secret", ConsumerSecret}, _
            {"refresh_token", RefreshToken}}
        Me.AccessToken = ""
        Dim r As New ResponseObject(Of OauthTokens)(POSTAccess(EndPoints.Oauth_AccessToken, Me, p))
        If Not r.ResponseCode = 200 Then Return False
        Me.AccessToken = r.Objects.AccessToken
        Me.TokenType = r.Objects.TokenType
        Me.ExpiresIn = r.Objects.ExpiresIn
        Me.RefreshToken = r.Objects.RefreshToken
        LastUpdate = Now
        Return True
    End Function

    ''' <summary>
    ''' Timeline
    ''' </summary>
    Public ReadOnly Timeline As New Timeline(Me)

    ''' <summary>
    ''' Statuses
    ''' </summary>
    Public ReadOnly Statuses As New Statuses(Me)

    ''' <summary>
    ''' SecretMails
    ''' </summary>
    Public ReadOnly SecretMails As New SecretMails(Me)

    ''' <summary>
    ''' Users
    ''' </summary>
    Public ReadOnly Users As New Users(Me)

    ''' <summary>
    ''' Account
    ''' </summary>
    Public ReadOnly Account As New Account(Me)

    ''' <summary>
    ''' Friendships
    ''' </summary>
    Public ReadOnly Friendships As New Friendships(Me)

    ''' <summary>
    ''' Favorites
    ''' </summary>
    Public ReadOnly Favorites As New Favorites(Me)

    ''' <summary>
    ''' Trends
    ''' </summary>
    Public ReadOnly Trends As New Trends(Me)

    ''' <summary>
    ''' Searches
    ''' </summary>
    Public ReadOnly Searches As New Searches(Me)
End Class
