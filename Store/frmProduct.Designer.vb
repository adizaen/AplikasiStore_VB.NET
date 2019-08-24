<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.txtbuy = New System.Windows.Forms.TextBox()
        Me.txtspecification = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsell = New System.Windows.Forms.TextBox()
        Me.cmdremove = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Product"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(35, 110)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(785, 247)
        Me.dgv.TabIndex = 2
        '
        'cmdcancel
        '
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.Location = New System.Drawing.Point(589, 529)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 30)
        Me.cmdcancel.TabIndex = 29
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdupdate.Location = New System.Drawing.Point(589, 457)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 30)
        Me.cmdupdate.TabIndex = 28
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsave.Location = New System.Drawing.Point(589, 421)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 30)
        Me.cmdsave.TabIndex = 27
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdinsert.Location = New System.Drawing.Point(589, 385)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(75, 30)
        Me.cmdinsert.TabIndex = 26
        Me.cmdinsert.Text = "Insert"
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'txtbuy
        '
        Me.txtbuy.Location = New System.Drawing.Point(318, 492)
        Me.txtbuy.Name = "txtbuy"
        Me.txtbuy.Size = New System.Drawing.Size(254, 22)
        Me.txtbuy.TabIndex = 24
        '
        'txtspecification
        '
        Me.txtspecification.Location = New System.Drawing.Point(318, 463)
        Me.txtspecification.Name = "txtspecification"
        Me.txtspecification.Size = New System.Drawing.Size(254, 22)
        Me.txtspecification.TabIndex = 23
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(318, 434)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(254, 22)
        Me.txtname.TabIndex = 22
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(318, 405)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(254, 22)
        Me.txtproductid.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 524)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sell Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Buy Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 466)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Specification"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product ID"
        '
        'txtsell
        '
        Me.txtsell.Location = New System.Drawing.Point(318, 521)
        Me.txtsell.Name = "txtsell"
        Me.txtsell.Size = New System.Drawing.Size(254, 22)
        Me.txtsell.TabIndex = 30
        '
        'cmdremove
        '
        Me.cmdremove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdremove.Location = New System.Drawing.Point(589, 493)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(75, 30)
        Me.cmdremove.TabIndex = 31
        Me.cmdremove.Text = "Remove"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 587)
        Me.Controls.Add(Me.cmdremove)
        Me.Controls.Add(Me.txtsell)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdinsert)
        Me.Controls.Add(Me.txtbuy)
        Me.Controls.Add(Me.txtspecification)
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
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Product"
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
    Friend WithEvents txtbuy As TextBox
    Friend WithEvents txtspecification As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsell As TextBox
    Friend WithEvents cmdremove As Button
End Class
