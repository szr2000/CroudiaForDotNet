Public Class SecretMails
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get secretmails
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function SecretMails(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of SecretMailObjectList)
        Return New ResponseObject(Of SecretMailObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.SecretMails, parameter))
    End Function

    ''' <summary>
    ''' Get secretmails of sent
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Sent(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of SecretMailObjectList)
        Return New ResponseObject(Of SecretMailObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.SecretMails_Sent, parameter))
    End Function

    ''' <summary>
    ''' Create new secretmail
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of SecretMailObject)
        Return New ResponseObject(Of SecretMailObject)(token.PrepareAccess(HttpMethod.HttpPOST, EndPoints.SecretMails_New, parameter))
    End Function

    ''' <summary>
    ''' Destroy secretmail
    ''' </summary>
    ''' <param name="Id">The id of secretmail</param>
    Public Function Destroy(ByVal Id As Decimal) As ResponseObject(Of SecretMailObject)
        Return New ResponseObject(Of SecretMailObject)(token.PrepareAccess(HttpMethod.HttpPOST, String.Format(EndPoints.SecretMails_Destroy_Id, Id.ToString)))
    End Function

    ''' <summary>
    ''' Show secretmail
    ''' </summary>
    ''' <param name="Id">The id of secretmail</param>
    Public Function Show(ByVal Id As Decimal) As ResponseObject(Of SecretMailObject)
        Return New ResponseObject(Of SecretMailObject)(token.PrepareAccess(HttpMethod.HttpGET, String.Format(EndPoints.SecretMails_Show_Id, Id.ToString)))
    End Function
End Class
