Imports System.IO
Public Class NodeInstallerService
    Public Shared Function EnsureNodeInstalled() As Boolean
        Dim nodeDir = System.IO.Path.Combine(APP_DIRECTORY, "node")
        If Directory.Exists(nodeDir) And File.Exists(Path.Combine(nodeDir, "npm-portable.bat")) Then Return True

        Try
            Dim tempDir = Path.Combine(APP_DIRECTORY, "temp")
            Dim zipPath = Path.Combine(tempDir, "node.zip")

            If Not Directory.Exists(tempDir) Then Directory.CreateDirectory(tempDir)
            If Not File.Exists(zipPath) Then My.Computer.Network.DownloadFile(NODE_PORTABLE_URL, zipPath)

            Compression.ZipFile.ExtractToDirectory(zipPath, APP_DIRECTORY)

            For Each folder In Directory.GetDirectories(APP_DIRECTORY)
                If folder.Contains("node-v20.14.0-win-x64") Then
                    Directory.Move(folder, nodeDir)

                    Exit For
                End If
            Next

            Directory.Delete(tempDir, True)

            File.WriteAllText(Path.Combine(nodeDir, "npm-portable.bat"), NPM_PORTABLE)
        Catch ex As Exception
            Directory.Delete(nodeDir, True)

            Return False
        End Try

        Return True
    End Function
End Class
