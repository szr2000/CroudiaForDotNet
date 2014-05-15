Imports System.Runtime.Serialization
<DataContract>
Public Class SecretMailObject

    ''' <summary>
    ''' シークレットメールの作成日
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property

    <DataMember(Name:="created_at")>
    Private Property cat As String

    ''' <summary>
    ''' シークレットメールのidを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' 受信者を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="recipient")>
    Public Property Recipient As UserObject

    ''' <summary>
    ''' 受信者のユーザーidを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="recipient_id")>
    Public Property RecipientId As String

    ''' <summary>
    ''' 受信者のスクリーンネームを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="recipient_screen_name")>
    Public Property RecipientScreenName As String

    ''' <summary>
    ''' 送信者を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="sender")>
    Public Property Sender As UserObject

    ''' <summary>
    ''' 送信者のユーザーidを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="sender_id")>
    Public Property SenderId As String

    ''' <summary>
    ''' 送信者のスクリーンネームを取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="sender_screen_name")>
    Public Property SenderScreenName As String

    ''' <summary>
    ''' シークレットメールの本文を取得します
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="text")>
    Public Property Text As String
End Class

Public Class SecretMailObjectList
    Inherits List(Of SecretMailObject)
End Class