<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtemployeeid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txthandphone = New System.Windows.Forms.TextBox()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.cbposition = New System.Windows.Forms.ComboBox()
        Me.cmdremove = New System.Windows.Forms.Button()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Manage Employee"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(32, 116)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(961, 224)
        Me.dgv.TabIndex = 3
        '
        'cmdcancel
        '
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.Location = New System.Drawing.Point(666, 500)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 30)
        Me.cmdcancel.TabIndex = 29
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdupdate.Location = New System.Drawing.Point(666, 428)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 30)
        Me.cmdupdate.TabIndex = 28
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsave.Location = New System.Drawing.Point(666, 392)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 30)
        Me.cmdsave.TabIndex = 27
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdinsert.Location = New System.Drawing.Point(666, 356)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(75, 30)
        Me.cmdinsert.TabIndex = 26
        Me.cmdinsert.Text = "Insert"
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(392, 443)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(254, 22)
        Me.txtemail.TabIndex = 24
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(392, 385)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 22)
        Me.txtname.TabIndex = 22
        '
        'txtemployeeid
        '
        Me.txtemployeeid.Location = New System.Drawing.Point(392, 356)
        Me.txtemployeeid.Name = "txtemployeeid"
        Me.txtemployeeid.Size = New System.Drawing.Size(254, 22)
        Me.txtemployeeid.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Employee ID"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(392, 472)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(254, 22)
        Me.txtpassword.TabIndex = 30
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 565)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Birth Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 536)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Handphone"
        '
        'txthandphone
        '
        Me.txthandphone.Location = New System.Drawing.Point(392, 533)
        Me.txthandphone.Name = "txthandphone"
        Me.txthandphone.Size = New System.Drawing.Size(254, 22)
        Me.txthandphone.TabIndex = 33
        '
        'dtbirth
        '
        Me.dtbirth.Location = New System.Drawing.Point(392, 561)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(254, 22)
        Me.dtbirth.TabIndex = 34
        '
        'cbposition
        '
        Me.cbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbposition.FormattingEnabled = True
        Me.cbposition.Items.AddRange(New Object() {"Kasir", "Admin"})
        Me.cbposition.Location = New System.Drawing.Point(392, 414)
        Me.cbposition.Name = "cbposition"
        Me.cbposition.Size = New System.Drawing.Size(254, 24)
        Me.cbposition.TabIndex = 35
        '
        'cmdremove
        '
        Me.cmdremove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdremove.Location = New System.Drawing.Point(666, 464)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(75, 30)
        Me.cmdremove.TabIndex = 36
        Me.cmdremove.Text = "Remove"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(392, 504)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(254, 22)
        Me.txtconfirm.TabIndex = 37
        Me.txtconfirm.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 507)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Confirm Password"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 596)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.cmdremove)
        Me.Controls.Add(Me.cbposition)
        Me.Controls.Add(Me.dtbirth)
        Me.Controls.Add(Me.txthandphone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdinsert)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtemployeeid)
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
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Employee"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmdcancel As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmdinsert As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemployeeid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txthandphone As TextBox
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents cbposition As ComboBox
    Friend WithEvents cmdremove As Button
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents Label9 As Label
End Class
