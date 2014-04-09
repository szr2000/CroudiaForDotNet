Public Class Searches
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Voices
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Voices(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SearchObject))
        Return Await Task.Run(Function() token.Searches.Voices(parameter))
    End Function

    ''' <summary>
    ''' Users
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Users(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SearchObject))
        Return Await Task.Run(Function() token.Searches.Users(parameter))
    End Function

    ''' <summary>
    ''' Profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Profile(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SearchObject))
        Return Await Task.Run(Function() token.Searches.Profile(parameter))
    End Function

    ''' <summary>
    ''' Favorites
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Favorites(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SearchObject))
        Return Await Task.Run(Function() token.Searches.Favorites(parameter))
    End Function
End Class
