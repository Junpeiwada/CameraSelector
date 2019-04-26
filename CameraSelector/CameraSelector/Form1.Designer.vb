<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TrackBarDistance = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownDistance = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHeight = New System.Windows.Forms.NumericUpDown()
        Me.TrackBarHeight = New System.Windows.Forms.TrackBar()
        Me.NumericUpDownCameraHeight = New System.Windows.Forms.NumericUpDown()
        Me.TrackBarCameraHeight = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelFacePxPerM = New System.Windows.Forms.Label()
        Me.TextBoxPixWidth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.TrackBarDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCameraHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarCameraHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBarDistance
        '
        Me.TrackBarDistance.Location = New System.Drawing.Point(29, 60)
        Me.TrackBarDistance.Maximum = 1000
        Me.TrackBarDistance.Name = "TrackBarDistance"
        Me.TrackBarDistance.Size = New System.Drawing.Size(370, 45)
        Me.TrackBarDistance.TabIndex = 0
        Me.TrackBarDistance.TickFrequency = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "被写体までの距離"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "被写体高さ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "カメラの高さ"
        '
        'NumericUpDownDistance
        '
        Me.NumericUpDownDistance.DecimalPlaces = 1
        Me.NumericUpDownDistance.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownDistance.Location = New System.Drawing.Point(193, 31)
        Me.NumericUpDownDistance.Name = "NumericUpDownDistance"
        Me.NumericUpDownDistance.Size = New System.Drawing.Size(120, 19)
        Me.NumericUpDownDistance.TabIndex = 4
        Me.NumericUpDownDistance.Value = New Decimal(New Integer() {11, 0, 0, 65536})
        '
        'NumericUpDownHeight
        '
        Me.NumericUpDownHeight.DecimalPlaces = 1
        Me.NumericUpDownHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownHeight.Location = New System.Drawing.Point(193, 107)
        Me.NumericUpDownHeight.Name = "NumericUpDownHeight"
        Me.NumericUpDownHeight.Size = New System.Drawing.Size(120, 19)
        Me.NumericUpDownHeight.TabIndex = 6
        Me.NumericUpDownHeight.Value = New Decimal(New Integer() {11, 0, 0, 65536})
        '
        'TrackBarHeight
        '
        Me.TrackBarHeight.Location = New System.Drawing.Point(29, 136)
        Me.TrackBarHeight.Maximum = 1000
        Me.TrackBarHeight.Name = "TrackBarHeight"
        Me.TrackBarHeight.Size = New System.Drawing.Size(370, 45)
        Me.TrackBarHeight.TabIndex = 5
        Me.TrackBarHeight.TickFrequency = 100
        '
        'NumericUpDownCameraHeight
        '
        Me.NumericUpDownCameraHeight.DecimalPlaces = 1
        Me.NumericUpDownCameraHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownCameraHeight.Location = New System.Drawing.Point(193, 187)
        Me.NumericUpDownCameraHeight.Name = "NumericUpDownCameraHeight"
        Me.NumericUpDownCameraHeight.Size = New System.Drawing.Size(120, 19)
        Me.NumericUpDownCameraHeight.TabIndex = 8
        Me.NumericUpDownCameraHeight.Value = New Decimal(New Integer() {11, 0, 0, 65536})
        '
        'TrackBarCameraHeight
        '
        Me.TrackBarCameraHeight.Location = New System.Drawing.Point(29, 216)
        Me.TrackBarCameraHeight.Maximum = 1000
        Me.TrackBarCameraHeight.Name = "TrackBarCameraHeight"
        Me.TrackBarCameraHeight.Size = New System.Drawing.Size(370, 45)
        Me.TrackBarCameraHeight.TabIndex = 7
        Me.TrackBarCameraHeight.TickFrequency = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "検出 25px/m"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "人の顔の大きさ 幅160mm"
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(241, 336)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(75, 12)
        Me.LabelResult.TabIndex = 11
        Me.LabelResult.Text = "必要な解像度"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 390)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "100"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "レンズ焦点距離35mm換算mm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "px/m"
        '
        'LabelFacePxPerM
        '
        Me.LabelFacePxPerM.AutoSize = True
        Me.LabelFacePxPerM.Location = New System.Drawing.Point(356, 290)
        Me.LabelFacePxPerM.Name = "LabelFacePxPerM"
        Me.LabelFacePxPerM.Size = New System.Drawing.Size(38, 12)
        Me.LabelFacePxPerM.TabIndex = 16
        Me.LabelFacePxPerM.Text = "Label8"
        '
        'TextBoxPixWidth
        '
        Me.TextBoxPixWidth.Location = New System.Drawing.Point(120, 450)
        Me.TextBoxPixWidth.Name = "TextBoxPixWidth"
        Me.TextBoxPixWidth.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxPixWidth.TabIndex = 17
        Me.TextBoxPixWidth.Text = "3000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(121, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "水平画素数"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 526)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxPixWidth)
        Me.Controls.Add(Me.LabelFacePxPerM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownCameraHeight)
        Me.Controls.Add(Me.TrackBarCameraHeight)
        Me.Controls.Add(Me.NumericUpDownHeight)
        Me.Controls.Add(Me.NumericUpDownDistance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBarDistance)
        Me.Controls.Add(Me.TrackBarHeight)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBarDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCameraHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarCameraHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBarDistance As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownDistance As NumericUpDown
    Friend WithEvents NumericUpDownHeight As NumericUpDown
    Friend WithEvents TrackBarHeight As TrackBar
    Friend WithEvents NumericUpDownCameraHeight As NumericUpDown
    Friend WithEvents TrackBarCameraHeight As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelFacePxPerM As Label
    Friend WithEvents TextBoxPixWidth As TextBox
    Friend WithEvents Label8 As Label
End Class
