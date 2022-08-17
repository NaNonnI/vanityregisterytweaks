Imports Microsoft.Win32
Public Class main

    Dim regKey As RegistryKey

    Private Sub secbutton_Click(sender As Object, e As EventArgs) Handles secbuttons.Click
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
        If seclabel.Text = "Désactivé" Then
            regKey.CreateSubKey("ShowSecondsInSystemClock")
            regKey.SetValue("ShowSecondsInSystemClock", &H1, RegistryValueKind.DWord)
        Else
            regKey.DeleteValue("ShowSecondsInSystemClock")
        End If
        regKey.Close()
        RestartExplorer()
        ReloadKeys()
    End Sub
    Private Sub wvbutton_Click(sender As Object, e As EventArgs) Handles wvbutton.Click
        regKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
        If wvlabel.Text = "Désactivé" Then
            regKey.CreateSubKey("PaintDesktopVersion")
            regKey.SetValue("PaintDesktopVersion", &H1, RegistryValueKind.DWord)
        Else
            regKey.DeleteValue("PaintDesktopVersion")
        End If
        regKey.Close()
        RestartExplorer()
        ReloadKeys()
    End Sub

    Private Sub tobutton_Click(sender As Object, e As EventArgs) Handles tobutton.Click
        regKey = Registry.ClassesRoot.OpenSubKey("\*\shell", True)
        If tolabel.Text = "Désactivé" Then

            Dim command As String = "cmd.exe /c takeown /f \""%1\"" /r /d y && icacls \""%1\"" /grant administrators:F /t"

            regKey.CreateSubKey("runas")
            regKey = Registry.ClassesRoot.OpenSubKey("\*\shell\runas", True)
            regKey.SetValue("", "Take Ownership", RegistryValueKind.String)
            regKey.SetValue("NoWorkingDirectory", "", RegistryValueKind.String)
            regKey.CreateSubKey("command")
            regKey = Registry.ClassesRoot.OpenSubKey("\*\shell\runas\command", True)
            regKey.SetValue("", command, RegistryValueKind.String)
            regKey.SetValue("IsolatedCommand", command, RegistryValueKind.String)

            regKey = Registry.ClassesRoot.OpenSubKey("\Directory\shell", True)
            regKey.CreateSubKey("runas")
            regKey = Registry.ClassesRoot.OpenSubKey("\*\shell\runas", True)
            regKey.SetValue("", "Take Ownership", RegistryValueKind.String)
            regKey.SetValue("NoWorkingDirectory", "", RegistryValueKind.String)
            regKey.CreateSubKey("command")
            regKey = Registry.ClassesRoot.OpenSubKey("\*\shell\runas\command", True)
            regKey.SetValue("", command, RegistryValueKind.String)
            regKey.SetValue("IsolatedCommand", command, RegistryValueKind.String)
        Else
            regKey.DeleteSubKeyTree("runas")
            regKey = Registry.ClassesRoot.OpenSubKey("\Directory\shell", True)
            regKey.DeleteSubKeyTree("runas")
        End If
        regKey.Close()
        RestartExplorer()
        ReloadKeys()
    End Sub

    Private Sub ebutton_Click(sender As Object, e As EventArgs) Handles ebutton.Click
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
        If elabel.Text = "Désactivé" Then
            regKey.CreateSubKey("EncryptionContextMenu")
            regKey.SetValue("EncryptionContextMenu", &H1, RegistryValueKind.DWord)
        Else
            regKey.DeleteValue("EncryptionContextMenu")
        End If
        regKey.Close()
        RestartExplorer()
        ReloadKeys()
    End Sub

    Dim mouse_offset
    Private Sub topbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles topbar.MouseDown
        mouse_offset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub topbar_MouseMove(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles topbar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub closeb_Click(sender As Object, e As EventArgs) Handles closeb.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub minimizeb_Click(sender As Object, e As EventArgs) Handles minimizeb.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RestartExplorer()
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "explorer" Then
                prog.Kill()
            End If
        Next
    End Sub

    Private Sub ReloadKeys()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", Nothing) Is Nothing Then
            seclabel.Text = "Désactivé"
        Else
            seclabel.Text = "Activé"
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", Nothing) Is Nothing Then
            wvlabel.Text = "Désactivé"
        Else
            wvlabel.Text = "Activé"
        End If
        If My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\*\shell\runas", "NoWorkingDirectory", Nothing) Is Nothing Then
            tolabel.Text = "Désactivé"
        Else
            tolabel.Text = "Activé"
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EncryptionContextMenu", Nothing) Is Nothing Then
            elabel.Text = "Désactivé"
        Else
            elabel.Text = "Activé"
        End If
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadKeys()
    End Sub
End Class