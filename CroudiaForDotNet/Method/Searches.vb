Public Class Searches
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Search whispers of query
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Voices(ByVal parameter As RequestParam) As ResponseObject(Of SearchObject)
        Return New ResponseObject(Of SearchObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Search_Voices, parameter))
    End Function

    ''' <summary>
    ''' Search users of query
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Users(ByVal parameter As RequestParam) As ResponseObject(Of SearchObject)
        Return New ResponseObject(Of SearchObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Users_Search, parameter))
    End Function

    ''' <summary>
    ''' Search users with profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Profile(ByVal parameter As RequestParam) As ResponseObject(Of SearchObject)
        Return New ResponseObject(Of SearchObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Profile_Search, parameter))
    End Function

    ''' <summary>
    ''' Search favorites of query
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Favorites(ByVal parameter As RequestParam) As ResponseObject(Of SearchObject)
        Return New ResponseObject(Of SearchObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Search_Favorites, parameter))
    End Function
End Class
