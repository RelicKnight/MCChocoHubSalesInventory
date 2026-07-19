<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinesTeacher
    Inherits System.Windows.Forms.Form

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
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Maroon
        Guna2HtmlLabel2.Location = New Point(30, 30)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(224, 33)
        Guna2HtmlLabel2.TabIndex = 77
        Guna2HtmlLabel2.Text = "TEACHERS FINE"
        ' 
        ' FinesTeacher
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(908, 544)
        Controls.Add(Guna2HtmlLabel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FinesTeacher"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FinesTeacher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
