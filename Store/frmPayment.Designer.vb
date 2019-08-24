<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.txtmemberid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdcheck = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdpay = New System.Windows.Forms.Button()
        Me.txtcard = New System.Windows.Forms.TextBox()
        Me.radiocash = New System.Windows.Forms.RadioButton()
        Me.radiocard = New System.Windows.Forms.RadioButton()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.lbldiscount = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Payment Form"
        '
        'txtmemberid
        '
        Me.txtmemberid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmemberid.Location = New System.Drawing.Point(161, 82)
        Me.txtmemberid.Name = "txtmemberid"
        Me.txtmemberid.Size = New System.Drawing.Size(134, 22)
        Me.txtmemberid.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Member ID"
        '
        'cmdcheck
        '
        Me.cmdcheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcheck.Location = New System.Drawing.Point(301, 81)
        Me.cmdcheck.Name = "cmdcheck"
        Me.cmdcheck.Size = New System.Drawing.Size(75, 25)
        Me.cmdcheck.TabIndex = 25
        Me.cmdcheck.Text = "Check"
        Me.cmdcheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Payment Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Card Number"
        '
        'cmdpay
        '
        Me.cmdpay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdpay.Location = New System.Drawing.Point(161, 290)
        Me.cmdpay.Name = "cmdpay"
        Me.cmdpay.Size = New System.Drawing.Size(97, 25)
        Me.cmdpay.TabIndex = 31
        Me.cmdpay.Text = "Pay"
        Me.cmdpay.UseVisualStyleBackColor = True
        '
        'txtcard
        '
        Me.txtcard.Location = New System.Drawing.Point(161, 244)
        Me.txtcard.Name = "txtcard"
        Me.txtcard.Size = New System.Drawing.Size(201, 22)
        Me.txtcard.TabIndex = 32
        '
        'radiocash
        '
        Me.radiocash.AutoSize = True
        Me.radiocash.Location = New System.Drawing.Point(161, 217)
        Me.radiocash.Name = "radiocash"
        Me.radiocash.Size = New System.Drawing.Size(57, 20)
        Me.radiocash.TabIndex = 33
        Me.radiocash.TabStop = True
        Me.radiocash.Text = "Cash"
        Me.radiocash.UseVisualStyleBackColor = True
        '
        'radiocard
        '
        Me.radiocard.AutoSize = True
        Me.radiocard.Location = New System.Drawing.Point(238, 217)
        Me.radiocard.Name = "radiocard"
        Me.radiocard.Size = New System.Drawing.Size(55, 20)
        Me.radiocard.TabIndex = 34
        Me.radiocard.TabStop = True
        Me.radiocard.Text = "Card"
        Me.radiocard.UseVisualStyleBackColor = True
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(184, 135)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(75, 16)
        Me.lblsubtotal.TabIndex = 35
        Me.lblsubtotal.Text = "Sub Total"
        '
        'lbldiscount
        '
        Me.lbldiscount.AutoSize = True
        Me.lbldiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiscount.Location = New System.Drawing.Point(184, 163)
        Me.lbldiscount.Name = "lbldiscount"
        Me.lbldiscount.Size = New System.Drawing.Size(68, 16)
        Me.lbldiscount.TabIndex = 36
        Me.lbldiscount.Text = "Discount"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(184, 191)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(44, 16)
        Me.lbltotal.TabIndex = 37
        Me.lbltotal.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Rp."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(158, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(158, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Rp."
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 337)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbldiscount)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.radiocard)
        Me.Controls.Add(Me.radiocash)
        Me.Controls.Add(Me.txtcard)
        Me.Controls.Add(Me.cmdpay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdcheck)
        Me.Controls.Add(Me.txtmemberid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmemberid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdcheck As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdpay As Button
    Friend WithEvents txtcard As TextBox
    Friend WithEvents radiocash As RadioButton
    Friend WithEvents radiocard As RadioButton
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents lbldiscount As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
