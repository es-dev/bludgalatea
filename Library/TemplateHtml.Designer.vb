Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateHtml
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
        Me.htmlBox = New Gizmox.WebGUI.Forms.HtmlBox()
        Me.SuspendLayout()
        '
        'htmlBox
        '
        Me.htmlBox.BackColor = System.Drawing.Color.Pink
        Me.htmlBox.ContentType = "text/html"
        Me.htmlBox.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill
        Me.htmlBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmlBox.Html = "<HTML>No content.</HTML>"
        Me.htmlBox.Location = New System.Drawing.Point(0, 0)
        Me.htmlBox.Name = "htmlBox"
        Me.htmlBox.Size = New System.Drawing.Size(820, 327)
        Me.htmlBox.TabIndex = 0
        '
        'TemplateHtml
        '
        Me.Controls.Add(Me.htmlBox)
        Me.Size = New System.Drawing.Size(820, 327)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents htmlBox As Gizmox.WebGUI.Forms.HtmlBox

End Class
