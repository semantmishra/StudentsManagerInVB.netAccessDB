Imports System.Data.OleDb

Public Class ManageStudentScreen : Inherits Temp
    Dim Connection As New Connection()
    Dim dt As New DataTable
    Public Sub LoadDataInGridView()
        Dim Reader As New OleDbDataAdapter("SELECT * FROM students", Connection.GetConnetion())
        dt.Clear()
        Reader.Fill(dt)
    End Sub

    Private Sub AddStudentToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles AddStudentToolStripButton1.Click
        StudentInfoScreen.ShowDialog()
        LoadDataInGridView()
        DataGridView1.DataSource = dt
    End Sub

    Private Sub ManageStudentScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadDataInGridView()
        DataGridView1.DataSource = dt
        DeleteToolStripTextBox1.Text = "Enter ID Then Delete"
    End Sub

    Private Sub DeleteToolStripTextBox1_Enter(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripTextBox1.Enter
        If (DeleteToolStripTextBox1.Text = "Enter ID Then Delete") Then
            DeleteToolStripTextBox1.Clear()
        End If
    End Sub

    Private Sub DeleteToolStripTextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripTextBox1.Leave
        palce()



    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        Dim conn As New OleDb.OleDbConnection(Connection.GetConnetion().ToString())
        Dim cmd As New OleDbCommand("DELETE from students WHERE id= " & DeleteToolStripTextBox1.Text & "", conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Delete SuccesFul")
        LoadDataInGridView()
        DataGridView1.DataSource = dt
        DeleteToolStripTextBox1.Clear()
        palce()
    End Sub

    Private Sub palce()
        If (DeleteToolStripTextBox1.Text = String.Empty) Then
            DeleteToolStripTextBox1.Text = "Enter ID Then Delete"
        End If
    End Sub

End Class