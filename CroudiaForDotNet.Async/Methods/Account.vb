Public Class Account
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' UpdateCoverImage
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateCoverImage(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateCoverImage(parameter))
    End Function

    ''' <summary>
    ''' VerifyCredentials
    ''' </summary>
    Public Async Function VerifyCredentials() As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.VerifyCredentials)
    End Function

    ''' <summary>
    ''' UpdateProfileImage
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfileImage(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfileImage(parameter))
    End Function

    ''' <summary>
    ''' UpdateProfile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfile(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfile(parameter))
    End Function
End Class
