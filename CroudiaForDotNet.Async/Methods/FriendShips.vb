Public Class FriendShips
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Add user to follow list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Friendships.Create(parameter))
    End Function

    ''' <summary>
    ''' Delete user from follow list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Friendships.Destroy(parameter))
    End Function

    ''' <summary>
    ''' Show relation ship
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of RelationshipObject))
        Return Await Task.Run(Function() token.Friendships.Show(parameter))
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Async Function Lookup(ByVal Ids As Decimal()) As Task(Of ResponseObject(Of FriendShipLookupObjectList))
        Return Await Task.Run(Function() token.Friendships.Lookup(Ids))
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Async Function Lookup(ByVal ScreenNames As String()) As Task(Of ResponseObject(Of FriendShipLookupObjectList))
        Return Await Task.Run(Function() token.Friendships.Lookup(ScreenNames))
    End Function

    ''' <summary>
    ''' FriendsIds
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FriendsIds(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendIdsList))
        Return Await Task.Run(Function() token.Friendships.FriendsIds(parameter))
    End Function

    ''' <summary>
    ''' FriendsList
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FriendsList(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendUserObject))
        Return Await Task.Run(Function() token.Friendships.FriendsList(parameter))
    End Function

    ''' <summary>
    ''' FollowersIds
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FollowersIds(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendIdsList))
        Return Await Task.Run(Function() token.Friendships.FollowersIds(parameter))
    End Function

    ''' <summary>
    ''' FollowersList
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FollowersList(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendUserObject))
        Return Await Task.Run(Function() token.Friendships.FollowersList(parameter))
    End Function
End Class
