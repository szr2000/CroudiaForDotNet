Public Class Favorites
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get favorites
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Favorites(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Favorites.Favorites(parameter))
    End Function

    ''' <summary>
    ''' Add whisper to favorites
    ''' </summary>
    ''' <param name="Id">id</param>
    Public Async Function Create(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Favorites.Create(Id))
    End Function

    ''' <summary>
    ''' Delete whisper from favorites
    ''' </summary>
    ''' <param name="Id">id</param>
    Public Async Function Destroy(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Favorites.Destroy(Id))
    End Function
End Class
