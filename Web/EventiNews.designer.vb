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
        Me.TemplateEventoNews4 = New Library.TemplateEventoNews()
        Me.TemplateEventoNews2 = New Library.TemplateEventoNews()
        Me.txtTitle = New Gizmox.WebGUI.Forms.Label()
        Me.TemplateEventoNews3 = New Library.TemplateEventoNews()
        Me.TemplateEventoNews1 = New Library.TemplateEventoNews()
        Me.panelBody.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.panelContenuto)
        Me.panelBody.MinimumSize = New System.Drawing.Size(1024, 735)
        Me.panelBody.Size = New System.Drawing.Size(1024, 940)
        '
        'panelContenuto
        '
        Me.panelContenuto.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.TemplateEventoNews4)
        Me.panelContenuto.Controls.Add(Me.TemplateEventoNews2)
        Me.panelContenuto.Controls.Add(Me.txtTitle)
        Me.panelContenuto.Controls.Add(Me.TemplateEventoNews3)
        Me.panelContenuto.Controls.Add(Me.TemplateEventoNews1)
        Me.panelContenuto.Location = New System.Drawing.Point(203, 0)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(1024, 800)
        Me.panelContenuto.TabIndex = 3
        '
        'TemplateEventoNews4
        '
        Me.TemplateEventoNews4.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateEventoNews4.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TemplateEventoNews4.Location = New System.Drawing.Point(0, 550)
        Me.TemplateEventoNews4.Name = "TemplateEventoNews4"
        Me.TemplateEventoNews4.Size = New System.Drawing.Size(820, 240)
        Me.TemplateEventoNews4.TabIndex = 5
        Me.TemplateEventoNews4.TemplateDescription = "Conferenza stampa per la presentazione del progetto ""Io cresco, grazie mamma"" pre" & _
    "sso la biblioteca del P.O. dell’Annunziata di Cosenza ore 11.00"
        Me.TemplateEventoNews4.TemplateImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("TemplateEventoNews4.TemplateImage"))
        Me.TemplateEventoNews4.TemplateWidthDescrizione = 550
        Me.TemplateEventoNews4.TemplateWidthImage = 150
        '
        'TemplateEventoNews2
        '
        Me.TemplateEventoNews2.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateEventoNews2.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TemplateEventoNews2.Location = New System.Drawing.Point(0, 187)
        Me.TemplateEventoNews2.Name = "TemplateEventoNews2"
        Me.TemplateEventoNews2.Size = New System.Drawing.Size(820, 97)
        Me.TemplateEventoNews2.TabIndex = 2
        Me.TemplateEventoNews2.TemplateDescription = Nothing
        Me.TemplateEventoNews2.TemplateImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("TemplateEventoNews2.TemplateImage"))
        Me.TemplateEventoNews2.TemplateWidthDescrizione = 0
        Me.TemplateEventoNews2.TemplateWidthImage = 400
        '
        'txtTitle
        '
        Me.txtTitle.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(0, 30)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(678, 33)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "News"
        '
        'TemplateEventoNews3
        '
        Me.TemplateEventoNews3.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.TemplateEventoNews3.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateEventoNews3.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TemplateEventoNews3.Location = New System.Drawing.Point(0, 290)
        Me.TemplateEventoNews3.Name = "TemplateEventoNews3"
        Me.TemplateEventoNews3.Size = New System.Drawing.Size(820, 250)
        Me.TemplateEventoNews3.TabIndex = 4
        Me.TemplateEventoNews3.TemplateDescription = "Serata di beneficenza per una raccolta fondi per la banca del latte, che si svolg" & _
    "erà presso la Galleria Commerciale Marconipiù, in via Guglielmo Marconi a Rende " & _
    "(Cosenza)"
        Me.TemplateEventoNews3.TemplateImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("TemplateEventoNews3.TemplateImage"))
        Me.TemplateEventoNews3.TemplateWidthDescrizione = 550
        Me.TemplateEventoNews3.TemplateWidthImage = 150
        '
        'TemplateEventoNews1
        '
        Me.TemplateEventoNews1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange
        Me.TemplateEventoNews1.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.TemplateEventoNews1.Location = New System.Drawing.Point(0, 65)
        Me.TemplateEventoNews1.Name = "TemplateEventoNews1"
        Me.TemplateEventoNews1.Size = New System.Drawing.Size(820, 122)
        Me.TemplateEventoNews1.TabIndex = 0
        Me.TemplateEventoNews1.TemplateDescription = ""
        Me.TemplateEventoNews1.TemplateImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("TemplateEventoNews1.TemplateImage"))
        Me.TemplateEventoNews1.TemplateWidthDescrizione = 0
        Me.TemplateEventoNews1.TemplateWidthImage = 400
        '
        'EventiNews
        '
        Me.Size = New System.Drawing.Size(1024, 780)
        Me.Controls.SetChildIndex(Me.panelBody, 0)
        Me.panelBody.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents txtTitle As Gizmox.WebGUI.Forms.Label
    Friend WithEvents TemplateEventoNews1 As Library.TemplateEventoNews
    Friend WithEvents TemplateEventoNews2 As Library.TemplateEventoNews
    Friend WithEvents TemplateEventoNews3 As Library.TemplateEventoNews
    Friend WithEvents TemplateEventoNews4 As Library.TemplateEventoNews

#End Region

End Class
