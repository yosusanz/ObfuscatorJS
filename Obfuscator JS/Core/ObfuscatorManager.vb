Imports System.IO
Public Class ObfuscatorManager
    Public Shared Function createScriptFileIfMissing() As Boolean
        Dim obfuscateFilePath = Path.Combine(APP_DIRECTORY, "obfuscate.js")

        If Not File.Exists(obfuscateFilePath) Then File.WriteAllText(obfuscateFilePath, JS_OBFUSCATOR)

        Return System.IO.File.Exists(obfuscateFilePath)
    End Function

    Public Shared Sub RunObfuscation(inputFile As String, outputFile As String)
        Dim nodeProcess As New ProcessStartInfo With {
            .FileName = Path.Combine(APP_DIRECTORY, "node", "node.exe"),
            .Arguments = $"""{Path.Combine(APP_DIRECTORY, "obfuscate.js")}"" ""{inputFile}"" ""{outputFile}""",
            .WorkingDirectory = APP_DIRECTORY,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        Using p As Process = Process.Start(nodeProcess)
            p.WaitForExit()
        End Using
    End Sub

    Public Shared Sub ObfuscateAllJsFiles(inputRoot As String, outputRoot As String, inputFiles As String(), progress As IProgress(Of Integer))
        Dim done = 0

        For Each inputFile In inputFiles
            Dim relativePath = inputFile.Substring(inputRoot.Length).TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
            Dim outputFile = Path.Combine(outputRoot, relativePath)

            Directory.CreateDirectory(Path.GetDirectoryName(outputFile))
            RunObfuscation(inputFile, outputFile)

            done += 1
            progress.Report(done)
        Next
    End Sub
End Class
