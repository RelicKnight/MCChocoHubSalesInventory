<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        SuspendLayout()
        ' 
        ' Guna2TileButton1
        ' 
        Guna2TileButton1.BackgroundImage = CType(resources.GetObject("Guna2TileButton1.BackgroundImage"), Image)
        Guna2TileButton1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2TileButton1.CustomizableEdges = CustomizableEdges1
        Guna2TileButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2TileButton1.FillColor = Color.Transparent
        Guna2TileButton1.Font = New Font("Segoe UI", 9F)
        Guna2TileButton1.ForeColor = Color.White
        Guna2TileButton1.Location = New Point(582, 345)
        Guna2TileButton1.Name = "Guna2TileButton1"
        Guna2TileButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TileButton1.Size = New Size(333, 137)
        Guna2TileButton1.TabIndex = 2
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(1553, 881)
        Controls.Add(Guna2TileButton1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
End Class
