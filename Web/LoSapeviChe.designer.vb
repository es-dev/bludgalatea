Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoSapeviChe
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
        Me.htmlLoSapeviChe = New Library.TemplateHtml()
        Me.titleLoSapeviChe = New Library.TemplateTitle()
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
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.htmlLoSapeviChe)
        Me.panelContenuto.Controls.Add(Me.titleLoSapeviChe)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(821, 685)
        Me.panelContenuto.TabIndex = 3
        '
        'htmlLoSapeviChe
        '
        Me.htmlLoSapeviChe.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.htmlLoSapeviChe.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlLoSapeviChe.Html = Nothing
        Me.htmlLoSapeviChe.Location = New System.Drawing.Point(0, 78)
        Me.htmlLoSapeviChe.Name = "htmlLoSapeviChe"
        Me.htmlLoSapeviChe.Size = New System.Drawing.Size(820, 607)
        Me.htmlLoSapeviChe.TabIndex = 1
        '
        'titleLoSapeviChe
        '
        Me.titleLoSapeviChe.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.titleLoSapeviChe.Location = New System.Drawing.Point(0, 30)
        Me.titleLoSapeviChe.Name = "titleLoSapeviChe"
        Me.titleLoSapeviChe.Size = New System.Drawing.Size(820, 48)
        Me.titleLoSapeviChe.TabIndex = 0
        Me.titleLoSapeviChe.TemplateTitle = "Lo sapevi che..."
        '
        'LoSapeviChe
        '
        Me.Size = New System.Drawing.Size(1024, 1000)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents titleLoSapeviChe As Library.TemplateTitle
    Friend WithEvents htmlLoSapeviChe As Library.TemplateHtml

#End Region

End Class
