Imports System.Web.Script.Serialization

Public Class frmMain
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowseStarbound.Click, btnBrowseMod.Click
        Dim tempName As String = sender.Name
        Dim dlgBrowseResult As DialogResult = dlgBrowseFolder.ShowDialog
        If dlgBrowseResult = Windows.Forms.DialogResult.OK Then
            Select Case tempName
                Case "btnBrowseStarbound"
                    txtStarboundPath.Text = dlgBrowseFolder.SelectedPath
                Case "btnBrowseMod"
                    txtModPath.Text = dlgBrowseFolder.SelectedPath
            End Select
        End If
    End Sub

    Private Sub txt_DragEnter(sender As Object, e As DragEventArgs) Handles txtModPath.DragEnter, txtStarboundPath.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub txt_DragDrop(sender As Object, e As DragEventArgs) Handles txtModPath.DragDrop, txtStarboundPath.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            MyFiles = e.Data.GetData(DataFormats.FileDrop)

            Dim fileInfo As New IO.FileInfo(MyFiles(0))
            If fileInfo.Attributes = IO.FileAttributes.Directory Then
                sender.Text = MyFiles(0)
                If sender.Name = "txtModPath" Then
                    Dim dirInfoModPath As New IO.DirectoryInfo(txtModPath.Text)
                    Dim modInfoFiles As IO.FileInfo() = dirInfoModPath.GetFiles("*.modinfo")
                    TextBox1.Text = System.IO.File.ReadAllText(modInfoFiles(0).FullName)
                    If chkAutoPack.Checked = True Then
                        packMod()
                    End If
                End If
            Else
                MsgBox("You need to specify a directory, not a file!")
            End If

        End If
    End Sub





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        packMod()
    End Sub

    Private Sub packMod()
        Dim dirInfoStarboundPath As New IO.DirectoryInfo(txtStarboundPath.Text)
        Dim dirInfoModPath As New IO.DirectoryInfo(txtModPath.Text)
        Dim assetPackerInfo As New IO.FileInfo(dirInfoStarboundPath.FullName & "\win32\asset_packer.exe")

        If dirInfoStarboundPath.Exists Then
            If assetPackerInfo.Exists Then
                If dirInfoModPath.Exists Then
                    Dim modInfoFiles As IO.FileInfo() = dirInfoModPath.GetFiles("*.modinfo")
                    For Each file In modInfoFiles
                        If file.Name <> "pak.modinfo" Then
                            file.CopyTo(file.Directory.FullName & "\pak.modinfo", True)
                        End If
                    Next

                    Dim json As New JavaScriptSerializer
                    Dim jsonData As jsonRootObject = json.Deserialize(Of jsonRootObject)(TextBox1.Text)
                    jsonData = jsonData

                    Dim processExe As String = dirInfoStarboundPath.FullName & "\win32\asset_packer.exe"
                    Dim processArgs As String

                    If Not jsonData.metadata Is Nothing AndAlso Not jsonData.metadata.version Is Nothing Then
                        processArgs = Chr(34) & jsonData.name & " " & jsonData.metadata.version & Chr(34) & " " & _
                                  Chr(34) & dirInfoModPath.FullName & Chr(34) & " " & _
                                  Chr(34) & dirInfoModPath.Parent.FullName & "\" & jsonData.name & ".modpak" & Chr(34)
                    Else
                        processArgs = Chr(34) & jsonData.name & Chr(34) & " " & _
                                  Chr(34) & dirInfoModPath.FullName & Chr(34) & " " & _
                                  Chr(34) & dirInfoModPath.Parent.FullName & "\" & jsonData.name & ".modpak" & Chr(34)

                    End If
                    
                    Dim tempString As String

                    Dim packProcess As New Process()
                    packProcess.StartInfo.FileName = processExe
                    packProcess.StartInfo.Arguments = processArgs
                    packProcess.StartInfo.UseShellExecute = False
                    packProcess.StartInfo.RedirectStandardOutput = True

                    packProcess.Start()
                    TextBox1.Text = packProcess.StandardOutput.ReadToEnd()

                    packProcess.WaitForExit()
                    'packProcess.Start(processExe, processArgs)

                Else
                    MsgBox("Invalid Mod Path Specified!")
                End If
            Else
                MsgBox("Asset_packer.exe not found, check your Starbound Path!")
            End If
        Else
            MsgBox("Invalid Starbound Path Specified!")
        End If

    End Sub


    Private Sub btnJson_Click(sender As Object, e As EventArgs) Handles btnJson.Click
        Dim dirInfo As New IO.DirectoryInfo(txtModPath.Text)
        Dim modInfoFiles As IO.FileInfo() = dirInfo.GetFiles("*.modinfo")
        TextBox1.Text = System.IO.File.ReadAllText(modInfoFiles(0).FullName)
    End Sub
End Class


