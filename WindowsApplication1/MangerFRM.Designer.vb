<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MangerFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MangerFRM))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BartechOrderMangerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BartechOrderManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FPMOrderManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IHCOrderManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBartechToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewIHCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BartechOrderMangerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1411, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BartechOrderMangerToolStripMenuItem
        '
        Me.BartechOrderMangerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BartechOrderManagerToolStripMenuItem, Me.FPMOrderManagerToolStripMenuItem, Me.IHCOrderManagerToolStripMenuItem, Me.ViewBartechToolStripMenuItem, Me.ViewIHCToolStripMenuItem, Me.ViewFPMToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.BartechOrderMangerToolStripMenuItem.Name = "BartechOrderMangerToolStripMenuItem"
        Me.BartechOrderMangerToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.BartechOrderMangerToolStripMenuItem.Text = "Manager"
        '
        'BartechOrderManagerToolStripMenuItem
        '
        Me.BartechOrderManagerToolStripMenuItem.Name = "BartechOrderManagerToolStripMenuItem"
        Me.BartechOrderManagerToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.BartechOrderManagerToolStripMenuItem.Text = "&Bartech Order Manager"
        '
        'FPMOrderManagerToolStripMenuItem
        '
        Me.FPMOrderManagerToolStripMenuItem.Name = "FPMOrderManagerToolStripMenuItem"
        Me.FPMOrderManagerToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FPMOrderManagerToolStripMenuItem.Text = "&FPM Order Manager"
        '
        'IHCOrderManagerToolStripMenuItem
        '
        Me.IHCOrderManagerToolStripMenuItem.Name = "IHCOrderManagerToolStripMenuItem"
        Me.IHCOrderManagerToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.IHCOrderManagerToolStripMenuItem.Text = "&IHC Order Manager"
        '
        'ViewBartechToolStripMenuItem
        '
        Me.ViewBartechToolStripMenuItem.Name = "ViewBartechToolStripMenuItem"
        Me.ViewBartechToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ViewBartechToolStripMenuItem.Text = "View BT"
        '
        'ViewIHCToolStripMenuItem
        '
        Me.ViewIHCToolStripMenuItem.Name = "ViewIHCToolStripMenuItem"
        Me.ViewIHCToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ViewIHCToolStripMenuItem.Text = "View IHC"
        '
        'ViewFPMToolStripMenuItem
        '
        Me.ViewFPMToolStripMenuItem.Name = "ViewFPMToolStripMenuItem"
        Me.ViewFPMToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ViewFPMToolStripMenuItem.Text = "View FPM"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'MangerFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1411, 1045)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MangerFRM"
        Me.Text = "Queue Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BartechOrderMangerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BartechOrderManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FPMOrderManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IHCOrderManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBartechToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewIHCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFPMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
