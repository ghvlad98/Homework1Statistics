Imports System.Runtime.CompilerServices

Public Class Form1

    Dim input As String = String.Empty
    Dim operand1 As String = String.Empty
    Dim operand2 As String = String.Empty
    Dim operation As Char
    Dim result As Double = 0.0

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        If (Me.input.Length <= 0) Then
            Return
        Else
            Dim l As Integer = Me.UserInputText.Text.Length
            Me.UserInputText.Text = Me.UserInputText.Text.Remove(l - 1, 1)
            Me.input = Me.input.Remove(l - 1)
        End If
    End Sub

    Private Sub DivideButton_Click(sender As Object, e As EventArgs) Handles DivideButton.Click
        operand1 = input
        operation = "/"c
        input = String.Empty
    End Sub

    Private Sub SevenButton_Click(sender As Object, e As EventArgs) Handles SevenButton.Click
        Me.UserInputText.Text = ""
        input += "7"
        Me.UserInputText.Text += input
    End Sub

    Private Sub EightButton_Click(sender As Object, e As EventArgs) Handles EightButton.Click
        Me.UserInputText.Text = ""
        input += "8"
        Me.UserInputText.Text += input
    End Sub

    Private Sub NineButton_Click(sender As Object, e As EventArgs) Handles NineButton.Click
        Me.UserInputText.Text = ""
        input += "9"
        Me.UserInputText.Text += input
    End Sub

    Private Sub TimesButton_Click(sender As Object, e As EventArgs) Handles TimesButton.Click
        operand1 = input
        operation = "*"c
        input = String.Empty
    End Sub

    Private Sub FourButton_Click(sender As Object, e As EventArgs) Handles FourButton.Click
        Me.UserInputText.Text = ""
        input += "4"
        Me.UserInputText.Text += input
    End Sub

    Private Sub FiveButton_Click(sender As Object, e As EventArgs) Handles FiveButton.Click
        Me.UserInputText.Text = ""
        input += "5"
        Me.UserInputText.Text += input
    End Sub

    Private Sub SixButton_Click(sender As Object, e As EventArgs) Handles SixButton.Click
        Me.UserInputText.Text = ""
        input += "6"
        Me.UserInputText.Text += input
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        operand1 = input
        operation = "-"c
        input = String.Empty
    End Sub

    Private Sub OneButton_Click(sender As Object, e As EventArgs) Handles OneButton.Click
        Me.UserInputText.Text = ""
        input += "1"
        Me.UserInputText.Text += input
    End Sub

    Private Sub TwoButton_Click(sender As Object, e As EventArgs) Handles TwoButton.Click
        Me.UserInputText.Text = ""
        input += "2"
        Me.UserInputText.Text += input
    End Sub

    Private Sub ThreeButton_Click(sender As Object, e As EventArgs) Handles ThreeButton.Click
        Me.UserInputText.Text = ""
        input += "3"
        Me.UserInputText.Text += input
    End Sub

    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        operand1 = input
        operation = "+"c
        input = String.Empty
    End Sub

    Private Sub CEButton_Click(sender As Object, e As EventArgs) Handles CEButton.Click
        Me.UserInputText.Text = ""
        Me.input = String.Empty
        Me.operand1 = String.Empty
        Me.operand2 = String.Empty
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        Me.UserInputText.Text = ""
        input += "0"
        Me.UserInputText.Text += input
    End Sub

    Private Sub PointButton_Click(sender As Object, e As EventArgs) Handles PointButton.Click
        Me.UserInputText.Text = ""
        input += "."
        Me.UserInputText.Text += input
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        operand2 = input
        Dim num1, num2 As Double
        Double.TryParse(operand1, num1)
        Double.TryParse(operand2, num2)

        If (operation = "+"c) Then
            result = num1 + num2
            Me.UserInputText.Text = result.ToString()
            input = result.ToString()
        ElseIf (operation = "-"c) Then
            result = num1 - num2
            Me.UserInputText.Text = result.ToString()
            input = result.ToString()
        ElseIf (operation = "*"c) Then
            result = num1 * num2
            Me.UserInputText.Text = result.ToString()
            input = result.ToString()
        ElseIf (operation = "/"c) Then
            If (num2 <> 0) Then
                result = num1 / num2
                Me.UserInputText.Text = result.ToString()
                input = result.ToString()
            Else
                Me.UserInputText.Text = "Division by zero!"
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserInputText_MouseEnter(sender As Object, e As EventArgs) Handles UserInputText.MouseEnter
        Me.UserInputText.Text = Me.input
        Me.UserInputText.Text = ""
    End Sub

    Private Sub UserInputText_MouseLeave(sender As Object, e As EventArgs) Handles UserInputText.MouseLeave
        Me.UserInputText.Text = Me.input
    End Sub

    Private Sub UserInputText_TextChanged(sender As Object, e As EventArgs) Handles UserInputText.TextChanged

    End Sub
End Class
