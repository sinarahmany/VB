Public Class Form1
    Dim status As Boolean = False 'status 
    Dim clear As Boolean = False
    Dim first As Double, second As Double 'Save to  first and second value 
    Dim buttons As Integer



    'Regular calculater  
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim result As Double
        second = calbox.Text

        Select Case buttons
            Case Is = 1 ' plus
                result = first + second
            Case Is = 2 ' minus
                result = first - second
            Case Is = 3 ' divide 
                result = first * second
            Case Is = 4 ' subtract 
                result = first / second
            Case Is = 5

                Exit Sub


        End Select
        buttons = 5
        status = False
        clear = True
        calbox.Text = result




    End Sub
    ' Numbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "6"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "7"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "8"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If calbox.Text = "0" Then
            calbox.Text = ""
        ElseIf clear = True Then
            calbox.Text = ""
            clear = False

        End If

        status = True
        calbox.Text += "9"
    End Sub

    'Dot
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not (calbox.Text.Contains(".")) Then
            calbox.Text += "."
        End If
        status = True
    End Sub

    'Clear button

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        calbox.Text = "0"
        Button11.Enabled = True
        clear = False
        first = 0
        second = 0
        buttons = 0
        calbox.ForeColor = Color.Black
    End Sub

    'Divide key 
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        clear = True

        If status = True And buttons <> 0 Then
            Call conCal()
        End If

        first = calbox.Text

        If Button11.Enabled = False Then
            Button11.Enabled = True

        End If

        buttons = 4

    End Sub
    'Multiply key
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        clear = True

        If status = True And buttons <> 0 Then
            Call conCal()
        End If

        first = calbox.Text

        If Button11.Enabled = False Then
            Button11.Enabled = True

        End If

        buttons = 3
    End Sub
    'Subtract key
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        clear = True

        If status = True And buttons <> 0 Then
            Call conCal()
        End If

        first = calbox.Text

        If Button11.Enabled = False Then
            Button11.Enabled = True

        End If

        buttons = 2
    End Sub
    'Addition key
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        clear = True

        If status = True And buttons <> 0 Then
            Call conCal()
        End If

        first = calbox.Text

        If Button11.Enabled = False Then
            Button11.Enabled = True

        End If

        buttons = 1 ' Save Plus value
    End Sub

    'it is for multiple calculate 
    Sub conCal()
        Dim result As Double

        second = calbox.Text

        Select Case buttons
            Case Is = 1 ' plus
                result = first + second
            Case Is = 2 ' minus
                result = first - second
            Case Is = 3 ' divide 
                result = first * second
            Case Is = 4 ' subtract 
                result = first / second
            Case Is = 5
                Exit Sub
        End Select

        buttons = 5
        status = False
        calbox.Text = result
        first = result
        clear = True


    End Sub



    'text length color change
    Function adjust_text() As String
        Dim length As Single = calbox.Text.Length

        If length <= 12 Then
            calbox.ForeColor = Color.Black

        ElseIf length > 11 And length <= 19 Then
            calbox.ForeColor = Color.Black
            calbox.Font = New Font("arial", 20, FontStyle.Regular)

        ElseIf length > 20 Then
            calbox.ForeColor = Color.Red
            calbox.Font = New Font("arial", 20, FontStyle.Regular)
            MessageBox.Show("Over number bitch!")
        End If
    End Function


End Class
