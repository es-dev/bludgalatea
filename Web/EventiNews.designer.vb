Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventiNews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventiNews))
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.txtTitle = New Gizmox.WebGUI.Forms.Label()
        Me.TemplateEventoNews1 = New Library.TemplateEventoNews()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor = System.Drawing.Color.Pink
        Me.panelContenuto.Controls.Add(Me.txtTitle)
        Me.panelContenuto.Controls.Add(Me.TemplateEventoNews1)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(820, 385)
        Me.panelContenuto.TabIndex = 3
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Pink
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(0, 30)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(678, 33)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "News"
        '
        'TemplateEventoNews1
        '
        Me.TemplateEventoNews1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateEventoNews1.BackColor = System.Drawing.Color.Pink
        Me.TemplateEventoNews1.Location = New System.Drawing.Point(0, 65)
        Me.TemplateEventoNews1.Name = "TemplateEventoNews1"
        Me.TemplateEventoNews1.Size = New System.Drawing.Size(820, 176)
        Me.TemplateEventoNews1.TabIndex = 0
        Me.TemplateEventoNews1.TemplateDescription = ""
        Me.TemplateEventoNews1.TemplateImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("TemplateEventoNews1.TemplateImage"))
        Me.TemplateEventoNews1.TemplateWidthDescrizione = 460
        Me.TemplateEventoNews1.TemplateWidthImage = 260
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents txtTitle As Gizmox.WebGUI.Forms.Label
    Friend WithEvents TemplateEventoNews1 As Library.TemplateEventoNews

#End Region

End Class
