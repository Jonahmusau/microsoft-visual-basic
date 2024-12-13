<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rdbAddition = New System.Windows.Forms.RadioButton()
        Me.rdbSubstraction = New System.Windows.Forms.RadioButton()
        Me.rdbMultiplication = New System.Windows.Forms.RadioButton()
        Me.rdbDivision = New System.Windows.Forms.RadioButton()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(442, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rdbAddition
        '
        Me.rdbAddition.AutoSize = True
        Me.rdbAddition.Location = New System.Drawing.Point(421, 12)
        Me.rdbAddition.Name = "rdbAddition"
        Me.rdbAddition.Size = New System.Drawing.Size(80, 21)
        Me.rdbAddition.TabIndex = 2
        Me.rdbAddition.TabStop = True
        Me.rdbAddition.Text = "Addition"
        Me.rdbAddition.UseVisualStyleBackColor = True
        '
        'rdbSubstraction
        '
        Me.rdbSubstraction.AutoSize = True
        Me.rdbSubstraction.Location = New System.Drawing.Point(421, 96)
        Me.rdbSubstraction.Name = "rdbSubstraction"
        Me.rdbSubstraction.Size = New System.Drawing.Size(108, 21)
        Me.rdbSubstraction.TabIndex = 3
        Me.rdbSubstraction.TabStop = True
        Me.rdbSubstraction.Text = "Substraction"
        Me.rdbSubstraction.UseVisualStyleBackColor = True
        '
        'rdbMultiplication
        '
        Me.rdbMultiplication.AutoSize = True
        Me.rdbMultiplication.Location = New System.Drawing.Point(421, 182)
        Me.rdbMultiplication.Name = "rdbMultiplication"
        Me.rdbMultiplication.Size = New System.Drawing.Size(110, 21)
        Me.rdbMultiplication.TabIndex = 4
        Me.rdbMultiplication.TabStop = True
        Me.rdbMultiplication.Text = "Multiplication"
        Me.rdbMultiplication.UseVisualStyleBackColor = True
        '
        'rdbDivision
        '
        Me.rdbDivision.AutoSize = True
        Me.rdbDivision.Location = New System.Drawing.Point(421, 297)
        Me.rdbDivision.Name = "rdbDivision"
        Me.rdbDivision.Size = New System.Drawing.Size(78, 21)
        Me.rdbDivision.TabIndex = 5
        Me.rdbDivision.TabStop = True
        Me.rdbDivision.Text = "Division"
        Me.rdbDivision.UseVisualStyleBackColor = True
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(42, 16)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(70, 17)
        Me.lblNumber1.TabIndex = 6
        Me.lblNumber1.Text = "Number 1"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(42, 158)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(70, 17)
        Me.lblNumber2.TabIndex = 7
        Me.lblNumber2.Text = "Number 2"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(42, 283)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(48, 17)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Result"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(170, 13)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber1.TabIndex = 9
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(170, 153)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber2.TabIndex = 10
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(170, 283)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 22)
        Me.txtResult.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 424)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.rdbDivision)
        Me.Controls.Add(Me.rdbMultiplication)
        Me.Controls.Add(Me.rdbSubstraction)
        Me.Controls.Add(Me.rdbAddition)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rdbAddition As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSubstraction As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
