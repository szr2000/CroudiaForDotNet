Public Class AsyncTokens

    Public Sub New(ByVal t As OauthTokens)
        Account = New Account(t)
        Favorites = New Favorites(t)
        FriendShips = New FriendShips(t)
        Searches = New Searches(t)
        SecretMails = New SecretMails(t)
        Statuses = New Statuses(t)
        Timeline = New Timeline(t)
        Trends = New Trends(t)
        Users = New Users(t)
    End Sub

    Public ReadOnly Account As Account

    Public ReadOnly Favorites As Favorites

    Public ReadOnly FriendShips As FriendShips

    Public ReadOnly Searches As Searches

    Public ReadOnly SecretMails As SecretMails

    Public ReadOnly Statuses As Statuses

    Public ReadOnly Timeline As Timeline

    Public ReadOnly Trends As Trends

    Public ReadOnly Users As Users
End Class
