Imports System.Data.OleDb

Public Class StudentInfoScreen : Inherits Temp
    Dim Connection As New Connection()

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If SaveButton.Text = "Update" Then
            Dim conn As New OleDb.OleDbConnection(Connection.GetConnetion().ToString())
            Dim cmd As New OleDbCommand("UPDATE Students SET FullName=@FullName , FatherName=@FatherName , MotherName=@MotherName , DateOfBirth=@DateOfBirth , [Class] = @Class , AadharNo=@AadharNo , AdmissionDate=@AdmissionDate , Gender=@Gender , Mobile1=@Mobile1 , Email=@Email , AddressLine=@Add ,[Session]= @Session WHERE [id] = @Id", conn)
            cmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text)
            cmd.Parameters.AddWithValue("@FatherName", FatherNAmeTextBox.Text)
            cmd.Parameters.AddWithValue("@MotherName", MotherNAmeTextBox.Text)
            cmd.Parameters.AddWithValue("@DateOfBirth", DOBTextBox.Text)
            cmd.Parameters.AddWithValue("@Class", ClassTextBox.Text)
            cmd.Parameters.AddWithValue("@AadharNo", AadharNoTextBox.Text)
            cmd.Parameters.AddWithValue("@AdmissionDate", AdmissionDateTextBox.Text)
            cmd.Parameters.AddWithValue("@Gender", GenderTextBox.Text)
            cmd.Parameters.AddWithValue("@Mobile1", MobileTextBox.Text)
            cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text)
            cmd.Parameters.AddWithValue("@Add", AddressTextBox.Text)
            cmd.Parameters.AddWithValue("@Session", SessionTextBox.Text)
            cmd.Parameters.AddWithValue("@Id", idTextBox.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data Update Succesfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
            Me.Close()
        Else

            If (idTextBox.Text <> String.Empty And FullNameTextBox.Text <> String.Empty) Then
                Dim conn As New OleDb.OleDbConnection(Connection.GetConnetion().ToString())
                Dim cmd As New OleDbCommand("INSERt into Students values('" & idTextBox.Text & "','" & FullNameTextBox.Text & "','" & FatherNAmeTextBox.Text & "','" & MotherNAmeTextBox.Text & "','" & DOBTextBox.Text & "','" & ClassTextBox.Text & "','" & AadharNoTextBox.Text & "','" & AdmissionDateTextBox.Text & "','" & GenderTextBox.Text & "','" & MobileTextBox.Text & "','" & EmailTextBox.Text & "','" & AddressTextBox.Text & "','" & SessionTextBox.Text & "')", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Data Save Succesfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                Me.Close()

            Else
                MsgBox("Fill The Id And Full Name then Save Record ")
            End If

        End If

    End Sub

    Public Function GetScalarValue() As Object

        Dim conn As New OleDb.OleDbConnection(Connection.GetConnetion().ToString())
        Dim cmd As New OleDbCommand("SElect max(id)+1 from students", conn)
        conn.Open()
        Dim value = cmd.ExecuteScalar()
        If IsDBNull(value) Then
            Return "1"
        Else
            Return value
        End If

    End Function

    Private Sub StudentInfoScreen_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        idTextBox.Text = GetScalarValue()
    End Sub

    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        clear()
    End Sub

    Private Sub clear()
        idTextBox.Clear()
        FullNameTextBox.Clear()
        AadharNoTextBox.Clear()
        FatherNAmeTextBox.Clear()
        MotherNAmeTextBox.Clear()
        DOBTextBox.Clear()
        ClassTextBox.Clear()
        AddressTextBox.Clear()
        AdmissionDateTextBox.Clear()
        GenderTextBox.Clear()
        MobileTextBox.Clear()
        EmailTextBox.Clear()
        AddressTextBox.Clear()
        SessionTextBox.Clear()


    End Sub


    Private Sub FindButton_Click(sender As System.Object, e As System.EventArgs) Handles FindButton.Click
        If (idTextBox.Text <> String.Empty) Then


            Dim conn As New OleDb.OleDbConnection(Connection.GetConnetion().ToString())
            Dim cmd As New OleDbCommand("SELECT * from students WHERE id=" & idTextBox.Text & "", conn)
            conn.Open()

            Dim Reader = cmd.ExecuteReader()

            Reader.Read()
            If Reader.HasRows Then
                FullNameTextBox.Text = Reader(1)

                FatherNAmeTextBox.Text = Reader(2)
                MotherNAmeTextBox.Text = Reader(3)
                DOBTextBox.Text = Reader(4)
                ClassTextBox.Text = Reader(5)
                AadharNoTextBox.Text = Reader(6)
                AdmissionDateTextBox.Text = Reader(7)
                GenderTextBox.Text = Reader(8)
                MobileTextBox.Text = Reader(9)
                EmailTextBox.Text = Reader(10)
                AddressTextBox.Text = Reader(11)
                SessionTextBox.Text = Reader(12)

                SaveButton.Text = "Update"
            Else
                MsgBox("Data Not Fount")
            End If
            conn.Close()
        End If

    End Sub
End Class