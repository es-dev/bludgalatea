Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PercheDonare
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
        Me.TemplateTitle1 = New Library.TemplateTitle()
        Me.TemplateHtml1 = New Library.TemplateHtml()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 850)
        Me.panelBody.Size = New System.Drawing.Size(1024, 850)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.TemplateHtml1)
        Me.panelContenuto.Controls.Add(Me.TemplateTitle1)
        Me.panelContenuto.Location = New System.Drawing.Point(204, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(820, 766)
        Me.panelContenuto.TabIndex = 3
        '
        'TemplateTitle1
        '
        Me.TemplateTitle1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.TemplateTitle1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateTitle1.Location = New System.Drawing.Point(0, 30)
        Me.TemplateTitle1.Name = "TemplateTitle1"
        Me.TemplateTitle1.Size = New System.Drawing.Size(820, 48)
        Me.TemplateTitle1.TabIndex = 0
        Me.TemplateTitle1.TemplateTitle = "Perchè donare?"
        '
        'TemplateHtml1
        '
        Me.TemplateHtml1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.TemplateHtml1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateHtml1.Html = Nothing
        Me.TemplateHtml1.Location = New System.Drawing.Point(0, 78)
        Me.TemplateHtml1.Name = "TemplateHtml1"
        Me.TemplateHtml1.Size = New System.Drawing.Size(820, 687)
        Me.TemplateHtml1.TabIndex = 1
        '
        'PercheDonare
        '
        Me.Size = New System.Drawing.Size(1024, 1100)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents TemplateTitle1 As Library.TemplateTitle
    Friend WithEvents TemplateHtml1 As Library.TemplateHtml

#End Region

End Class
