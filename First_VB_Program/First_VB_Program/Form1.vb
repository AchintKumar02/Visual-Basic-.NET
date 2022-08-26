Public Class Form1
    Private Sub BtnGO_Click(sender As Object, e As EventArgs) Handles BtnGO.Click
        MsgBox("Hello World")
    End Sub
    Private Sub VariableBtn_Click(sender As Object, e As EventArgs) Handles VariableBtn.Click
        Dim stName_Of_Student As String
        stName_Of_Student = "Achint Kumar"
        MsgBox("Welcome " & stName_Of_Student & " On your First Visual basic program")

        stName_Of_Student = "Gaurav Arya"
        MsgBox("Welcome " & stName_Of_Student & " On your First Visual basic program")
    End Sub
End Class
