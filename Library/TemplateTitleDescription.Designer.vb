Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateTitleDescription
    Inherits Gizmox.WebGui.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual WebGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New Gizmox.WebGUI.Forms.Label()
        Me.lblDescription = New Gizmox.WebGUI.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(820, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Label1"
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.White
        Me.lblDescription.Location = New System.Drawing.Point(0, 26)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(820, 301)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Label2"
        '
        'TemplateTitleDescription
        '
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Size = New System.Drawing.Size(820, 327)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As Gizmox.WebGUI.Forms.Label
    Friend WithEvents lblDescription As Gizmox.WebGUI.Forms.Label

End Class
