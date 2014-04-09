Public Class Users
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Show
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Users.Show(parameter))
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Async Function Lookup(ByVal Ids As Decimal()) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Lookup(Ids))
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Async Function Lookup(ByVal ScreenNames As String()) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Lookup(ScreenNames))
    End Function
End Class
