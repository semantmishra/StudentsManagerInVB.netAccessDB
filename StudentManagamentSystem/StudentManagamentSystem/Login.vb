Public Class Login : Inherits Temp

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "Admin"
        TextBox2.Text = "password"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Enter User NAme And Password")
        Else
            If TextBox1.Text = "Admin" And TextBox2.Text = "password" Then
                Me.Hide()
                Dashboard.ShowDialog()
            End If
        End If
    End Sub
End Class