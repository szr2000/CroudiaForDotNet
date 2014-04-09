Public Class SecretMails
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' SecretMails
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function SecretMails(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of SecretMailObjectList))
        Return Await Task.Run(Function() token.SecretMails.SecretMails(parameter))
    End Function

    ''' <summary>
    ''' Sent
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Sent(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of SecretMailObjectList))
        Return Await Task.Run(Function() token.SecretMails.Sent(parameter))
    End Function

    ''' <summary>
    ''' Create
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SecretMailObject))
        Return Await Task.Run(Function() token.SecretMails.Create(parameter))
    End Function

    ''' <summary>
    ''' Destroy
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Destroy(ByVal Id As Decimal) As Task(Of ResponseObject(Of SecretMailObject))
        Return Await Task.Run(Function() token.SecretMails.Destroy(Id))
    End Function

    ''' <summary>
    ''' Show
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Show(ByVal Id As Decimal) As Task(Of ResponseObject(Of SecretMailObject))
        Return Await Task.Run(Function() token.SecretMails.Show(Id))
    End Function
End Class
