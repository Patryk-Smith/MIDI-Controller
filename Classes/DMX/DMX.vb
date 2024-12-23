Partial Public Module DMX
    Public Const STD_UNIVERSE_SIZE = 512 ' there are usually 512 addresses in a standard DMX universe
    Public Enum ChannelUseCase
        Null
        ColorRed
        ColorGreen
        ColorBlue
        Intensity
        Xrotation
        Yrotation
        Zrotation
    End Enum
End Module
