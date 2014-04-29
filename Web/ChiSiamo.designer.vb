Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiSiamo
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
        Me.htmlChiSiamo = New Library.TemplateHtml()
        Me.titleChiSiamo = New Library.TemplateTitle()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 1125)
        Me.panelBody.Size = New System.Drawing.Size(1024, 1125)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor = System.Drawing.Color.Pink
        Me.panelContenuto.Controls.Add(Me.htmlChiSiamo)
        Me.panelContenuto.Controls.Add(Me.titleChiSiamo)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(821, 1060)
        Me.panelContenuto.TabIndex = 1
        '
        'htmlChiSiamo
        '
        Me.htmlChiSiamo.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.htmlChiSiamo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlChiSiamo.Html = Nothing
        Me.htmlChiSiamo.Location = New System.Drawing.Point(0, 78)
        Me.htmlChiSiamo.Name = "htmlChiSiamo"
        Me.htmlChiSiamo.Size = New System.Drawing.Size(821, 982)
        Me.htmlChiSiamo.TabIndex = 8
        '
        'titleChiSiamo
        '
        Me.titleChiSiamo.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.titleChiSiamo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.titleChiSiamo.Location = New System.Drawing.Point(0, 30)
        Me.titleChiSiamo.Name = "titleChiSiamo"
        Me.titleChiSiamo.Size = New System.Drawing.Size(820, 48)
        Me.titleChiSiamo.TabIndex = 0
        Me.titleChiSiamo.TemplateTitle = "Chi siamo"
        '
        'ChiSiamo
        '
        Me.Size = New System.Drawing.Size(1024, 1400)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents titleChiSiamo As Library.TemplateTitle
    Friend WithEvents htmlChiSiamo As Library.TemplateHtml

#End Region

End Class
