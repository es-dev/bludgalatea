Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiPuoDonare
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
        Me.htmlChiPuoDonare = New Library.TemplateHtml()
        Me.titleChiPuoDonare = New Library.TemplateTitle()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 750)
        Me.panelBody.Size = New System.Drawing.Size(1024, 750)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor = System.Drawing.Color.Pink
        Me.panelContenuto.Controls.Add(Me.htmlChiPuoDonare)
        Me.panelContenuto.Controls.Add(Me.titleChiPuoDonare)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(821, 685)
        Me.panelContenuto.TabIndex = 3
        '
        'htmlChiPuoDonare
        '
        Me.htmlChiPuoDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.htmlChiPuoDonare.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlChiPuoDonare.Html = Nothing
        Me.htmlChiPuoDonare.Location = New System.Drawing.Point(1, 78)
        Me.htmlChiPuoDonare.Name = "htmlChiPuoDonare"
        Me.htmlChiPuoDonare.Size = New System.Drawing.Size(820, 607)
        Me.htmlChiPuoDonare.TabIndex = 1
        '
        'titleChiPuoDonare
        '
        Me.titleChiPuoDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.titleChiPuoDonare.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.titleChiPuoDonare.Location = New System.Drawing.Point(0, 30)
        Me.titleChiPuoDonare.Name = "titleChiPuoDonare"
        Me.titleChiPuoDonare.Size = New System.Drawing.Size(820, 48)
        Me.titleChiPuoDonare.TabIndex = 0
        Me.titleChiPuoDonare.TemplateTitle = "Chi può donare"
        '
        'ChiPuoDonare
        '
        Me.Size = New System.Drawing.Size(1024, 1000)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents htmlChiPuoDonare As Library.TemplateHtml
    Friend WithEvents titleChiPuoDonare As Library.TemplateTitle

#End Region

End Class
