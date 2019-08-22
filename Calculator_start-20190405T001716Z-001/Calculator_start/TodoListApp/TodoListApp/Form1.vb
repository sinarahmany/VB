Public Class Form1

    Dim numi1 As Decimal
    Dim op As Boolean = False
    Dim numi2 As Decimal
    Dim operation As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControl1.SelectTab(TabPage3)
        TabControl1.SelectTab(2)

    End Sub

    'add to the list
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If taskBar.Text = "" Then
            statusMessage.Text = "please type your task and hit the botton"
            statusMessage.ForeColor = Color.Red
        Else
            Dim task As String = taskBar.Text
            'task = LTrim(RTrim(task))
            task = Trim(task)
            todoList.Items.Add(task + "    Time : " + Format(Now, "hh:mm").ToString)
            taskBar.Clear()
            statusMessage.Text = "please type your task and hit the botton"
            statusMessage.ForeColor = Color.White
        End If
    End Sub

    'clear all button
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'check if the list is empty
        Dim listCounter As Integer = todoList.Items.Count

        If listCounter > 0 Then
            'ask are you sure message
            DialogResult = MessageBox.Show("Are you sure you want to delete ALL?", "WARNING", MessageBoxButtons.YesNo)

            If DialogResult.ToString = "Yes" Then
                todoList.Items.Clear()
                statusMessage.Text = "to do list cleared"
                statusMessage.ForeColor = Color.Red
            Else
                'no action
            End If
        Else
            statusMessage.Text = "List is empty"
            statusMessage.ForeColor = Color.Red
        End If
    End Sub
    'Delete button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        '                        != not equal 
        If todoList.SelectedItem <> "" Then
            'selected
            DialogResult = MessageBox.Show("are you sure you want to delete this?", "WARNING", MessageBoxButtons.OKCancel)

            If DialogResult.ToString = "OK" Then
                todoList.Items.Remove(todoList.SelectedItem)
                statusMessage.Text = "item deleted successfully"
            Else
                'no action
            End If
        Else
            'not selected
            statusMessage.Text = "Select an item first!"
            statusMessage.ForeColor = Color.Red
        End If

    End Sub
    Private Sub taskBar_TextChanged_1(sender As Object, e As EventArgs) Handles taskBar.TextChanged
        statusMessage.Text = "please type your task and hit the botton"
        statusMessage.ForeColor = Color.White
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For index = 1 To 10 Step +1
            'RichTextBox1.Text = RichTextBox1.Text + index.ToString + vbCrLf
            RichTextBox1.Text += index.ToString + vbCrLf
        Next

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If IsNumeric(input1.Text) And IsNumeric(input2.Text) Then
            Dim userInput1 As Integer = Convert.ToInt64(input1.Text)
            Dim userInput2 As Integer = Convert.ToInt64(input2.Text)

            If userInput1 < userInput2 Then
                'userinput 1 is greater
                RichTextBox1.Text = "the min value is : " + userInput1.ToString
            Else
                'userinput 2 is greater
                RichTextBox1.Text = "the min value is : " + userInput2.ToString
            End If
        Else
            MessageBox.Show("not number!!")
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        'ten times my name

        For index = 1 To 10
            RichTextBox1.Text += "Saygin" + vbCrLf
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim sum As Integer = 0

        For index = 1 To 100 Step +1
            sum += index
        Next

        RichTextBox1.Text = "for loop result : " + sum.ToString
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        For index = 10 To 1 Step -1
            'RichTextBox1.Text = RichTextBox1.Text + index.ToString + vbCrLf
            RichTextBox1.Text += index.ToString + vbCrLf

        Next

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If IsNumeric(input1.Text) And IsNumeric(input2.Text) Then
            Dim userInput1 As Integer = Convert.ToInt64(input1.Text)
            Dim userInput2 As Integer = Convert.ToInt64(input2.Text)

            If userInput1 > userInput2 Then
                'userinput 1 is greater
                RichTextBox1.Text = "the max value is : " + userInput1.ToString
            Else
                'userinput 2 is greater
                RichTextBox1.Text = "the max value is : " + userInput2.ToString
            End If
        Else
            MessageBox.Show("not number!!")
        End If

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim index As Integer = 0

        While index <= 100

            If index Mod 2 = 0 Then
                RichTextBox1.Text += index.ToString + " "

            End If

            index += 1

        End While

    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        For index = 1 To 100

            Dim Flag As Boolean = True

            If index <= 1 Then
                Continue For
            End If

            If index = 2 Then
                RichTextBox1.Text += index.ToString + " is prime" + vbCrLf
                Continue For
            End If

            'check if its prime
            For counter = 2 To Math.Sqrt(index) + 1
                If index Mod counter = 0 Then
                    Flag = False
                    Exit For
                    'if I dont exit I will check the next counter for no reason
                    RichTextBox1.Text += "tried to divide by " + counter.ToString + " "
                End If
            Next

            If Flag = True Then
                RichTextBox1.Text += index.ToString + " is prime" + vbCrLf
            End If
        Next

    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click

        Dim sum As Integer = 0
        Dim index As Integer = 1

        Do
            sum += index
            index += 1
        Loop Until index > 100


        RichTextBox1.Text = "Do loop result : " + sum.ToString


    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Dim sum As Integer = 0
        Dim index As Integer = 1

        While index <= 100
            sum += index
            index += 1
        End While

        RichTextBox1.Text = "While loop result : " + sum.ToString

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        ' 1 3 5 7 9 11 .... 99
        Dim index As Integer = 0

        While index <= 100

            If index Mod 2 = 1 Then
                RichTextBox1.Text += index.ToString + " "

            End If

            index += 1

        End While

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.Clear()
    End Sub


    Private Sub OperatorClear_Click(sender As Object, e As EventArgs) Handles OperatorClear.Click
        calcScreen.Clear()
        op = False
        numi1 = Nothing
        numi2 = Nothing
    End Sub

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        If op = False Then

            Dim n1 As Decimal = 1
            calcScreen.Text += n1.ToString
            numi1 = int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 1.ToString
            numi2 = Val(calcScreen.Text)

        End If

    End Sub


    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        If op = False Then

            Dim n2 As Decimal = 2
            calcScreen.Text += n2.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 2.ToString
            numi2 = Val(calcScreen.Text)

        End If

    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        If op = False Then

            Dim n3 As Decimal = 3
            calcScreen.Text += n3.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 3.ToString
            numi2 = Val(calcScreen.Text)

        End If
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        If op = False Then

            Dim n4 As Decimal = 4
            calcScreen.Text += n4.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 4.ToString
            numi2 = Val(calcScreen.Text)

        End If

    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click

        If op = False Then

            Dim n5 As Decimal = 5
            calcScreen.Text += n5.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 5.ToString
            numi2 = Val(calcScreen.Text)

        End If


    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        If op = False Then

            Dim n6 As Decimal = 6
            calcScreen.Text += n6.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 6.ToString
            numi2 = Val(calcScreen.Text)

        End If
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        If op = False Then

            Dim n7 As Decimal = 7
            calcScreen.Text += n7.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 7.ToString
            numi2 = Val(calcScreen.Text)

        End If



    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        If op = False Then

            Dim n8 As Decimal = 8
            calcScreen.Text += n8.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 8.ToString
            numi2 = Val(calcScreen.Text)

        End If


    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        If op = False Then

            Dim n9 As Decimal = 9
            calcScreen.Text += n9.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 9.ToString
            numi2 = Val(calcScreen.Text)

        End If


    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        If op = False Then

            Dim n0 As Decimal = 0
            calcScreen.Text += n0.ToString
            numi1 = Int(calcScreen.Text)
            op = True
        Else
            calcScreen.Text += 0.ToString
            numi2 = Val(calcScreen.Text)

        End If
    End Sub


    Private Sub OperatorPlus_Click(sender As Object, e As EventArgs) Handles OperatorPlus.Click
        calcScreen.Clear()
        operation = "+"



    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click







        If operation = "*" Then
            calcScreen.Text = (numi1 * numi2).ToString
        Else
            If operation = "+" Then
                calcScreen.Text as double = (numi1 + numi2).ToString
                
            Else
                If operation = "-" Then
                    calcScreen.Text = (numi1 - numi2).ToString
                Else
                    calcScreen.Text = (numi1 / numi2).ToString
                End If

            End If
        End If
        'it automatically showed infinity when we divide a number by zero so that`s why i didn`t add if statement for this condition






    End Sub

    Private Sub OperatorMultiply_Click(sender As Object, e As EventArgs) Handles OperatorMultiply.Click
        calcScreen.Clear()
        operation = "*"

    End Sub

    Private Sub OperatorMinus_Click(sender As Object, e As EventArgs) Handles OperatorMinus.Click
        calcScreen.Clear()
        operation = "-"
    End Sub

    Private Sub OperatorDivide_Click(sender As Object, e As EventArgs) Handles OperatorDivide.Click
        calcScreen.Clear()
        operation = "/"
    End Sub

    Private Sub NumDot_Click(sender As Object, e As EventArgs) Handles NumDot.Click
        If Not (calcScreen.Text.Contains(".")) Then
            calcScreen.Text += "."
        End If
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub
End Class
