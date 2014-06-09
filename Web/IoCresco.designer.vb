Imports System.Drawing
Imports System.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IoCresco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IoCresco))
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.PictureBox1 = New Gizmox.WebGUI.Forms.PictureBox()
        Me.titleIoCresco = New Library.TemplateTitle()
        Me.htmlIoCresco = New Library.TemplateHtml()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 500)
        Me.panelBody.Size = New System.Drawing.Size(1024, 500)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.htmlIoCresco)
        Me.panelContenuto.Controls.Add(Me.PictureBox1)
        Me.panelContenuto.Controls.Add(Me.titleIoCresco)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(820, 417)
        Me.panelContenuto.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("PictureBox1.Image"))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 181)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'titleIoCresco
        '
        Me.titleIoCresco.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.titleIoCresco.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.titleIoCresco.Location = New System.Drawing.Point(0, 30)
        Me.titleIoCresco.Name = "titleIoCresco"
        Me.titleIoCresco.Size = New System.Drawing.Size(820, 48)
        Me.titleIoCresco.TabIndex = 0
        Me.titleIoCresco.TemplateTitle = "Io cresco, grazie mamma"
        '
        'htmlIoCresco
        '
        Me.htmlIoCresco.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.htmlIoCresco.Html = Nothing
        Me.htmlIoCresco.Location = New System.Drawing.Point(0, 78)
        Me.htmlIoCresco.Name = "htmlIoCresco"
        Me.htmlIoCresco.Size = New System.Drawing.Size(820, 158)
        Me.htmlIoCresco.TabIndex = 3
        '
        'IoCresco
        '
        Me.Size = New System.Drawing.Size(1024, 750)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents titleIoCresco As Library.TemplateTitle
    Friend WithEvents PictureBox1 As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents htmlIoCresco As Library.TemplateHtml

#End Region

End Class
