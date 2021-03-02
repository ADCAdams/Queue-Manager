Public Class MangerFRM

    Private Sub BartechOrderManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BartechOrderManagerToolStripMenuItem.Click
        BTManager.MdiParent = Me
        BTManager.Show()
    End Sub

    Private Sub FPMOrderManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FPMOrderManagerToolStripMenuItem.Click
        FPMManager.MdiParent = Me
        FPMManager.Show()
    End Sub

    Private Sub IHCOrderManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IHCOrderManagerToolStripMenuItem.Click
        IHCManager.MdiParent = Me
        IHCManager.Show()
    End Sub

    Private Sub MangerFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        ''MsgBox(Environment.MachineName)
        Dim pc As String = Environment.MachineName
        If pc = "FPMDISPLAY" Then
            FPMView.MdiParent = Me
            FPMView.Show()
        End If
        If pc = "BARTECDISPLAY" Then
            BTView.MdiParent = Me
            BTView.Show()
        End If
        If pc = "IHCDISPLAY" Then
            IHCView.MdiParent = Me
            IHCView.Show()
        End If

        Me.Text = "Order Manager  " & "Version " & Application.ProductVersion

    End Sub

    Private Sub ViewFPMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFPMToolStripMenuItem.Click
        FPMView.MdiParent = Me
        FPMView.Show()
    End Sub

    Private Sub ViewIHCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIHCToolStripMenuItem.Click
        IHCView.MdiParent = Me
        IHCView.Show()
    End Sub

    Private Sub ViewBartechToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBartechToolStripMenuItem.Click
        BTView.MdiParent = Me
        BTView.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
