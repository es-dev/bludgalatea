Imports Gizmox.WebGUI.Forms
Imports Gizmox.WebGUI.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateForm
    Inherits Gizmox.WebGUI.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateForm))
        Me.panelHeader = New Gizmox.WebGUI.Forms.Panel()
        Me.panelNavigation = New Gizmox.WebGUI.Forms.Panel()
        Me.linkComeDonare = New ESD.Library.JQLinkLabel()
        Me.linkChiPuoDonare = New ESD.Library.JQLinkLabel()
        Me.linkPercheDonare = New ESD.Library.JQLinkLabel()
        Me.lnkIoCresco = New ESD.Library.JQLinkLabel()
        Me.linkChiSiamo = New ESD.Library.JQLinkLabel()
        Me.imgHeader = New Gizmox.WebGUI.Forms.PictureBox()
        Me.panelBody = New Gizmox.WebGUI.Forms.Panel()
        Me.panelFooter = New Gizmox.WebGUI.Forms.Panel()
        Me.imgFooter = New Gizmox.WebGUI.Forms.PictureBox()
        Me.panelNavigazione = New Gizmox.WebGUI.Forms.Panel()
        Me.lnkEventi = New ESD.Library.JQLinkLabel()
        Me.lnkDomandeFrequenti = New ESD.Library.JQLinkLabel()
        Me.lnkLosapevi = New ESD.Library.JQLinkLabel()
        Me.lnkHome = New ESD.Library.JQLinkLabel()
        Me.panelHeader.SuspendLayout()
        Me.panelNavigation.SuspendLayout()
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBody.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        CType(Me.imgFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNavigazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.Pink
        Me.panelHeader.Controls.Add(Me.panelNavigation)
        Me.panelHeader.Controls.Add(Me.imgHeader)
        Me.panelHeader.Dock = Gizmox.WebGUI.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.MinimumSize = New System.Drawing.Size(1024, 250)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1024, 250)
        Me.panelHeader.TabIndex = 0
        '
        'panelNavigation
        '
        Me.panelNavigation.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelNavigation.BackColor = System.Drawing.Color.PaleVioletRed
        Me.panelNavigation.Controls.Add(Me.linkComeDonare)
        Me.panelNavigation.Controls.Add(Me.linkChiPuoDonare)
        Me.panelNavigation.Controls.Add(Me.linkPercheDonare)
        Me.panelNavigation.Controls.Add(Me.lnkIoCresco)
        Me.panelNavigation.Controls.Add(Me.linkChiSiamo)
        Me.panelNavigation.Location = New System.Drawing.Point(0, 217)
        Me.panelNavigation.Name = "panelNavigation"
        Me.panelNavigation.Size = New System.Drawing.Size(1024, 33)
        Me.panelNavigation.TabIndex = 1
        '
        'linkComeDonare
        '
        Me.linkComeDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.linkComeDonare.AutoSize = True
        Me.linkComeDonare.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.linkComeDonare.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.linkComeDonare.ForeColor = System.Drawing.Color.White
        Me.linkComeDonare.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.linkComeDonare.JQEnterForeColor = System.Drawing.Color.Red
        Me.linkComeDonare.Location = New System.Drawing.Point(579, 7)
        Me.linkComeDonare.Name = "linkComeDonare"
        Me.linkComeDonare.Size = New System.Drawing.Size(100, 21)
        Me.linkComeDonare.TabIndex = 4
        Me.linkComeDonare.Text = "Come donare"
        '
        'linkChiPuoDonare
        '
        Me.linkChiPuoDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.linkChiPuoDonare.AutoSize = True
        Me.linkChiPuoDonare.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.linkChiPuoDonare.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.linkChiPuoDonare.ForeColor = System.Drawing.Color.White
        Me.linkChiPuoDonare.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.linkChiPuoDonare.JQEnterForeColor = System.Drawing.Color.Red
        Me.linkChiPuoDonare.Location = New System.Drawing.Point(440, 7)
        Me.linkChiPuoDonare.Name = "linkChiPuoDonare"
        Me.linkChiPuoDonare.Size = New System.Drawing.Size(100, 21)
        Me.linkChiPuoDonare.TabIndex = 3
        Me.linkChiPuoDonare.Text = "Chi può donare"
        '
        'linkPercheDonare
        '
        Me.linkPercheDonare.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.linkPercheDonare.AutoSize = True
        Me.linkPercheDonare.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.linkPercheDonare.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.linkPercheDonare.ForeColor = System.Drawing.Color.White
        Me.linkPercheDonare.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.linkPercheDonare.JQEnterForeColor = System.Drawing.Color.Red
        Me.linkPercheDonare.Location = New System.Drawing.Point(310, 7)
        Me.linkPercheDonare.Name = "linkPercheDonare"
        Me.linkPercheDonare.Size = New System.Drawing.Size(100, 21)
        Me.linkPercheDonare.TabIndex = 2
        Me.linkPercheDonare.Text = "Perchè donare"
        '
        'lnkIoCresco
        '
        Me.lnkIoCresco.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.lnkIoCresco.AutoSize = True
        Me.lnkIoCresco.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.lnkIoCresco.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lnkIoCresco.ForeColor = System.Drawing.Color.White
        Me.lnkIoCresco.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.lnkIoCresco.JQEnterForeColor = System.Drawing.Color.Red
        Me.lnkIoCresco.Location = New System.Drawing.Point(114, 7)
        Me.lnkIoCresco.Name = "lnkIoCresco"
        Me.lnkIoCresco.Size = New System.Drawing.Size(100, 21)
        Me.lnkIoCresco.TabIndex = 1
        Me.lnkIoCresco.Text = "Io cresco, grazie mamma"
        '
        'linkChiSiamo
        '
        Me.linkChiSiamo.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.linkChiSiamo.AutoSize = True
        Me.linkChiSiamo.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.linkChiSiamo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.linkChiSiamo.ForeColor = System.Drawing.Color.White
        Me.linkChiSiamo.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.linkChiSiamo.JQEnterForeColor = System.Drawing.Color.Red
        Me.linkChiSiamo.Location = New System.Drawing.Point(10, 7)
        Me.linkChiSiamo.Name = "linkChiSiamo"
        Me.linkChiSiamo.Size = New System.Drawing.Size(100, 21)
        Me.linkChiSiamo.TabIndex = 0
        Me.linkChiSiamo.Text = "Chi siamo"
        '
        'imgHeader
        '
        Me.imgHeader.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.imgHeader.BackgroundImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgHeader.BackgroundImage"))
        Me.imgHeader.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch
        Me.imgHeader.Location = New System.Drawing.Point(0, 0)
        Me.imgHeader.Name = "imgHeader"
        Me.imgHeader.Size = New System.Drawing.Size(1024, 217)
        Me.imgHeader.TabIndex = 0
        Me.imgHeader.TabStop = False
        '
        'panelBody
        '
        Me.panelBody.Anchor = CType((((Gizmox.WebGUI.Forms.AnchorStyles.Top Or Gizmox.WebGUI.Forms.AnchorStyles.Bottom) _
            Or Gizmox.WebGUI.Forms.AnchorStyles.Left) _
            Or Gizmox.WebGUI.Forms.AnchorStyles.Right), Gizmox.WebGUI.Forms.AnchorStyles)
        Me.panelBody.BackColor = System.Drawing.Color.Pink
        Me.panelBody.Controls.Add(Me.panelFooter)
        Me.panelBody.Controls.Add(Me.panelNavigazione)
        Me.panelBody.Location = New System.Drawing.Point(0, 250)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(1024, 450)
        Me.panelBody.TabIndex = 1
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.Pink
        Me.panelFooter.Controls.Add(Me.imgFooter)
        Me.panelFooter.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 392)
        Me.panelFooter.MinimumSize = New System.Drawing.Size(1024, 65)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(1024, 65)
        Me.panelFooter.TabIndex = 2
        '
        'imgFooter
        '
        Me.imgFooter.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.imgFooter.BackgroundImage = New Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("imgFooter.BackgroundImage"))
        Me.imgFooter.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch
        Me.imgFooter.Location = New System.Drawing.Point(0, 0)
        Me.imgFooter.Name = "imgFooter"
        Me.imgFooter.Size = New System.Drawing.Size(1024, 65)
        Me.imgFooter.TabIndex = 0
        Me.imgFooter.TabStop = False
        '
        'panelNavigazione
        '
        Me.panelNavigazione.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.panelNavigazione.BackColor = System.Drawing.Color.Pink
        Me.panelNavigazione.Controls.Add(Me.lnkEventi)
        Me.panelNavigazione.Controls.Add(Me.lnkDomandeFrequenti)
        Me.panelNavigazione.Controls.Add(Me.lnkLosapevi)
        Me.panelNavigazione.Controls.Add(Me.lnkHome)
        Me.panelNavigazione.Location = New System.Drawing.Point(0, 0)
        Me.panelNavigazione.Name = "panelNavigazione"
        Me.panelNavigazione.Size = New System.Drawing.Size(174, 151)
        Me.panelNavigazione.TabIndex = 0
        '
        'lnkEventi
        '
        Me.lnkEventi.AutoSize = True
        Me.lnkEventi.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.lnkEventi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lnkEventi.ForeColor = System.Drawing.Color.White
        Me.lnkEventi.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.lnkEventi.JQEnterForeColor = System.Drawing.Color.Red
        Me.lnkEventi.Location = New System.Drawing.Point(30, 114)
        Me.lnkEventi.Name = "lnkEventi"
        Me.lnkEventi.Size = New System.Drawing.Size(100, 21)
        Me.lnkEventi.TabIndex = 3
        Me.lnkEventi.Text = "Eventi e news"
        '
        'lnkDomandeFrequenti
        '
        Me.lnkDomandeFrequenti.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Top
        Me.lnkDomandeFrequenti.AutoSize = True
        Me.lnkDomandeFrequenti.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.lnkDomandeFrequenti.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lnkDomandeFrequenti.ForeColor = System.Drawing.Color.White
        Me.lnkDomandeFrequenti.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.lnkDomandeFrequenti.JQEnterForeColor = System.Drawing.Color.Red
        Me.lnkDomandeFrequenti.Location = New System.Drawing.Point(30, 60)
        Me.lnkDomandeFrequenti.Name = "lnkDomandeFrequenti"
        Me.lnkDomandeFrequenti.Size = New System.Drawing.Size(100, 21)
        Me.lnkDomandeFrequenti.TabIndex = 2
        Me.lnkDomandeFrequenti.Text = "Domande frequenti"
        '
        'lnkLosapevi
        '
        Me.lnkLosapevi.AutoSize = True
        Me.lnkLosapevi.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.lnkLosapevi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lnkLosapevi.ForeColor = System.Drawing.Color.White
        Me.lnkLosapevi.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.lnkLosapevi.JQEnterForeColor = System.Drawing.Color.Red
        Me.lnkLosapevi.Location = New System.Drawing.Point(30, 87)
        Me.lnkLosapevi.Name = "lnkLosapevi"
        Me.lnkLosapevi.Size = New System.Drawing.Size(100, 21)
        Me.lnkLosapevi.TabIndex = 3
        Me.lnkLosapevi.Text = "Lo sapevi che..."
        '
        'lnkHome
        '
        Me.lnkHome.AutoSize = True
        Me.lnkHome.Cursor = Gizmox.WebGUI.Forms.Cursors.Hand
        Me.lnkHome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lnkHome.ForeColor = System.Drawing.Color.White
        Me.lnkHome.JQDownForeColor = System.Drawing.Color.RoyalBlue
        Me.lnkHome.JQEnterForeColor = System.Drawing.Color.Red
        Me.lnkHome.Location = New System.Drawing.Point(30, 33)
        Me.lnkHome.Name = "lnkHome"
        Me.lnkHome.Size = New System.Drawing.Size(100, 21)
        Me.lnkHome.TabIndex = 4
        Me.lnkHome.Text = "Home"
        '
        'TemplateForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Pink
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelHeader)
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.StartPosition = Gizmox.WebGUI.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "TemplateForm"
        Me.panelHeader.ResumeLayout(False)
        Me.panelNavigation.ResumeLayout(False)
        CType(Me.imgHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBody.ResumeLayout(False)
        Me.panelFooter.ResumeLayout(False)
        CType(Me.imgFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNavigazione.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHeader As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents panelFooter As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents panelNavigation As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents linkComeDonare As ESD.Library.JQLinkLabel
    Friend WithEvents linkChiPuoDonare As ESD.Library.JQLinkLabel
    Friend WithEvents linkPercheDonare As ESD.Library.JQLinkLabel
    Friend WithEvents lnkIoCresco As ESD.Library.JQLinkLabel
    Friend WithEvents linkChiSiamo As ESD.Library.JQLinkLabel
    Friend WithEvents imgHeader As Gizmox.WebGUI.Forms.PictureBox
    Friend WithEvents panelNavigazione As Gizmox.WebGUI.Forms.Panel
    Friend WithEvents lnkEventi As ESD.Library.JQLinkLabel
    Friend WithEvents lnkDomandeFrequenti As ESD.Library.JQLinkLabel
    Friend WithEvents lnkLosapevi As ESD.Library.JQLinkLabel
    Friend WithEvents lnkHome As ESD.Library.JQLinkLabel
    Friend WithEvents imgFooter As Gizmox.WebGUI.Forms.PictureBox
    Public WithEvents panelBody As Gizmox.WebGUI.Forms.Panel

End Class