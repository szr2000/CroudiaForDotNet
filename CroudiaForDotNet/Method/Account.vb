Public Class Account
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Verify Credentials
    ''' </summary>
    Public Function VerifyCredentials() As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Account_Verify_Credentials))
    End Function

    ''' <summary>
    ''' Update Profile Image
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfileImage(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpPOSTMultipart, EndPoints.Account_Update_Profile_Image, parameter))
    End Function

    ''' <summary>
    ''' Update cover image
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateCoverImage(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpPOSTMultipart, EndPoints.Account_Update_Cover_Image, parameter))
    End Function

    ''' <summary>
    ''' Update profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfile(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.Account_Update_Profile, parameter))
    End Function
End Class
