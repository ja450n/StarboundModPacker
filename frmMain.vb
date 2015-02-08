Imports System.Web.Script.Serialization

Public Class frmMain

    Public Delegate Sub delegateUnpack(ByVal starboundPath As String, ByVal modPath As String)
    Public Delegate Sub delegatePack(ByVal starboundPath As String, ByVal modPath As String)
    Public Delegate Sub delegateSetText(ByVal textContent As String)
    Public Delegate Sub delegateSetProgressBarState(ByVal boolState As Boolean)

    Public packBoolean As Boolean = True

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

    Private Sub txt_DragEnter(sender As Object, e As DragEventArgs) Handles txtModPath.DragEnter, txtStarboundPath.DragEnter, pnlDropUnpack.DragEnter
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
                packBoolean = True
                sender.Text = MyFiles(0)
                If sender.Name = "txtModPath" Then
                    Dim dirInfoModPath As New IO.DirectoryInfo(txtModPath.Text)
                    Dim modInfoFiles As IO.FileInfo() = dirInfoModPath.GetFiles("*.modinfo")
                    If modInfoFiles.Length > 0 Then
                        txtModinfo.Text = System.IO.File.ReadAllText(modInfoFiles(0).FullName)
                    Else
                        MsgBox("No .modinfo file found, this is required!")
                        Exit Sub
                    End If
                    If chkAutoPack.Checked = True Then
                        Dim packDelegate As delegatePack = New delegatePack(AddressOf packMod)
                        packDelegate(txtStarboundPath.Text, MyFiles(0))
                    End If
                End If
            Else
                MsgBox("Invalid mod directory specified!")
                Exit Sub
            End If
        End If
    End Sub
    Private Sub pnlDropUnpack_DragDrop(sender As Object, e As DragEventArgs) Handles pnlDropUnpack.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            MyFiles = e.Data.GetData(DataFormats.FileDrop)

            Dim fileInfo As New IO.FileInfo(MyFiles(0))
            If fileInfo.Attributes = IO.FileAttributes.Archive Then
                If fileInfo.Extension = ".modpak" Or fileInfo.Extension = ".pak" Then
                    Dim unpackDelegate As delegateUnpack = New delegateUnpack(AddressOf unpackMod)
                    unpackDelegate(txtStarboundPath.Text, MyFiles(0))
                End If
            End If
        Else
            MsgBox("Invalid File/Path specified!")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim packDelegate As delegatePack = New delegatePack(AddressOf packMod)
        'packDelegate(txtStarboundPath.Text, txtModPath.Text)
        BeginInvoke(New delegatePack(AddressOf packMod), New Object() {txtStarboundPath.Text, txtModPath.Text})
        Return
    End Sub
    Private Sub unpackMod(ByVal starboundPath As String, ByVal modPath As String)
        Dim dirInfoStarboundPath As New IO.DirectoryInfo(starboundPath)
        Dim dirInfoModPath As New IO.FileInfo(modPath)
        Dim assetUnpackerInfo As New IO.FileInfo(dirInfoStarboundPath.FullName & "\win32\asset_unpacker.exe")
        Dim setTextDelegate As delegateSetText = New delegateSetText(AddressOf setText)
        Dim setProgressBarVisibleDelegate As delegateSetProgressBarState = New delegateSetProgressBarState(AddressOf setProgressVisible)

        If dirInfoStarboundPath.Exists Then
            If assetUnpackerInfo.Exists Then
                If dirInfoModPath.Exists Then

                    Dim processExe As String = dirInfoStarboundPath.FullName & "\win32\asset_unpacker.exe"
                    Dim processArgs As String = Chr(34) & dirInfoModPath.FullName & Chr(34) & " " & _
                        Chr(34) & dirInfoModPath.FullName.Remove(dirInfoModPath.FullName.Length - dirInfoModPath.Extension.Length, dirInfoModPath.Extension.Length) & Chr(34)

                    Dim unpackProcess As New Process()
                    unpackProcess.StartInfo.FileName = processExe
                    unpackProcess.StartInfo.Arguments = processArgs
                    unpackProcess.StartInfo.UseShellExecute = False
                    unpackProcess.StartInfo.RedirectStandardOutput = True
                    unpackProcess.EnableRaisingEvents = True

                    Me.Invoke(setProgressBarVisibleDelegate, New Object() {True})

                    unpackProcess.Start()
                    Application.DoEvents()
                    Dim unpackProcessStdOut As String
                    unpackProcessStdOut = unpackProcess.StandardOutput.ReadToEnd()

                    Me.Invoke(setTextDelegate, New Object() {unpackProcessStdOut})

                    While unpackProcess.HasExited = False
                        Application.DoEvents()
                    End While
                    'unpackProcess.WaitForExit()
                Else
                    MsgBox("Invalid Mod Path Specified!")
                End If
            Else
                MsgBox("Asset_unpacker.exe not found, check your Starbound Path!")
            End If
        Else
            MsgBox("Invalid Starbound Path Specified!")
        End If

        Me.Invoke(setProgressBarVisibleDelegate, New Object() {False})
        Application.DoEvents()

    End Sub

    Private Sub packMod(ByVal starboundPath As String, ByVal modPath As String)
        Dim dirInfoStarboundPath As New IO.DirectoryInfo(starboundPath)
        Dim dirInfoModPath As New IO.DirectoryInfo(modPath)
        Dim assetPackerInfo As New IO.FileInfo(dirInfoStarboundPath.FullName & "\win32\asset_packer.exe")

        Dim setTextDelegate As delegateSetText = New delegateSetText(AddressOf setText)
        Dim setProgressBarVisibleDelegate As delegateSetProgressBarState = New delegateSetProgressBarState(AddressOf setProgressVisible)

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
                    Dim jsonData As jsonRootObject = json.Deserialize(Of jsonRootObject)(txtModinfo.Text)
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

                    Dim packProcess As New Process()
                    packProcess.StartInfo.FileName = processExe
                    packProcess.StartInfo.Arguments = processArgs
                    packProcess.StartInfo.UseShellExecute = False
                    packProcess.StartInfo.RedirectStandardOutput = True
                    packProcess.EnableRaisingEvents = True

                    Me.Invoke(setProgressBarVisibleDelegate, New Object() {True})

                    packProcess.Start()

                    Dim packProcessStdOut As String
                    packProcessStdOut = packProcess.StandardOutput.ReadToEnd()

                    packProcess.WaitForExit()
                    
                    Me.Invoke(setTextDelegate, New Object() {packProcessStdOut})

                Else
                    MsgBox("Invalid Mod Path Specified!")
                End If
            Else
                MsgBox("Asset_packer.exe not found, check your Starbound Path!")
            End If
        Else
            MsgBox("Invalid Starbound Path Specified!")
        End If

        Me.Invoke(setProgressBarVisibleDelegate, New Object() {False})
        Application.DoEvents()

    End Sub


    Private Sub txtBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModinfo.KeyPress, txtStatus.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub btnJson_Click(sender As Object, e As EventArgs) Handles btnJson.Click
        Dim dirInfo As New IO.DirectoryInfo(txtModPath.Text)
        Dim modInfoFiles As IO.FileInfo() = dirInfo.GetFiles("*.modinfo")
        txtModinfo.Text = System.IO.File.ReadAllText(modInfoFiles(0).FullName)
    End Sub

    Private Sub setText(ByVal textContent As String)
        'If clearFirst = True Then : Me.txtStatus.Clear() : End If
        'Me.txtStatus.AppendText(textToAppend & vbCrLf)
        Me.txtStatus.Text = textContent
    End Sub
    Private Sub setProgressVisible(ByVal boolState As Boolean)
        Me.ToolStripProgressBar1.Visible = boolState
    End Sub

End Class


