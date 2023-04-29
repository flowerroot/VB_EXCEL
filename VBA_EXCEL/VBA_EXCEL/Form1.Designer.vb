<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Run = New System.Windows.Forms.Button()
        Me.meeting_path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CAM1_path = New System.Windows.Forms.TextBox()
        Me.CAM2_path = New System.Windows.Forms.TextBox()
        Me.CAM3_path = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_ID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.TextBox()
        Me.Search_path = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.CAM1_RadioButton = New System.Windows.Forms.RadioButton()
        Me.CAM3_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Start_Point_TextBox = New System.Windows.Forms.TextBox()
        Me.End_Point_TextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Sheet_TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Run
        '
        Me.Run.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Run.Location = New System.Drawing.Point(712, 301)
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(75, 23)
        Me.Run.TabIndex = 0
        Me.Run.Text = "Run"
        Me.Run.UseVisualStyleBackColor = True
        '
        'meeting_path
        '
        Me.meeting_path.Location = New System.Drawing.Point(101, 12)
        Me.meeting_path.Name = "meeting_path"
        Me.meeting_path.Size = New System.Drawing.Size(687, 21)
        Me.meeting_path.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "미팅자료 경로"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Panel info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CAM #1 경로"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CAM #2 경로"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CAM #3 경로"
        '
        'CAM1_path
        '
        Me.CAM1_path.Location = New System.Drawing.Point(101, 39)
        Me.CAM1_path.Name = "CAM1_path"
        Me.CAM1_path.Size = New System.Drawing.Size(687, 21)
        Me.CAM1_path.TabIndex = 7
        Me.CAM1_path.Text = "\\200.100.1.100\D\RESULT_DATA"
        '
        'CAM2_path
        '
        Me.CAM2_path.Location = New System.Drawing.Point(101, 66)
        Me.CAM2_path.Name = "CAM2_path"
        Me.CAM2_path.Size = New System.Drawing.Size(687, 21)
        Me.CAM2_path.TabIndex = 8
        Me.CAM2_path.Text = "\\200.100.1.101\D\RESULT_DATA"
        '
        'CAM3_path
        '
        Me.CAM3_path.Location = New System.Drawing.Point(101, 93)
        Me.CAM3_path.Name = "CAM3_path"
        Me.CAM3_path.Size = New System.Drawing.Size(687, 21)
        Me.CAM3_path.TabIndex = 9
        Me.CAM3_path.Text = "\\200.100.1.102\D\RESULT_DATA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "A0 위치"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Panel ID"
        '
        'Panel_ID
        '
        Me.Panel_ID.Enabled = False
        Me.Panel_ID.Location = New System.Drawing.Point(101, 214)
        Me.Panel_ID.Name = "Panel_ID"
        Me.Panel_ID.Size = New System.Drawing.Size(687, 21)
        Me.Panel_ID.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Grid"
        '
        'Grid
        '
        Me.Grid.Enabled = False
        Me.Grid.Location = New System.Drawing.Point(101, 240)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(687, 21)
        Me.Grid.TabIndex = 16
        '
        'Search_path
        '
        Me.Search_path.Enabled = False
        Me.Search_path.Location = New System.Drawing.Point(101, 267)
        Me.Search_path.Name = "Search_path"
        Me.Search_path.Size = New System.Drawing.Size(687, 21)
        Me.Search_path.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 12)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Search 경로"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 335)
        Me.Splitter1.TabIndex = 19
        Me.Splitter1.TabStop = False
        '
        'CAM1_RadioButton
        '
        Me.CAM1_RadioButton.AutoSize = True
        Me.CAM1_RadioButton.Location = New System.Drawing.Point(101, 121)
        Me.CAM1_RadioButton.Name = "CAM1_RadioButton"
        Me.CAM1_RadioButton.Size = New System.Drawing.Size(67, 16)
        Me.CAM1_RadioButton.TabIndex = 20
        Me.CAM1_RadioButton.TabStop = True
        Me.CAM1_RadioButton.Text = "CAM #1"
        Me.CAM1_RadioButton.UseVisualStyleBackColor = True
        '
        'CAM3_RadioButton
        '
        Me.CAM3_RadioButton.AutoSize = True
        Me.CAM3_RadioButton.Location = New System.Drawing.Point(174, 121)
        Me.CAM3_RadioButton.Name = "CAM3_RadioButton"
        Me.CAM3_RadioButton.Size = New System.Drawing.Size(67, 16)
        Me.CAM3_RadioButton.TabIndex = 21
        Me.CAM3_RadioButton.TabStop = True
        Me.CAM3_RadioButton.Text = "CAM #3"
        Me.CAM3_RadioButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(400, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 12)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "행 부터 ~"
        '
        'Start_Point_TextBox
        '
        Me.Start_Point_TextBox.Location = New System.Drawing.Point(294, 143)
        Me.Start_Point_TextBox.Name = "Start_Point_TextBox"
        Me.Start_Point_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Start_Point_TextBox.TabIndex = 23
        Me.Start_Point_TextBox.Text = "3"
        Me.Start_Point_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'End_Point_TextBox
        '
        Me.End_Point_TextBox.Location = New System.Drawing.Point(464, 143)
        Me.End_Point_TextBox.Name = "End_Point_TextBox"
        Me.End_Point_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.End_Point_TextBox.TabIndex = 24
        Me.End_Point_TextBox.Text = "4"
        Me.End_Point_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(570, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 12)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "행 까지"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 12)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "작업 범위"
        '
        'Sheet_TextBox
        '
        Me.Sheet_TextBox.Location = New System.Drawing.Point(101, 143)
        Me.Sheet_TextBox.Name = "Sheet_TextBox"
        Me.Sheet_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.Sheet_TextBox.TabIndex = 27
        Me.Sheet_TextBox.Text = "11"
        Me.Sheet_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(207, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 12)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "번째 Sheet 의"
        '
        'Progress
        '
        Me.Progress.Enabled = False
        Me.Progress.Location = New System.Drawing.Point(101, 294)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(293, 21)
        Me.Progress.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 335)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Sheet_TextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.End_Point_TextBox)
        Me.Controls.Add(Me.Start_Point_TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CAM3_RadioButton)
        Me.Controls.Add(Me.CAM1_RadioButton)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Search_path)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CAM3_path)
        Me.Controls.Add(Me.CAM2_path)
        Me.Controls.Add(Me.CAM1_path)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.meeting_path)
        Me.Controls.Add(Me.Run)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Run As Button
    Friend WithEvents meeting_path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CAM1_path As TextBox
    Friend WithEvents CAM2_path As TextBox
    Friend WithEvents CAM3_path As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Grid As TextBox
    Friend WithEvents Search_path As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents CAM1_RadioButton As RadioButton
    Friend WithEvents CAM3_RadioButton As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Start_Point_TextBox As TextBox
    Friend WithEvents End_Point_TextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Sheet_TextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Progress As TextBox
End Class
