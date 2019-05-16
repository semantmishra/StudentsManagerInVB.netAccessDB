Public Class Connection
    Public Function GetConnetion() As String
        Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\student.accdb"
    End Function

End Class
