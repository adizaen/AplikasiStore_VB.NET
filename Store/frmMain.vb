Public Class frmMain
    Private Sub awal()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        ChangePasswordToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransactionToolStripMenuItem.Enabled = False
        ViewToolStripMenuItem.Enabled = False
        lblname.Text = "Welcome, "
        lbluser.Text = "SMK Mart"
        txtemployeeid.Clear()
        txtpassword.Clear()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call awal()
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        frmMember.MdiParent = Me
        frmMember.Show()
    End Sub

    Private Sub PromoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoToolStripMenuItem.Click
        frmPromo.MdiParent = Me
        frmPromo.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Today.ToLongDateString + "            Time : " + TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.MdiParent = Me
        frmChangePassword.Show()
    End Sub

    Private Sub TransactionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem2.Click
        frmTrx.MdiParent = Me
        frmTrx.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        frmProduct.MdiParent = Me
        frmProduct.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        frmEmployee.MdiParent = Me
        frmEmployee.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call awal()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub TransactionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem1.Click
        frmViewTrx.MdiParent = Me
        frmViewTrx.Show()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        frmSummary.MdiParent = Me
        frmSummary.Show()
    End Sub
End Class
