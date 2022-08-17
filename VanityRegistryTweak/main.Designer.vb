<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.topbar = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.minimizeb = New System.Windows.Forms.PictureBox()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.secbuttons = New System.Windows.Forms.Button()
        Me.seclabel = New System.Windows.Forms.Label()
        Me.wvbutton = New System.Windows.Forms.Button()
        Me.wvlabel = New System.Windows.Forms.Label()
        Me.tobutton = New System.Windows.Forms.Button()
        Me.tolabel = New System.Windows.Forms.Label()
        Me.ebutton = New System.Windows.Forms.Button()
        Me.elabel = New System.Windows.Forms.Label()
        Me.topbar.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topbar
        '
        Me.topbar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.topbar.Controls.Add(Me.logo)
        Me.topbar.Controls.Add(Me.minimizeb)
        Me.topbar.Controls.Add(Me.closeb)
        resources.ApplyResources(Me.topbar, "topbar")
        Me.topbar.Name = "topbar"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = Global.VanityRegistryTweak.My.Resources.Resources.vrt
        resources.ApplyResources(Me.logo, "logo")
        Me.logo.Name = "logo"
        Me.logo.TabStop = False
        '
        'minimizeb
        '
        Me.minimizeb.Image = Global.VanityRegistryTweak.My.Resources.Resources.minimize
        resources.ApplyResources(Me.minimizeb, "minimizeb")
        Me.minimizeb.Name = "minimizeb"
        Me.minimizeb.TabStop = False
        '
        'closeb
        '
        Me.closeb.Image = Global.VanityRegistryTweak.My.Resources.Resources.close
        resources.ApplyResources(Me.closeb, "closeb")
        Me.closeb.Name = "closeb"
        Me.closeb.TabStop = False
        '
        'secbuttons
        '
        resources.ApplyResources(Me.secbuttons, "secbuttons")
        Me.secbuttons.Name = "secbuttons"
        Me.secbuttons.UseVisualStyleBackColor = True
        '
        'seclabel
        '
        resources.ApplyResources(Me.seclabel, "seclabel")
        Me.seclabel.Name = "seclabel"
        '
        'wvbutton
        '
        resources.ApplyResources(Me.wvbutton, "wvbutton")
        Me.wvbutton.Name = "wvbutton"
        Me.wvbutton.UseVisualStyleBackColor = True
        '
        'wvlabel
        '
        resources.ApplyResources(Me.wvlabel, "wvlabel")
        Me.wvlabel.Name = "wvlabel"
        '
        'tobutton
        '
        resources.ApplyResources(Me.tobutton, "tobutton")
        Me.tobutton.Name = "tobutton"
        Me.tobutton.UseVisualStyleBackColor = True
        '
        'tolabel
        '
        resources.ApplyResources(Me.tolabel, "tolabel")
        Me.tolabel.Name = "tolabel"
        '
        'ebutton
        '
        resources.ApplyResources(Me.ebutton, "ebutton")
        Me.ebutton.Name = "ebutton"
        Me.ebutton.UseVisualStyleBackColor = True
        '
        'elabel
        '
        resources.ApplyResources(Me.elabel, "elabel")
        Me.elabel.Name = "elabel"
        '
        'main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.elabel)
        Me.Controls.Add(Me.ebutton)
        Me.Controls.Add(Me.tolabel)
        Me.Controls.Add(Me.tobutton)
        Me.Controls.Add(Me.wvlabel)
        Me.Controls.Add(Me.wvbutton)
        Me.Controls.Add(Me.seclabel)
        Me.Controls.Add(Me.secbuttons)
        Me.Controls.Add(Me.topbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.topbar.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents topbar As Panel
    Friend WithEvents closeb As PictureBox
    Friend WithEvents minimizeb As PictureBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents secbuttons As Button
    Friend WithEvents seclabel As Label
    Friend WithEvents wvbutton As Button
    Friend WithEvents wvlabel As Label
    Friend WithEvents tobutton As Button
    Friend WithEvents tolabel As Label
    Friend WithEvents ebutton As Button
    Friend WithEvents elabel As Label
End Class
