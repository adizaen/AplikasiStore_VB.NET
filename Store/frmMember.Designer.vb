<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmemberid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txthp = New System.Windows.Forms.TextBox()
        Me.dtexpired = New System.Windows.Forms.DateTimePicker()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdcancel = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Member"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(26, 88)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1014, 227)
        Me.dgv.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Member ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Expired Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Handphone"
        '
        'txtmemberid
        '
        Me.txtmemberid.Location = New System.Drawing.Point(429, 351)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.Size = New System.Drawing.Size(254, 22)
        Me.txtmemberid.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(429, 380)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 22)
        Me.txtname.TabIndex = 8
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(429, 409)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(254, 22)
        Me.txtemail.TabIndex = 9
        '
        'txthp
        '
        Me.txthp.Location = New System.Drawing.Point(429, 438)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(254, 22)
        Me.txthp.TabIndex = 10
        '
        'dtexpired
        '
        Me.dtexpired.Location = New System.Drawing.Point(429, 468)
        Me.dtexpired.Name = "dtexpired"
        Me.dtexpired.Size = New System.Drawing.Size(254, 22)
        Me.dtexpired.TabIndex = 11
        '
        'cmdinsert
        '
        Me.cmdinsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdinsert.Location = New System.Drawing.Point(703, 351)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(75, 30)
        Me.cmdinsert.TabIndex = 12
        Me.cmdinsert.Text = "Insert"
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsave.Location = New System.Drawing.Point(703, 387)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 30)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdupdate.Location = New System.Drawing.Point(703, 423)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 30)
        Me.cmdupdate.TabIndex = 14
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.Location = New System.Drawing.Point(703, 459)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 30)
        Me.cmdcancel.TabIndex = 15
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 524)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdinsert)
        Me.Controls.Add(Me.dtexpired)
        Me.Controls.Add(Me.txthp)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtmemberid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Member Form"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmemberid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txthp As TextBox
    Friend WithEvents dtexpired As DateTimePicker
    Friend WithEvents cmdinsert As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdcancel As Button
End Class
