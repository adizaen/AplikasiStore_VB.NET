<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvcustomers = New System.Windows.Forms.DataGridView()
        Me.dgvproduct = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvcustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Summary Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "3 Best Customers"
        '
        'dgvcustomers
        '
        Me.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomers.Location = New System.Drawing.Point(30, 100)
        Me.dgvcustomers.Name = "dgvcustomers"
        Me.dgvcustomers.ReadOnly = True
        Me.dgvcustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcustomers.Size = New System.Drawing.Size(478, 150)
        Me.dgvcustomers.TabIndex = 22
        '
        'dgvproduct
        '
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduct.Location = New System.Drawing.Point(30, 294)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.ReadOnly = True
        Me.dgvproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproduct.Size = New System.Drawing.Size(478, 187)
        Me.dgvproduct.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "5 Most Popular Product"
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 512)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvproduct)
        Me.Controls.Add(Me.dgvcustomers)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        CType(Me.dgvcustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvcustomers As DataGridView
    Friend WithEvents dgvproduct As DataGridView
    Friend WithEvents Label2 As Label
End Class
