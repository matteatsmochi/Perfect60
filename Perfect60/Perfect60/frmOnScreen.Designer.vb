<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnScreen))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picArena0 = New System.Windows.Forms.PictureBox()
        Me.picArena1 = New System.Windows.Forms.PictureBox()
        Me.picArena2 = New System.Windows.Forms.PictureBox()
        Me.picArena4 = New System.Windows.Forms.PictureBox()
        Me.picArena3 = New System.Windows.Forms.PictureBox()
        Me.lblArena0Wins = New System.Windows.Forms.Label()
        Me.lblArena0Loss = New System.Windows.Forms.Label()
        Me.lblArena0ClassName = New System.Windows.Forms.Label()
        Me.lblArena1ClassName = New System.Windows.Forms.Label()
        Me.lblArena1Loss = New System.Windows.Forms.Label()
        Me.lblArena1Wins = New System.Windows.Forms.Label()
        Me.lblArena2Loss = New System.Windows.Forms.Label()
        Me.lblArena2Wins = New System.Windows.Forms.Label()
        Me.lblArena2ClassName = New System.Windows.Forms.Label()
        Me.lblArena3Loss = New System.Windows.Forms.Label()
        Me.lblArena3Wins = New System.Windows.Forms.Label()
        Me.lblArena3ClassName = New System.Windows.Forms.Label()
        Me.lblArena4Loss = New System.Windows.Forms.Label()
        Me.lblArena4Wins = New System.Windows.Forms.Label()
        Me.lblArena4ClassName = New System.Windows.Forms.Label()
        CType(Me.picArena0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArena1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArena2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArena4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArena3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Cornerstone", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(115, 74)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(92, 45)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "33"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picArena0
        '
        Me.picArena0.BackColor = System.Drawing.Color.Transparent
        Me.picArena0.BackgroundImage = Global.Perfect60.My.Resources.Resources.icon_class_hunter
        Me.picArena0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArena0.Location = New System.Drawing.Point(50, 135)
        Me.picArena0.Name = "picArena0"
        Me.picArena0.Size = New System.Drawing.Size(50, 50)
        Me.picArena0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArena0.TabIndex = 2
        Me.picArena0.TabStop = False
        '
        'picArena1
        '
        Me.picArena1.BackColor = System.Drawing.Color.Transparent
        Me.picArena1.BackgroundImage = Global.Perfect60.My.Resources.Resources.icon_class_mage
        Me.picArena1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArena1.Location = New System.Drawing.Point(59, 191)
        Me.picArena1.Name = "picArena1"
        Me.picArena1.Size = New System.Drawing.Size(32, 32)
        Me.picArena1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArena1.TabIndex = 3
        Me.picArena1.TabStop = False
        '
        'picArena2
        '
        Me.picArena2.BackColor = System.Drawing.Color.Transparent
        Me.picArena2.BackgroundImage = Global.Perfect60.My.Resources.Resources.icon_class_warrior
        Me.picArena2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArena2.Location = New System.Drawing.Point(59, 225)
        Me.picArena2.Name = "picArena2"
        Me.picArena2.Size = New System.Drawing.Size(32, 32)
        Me.picArena2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArena2.TabIndex = 4
        Me.picArena2.TabStop = False
        '
        'picArena4
        '
        Me.picArena4.BackColor = System.Drawing.Color.Transparent
        Me.picArena4.BackgroundImage = Global.Perfect60.My.Resources.Resources.icon_class_druid
        Me.picArena4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArena4.Location = New System.Drawing.Point(59, 294)
        Me.picArena4.Name = "picArena4"
        Me.picArena4.Size = New System.Drawing.Size(32, 32)
        Me.picArena4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArena4.TabIndex = 6
        Me.picArena4.TabStop = False
        '
        'picArena3
        '
        Me.picArena3.BackColor = System.Drawing.Color.Transparent
        Me.picArena3.BackgroundImage = Global.Perfect60.My.Resources.Resources.icon_class_priest
        Me.picArena3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picArena3.Location = New System.Drawing.Point(59, 260)
        Me.picArena3.Name = "picArena3"
        Me.picArena3.Size = New System.Drawing.Size(32, 32)
        Me.picArena3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArena3.TabIndex = 5
        Me.picArena3.TabStop = False
        '
        'lblArena0Wins
        '
        Me.lblArena0Wins.BackColor = System.Drawing.Color.Transparent
        Me.lblArena0Wins.Font = New System.Drawing.Font("Cornerstone", 28.0!)
        Me.lblArena0Wins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena0Wins.Location = New System.Drawing.Point(180, 141)
        Me.lblArena0Wins.Name = "lblArena0Wins"
        Me.lblArena0Wins.Size = New System.Drawing.Size(55, 44)
        Me.lblArena0Wins.TabIndex = 7
        Me.lblArena0Wins.Text = "12"
        Me.lblArena0Wins.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArena0Loss
        '
        Me.lblArena0Loss.BackColor = System.Drawing.Color.Transparent
        Me.lblArena0Loss.Font = New System.Drawing.Font("Cornerstone", 28.0!)
        Me.lblArena0Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena0Loss.Location = New System.Drawing.Point(227, 141)
        Me.lblArena0Loss.Name = "lblArena0Loss"
        Me.lblArena0Loss.Size = New System.Drawing.Size(55, 44)
        Me.lblArena0Loss.TabIndex = 8
        Me.lblArena0Loss.Text = "3"
        '
        'lblArena0ClassName
        '
        Me.lblArena0ClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblArena0ClassName.Font = New System.Drawing.Font("Cornerstone", 14.0!)
        Me.lblArena0ClassName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena0ClassName.Location = New System.Drawing.Point(98, 151)
        Me.lblArena0ClassName.Name = "lblArena0ClassName"
        Me.lblArena0ClassName.Size = New System.Drawing.Size(92, 29)
        Me.lblArena0ClassName.TabIndex = 9
        Me.lblArena0ClassName.Text = "warlock"
        Me.lblArena0ClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblArena1ClassName
        '
        Me.lblArena1ClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblArena1ClassName.Font = New System.Drawing.Font("Cornerstone", 12.0!)
        Me.lblArena1ClassName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena1ClassName.Location = New System.Drawing.Point(93, 202)
        Me.lblArena1ClassName.Name = "lblArena1ClassName"
        Me.lblArena1ClassName.Size = New System.Drawing.Size(92, 21)
        Me.lblArena1ClassName.TabIndex = 10
        Me.lblArena1ClassName.Text = "warlock"
        Me.lblArena1ClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblArena1Loss
        '
        Me.lblArena1Loss.BackColor = System.Drawing.Color.Transparent
        Me.lblArena1Loss.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena1Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena1Loss.Location = New System.Drawing.Point(226, 195)
        Me.lblArena1Loss.Name = "lblArena1Loss"
        Me.lblArena1Loss.Size = New System.Drawing.Size(55, 28)
        Me.lblArena1Loss.TabIndex = 12
        Me.lblArena1Loss.Text = "3"
        '
        'lblArena1Wins
        '
        Me.lblArena1Wins.BackColor = System.Drawing.Color.Transparent
        Me.lblArena1Wins.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena1Wins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena1Wins.Location = New System.Drawing.Point(177, 195)
        Me.lblArena1Wins.Name = "lblArena1Wins"
        Me.lblArena1Wins.Size = New System.Drawing.Size(55, 28)
        Me.lblArena1Wins.TabIndex = 11
        Me.lblArena1Wins.Text = "12"
        Me.lblArena1Wins.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArena2Loss
        '
        Me.lblArena2Loss.BackColor = System.Drawing.Color.Transparent
        Me.lblArena2Loss.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena2Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena2Loss.Location = New System.Drawing.Point(226, 229)
        Me.lblArena2Loss.Name = "lblArena2Loss"
        Me.lblArena2Loss.Size = New System.Drawing.Size(55, 28)
        Me.lblArena2Loss.TabIndex = 15
        Me.lblArena2Loss.Text = "3"
        '
        'lblArena2Wins
        '
        Me.lblArena2Wins.BackColor = System.Drawing.Color.Transparent
        Me.lblArena2Wins.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena2Wins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena2Wins.Location = New System.Drawing.Point(177, 229)
        Me.lblArena2Wins.Name = "lblArena2Wins"
        Me.lblArena2Wins.Size = New System.Drawing.Size(55, 28)
        Me.lblArena2Wins.TabIndex = 14
        Me.lblArena2Wins.Text = "12"
        Me.lblArena2Wins.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArena2ClassName
        '
        Me.lblArena2ClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblArena2ClassName.Font = New System.Drawing.Font("Cornerstone", 12.0!)
        Me.lblArena2ClassName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena2ClassName.Location = New System.Drawing.Point(93, 236)
        Me.lblArena2ClassName.Name = "lblArena2ClassName"
        Me.lblArena2ClassName.Size = New System.Drawing.Size(92, 21)
        Me.lblArena2ClassName.TabIndex = 13
        Me.lblArena2ClassName.Text = "warlock"
        Me.lblArena2ClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblArena3Loss
        '
        Me.lblArena3Loss.BackColor = System.Drawing.Color.Transparent
        Me.lblArena3Loss.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena3Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena3Loss.Location = New System.Drawing.Point(226, 264)
        Me.lblArena3Loss.Name = "lblArena3Loss"
        Me.lblArena3Loss.Size = New System.Drawing.Size(55, 28)
        Me.lblArena3Loss.TabIndex = 18
        Me.lblArena3Loss.Text = "3"
        '
        'lblArena3Wins
        '
        Me.lblArena3Wins.BackColor = System.Drawing.Color.Transparent
        Me.lblArena3Wins.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena3Wins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena3Wins.Location = New System.Drawing.Point(177, 264)
        Me.lblArena3Wins.Name = "lblArena3Wins"
        Me.lblArena3Wins.Size = New System.Drawing.Size(55, 28)
        Me.lblArena3Wins.TabIndex = 17
        Me.lblArena3Wins.Text = "12"
        Me.lblArena3Wins.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArena3ClassName
        '
        Me.lblArena3ClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblArena3ClassName.Font = New System.Drawing.Font("Cornerstone", 12.0!)
        Me.lblArena3ClassName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena3ClassName.Location = New System.Drawing.Point(93, 271)
        Me.lblArena3ClassName.Name = "lblArena3ClassName"
        Me.lblArena3ClassName.Size = New System.Drawing.Size(92, 21)
        Me.lblArena3ClassName.TabIndex = 16
        Me.lblArena3ClassName.Text = "warlock"
        Me.lblArena3ClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblArena4Loss
        '
        Me.lblArena4Loss.BackColor = System.Drawing.Color.Transparent
        Me.lblArena4Loss.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena4Loss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena4Loss.Location = New System.Drawing.Point(226, 298)
        Me.lblArena4Loss.Name = "lblArena4Loss"
        Me.lblArena4Loss.Size = New System.Drawing.Size(55, 28)
        Me.lblArena4Loss.TabIndex = 21
        Me.lblArena4Loss.Text = "3"
        '
        'lblArena4Wins
        '
        Me.lblArena4Wins.BackColor = System.Drawing.Color.Transparent
        Me.lblArena4Wins.Font = New System.Drawing.Font("Cornerstone", 20.0!)
        Me.lblArena4Wins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena4Wins.Location = New System.Drawing.Point(177, 298)
        Me.lblArena4Wins.Name = "lblArena4Wins"
        Me.lblArena4Wins.Size = New System.Drawing.Size(55, 28)
        Me.lblArena4Wins.TabIndex = 20
        Me.lblArena4Wins.Text = "12"
        Me.lblArena4Wins.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblArena4ClassName
        '
        Me.lblArena4ClassName.BackColor = System.Drawing.Color.Transparent
        Me.lblArena4ClassName.Font = New System.Drawing.Font("Cornerstone", 12.0!)
        Me.lblArena4ClassName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblArena4ClassName.Location = New System.Drawing.Point(93, 305)
        Me.lblArena4ClassName.Name = "lblArena4ClassName"
        Me.lblArena4ClassName.Size = New System.Drawing.Size(92, 21)
        Me.lblArena4ClassName.TabIndex = 19
        Me.lblArena4ClassName.Text = "warlock"
        Me.lblArena4ClassName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmOnScreen
        '
        Me.BackgroundImage = Global.Perfect60.My.Resources.Resources.Perfect_60_Back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(301, 360)
        Me.Controls.Add(Me.lblArena4Loss)
        Me.Controls.Add(Me.lblArena4Wins)
        Me.Controls.Add(Me.lblArena4ClassName)
        Me.Controls.Add(Me.lblArena3Loss)
        Me.Controls.Add(Me.lblArena3Wins)
        Me.Controls.Add(Me.lblArena3ClassName)
        Me.Controls.Add(Me.lblArena2Loss)
        Me.Controls.Add(Me.lblArena2Wins)
        Me.Controls.Add(Me.lblArena2ClassName)
        Me.Controls.Add(Me.lblArena1Loss)
        Me.Controls.Add(Me.lblArena1Wins)
        Me.Controls.Add(Me.lblArena1ClassName)
        Me.Controls.Add(Me.picArena0)
        Me.Controls.Add(Me.lblArena0ClassName)
        Me.Controls.Add(Me.picArena4)
        Me.Controls.Add(Me.picArena3)
        Me.Controls.Add(Me.picArena2)
        Me.Controls.Add(Me.picArena1)
        Me.Controls.Add(Me.lblArena0Loss)
        Me.Controls.Add(Me.lblArena0Wins)
        Me.Controls.Add(Me.lblScore)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOnScreen"
        Me.Text = "Perf60 OBS"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.picArena0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArena1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArena2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArena4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArena3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picOnScreenBack As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents picArena0 As PictureBox
    Friend WithEvents picArena1 As PictureBox
    Friend WithEvents picArena2 As PictureBox
    Friend WithEvents picArena4 As PictureBox
    Friend WithEvents picArena3 As PictureBox
    Friend WithEvents lblArena0Wins As Label
    Friend WithEvents lblArena0Loss As Label
    Friend WithEvents lblArena0ClassName As Label
    Friend WithEvents lblArena1ClassName As Label
    Friend WithEvents lblArena1Loss As Label
    Friend WithEvents lblArena1Wins As Label
    Friend WithEvents lblArena2Loss As Label
    Friend WithEvents lblArena2Wins As Label
    Friend WithEvents lblArena2ClassName As Label
    Friend WithEvents lblArena3Loss As Label
    Friend WithEvents lblArena3Wins As Label
    Friend WithEvents lblArena3ClassName As Label
    Friend WithEvents lblArena4Loss As Label
    Friend WithEvents lblArena4Wins As Label
    Friend WithEvents lblArena4ClassName As Label
End Class
