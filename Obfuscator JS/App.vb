Public Class App
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"{APP_NAME} - v.{APP_VERSION}"
    End Sub

    Private Sub PictureBoxLinkedin_Click(sender As Object, e As EventArgs) Handles PictureBoxLinkedin.Click
        Process.Start(New ProcessStartInfo With {
            .FileName = "https://www.linkedin.com/in/yosusanz/",
            .UseShellExecute = True
        })
    End Sub

    Private Async Sub ButtonObfuscate_Click(sender As Object, e As EventArgs) Handles ButtonObfuscate.Click
        If String.IsNullOrWhiteSpace(TextBoxInputFolder.Text) OrElse String.IsNullOrWhiteSpace(TextBoxOutputFolder.Text) Then
            MsgBox("Debes indicar los directorios de trabajo", MsgBoxStyle.Information, APP_NAME)

            Exit Sub
        End If
        If String.Equals(TextBoxInputFolder.Text, TextBoxOutputFolder.Text) Then
            MsgBox("Los directorios de entrada y salida no pueden ser el mismo", MsgBoxStyle.Information, APP_NAME)

            Exit Sub
        End If

        Dim inputFiles = System.IO.Directory.GetFiles(TextBoxInputFolder.Text, "*.js", System.IO.SearchOption.AllDirectories)

        progressBar.Value = 0
        progressBar.Maximum = inputFiles.Length

        Dim progress = New Progress(Of Integer)(
            Sub(value)
                progressBar.Value = value
                LabelProgressStatus.Text = $"Completado {value}/{inputFiles.Length}"
            End Sub)

        setIsObfuscating(True)

        Try
            Await Task.Run(Sub()
                               ObfuscatorManager.ObfuscateAllJsFiles(TextBoxInputFolder.Text, TextBoxOutputFolder.Text, inputFiles, progress)
                           End Sub)
            MsgBox("Obfuscación completada", MsgBoxStyle.Information, APP_NAME)

            Process.Start("explorer.exe", TextBoxOutputFolder.Text)
        Catch ex As Exception
            MsgBox("Error durante la ofuscación: " & ex.Message, MsgBoxStyle.Critical, APP_NAME)
        End Try

        setIsObfuscating(False)
        clearFolderTexts()
    End Sub

    Private Sub PictureBoxInputFolder_Click(sender As Object, e As EventArgs) Handles PictureBoxInputFolder.Click
        Using dialog As New FolderBrowserDialog
            dialog.Description = "Selecciona una carpeta de entrada"
            dialog.RootFolder = Environment.SpecialFolder.MyComputer

            If dialog.ShowDialog() = DialogResult.OK Then
                TextBoxInputFolder.Text = dialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub PictureBoxOutputFolder_Click(sender As Object, e As EventArgs) Handles PictureBoxOutputFolder.Click
        Using dialog As New FolderBrowserDialog
            dialog.Description = "Selecciona una carpeta de salida"
            dialog.RootFolder = Environment.SpecialFolder.MyComputer

            If dialog.ShowDialog() = DialogResult.OK Then
                TextBoxOutputFolder.Text = dialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub setIsObfuscating(isOfuscating As Boolean)
        progressBar.Visible = isOfuscating
        LabelProgressStatus.Visible = isOfuscating

        ButtonObfuscate.Enabled = Not isOfuscating
        PictureBoxInputFolder.Enabled = Not isOfuscating
        PictureBoxOutputFolder.Enabled = Not isOfuscating
    End Sub

    Private Sub clearFolderTexts()
        LabelProgressStatus.Text = String.Empty
        TextBoxInputFolder.Text = String.Empty
        TextBoxOutputFolder.Text = String.Empty
    End Sub
End Class
