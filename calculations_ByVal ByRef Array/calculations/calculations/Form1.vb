Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'call the factorial function
        RichTextBox1.Text += "The result of factorial(5) is: " _
             + factorial(5).ToString + vbCrLf

        'call the recursion function
        RichTextBox1.Text += "The result of factorialWithRecursion(5) is: " _
             + factorialWithRecursion(5).ToString + vbCrLf + vbCrLf

        'print all first 10 fibonacci numbers
        RichTextBox1.Text += "___the words inside the sentences" + vbCrLf
        For index = 1 To 10
            RichTextBox1.Text += "fibonacci(" + index.ToString + ") is : " + fibonacci(index).ToString + vbCrLf
        Next

        '2 lines break
        RichTextBox1.Text += vbCrLf + vbCrLf

        'create array and initialize with student names
        Dim userNames() As String = {
            "jose", "mariana", "daniel",
            "mykhailo", "wade", "alex", "naoya",
            "sina", "siamak", "saygin"
        }

        'loop through and print all names
        RichTextBox1.Text += "____List of the students" + vbCrLf

        For index = 1 To 9
            RichTextBox1.Text += userNames(index) + vbCrLf
        Next


        '2 lines break
        RichTextBox1.Text += vbCrLf + vbCrLf
        RichTextBox1.Text += "___the words inside the sentences" + vbCrLf

        'create a string and split it into words
        Dim sentences = New String("Hello Visual Basic, you have challanging syntax")
        Dim words As Array = sentences.Split()

        'loop through and print all words inside the sentences
        For Each word As String In words
            RichTextBox1.Text += word + vbCrLf
        Next

        RichTextBox1.Text += addition(5, 10).ToString + vbCrLf '15
        RichTextBox1.Text += subtract(5, 10).ToString + vbCrLf ' -5
        RichTextBox1.Text += divide(10, 5).ToString + vbCrLf ' 2
        RichTextBox1.Text += multiply(5, 10).ToString + vbCrLf ' 50


        RichTextBox1.Text += addition(5, 10, 15).ToString + vbCrLf '30
        RichTextBox1.Text += addition(5, 10, 15).ToString + vbCrLf '30
        RichTextBox1.Text += addition(1, 2, 3, 4, 5, 6, 7, 8, 9, 10).ToString + vbCrLf '55

        RichTextBox1.Text += multiply(addition(5, 4), 2).ToString + vbCrLf + vbCrLf

        Dim firstNum As Integer = 10
        Dim secondNum As Integer = 10

        RichTextBox1.Text += "before calling the function" + vbCrLf +
                             " firstNum is : " + firstNum.ToString + vbCrLf +
                             " secondNum is : " + secondNum.ToString + vbCrLf + vbCrLf

        RichTextBox1.Text += "When we call the function" + vbCrLf +
                             " donotmodify(firstNum) value is : " + donotmodify(firstNum).ToString + vbCrLf +
                             " modify(secondNum) value is : " + modify(secondNum).ToString + vbCrLf + vbCrLf

        RichTextBox1.Text += "after calling the function" + vbCrLf +
                             " firstNum is : " + firstNum.ToString + vbCrLf +
                             " secondNum is : " + secondNum.ToString + vbCrLf


    End Sub


    Function donotmodify(ByVal number As Integer)
        number += 1
        Return number
    End Function

    Function modify(ByRef number As Integer)
        number += 1
        Return number
    End Function

    Function factorial(number As Integer)

        Dim sum As Integer = 1

        For index = number To 1 Step -1
            sum *= index
        Next

        Return sum

    End Function

    Function factorialWithRecursion(number As Integer)

        'If number = 1 Then
        '    Return 1
        'Else
        '    Return number * factorialWithRecursion(number - 1)
        'End If

        If number = 1 Then Return 1

        Return number * factorialWithRecursion(number - 1)

    End Function

    Function fibonacci(number As Integer)

        If number = 1 Then Return 0
        If number = 2 Then Return 1

        Return fibonacci(number - 1) + fibonacci(number - 2)

    End Function


    'arguments
    Function addition(ByVal ParamArray thepassingvalues() As Integer) As Integer
        Dim sum As Integer = 0
        If thepassingvalues.Length <= 0 Then Return 0
        For i As Integer = 0 To UBound(thepassingvalues, 1)
            sum += thepassingvalues(i)
        Next i
        Return sum
    End Function

    Function subtract(num1 As Integer, num2 As Integer)
        Return num1 - num2
    End Function

    Function multiply(num1 As Integer, num2 As Integer)
        Return num1 * num2
    End Function

    Function divide(num1 As Integer, num2 As Integer)
        Return num1 / num2
    End Function


End Class

