Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.TemplateHtml1 = New Library.TemplateHtml()
        Me.panelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.TemplateHtml1)
        '
        'TemplateHtml1
        '
        Me.TemplateHtml1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateHtml1.Html = Nothing
        Me.TemplateHtml1.Location = New System.Drawing.Point(204, 33)
        Me.TemplateHtml1.Name = "TemplateHtml1"
        Me.TemplateHtml1.Size = New System.Drawing.Size(820, 327)
        Me.TemplateHtml1.TabIndex = 3
        '
        'test
        '
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TemplateHtml1 As Library.TemplateHtml

#End Region

End Class
