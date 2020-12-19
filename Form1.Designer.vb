<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radMetricToImperial = New System.Windows.Forms.RadioButton()
        Me.radImpToMetric = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblValueToConvert = New System.Windows.Forms.Label()
        Me.txtValueToConvert = New System.Windows.Forms.TextBox()
        Me.lblConversionType = New System.Windows.Forms.Label()
        Me.lblConvertedValue = New System.Windows.Forms.Label()
        Me.lblFinalValue = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblConversionType)
        Me.Panel1.Controls.Add(Me.radMetricToImperial)
        Me.Panel1.Controls.Add(Me.radImpToMetric)
        Me.Panel1.Location = New System.Drawing.Point(132, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 107)
        Me.Panel1.TabIndex = 0
        '
        'radMetricToImperial
        '
        Me.radMetricToImperial.AutoSize = True
        Me.radMetricToImperial.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMetricToImperial.Location = New System.Drawing.Point(3, 70)
        Me.radMetricToImperial.Name = "radMetricToImperial"
        Me.radMetricToImperial.Size = New System.Drawing.Size(177, 23)
        Me.radMetricToImperial.TabIndex = 1
        Me.radMetricToImperial.Text = "Metric to Imperial"
        Me.radMetricToImperial.UseVisualStyleBackColor = True
        '
        'radImpToMetric
        '
        Me.radImpToMetric.AutoSize = True
        Me.radImpToMetric.Checked = True
        Me.radImpToMetric.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radImpToMetric.Location = New System.Drawing.Point(3, 41)
        Me.radImpToMetric.Name = "radImpToMetric"
        Me.radImpToMetric.Size = New System.Drawing.Size(177, 23)
        Me.radImpToMetric.TabIndex = 0
        Me.radImpToMetric.TabStop = True
        Me.radImpToMetric.Text = "Imperial to Metric"
        Me.radImpToMetric.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(44, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(383, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Building Plans Conversion"
        '
        'lblValueToConvert
        '
        Me.lblValueToConvert.AutoSize = True
        Me.lblValueToConvert.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueToConvert.Location = New System.Drawing.Point(18, 83)
        Me.lblValueToConvert.Name = "lblValueToConvert"
        Me.lblValueToConvert.Size = New System.Drawing.Size(198, 24)
        Me.lblValueToConvert.TabIndex = 2
        Me.lblValueToConvert.Text = "Value to convert:"
        '
        'txtValueToConvert
        '
        Me.txtValueToConvert.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueToConvert.Location = New System.Drawing.Point(222, 80)
        Me.txtValueToConvert.Name = "txtValueToConvert"
        Me.txtValueToConvert.Size = New System.Drawing.Size(100, 32)
        Me.txtValueToConvert.TabIndex = 3
        '
        'lblConversionType
        '
        Me.lblConversionType.AutoSize = True
        Me.lblConversionType.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversionType.Location = New System.Drawing.Point(3, 0)
        Me.lblConversionType.Name = "lblConversionType"
        Me.lblConversionType.Size = New System.Drawing.Size(201, 24)
        Me.lblConversionType.TabIndex = 4
        Me.lblConversionType.Text = "Conversion Type:"
        '
        'lblConvertedValue
        '
        Me.lblConvertedValue.AutoSize = True
        Me.lblConvertedValue.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedValue.Location = New System.Drawing.Point(45, 267)
        Me.lblConvertedValue.Name = "lblConvertedValue"
        Me.lblConvertedValue.Size = New System.Drawing.Size(197, 24)
        Me.lblConvertedValue.TabIndex = 4
        Me.lblConvertedValue.Text = "Converted Value:"
        '
        'lblFinalValue
        '
        Me.lblFinalValue.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalValue.Location = New System.Drawing.Point(248, 267)
        Me.lblFinalValue.Name = "lblFinalValue"
        Me.lblFinalValue.Size = New System.Drawing.Size(177, 24)
        Me.lblFinalValue.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(76, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 63)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(263, 337)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 63)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inches/Meters"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFinalValue)
        Me.Controls.Add(Me.lblConvertedValue)
        Me.Controls.Add(Me.txtValueToConvert)
        Me.Controls.Add(Me.lblValueToConvert)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "Building Plans Conversion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents radMetricToImperial As RadioButton
    Friend WithEvents radImpToMetric As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblValueToConvert As Label
    Friend WithEvents txtValueToConvert As TextBox
    Friend WithEvents lblConversionType As Label
    Friend WithEvents lblConvertedValue As Label
    Friend WithEvents lblFinalValue As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
End Class
