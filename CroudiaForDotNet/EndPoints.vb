Friend Module EndPoints
    'Croudia
    Friend ReadOnly Croudia_API As String = "https://api.croudia.com/"
    'Oauth
    Friend ReadOnly Oauth_Authorize As String = Croudia_API & "oauth/authorize"
    Friend ReadOnly Oauth_AccessToken As String = Croudia_API & "oauth/token"
    'Timeline
    Friend ReadOnly Statuses_Public_Timeline As String = Croudia_API & "statuses/public_timeline.json"
    Friend ReadOnly Statuses_Home_Timeline As String = Croudia_API & "statuses/home_timeline.json"
    Friend ReadOnly Statuses_User_Timeline As String = Croudia_API & "statuses/user_timeline.json"
    Friend ReadOnly Statuses_Mentions As String = Croudia_API & "statuses/mentions.json"
    'Statuses
    Friend ReadOnly Statuses_Update As String = Croudia_API & "statuses/update.json"
    Friend ReadOnly Statuses_Update_With_Media As String = Croudia_API & "statuses/update_with_media.json"
    Friend ReadOnly Statuses_Destroy_Id As String = Croudia_API & "statuses/destroy/{0}.json"
    Friend ReadOnly Statuses_Show_Id As String = Croudia_API & "statuses/show/{0}.json"
    Friend ReadOnly Statuses_Spread_Id As String = Croudia_API & "statuses/spread/{0}.json"
    Friend ReadOnly Statuses_Share As String = Croudia_API & "statuses/share.json"
    Friend ReadOnly Statuses_Share_With_Media As String = Croudia_API & "statuses/share_with_media.json"
    'SecretMails
    Friend ReadOnly SecretMails As String = Croudia_API & "secret_mails.json"
    Friend ReadOnly SecretMails_Sent As String = Croudia_API & "secret_mails/sent.json"
    Friend ReadOnly SecretMails_New As String = Croudia_API & "secret_mails/new.json"
    Friend ReadOnly SecretMails_New_With_Media As String = Croudia_API & "secret_mails/new_with_media.json"
    Friend ReadOnly SecretMails_Destroy_Id As String = Croudia_API & "secret_mails/destroy/{0}.json"
    Friend ReadOnly SecretMails_Show_Id As String = Croudia_API & "secret_mails/show/{0}.json"
    'Users
    Friend ReadOnly Users_Show As String = Croudia_API & "users/show.json"
    Friend ReadOnly Users_Lookup As String = Croudia_API & "users/lookup.json"
    'Account
    Friend ReadOnly Account_Verify_Credentials As String = Croudia_API & "account/verify_credentials.json"
    Friend ReadOnly Account_Update_Profile_Image As String = Croudia_API & "account/update_profile_image.json"
    Friend ReadOnly Account_Update_Cover_Image As String = Croudia_API & "account/update_cover_image.json"
    Friend ReadOnly Account_Update_Profile As String = Croudia_API & "account/update_profile.json"
    'Friendships
    Friend ReadOnly Friendships_Create As String = Croudia_API & "friendships/create.json"
    Friend ReadOnly Friendships_Destroy As String = Croudia_API & "friendships/destroy.json"
    Friend ReadOnly Friendships_Show As String = Croudia_API & "friendships/show.json"
    Friend ReadOnly Friendships_Lookup As String = Croudia_API & "friendships/lookup.json"
    Friend ReadOnly Friends_Ids As String = Croudia_API & "friends/ids.json"
    Friend ReadOnly Friends_List As String = Croudia_API & "friends/list.json"
    Friend ReadOnly Followers_Ids As String = Croudia_API & "followers/ids.json"
    Friend ReadOnly Followers_List As String = Croudia_API & "followers/list.json"
    'Favorites
    Friend ReadOnly Favorites As String = Croudia_API & "favorites.json"
    Friend ReadOnly Favorites_Create_Id As String = Croudia_API & "favorites/create/{0}.json"
    Friend ReadOnly Favorites_Destroy_Id As String = Croudia_API & "favorites/destroy/{0}.json"
    'Trends
    Friend ReadOnly Trends_Place As String = Croudia_API & "trends/place.json"
    'Searches
    Friend ReadOnly Search_Voices As String = Croudia_API & "search/voices.json"
    Friend ReadOnly Users_Search As String = Croudia_API & "users/search.json"
    Friend ReadOnly Profile_Search As String = Croudia_API & "profile/search.json"
    Friend ReadOnly Search_Favorites As String = Croudia_API & "search/favorites.json"
End Module
