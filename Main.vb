
Public Module Main
    Public Class Main

        Private Shared MainFormController As MainForm
        Private Shared DimmerController As StageSetter
        Public Shared Sub Main(args As String())
            Debug.WriteLine("Hello World!")
            Application.EnableVisualStyles()
            Debug.Assert(args.Length <> 0)
            For Each arg In args
                Select Case arg
                    Case "-h"
                    Case "--help"
                        Console.WriteLine()
                        Console.WriteLine("Here is your help.")

                    Case Else
                        Console.WriteLine()
                        Console.WriteLine("Enter a valid command")
                End Select
            Next

            MainFormController = New MainForm()
            Application.Run(MainFormController)

            Do While MainFormController.DoneUsingForm = False
                'Do other things
                Threading.Thread.Sleep(100)
            Loop

            'Form is closed, need to safely close MIDI handles if any exist
            If (Not IsNothing(DimmerController)) Then
                DimmerController.CloseConnection()
            End If

        End Sub
        Public Shared Sub CreateNewMIDIControlledConsole(myDeviceID As Integer, Optional myCapabilites As MIDIOUTCAPSW = Nothing)
            DimmerController = New StageSetter(myDeviceID, myCapabilites)
        End Sub

        Public Shared Sub PrintControllerCapabilities()
            DimmerController.GetHardwareInformation()
        End Sub

        Public Shared Sub CycleMode()
            DimmerController.ToggleMode()
        End Sub

        Public Shared Sub ToggleBlackout()
            DimmerController.ToggleBlackout()
        End Sub

        Public Shared Sub FullOn()
            DimmerController.FullOn()
        End Sub

        Public Shared Sub FullOff()
            DimmerController.FullOff()
        End Sub

        Public Shared Sub Disconnect()
            If IsNothing(DimmerController) Then
                Exit Sub
            End If

            DimmerController.CloseConnection()
        End Sub
        Public Shared Function GetCurrentMode() As StageSetter.StageSetterModes
            Return DimmerController.ChannelBankMode
        End Function
        Public Shared Function GetCurrentStatus() As String
            Select Case DimmerController.MIDIControl.Activity
                Case MIDIStatus.NotCurrentlConnected
                    Return "Waiting to Connect"
                Case MIDIStatus.Connected
                    Return "Connected"
                Case MIDIStatus.NotCurrentlConnected
                    Return "Disconnected"
                Case Else
                    Return "UNKNOWN"
            End Select
        End Function

        Public Shared Async Sub SetChannelIntensity(myChannel As Channel)
            If IsNothing(myChannel) Then
                Exit Sub
            End If
            If IsNothing(DimmerController) Then
                Exit Sub
            End If
            Await Task.Yield()

            Exit Sub
            'Await DimmerController.SetAddressIntensity(DimmerController.Channels., myChannel.Value)
        End Sub
        Public Shared Async Sub SetSubGroupIntensity(mySubGroup As Subgroup)
            If IsNothing(mySubGroup) Then
                Exit Sub
            End If
            If IsNothing(DimmerController) Then
                Exit Sub
            End If

            Await Task.Yield()
            Exit Sub

            'Await DimmerController.SetSubGroupIntensity(mySubGroup)
        End Sub
        Public Shared Async Sub UpdateChannels()
            If IsNothing(DimmerController) Then
                Exit Sub
            End If
            Await DimmerController.UpdateChannels()
        End Sub
        Public Shared Function GetChannel(Position As Integer) As DMXChannel

            If IsNothing(DimmerController) Then
                Return Nothing
            End If
            Return DimmerController.GetChannel(Position)
        End Function
        Public Shared Function GetSubGroup(SubGroupName As String) As Subgroup
            If IsNothing(DimmerController) Then
                Return Nothing
            End If
            Return DimmerController.GetSubGroup(SubGroupName)
        End Function


    End Class

End Module
