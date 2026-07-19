<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2vScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Panel1 = New Panel()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(Panel1)
        Guna2Panel1.Controls.Add(Guna2vScrollBar1)
        Guna2Panel1.Controls.Add(Guna2Button3)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(1565, 922)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Guna2vScrollBar1
        ' 
        Guna2vScrollBar1.FillColor = Color.Pink
        Guna2vScrollBar1.InUpdate = False
        Guna2vScrollBar1.LargeChange = 10
        Guna2vScrollBar1.Location = New Point(1547, 0)
        Guna2vScrollBar1.Name = "Guna2vScrollBar1"
        Guna2vScrollBar1.ScrollbarSize = 18
        Guna2vScrollBar1.Size = New Size(18, 922)
        Guna2vScrollBar1.TabIndex = 118
        Guna2vScrollBar1.ThumbColor = Color.Maroon
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.BorderColor = Color.FromArgb(CByte(238), CByte(105), CByte(131))
        Guna2Button3.BorderRadius = 5
        Guna2Button3.CustomizableEdges = CustomizableEdges1
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Maroon
        Guna2Button3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2Button3.ForeColor = Color.FromArgb(CByte(255), CByte(196), CByte(196))
        Guna2Button3.Location = New Point(1369, 15)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(174, 45)
        Guna2Button3.TabIndex = 117
        Guna2Button3.Text = "BACK"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Maroon
        Guna2HtmlLabel2.Location = New Point(30, 27)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(212, 33)
        Guna2HtmlLabel2.TabIndex = 6
        Guna2HtmlLabel2.Text = "LIST OF BOOKS"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Location = New Point(346, 890)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 740)
        Panel1.TabIndex = 119
        ' 
        ' Books
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(1565, 922)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Books"
        StartPosition = FormStartPosition.Manual
        Text = "Books"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2vScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents Panel1 As Panel
End Class
