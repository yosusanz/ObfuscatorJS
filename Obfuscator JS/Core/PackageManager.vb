Imports System.IO
Public Class PackageManager
    Public Shared Function EnsurePackageInstalled(packageName As String) As Boolean
        Dim nodeDir = Path.Combine(APP_DIRECTORY, "node")
        Dim packagePath = Path.Combine(nodeDir, "node_modules", packageName)
        If Directory.Exists(packagePath) Then Return True

        Dim npmProcess As New ProcessStartInfo("cmd.exe", "/c npm-portable.bat install " & packageName) With {
            .WorkingDirectory = nodeDir,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True
        }

        Using p As Process = Process.Start(npmProcess)
            p.WaitForExit()
        End Using

        Return Directory.Exists(packagePath)
    End Function
End Class
