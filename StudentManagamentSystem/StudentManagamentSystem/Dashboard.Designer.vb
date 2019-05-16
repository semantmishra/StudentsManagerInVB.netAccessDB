<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits StudentManagamentSystem.Temp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.ManageStudentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.StudentManagamentSystem.My.Resources.Resources.Log_Out_48x48
        Me.Button4.Location = New System.Drawing.Point(712, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(179, 153)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Logout"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.StudentManagamentSystem.My.Resources.Resources.Globe_48x48
        Me.Button3.Location = New System.Drawing.Point(496, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 153)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Devopers"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.HelpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton.Image = Global.StudentManagamentSystem.My.Resources.Resources.Help_48x48
        Me.HelpButton.Location = New System.Drawing.Point(280, 51)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(179, 153)
        Me.HelpButton.TabIndex = 0
        Me.HelpButton.Text = "HelpSuport"
        Me.HelpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'ManageStudentButton
        '
        Me.ManageStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ManageStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ManageStudentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ManageStudentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageStudentButton.Image = Global.StudentManagamentSystem.My.Resources.Resources.User_48x48
        Me.ManageStudentButton.Location = New System.Drawing.Point(64, 51)
        Me.ManageStudentButton.Name = "ManageStudentButton"
        Me.ManageStudentButton.Size = New System.Drawing.Size(179, 153)
        Me.ManageStudentButton.TabIndex = 0
        Me.ManageStudentButton.Text = "Manage Student"
        Me.ManageStudentButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ManageStudentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ManageStudentButton.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 277)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.ManageStudentButton)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ManageStudentButton As System.Windows.Forms.Button
    Friend WithEvents HelpButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
