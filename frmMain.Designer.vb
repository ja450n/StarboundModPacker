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
        Me.txtModinfo = New System.Windows.Forms.TextBox()
        Me.btnJson = New System.Windows.Forms.Button()
        Me.chkAutoPack = New System.Windows.Forms.CheckBox()
        Me.txtStarboundPath = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grpUnpack = New System.Windows.Forms.GroupBox()
        Me.pnlDropUnpack = New System.Windows.Forms.Panel()
        Me.procUnpack = New System.Diagnostics.Process()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpUnpack.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowseStarbound
        '
        Me.btnBrowseStarbound.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseStarbound.Location = New System.Drawing.Point(542, 27)
        Me.btnBrowseStarbound.Name = "btnBrowseStarbound"
        Me.btnBrowseStarbound.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseStarbound.TabIndex = 0
        Me.btnBrowseStarbound.Text = "..."
        Me.btnBrowseStarbound.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(189, 191)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Pack"
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
        Me.Label2.Location = New System.Drawing.Point(6, 16)
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
        Me.txtModPath.Location = New System.Drawing.Point(9, 32)
        Me.txtModPath.Name = "txtModPath"
        Me.txtModPath.Size = New System.Drawing.Size(219, 20)
        Me.txtModPath.TabIndex = 5
        '
        'btnBrowseMod
        '
        Me.btnBrowseMod.AllowDrop = True
        Me.btnBrowseMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseMod.Location = New System.Drawing.Point(234, 30)
        Me.btnBrowseMod.Name = "btnBrowseMod"
        Me.btnBrowseMod.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseMod.TabIndex = 4
        Me.btnBrowseMod.Text = "..."
        Me.btnBrowseMod.UseVisualStyleBackColor = True
        '
        'txtModinfo
        '
        Me.txtModinfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModinfo.Location = New System.Drawing.Point(9, 58)
        Me.txtModinfo.Multiline = True
        Me.txtModinfo.Name = "txtModinfo"
        Me.txtModinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtModinfo.Size = New System.Drawing.Size(255, 127)
        Me.txtModinfo.TabIndex = 7
        '
        'btnJson
        '
        Me.btnJson.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnJson.Location = New System.Drawing.Point(6, 189)
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
        Me.chkAutoPack.Location = New System.Drawing.Point(135, 195)
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
        Me.txtStarboundPath.Size = New System.Drawing.Size(524, 20)
        Me.txtStarboundPath.TabIndex = 1
        Me.txtStarboundPath.Text = Global.StarboundModPacker.My.MySettings.Default.StarboundPath
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnJson)
        Me.GroupBox1.Controls.Add(Me.chkAutoPack)
        Me.GroupBox1.Controls.Add(Me.txtModPath)
        Me.GroupBox1.Controls.Add(Me.btnBrowseMod)
        Me.GroupBox1.Controls.Add(Me.txtModinfo)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 220)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pack"
        '
        'txtStatus
        '
        Me.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStatus.Location = New System.Drawing.Point(3, 16)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStatus.Size = New System.Drawing.Size(554, 116)
        Me.txtStatus.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 135)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'grpUnpack
        '
        Me.grpUnpack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUnpack.Controls.Add(Me.pnlDropUnpack)
        Me.grpUnpack.Location = New System.Drawing.Point(289, 56)
        Me.grpUnpack.Name = "grpUnpack"
        Me.grpUnpack.Size = New System.Drawing.Size(280, 220)
        Me.grpUnpack.TabIndex = 13
        Me.grpUnpack.TabStop = False
        Me.grpUnpack.Text = "Unpack"
        '
        'pnlDropUnpack
        '
        Me.pnlDropUnpack.AllowDrop = True
        Me.pnlDropUnpack.BackgroundImage = Global.StarboundModPacker.My.Resources.Resources.landing_package
        Me.pnlDropUnpack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlDropUnpack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDropUnpack.Location = New System.Drawing.Point(3, 16)
        Me.pnlDropUnpack.Name = "pnlDropUnpack"
        Me.pnlDropUnpack.Size = New System.Drawing.Size(274, 201)
        Me.pnlDropUnpack.TabIndex = 0
        '
        'procUnpack
        '
        Me.procUnpack.StartInfo.Domain = ""
        Me.procUnpack.StartInfo.LoadUserProfile = False
        Me.procUnpack.StartInfo.Password = Nothing
        Me.procUnpack.StartInfo.StandardErrorEncoding = Nothing
        Me.procUnpack.StartInfo.StandardOutputEncoding = Nothing
        Me.procUnpack.StartInfo.UserName = ""
        Me.procUnpack.SynchronizingObject = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(550, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpUnpack)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStarboundPath)
        Me.Controls.Add(Me.btnBrowseStarbound)
        Me.Name = "frmMain"
        Me.Text = "Starbound ModPacker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpUnpack.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents txtModinfo As System.Windows.Forms.TextBox
    Friend WithEvents btnJson As System.Windows.Forms.Button
    Friend WithEvents chkAutoPack As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpUnpack As System.Windows.Forms.GroupBox
    Friend WithEvents pnlDropUnpack As System.Windows.Forms.Panel
    Friend WithEvents procUnpack As System.Diagnostics.Process
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar

End Class
