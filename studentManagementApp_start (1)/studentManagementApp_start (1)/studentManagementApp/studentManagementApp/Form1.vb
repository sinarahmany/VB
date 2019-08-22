Public Class Form1

    Dim conObj As New ADODB.Connection
    Dim recSetObj As New ADODB.Recordset
    Dim StrCriteria As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conObj.Provider = "Microsoft.ACE.OLEDB.12.0"
        conObj.ConnectionString = "./StudentsInfo.accdb"
        conObj.Open()
        recSetObj.Open("SELECT * FROM Students",
                       conObj,
                       ADODB.CursorTypeEnum.adOpenDynamic,
                       ADODB.LockTypeEnum.adLockOptimistic)
        radioButtonByStudentId.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles firstButton.Click
        recSetObj.MoveFirst()
        showData()
        clearOutputMessage()
    End Sub

    Private Sub RadioButtonMan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMan.CheckedChanged
        manAvatar.BringToFront()
    End Sub

    Private Sub RadioButtonWoman_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonWoman.CheckedChanged
        womanAvatar.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        recSetObj.MoveNext()
        If recSetObj.EOF Then
            recSetObj.MoveLast()
            showData()
            outputMessage("No more records. End of records.")
        Else
            showData()
            clearOutputMessage()
        End If
    End Sub


    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearAllBoxes()
    End Sub

    Sub showData()

        studentNameBox.Text = recSetObj.Fields("StudentName").Value.ToString
        studentLastNameBox.Text = recSetObj.Fields("StudentLastName").Value.ToString.ToUpper
        studentNumberBox.Text = recSetObj.Fields("StudentNumber").Value.ToString
        'studentStartDateBox.Text = Format(recSetObj.Fields("StartDate").Value, "MMM,d yyyy")
        studentProgramBox.Text = recSetObj.Fields("Program").Value.ToString
        studentAddressBox.Text = recSetObj.Fields("Address").Value.ToString
        studentPhoneBox.Text = recSetObj.Fields("PhoneNumber").Value.ToString
        studentEmailBox.Text = recSetObj.Fields("Email").Value.ToString
        studentCountryBox.Text = recSetObj.Fields("Country").Value.ToString

        Dim gender As Boolean = recSetObj.Fields("Gender").Value.ToString

    End Sub

    Sub outputMessage(message As String)
        userMessage.Text = message
    End Sub
    Sub clearOutputMessage()
        userMessage.Text = ""
    End Sub

    Sub clearAllBoxes()
        studentNameBox.Clear()
        studentLastNameBox.Clear()
        studentNumberBox.Clear()
        studentStartDateBox.Clear()
        studentProgramBox.Clear()
        studentAddressBox.Clear()
        studentPhoneBox.Clear()
        studentEmailBox.Clear()
        studentCountryBox.Clear()
        RadioButtonMan.Checked = False
        RadioButtonWoman.Checked = False

        clearOutputMessage()
    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        recSetObj.MovePrevious
        If recSetObj.BOF Then
            recSetObj.MoveFirst()
            showData()
            outputMessage("No more records. Start of records.")
        Else
            showData()
            clearOutputMessage()
        End If
    End Sub

    Private Sub lastButton_Click(sender As Object, e As EventArgs) Handles lastButton.Click
        recSetObj.MoveLast()
        showData()
        clearOutputMessage()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        'check if the fields are empty
        If studentNameBox.Text = "" Or
           studentLastNameBox.Text = "" Or
           studentNumberBox.Text = "" Or
           studentStartDateBox.Text = "" Or
           studentProgramBox.Text = "" Or
           studentAddressBox.Text = "" Or
           studentPhoneBox.Text = "" Or
           studentEmailBox.Text = "" Or
           studentCountryBox.Text = "" Or
           (Not RadioButtonMan.Checked And
           Not RadioButtonWoman.Checked) Then

            outputMessage("Fill out all the fields")
            Exit Sub

        End If

        clearOutputMessage()

        recSetObj.MoveFirst()
        StrCriteria = "StudentNumber ='" + studentNumberBox.Text + "'"
        recSetObj.Find(StrCriteria)
        If recSetObj.EOF Then 'I did not find the record 
            recSetObj.AddNew()
            SaveInAccessFile()
            recSetObj.Update()
            clearAllBoxes()
            outputMessage("New record saved succesfully!")
        Else 'record is found 
            outputMessage("Duplicate record, Please try again")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles update.Click
        If studentNameBox.Text = "" Or
          studentLastNameBox.Text = "" Or
          studentNumberBox.Text = "" Or
          studentStartDateBox.Text = "" Or
          studentProgramBox.Text = "" Or
          studentAddressBox.Text = "" Or
          studentPhoneBox.Text = "" Or
          studentEmailBox.Text = "" Or
          studentCountryBox.Text = "" Or
          (Not RadioButtonMan.Checked And
          Not RadioButtonWoman.Checked) Then

            outputMessage("Fill out all the fields")
            Exit Sub

        End If

        clearOutputMessage()
        SaveInAccessFile()
        recSetObj.Update()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        recSetObj.Delete()
        recSetObj.Update()
        recSetObj.MoveLast()
        showData()
        '        recSetObj.Fields("StudentName").Value = ""
        '       recSetObj.Fields("StudentLastName").Value = studentLastNameBox.Text
        '      recSetObj.Fields("StudentNumber").Value = studentNumberBox.Text
        '     'FormatrecSetObj.Fields("StartDate").Value = studentStartDateBox.Text
        '    recSetObj.Fields("Program").Value = studentProgramBox.Text
        '   recSetObj.Fields("Address").Value = studentAddressBox.Text
        '  recSetObj.Fields("PhoneNumber").Value = studentPhoneBox.Text
        ' recSetObj.Fields("Email").Value = studentEmailBox.Text
        'recSetObj.Fields("Country").Value = studentCountryBox.Text
    End Sub
    Sub SaveInAccessFile()
        recSetObj.Fields("StudentName").Value = studentNameBox.Text
        recSetObj.Fields("StudentLastName").Value = studentLastNameBox.Text
        recSetObj.Fields("StudentNumber").Value = studentNumberBox.Text
        'FormatrecSetObj.Fields("StartDate").Value = studentStartDateBox.Text
        recSetObj.Fields("Program").Value = studentProgramBox.Text
        recSetObj.Fields("Address").Value = studentAddressBox.Text
        recSetObj.Fields("PhoneNumber").Value = studentPhoneBox.Text
        recSetObj.Fields("Email").Value = studentEmailBox.Text
        recSetObj.Fields("Country").Value = studentCountryBox.Text

        If RadioButtonMan.Checked Then
            recSetObj.Fields("Gender").Value = True

        Else
            recSetObj.Fields("Gender").Value = False
        End If

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If searchBox.Text Is "" Then
            MessageBox.Show("type something")
        Else


            If radioButtonByStudentId.Checked Then
                StrCriteria = "StudentNumber ='" + searchBox.Text + "'"
                recSetObj.Find(StrCriteria)

                showData()
                ' recSetObj.Fields("StudentNumber").Value = searchBox.Text
            Else

                StrCriteria = "StudentName ='" + searchBox.Text + "'"
                recSetObj.Find(StrCriteria)
                showData()


            End If
        End If
    End Sub
End Class
