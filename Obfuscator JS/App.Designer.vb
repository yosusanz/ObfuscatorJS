<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.LabelInputFolder = New System.Windows.Forms.Label()
        Me.TextBoxInputFolder = New System.Windows.Forms.TextBox()
        Me.TextBoxOutputFolder = New System.Windows.Forms.TextBox()
        Me.LabelOutputFolder = New System.Windows.Forms.Label()
        Me.ButtonObfuscate = New System.Windows.Forms.Button()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.LabelLicense = New System.Windows.Forms.Label()
        Me.LabelCreator = New System.Windows.Forms.Label()
        Me.PictureBoxLinkedin = New System.Windows.Forms.PictureBox()
        Me.PictureBoxOutputFolder = New System.Windows.Forms.PictureBox()
        Me.PictureBoxInputFolder = New System.Windows.Forms.PictureBox()
        Me.LabelFollowMeOn = New System.Windows.Forms.Label()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.LabelSetDirectories = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.LabelProgressStatus = New System.Windows.Forms.Label()
        Me.PanelFooter.SuspendLayout()
        CType(Me.PictureBoxLinkedin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutputFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxInputFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelInputFolder
        '
        Me.LabelInputFolder.AutoSize = True
        Me.LabelInputFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.LabelInputFolder.Location = New System.Drawing.Point(50, 84)
        Me.LabelInputFolder.Name = "LabelInputFolder"
        Me.LabelInputFolder.Size = New System.Drawing.Size(106, 13)
        Me.LabelInputFolder.TabIndex = 0
        Me.LabelInputFolder.Text = "Directorio de entrada"
        '
        'TextBoxInputFolder
        '
        Me.TextBoxInputFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInputFolder.Enabled = False
        Me.TextBoxInputFolder.Location = New System.Drawing.Point(53, 100)
        Me.TextBoxInputFolder.Name = "TextBoxInputFolder"
        Me.TextBoxInputFolder.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxInputFolder.TabIndex = 1
        '
        'TextBoxOutputFolder
        '
        Me.TextBoxOutputFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxOutputFolder.Enabled = False
        Me.TextBoxOutputFolder.Location = New System.Drawing.Point(53, 144)
        Me.TextBoxOutputFolder.Name = "TextBoxOutputFolder"
        Me.TextBoxOutputFolder.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxOutputFolder.TabIndex = 4
        '
        'LabelOutputFolder
        '
        Me.LabelOutputFolder.AutoSize = True
        Me.LabelOutputFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.LabelOutputFolder.Location = New System.Drawing.Point(50, 128)
        Me.LabelOutputFolder.Name = "LabelOutputFolder"
        Me.LabelOutputFolder.Size = New System.Drawing.Size(97, 13)
        Me.LabelOutputFolder.TabIndex = 3
        Me.LabelOutputFolder.Text = "Directorio de salida"
        '
        'ButtonObfuscate
        '
        Me.ButtonObfuscate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonObfuscate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ButtonObfuscate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonObfuscate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonObfuscate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonObfuscate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ButtonObfuscate.Location = New System.Drawing.Point(235, 183)
        Me.ButtonObfuscate.Name = "ButtonObfuscate"
        Me.ButtonObfuscate.Size = New System.Drawing.Size(90, 27)
        Me.ButtonObfuscate.TabIndex = 6
        Me.ButtonObfuscate.Text = "Obfuscar"
        Me.ButtonObfuscate.UseVisualStyleBackColor = False
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.PanelFooter.Controls.Add(Me.LabelYear)
        Me.PanelFooter.Controls.Add(Me.LabelLicense)
        Me.PanelFooter.Controls.Add(Me.LabelCreator)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 361)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(371, 40)
        Me.PanelFooter.TabIndex = 7
        '
        'LabelLicense
        '
        Me.LabelLicense.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.LabelLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelLicense.Location = New System.Drawing.Point(11, 7)
        Me.LabelLicense.Name = "LabelLicense"
        Me.LabelLicense.Size = New System.Drawing.Size(148, 12)
        Me.LabelLicense.TabIndex = 22
        Me.LabelLicense.Text = "Apache License 2.0"
        Me.LabelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCreator
        '
        Me.LabelCreator.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.LabelCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelCreator.Location = New System.Drawing.Point(12, 20)
        Me.LabelCreator.Name = "LabelCreator"
        Me.LabelCreator.Size = New System.Drawing.Size(148, 12)
        Me.LabelCreator.TabIndex = 21
        Me.LabelCreator.Text = "Desarrollado por Yosu Sanz Iriarte"
        Me.LabelCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxLinkedin
        '
        Me.PictureBoxLinkedin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLinkedin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxLinkedin.Image = Global.Obfuscator_JS.My.Resources.Resources.linkedin
        Me.PictureBoxLinkedin.Location = New System.Drawing.Point(282, 328)
        Me.PictureBoxLinkedin.Name = "PictureBoxLinkedin"
        Me.PictureBoxLinkedin.Size = New System.Drawing.Size(77, 18)
        Me.PictureBoxLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLinkedin.TabIndex = 8
        Me.PictureBoxLinkedin.TabStop = False
        '
        'PictureBoxOutputFolder
        '
        Me.PictureBoxOutputFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxOutputFolder.Image = Global.Obfuscator_JS.My.Resources.Resources.icon_folder
        Me.PictureBoxOutputFolder.Location = New System.Drawing.Point(302, 144)
        Me.PictureBoxOutputFolder.Name = "PictureBoxOutputFolder"
        Me.PictureBoxOutputFolder.Size = New System.Drawing.Size(23, 20)
        Me.PictureBoxOutputFolder.TabIndex = 5
        Me.PictureBoxOutputFolder.TabStop = False
        '
        'PictureBoxInputFolder
        '
        Me.PictureBoxInputFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxInputFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxInputFolder.Image = Global.Obfuscator_JS.My.Resources.Resources.icon_folder
        Me.PictureBoxInputFolder.Location = New System.Drawing.Point(302, 100)
        Me.PictureBoxInputFolder.Name = "PictureBoxInputFolder"
        Me.PictureBoxInputFolder.Size = New System.Drawing.Size(23, 20)
        Me.PictureBoxInputFolder.TabIndex = 2
        Me.PictureBoxInputFolder.TabStop = False
        '
        'LabelFollowMeOn
        '
        Me.LabelFollowMeOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFollowMeOn.AutoSize = True
        Me.LabelFollowMeOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFollowMeOn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.LabelFollowMeOn.Location = New System.Drawing.Point(298, 315)
        Me.LabelFollowMeOn.Name = "LabelFollowMeOn"
        Me.LabelFollowMeOn.Size = New System.Drawing.Size(63, 12)
        Me.LabelFollowMeOn.TabIndex = 9
        Me.LabelFollowMeOn.Text = "Sígueme en"
        '
        'LabelYear
        '
        Me.LabelYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelYear.Location = New System.Drawing.Point(317, 20)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(44, 12)
        Me.LabelYear.TabIndex = 23
        Me.LabelYear.Text = "© 2025"
        Me.LabelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSetDirectories
        '
        Me.LabelSetDirectories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSetDirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSetDirectories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.LabelSetDirectories.Location = New System.Drawing.Point(0, 43)
        Me.LabelSetDirectories.Name = "LabelSetDirectories"
        Me.LabelSetDirectories.Size = New System.Drawing.Size(371, 25)
        Me.LabelSetDirectories.TabIndex = 10
        Me.LabelSetDirectories.Text = "Indica los directorios"
        Me.LabelSetDirectories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progressBar
        '
        Me.progressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.progressBar.Location = New System.Drawing.Point(49, 264)
        Me.progressBar.Maximum = 4
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(272, 18)
        Me.progressBar.Step = 1
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 22
        Me.progressBar.Visible = False
        '
        'LabelProgressStatus
        '
        Me.LabelProgressStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelProgressStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.LabelProgressStatus.Location = New System.Drawing.Point(0, 248)
        Me.LabelProgressStatus.Name = "LabelProgressStatus"
        Me.LabelProgressStatus.Size = New System.Drawing.Size(371, 13)
        Me.LabelProgressStatus.TabIndex = 23
        Me.LabelProgressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelProgressStatus.Visible = False
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 401)
        Me.Controls.Add(Me.LabelProgressStatus)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.LabelSetDirectories)
        Me.Controls.Add(Me.LabelFollowMeOn)
        Me.Controls.Add(Me.PictureBoxLinkedin)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.ButtonObfuscate)
        Me.Controls.Add(Me.PictureBoxOutputFolder)
        Me.Controls.Add(Me.TextBoxOutputFolder)
        Me.Controls.Add(Me.LabelOutputFolder)
        Me.Controls.Add(Me.PictureBoxInputFolder)
        Me.Controls.Add(Me.TextBoxInputFolder)
        Me.Controls.Add(Me.LabelInputFolder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(387, 440)
        Me.MinimumSize = New System.Drawing.Size(387, 440)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelFooter.ResumeLayout(False)
        CType(Me.PictureBoxLinkedin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutputFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxInputFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInputFolder As Label
    Friend WithEvents TextBoxInputFolder As TextBox
    Friend WithEvents PictureBoxInputFolder As PictureBox
    Friend WithEvents PictureBoxOutputFolder As PictureBox
    Friend WithEvents TextBoxOutputFolder As TextBox
    Friend WithEvents LabelOutputFolder As Label
    Friend WithEvents ButtonObfuscate As Button
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents LabelLicense As Label
    Friend WithEvents LabelCreator As Label
    Friend WithEvents PictureBoxLinkedin As PictureBox
    Friend WithEvents LabelFollowMeOn As Label
    Friend WithEvents LabelYear As Label
    Friend WithEvents LabelSetDirectories As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents LabelProgressStatus As Label
End Class
