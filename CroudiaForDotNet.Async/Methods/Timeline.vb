Public Class Timeline
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' PublicTimeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function PublicTimeline(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.PublicTimeline(parameter))
    End Function

    ''' <summary>
    ''' HomeTimeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function HomeTimeline(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.HomeTimeline(parameter))
    End Function

    ''' <summary>
    ''' UserTimeline
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UserTimeline(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.UserTimeline(parameter))
    End Function

    ''' <summary>
    ''' Mentions
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Mentions(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.Mentions(parameter))
    End Function
End Class
