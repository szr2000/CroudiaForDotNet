Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Web

Namespace CroudiaAccess
    Public Module AccessToCroudia
        Friend Function POSTAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, Optional ByVal Dic As RequestParam = Nothing) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            Dim wa As HttpWebRequest = CType(WebRequest.Create(EndPoint), System.Net.HttpWebRequest)
            Dim parameter As String = ParamParse(Dic)
            wa.Method = "POST"
            If Not String.IsNullOrEmpty(Oauth.AccessToken) Then
                wa.Headers(HttpRequestHeader.Authorization) = String.Format("Bearer {0}", Oauth.AccessToken)
            End If
            wa.ContentType = "application/x-www-form-urlencoded"
            wa.ContentLength = Encoding.UTF8.GetByteCount(parameter)
            Dim reqStream As Stream = wa.GetRequestStream()
            reqStream.Write(Encoding.UTF8.GetBytes(parameter), 0, Encoding.UTF8.GetByteCount(parameter))
            reqStream.Close()
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
            Return Nothing
        End Function

        Friend Function GETAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, Optional ByVal Dic As RequestParam = Nothing) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            Dim parameter As String = ""
            If Not IsNothing(Dic) Then
                parameter = "?" & ParamParse(Dic)
            End If
            Dim wa As System.Net.HttpWebRequest = _
        CType(System.Net.WebRequest.Create(EndPoint & parameter),  _
            System.Net.HttpWebRequest)
            wa.Method = "GET" 'GET
            wa.ContentType = "application/x-www-form-urlencoded"
            wa.Headers(HttpRequestHeader.Authorization) = String.Format("Bearer {0}", Oauth.AccessToken)
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
        End Function

        Friend Function MultiPartPOSTAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, ByVal Dic As RequestParam) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            If IsNothing(Dic) Then
                Throw New ArgumentException("Dic")
            End If
            Dim boundary As String = "fisttwitboundary"
            Dim wa As System.Net.HttpWebRequest = _
        CType(System.Net.WebRequest.Create(EndPoint),  _
            System.Net.HttpWebRequest)
            wa.Method = "POST"
            wa.ContentType = "multipart/form-data;boundary=" & boundary
            wa.Headers(HttpRequestHeader.Authorization) = String.Format("Bearer {0}", Oauth.AccessToken)
            Dim pd As New StringBuilder
            Dim KeyInData As String = Nothing
            For Each v As KeyValuePair(Of String, Object) In Dic
                If v.Value.GetType.Name = GetType(Byte()).Name Then
                    KeyInData = v.Key
                Else
                    pd.Append(String.Format("--" & boundary & vbCrLf & _
          "Content-Disposition: form-data; name=""{0}""" _
          & vbCrLf & vbCrLf & v.Value & vbCrLf, v.Key))
                End If
            Next
            pd.Append(String.Format("--" & boundary & vbCrLf & _
        "Content-Type: application/octet-stream" & vbCrLf &
        "Content-Disposition: form-data; name=""{0}""; filename=""{1}""" & vbCrLf & vbCrLf, KeyInData, New Random().Next))
            Dim PostByte As Byte() = Encoding.UTF8.GetBytes(pd.ToString)
            Dim PostEnd As String = vbCrLf & "--" & boundary & "--" & vbCrLf
            Dim PostEndByte As Byte() = Encoding.UTF8.GetBytes(PostEnd)
            Dim PostData As Byte() = CType(Dic(KeyInData), Byte())
            wa.ContentLength = PostByte.Length + PostEndByte.Length + PostData.Length
            Dim reqStream As System.IO.Stream = wa.GetRequestStream()
            reqStream.Write(PostByte, 0, PostByte.Length)
            reqStream.Write(PostData, 0, PostData.Length)
            reqStream.Write(PostEndByte, 0, PostEndByte.Length)
            reqStream.Close()
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
        End Function

        Private Function ParamParse(ByVal Param As RequestParam) As String
            If IsNothing(Param) Then Return ""
            Dim value As New StringBuilder("?")
            For Each v As KeyValuePair(Of String, Object) In Param
                If Not value.ToString = "" Then
                    value.Append("&" & v.Key & "=" & HttpUtility.UrlEncode(v.Value))
                Else
                    value.Append(v.Key & "=" & HttpUtility.UrlEncode(v.Value))
                End If
            Next
            Return value.ToString
        End Function
    End Module

End Namespace

Friend Enum HttpMethod
    HttpPOST
    HttpGET
    HttpPOSTMultipart
End Enum