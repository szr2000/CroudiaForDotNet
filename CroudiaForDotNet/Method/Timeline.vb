Public Class Timeline
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get public timeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function PublicTimeline(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Statuses_Public_Timeline, parameter))
    End Function

    ''' <summary>
    ''' Get home timeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function HomeTimeline(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Statuses_Home_Timeline, parameter))
    End Function

    ''' <summary>
    ''' Get user timeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UserTimeline(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Statuses_User_Timeline, parameter))
    End Function

    ''' <summary>
    ''' Get mentions
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Mentions(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Statuses_Mentions, parameter))
    End Function
End Class
