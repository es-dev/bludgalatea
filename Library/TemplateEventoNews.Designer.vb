Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateEventoNews
    Inherits Gizmox.WebGui.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual WebGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateEventoNews))
        Me.imgStampa = New Gizmox.WebGUI.Forms.PictureBox()
        Me.imgEmail = New Gizmox.WebGUI.Forms.PictureBox()
        Me.imgPdf = New Gizmox.WebGUI.Forms.PictureBox()
        Me.pnlImage = New Gizmox.WebGUI.Forms.Panel()
        Me.panelContenuto = New Gizmox.WebGUI.Forms.Panel()
        Me.lblDescrizione = New Gizmox.WebGUI.Forms.Label()
        Me.imgEvento = New Gizmox.WebGUI.Forms.PictureBox()
        CType(Me.imgStampa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImage.SuspendLayout()
        Me.panelContenuto.SuspendLayout()
        CType(Me.imgEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgStampa
        '
        Me.imgStampa.BackgroundImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgStampa.BackgroundImage"))
        Me.imgStampa.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center
        Me.imgStampa.Location = New System.Drawing.Point(37, 9)
        Me.imgStampa.Name = "imgStampa"
        Me.imgStampa.Size = New System.Drawing.Size(20, 20)
        Me.imgStampa.TabIndex = 1
        Me.imgStampa.TabStop = False
        '
        'imgEmail
        '
        Me.imgEmail.BackgroundImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgEmail.BackgroundImage"))
        Me.imgEmail.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center
        Me.imgEmail.Location = New System.Drawing.Point(66, 9)
        Me.imgEmail.Name = "imgEmail"
        Me.imgEmail.Size = New System.Drawing.Size(20, 20)
        Me.imgEmail.TabIndex = 1
        Me.imgEmail.TabStop = False
        '
        'imgPdf
        '
        Me.imgPdf.BackgroundImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgPdf.BackgroundImage"))
        Me.imgPdf.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Center
        Me.imgPdf.Location = New System.Drawing.Point(8, 9)
        Me.imgPdf.Name = "imgPdf"
        Me.imgPdf.Size = New System.Drawing.Size(20, 20)
        Me.imgPdf.TabIndex = 0
        Me.imgPdf.TabStop = False
        '
        'pnlImage
        '
        Me.pnlImage.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnlImage.Controls.Add(Me.imgStampa)
        Me.pnlImage.Controls.Add(Me.imgEmail)
        Me.pnlImage.Controls.Add(Me.imgPdf)
        Me.pnlImage.Location = New System.Drawing.Point(722, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(98, 42)
        Me.pnlImage.TabIndex = 1
        '
        'panelContenuto
        '
        Me.panelContenuto.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.panelContenuto.Controls.Add(Me.lblDescrizione)
        Me.panelContenuto.Controls.Add(Me.imgEvento)
        Me.panelContenuto.Location = New System.Drawing.Point(0, 32)
        Me.panelContenuto.Name = "panelContenuto"
        Me.panelContenuto.Size = New System.Drawing.Size(720, 252)
        Me.panelContenuto.TabIndex = 2
        '
        'lblDescrizione
        '
        Me.lblDescrizione.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.lblDescrizione.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizione.ForeColor = System.Drawing.Color.White
        Me.lblDescrizione.Location = New System.Drawing.Point(169, 34)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(550, 185)
        Me.lblDescrizione.TabIndex = 1
        Me.lblDescrizione.Text = "Label1"
        '
        'imgEvento
        '
        Me.imgEvento.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.imgEvento.Location = New System.Drawing.Point(0, 0)
        Me.imgEvento.Name = "imgEvento"
        Me.imgEvento.Size = New System.Drawing.Size(150, 252)
        Me.imgEvento.TabIndex = 0
        Me.imgEvento.TabStop = False
        '
        'TemplateEventoNews
        '
        Me.BackColor =  System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Controls.Add(Me.panelContenuto)
        Me.Controls.Add(Me.pnlImage)
        Me.Size = New System.Drawing.Size(820, 284)
        CType(Me.imgStampa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImage.ResumeLayout(False)
        Me.panelContenuto.ResumeLayout(False)
        CType(Me.imgEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgStampa As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents imgEmail As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents imgPdf As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents pnlImage As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents panelContenuto As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents lblDescrizione As Gizmox.WebGUI.Forms.Label
    Friend WithEvents imgEvento As Gizmox.WebGUI.Forms.PictureBox

End Class
