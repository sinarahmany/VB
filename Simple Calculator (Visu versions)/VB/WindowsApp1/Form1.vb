Public Class sina
    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim Operations As Integer
    Dim sum As Decimal = Firstnum + secondnum
    Dim subti As Decimal = Firstnum - secondnum
    Dim mul As Decimal = Firstnum * secondnum
    Dim Operator_selctor As Boolean = False

    Private Sub calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Operator_selctor = True Then
            secondnum = TextBox1.Text
            

            If Operations = 1 Then
                TextBox1.Text = sum + secondnum
            ElseIf Operations = 2 Then
                TextBox1.Text = Firstnum - secondnum
            ElseIf Operations = 3 Then
                TextBox1.Text = mul * secondnum
            Else
                    If secondnum = 0 Then
                        TextBox1.Text = "infinity!!!"
                    Else
                        TextBox1.Text = Firstnum / secondnum
                    End If
                End If
            Operator_selctor = False

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
            sum += 1
            subti += 1
            mul *= 1
        Else
            TextBox1.Text = "1"
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
            sum += 2
            mul *= 2
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
            sum += 3
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
            sum += 4
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
            sum += 5
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
            sum += 6
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
            sum += 7
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
            sum += 8
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
            sum += 9
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = "0"
        sum = 0
        subti = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = ""
        Operator_selctor = True
        Operations = 1 ' = +

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = ""
        Operator_selctor = True
        Operations = 2 ' - -
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = ""
        Operator_selctor = True
        Operations = 3 '=x
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = ""
        Operator_selctor = True
        Operations = 4 ' /
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
