Public Class Statuses
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Update
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Update(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Update(parameter))
    End Function

    ''' <summary>
    ''' UpdateWithmedia
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateWithMedia(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.UpdateWithMedia(parameter))
    End Function

    ''' <summary>
    ''' Destroy
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Destroy(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Destroy(Id))
    End Function

    ''' <summary>
    ''' Show
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Show(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Show(Id))
    End Function

    ''' <summary>
    ''' Spread
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Spread(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Spread(Id))
    End Function

    ''' <summary>
    ''' Share
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Share(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Share(parameter))
    End Function

    ''' <summary>
    ''' ShareWithMedia
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function ShareWithMedia(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.ShareWithMedia(parameter))
    End Function
End Class
