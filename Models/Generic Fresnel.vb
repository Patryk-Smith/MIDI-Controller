Public Class Generic_Fresnel
    Inherits LightingFixture

    Public Sub New()
        MyBase.New()
        MyBase.description = "Generic Stage Light"
        MyBase.manufacturer = "Unknown"
        MyBase.supportedChannelModes = New List(Of ChannelMode)
        MyBase.supportedChannelModes.Add(ChannelMode.One)
    End Sub

End Class
