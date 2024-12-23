Imports System.Runtime.InteropServices


Public Class MainForm
    Public Property DoneUsingForm As Boolean
    Private Property FormInitializing As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FormInitializing = True
        DoneUsingForm = False
    End Sub
    Private Sub On_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set all sliders to "0"

        Threading.Thread.Sleep(1500)

        Dim myslider As Windows.Forms.VScrollBar = Nothing
        Dim componentObject As Windows.Forms.Control = Nothing

        Slider_1.Value = 255
        Slider_2.Value = 255
        Slider_3.Value = 255
        Slider_4.Value = 255
        Slider_5.Value = 255
        Slider_6.Value = 255
        Slider_7.Value = 255
        Slider_8.Value = 255
        Slider_9.Value = 255
        Slider_10.Value = 255
        Slider_11.Value = 255
        Slider_12.Value = 255
        Slider_13.Value = 255
        Slider_14.Value = 255
        Slider_15.Value = 255
        Slider_16.Value = 255

        Slider_Main.Value = 255
        Slider_SubX.Value = 255
        Slider_SubY.Value = 255


        If (ComboBox_DeviceSelection.Items.Count > 0) Then
            ComboBox_DeviceSelection.Items.Clear()
        End If

        Debug.WriteLine("Loading available devices...")
        For t = 0 To midiOutGetNumDevs() - 1
            Dim ocaps As New MIDIOUTCAPSW
            midiOutGetDevCapsW(t, ocaps, Marshal.SizeOf(ocaps))
            ComboBox_DeviceSelection.Items.Add(ocaps.szPname)
            Debug.WriteLine($"Device [{t}] : {ocaps.szPname}")

        Next
        Debug.WriteLine("Select the device to control.")

        Label_MIDICommunicationStatus.Text = "Status: Disconnected"
        Label_Mode.Text = "Mode: N/A"
        FormInitializing = False
    End Sub

    Private Sub ComboBox_DeviceSelection_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Public Function GetRealValue(valueToChange As Integer) As Integer
        Return DMX_MAX_VALUE - valueToChange
    End Function

    Private Sub ChannelLabelOnDblClick(sender As Object, e As EventArgs)
        ' Setup color picker when user double clicks a label (only 1-6)
        Dim cDialog As New ColorDialog()
        cDialog.Color = Color.White
        cDialog.AllowFullOpen = True
        cDialog.ShowDialog()

        ' Get Values from color dialog
        Dim pickedColor = cDialog.Color
        Dim startingChannel = CType(sender, Label).Name
        Dim redValueFromColor = pickedColor.R
        Dim greenValueFromColor = pickedColor.G
        Dim blueValueFromColor = pickedColor.B
        Dim iChannel As Integer = CInt(startingChannel.Substring(5))

        CType(MainControlPanel.Controls.Find("Slider_" & iChannel, True)(0), VScrollBar).Value = GetRealValue(redValueFromColor)
        CType(MainControlPanel.Controls.Find("Slider_" & iChannel + 1, True)(0), VScrollBar).Value = GetRealValue(greenValueFromColor)
        CType(MainControlPanel.Controls.Find("Slider_" & iChannel + 2, True)(0), VScrollBar).Value = GetRealValue(blueValueFromColor)

        'debugging values
        Debug.WriteLine($"Channel Selected: {startingChannel}")
        Debug.WriteLine($"R:{redValueFromColor}, G:{greenValueFromColor}, B:{blueValueFromColor}")
    End Sub

    Private Sub MainControlPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox_DeviceSelection_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    'TODO: Allow renaming of labels
    'TODO: allow grouping from labels
    Private Sub LabelClick(sender As Object, e As EventArgs)

    End Sub


    Private Sub Slider_Main_Scroll(sender As Object, e As EventArgs) Handles Slider_Main.ValueChanged
        If (FormInitializing = True) Then
            Exit Sub
        End If

        Dim SliderObjRef As Windows.Forms.VScrollBar = Nothing
        Try
            SliderObjRef = CType(sender, VScrollBar)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            Exit Sub
        End Try

        'Debug.WriteLine($"{SliderObjRef.Name}:{SliderObjRef.Value}")  

        Main.Main.UpdateChannels()

    End Sub

    Private Sub Slider_SubY_Scroll(sender As Object, e As EventArgs) Handles Slider_SubY.ValueChanged
        If (FormInitializing = True) Then
            Exit Sub
        End If

        Dim SliderObjRef As Windows.Forms.VScrollBar = Nothing
        Try
            SliderObjRef = CType(sender, VScrollBar)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            Exit Sub
        End Try
        Dim SubGroupToChange As Subgroup = Main.Main.GetSubGroup("Y")
        Dim ValueToSend As Byte = 0
        ValueToSend = 255 - SliderObjRef.Value
        'Debug.WriteLine($"{SliderObjRef.Name},{SliderObjRef.Value}") 
        SubGroupToChange.Value = ValueToSend
        Main.Main.SetSubGroupIntensity(SubGroupToChange)

    End Sub

    Private Sub Slider_SubX_Scroll(sender As Object, e As EventArgs) Handles Slider_SubX.ValueChanged
        If (FormInitializing = True) Then
            Exit Sub
        End If

        Dim SliderObjRef As Windows.Forms.VScrollBar = Nothing
        Try
            SliderObjRef = CType(sender, VScrollBar)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            Exit Sub
        End Try
        Dim SubGroupToChange As Subgroup = Main.Main.GetSubGroup("X")
        Dim ValueToSend As Byte = 0
        ValueToSend = 255 - SliderObjRef.Value
        'Debug.WriteLine($"{SliderObjRef.Name},{SliderObjRef.Value}") 
        SubGroupToChange.Value = ValueToSend
        Main.Main.SetSubGroupIntensity(SubGroupToChange)

    End Sub

    Private Sub Slider_Scroll(sender As Object, e As EventArgs) Handles Slider_16.ValueChanged, Slider_15.ValueChanged,
                                                                                Slider_14.ValueChanged, Slider_13.ValueChanged,
                                                                                Slider_12.ValueChanged, Slider_11.ValueChanged,
                                                                                Slider_10.ValueChanged, Slider_9.ValueChanged,
                                                                                Slider_8.ValueChanged, Slider_7.ValueChanged,
                                                                                Slider_6.ValueChanged, Slider_5.ValueChanged,
                                                                                Slider_4.ValueChanged, Slider_3.ValueChanged,
                                                                                Slider_2.ValueChanged, Slider_1.ValueChanged
        If (FormInitializing = True) Then
            Exit Sub
        End If

        Dim SliderObjRef As Windows.Forms.VScrollBar = Nothing
        Try
            SliderObjRef = CType(sender, VScrollBar)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            Exit Sub
        End Try

        'Debug.WriteLine($"{SliderObjRef.Name}:{SliderObjRef.Value}")
        Dim myChannel As Integer = 0
        myChannel = CType(SliderObjRef.Name.ToString().Substring("Slider_".Length), Integer)

        Dim ValueToSend As Byte = 0
        ValueToSend = SliderObjRef.Value
        'Debug.WriteLine($"{SliderObjRef.Name},{SliderObjRef.Value}")
        Dim ChannelToChange As DMXChannel = Main.Main.GetChannel(myChannel)


        ChannelToChange.Value = SliderObjRef.Maximum - ValueToSend
        Exit Sub
        'Main.Main.SetChannelIntensity(ChannelToChange)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_StageLeft.Click, Button_StageMid.Click, Button_StageRight.Click

        Dim buttonClicked As Windows.Forms.Button = Nothing
        Try
            buttonClicked = CType(sender, Button)
        Catch ex As Exception
            DisplayErrorMessage(ex.Message)
            Exit Sub
        End Try

        Dim colorValueToSetLight As Color = Nothing
        Dim DialogProcessor As DialogResult = ColorDialog1.ShowDialog()
        colorValueToSetLight = ColorDialog1.Color

        Dim buttonName As String = buttonClicked.Name

        Select Case buttonName
            Case "Button_StageLeft"
                Panel_ColorLeft.BackColor = colorValueToSetLight
            Case "Button_StageMid"
                Panel_ColorMid.BackColor = colorValueToSetLight
            Case "Button_StageRight"
                Panel_ColorRight.BackColor = colorValueToSetLight
            Case Else
                DisplayErrorMessage($"Internal Error. Button name {buttonName} not found!")
        End Select

    End Sub

    Public Sub DisplayErrorMessage(MessageToDisplay As String)
        MessageBox.Show(MessageToDisplay, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim DeviceID As Integer = 0
        Dim ocaps As New MIDIOUTCAPSW

        If (IsNothing(ComboBox_DeviceSelection.SelectedItem)) Then
            Exit Sub
        End If

        If Button1.Text.Equals("Disconnect") Then
            'Disconnect Device
            Main.Main.Disconnect()
            Button1.Text = "Connect"
            Label_MIDICommunicationStatus.Text = "Status: " & Main.Main.GetCurrentStatus()
            Label_Mode.Text = "Mode: N/A"
        Else

            'Connect to Device
            ' Get the current device selected in the drop down
            For DeviceID = 0 To midiOutGetNumDevs() - 1
                midiOutGetDevCapsW(DeviceID, ocaps, Marshal.SizeOf(ocaps))
                If (ComboBox_DeviceSelection.SelectedItem.ToString().Equals(ocaps.szPname)) Then
                    Exit For
                End If
            Next

            Label_MIDICommunicationStatus.Text = "Status: Connecting..."

            ' create a new instance of a MIDI device for it
            Main.Main.CreateNewMIDIControlledConsole(DeviceID, ocaps)

            ' Get Hardware information
            Main.Main.PrintControllerCapabilities()

            ' Update Status  
            Label_MIDICommunicationStatus.Text = "Status: " & Main.Main.GetCurrentStatus()
            Label_Mode.Text = "Mode: " & Main.Main.GetCurrentMode().ToString()
            Button1.Text = "Disconnect"
        End If
    End Sub

    Private Sub FormIsClosing() Handles MyBase.Closed
        Main.Main.Disconnect()
        DoneUsingForm = True
    End Sub

    Private Sub Button_ModeToggle_Click(sender As Object, e As EventArgs) Handles Button_ModeToggle.Click
        Main.Main.CycleMode()
        Label_Mode.Text = "Mode: " & Main.Main.GetCurrentMode().ToString()
    End Sub

    Private Sub Button_ToggleBlackout_Click(sender As Object, e As EventArgs) Handles Button_ToggleBlackout.Click
        Main.Main.ToggleBlackout()
    End Sub

    Private Sub Button_FullOn_MouseDown(sender As Object, e As MouseEventArgs) Handles Button_FullOn.MouseDown
        Main.Main.FullOn()
    End Sub

    Private Sub Button_FullOn_MouseUp(sender As Object, e As MouseEventArgs) Handles Button_FullOn.MouseUp
        Main.Main.FullOff()
    End Sub
    ' TODO: For fun!
    'Private Sub Button_PartyMode_Click(sender As Object, e As EventArgs) Handles Button_PartyMode.Click
    '    For j = 0 To 255 Step 1
    '        For i = 0 To 16 Step 1
    '            Main.Main.GetChannel(i).Value = 255 - j
    '            Main.Main.SetChannelIntensity(Main.Main.GetChannel(i))
    '        Next
    '    Next

    'End Sub
End Class