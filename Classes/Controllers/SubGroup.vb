Partial Public Module Controller
    Public Class SubGroup
        Inherits Controller.Channel
        Public Property Channels As List(Of Controller.Channel)
        Public Sub New()
            MyBase.New(0, "SubGroup")
        End Sub
    End Class
End Module