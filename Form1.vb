Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAddition.CheckedChanged
        Dim Number1, Number2, Result As Double
        If txtNumber1.Text = "" Then
            Number1 = 0
        Else
            Number1 = Convert.ToDouble(txtNumber1.Text)

        End If
        If txtNumber2.Text = "" Then
            Number2 = 0
        Else
            Number2 = Convert.ToDouble(txtNumber2.Text)
        End If
        Result = Number1 + Number2
        txtResult.Text = Result.ToString()

    End Sub

    Private Sub rdbSubstraction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSubstraction.CheckedChanged
        Dim Number1, Number2, Result As Double
        If txtNumber1.Text = "" Then
            Number1 = 0
        Else
            Number1 = Convert.ToDouble(txtNumber1.Text)

        End If
        If txtNumber2.Text = "" Then
            Number2 = 0
        Else
            Number2 = Convert.ToDouble(txtNumber2.Text)
        End If
        Result = Number1 - Number2
        txtResult.Text = Result.ToString()

    End Sub

    Private Sub rdbMultiplication_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMultiplication.CheckedChanged
        Dim Number1, Number2, Result As Double
        If txtNumber1.Text = "" Then
            Number1 = 0
        Else
            Number1 = Convert.ToDouble(txtNumber1.Text)

        End If
        If txtNumber2.Text = "" Then
            Number2 = 0
        Else
            Number2 = Convert.ToDouble(txtNumber2.Text)
        End If
        Result = Number1 * Number2
        txtResult.Text = Result.ToString()

    End Sub

    Private Sub rdbDivision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDivision.CheckedChanged
        Dim Number1, Number2, Result As Double
        If txtNumber1.Text = "" Then
            Number1 = 0
        Else
            Number1 = Convert.ToDouble(txtNumber1.Text)

        End If
        If txtNumber2.Text = "" Then
            Number2 = 0
        Else
            Number2 = Convert.ToDouble(txtNumber2.Text)
        End If
        Result = Number1 / Number2
        txtResult.Text = Result.ToString()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        txtResult.Text = ""

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
