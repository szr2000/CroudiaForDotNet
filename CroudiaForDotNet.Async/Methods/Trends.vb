Public Class Trends
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Place
    ''' </summary>
    ''' <param name="parameter">Parameter</param>
    Public Async Function Place(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of TrendsObjectList))
        Return Await Task.Run(Function() token.Trends.Place(parameter))
    End Function
End Class
