<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.todoList = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.statusMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taskBar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.calcScreen = New System.Windows.Forms.TextBox()
        Me.OperatorClear = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.OperatorDivide = New System.Windows.Forms.Button()
        Me.OperatorMultiply = New System.Windows.Forms.Button()
        Me.OperatorMinus = New System.Windows.Forms.Button()
        Me.OperatorPlus = New System.Windows.Forms.Button()
        Me.NumDot = New System.Windows.Forms.Button()
        Me.Num0 = New System.Windows.Forms.Button()
        Me.Num9 = New System.Windows.Forms.Button()
        Me.Num8 = New System.Windows.Forms.Button()
        Me.Num7 = New System.Windows.Forms.Button()
        Me.Num6 = New System.Windows.Forms.Button()
        Me.Num5 = New System.Windows.Forms.Button()
        Me.Num4 = New System.Windows.Forms.Button()
        Me.Num3 = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.Button()
        Me.Num1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(28, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(551, 655)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.todoList)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.statusMessage)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.taskBar)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(543, 618)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "todo List"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(37, 537)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 61)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Clear All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'todoList
        '
        Me.todoList.FormattingEnabled = True
        Me.todoList.ItemHeight = 24
        Me.todoList.Location = New System.Drawing.Point(41, 59)
        Me.todoList.Name = "todoList"
        Me.todoList.Size = New System.Drawing.Size(435, 388)
        Me.todoList.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(338, 537)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 61)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'statusMessage
        '
        Me.statusMessage.AutoSize = True
        Me.statusMessage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusMessage.ForeColor = System.Drawing.Color.White
        Me.statusMessage.Location = New System.Drawing.Point(35, 468)
        Me.statusMessage.Name = "statusMessage"
        Me.statusMessage.Size = New System.Drawing.Size(448, 33)
        Me.statusMessage.TabIndex = 11
        Me.statusMessage.Text = "please type your task and hit the botton"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 49)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Todo list Application"
        '
        'taskBar
        '
        Me.taskBar.Location = New System.Drawing.Point(41, 504)
        Me.taskBar.Name = "taskBar"
        Me.taskBar.Size = New System.Drawing.Size(435, 32)
        Me.taskBar.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(181, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 61)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add to do list"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.Button14)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.input2)
        Me.TabPage2.Controls.Add(Me.input1)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(543, 618)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "loops"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(49, 485)
        Me.Button13.Name = "Button13"
        Me.Button13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button13.Size = New System.Drawing.Size(243, 40)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "Do loop add numbers 1 to 100"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(49, 439)
        Me.Button14.Name = "Button14"
        Me.Button14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button14.Size = New System.Drawing.Size(243, 40)
        Me.Button14.TabIndex = 13
        Me.Button14.Text = "While loop add numbers 1 to 100"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(304, 485)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(183, 40)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "clear"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(49, 550)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(438, 40)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "print  prime number between 1 to 100"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(304, 439)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(183, 40)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "print odd numbers"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(304, 393)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(183, 40)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "print even numbers"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(49, 393)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(243, 40)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "for loop add numbers 1 to 100"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(388, 338)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 40)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "find the min"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(272, 338)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 40)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "find the max"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'input2
        '
        Me.input2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.Location = New System.Drawing.Point(288, 284)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(129, 44)
        Me.input2.TabIndex = 4
        '
        'input1
        '
        Me.input1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.Location = New System.Drawing.Point(111, 284)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(129, 44)
        Me.input1.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(154, 338)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 40)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "ten to one"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(49, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(477, 253)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(49, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 40)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "one to ten"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Silver
        Me.TabPage4.CausesValidation = False
        Me.TabPage4.Controls.Add(Me.calcScreen)
        Me.TabPage4.Controls.Add(Me.OperatorClear)
        Me.TabPage4.Controls.Add(Me.Button19)
        Me.TabPage4.Controls.Add(Me.OperatorDivide)
        Me.TabPage4.Controls.Add(Me.OperatorMultiply)
        Me.TabPage4.Controls.Add(Me.OperatorMinus)
        Me.TabPage4.Controls.Add(Me.OperatorPlus)
        Me.TabPage4.Controls.Add(Me.NumDot)
        Me.TabPage4.Controls.Add(Me.Num0)
        Me.TabPage4.Controls.Add(Me.Num9)
        Me.TabPage4.Controls.Add(Me.Num8)
        Me.TabPage4.Controls.Add(Me.Num7)
        Me.TabPage4.Controls.Add(Me.Num6)
        Me.TabPage4.Controls.Add(Me.Num5)
        Me.TabPage4.Controls.Add(Me.Num4)
        Me.TabPage4.Controls.Add(Me.Num3)
        Me.TabPage4.Controls.Add(Me.Num2)
        Me.TabPage4.Controls.Add(Me.Num1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(543, 618)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "calculator"
        '
        'calcScreen
        '
        Me.calcScreen.Font = New System.Drawing.Font("Calibri", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcScreen.Location = New System.Drawing.Point(107, 52)
        Me.calcScreen.Name = "calcScreen"
        Me.calcScreen.ReadOnly = True
        Me.calcScreen.Size = New System.Drawing.Size(341, 98)
        Me.calcScreen.TabIndex = 20
        Me.calcScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OperatorClear
        '
        Me.OperatorClear.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorClear.Location = New System.Drawing.Point(368, 138)
        Me.OperatorClear.Name = "OperatorClear"
        Me.OperatorClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OperatorClear.Size = New System.Drawing.Size(80, 80)
        Me.OperatorClear.TabIndex = 19
        Me.OperatorClear.Text = "AC"
        Me.OperatorClear.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(107, 479)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(255, 80)
        Me.Button19.TabIndex = 17
        Me.Button19.Text = "="
        Me.Button19.UseVisualStyleBackColor = True
        '
        'OperatorDivide
        '
        Me.OperatorDivide.BackColor = System.Drawing.Color.Goldenrod
        Me.OperatorDivide.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorDivide.ForeColor = System.Drawing.Color.White
        Me.OperatorDivide.Location = New System.Drawing.Point(368, 224)
        Me.OperatorDivide.Name = "OperatorDivide"
        Me.OperatorDivide.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OperatorDivide.Size = New System.Drawing.Size(80, 80)
        Me.OperatorDivide.TabIndex = 15
        Me.OperatorDivide.Text = "/"
        Me.OperatorDivide.UseVisualStyleBackColor = False
        '
        'OperatorMultiply
        '
        Me.OperatorMultiply.BackColor = System.Drawing.Color.Goldenrod
        Me.OperatorMultiply.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorMultiply.ForeColor = System.Drawing.Color.White
        Me.OperatorMultiply.Location = New System.Drawing.Point(368, 310)
        Me.OperatorMultiply.Name = "OperatorMultiply"
        Me.OperatorMultiply.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OperatorMultiply.Size = New System.Drawing.Size(80, 80)
        Me.OperatorMultiply.TabIndex = 14
        Me.OperatorMultiply.Text = "*"
        Me.OperatorMultiply.UseVisualStyleBackColor = False
        '
        'OperatorMinus
        '
        Me.OperatorMinus.BackColor = System.Drawing.Color.Goldenrod
        Me.OperatorMinus.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorMinus.ForeColor = System.Drawing.Color.White
        Me.OperatorMinus.Location = New System.Drawing.Point(368, 396)
        Me.OperatorMinus.Name = "OperatorMinus"
        Me.OperatorMinus.Size = New System.Drawing.Size(80, 80)
        Me.OperatorMinus.TabIndex = 13
        Me.OperatorMinus.Text = "-"
        Me.OperatorMinus.UseVisualStyleBackColor = False
        '
        'OperatorPlus
        '
        Me.OperatorPlus.BackColor = System.Drawing.Color.Goldenrod
        Me.OperatorPlus.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorPlus.ForeColor = System.Drawing.Color.White
        Me.OperatorPlus.Location = New System.Drawing.Point(368, 482)
        Me.OperatorPlus.Name = "OperatorPlus"
        Me.OperatorPlus.Size = New System.Drawing.Size(80, 80)
        Me.OperatorPlus.TabIndex = 12
        Me.OperatorPlus.Text = "+"
        Me.OperatorPlus.UseVisualStyleBackColor = False
        '
        'NumDot
        '
        Me.NumDot.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDot.Location = New System.Drawing.Point(282, 396)
        Me.NumDot.Name = "NumDot"
        Me.NumDot.Size = New System.Drawing.Size(80, 80)
        Me.NumDot.TabIndex = 11
        Me.NumDot.Text = "."
        Me.NumDot.UseVisualStyleBackColor = True
        '
        'Num0
        '
        Me.Num0.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num0.Location = New System.Drawing.Point(107, 396)
        Me.Num0.Name = "Num0"
        Me.Num0.Size = New System.Drawing.Size(166, 80)
        Me.Num0.TabIndex = 10
        Me.Num0.Text = "0"
        Me.Num0.UseVisualStyleBackColor = True
        '
        'Num9
        '
        Me.Num9.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num9.Location = New System.Drawing.Point(282, 138)
        Me.Num9.Name = "Num9"
        Me.Num9.Size = New System.Drawing.Size(80, 80)
        Me.Num9.TabIndex = 9
        Me.Num9.Text = "9"
        Me.Num9.UseVisualStyleBackColor = True
        '
        'Num8
        '
        Me.Num8.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num8.Location = New System.Drawing.Point(196, 138)
        Me.Num8.Name = "Num8"
        Me.Num8.Size = New System.Drawing.Size(80, 80)
        Me.Num8.TabIndex = 8
        Me.Num8.Text = "8"
        Me.Num8.UseVisualStyleBackColor = True
        '
        'Num7
        '
        Me.Num7.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num7.Location = New System.Drawing.Point(107, 138)
        Me.Num7.Name = "Num7"
        Me.Num7.Size = New System.Drawing.Size(80, 80)
        Me.Num7.TabIndex = 7
        Me.Num7.Text = "7"
        Me.Num7.UseVisualStyleBackColor = True
        '
        'Num6
        '
        Me.Num6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num6.Location = New System.Drawing.Point(282, 224)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(80, 80)
        Me.Num6.TabIndex = 6
        Me.Num6.Text = "6"
        Me.Num6.UseVisualStyleBackColor = True
        '
        'Num5
        '
        Me.Num5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num5.Location = New System.Drawing.Point(193, 224)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(80, 80)
        Me.Num5.TabIndex = 5
        Me.Num5.Text = "5"
        Me.Num5.UseVisualStyleBackColor = True
        '
        'Num4
        '
        Me.Num4.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num4.Location = New System.Drawing.Point(107, 224)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(80, 80)
        Me.Num4.TabIndex = 4
        Me.Num4.Text = "4"
        Me.Num4.UseVisualStyleBackColor = True
        '
        'Num3
        '
        Me.Num3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.Location = New System.Drawing.Point(282, 310)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(80, 80)
        Me.Num3.TabIndex = 3
        Me.Num3.Text = "3"
        Me.Num3.UseVisualStyleBackColor = True
        '
        'Num2
        '
        Me.Num2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.Location = New System.Drawing.Point(196, 310)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(80, 80)
        Me.Num2.TabIndex = 2
        Me.Num2.Text = "2"
        Me.Num2.UseVisualStyleBackColor = True
        '
        'Num1
        '
        Me.Num1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(107, 310)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(80, 80)
        Me.Num1.TabIndex = 1
        Me.Num1.Text = "1"
        Me.Num1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 690)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents todoList As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents statusMessage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents taskBar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents input2 As TextBox
    Friend WithEvents input1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents OperatorClear As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents OperatorDivide As Button
    Friend WithEvents OperatorMultiply As Button
    Friend WithEvents OperatorMinus As Button
    Friend WithEvents OperatorPlus As Button
    Friend WithEvents NumDot As Button
    Friend WithEvents Num0 As Button
    Friend WithEvents Num9 As Button
    Friend WithEvents Num8 As Button
    Friend WithEvents Num7 As Button
    Friend WithEvents Num6 As Button
    Friend WithEvents Num5 As Button
    Friend WithEvents Num4 As Button
    Friend WithEvents Num3 As Button
    Friend WithEvents Num2 As Button
    Friend WithEvents calcScreen As TextBox
    Friend WithEvents Num1 As Button
End Class
