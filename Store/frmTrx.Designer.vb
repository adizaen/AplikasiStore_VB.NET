<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrx
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltransactionid = New System.Windows.Forms.Label()
        Me.lblpromo = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.cmdremove = New System.Windows.Forms.Button()
        Me.cmdchoose = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.cmdnext = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbuy = New System.Windows.Forms.TextBox()
        Me.txttype = New System.Windows.Forms.TextBox()
        Me.txtreward = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaction Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Transaction ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Qty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Promo"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(356, 178)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(218, 22)
        Me.txtprice.TabIndex = 17
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(356, 150)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(218, 22)
        Me.txtname.TabIndex = 16
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(356, 122)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(218, 22)
        Me.txtproductid.TabIndex = 15
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(356, 206)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(218, 22)
        Me.txtqty.TabIndex = 18
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(699, 98)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(41, 16)
        Me.lbldate.TabIndex = 21
        Me.lbldate.Text = "Date"
        '
        'lbltransactionid
        '
        Me.lbltransactionid.AutoSize = True
        Me.lbltransactionid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransactionid.Location = New System.Drawing.Point(140, 98)
        Me.lbltransactionid.Name = "lbltransactionid"
        Me.lbltransactionid.Size = New System.Drawing.Size(23, 16)
        Me.lbltransactionid.TabIndex = 20
        Me.lbltransactionid.Text = "ID"
        '
        'lblpromo
        '
        Me.lblpromo.AutoSize = True
        Me.lblpromo.Location = New System.Drawing.Point(356, 237)
        Me.lblpromo.Name = "lblpromo"
        Me.lblpromo.Size = New System.Drawing.Size(12, 16)
        Me.lblpromo.TabIndex = 22
        Me.lblpromo.Text = "-"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(35, 323)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(793, 200)
        Me.dgv.TabIndex = 23
        '
        'cmdadd
        '
        Me.cmdadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdadd.Location = New System.Drawing.Point(310, 273)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(117, 29)
        Me.cmdadd.TabIndex = 24
        Me.cmdadd.Text = "Add"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'cmdremove
        '
        Me.cmdremove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdremove.Location = New System.Drawing.Point(443, 273)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(117, 29)
        Me.cmdremove.TabIndex = 25
        Me.cmdremove.Text = "Remove"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'cmdchoose
        '
        Me.cmdchoose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdchoose.Location = New System.Drawing.Point(586, 122)
        Me.cmdchoose.Name = "cmdchoose"
        Me.cmdchoose.Size = New System.Drawing.Size(45, 22)
        Me.cmdchoose.TabIndex = 26
        Me.cmdchoose.Text = "..."
        Me.cmdchoose.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(132, 535)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(21, 24)
        Me.lbltotal.TabIndex = 27
        Me.lbltotal.Text = "0"
        '
        'cmdnext
        '
        Me.cmdnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdnext.Location = New System.Drawing.Point(711, 535)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(117, 29)
        Me.cmdnext.TabIndex = 28
        Me.cmdnext.Text = "Next >>"
        Me.cmdnext.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 535)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total : Rp."
        '
        'txtbuy
        '
        Me.txtbuy.Location = New System.Drawing.Point(623, 233)
        Me.txtbuy.Name = "txtbuy"
        Me.txtbuy.Size = New System.Drawing.Size(100, 22)
        Me.txtbuy.TabIndex = 30
        Me.txtbuy.Visible = False
        '
        'txttype
        '
        Me.txttype.Location = New System.Drawing.Point(623, 261)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(100, 22)
        Me.txttype.TabIndex = 31
        Me.txttype.Visible = False
        '
        'txtreward
        '
        Me.txtreward.Location = New System.Drawing.Point(623, 289)
        Me.txtreward.Name = "txtreward"
        Me.txtreward.Size = New System.Drawing.Size(100, 22)
        Me.txtreward.TabIndex = 32
        Me.txtreward.Visible = False
        '
        'frmTrx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 575)
        Me.Controls.Add(Me.txtreward)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtbuy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.cmdchoose)
        Me.Controls.Add(Me.cmdremove)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblpromo)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbltransactionid)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Form"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltransactionid As Label
    Friend WithEvents lblpromo As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmdadd As Button
    Friend WithEvents cmdremove As Button
    Friend WithEvents cmdchoose As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents cmdnext As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbuy As TextBox
    Friend WithEvents txttype As TextBox
    Friend WithEvents txtreward As TextBox
End Class
