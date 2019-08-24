<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewTrx
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtstart = New System.Windows.Forms.DateTimePicker()
        Me.cbfilter = New System.Windows.Forms.ComboBox()
        Me.cmdsearch = New System.Windows.Forms.Button()
        Me.dtend = New System.Windows.Forms.DateTimePicker()
        Me.dgvheader = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvdetail = New System.Windows.Forms.DataGridView()
        Me.lbltotaltransaction = New System.Windows.Forms.Label()
        Me.lbltotalprofit = New System.Windows.Forms.Label()
        CType(Me.dgvheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "View Transaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Filter"
        '
        'dtstart
        '
        Me.dtstart.Location = New System.Drawing.Point(152, 90)
        Me.dtstart.Name = "dtstart"
        Me.dtstart.Size = New System.Drawing.Size(202, 22)
        Me.dtstart.TabIndex = 14
        '
        'cbfilter
        '
        Me.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfilter.FormattingEnabled = True
        Me.cbfilter.Items.AddRange(New Object() {"All", "Member", "Non Member"})
        Me.cbfilter.Location = New System.Drawing.Point(152, 121)
        Me.cbfilter.Name = "cbfilter"
        Me.cbfilter.Size = New System.Drawing.Size(121, 24)
        Me.cbfilter.TabIndex = 16
        '
        'cmdsearch
        '
        Me.cmdsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsearch.Location = New System.Drawing.Point(279, 121)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 24)
        Me.cmdsearch.TabIndex = 17
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'dtend
        '
        Me.dtend.Location = New System.Drawing.Point(492, 89)
        Me.dtend.Name = "dtend"
        Me.dtend.Size = New System.Drawing.Size(202, 22)
        Me.dtend.TabIndex = 18
        '
        'dgvheader
        '
        Me.dgvheader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvheader.Location = New System.Drawing.Point(29, 204)
        Me.dgvheader.Name = "dgvheader"
        Me.dgvheader.ReadOnly = True
        Me.dgvheader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvheader.Size = New System.Drawing.Size(747, 150)
        Me.dgvheader.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Total Transaction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total Profit"
        '
        'dgvdetail
        '
        Me.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetail.Location = New System.Drawing.Point(29, 375)
        Me.dgvdetail.Name = "dgvdetail"
        Me.dgvdetail.ReadOnly = True
        Me.dgvdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetail.Size = New System.Drawing.Size(747, 154)
        Me.dgvdetail.TabIndex = 22
        '
        'lbltotaltransaction
        '
        Me.lbltotaltransaction.AutoSize = True
        Me.lbltotaltransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaltransaction.Location = New System.Drawing.Point(168, 174)
        Me.lbltotaltransaction.Name = "lbltotaltransaction"
        Me.lbltotaltransaction.Size = New System.Drawing.Size(40, 17)
        Me.lbltotaltransaction.TabIndex = 23
        Me.lbltotaltransaction.Text = "total"
        '
        'lbltotalprofit
        '
        Me.lbltotalprofit.AutoSize = True
        Me.lbltotalprofit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprofit.Location = New System.Drawing.Point(660, 174)
        Me.lbltotalprofit.Name = "lbltotalprofit"
        Me.lbltotalprofit.Size = New System.Drawing.Size(46, 17)
        Me.lbltotalprofit.TabIndex = 24
        Me.lbltotalprofit.Text = "profit"
        '
        'frmViewTrx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 557)
        Me.Controls.Add(Me.lbltotalprofit)
        Me.Controls.Add(Me.lbltotaltransaction)
        Me.Controls.Add(Me.dgvdetail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvheader)
        Me.Controls.Add(Me.dtend)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.cbfilter)
        Me.Controls.Add(Me.dtstart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewTrx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Transaction"
        CType(Me.dgvheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtstart As DateTimePicker
    Friend WithEvents cbfilter As ComboBox
    Friend WithEvents cmdsearch As Button
    Friend WithEvents dtend As DateTimePicker
    Friend WithEvents dgvheader As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvdetail As DataGridView
    Friend WithEvents lbltotaltransaction As Label
    Friend WithEvents lbltotalprofit As Label
End Class
