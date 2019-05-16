Public Class Dashboard : Inherits Temp

    Private Sub ManageStudentButton_Click(sender As System.Object, e As System.EventArgs) Handles ManageStudentButton.Click
        ManageStudentScreen.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub HelpButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpButton.Click
        Help.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Devolpers.ShowDialog()
    End Sub
End Class
