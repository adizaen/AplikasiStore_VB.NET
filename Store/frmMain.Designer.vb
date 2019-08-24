<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtemployeeid = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.PromoToolStripMenuItem, Me.ProductToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'PromoToolStripMenuItem
        '
        Me.PromoToolStripMenuItem.Name = "PromoToolStripMenuItem"
        Me.PromoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PromoToolStripMenuItem.Text = "Promo"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem2})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'TransactionToolStripMenuItem2
        '
        Me.TransactionToolStripMenuItem2.Name = "TransactionToolStripMenuItem2"
        Me.TransactionToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.TransactionToolStripMenuItem2.Text = "Transaction"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem1, Me.SummaryToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TransactionToolStripMenuItem1
        '
        Me.TransactionToolStripMenuItem1.Name = "TransactionToolStripMenuItem1"
        Me.TransactionToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.TransactionToolStripMenuItem1.Text = "Transaction"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbltime.Location = New System.Drawing.Point(1087, 5)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(56, 16)
        Me.lbltime.TabIndex = 5
        Me.lbltime.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(855, 5)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(69, 16)
        Me.lblname.TabIndex = 7
        Me.lblname.Text = "Welcome,"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(925, 5)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(34, 16)
        Me.lbluser.TabIndex = 9
        Me.lbluser.Text = "user"
        '
        'txtemployeeid
        '
        Me.txtemployeeid.Location = New System.Drawing.Point(495, 2)
        Me.txtemployeeid.Name = "txtemployeeid"
        Me.txtemployeeid.Size = New System.Drawing.Size(100, 22)
        Me.txtemployeeid.TabIndex = 11
        Me.txtemployeeid.Visible = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(601, 3)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 22)
        Me.txtpassword.TabIndex = 12
        Me.txtpassword.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtemployeeid)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblname As Label
    Friend WithEvents TransactionToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbluser As Label
    Friend WithEvents txtemployeeid As TextBox
    Friend WithEvents txtpassword As TextBox
End Class
