Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComeDonare
    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region " Visual WebGui Designer generated code "

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
    Private Sub InitializeComponent()
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.htmlComeDonare = New Library.TemplateHtml()
        Me.titleComeDonare = New Library.TemplateTitle()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 550)
        Me.panelBody.Size = New System.Drawing.Size(1024, 550)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.htmlComeDonare)
        Me.panelContenuto.Controls.Add(Me.titleComeDonare)
        Me.panelContenuto.Location = New System.Drawing.Point(204, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(820, 468)
        Me.panelContenuto.TabIndex = 3
        '
        'htmlComeDonare
        '
        Me.htmlComeDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.htmlComeDonare.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlComeDonare.Html = Nothing
        Me.htmlComeDonare.Location = New System.Drawing.Point(0, 78)
        Me.htmlComeDonare.Name = "htmlComeDonare"
        Me.htmlComeDonare.Size = New System.Drawing.Size(820, 390)
        Me.htmlComeDonare.TabIndex = 1
        '
        'titleComeDonare
        '
        Me.titleComeDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.titleComeDonare.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.titleComeDonare.Location = New System.Drawing.Point(0, 30)
        Me.titleComeDonare.Name = "titleComeDonare"
        Me.titleComeDonare.Size = New System.Drawing.Size(820, 48)
        Me.titleComeDonare.TabIndex = 0
        Me.titleComeDonare.TemplateTitle = "Come donare"
        '
        'ComeDonare
        '
        Me.Size = New System.Drawing.Size(1024, 800)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents titleComeDonare As Library.TemplateTitle
    Friend WithEvents htmlComeDonare As Library.TemplateHtml

#End Region

End Class
