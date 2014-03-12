Public Class Trends
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get place with a place
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Place(ByVal parameter As RequestParam) As ResponseObject(Of TrendsObjectList)
        Return New ResponseObject(Of TrendsObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Trends_Place, parameter))
    End Function
End Class
