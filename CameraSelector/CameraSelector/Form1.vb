Public Class Form1
    Private Sub TrackBarDistance_Scroll(sender As Object, e As EventArgs) Handles TrackBarDistance.Scroll
        NumericUpDownDistance.Value = TrackBarDistance.Value / 10
        CalcDistance()
    End Sub

    Private Sub TrackBarHeight_Scroll(sender As Object, e As EventArgs) Handles TrackBarHeight.Scroll
        NumericUpDownHeight.Value = TrackBarHeight.Value / 10
        CalcDistance()
    End Sub

    Private Sub TrackBarCameraHeight_Scroll(sender As Object, e As EventArgs) Handles TrackBarCameraHeight.Scroll
        NumericUpDownCameraHeight.Value = TrackBarCameraHeight.Value / 10
        CalcDistance()
    End Sub


    Private Sub CalcDistance()
        Dim height = NumericUpDownHeight.Value - NumericUpDownCameraHeight.Value
        Dim width = NumericUpDownDistance.Value

        Dim distance = Math.Sqrt(height ^ 2 + width ^ 2)

        LabelResult.Text = distance

        '// 画面の角度
        'Dim angleOfView = CalcCameraAngleOfViewInRadian(TextBox1.Text) * 180 / Math.PI
        Dim angleOfView = CalcCameraAngleOfViewInRadian(TextBox1.Text)

        '// フレームに入っている距離横幅
        Dim frameMeter = distance * Math.Sin(angleOfView / 2) * 2

        '// 像面での顔の幅、割合
        Dim faceRate = 160 / (frameMeter * 1000)



        '// 顔の画素数
        Dim pixcel = CInt(TextBoxPixWidth.Text) '// 横の画素数
        Dim facePixcel = pixcel * faceRate


        'LabelResult.Text = frameMeter & " : " & faceRate * 100 & "% : " & facePixcel


        Dim result = ""

        If facePixcel > 500 Then
            result = "表情認識"
        ElseIf facePixcel > 250 Then
            result = "性別認識"
        ElseIf facePixcel > 125 Then
            result = "顔認識"
        ElseIf facePixcel > 25 Then
            result = "検出"
        Else
            result = "--"
        End If

        LabelFacePxPerM.Text = facePixcel.ToString & vbNewLine & result
    End Sub

    Private Function CalcCameraAngleOfViewInRadian(lenseLength As Integer) As Double
        '2 * atan(imageSenderSize/(2*lenslength))

        Dim frameSize = 36 '// mm
        Dim angleOfView = 2 * Math.Atan(frameSize / (2 * lenseLength))

        Return angleOfView

    End Function
End Class
