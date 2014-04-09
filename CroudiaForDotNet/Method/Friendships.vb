Imports System.Text

Public Class Friendships
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Add user to follow list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.Friendships_Create, parameter))
    End Function

    ''' <summary>
    ''' Delete user from follow list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.Friendships_Destroy, parameter))
    End Function

    ''' <summary>
    ''' Show relation ship
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of RelationshipObject)
        Return New ResponseObject(Of RelationshipObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Friendships_Show, parameter))
    End Function

    ''' <summary>
    ''' Lookup relation ship
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Function Lookup(ByVal Ids As Decimal()) As ResponseObject(Of FriendShipLookupObjectList)
        Dim r As New RequestParam
        Dim sb As New StringBuilder
        For Each v As Decimal In Ids
            sb.Append("," & v.ToString)
        Next
        sb.Remove(0, 1)
        r("user_id") = sb.ToString
        Return New ResponseObject(Of FriendShipLookupObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Friendships_Lookup, r))
    End Function

    ''' <summary>
    ''' Lookup relation ship
    ''' </summary>
    ''' <param name="ScreenNames">Screennames</param>
    Public Function Lookup(ByVal ScreenNames As String()) As ResponseObject(Of FriendShipLookupObjectList)
        Dim r As New RequestParam
        Dim sb As New StringBuilder
        For Each v As String In ScreenNames
            sb.Append("," & v.ToString)
        Next
        sb.Remove(0, 1)
        r("screen_name") = sb.ToString
        Return New ResponseObject(Of FriendShipLookupObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Friendships_Lookup, r))
    End Function

    ''' <summary>
    ''' Get Friendslist of id type
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FriendsIds(ByVal parameter As RequestParam) As ResponseObject(Of FriendIdsList)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        If Not parameter.ContainsKey("cursor") Then
            parameter("cursor") = "-1"
        End If
        Return New ResponseObject(Of FriendIdsList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Friends_Ids, parameter))
    End Function

    ''' <summary>
    ''' Get Friendslist of user-object type
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FriendsList(ByVal parameter As RequestParam) As ResponseObject(Of FriendUserObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        If Not parameter.ContainsKey("cursor") Then
            parameter("cursor") = "-1"
        End If
        Return New ResponseObject(Of FriendUserObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Friends_List, parameter))
    End Function

    ''' <summary>
    ''' Get followerslist of id type
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FollowersIds(ByVal parameter As RequestParam) As ResponseObject(Of FriendIdsList)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        If Not parameter.ContainsKey("cursor") Then
            parameter("cursor") = "-1"
        End If
        Return New ResponseObject(Of FriendIdsList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Followers_Ids, parameter))
    End Function

    ''' <summary>
    ''' Get Followerslist of user-object type
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FollowersList(ByVal parameter As RequestParam) As ResponseObject(Of FriendUserObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        If Not parameter.ContainsKey("cursor") Then
            parameter("cursor") = "-1"
        End If
        Return New ResponseObject(Of FriendUserObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Followers_List, parameter))
    End Function

End Class
