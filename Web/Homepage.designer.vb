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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.TemplateTitle1 = New Library.TemplateTitle()
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.Label1 = New Gizmox.WebGUI.Forms.Label()
        Me.labelGalatea = New Gizmox.WebGUI.Forms.Label()
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
        Me.panelContenuto.Controls.Add(Me.Label1)
        Me.panelContenuto.Controls.Add(Me.labelGalatea)
        Me.panelContenuto.Controls.Add(Me.TemplateTitle1)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(821, 477)
        Me.panelContenuto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(821, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "_________________________________________________________________________________" & _
    "______________________________________________________"
        '
        'labelGalatea
        '
        Me.labelGalatea.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGalatea.ForeColor = System.Drawing.Color.White
        Me.labelGalatea.Location = New System.Drawing.Point(0, 96)
        Me.labelGalatea.Name = "labelGalatea"
        Me.labelGalatea.Size = New System.Drawing.Size(821, 43)
        Me.labelGalatea.TabIndex = 2
        Me.labelGalatea.Text = resources.GetString("labelGalatea.Text")
        '
        'Homepage
        '
        Me.Size = New System.Drawing.Size(1024, 1000)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TemplateTitle1 As Library.TemplateTitle
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents labelGalatea As Gizmox.WebGUI.Forms.Label
    Friend WithEvents Label1 As Gizmox.WebGUI.Forms.Label

#End Region

End Class
