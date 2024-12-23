<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        Panel_ColorRight = New Panel()
        Panel_ColorMid = New Panel()
        Panel_ColorLeft = New Panel()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Button_StageRight = New Button()
        Button_StageMid = New Button()
        Button_StageLeft = New Button()
        TabPage1 = New TabPage()
        MainControlPanel = New Panel()
        Button_PartyMode = New Button()
        Label_Mode = New Label()
        Button_ModeToggle = New Button()
        Button_FullOn = New Button()
        Button_ToggleBlackout = New Button()
        Label_MIDICommunicationStatus = New Label()
        Button1 = New Button()
        Label20 = New Label()
        ComboBox_DeviceSelection = New ComboBox()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Slider_Main = New VScrollBar()
        Slider_SubY = New VScrollBar()
        Slider_SubX = New VScrollBar()
        Slider_16 = New VScrollBar()
        Slider_15 = New VScrollBar()
        Slider_14 = New VScrollBar()
        Slider_13 = New VScrollBar()
        Slider_12 = New VScrollBar()
        Slider_11 = New VScrollBar()
        Slider_10 = New VScrollBar()
        Slider_7 = New VScrollBar()
        Slider_6 = New VScrollBar()
        Slider_5 = New VScrollBar()
        Slider_4 = New VScrollBar()
        Slider_3 = New VScrollBar()
        Slider_2 = New VScrollBar()
        Slider_1 = New VScrollBar()
        Slider_9 = New VScrollBar()
        Slider_8 = New VScrollBar()
        ColorDialog1 = New ColorDialog()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        MainControlPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(2, 5)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(893, 484)
        TabControl1.TabIndex = 41
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel_ColorRight)
        TabPage2.Controls.Add(Panel_ColorMid)
        TabPage2.Controls.Add(Panel_ColorLeft)
        TabPage2.Controls.Add(Label23)
        TabPage2.Controls.Add(Label22)
        TabPage2.Controls.Add(Label21)
        TabPage2.Controls.Add(Button_StageRight)
        TabPage2.Controls.Add(Button_StageMid)
        TabPage2.Controls.Add(Button_StageLeft)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(885, 456)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Stage View"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel_ColorRight
        ' 
        Panel_ColorRight.Location = New Point(579, 103)
        Panel_ColorRight.Name = "Panel_ColorRight"
        Panel_ColorRight.Size = New Size(128, 100)
        Panel_ColorRight.TabIndex = 7
        ' 
        ' Panel_ColorMid
        ' 
        Panel_ColorMid.Location = New Point(338, 103)
        Panel_ColorMid.Name = "Panel_ColorMid"
        Panel_ColorMid.Size = New Size(128, 100)
        Panel_ColorMid.TabIndex = 7
        ' 
        ' Panel_ColorLeft
        ' 
        Panel_ColorLeft.Location = New Point(107, 103)
        Panel_ColorLeft.Name = "Panel_ColorLeft"
        Panel_ColorLeft.Size = New Size(128, 100)
        Panel_ColorLeft.TabIndex = 6
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(612, 56)
        Label23.Name = "Label23"
        Label23.Size = New Size(67, 15)
        Label23.TabIndex = 5
        Label23.Text = "Stage Right"' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(375, 55)
        Label22.Name = "Label22"
        Label22.Size = New Size(44, 15)
        Label22.TabIndex = 4
        Label22.Text = "Middle"' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(147, 55)
        Label21.Name = "Label21"
        Label21.Size = New Size(59, 15)
        Label21.TabIndex = 3
        Label21.Text = "Stage Left"' 
        ' Button_StageRight
        ' 
        Button_StageRight.Location = New Point(579, 74)
        Button_StageRight.Name = "Button_StageRight"
        Button_StageRight.Size = New Size(128, 23)
        Button_StageRight.TabIndex = 2
        Button_StageRight.Text = "Change Color"
        Button_StageRight.UseVisualStyleBackColor = True
        ' 
        ' Button_StageMid
        ' 
        Button_StageMid.Location = New Point(338, 74)
        Button_StageMid.Name = "Button_StageMid"
        Button_StageMid.Size = New Size(128, 23)
        Button_StageMid.TabIndex = 1
        Button_StageMid.Text = "Change Color"
        Button_StageMid.UseVisualStyleBackColor = True
        ' 
        ' Button_StageLeft
        ' 
        Button_StageLeft.Location = New Point(107, 74)
        Button_StageLeft.Name = "Button_StageLeft"
        Button_StageLeft.Size = New Size(128, 23)
        Button_StageLeft.TabIndex = 0
        Button_StageLeft.Text = "Change Color"
        Button_StageLeft.UseVisualStyleBackColor = True
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(MainControlPanel)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(885, 456)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Manual Control"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' MainControlPanel
        ' 
        MainControlPanel.Controls.Add(Button_PartyMode)
        MainControlPanel.Controls.Add(Label_Mode)
        MainControlPanel.Controls.Add(Button_ModeToggle)
        MainControlPanel.Controls.Add(Button_FullOn)
        MainControlPanel.Controls.Add(Button_ToggleBlackout)
        MainControlPanel.Controls.Add(Label_MIDICommunicationStatus)
        MainControlPanel.Controls.Add(Button1)
        MainControlPanel.Controls.Add(Label20)
        MainControlPanel.Controls.Add(ComboBox_DeviceSelection)
        MainControlPanel.Controls.Add(Label19)
        MainControlPanel.Controls.Add(Label18)
        MainControlPanel.Controls.Add(Label17)
        MainControlPanel.Controls.Add(Label9)
        MainControlPanel.Controls.Add(Label10)
        MainControlPanel.Controls.Add(Label11)
        MainControlPanel.Controls.Add(Label12)
        MainControlPanel.Controls.Add(Label13)
        MainControlPanel.Controls.Add(Label14)
        MainControlPanel.Controls.Add(Label15)
        MainControlPanel.Controls.Add(Label16)
        MainControlPanel.Controls.Add(Label8)
        MainControlPanel.Controls.Add(Label7)
        MainControlPanel.Controls.Add(Label6)
        MainControlPanel.Controls.Add(Label5)
        MainControlPanel.Controls.Add(Label4)
        MainControlPanel.Controls.Add(Label3)
        MainControlPanel.Controls.Add(Label2)
        MainControlPanel.Controls.Add(Label1)
        MainControlPanel.Controls.Add(Slider_Main)
        MainControlPanel.Controls.Add(Slider_SubY)
        MainControlPanel.Controls.Add(Slider_SubX)
        MainControlPanel.Controls.Add(Slider_16)
        MainControlPanel.Controls.Add(Slider_15)
        MainControlPanel.Controls.Add(Slider_14)
        MainControlPanel.Controls.Add(Slider_13)
        MainControlPanel.Controls.Add(Slider_12)
        MainControlPanel.Controls.Add(Slider_11)
        MainControlPanel.Controls.Add(Slider_10)
        MainControlPanel.Controls.Add(Slider_7)
        MainControlPanel.Controls.Add(Slider_6)
        MainControlPanel.Controls.Add(Slider_5)
        MainControlPanel.Controls.Add(Slider_4)
        MainControlPanel.Controls.Add(Slider_3)
        MainControlPanel.Controls.Add(Slider_2)
        MainControlPanel.Controls.Add(Slider_1)
        MainControlPanel.Controls.Add(Slider_9)
        MainControlPanel.Controls.Add(Slider_8)
        MainControlPanel.Dock = DockStyle.Fill
        MainControlPanel.Location = New Point(3, 3)
        MainControlPanel.Margin = New Padding(3, 2, 3, 2)
        MainControlPanel.Name = "MainControlPanel"
        MainControlPanel.Size = New Size(879, 450)
        MainControlPanel.TabIndex = 41
        ' 
        ' Button_PartyMode
        ' 
        Button_PartyMode.Location = New Point(753, 414)
        Button_PartyMode.Name = "Button_PartyMode"
        Button_PartyMode.Size = New Size(104, 23)
        Button_PartyMode.TabIndex = 87
        Button_PartyMode.Text = "Party Mode"
        Button_PartyMode.UseVisualStyleBackColor = True
        ' 
        ' Label_Mode
        ' 
        Label_Mode.AutoSize = True
        Label_Mode.Location = New Point(462, 201)
        Label_Mode.Name = "Label_Mode"
        Label_Mode.Size = New Size(66, 15)
        Label_Mode.TabIndex = 86
        Label_Mode.Text = "Mode: N/A"' 
        ' Button_ModeToggle
        ' 
        Button_ModeToggle.Location = New Point(462, 175)
        Button_ModeToggle.Name = "Button_ModeToggle"
        Button_ModeToggle.Size = New Size(91, 23)
        Button_ModeToggle.TabIndex = 85
        Button_ModeToggle.Text = "Change Mode"
        Button_ModeToggle.UseVisualStyleBackColor = True
        ' 
        ' Button_FullOn
        ' 
        Button_FullOn.Location = New Point(462, 115)
        Button_FullOn.Name = "Button_FullOn"
        Button_FullOn.Size = New Size(75, 23)
        Button_FullOn.TabIndex = 84
        Button_FullOn.Text = "Full On"
        Button_FullOn.UseVisualStyleBackColor = True
        ' 
        ' Button_ToggleBlackout
        ' 
        Button_ToggleBlackout.Location = New Point(462, 86)
        Button_ToggleBlackout.Name = "Button_ToggleBlackout"
        Button_ToggleBlackout.Size = New Size(75, 23)
        Button_ToggleBlackout.TabIndex = 83
        Button_ToggleBlackout.Text = "Blackout"
        Button_ToggleBlackout.UseVisualStyleBackColor = True
        ' 
        ' Label_MIDICommunicationStatus
        ' 
        Label_MIDICommunicationStatus.AutoSize = True
        Label_MIDICommunicationStatus.Location = New Point(511, 17)
        Label_MIDICommunicationStatus.Name = "Label_MIDICommunicationStatus"
        Label_MIDICommunicationStatus.Size = New Size(42, 15)
        Label_MIDICommunicationStatus.TabIndex = 82
        Label_MIDICommunicationStatus.Text = "Status:"' 
        ' Button1
        ' 
        Button1.Location = New Point(430, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 81
        Button1.Text = "Connect"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(102, 17)
        Label20.Name = "Label20"
        Label20.Size = New Size(42, 15)
        Label20.TabIndex = 80
        Label20.Text = "Device"' 
        ' ComboBox_DeviceSelection
        ' 
        ComboBox_DeviceSelection.FormattingEnabled = True
        ComboBox_DeviceSelection.Location = New Point(150, 14)
        ComboBox_DeviceSelection.Margin = New Padding(3, 2, 3, 2)
        ComboBox_DeviceSelection.Name = "ComboBox_DeviceSelection"
        ComboBox_DeviceSelection.Size = New Size(274, 23)
        ComboBox_DeviceSelection.TabIndex = 79
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(697, 58)
        Label19.Name = "Label19"
        Label19.Size = New Size(43, 15)
        Label19.TabIndex = 78
        Label19.Text = "Master"' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(658, 58)
        Label18.Name = "Label18"
        Label18.Size = New Size(14, 15)
        Label18.TabIndex = 77
        Label18.Text = "Y"' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(601, 58)
        Label17.Name = "Label17"
        Label17.Size = New Size(14, 15)
        Label17.TabIndex = 76
        Label17.Text = "X"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(401, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(19, 15)
        Label9.TabIndex = 75
        Label9.Text = "16"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(349, 238)
        Label10.Name = "Label10"
        Label10.Size = New Size(19, 15)
        Label10.TabIndex = 74
        Label10.Text = "15"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(298, 238)
        Label11.Name = "Label11"
        Label11.Size = New Size(19, 15)
        Label11.TabIndex = 73
        Label11.Text = "14"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(246, 238)
        Label12.Name = "Label12"
        Label12.Size = New Size(19, 15)
        Label12.TabIndex = 72
        Label12.Text = "13"' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(194, 238)
        Label13.Name = "Label13"
        Label13.Size = New Size(19, 15)
        Label13.TabIndex = 71
        Label13.Text = "12"' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(143, 238)
        Label14.Name = "Label14"
        Label14.Size = New Size(19, 15)
        Label14.TabIndex = 70
        Label14.Text = "11"' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(91, 238)
        Label15.Name = "Label15"
        Label15.Size = New Size(19, 15)
        Label15.TabIndex = 69
        Label15.Text = "10"' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(46, 238)
        Label16.Name = "Label16"
        Label16.Size = New Size(13, 15)
        Label16.TabIndex = 68
        Label16.Text = "9"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(408, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(13, 15)
        Label8.TabIndex = 67
        Label8.Text = "8"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(356, 58)
        Label7.Name = "Label7"
        Label7.Size = New Size(13, 15)
        Label7.TabIndex = 66
        Label7.Text = "7"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(304, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(13, 15)
        Label6.TabIndex = 65
        Label6.Text = "6"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(253, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 64
        Label5.Text = "5"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(201, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(13, 15)
        Label4.TabIndex = 63
        Label4.Text = "4"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 62
        Label3.Text = "3"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(13, 15)
        Label2.TabIndex = 61
        Label2.Text = "2"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(13, 15)
        Label1.TabIndex = 60
        Label1.Text = "1"' 
        ' Slider_Main
        ' 
        Slider_Main.LargeChange = 25
        Slider_Main.Location = New Point(710, 86)
        Slider_Main.Maximum = 255
        Slider_Main.Name = "Slider_Main"
        Slider_Main.Size = New Size(26, 232)
        Slider_Main.TabIndex = 59
        ' 
        ' Slider_SubY
        ' 
        Slider_SubY.LargeChange = 25
        Slider_SubY.Location = New Point(654, 86)
        Slider_SubY.Maximum = 255
        Slider_SubY.Name = "Slider_SubY"
        Slider_SubY.Size = New Size(26, 232)
        Slider_SubY.TabIndex = 58
        ' 
        ' Slider_SubX
        ' 
        Slider_SubX.LargeChange = 25
        Slider_SubX.Location = New Point(598, 86)
        Slider_SubX.Maximum = 255
        Slider_SubX.Name = "Slider_SubX"
        Slider_SubX.Size = New Size(26, 232)
        Slider_SubX.TabIndex = 57
        ' 
        ' Slider_16
        ' 
        Slider_16.LargeChange = 25
        Slider_16.Location = New Point(403, 262)
        Slider_16.Maximum = 255
        Slider_16.Name = "Slider_16"
        Slider_16.Size = New Size(26, 130)
        Slider_16.TabIndex = 56
        ' 
        ' Slider_15
        ' 
        Slider_15.LargeChange = 25
        Slider_15.Location = New Point(352, 262)
        Slider_15.Maximum = 255
        Slider_15.Name = "Slider_15"
        Slider_15.Size = New Size(26, 130)
        Slider_15.TabIndex = 55
        ' 
        ' Slider_14
        ' 
        Slider_14.LargeChange = 25
        Slider_14.Location = New Point(300, 262)
        Slider_14.Maximum = 255
        Slider_14.Name = "Slider_14"
        Slider_14.Size = New Size(26, 130)
        Slider_14.TabIndex = 54
        ' 
        ' Slider_13
        ' 
        Slider_13.LargeChange = 25
        Slider_13.Location = New Point(248, 262)
        Slider_13.Maximum = 255
        Slider_13.Name = "Slider_13"
        Slider_13.Size = New Size(26, 130)
        Slider_13.TabIndex = 53
        ' 
        ' Slider_12
        ' 
        Slider_12.LargeChange = 25
        Slider_12.Location = New Point(197, 262)
        Slider_12.Maximum = 255
        Slider_12.Name = "Slider_12"
        Slider_12.Size = New Size(26, 130)
        Slider_12.TabIndex = 52
        ' 
        ' Slider_11
        ' 
        Slider_11.LargeChange = 25
        Slider_11.Location = New Point(145, 262)
        Slider_11.Maximum = 255
        Slider_11.Name = "Slider_11"
        Slider_11.Size = New Size(26, 130)
        Slider_11.TabIndex = 51
        ' 
        ' Slider_10
        ' 
        Slider_10.LargeChange = 25
        Slider_10.Location = New Point(94, 262)
        Slider_10.Maximum = 255
        Slider_10.Name = "Slider_10"
        Slider_10.Size = New Size(26, 130)
        Slider_10.TabIndex = 50
        ' 
        ' Slider_7
        ' 
        Slider_7.LargeChange = 25
        Slider_7.Location = New Point(352, 86)
        Slider_7.Maximum = 255
        Slider_7.Name = "Slider_7"
        Slider_7.Size = New Size(26, 130)
        Slider_7.TabIndex = 47
        ' 
        ' Slider_6
        ' 
        Slider_6.LargeChange = 25
        Slider_6.Location = New Point(300, 86)
        Slider_6.Maximum = 255
        Slider_6.Name = "Slider_6"
        Slider_6.Size = New Size(26, 130)
        Slider_6.TabIndex = 46
        ' 
        ' Slider_5
        ' 
        Slider_5.LargeChange = 25
        Slider_5.Location = New Point(248, 86)
        Slider_5.Maximum = 255
        Slider_5.Name = "Slider_5"
        Slider_5.Size = New Size(26, 130)
        Slider_5.TabIndex = 45
        ' 
        ' Slider_4
        ' 
        Slider_4.LargeChange = 25
        Slider_4.Location = New Point(197, 86)
        Slider_4.Maximum = 255
        Slider_4.Name = "Slider_4"
        Slider_4.Size = New Size(26, 130)
        Slider_4.TabIndex = 44
        ' 
        ' Slider_3
        ' 
        Slider_3.LargeChange = 25
        Slider_3.Location = New Point(145, 86)
        Slider_3.Maximum = 255
        Slider_3.Name = "Slider_3"
        Slider_3.Size = New Size(26, 130)
        Slider_3.TabIndex = 43
        ' 
        ' Slider_2
        ' 
        Slider_2.LargeChange = 25
        Slider_2.Location = New Point(94, 86)
        Slider_2.Maximum = 255
        Slider_2.Name = "Slider_2"
        Slider_2.Size = New Size(26, 130)
        Slider_2.TabIndex = 42
        ' 
        ' Slider_1
        ' 
        Slider_1.LargeChange = 25
        Slider_1.Location = New Point(42, 86)
        Slider_1.Maximum = 255
        Slider_1.Name = "Slider_1"
        Slider_1.Size = New Size(26, 130)
        Slider_1.TabIndex = 41
        ' 
        ' Slider_9
        ' 
        Slider_9.LargeChange = 25
        Slider_9.Location = New Point(42, 262)
        Slider_9.Maximum = 255
        Slider_9.Name = "Slider_9"
        Slider_9.Size = New Size(26, 130)
        Slider_9.TabIndex = 49
        ' 
        ' Slider_8
        ' 
        Slider_8.LargeChange = 25
        Slider_8.Location = New Point(403, 86)
        Slider_8.Maximum = 255
        Slider_8.Name = "Slider_8"
        Slider_8.Size = New Size(26, 130)
        Slider_8.TabIndex = 48
        ' 
        ' ColorDialog1
        ' 
        ColorDialog1.AnyColor = True
        ColorDialog1.FullOpen = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 492)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainForm"
        Text = "Stage Setter - 8 Controller"
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        MainControlPanel.ResumeLayout(False)
        MainControlPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MainControlPanel As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox_DeviceSelection As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Slider_Main As VScrollBar
    Friend WithEvents Slider_SubY As VScrollBar
    Friend WithEvents Slider_SubX As VScrollBar
    Friend WithEvents Slider_16 As VScrollBar
    Friend WithEvents Slider_15 As VScrollBar
    Friend WithEvents Slider_14 As VScrollBar
    Friend WithEvents Slider_13 As VScrollBar
    Friend WithEvents Slider_12 As VScrollBar
    Friend WithEvents Slider_11 As VScrollBar
    Friend WithEvents Slider_10 As VScrollBar
    Friend WithEvents Slider_7 As VScrollBar
    Friend WithEvents Slider_6 As VScrollBar
    Friend WithEvents Slider_5 As VScrollBar
    Friend WithEvents Slider_4 As VScrollBar
    Friend WithEvents Slider_3 As VScrollBar
    Friend WithEvents Slider_2 As VScrollBar
    Friend WithEvents Slider_1 As VScrollBar
    Friend WithEvents Slider_9 As VScrollBar
    Friend WithEvents Slider_8 As VScrollBar
    Friend WithEvents Panel_ColorRight As Panel
    Friend WithEvents Panel_ColorMid As Panel
    Friend WithEvents Panel_ColorLeft As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button_StageRight As Button
    Friend WithEvents Button_StageMid As Button
    Friend WithEvents Button_StageLeft As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label_MIDICommunicationStatus As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_ModeToggle As Button
    Friend WithEvents Button_FullOn As Button
    Friend WithEvents Button_ToggleBlackout As Button
    Friend WithEvents Label_Mode As Label
    Friend WithEvents Button_PartyMode As Button
End Class
