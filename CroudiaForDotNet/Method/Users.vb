Imports System.Text

Public Class Users
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Show a user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Users_Show, parameter))
    End Function

    ''' <summary>
    ''' Lookup users
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Function Lookup(ByVal Ids As Decimal()) As ResponseObject(Of UserObjectList)
        Dim r As New RequestParam
        Dim sb As New StringBuilder
        For Each v As Decimal In Ids
            sb.Append("," & v.ToString)
        Next
        sb.Remove(0, 1)
        r("user_id") = sb.ToString
        Return New ResponseObject(Of UserObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Users_Lookup, r))
    End Function

    ''' <summary>
    ''' Lookup users
    ''' </summary>
    ''' <param name="ScreenNames">Screennames</param>
    Public Function Lookup(ByVal ScreenNames As String()) As ResponseObject(Of UserObjectList)
        Dim r As New RequestParam
        Dim sb As New StringBuilder
        For Each v As String In ScreenNames
            sb.Append("," & v.ToString)
        Next
        sb.Remove(0, 1)
        r("screen_name") = sb.ToString
        Return New ResponseObject(Of UserObjectList)(token.PrepareAccess(HttpMethod.HttpGET, EndPoints.Users_Lookup, r))
    End Function
End Class
