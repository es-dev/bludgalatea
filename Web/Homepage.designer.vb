Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Me.TemplateTitle1 = New Library.TemplateTitle()
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.htmlHomepage = New Library.TemplateHtml()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 2100)
        Me.panelBody.Size = New System.Drawing.Size(1024, 2100)
        '
        'TemplateTitle1
        '
        Me.TemplateTitle1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateTitle1.Location = New System.Drawing.Point(0, 29)
        Me.TemplateTitle1.Name = "TemplateTitle1"
        Me.TemplateTitle1.Size = New System.Drawing.Size(821, 48)
        Me.TemplateTitle1.TabIndex = 1
        Me.TemplateTitle1.TemplateTitle = "Blud Galatea Cosenza"
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor = System.Drawing.Color.Pink
        Me.panelContenuto.Controls.Add(Me.htmlHomepage)
        Me.panelContenuto.Controls.Add(Me.TemplateTitle1)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(821, 2035)
        Me.panelContenuto.TabIndex = 2
        '
        'htmlHomepage
        '
        Me.htmlHomepage.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlHomepage.Html = Nothing
        Me.htmlHomepage.Location = New System.Drawing.Point(0, 77)
        Me.htmlHomepage.Name = "htmlHomepage"
        Me.htmlHomepage.Size = New System.Drawing.Size(820, 2035)
        Me.htmlHomepage.TabIndex = 2
        '
        'Homepage
        '
        Me.Size = New System.Drawing.Size(1024, 2250)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TemplateTitle1 As Library.TemplateTitle
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents htmlHomepage As Library.TemplateHtml

#End Region

End Class
