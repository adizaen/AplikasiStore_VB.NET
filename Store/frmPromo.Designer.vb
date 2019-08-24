<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromo
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
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtreward = New System.Windows.Forms.TextBox()
        Me.dtstart = New System.Windows.Forms.DateTimePicker()
        Me.dtend = New System.Windows.Forms.DateTimePicker()
        Me.cmdchoose = New System.Windows.Forms.Button()
        Me.txtpromo = New System.Windows.Forms.ComboBox()
        Me.txtpromoid = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcancel
        '
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.Location = New System.Drawing.Point(734, 453)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 30)
        Me.cmdcancel.TabIndex = 31
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdupdate.Location = New System.Drawing.Point(734, 417)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 30)
        Me.cmdupdate.TabIndex = 30
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsave.Location = New System.Drawing.Point(734, 381)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 30)
        Me.cmdsave.TabIndex = 29
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdinsert.Location = New System.Drawing.Point(734, 345)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(75, 30)
        Me.cmdinsert.TabIndex = 28
        Me.cmdinsert.Text = "Insert"
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(409, 403)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(254, 22)
        Me.txtqty.TabIndex = 25
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(409, 374)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 22)
        Me.txtname.TabIndex = 24
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(409, 345)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(254, 22)
        Me.txtproductid.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Reward"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Promo Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Buy Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Product ID"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(26, 105)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1014, 212)
        Me.dgv.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Manage Promo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(302, 522)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "End Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(302, 493)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Start Date"
        '
        'txtreward
        '
        Me.txtreward.Location = New System.Drawing.Point(409, 461)
        Me.txtreward.Name = "txtreward"
        Me.txtreward.Size = New System.Drawing.Size(254, 22)
        Me.txtreward.TabIndex = 34
        '
        'dtstart
        '
        Me.dtstart.Location = New System.Drawing.Point(409, 488)
        Me.dtstart.Name = "dtstart"
        Me.dtstart.Size = New System.Drawing.Size(254, 22)
        Me.dtstart.TabIndex = 35
        '
        'dtend
        '
        Me.dtend.Location = New System.Drawing.Point(409, 517)
        Me.dtend.Name = "dtend"
        Me.dtend.Size = New System.Drawing.Size(254, 22)
        Me.dtend.TabIndex = 36
        '
        'cmdchoose
        '
        Me.cmdchoose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdchoose.Location = New System.Drawing.Point(669, 345)
        Me.cmdchoose.Name = "cmdchoose"
        Me.cmdchoose.Size = New System.Drawing.Size(43, 22)
        Me.cmdchoose.TabIndex = 37
        Me.cmdchoose.Text = "..."
        Me.cmdchoose.UseVisualStyleBackColor = True
        '
        'txtpromo
        '
        Me.txtpromo.FormattingEnabled = True
        Me.txtpromo.Items.AddRange(New Object() {"FREE", "DISC"})
        Me.txtpromo.Location = New System.Drawing.Point(409, 432)
        Me.txtpromo.Name = "txtpromo"
        Me.txtpromo.Size = New System.Drawing.Size(254, 24)
        Me.txtpromo.TabIndex = 38
        '
        'txtpromoid
        '
        Me.txtpromoid.Location = New System.Drawing.Point(26, 371)
        Me.txtpromoid.Name = "txtpromoid"
        Me.txtpromoid.Size = New System.Drawing.Size(91, 22)
        Me.txtpromoid.TabIndex = 39
        Me.txtpromoid.Text = "txtpromoid"
        Me.txtpromoid.Visible = False
        '
        'frmPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 568)
        Me.Controls.Add(Me.txtpromoid)
        Me.Controls.Add(Me.txtpromo)
        Me.Controls.Add(Me.cmdchoose)
        Me.Controls.Add(Me.dtend)
        Me.Controls.Add(Me.dtstart)
        Me.Controls.Add(Me.txtreward)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdinsert)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtproductid)
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
        Me.Name = "frmPromo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Promo Form"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdcancel As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmdsave As Button
    Friend WithEvents cmdinsert As Button
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtreward As TextBox
    Friend WithEvents dtstart As DateTimePicker
    Friend WithEvents dtend As DateTimePicker
    Friend WithEvents cmdchoose As Button
    Friend WithEvents txtpromo As ComboBox
    Friend WithEvents txtpromoid As TextBox
End Class
