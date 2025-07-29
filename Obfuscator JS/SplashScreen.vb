Public Class SplashScreen

    Delegate Sub delegateRefreshUI(message As String, value As UShort)
    Delegate Sub delegateLoadForm(formName As String)


    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelVersion.Text = APP_VERSION.ToString
        progressBar.Value = 0
    End Sub

    Private Async Sub SplashScreen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Await loadApplication()
    End Sub

    Private Async Function loadApplication() As Task
        refreshUI("Comprobando node", 1)
        Await Task.Delay(100)

        If NodeInstallerService.EnsureNodeInstalled() Then
            refreshUI("Verificando javascript-obfuscator", 2)
            Await Task.Delay(100)

            If PackageManager.EnsurePackageInstalled("javascript-obfuscator") Then
                refreshUI("Examinando archivos de ofuscación", 3)
                Await Task.Delay(100)

                If ObfuscatorManager.createScriptFileIfMissing() Then
                    refreshUI("Todo correcto", 4)
                    Await Task.Delay(100)

                    loadApp()
                    Exit Function
                End If
            End If
        End If

        MsgBox("ERROR cargando la aplicación", MsgBoxStyle.Critical, APP_NAME)
        Application.Exit()
    End Function


    Private Sub refreshUI(message As String, value As UShort)
        If progressStatus.InvokeRequired Then
            progressStatus.Invoke(New delegateRefreshUI(AddressOf refreshUI), message, value)
        Else
            progressBar.Value = value
            progressStatus.Text = message
        End If
    End Sub
    Private Sub loadApp()
        If progressStatus.InvokeRequired Then
            progressStatus.Invoke(New delegateLoadForm(AddressOf loadApp))
        Else
            progressStatus.Text = "Cargando aplicación"
            App.Show()

            Me.Close()
        End If
    End Sub
End Class