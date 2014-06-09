Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateTitle))
        Me.lblTitolo = New Gizmox.WebGUI.Forms.Label()
        Me.pnlImage = New Gizmox.WebGUI.Forms.Panel()
        Me.imgStampa = New Gizmox.WebGUI.Forms.PictureBox()
        Me.imgEmail = New Gizmox.WebGUI.Forms.PictureBox()
        Me.imgPdf = New Gizmox.WebGUI.Forms.PictureBox()
        Me.pnlImage.SuspendLayout()
        CType(Me.imgStampa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitolo
        '
        Me.lblTitolo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitolo.ForeColor = System.Drawing.Color.Black
        Me.lblTitolo.Location = New System.Drawing.Point(0, 9)
        Me.lblTitolo.Name = "lblTitolo"
        Me.lblTitolo.Size = New System.Drawing.Size(678, 33)
        Me.lblTitolo.TabIndex = 0
        Me.lblTitolo.Text = "Label1"
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.pnlImage.Controls.Add(Me.imgStampa)
        Me.pnlImage.Controls.Add(Me.imgEmail)
        Me.pnlImage.Controls.Add(Me.imgPdf)
        Me.pnlImage.Location = New System.Drawing.Point(678, 0)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(98, 42)
        Me.pnlImage.TabIndex = 1
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
        'TemplateTitle
        '
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.lblTitolo)
        Me.Size = New System.Drawing.Size(820, 48)
        Me.pnlImage.ResumeLayout(False)
        CType(Me.imgStampa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitolo As Gizmox.WebGUI.Forms.Label
    Friend WithEvents pnlImage As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents imgStampa As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents imgEmail As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents imgPdf As Gizmox.WebGUI.Forms.PictureBox

End Class
