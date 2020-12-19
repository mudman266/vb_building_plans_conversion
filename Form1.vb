Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValueToConvert.Text = ""
        radImpToMetric.Checked = True
        radMetricToImperial.Checked = False
        lblFinalValue.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decConversion As Decimal = 0.0
        ' Validate input
        If (String.IsNullOrEmpty(txtValueToConvert.Text) Or Not IsNumeric(txtValueToConvert.Text)) Then
            MsgBox("Value to convert is invalid. Try again.")
        Else
            ' Determine conversion type
            If (radImpToMetric.Checked) Then
                decConversion = 0.0253
            ElseIf (radMetricToImperial.Checked) Then
                decConversion = 39.37008
            End If
            Dim decFinalValue = txtValueToConvert.Text * decConversion
            lblFinalValue.Text = decFinalValue.ToString("F3")
        End If
    End Sub
End Class
