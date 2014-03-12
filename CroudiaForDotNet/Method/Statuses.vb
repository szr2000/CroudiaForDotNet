Public Class Statuses
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Post a status
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Update(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.Statuses_Update, parameter))
    End Function

    ''' <summary>
    ''' Post a status with media
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateWithMedia(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOSTMultipart, EndPoints.Statuses_Update_With_Media, parameter))
    End Function

    ''' <summary>
    ''' Destroy a status
    ''' </summary>
    ''' <param name="Id">Whisper's Id</param>
    Public Function Destroy(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, String.Format(EndPoints.Statuses_Destroy_Id, Id.ToString)))
    End Function

    ''' <summary>
    ''' Show a status
    ''' </summary>
    ''' <param name="Id">Whisper's Id</param>
    Public Function Show(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpGET, String.Format(EndPoints.Statuses_Show_Id, Id.ToString)))
    End Function

    ''' <summary>
    ''' Spread a status
    ''' </summary>
    ''' <param name="Id">Whisper's Id</param>
    Public Function Spread(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, String.Format(EndPoints.Statuses_Spread_Id, Id.ToString)))
    End Function

    ''' <summary>
    ''' Share a status
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Share(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.Statuses_Share, parameter))
    End Function

    ''' <summary>
    ''' Share a status with a media
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function ShareWithMedia(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOSTMultipart, EndPoints.Statuses_Share_With_Media, parameter))
    End Function
End Class
