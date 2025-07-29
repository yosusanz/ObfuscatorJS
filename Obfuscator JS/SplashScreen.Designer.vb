<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCreator = New System.Windows.Forms.Label()
        Me.LabelLicense = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.progressStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelVersion
        '
        Me.LabelVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(575, 9)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(53, 12)
        Me.LabelVersion.TabIndex = 18
        Me.LabelVersion.Text = "v.1.0.0.0"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCreator
        '
        Me.LabelCreator.BackColor = System.Drawing.Color.Black
        Me.LabelCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCreator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelCreator.Location = New System.Drawing.Point(12, 276)
        Me.LabelCreator.Name = "LabelCreator"
        Me.LabelCreator.Size = New System.Drawing.Size(148, 12)
        Me.LabelCreator.TabIndex = 19
        Me.LabelCreator.Text = "Desarrollado por Yosu Sanz Iriarte"
        Me.LabelCreator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelLicense
        '
        Me.LabelLicense.BackColor = System.Drawing.Color.Black
        Me.LabelLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.LabelLicense.Location = New System.Drawing.Point(11, 263)
        Me.LabelLicense.Name = "LabelLicense"
        Me.LabelLicense.Size = New System.Drawing.Size(148, 12)
        Me.LabelLicense.TabIndex = 20
        Me.LabelLicense.Text = "Apache License 2.0"
        Me.LabelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'progressBar
        '
        Me.progressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.progressBar.Location = New System.Drawing.Point(436, 284)
        Me.progressBar.Maximum = 4
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(192, 4)
        Me.progressBar.Step = 1
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 21
        '
        'progressStatus
        '
        Me.progressStatus.BackColor = System.Drawing.Color.Black
        Me.progressStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressStatus.ForeColor = System.Drawing.Color.White
        Me.progressStatus.Location = New System.Drawing.Point(436, 263)
        Me.progressStatus.Name = "progressStatus"
        Me.progressStatus.Size = New System.Drawing.Size(192, 12)
        Me.progressStatus.TabIndex = 22
        Me.progressStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Obfuscator_JS.My.Resources.Resources.splashscreen
        Me.ClientSize = New System.Drawing.Size(640, 300)
        Me.Controls.Add(Me.progressStatus)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.LabelLicense)
        Me.Controls.Add(Me.LabelCreator)
        Me.Controls.Add(Me.LabelVersion)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelCreator As Label
    Friend WithEvents LabelLicense As Label
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents progressStatus As Label
End Class
