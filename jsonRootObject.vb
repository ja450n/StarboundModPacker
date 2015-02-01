Public Class jsonRootObject
    Private prv_name As String
    Private prv_version As String
    Private prv_path As String
    Private prv_dependencies As List(Of Object)
    Private prv_metadata As Metadata

    Property name() As String
        Get
            Return prv_name
        End Get
        Set(ByVal Value As String)
            prv_name = Value
        End Set
    End Property
    Property version() As String
        Get
            Return prv_version
        End Get
        Set(ByVal Value As String)
            prv_version = Value
        End Set
    End Property
    Property path() As String
        Get
            Return prv_path
        End Get
        Set(ByVal Value As String)
            prv_path = Value
        End Set
    End Property

    Property dependencies() As List(Of Object)
        Get
            Return prv_dependencies
        End Get
        Set(ByVal Value As List(Of Object))
            prv_dependencies = Value
        End Set
    End Property

    Property metadata() As Metadata
        Get
            Return prv_metadata
        End Get
        Set(ByVal Value As Metadata)
            prv_metadata = Value
        End Set
    End Property

End Class

Public Class Metadata
    Private prv_author As String
    Private prv_description As String
    Private prv_version As String

    Property author() As String
        Get
            Return prv_author
        End Get
        Set(ByVal Value As String)
            prv_author = Value
        End Set
    End Property
    Property description() As String
        Get
            Return prv_description
        End Get
        Set(ByVal Value As String)
            prv_description = Value
        End Set
    End Property
    Property version() As String
        Get
            Return prv_version
        End Get
        Set(ByVal Value As String)
            prv_version = Value
        End Set
    End Property

End Class

