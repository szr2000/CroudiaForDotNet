Public Class Favorites
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get favorites
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Favorites(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Favorites, parameter))
    End Function

    ''' <summary>
    ''' Add whisper to favorites
    ''' </summary>
    ''' <param name="Id">Whisper's id</param>
    Public Function Create(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, String.Format(EndPoints.Favorites_Create_Id, Id.ToString)))
    End Function

    ''' <summary>
    ''' Delete whisper from favorites
    ''' </summary>
    ''' <param name="Id">Whisper's id</param>
    Public Function Destroy(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        Return New ResponseObject(Of StatusObject)(token.PrepareAccess(HttpMethod.HttpPOST, String.Format(EndPoints.Favorites_Destroy_Id, Id.ToString)))
    End Function
End Class
