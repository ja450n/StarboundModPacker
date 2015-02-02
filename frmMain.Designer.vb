<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBrowseStarbound = New System.Windows.Forms.Button()
        Me.dlgBrowseFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModPath = New System.Windows.Forms.TextBox()
        Me.btnBrowseMod = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnJson = New System.Windows.Forms.Button()
        Me.chkAutoPack = New System.Windows.Forms.CheckBox()
        Me.txtStarboundPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBrowseStarbound
        '
        Me.btnBrowseStarbound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseStarbound.Location = New System.Drawing.Point(242, 27)
        Me.btnBrowseStarbound.Name = "btnBrowseStarbound"
        Me.btnBrowseStarbound.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseStarbound.TabIndex = 0
        Me.btnBrowseStarbound.Text = "..."
        Me.btnBrowseStarbound.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(197, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Un/Pack"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starbound Path:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mod Path:"
        '
        'txtModPath
        '
        Me.txtModPath.AllowDrop = True
        Me.txtModPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModPath.Location = New System.Drawing.Point(12, 68)
        Me.txtModPath.Name = "txtModPath"
        Me.txtModPath.Size = New System.Drawing.Size(224, 20)
        Me.txtModPath.TabIndex = 5
        '
        'btnBrowseMod
        '
        Me.btnBrowseMod.AllowDrop = True
        Me.btnBrowseMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseMod.Location = New System.Drawing.Point(242, 66)
        Me.btnBrowseMod.Name = "btnBrowseMod"
        Me.btnBrowseMod.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseMod.TabIndex = 4
        Me.btnBrowseMod.Text = "..."
        Me.btnBrowseMod.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(13, 98)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(259, 127)
        Me.TextBox1.TabIndex = 7
        '
        'btnJson
        '
        Me.btnJson.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnJson.Location = New System.Drawing.Point(12, 227)
        Me.btnJson.Name = "btnJson"
        Me.btnJson.Size = New System.Drawing.Size(75, 23)
        Me.btnJson.TabIndex = 8
        Me.btnJson.Text = "JSON"
        Me.btnJson.UseVisualStyleBackColor = True
        Me.btnJson.Visible = False
        '
        'chkAutoPack
        '
        Me.chkAutoPack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoPack.AutoSize = True
        Me.chkAutoPack.Checked = Global.StarboundModPacker.My.MySettings.Default.AutoPack
        Me.chkAutoPack.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.StarboundModPacker.My.MySettings.Default, "AutoPack", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkAutoPack.Location = New System.Drawing.Point(143, 231)
        Me.chkAutoPack.Name = "chkAutoPack"
        Me.chkAutoPack.Size = New System.Drawing.Size(48, 17)
        Me.chkAutoPack.TabIndex = 9
        Me.chkAutoPack.Text = "Auto"
        Me.chkAutoPack.UseVisualStyleBackColor = True
        '
        'txtStarboundPath
        '
        Me.txtStarboundPath.AllowDrop = True
        Me.txtStarboundPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStarboundPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.StarboundModPacker.My.MySettings.Default, "StarboundPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtStarboundPath.Location = New System.Drawing.Point(12, 29)
        Me.txtStarboundPath.Name = "txtStarboundPath"
        Me.txtStarboundPath.Size = New System.Drawing.Size(224, 20)
        Me.txtStarboundPath.TabIndex = 1
        Me.txtStarboundPath.Text = Global.StarboundModPacker.My.MySettings.Default.StarboundPath
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.chkAutoPack)
        Me.Controls.Add(Me.btnJson)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtModPath)
        Me.Controls.Add(Me.btnBrowseMod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStarboundPath)
        Me.Controls.Add(Me.btnBrowseStarbound)
        Me.Name = "frmMain"
        Me.Text = "Starbound ModPacker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowseStarbound As System.Windows.Forms.Button
    Friend WithEvents dlgBrowseFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtStarboundPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseMod As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnJson As System.Windows.Forms.Button
    Friend WithEvents chkAutoPack As System.Windows.Forms.CheckBox

End Class
