Public Class Form1

    Dim conObj As New ADODB.Connection
    Dim recSetObj As New ADODB.Recordset

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conObj.Provider = "Microsoft.ACE.OLEDB.12.0"
        conObj.ConnectionString = "./StudentsInfo.accdb"
        conObj.Open()
        recSetObj.Open("SELECT * FROM Students",
                       conObj,
                       ADODB.CursorTypeEnum.adOpenDynamic,
                       ADODB.LockTypeEnum.adLockPessimistic)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        recSetObj.MoveFirst()
        MessageBox.Show(recSetObj.Fields("StudentName").Value)
    End Sub
End Class
